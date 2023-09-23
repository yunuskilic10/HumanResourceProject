using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Extensions.NewEmail
{
    public static class NewEmail
    {
        public static string CreateEmail(string name, string secondName, string lastName, string companyName)
        {
            name = ConvertTurkishToEnglish(name.ToLower());
            if (secondName != null)
            {
                secondName = ConvertTurkishToEnglish(secondName.ToLower());

                lastName = ConvertTurkishToEnglish(lastName.ToLower());
                companyName = ConvertTurkishToEnglish(companyName.ToLower());

                string createEmail = $"{name}{secondName}{lastName}" + "@" + companyName + ".com";
                return createEmail.Replace(" ", "");
            }
            else
            {
                lastName = ConvertTurkishToEnglish(lastName.ToLower());
                companyName = ConvertTurkishToEnglish(companyName.ToLower());

                string createEmail = $"{name}{lastName}" + "@" + companyName + ".com";
                return createEmail.Replace(" ", "");
            }
        }

        static string ConvertTurkishToEnglish(string input)
        {
            string[] turkishChars = { "ç", "ğ", "ı", "i", "ö", "ş", "ü", "Ç", "Ğ", "İ", "I", "Ö", "Ş", "Ü" };
            string[] englishChars = { "c", "g", "i", "i", "o", "s", "u", "C", "G", "I", "I", "O", "S", "U" };

            StringBuilder result = new StringBuilder(input);

            for (int i = 0; i < turkishChars.Length; i++)
            {
                result = result.Replace(turkishChars[i], englishChars[i]);
            }

            return result.ToString();
        }
    }
}
