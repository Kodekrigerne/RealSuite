using System.Data;

namespace BusinessLogic
{
    public class ExportService
    {
        private BindingSource PropertiesSource;

        public ExportService(BindingSource propertiesSource)
        {
            PropertiesSource = propertiesSource;
        }

        public void SaveListToFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "CSV files (*.csv)|*.csv|Alle filer (*.*)|*.* ";
            saveFileDialog.Title = "Gem filtreret liste over ejendomme";
            saveFileDialog.FileName = "Filtreret liste";


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                CreateCSV(filePath);
            }

        }

        public void CreateCSV(string filePath)
        {
            DataTable? dt = PropertiesSource.DataSource as DataTable;

            List<string> csvLines = new List<string>();

            List<string> headers = new List<string>();

            foreach (DataColumn column in dt.Columns)
            {
                switch (column.ColumnName)
                {
                    case "Id":
                        headers.Add("Bolig ID");
                        break;

                    case "StreetName":
                        headers.Add("Vej");
                        break;

                    case "StreetNumber":
                        headers.Add("Nr.");
                        break;

                    case "ZipCode":
                        headers.Add("Postnr.");
                        break;

                    case "BuildYear":
                        headers.Add("Byggeår");
                        break;

                    case "SquareMeters":
                        headers.Add("m2");
                        break;

                    case "SellerID":
                        headers.Add("Sælger");
                        break;

                    case "Price":
                        headers.Add("Pris");
                        break;

                    case "RealtorID":
                        headers.Add("Mægler");
                        break;

                    case "DateListed":
                        headers.Add("Noteringsdato");
                        break;

                    case "DateSold":
                        headers.Add("Salgsdato");
                        break;

                    case "Sold":
                        headers.Add("Solgt");
                        break;

                    case "SqmPrice":
                        headers.Add("Pris pr. m2");
                        break;
                }
            }

            csvLines.Add(string.Join(";", headers));


            foreach (object item in PropertiesSource)
            {
                DataRowView? rowView = item as DataRowView;

                DataRow row = rowView.Row;

                List<string> data = new List<string>();

                foreach (DataColumn column in dt.Columns)
                {
                    string? value = row.IsNull(column) ? "" : row[column].ToString();

                    if (column.ColumnName == "DateListed")
                    {
                        value = value.Substring(0, value.Length - 9);
                    }

                    if (column.ColumnName == "DateSold" && value.Length != 0)
                    {
                        value = value.Substring(0, value.Length - 9);
                    }

                    data.Add(value);
                }

                csvLines.Add(string.Join(";", data));
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, false, new System.Text.UTF8Encoding(true)))
                {

                    foreach (string line in csvLines)
                    {
                        writer.WriteLine(line);
                    }
                }

                MessageBox.Show($"Listen er gemt som: {filePath}", "Gemt");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Der opstod en fejl under oprettelse af filen:\n" + ex.Message,
                    "Fejl ved oprettelse");
            }
        }
    }
}
