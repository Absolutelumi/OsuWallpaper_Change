namespace OsuWallpaper_Change
{
    class Osu
    {
        public bool running { get; set; }

        public void Apply(string randomWallpaper, string skinPath)
        {
            string wallpaperName = skinPath + "menu-background" + ".jpg"; 
            System.IO.File.Delete(skinPath + "menu-background" + ".jpg");
            System.IO.File.Copy(randomWallpaper, wallpaperName); 
        }
    }
}
