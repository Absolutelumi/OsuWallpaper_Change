using System;
using System.IO; 

namespace OsuWallpaper_Change
{
    class WallpaperChanger
    {
        Random random = new Random();
        Osu osu = new Osu();
        Wallpapers WPapers = new Wallpapers(); 
        private readonly string skinPath = @"C:\Users\Scott\AppData\Local\osu!\Skins\- Absolutelumi -\";
        private readonly string wallpaperPath = @"C:\Users\Scott\Desktop\プログラミング\Wallpapers\";
        private readonly string tempPath = @"C:\Users\Scott\Desktop\プログラミング\Temp\"; 
        private string randomWallpaper { get; set; }
        public bool complete = false; 
        public string[] wallpapers { get; set; }
        
        public void changeWallpaper()
        {
            WPapers.Rename(wallpaperPath, tempPath); 

            int wallpaperAmmount = Directory.GetFiles(wallpaperPath).Length;
            wallpapers = new string[wallpaperAmmount];

            for (int i = 0; i < wallpapers.Length; i++)
            {
                wallpapers[i] = wallpaperPath + string.Format("Wallpaper-{0}", i + 1 + ".jpg");
            }

            randomWallpaper = wallpapers[random.Next(0, wallpapers.Length)];

            osu.Apply(randomWallpaper, skinPath);
            osu.Start(); 
        }
    }
}
