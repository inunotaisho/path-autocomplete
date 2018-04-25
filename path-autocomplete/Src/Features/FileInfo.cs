using System;
using System.IO;

namespace PathAutoComplete.Src.FileInfo
{
    public class FileInfo
    {
        private string type;
        private string name;
        private string itemPath;
        private const string loc = "";

        public FileInfo(string itemPath)
        {
            this.itemPath = itemPath;
            this.type = Directory.Exists(itemPath) ? "dir" : "file";
            this.name = (Directory.Exists(itemPath)) ? Path.GetDirectoryName(itemPath) : Path.GetFileName(itemPath);
        }

        bool isDirectory()
        {
            return this.type == "dir";
        }

        string getPath()
        {
            return this.itemPath;
        }

        string getName()
        {
            return this.name;
        }
    }
}
