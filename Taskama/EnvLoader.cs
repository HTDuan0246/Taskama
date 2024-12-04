namespace Taskama
{
    public static class EnvLoader
    {
        public static void LoadEnv(string filePath = ".env")
        {
            if (!File.Exists(filePath))
                return;

            foreach (var line in File.ReadAllLines(filePath))
            {
                // Bỏ qua các dòng trống hoặc comment
                if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#"))
                    continue;

                // Tách dòng thành key và value
                var parts = line.Split('=', 2);
                if (parts.Length == 2)
                    Environment.SetEnvironmentVariable(parts[0].Trim(), parts[1].Trim());
            }
        }
    }
}