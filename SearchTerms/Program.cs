// Read file using StreamReader. Reads file line by line
using static System.Net.Mime.MediaTypeNames;
int termsFound = 0;
int linesInDataFile = 0;

using (StreamReader searchTermsFile = new StreamReader("C:\\ScreenTest\\SearchTerms.txt"))
{
    string searchTerm;

    while ((searchTerm = searchTermsFile.ReadLine()) != null)
    {
        using (StreamReader dataFile = new StreamReader("C:\\ScreenTest\\Data.txt"))
        {
            string dataLine;
            linesInDataFile = 0;

            while ((dataLine = dataFile.ReadLine()) != null)
            {
                if (dataLine.Contains(searchTerm))
                {
                    termsFound++;
                }
                linesInDataFile++;
            }
            dataFile.Close();
        }
    }
    searchTermsFile.Close();
}

Console.WriteLine(termsFound);

Console.WriteLine(linesInDataFile);

Console.WriteLine(termsFound/linesInDataFile);