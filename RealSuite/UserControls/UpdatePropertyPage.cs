using BusinessLogic;
using Models;
using RealSuite.Interfaces;
using RealSuite.Services;

namespace RealSuite.UserControls
{
    public partial class UpdatePropertyPage : UserControl, IClearable
    {
        private readonly NavigationService _navigation;
        public Property? UpdateProperty;
        private PropertyService propertyService = new PropertyService();
        private SellerService sellerService = new SellerService();

        public UpdatePropertyPage(NavigationService navigation)
        {
            InitializeComponent();
            _navigation = navigation;
            addSellerGrid.Visible = false;
            pris_textbox.Controls[0].Hide();
            vurdering_textbox.Controls[0].Hide();
        }

        public void Clear()
        {

        }


        public void SetupPageDetails()
        {
            if (UpdateProperty != null)
            {
                id_textbox.Text = UpdateProperty.Id.ToString();
                vejnavn_textbox.Text = UpdateProperty.StreetName;
                husnr_textbox.Text = UpdateProperty.StreetNumber.ToString();
                zipcode_textbox.Text = UpdateProperty.ZipCode.ToString();
                byggeår_textbox.Text = UpdateProperty.BuildYear.ToString();
                kvm_textbox.Text = UpdateProperty.SquareMeters.ToString();
                sælgerID_textbox.Text = UpdateProperty.SellerId.ToString();
                pris_textbox.Value = Convert.ToInt32(UpdateProperty.Price);
                ejendomsmæglerID_textbox.Text = "1000";
                ejendomsmægler_textbox.Text = "Maria Thodegaard";
                dato_datepicker.Value = UpdateProperty.DateListed;
                solgt_checkbox.Checked = UpdateProperty.Sold;

                if (UpdateProperty.DateSold == null)
                {
                    solgtdato_dateTimePicker.Value = DateTime.Now;
                }
                else
                {
                    solgtdato_dateTimePicker.Value = (DateTime)UpdateProperty.DateSold;
                }

            }
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
            var property = new Property(Convert.ToInt32(id_textbox.Text), vejnavn_textbox.Text, Convert.ToInt32(husnr_textbox.Text),
                Convert.ToInt32(zipcode_textbox.Text), Convert.ToInt32(byggeår_textbox.Text),
                Convert.ToInt32(kvm_textbox.Text), Convert.ToInt32(sælgerID_textbox.Text),
                Convert.ToDouble(pris_textbox.Text), Convert.ToInt32(ejendomsmæglerID_textbox.Text),
                dato_datepicker.Value, solgtdato_dateTimePicker.Value, solgt_checkbox.Checked, Convert.ToInt32(pris_textbox.Value / Convert.ToInt32(kvm_textbox.Text)));

            bool rowUpdated = propertyService.UpdateProperty(property);

            if (rowUpdated == true)
            {
                MessageBox.Show("Bolig opdateret i databasen.", "Bolig opdateret");
                Clear();
            }
            else
            {
                MessageBox.Show("Bolig ikke opdateret i databasen.", "Fejl");
            }
        }

        private void redigering_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (redigering_checkbox.Checked == true)
            {
                DialogResult confirm = MessageBox.Show("Aktivér redigering?",
                    "Bekræft redigering", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (confirm == DialogResult.OK)
                {
                    vejnavn_textbox.Enabled = true;
                    husnr_textbox.Enabled = true;
                    zipcode_textbox.Enabled = true;
                    byggeår_textbox.Enabled = true;
                    kvm_textbox.Enabled = true;
                    addSellerButton.Enabled = true;
                    dato_datepicker.Enabled = true;
                    solgt_checkbox.Enabled = true;
                    solgtdato_dateTimePicker.Enabled = true;

                    streetname_checklabel.Visible = true;
                    streetnumber_checklabel.Visible = true;
                    zip_checkbox.Visible = true;
                    buildyear_checkbox.Visible = true;
                    squaremeter_checkbox.Visible = true;
                    seller_checkbox.Visible = true;
                    price_checkbox.Visible = true;

                }
                else
                {
                    redigering_checkbox.Checked = false;
                }
            }
            else
            {
                vejnavn_textbox.Enabled = false;
                husnr_textbox.Enabled = false;
                zipcode_textbox.Enabled = false;
                byggeår_textbox.Enabled = false;
                kvm_textbox.Enabled = false;
                addSellerButton.Enabled = false;
                dato_datepicker.Enabled = false;
                solgt_checkbox.Enabled = false;
                solgtdato_dateTimePicker.Enabled = false;
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
                opdater_button.Enabled = true;
            }
            else
            {
                opdater_button.Enabled = false;
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
            addSellerGrid.Columns[0].HeaderText = "Kunde ID";
            addSellerGrid.Columns[1].HeaderText = "Fornavn";
            addSellerGrid.Columns[2].HeaderText = "Efternavn";
            addSellerGrid.Columns[3].Visible = false;
            addSellerGrid.Columns[4].Visible = false;
            addSellerGrid.Columns[5].Visible = false;
            addSellerGrid.Columns[6].Visible = false;
            addSellerGrid.Columns[7].HeaderText = "Telefon";
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
            catch (Exception)
            {
            }
        }

        private void vejnavn_textbox_TextChanged(object sender, EventArgs e)
        {
            if (!vejnavn_textbox.Text.All(char.IsLetter) || vejnavn_textbox.Text == "")
            {
                streetname_checklabel.Text = "O";
                streetname_checklabel.ForeColor = Color.Red;
            }
            else
            {
                streetname_checklabel.Text = "P";
                streetname_checklabel.ForeColor = Color.Green;
            }
            SubmitKeyCheck();
        }

        private void husnr_textbox_TextChanged(object sender, EventArgs e)
        {
            if (!husnr_textbox.Text.All(char.IsDigit) || husnr_textbox.Text == "")
            {
                streetnumber_checklabel.Text = "O";
                streetnumber_checklabel.ForeColor = Color.Red;
            }
            else
            {
                streetnumber_checklabel.Text = "P";
                streetnumber_checklabel.ForeColor = Color.Green;
            }
            SubmitKeyCheck();
        }

        private void zipcode_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void byggeår_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void kvm_textbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void pris_textbox_ValueChanged(object sender, EventArgs e)
        {
            if (UpdateProperty != null && pris_textbox.Value != (decimal)UpdateProperty.Price)
                opdater_button.Enabled = true;
        }
    }
}
