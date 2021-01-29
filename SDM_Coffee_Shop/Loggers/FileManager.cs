using System.IO;

namespace SDM_Coffee_Shop
{
    internal class FileManager
    {
        public void CreateFile(string file)
        {
            if (!File.Exists(file))
            {
                FileStream fileStream = File.Create(file);
                fileStream.Close();
            }
        }
    }
}