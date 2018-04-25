using System;
using System.Text.RegularExpressions;
using PathAutoComplete.Src.FileInfo;
using PathAutoComplete.Src.Configuration;


namespace pathautocomplete.Src.PathAutoCompleteProvider
{
    public class PathAutoCompleteProvider
    {
        string currentFile;

        var configuration = new PathConfiguration();
        public PathAutoCompleteProvider()
        {

            var self = this;
        }

        //Builds a list of the available files and folders from the provided path.

        getFolderItems(string FolderPath){


            var results = null;
        }

        //Returns the current working directory

        //Applies the folder mappings based on the user configurations

        //Determine if the current path

        //Determine if we should provide path completion.

        //Filter for the suggested items
     
    }
}
