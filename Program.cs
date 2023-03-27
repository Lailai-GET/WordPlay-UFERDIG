using System.Xml;

namespace Readwrite
{
    internal class Program
    {
        /*
         * Jeg gav opp..
         * Det tok så lang tid å laste inn, så det ble vanskelig å teste hver nye oppgave.
         * Og det var mye uklarheter i oppgaveteksten, og det ble veldig frustrerende.
         * Hadde jeg vært i en bedrift hvor jeg fikk beksjed at det måtte gjøres, så kunne jeg greid det,
         * men jeg merker at jeg ikke vil sitte her dag ut/inn og jobbe med dette og bli irritert.
         * Jeg er her for å lære, ikke for å pine meg selv med arbeidsoppgaver jeg helst skulle vært foruten.
         * Blabla work ethics og sikkert GRIT å komme gjennom,
         * men om hovedpoenget var å lese fra en fil og jobbe med lister så job done.
         */
        static void Main(string[] args)
        {
            var path = "C:\\Users\\Nikolai\\Documents\\GET Academy\\Modul 3\\Intro\\Readwrite\\ordliste.txt";
            var rawText = File.ReadAllText(path).Split("\t").ToArray();
            int[] wordLength = { 7, 8, 9, 10 };
            //WriteToConsole(rawText, wordLength);
            string[] allWords = MakeList(rawText, wordLength);
            foreach (var word in allWords)
            {
                Console.WriteLine(word);
            }
            
            
            
        }

        private static string[] MakeList(string[] rawText, int[] wordLength)
        {
            var used = new List<string>();
            foreach (string word in rawText)
            {
                if (MeetsConditions(word, used, wordLength))
                {
                    used.Add(word);
                }
            }
            return used.ToArray();
        }

        private static void WriteToConsole(string[] rawText, int[] wordLength)
        {
            var used = new List<string>();
            foreach (var word in rawText)
            {
                if (MeetsConditions(word, used, wordLength))
                {
                    Console.WriteLine(word);
                    used.Add(word);
                }
            }
        }

        private static bool MeetsConditions(string word, List<string> used, int[] wordLength)
        {
            if (
                !used.Contains(word) &&
                !word.Any(char.IsWhiteSpace) &&
                wordLength.Contains(word.Length)
            )
            {
                return true;
            }
            return false;
        }
    }
}