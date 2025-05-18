using System.Text.RegularExpressions;
using Models;
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
            if (!Regex.IsMatch(personDTO.CprNumber, @"^(?:0[1-9]|[12]\d|3[01])(?:0[1-9]|1[0-2])(?:[0-9]{2})[0-9]{4}$"))
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
            if (!personDTO.ZipCode.ToString().All(char.IsDigit) || (personDTO.ZipCode < 1000 || personDTO.ZipCode > 9999))
            {
                return false;
            }
            if (!personDTO.PhoneNumber.All(char.IsDigit) || personDTO.PhoneNumber.Length != 8)
            {
                return false;
            }
            return true;
        }

        public bool VerifyPerson(Person person)
        {
            if (!person.FirstName.All(char.IsLetter))
            {
                return false;
            }
            if (!person.LastName.All(char.IsLetter))
            {
                return false;
            }
            if (!Regex.IsMatch(person.CprNumber, @"^(?:0[1-9]|[12]\d|3[01])(?:0[1-9]|1[0-2])(?:[0-9]{2})[0-9]{4}$"))
            {
                return false;
            }
            if (!person.StreetName.All(char.IsLetter))
            {
                return false;
            }
            if (!person.StreetNumber.ToString().All(char.IsDigit))
            {
                return false;
            }
            if (!person.ZipCode.ToString().All(char.IsDigit) || (person.ZipCode < 1000 || person.ZipCode > 9999))
            {
                return false;
            }
            if (!person.PhoneNumber.All(char.IsDigit) || person.PhoneNumber.Length != 8)
            {
                return false;
            }
            return true;
        }

    }
}
