using BusinessLogic;
using Models;
using RealSuite.Enums;
using RealSuite.Interfaces;
using RealSuite.Services;

namespace RealSuite.UserControls
{
    public partial class UpdatePropertyPage : UserControl, IClearable, INavigatable
    {
        private NavigationService? _navigation;
        private Property? _propertyToUpdate;
        private readonly PropertyService propertyService = new();
        private readonly SellerService sellerService = new();
        private readonly AssessmentService assessmentService = new();
        private string? _sellerName;

        public UpdatePropertyPage()
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

        public void Clear()
        {
            redigering_checkbox.Checked = false;
        }

        public void SetupPageDetails(Property property, string sellerName)
        {
            _propertyToUpdate = property;
            _sellerName = sellerName;

            PageEdit(false);

            SetupPropertyDetails();

            opdater_button.Enabled = false;

            viewSellerButton.Visible = true;
        }

        private void solgt_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (solgt_checkbox.Checked == true)
            {
                solgtdato_label.Visible = true;
                solgtdato_dateTimePicker.Visible = true;
            }
            else
            {
                solgtdato_label.Visible = false;
                solgtdato_dateTimePicker.Visible = false;
            }
        }

        private void opdater_button_Click(object sender, EventArgs e)
        {
            DateTime? soldDate = solgt_checkbox.Checked == true ? solgtdato_dateTimePicker.Value : null;

            var property = new Property(Convert.ToInt32(id_textbox.Text), vejnavn_textbox.Text, Convert.ToInt32(husnr_textbox.Text),
                Convert.ToInt32(zipcode_textbox.Text), Convert.ToInt32(byggeår_textbox.Text),
                Convert.ToInt32(kvm_textbox.Text), Convert.ToInt32(sælgerID_textbox.Text),
                Convert.ToDouble(pris_textbox.Text), Convert.ToInt32(ejendomsmæglerID_textbox.Text),
                dato_datepicker.Value, soldDate, solgt_checkbox.Checked, Convert.ToInt32(pris_textbox.Value / Convert.ToInt32(kvm_textbox.Text)));

            bool rowUpdated = propertyService.UpdateProperty(property);

            if (rowUpdated == true)
            {
                MessageBox.Show("Bolig opdateret i databasen.", "Bolig opdateret");
                Clear();
                if (_navigation?.Pages[Pages.ViewProperties] is ViewPropertiesPage page) page.RefreshFromDb();
            }
            else
            {
                MessageBox.Show("Bolig ikke opdateret i databasen.", "Fejl");
            }
        }

        private void redigering_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (redigering_checkbox.Checked)
            {
                DialogResult confirm = MessageBox.Show("Aktivér redigering?",
                    "Bekræft redigering", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (confirm == DialogResult.OK)
                {
                    CheckLabelsText("");
                    PageEdit(true);
                    viewSellerButton.Visible = false;
                }
                else if (confirm == DialogResult.Cancel)
                {
                    redigering_checkbox.Checked = false;
                }
            }
            else if (DataChanged())
            {
                DialogResult confirm =
                    MessageBox.Show(
                        "Ændringer er ikke gemt. Hvis du fortsætter, vil ændringer blive slettet. Ønsker du at fortsætte?",
                        "Ændringer ej gemt", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    SetupPageDetails(_propertyToUpdate, _sellerName);
                }
                else
                {
                    UpdateCheckBoxNoHandler(true);
                }
            }
            else
            {
                SetupPageDetails(_propertyToUpdate, _sellerName);
            }

        }

        private void SubmitKeyCheck()
        {
            if (streetname_checklabel.Text == "O" ||
                streetnumber_checklabel.Text == "O" ||
                zip_checkbox.Text == "O" ||
                buildyear_checkbox.Text == "O" ||
                squaremeter_checkbox.Text == "O" ||
                !DataChanged())
            {
                opdater_button.Enabled = false;
            }
            else
            {
                opdater_button.Enabled = true;
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

        private void addSellerButton_Click(object sender, EventArgs e)
        {
            SellerGridSetup();
            if (addSellerGrid.Visible == true) addSellerGrid.Visible = false;
            else addSellerGrid.Visible = true;
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

        private void addSellerGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                sælgerID_textbox.Text = addSellerGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                sælgernavn_textbox.Text = addSellerGrid.Rows[e.RowIndex].Cells[1].Value + " " +
                                          addSellerGrid.Rows[e.RowIndex].Cells[2].Value;
                addSellerGrid.Visible = false;
            }
            catch (Exception) { }
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

        private void vejnavn_textbox_TextChanged(object sender, EventArgs e)
        {
            if (vejnavn_textbox.Text == _propertyToUpdate.StreetName)
            {
                streetname_checklabel.Text = string.Empty;
            }
            else if (!vejnavn_textbox.Text.All(char.IsLetter) || vejnavn_textbox.Text == "")
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
            if (husnr_textbox.Text == _propertyToUpdate.StreetNumber.ToString())
            {
                streetnumber_checklabel.Text = string.Empty;
            }
            else if (!husnr_textbox.Text.All(char.IsDigit) || husnr_textbox.Text == "")
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
            if (zipcode_textbox.Text == _propertyToUpdate.ZipCode.ToString())
            {
                zip_checkbox.Text = string.Empty;
            }
            else if (!zipcode_textbox.Text.All(char.IsDigit) || zipcode_textbox.Text.Length != 4)
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
            if (byggeår_textbox.Text == _propertyToUpdate.BuildYear.ToString())
            {
                buildyear_checkbox.Text = string.Empty;
            }
            else if (!byggeår_textbox.Text.All(char.IsDigit) || byggeår_textbox.Text.Length != 4)
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
            if (kvm_textbox.Text == _propertyToUpdate.SquareMeters.ToString())
            {
                squaremeter_checkbox.Text = string.Empty;
            }
            else if (!kvm_textbox.Text.All(char.IsDigit) || kvm_textbox.Text == "")
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

        private void pris_textbox_ValueChanged(object sender, EventArgs e)
        {
            if (_propertyToUpdate != null && pris_textbox.Value != (decimal)_propertyToUpdate.Price)
                opdater_button.Enabled = true;
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
                brugVurdering_button.Visible = true;
            }
            else
            {
                MessageBox.Show("Ikke tilstrækkelig data til at foretage vurdering.", "Vurdering");
                brugVurdering_button.Visible = false;
            }
        }

        private void brugVurdering_button_Click(object sender, EventArgs e)
        {
            pris_textbox.Value = vurdering_textbox.Value;
            brugVurdering_button.Visible = false;
            pris_textbox.Focus();
        }

        private void UpdatePropertyPage_Click(object sender, EventArgs e)
        {
            if (ContainsFocus) ParentForm!.ActiveControl = null;
            addSellerGrid.Visible = false;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (DataChanged())
            {
                DialogResult confirm =
                    MessageBox.Show(
                        "Ændringer er ikke gemt. Hvis du fortsætter, vil ændringer blive slettet. Ønsker du at fortsætte?",
                        "Ændringer ej gemt", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    _navigation?.NavigateTo(Pages.ViewProperties, false);
                }
            }
            else
            {
                _navigation?.NavigateTo(Pages.ViewProperties, false);
            }
        }

        private void PageEdit(bool status)
        {
            vejnavn_textbox.Enabled = status;
            husnr_textbox.Enabled = status;
            zipcode_textbox.Enabled = status;
            byggeår_textbox.Enabled = status;
            kvm_textbox.Enabled = status;
            addSellerButton.Enabled = status;
            dato_datepicker.Enabled = status;
            solgt_checkbox.Enabled = status;
            solgtdato_dateTimePicker.Enabled = status;
            streetname_checklabel.Visible = status;
            streetnumber_checklabel.Visible = status;
            zip_checkbox.Visible = status;
            buildyear_checkbox.Visible = status;
            squaremeter_checkbox.Visible = status;
            deleteButton.Visible = status;
        }

        private bool DataChanged()
        {
            if (vejnavn_textbox.Text != _propertyToUpdate.StreetName ||
                husnr_textbox.Text != _propertyToUpdate.StreetNumber.ToString() ||
                zipcode_textbox.Text != _propertyToUpdate.ZipCode.ToString() ||
                byggeår_textbox.Text != _propertyToUpdate.BuildYear.ToString() ||
                kvm_textbox.Text != _propertyToUpdate.SquareMeters.ToString() ||
                pris_textbox.Value != (decimal)_propertyToUpdate.Price ||
                solgt_checkbox.Checked != _propertyToUpdate.Sold ||
                dato_datepicker.Value != _propertyToUpdate.DateListed ||
                sælgerID_textbox.Text != _propertyToUpdate.SellerId.ToString() ||
                sælgernavn_textbox.Text != _sellerName ||
                (solgt_checkbox.Checked == true && solgtdato_dateTimePicker.Value != _propertyToUpdate.DateSold))
            {
                return true;
            }
            return false;
        }

        private void UpdateCheckBoxNoHandler(bool status)
        {
            redigering_checkbox.CheckedChanged -= redigering_checkbox_CheckedChanged;
            redigering_checkbox.Checked = status;
            redigering_checkbox.CheckedChanged += redigering_checkbox_CheckedChanged;
        }

        private void DisableEventHandlers()
        {
            vejnavn_textbox.TextChanged -= vejnavn_textbox_TextChanged;
            husnr_textbox.TextChanged -= husnr_textbox_TextChanged;
            zipcode_textbox.TextChanged -= zipcode_textbox_TextChanged;
            byggeår_textbox.TextChanged -= byggeår_textbox_TextChanged;
            kvm_textbox.TextChanged -= kvm_textbox_TextChanged;
        }

        private void EnableEventHandlers()
        {
            vejnavn_textbox.TextChanged += vejnavn_textbox_TextChanged;
            husnr_textbox.TextChanged += husnr_textbox_TextChanged;
            zipcode_textbox.TextChanged += zipcode_textbox_TextChanged;
            byggeår_textbox.TextChanged += byggeår_textbox_TextChanged;
            kvm_textbox.TextChanged += kvm_textbox_TextChanged;
        }

        private void CheckLabelsText(string text)
        {
            streetname_checklabel.Text = text;
            streetnumber_checklabel.Text = text;
            zip_checkbox.Text = text;
            buildyear_checkbox.Text = text;
            squaremeter_checkbox.Text = text;
        }

        private void fortrydButton_Click(object sender, EventArgs e)
        {
            SetupPropertyDetails();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SetupPropertyDetails();

            DialogResult answer = MessageBox.Show(
                $"""
                 Dette vil slette ejendommen: {_propertyToUpdate.StreetName} {_propertyToUpdate.StreetNumber}.
                 Denne handling kan ikke fortrydes. Ønsker du at fortsætte?
                 """,
                "Sletning af ejendom", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (answer == DialogResult.Yes)
            {
                var propertyDeleted = propertyService.DeleteProperty(_propertyToUpdate.Id);

                if (propertyDeleted)
                {
                    MessageBox.Show($"Ejendom slettet: {_propertyToUpdate.StreetName}{_propertyToUpdate.StreetNumber}",
                        "Slettelse af ejendom", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (_navigation?.Pages[Pages.ViewProperties] is ViewPropertiesPage viewPropertiesPage) viewPropertiesPage.RefreshFromDb();
                    _navigation?.NavigateTo(Pages.ViewProperties);
                }
                else
                {
                    MessageBox.Show("Noget gik galt under sletning af sælger. Prøv igen senere.",
                        "Fejl under slettelse", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SetupPropertyDetails()
        {
            if (_propertyToUpdate != null)
            {

                id_textbox.Text = _propertyToUpdate.Id.ToString();
                vejnavn_textbox.Text = _propertyToUpdate.StreetName;
                husnr_textbox.Text = _propertyToUpdate.StreetNumber.ToString();
                zipcode_textbox.Text = _propertyToUpdate.ZipCode.ToString();
                byggeår_textbox.Text = _propertyToUpdate.BuildYear.ToString();
                kvm_textbox.Text = _propertyToUpdate.SquareMeters.ToString();
                sælgerID_textbox.Text = _propertyToUpdate.SellerId.ToString();
                sælgernavn_textbox.Text = _sellerName;
                pris_textbox.Value = Convert.ToInt32(_propertyToUpdate.Price);
                ejendomsmæglerID_textbox.Text = "1000";
                ejendomsmægler_textbox.Text = "Maria Thodegaard";
                dato_datepicker.Value = _propertyToUpdate.DateListed;
                solgt_checkbox.Checked = _propertyToUpdate.Sold;
                vurdering_textbox.Text = string.Empty;
                brugVurdering_button.Visible = false;

                if (_propertyToUpdate.DateSold == null)
                {
                    solgtdato_dateTimePicker.Value = DateTime.Now;
                }
                else
                {
                    solgtdato_dateTimePicker.Value = (DateTime)_propertyToUpdate.DateSold;
                }
            }

            CheckLabelsText("");
        }

        private void viewSellerButton_Click(object sender, EventArgs e)
        {
            var seller = sellerService.GetSellerFromProperty(_propertyToUpdate);

            if (_navigation?.Pages[Pages.UpdateSeller] is UpdateSellerPage page)
            {
                page.SellerToUpdate = seller;
                page.SetupPage();
                _navigation.NavigateTo(Pages.UpdateSeller);
            }
        }
    }
}
