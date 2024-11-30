using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DyakovMS.Sprint3.Task3.V24.Lib
{
    public class DataService : ISprint3Task3V24
    {
        public string ReplaceCharInString(string value, char replaceable, char replacement)
        {
            string result = string.Empty;
            foreach (char c in value)
            {
                result += c == replaceable ? replacement : c;
            }
            return result;
        }
    }
}
