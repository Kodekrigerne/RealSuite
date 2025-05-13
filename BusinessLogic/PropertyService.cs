using System.Data;
using System.Text.RegularExpressions;
using DataAccess;
using Models.DTOModels;

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

        public bool CreateProperty(PropertyDTO propertyDTO)
        {
            if (VerifyProperty(propertyDTO) == true)
            {
                var rowCreated = _propertyDbService.CreateProperty(propertyDTO);
                return rowCreated;
            }
            else return false;
        }

        public bool VerifyProperty(PropertyDTO propertyDTO)
        {
            if (!propertyDTO.StreetName.All(char.IsLetter)) return false;
            if (!propertyDTO.StreetNumber.ToString().All(char.IsDigit)) return false;
            if (!propertyDTO.ZipCode.ToString().All(char.IsDigit) || (propertyDTO.ZipCode < 1000 || propertyDTO.ZipCode > 9999)) return false;
            if (!propertyDTO.BuildYear.ToString().All(char.IsDigit)) return false;
            if (!propertyDTO.SquareMeters.ToString().All(char.IsDigit)) return false;
            if (propertyDTO.Price < 0) return false;
            if (!Regex.IsMatch(propertyDTO.DateListed.ToString("yyyy-MM-dd"), @"^\d{4}-(0[1-9]|1[0-2])-(0[1-9]|[12]\d|3[01])$"))
                return false;

            return true;
        }

    }
}
