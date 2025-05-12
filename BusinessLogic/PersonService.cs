using Models.DTOModels;

namespace BusinessLogic
{
    internal class PersonService
    {

        public bool VerifyPerson(PersonDTO personDTO)
        {
            if (!personDTO.FirstName.All(char.IsLetter))
            {
                return false;
            }
            if (!personDTO.LastName.All(char.IsLetter))
            {
                return false;
            }
            if (!personDTO.CprNumber.All(char.IsDigit) && personDTO.CprNumber.Length != 10)
            {
                return false;
            }
            if (!personDTO.StreetName.All(char.IsLetter))
            {
                return false;
            }
            if (!personDTO.StreetNumber.ToString().All(char.IsDigit))
            {
                return false;
            }
            if (!personDTO.ZipCode.ToString().All(char.IsDigit) && (personDTO.ZipCode < 1000 && personDTO.ZipCode > 9999))
            {
                return false;
            }
            if (!personDTO.PhoneNumber.All(char.IsDigit) && personDTO.PhoneNumber.Length != 8)
            {
                return false;
            }
            return true;
        }

    }
}
