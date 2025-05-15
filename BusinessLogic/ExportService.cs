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
                headers.Add(column.ColumnName);
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
