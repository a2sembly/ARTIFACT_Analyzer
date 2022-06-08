namespace ARTIFACT_Analyzer
{
    internal class Files
    {
        public string GetFileVersion(string pathToExe)
        {
            var versionInfo = FileVersionInfo.GetVersionInfo(pathToExe);
            return versionInfo.FileVersion;
        }
        public string GetFileDescription(string pathToExe)
        {
            var versionInfo = FileVersionInfo.GetVersionInfo(pathToExe);
            return versionInfo.FileDescription;
        }

        public string[] GetFileList(string dir, string extension)
        {
             return Directory.GetFiles(dir, extension, SearchOption.AllDirectories);
        }
    }
}
