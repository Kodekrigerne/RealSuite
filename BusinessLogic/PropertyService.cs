using System.Data;
using DataAccess;

namespace BusinessLogic
{
    public class PropertyService
    {
        private readonly PropertyDbService _propertyDbService = new();

        public DataTable GetProperties()
        {
            var dataTable = _propertyDbService.GetProperties();
            return dataTable;
        }
    }
}
