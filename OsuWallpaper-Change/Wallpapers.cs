using System.IO; 

namespace OsuWallpaper_Change
{
    class Wallpapers
    {
        public void Rename(string wallpaperPath, string tempPath)
        {
            int file = 1;
            DirectoryInfo wallpapersDirectory = new DirectoryInfo(wallpaperPath);
            FileInfo[] wallpapers = wallpapersDirectory.GetFiles(); 
            foreach(FileInfo f in wallpapers)
            {
                File.Move(f.FullName, wallpaperPath + "Wallpaper-" + file + ".jpg"); 
                file++;
            }
        }
    }
}
