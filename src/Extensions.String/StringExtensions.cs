using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Moises.Toolkit.Extensions.String
{
    public static class StringExtensions
    {
        public static string RemoveAccents(this string text)
        {
            StringBuilder sbReturn = new StringBuilder();
            char[] arrayText = text.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letter in arrayText)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
                {
                    sbReturn.Append(letter);
                }
            }
            return sbReturn.ToString();
        }


        public static List<string> ScrapeBetween(this string data, string start, string end, bool getAll = false)
        {
            List<string> matches = new List<string>();

            do
            {
                int posStart = data.IndexOf(start);
                if (posStart == -1)
                {
                    break;
                }

                string sub = data.Substring(posStart + start.Length);
                int posEnd = sub.IndexOf(end);
                if (posEnd == -1)
                {
                    break;
                }

                matches.Add(sub.Substring(0, posEnd));

                int size = posStart + start.Length + posEnd;
                data = data.Substring(size);

            } while (getAll);

            return matches;
        }


        public static string FormatCpf(this string cpf)
        {
            if (cpf.Contains("."))
            {
                cpf = cpf.PadLeft(14, '0');
            }
            else
            {
                cpf = cpf.PadLeft(11, '0');
                cpf = cpf.Substring(0, 3) + "." + cpf.Substring(3, 3) + "." + cpf.Substring(6, 3) + "-" + cpf.Substring(9, 2);
            }

            return cpf;
        }
    }
}
