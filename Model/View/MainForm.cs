using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Numerics;
using Model;

namespace View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public delegate void ElementsListUpdateEventHandler(List<ElectricalElement> elementsList);
        public event ElementsListUpdateEventHandler ElectricalElementListUpdated;
        private List<ElectricalElement> _electricalElementList = new List<ElectricalElement>(); 
        private List<ElectricalElement> _searchElectricalElementList = new List<ElectricalElement>();
        private List<int> _indexForDeleteElementList;
        private bool ProcessSearchElement;

        private void ButtonAddElementMainForm_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm( UnclockControls, UpdateDateGridView, _electricalElementList, this);
            addForm.Show();
            ButtonAddElementMainForm.Enabled = false;
        }

        private void ButtonRemoveElementMainForm_Click(object sender, EventArgs e)
        {
            if (DataGridViewMainForm.RowCount != 0)
            {
                int _indexForDeleteElement;
                int selectedIndexDataGridView = DataGridViewMainForm.CurrentCell.RowIndex;
                Console.WriteLine(selectedIndexDataGridView);
                if (ProcessSearchElement)
                {
                    _indexForDeleteElement = _indexForDeleteElementList[DataGridViewMainForm.CurrentCell.RowIndex];
                }
                else
                {
                    _indexForDeleteElement = selectedIndexDataGridView;
                }
                _electricalElementList.RemoveAt(_indexForDeleteElement); //удаляем элемент из осного списка
                UpdateDateGridView(_electricalElementList);
            }
        }

        private void ButtonSearchMainForm_Click(object sender, EventArgs e)
        {
            SearchFrom searchForm = new SearchFrom(UnclockControls, UpdateDateGridView, _electricalElementList, SetProcessSearchElement, this);
            searchForm.Show();
            ButtonSearchMainForm.Enabled = false;
        }

        private void SetProcessSearchElement(List<int> indexForDeleteElementList)
        {
            ProcessSearchElement = true; //активирует режим поиска
            _indexForDeleteElementList = indexForDeleteElementList;
        }

        private void UpdateDateGridView(List<ElectricalElement> List)
        {
            ProcessSearchElement = false;

            DataGridViewMainForm.DataSource = null;
            DataGridViewMainForm.DataSource = List;

            DataGridViewMainForm.Columns[2].Visible = false;
            DataGridViewMainForm.Columns[0].HeaderText = "Название элемента";
            DataGridViewMainForm.Columns[1].HeaderText = "Комплексное значение";
            DataGridViewMainForm.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewMainForm.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewMainForm.ClearSelection();
        }

        public void UnclockControls()
        {
            ButtonAddElementMainForm.Enabled = true;
            ButtonSearchMainForm.Enabled = true;
        }

        private string _path;

        private void SaveButtonMainForm_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.Filter = "Electric *.elc|*.elc";
            saveDialog.FilterIndex = 1;

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                _path = saveDialog.FileName;
                var writer = new System.Xml.Serialization.XmlSerializer(typeof(List<ElectricalElement>));
                using (var file = System.IO.File.Create(_path))
                {
                    writer.Serialize(file, _electricalElementList);
                    file.Close();
                }
            }
            saveDialog.Dispose();
        }

        private void ButtonLoadMainForm_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                _path = openDialog.FileName;
                var reader = new System.Xml.Serialization.XmlSerializer(typeof(List<ElectricalElement>));
                var file = new System.IO.StreamReader(_path);
                _electricalElementList = (List<ElectricalElement>)reader.Deserialize(file);

                UpdateDateGridView(_electricalElementList);
                ElectricalElementListUpdated.Invoke(_electricalElementList);
            }
         }


        

    }
}
