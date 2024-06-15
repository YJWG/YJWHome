namespace YJWHome.Components.Pages
{
    public static class ExtensionFileInfo
    {
        private static Random _ran = new Random();

        public static void Shuffle<T>(this FileInfo[] list)
        {
            int to = list.Length;
            while (to > 1)
            {
                int from = _ran.Next(--to + 1);
                FileInfo tmp = list[from];
                list[from] = list[to];
                list[to] = tmp;
            }
        }

        public static void Swap<T>(this FileInfo[] list, int from, int to)
        {
            FileInfo tmp = list[from];
            list[from] = list[to];
            list[to] = tmp;
        }
    }
}