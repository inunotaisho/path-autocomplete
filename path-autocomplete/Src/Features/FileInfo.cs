using System;
using System.IO;
namespace pathautocomplete.Src.Features
{
    public class FileInfo
    {
        private string type;
        private string nameExt;
        private string nameNoExt;
        private string itemPath;

        public FileInfo()
        {
            var loc = '';
            this.itemPath = itemPath;
            this.type = fs.statSync(itemPath).isDirectory() ? 'dir' : 'file';
            this.nameExt = Path.GetFileName(itemPath);
            this.nameNoExt = Path.GetFileNameWithoutExtension(itemPath);
        }

        bool isDirectory()
        {
            return this.type == 'dir';
        }

        string getPath()
        {
            return this.itemPath;
        }

        string getName()
        {
            return (this.nameExt, this.nameNoExt);
        }
    }
}
