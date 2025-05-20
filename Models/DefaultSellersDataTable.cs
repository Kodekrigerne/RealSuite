using System.Data;

namespace Models
{
    public class DefaultSellersDataTable : DataTable
    {
        public DefaultSellersDataTable()
        {
            TableName = "Sellers";

            DataColumn idColumn = new DataColumn();
            idColumn.DataType = typeof(int);
            idColumn.ColumnName = "Id";
            Columns.Add(idColumn);

            DataColumn firstNameColumn = new DataColumn();
            firstNameColumn.DataType = typeof(string);
            firstNameColumn.ColumnName = "FirstName";
            Columns.Add(firstNameColumn);

            DataColumn lastNameColumn = new DataColumn();
            lastNameColumn.DataType = typeof(string);
            lastNameColumn.ColumnName = "LastName";
            Columns.Add(lastNameColumn);

            DataColumn cprNumberColumn = new DataColumn();
            cprNumberColumn.DataType = typeof(string);
            cprNumberColumn.ColumnName = "CprNumber";
            Columns.Add(cprNumberColumn);

            DataColumn streetNameColumn = new DataColumn();
            streetNameColumn.DataType = typeof(string);
            streetNameColumn.ColumnName = "StreetName";
            Columns.Add(streetNameColumn);

            DataColumn streetNumberColumn = new DataColumn();
            streetNumberColumn.DataType = typeof(int);
            streetNumberColumn.ColumnName = "StreetNumber";
            Columns.Add(streetNumberColumn);

            DataColumn zipCodeColumn = new DataColumn();
            zipCodeColumn.DataType = typeof(int);
            zipCodeColumn.ColumnName = "ZipCode";
            Columns.Add(zipCodeColumn);

            DataColumn phoneNumberColumn = new DataColumn();
            phoneNumberColumn.DataType = typeof(string);
            phoneNumberColumn.ColumnName = "PhoneNumber";
            Columns.Add(phoneNumberColumn);
        }
    }
}
