﻿using BusinessLogic;
using Models;
using Models.DTOModels;
using RealSuite.Enums;
using RealSuite.Interfaces;
using RealSuite.Services;

namespace RealSuite.UserControls
{
    public partial class AddPropertyPage : UserControl, IClearable, INavigatable
    {
        private SellerService sellerService = new SellerService();
        private PropertyService propertyService = new PropertyService();
        private NavigationService? _navigation;
        private AssessmentService assessmentService = new AssessmentService();

        public AddPropertyPage()
        {
            InitializeComponent();
            addSellerGrid.Visible = false;
            pris_textbox.Controls[0].Hide();
            vurdering_textbox.Controls[0].Hide();
        }

        public void SetNavigation(NavigationService navigation)
        {
            _navigation = navigation;
        }

        private void addSellerButton_Click(object sender, EventArgs e)
        {
            SellerGridSetup();
            if (addSellerGrid.Visible == true) addSellerGrid.Visible = false;
            else addSellerGrid.Visible = true;
        }

        private void addSellerGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            sælgerID_textbox.Text = addSellerGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            sælgernavn_textbox.Text = addSellerGrid.Rows[e.RowIndex].Cells[1].Value + " " +
                                      addSellerGrid.Rows[e.RowIndex].Cells[2].Value;
            addSellerGrid.Visible = false;
        }

        public void Clear()
        {
            pris_textbox.Value = 0;
            vurdering_textbox.Value = 0;

            ClearTextBoxes(this);

            streetname_checklabel.Visible = false;
            streetnumber_checklabel.Visible = false;
            zip_checkbox.Visible = false;
            buildyear_checkbox.Visible = false;
            squaremeter_checkbox.Visible = false;
            seller_checkbox.Visible = false;
            price_checkbox.Visible = false;
            addSellerGrid.Hide();
            ejendomsmæglerID_textbox.Text = "1000";
            ejendomsmægler_textbox.Text = "Maria Thodegaard";
        }

        private void tilføjbolig_button_Click(object sender, EventArgs e)
        {
            var propertyDTO = new PropertyDTO(vejnavn_textbox.Text, Convert.ToInt32(husnr_textbox.Text),
                Convert.ToInt32(zipcode_textbox.Text), Convert.ToInt32(byggeår_textbox.Text),
                Convert.ToInt32(kvm_textbox.Text), Convert.ToInt32(sælgerID_textbox.Text),
                Convert.ToDouble(pris_textbox.Text), Convert.ToInt32(ejendomsmæglerID_textbox.Text),
                dato_datepicker.Value, solgt_checkbox.Checked ? solgtdato_dateTimePicker.Value : null, solgt_checkbox.Checked);

            bool rowCreated = propertyService.CreateProperty(propertyDTO);

            if (rowCreated == true)
            {
                MessageBox.Show("Bolig oprettet i databasen.", "Bolig oprettet");
                Clear();
                if (_navigation?.Pages[Pages.ViewProperties] is ViewPropertiesPage page) page.RefreshFromDb();
            }
            else
            {
                MessageBox.Show("Bolig ikke oprettet i database", "Fejl under oprettelse");
            }
        }

        private void vejnavn_textbox_TextChanged(object sender, EventArgs e)
        {
            streetname_checklabel.Visible = true;

            if (!vejnavn_textbox.Text.All(char.IsLetter) || vejnavn_textbox.Text == "")
            {
                streetname_checklabel.Text = "O";
                streetname_checklabel.ForeColor = Color.Red;
            }
            else
            {
                streetname_checklabel.Text = "P";
                streetname_checklabel.ForeColor = Color.LightGreen;
            }
            SubmitKeyCheck();
        }

        private void husnr_textbox_TextChanged(object sender, EventArgs e)
        {
            streetnumber_checklabel.Visible = true;
            if (!husnr_textbox.Text.All(char.IsDigit) || husnr_textbox.Text == "")
            {
                streetnumber_checklabel.Text = "O";
                streetnumber_checklabel.ForeColor = Color.Red;
            }
            else
            {
                streetnumber_checklabel.Text = "P";
                streetnumber_checklabel.ForeColor = Color.LightGreen;
            }
            SubmitKeyCheck();
        }

        private void zipcode_textbox_TextChanged(object sender, EventArgs e)
        {
            zip_checkbox.Visible = true;
            if (!zipcode_textbox.Text.All(char.IsDigit) || zipcode_textbox.Text.Length != 4)
            {
                zip_checkbox.Text = "O";
                zip_checkbox.ForeColor = Color.Red;
            }
            else
            {
                zip_checkbox.Text = "P";
                zip_checkbox.ForeColor = Color.LightGreen;
            }
            SubmitKeyCheck();
            GetAssessment();
        }

        private void byggeår_textbox_TextChanged(object sender, EventArgs e)
        {
            buildyear_checkbox.Visible = true;
            if (!byggeår_textbox.Text.All(char.IsDigit) || byggeår_textbox.Text.Length != 4)
            {
                buildyear_checkbox.Text = "O";
                buildyear_checkbox.ForeColor = Color.Red;
            }
            else
            {
                buildyear_checkbox.Text = "P";
                buildyear_checkbox.ForeColor = Color.LightGreen;
            }
            SubmitKeyCheck();
            GetAssessment();
        }

        private void kvm_textbox_TextChanged(object sender, EventArgs e)
        {
            squaremeter_checkbox.Visible = true;
            if (!kvm_textbox.Text.All(char.IsDigit) || kvm_textbox.Text == "")
            {
                squaremeter_checkbox.Text = "O";
                squaremeter_checkbox.ForeColor = Color.Red;
            }
            else
            {
                squaremeter_checkbox.Text = "P";
                squaremeter_checkbox.ForeColor = Color.LightGreen;
            }
            SubmitKeyCheck();
            GetAssessment();
        }

        private void sælger_textbox_TextChanged(object sender, EventArgs e)
        {
            seller_checkbox.Visible = true;
            if (sælgerID_textbox.Text == "")
            {
                seller_checkbox.Text = "O";
                seller_checkbox.ForeColor = Color.Red;
            }
            else
            {
                seller_checkbox.Text = "P";
                seller_checkbox.ForeColor = Color.LightGreen;
            }
        }

        private void HandleDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow only digits and control keys (like backspace) 
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; //Suppress non-digit input
            }
        }
        private void HandleLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow only digits and control keys (like backspace) 
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; //Suppress non-digit input
            }
        }

        private void SubmitKeyCheck()
        {
            if (streetname_checklabel.Text == "P" &&
                streetnumber_checklabel.Text == "P" &&
                zip_checkbox.Text == "P" &&
                buildyear_checkbox.Text == "P" &&
                squaremeter_checkbox.Text == "P" &&
                price_checkbox.Text == "P")
            {
                tilføjbolig_button.Enabled = true;
            }
            else
            {
                tilføjbolig_button.Enabled = false;
            }
        }

        private void SellerGridSetup()
        {
            var sellerDataTable = sellerService.GetSellers();
            addSellerGrid.DataSource = sellerDataTable;
            addSellerGrid.Columns["Id"].HeaderText = "ID";
            addSellerGrid.Columns["FirstName"].HeaderText = "Fornavn";
            addSellerGrid.Columns["LastName"].HeaderText = "Efternavn";
            addSellerGrid.Columns["CprNumber"].Visible = false;
            addSellerGrid.Columns["StreetName"].Visible = false;
            addSellerGrid.Columns["StreetNumber"].Visible = false;
            addSellerGrid.Columns["ZipCode"].Visible = false;
            addSellerGrid.Columns["PhoneNumber"].HeaderText = "Telefon";
        }

        private void pris_textbox_ValueChanged(object sender, EventArgs e)
        {
            price_checkbox.Visible = true;
            if (pris_textbox.Value == 0)
            {
                price_checkbox.Text = "O";
                price_checkbox.ForeColor = Color.Red;
            }
            else
            {
                price_checkbox.Text = "P";
                price_checkbox.ForeColor = Color.LightGreen;
            }
            SubmitKeyCheck();
        }

        private void solgt_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (solgt_checkbox.Checked == true)
            {
                solgtdato_label.Visible = true;
                solgtdato_dateTimePicker.Visible = true;
                propertyForSaleLabel.Visible = false;
            }
            else
            {
                solgtdato_label.Visible = false;
                solgtdato_dateTimePicker.Visible = false;
                propertyForSaleLabel.Visible = true;
            }
        }

        private void GetAssessment()
        {
            if (buildyear_checkbox.Text != "O" &&
                squaremeter_checkbox.Text != "O" &&
                zip_checkbox.Text != "O")
            {
                vurdering_button.Enabled = true;
            }
            else
            {
                vurdering_button.Enabled = false;
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            Clear();
            vejnavn_textbox.Focus();
            addSellerGrid.Hide();
        }

        private void vurdering_button_Click(object sender, EventArgs e)
        {
            var priceAssessment = new PriceAssessment(
                Convert.ToInt32(zipcode_textbox.Text),
                Convert.ToInt32(byggeår_textbox.Text),
                Convert.ToInt32(kvm_textbox.Text));

            var assessedPrice = assessmentService.GetAssessment(priceAssessment);

            if (assessedPrice > 0)
            {
                vurdering_textbox.Text = assessedPrice.ToString();
                vurdering_button.Visible = false;
                useAssessment_button.Visible = true;
                useAssessment_button.Enabled = true;
            }
            else MessageBox.Show("Ikke tilstrækkelig data til at foretage vurdering.", "Vurdering");
        }

        private void ClearTextBoxes(Control control)
        {
            foreach (Control currentControl in control.Controls)
            {
                if (currentControl is Panel)
                {
                    ClearTextBoxes(currentControl);
                }

                if (currentControl is TextBox)
                {
                    TextBox currentTextBox = currentControl as TextBox;
                    currentTextBox.Text = string.Empty;
                }
            }
        }

        private void AddPropertyPage_Click(object sender, EventArgs e)
        {
            if (ContainsFocus) ParentForm!.ActiveControl = null;
        }

        private void useAssessment_button_Click(object sender, EventArgs e)
        {
            pris_textbox.Value = vurdering_textbox.Value;
            useAssessment_button.Visible = false;
            vurdering_button.Visible = true;
            pris_textbox.Focus();
        }
    }
}
