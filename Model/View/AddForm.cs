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
using Model;

namespace View
{
    public partial class AddForm : Form
    {
        private List<ElectricalElement> _electricalElementList;
        
        public delegate void UnclockControlsDelegate();
        private UnclockControlsDelegate _unclockControls;

        public delegate void UpdateDateGridView(List<ElectricalElement> List);
        public UpdateDateGridView _updateDataGridView;

        private double valueElectricalElement = 0;

        private ElectricalElementBase ElectricalElement;
        private Complex complexValueElectricalElement = 0;
        private int multiplier = 0;

        public AddForm(UnclockControlsDelegate unclockControls, 
                       UpdateDateGridView updateDateGridView, 
                       List<ElectricalElement> electricalElementList,
                       MainForm mainForm)
        {
            InitializeComponent();
            mainForm.ElectricalElementListUpdated += MainForm_ElectricalElementListUpdated;

            #if !DEBUG 
                ButtonRandomValueAddForm.Visible = false; 
                this.Size = new Size(Width, Height-40);
            #endif

            _electricalElementList = electricalElementList;
            _unclockControls = unclockControls;
            _updateDataGridView = updateDateGridView;
        }


        private void MainForm_ElectricalElementListUpdated( List<ElectricalElement> elementList)
        {
            _electricalElementList = elementList;
        }

        private void ComboBoxNameAddForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboBoxNameAddForm.SelectedIndex)
            {
                case 0://"Резистор":
                    ElectricalElement = new Resistor();
                    break;
                case 1:// "Кондесатор":
                    ElectricalElement = new Capacitor();
                    break;
                case 2://"Катушка идуктивности":
                    ElectricalElement = new Inductor();
                    break;
            }

            switch (ComboBoxNameAddForm.SelectedIndex)
            {
                case 0:
                    radioButton1.Text = "Ом";
                    radioButton2.Text = "кОм";
                    radioButton3.Text = "МОм";
                    break;
                case 1:
                    radioButton1.Text = "пФ";
                    radioButton2.Text = "нФ";
                    radioButton3.Text = "мкФ";
                    break;
                case 2:
                    radioButton1.Text = "мкГн";
                    radioButton2.Text = "мГн";
                    radioButton3.Text = "Гн";
                    break;
            }
            IsValid();
            groupBox1.Visible = true;
        }
        
        private void TextBoxValueAddForm_TextChanged(object sender, EventArgs e)
        {
            IsValid();
        }

        private void ButtonAddElementAddForm_Click(object sender, EventArgs e)
        { 
        ComplexXml complexXml = new ComplexXml();
            try
            {
                if (radioButton1.Checked)
                { multiplier = 0; }
                if (radioButton2.Checked)
                { multiplier = 1; }
                if (radioButton3.Checked)
                { multiplier = 2; }

                ElectricalElement.Multiplier = multiplier;
                complexXml.Value = ElectricalElement.CalculateImpedance(valueElectricalElement);
                _electricalElementList.Add(new ElectricalElement
                {
                    ElectricalElementName = ComboBoxNameAddForm.Text,
                    ElectricalElementValue = complexXml
                });


                _updateDataGridView(_electricalElementList);
                ComboBoxNameAddForm.Text = null;
                TextBoxValueAddForm.Text = string.Empty;
                radioButton1.Checked = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonCancelAddForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _updateDataGridView(_electricalElementList);
            _unclockControls();
        }

        //Провека на валидность введенных данных
        private void IsValid()
        {
                try
                {
                    string valueElement = TextBoxValueAddForm.Text.Replace(".", ",");

                    if (valueElement == null)
                    {
                        throw new ArgumentException(ComboBoxNameAddForm.Text + " не может быть null");
                    }
                    if (!double.TryParse(valueElement.ToString(), out valueElectricalElement))
                    {
                        throw new ArgumentException(ComboBoxNameAddForm.Text + " должно быть числом");
                    }
                    if (ComboBoxNameAddForm.Text == string.Empty)
                    {
                        throw new ArgumentException("Не выбран элемент");
                    }

                    ButtonAddElementAddForm.Enabled = true;
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    ButtonAddElementAddForm.Enabled = false;
                }
        }

        private void ButtonRandomValueAddForm_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, ComboBoxNameAddForm.Items.Count);
            ComboBoxNameAddForm.SelectedIndex = randomNumber;
            switch(random.Next(0, 3))
            {
                case 0:
                    radioButton1.Checked = true;
                    ElectricalElement.Multiplier = 0;
                    break;
                case 1:
                    radioButton2.Checked = true;
                    ElectricalElement.Multiplier = 1;
                    break;
                case 2:
                    radioButton3.Checked = true;
                    ElectricalElement.Multiplier = 2;
                    break;                
            }
            switch (randomNumber)
            {
                case 0:
                    TextBoxValueAddForm.Text = random.Next(1, 10).ToString();
                    break;
                case 1:
                    TextBoxValueAddForm.Text = random.Next(1, 10000).ToString();
                    break;
                case 2:
                    TextBoxValueAddForm.Text = random.Next(1, 10).ToString();
                    break;
            }
        }
        
        
    }
}
