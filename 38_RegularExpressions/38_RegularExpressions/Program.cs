using System.Text.RegularExpressions;

namespace _38_RegularExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\d{5}";
            Regex regex = new Regex(pattern);

            string text = "Hi there my number is 12345";

            MatchCollection matchCollection = regex.Matches(text);

            Console.WriteLine($"{matchCollection.Count} hits found:\n {text}");

            foreach (Match hit in matchCollection) {

                GroupCollection group = hit.Groups;
                Console.WriteLine($"{group[0].Value} found at {group[0].Index}");
            
            }

            // EMAIL EXTRACTOR

            string emailPattern = @"\w+@\w+\.\w+";
            regex = new Regex(emailPattern);

            string email = "Contact us at support@example.com or sales@example.org";

            matchCollection = regex.Matches(email);

            Console.WriteLine($"\n\n{matchCollection.Count} hits (emails) found:\n {email}");

            foreach (Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine($"{group[0].Value} found at {group[0].Index}");

            }





        }
    }
}
