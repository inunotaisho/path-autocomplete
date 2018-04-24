using System;
using System.IO;
namespace pathautocomplete.Src.Features
{
    public class PathConfiguration
    {
        private string type;
        private string nameExt;
        private string nameNoExt;
        private string itemPath;

        public PathConfiguration()
        {
            this.itemPath = itemPath;
            this.type = FileS ;
            this.nameExt = Path.GetFileName(itemPath);
            this.nameNoExt = Path.GetFileNameWithoutExtension(itemPath);
        }

        bool isDirectory(){
            return this.type == 'dir';
        }
    }
}

