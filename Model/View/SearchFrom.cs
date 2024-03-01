using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace View
{

    public partial class SearchFrom : Form
    {
        private List<ElectricalElement> _electricalElementList;
        private List<ElectricalElement> searchElectricalElementList;
        private List<int> indexForDeleteElementList;
        public delegate void UnclockControlsDelegate();
        private UnclockControlsDelegate _unclockControls;
        public delegate void UpdateDataSearch(List<ElectricalElement> List);
        UpdateDataSearch _updateDataGridView;
        public delegate void SetProcessSearchElement(List<int> indexForDeleteElement);
        SetProcessSearchElement _setProcessSearchElement;

        public SearchFrom(UnclockControlsDelegate unclockControls, UpdateDataSearch updateDataGridView, List<ElectricalElement> electricalElementList, SetProcessSearchElement setProcessSearchElement, MainForm mainForm)
        {
            InitializeComponent();
            mainForm.ElectricalElementListUpdated += MainForm_ElectricalElementListUpdated;
            _electricalElementList = electricalElementList;
            _unclockControls = unclockControls;
            _updateDataGridView = updateDataGridView;
            _setProcessSearchElement = setProcessSearchElement;
        }

        private void MainForm_ElectricalElementListUpdated(List<ElectricalElement> elementList)
        {
            _electricalElementList = elementList;
        }

        private void ButtonSearchElementSearchForm_Click(object sender, EventArgs e)
        {
            searchElectricalElementList = new List<ElectricalElement>();
            indexForDeleteElementList = new List<int>();
            double valueForSearchElectricalElement = 0;
            Complex complexValueForSearch = new Complex();

            try
            {
                valueForSearchElectricalElement = Double.Parse(TextBoxValueSearchForm.Text.Replace(".", ","));
            }
            catch (FormatException)
            {
                valueForSearchElectricalElement = 0;
            }

            switch (ComboBoxNameSearchForm.Text)
            {
                case "Резистор":
                    complexValueForSearch = new Complex(valueForSearchElectricalElement, 0);
                    break;
                case "Кондесатор":
                case "Катушка идуктивности":
                    complexValueForSearch = new Complex(0, valueForSearchElectricalElement);
                    break;
            }

            foreach (ElectricalElement element in _electricalElementList)
            {
                if (element.ElectricalElementName == ComboBoxNameSearchForm.Text && string.IsNullOrEmpty(TextBoxValueSearchForm.Text))
                {
                    searchElectricalElementList.Add(element);
                    indexForDeleteElementList.Add(_electricalElementList.IndexOf(element));
                    Console.WriteLine(_electricalElementList.IndexOf(element));
                }

                if (element.ElectricalElementName == ComboBoxNameSearchForm.Text && element.ElectricalElementValue.Value == complexValueForSearch)
                {
                    searchElectricalElementList.Add(element);
                    indexForDeleteElementList.Add(_electricalElementList.IndexOf(element));
                    Console.WriteLine(_electricalElementList.IndexOf(element));
                }
            }

            _updateDataGridView(searchElectricalElementList);
            _setProcessSearchElement(indexForDeleteElementList);
        }

        private void ButtonCancelSearchForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchFrom_FormClosed(object sender, FormClosedEventArgs e)
        {
            _unclockControls();
            _updateDataGridView(_electricalElementList);
        }

    }
}
