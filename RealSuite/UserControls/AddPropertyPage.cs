using BusinessLogic;
using Models.DTOModels;
using RealSuite.Interfaces;

namespace RealSuite.UserControls
{
    public partial class AddPropertyPage : UserControl, IClearable
    {
        private SellerService sellerService = new SellerService();
        private PropertyService propertyService = new PropertyService();

        public AddPropertyPage()
        {
            InitializeComponent();
            SellerGridSetup();
            tilføjsælger_button.Enabled = false;

        }

        private void addSellerButton_Click(object sender, EventArgs e)
        {
            if (addSellerGrid.Visible == true) addSellerGrid.Visible = false;
            else addSellerGrid.Visible = true;
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


        public void Clear()
        {
            foreach (TextBox item in Controls)
            {
                item.Text = "";
            }
        }

        private void tilføjsælger_button_Click(object sender, EventArgs e)
        {
            var propertyDTO = new PropertyDTO(vejnavn_textbox.Text, Convert.ToInt32(husnr_textbox.Text),
                Convert.ToInt32(zipcode_textbox.Text), Convert.ToInt32(byggeår_textbox.Text),
                Convert.ToInt32(kvm_textbox.Text), Convert.ToInt32(sælgerID_textbox.Text),
                Convert.ToDouble(pris_textbox.Text), Convert.ToInt32(ejendomsmægler_textbox.Text),
                dato_datepicker.Value, solgt_checkbox.Checked);

            bool rowCreated = propertyService.CreateProperty(propertyDTO);

            if (rowCreated == true)
            {
                MessageBox.Show("Bolig oprettet i databasen.", "Bolig oprettet");
                Clear();
            }
            else
            {
                MessageBox.Show("Bolig ikke oprettet i database", "Fejl under oprettelse");
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
            if (!zipcode_textbox.Text.All(char.IsDigit) || zipcode_textbox.Text.Length != 4)
            {
                zip_checkbox.Text = "O";
                zip_checkbox.ForeColor = Color.Red;
            }
            else
            {
                zip_checkbox.Text = "P";
                zip_checkbox.ForeColor = Color.Green;
            }
            SubmitKeyCheck();
        }

        private void byggeår_textbox_TextChanged(object sender, EventArgs e)
        {
            if (!byggeår_textbox.Text.All(char.IsDigit) || byggeår_textbox.Text.Length != 4)
            {
                buildyear_checkbox.Text = "O";
                buildyear_checkbox.ForeColor = Color.Red;
            }
            else
            {
                buildyear_checkbox.Text = "P";
                buildyear_checkbox.ForeColor = Color.Green;
            }
            SubmitKeyCheck();
        }

        private void kvm_textbox_TextChanged(object sender, EventArgs e)
        {
            if (!kvm_textbox.Text.All(char.IsDigit))
            {
                squaremeter_checkbox.Text = "O";
                squaremeter_checkbox.ForeColor = Color.Red;
            }
            else
            {
                squaremeter_checkbox.Text = "P";
                squaremeter_checkbox.ForeColor = Color.Green;
            }
            SubmitKeyCheck();
        }

        private void sælger_textbox_TextChanged(object sender, EventArgs e)
        {
            if (sælgerID_textbox.Text == "")
            {
                seller_checkbox.Text = "O";
                seller_checkbox.ForeColor = Color.Red;
            }
            else
            {
                seller_checkbox.Text = "P";
                seller_checkbox.ForeColor = Color.Green;
            }
        }

        private void pris_textbox_TextChanged(object sender, EventArgs e)
        {
            if (!pris_textbox.Text.All(char.IsDigit) || pris_textbox.Text == "")
            {
                price_checkbox.Text = "O";
                price_checkbox.ForeColor = Color.Red;
            }
            else
            {
                price_checkbox.Text = "P";
                price_checkbox.ForeColor = Color.Green;
            }
            SubmitKeyCheck();
        }

        private void ejendomsmægler_textbox_TextChanged(object sender, EventArgs e)
        {

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
                tilføjsælger_button.Enabled = true;
            }
            else
            {
                tilføjsælger_button.Enabled = false;
            }
        }


        private void SellerGridSetup()
        {
            addSellerGrid.Visible = false;
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
    }
}
