using System.Diagnostics; 

namespace OsuWallpaper_Change
{
    class Osu
    {
        public void Apply(string randomWallpaper, string skinPath)
        {
            string wallpaperName = skinPath + "menu-background" + ".jpg"; 
            System.IO.File.Delete(skinPath + "menu-background" + ".jpg");
            System.IO.File.Copy(randomWallpaper, wallpaperName); 
        }

        public void Start()
        {
            ProcessStartInfo start = new ProcessStartInfo();

            start.FileName = @"C:\Users\Scott\AppData\Local\osu!\osu!.exe";

            Process.Start(start); 
        }
    }
}
