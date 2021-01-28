
using System.Net;

using System.Text.RegularExpressions;


namespace NLUSchedule.Model
{
    public class Utility
    {






        /// <summary>
        /// MSSV 8 số, MSSGV 3 số 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool studentIDValidation(string input)
        {
            if (Regex.IsMatch(input, "^[0-9]{3}$|^[0-9]{8}$"))
            {
                return true;
            }
            return false;
        }



        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }


      

    }
}
