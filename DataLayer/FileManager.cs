namespace DataLayer
{
    public class FileManager
    {
        private string _filePath = "C:\\Users\\Computer\\source\\repos\\Project_PRG272\\DataLayer\\Users.txt";
        public string AddNewLine(string line)
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    File.AppendAllText(_filePath, line + "\n");
                    return "Line added successfully.";
                }
                else
                {
                    throw new FileNotFoundException("File not found: " + _filePath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while writing to the file: " + ex.Message);
                return "Failed to add line.";
            }
        }

        public string[] ReadFileLines()
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    return File.ReadAllLines(_filePath);
                }
                else
                {
                    throw new FileNotFoundException("File not found: " + _filePath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while reading the file: " + ex.Message);
                return Array.Empty<string>();
            }
        }
    }
}
