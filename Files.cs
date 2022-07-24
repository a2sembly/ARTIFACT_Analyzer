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

        public string getConsoleMsg(string Exe, string msg)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = Exe;
            Console.WriteLine(Exe);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            //start.WindowStyle = ProcessWindowStyle.Hidden;
            start.CreateNoWindow = true;
            start.Arguments = msg;  // argument 전달

            Process process = Process.Start(start);         // test.exe를 실행시키고
            StreamReader reader = process.StandardOutput;   // 출력되는 값을 가져오기 위해 StreamReader에 연결 
            return reader.ReadToEnd();                       // 출력값의 한 라인을 읽는다
        }
    }
}
