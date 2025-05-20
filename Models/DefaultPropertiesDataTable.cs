using System.Data;

namespace Models
{
    public class DefaultPropertiesDataTable : DataTable
    {

        public DefaultPropertiesDataTable()
        {
            TableName = "Properties";

            DataColumn idColumn = new DataColumn();
            idColumn.DataType = typeof(int);
            idColumn.ColumnName = "Id";
            Columns.Add(idColumn);

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

            DataColumn buildYearColumn = new DataColumn();
            buildYearColumn.DataType = typeof(int);
            buildYearColumn.ColumnName = "BuildYear";
            Columns.Add(buildYearColumn);

            DataColumn squareMetersColumn = new DataColumn();
            squareMetersColumn.DataType = typeof(int);
            squareMetersColumn.ColumnName = "SquareMeters";
            Columns.Add(squareMetersColumn);

            DataColumn sellerIdColumn = new DataColumn();
            sellerIdColumn.DataType = typeof(int);
            sellerIdColumn.ColumnName = "SellerID";
            Columns.Add(sellerIdColumn);

            DataColumn priceColumn = new DataColumn();
            priceColumn.DataType = typeof(int);
            priceColumn.ColumnName = "Price";
            Columns.Add(priceColumn);

            DataColumn realtorIdColumn = new DataColumn();
            realtorIdColumn.DataType = typeof(int);
            realtorIdColumn.ColumnName = "RealtorID";
            Columns.Add(realtorIdColumn);

            DataColumn dateListedColumn = new DataColumn();
            dateListedColumn.DataType = typeof(DateTime);
            dateListedColumn.ColumnName = "DateListed";
            Columns.Add(dateListedColumn);

            DataColumn dateSoldColumn = new DataColumn();
            dateSoldColumn.DataType = typeof(DateTime);
            dateSoldColumn.ColumnName = "DateSold";
            Columns.Add(dateSoldColumn);

            DataColumn soldColumn = new DataColumn();
            soldColumn.DataType = typeof(bool);
            soldColumn.ColumnName = "Sold";
            Columns.Add(soldColumn);

            DataColumn sqmPriceColumn = new DataColumn();
            sqmPriceColumn.DataType = typeof(int);
            sqmPriceColumn.ColumnName = "SqmPrice";
            Columns.Add(sqmPriceColumn);

            DataColumn saelgerColumn = new DataColumn();
            saelgerColumn.DataType = typeof(string);
            saelgerColumn.ColumnName = "Sælger";
            Columns.Add(saelgerColumn);
        }
    }
}
