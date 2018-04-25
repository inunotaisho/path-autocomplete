using System;
using System.IO;
using Microsoft.VisualStudio.Workspace;
using PathAutoComplete.Src.Interfaces;
namespace PathAutoComplete.Src.Configuration
{
    
    public class PathConfiguration
    {
        private readonly PathConfigurationValues data;
        public PathConfiguration()
        {
            this.data = null;
        }

        void update(string )

        update(fileUri?: Workspace.Uri)
        {
            var code = ProjectConfiguration();
            var codeConfiguration = vs.workspace.getConfiguration('path-autocomplete', fileUri || null);

            this.data.withExtension = codeConfiguration.get('extensionOnImport');
            this.data.excludedItems = codeConfiguration.get('excludedItems');
            this.data.pathMappings = codeConfiguration.get('pathMappings');
            this.data.transformations = codeConfiguration.get('transformations');
            this.data.triggerOutsideStrings = codeConfiguration.get('triggerOutsideStrings');
            this.data.enableFolderTrailingSlash = codeConfiguration.get('enableFolderTrailingSlash');
            this.data.homeDirectory = process.env[(process.platform == 'win32') ? 'USERPROFILE' : 'HOME'];

            var workspaceRootFolder = vs.workspace.workspaceFolders ? vs.workspace.workspaceFolders[0] : null;
            var workspaceFolder = workspaceRootFolder;

            if (fileUri)
            {
                workspaceFolder = vs.workspace.getWorkspaceFolder(fileUri);
            }

            this.data.workspaceFolderPath = workspaceFolder && workspaceFolder.uri.fsPath;
            this.data.workspaceRootPath = workspaceRootFolder && workspaceRootFolder.uri.fsPath;
        }

    }
}

