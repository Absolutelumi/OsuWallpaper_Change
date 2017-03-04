using System;
using System.IO; 

namespace OsuWallpaper_Change
{
    class WallpaperChanger
    {
        Random random = new Random();
        Osu osu = new Osu();
        private readonly string skinPath = @"C:\Users\Scott\AppData\Local\osu!\Skins\- Absolutelumi -\";
        private readonly string wallpaperPath = @"C:\Users\Scott\Desktop\プログラミング\Wallpapers\";
        private string randomWallpaper { get; set; }
        public string[] wallpapers { get; set; }
        
        public void changeWallpaper()
        {
            wallpapers = Directory.GetFiles(wallpaperPath); 

            randomWallpaper = wallpapers[random.Next(0, wallpapers.Length)];

            osu.Apply(randomWallpaper, skinPath);
            osu.Start(); 
        }
    }
}
