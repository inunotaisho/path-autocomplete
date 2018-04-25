using System;
using System.Collections.Generic;
namespace PathAutoComplete.Src.Interfaces
{
    public interface PathConfigurationValues
    {
        bool withExtension { get; }
        string excludedItems(string value);
        string pathMappings(string value);

        //one left
             
        bool triggerOutsideStrings { get; }
        bool enableFolderTrailingSlash { get; }
        string homeDirectory{ get;}
        string workspaceFolderPath { get;}
        string workspaceRootPath { get; }
    }
}
