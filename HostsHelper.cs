namespace VisualParadigmKeygen
{
    class HostsHelper
    {
        private readonly string hostsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts");

        readonly string[] txt =
        {
            "# Added by VisualParadigmKeygen",
            "0.0.0.0 cs.visual-paradigm.com",
            "0.0.0.0 license.visual-paradigm.com",
            "0.0.0.0 visual-paradigm.com",
            "# End"
        };
        public bool AddToHosts()
        {
            try
            {
                string hostsContent = File.ReadAllText(hostsPath);
                bool already = hostsContent.Contains(txt[1]);
                if (!already)
                {
                    using StreamWriter streamWriter = File.AppendText(hostsPath);
                    foreach (string line in txt)
                    {
                        streamWriter.WriteLine(line);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool RemoveFromHosts()
        {
            try
            {
                var lines = File.ReadAllLines(hostsPath).ToList();
                foreach (string txts in txt)
                {
                    lines.RemoveAll(line => line.Trim() == txts);
                }

                File.WriteAllLines(hostsPath, lines);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}