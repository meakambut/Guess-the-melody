using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace GuessTheMelody
{
    static class Quiz
    {
        static public List<string> list = new List<string>();

        static public int    GameDuration = 0;
        static public int    MusicDuration = 0;
        static public bool   RandonStart = false;
        static public string LastFolder = "";
        static public bool   IncludeFolders = false;
        static public int    CurrentGameDuration = 0;
        static public string answer = "";

        static public void ReadMusic()
        {
            try
            {
                string[] musicList = Directory.GetFiles(LastFolder, "*.mp3", IncludeFolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                list.Clear();
                list.AddRange(musicList);
            }
            catch
            {
            }
        }

        static string RegKeyName = "Software\\meakambut\\GuessMelody";

        public static void SaveSettings()
        {
            RegistryKey rk = null;

            try
            {
                rk = Registry.CurrentUser.CreateSubKey(RegKeyName);
                if (rk == null) return;
                rk.SetValue("GameDuration", GameDuration);
                rk.SetValue("MusicDuration", MusicDuration);
                rk.SetValue("RandonStart", RandonStart);
                rk.SetValue("LastFolder", LastFolder);
                rk.SetValue("IncludeFolders", IncludeFolders);
             }

            finally
            {
                if (rk != null) rk.Close();
            }
        }

        public static void GetSettings()
        {
            RegistryKey rk = null;

            try
            {
                rk = Registry.CurrentUser.OpenSubKey(RegKeyName);
                if (rk != null)
                {
                    GameDuration = (int)rk.GetValue("GameDuration");
                    MusicDuration = (int)rk.GetValue("MusicDuration");
                    RandonStart = Convert.ToBoolean(rk.GetValue("RandonStart"));
                    LastFolder = (string)rk.GetValue("LastFolder");
                    IncludeFolders = Convert.ToBoolean(rk.GetValue("IncludeFolders"));
                 }
             }

            finally
            {
                if (rk != null) rk.Close();
            }
        }
    }
}
