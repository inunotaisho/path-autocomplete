using System;
namespace pathautocomplete.Src.Interfaces
{
    public interface PathConfigurationValues
    {
        bool withExtension;
        string excludedItems: [{[key: string]: {when: string}}]
        string pathMappings?: [{[key: string]: string}];
             transformations?: [{string type,parameters?: Array<any>,when?: {string fileName}}];
        bool triggerOutsideStrings;
        bool enableFolderTrailingSlash;
        string homeDirectory;
        string workspaceFolderPath;
        string workspaceRootPath;
    }
}
