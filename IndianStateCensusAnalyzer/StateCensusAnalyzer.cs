using CsvHelper;
using System.Globalization;

namespace IndianStateCensusAnalyzer
{
    public class StateCensusAnalyzer
    {
        private static TextReader reader;

        public static int ReadStateCensusData(string filePath)
        {
           if (!Path.GetExtension(filePath).Equals(".csv"))
            {
                throw new CensusAnalyzerException(CensusAnalyzerException.ExceptionType.FILE_INCORRECT, "file extension incorrect");
            }
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<StateCensusData>().ToList();
                    Console.WriteLine("Read Data from CSV");
                    foreach (var data in records)
                    {
                        Console.WriteLine(data.State + "---" + data.Population + "---" +
                            data.AreaInSqKm + "---" + data.DensityPerSqKm);
                    }
                    return records.Count() - 1;
                }
            }
        }
    }
}
