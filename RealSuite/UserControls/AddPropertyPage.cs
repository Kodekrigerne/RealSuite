using BusinessLogic;
using Models.DTOModels;
using RealSuite.Interfaces;

namespace RealSuite.UserControls
{
    public partial class AddPropertyPage : UserControl, IClearable
    {
        private PropertyService propertyService = new PropertyService();

        public AddPropertyPage()
        {
            InitializeComponent();
        }

        public void Clear() { }

        private void tilføjsælger_button_Click(object sender, EventArgs e)
        {
            var propertyDTO = new PropertyDTO(vejnavn_textbox.Text, Convert.ToInt32(husnr_textbox.Text),
                Convert.ToInt32(zipcode_textbox.Text), Convert.ToInt32(byggeår_textbox.Text),
                Convert.ToInt32(kvm_textbox.Text), Convert.ToInt32(sælger_textbox.Text),
                Convert.ToDouble(pris_textbox.Text), Convert.ToDouble(vurdering_textbox.Text), Convert.ToInt32(ejendomsmægler_textbox.Text),
                dato_datepicker.Value, solgt_checkbox.Checked);

            bool rowCreated = propertyService.CreateProperty(propertyDTO);

            if (rowCreated == true)
            {
                MessageBox.Show("Bolig oprettet i databasen.", "Bolig oprettet");
            }
            else
            {
                MessageBox.Show("Bolig ikke oprettet i database", "Fejl under oprettelse");
            }
        }
    }
}
