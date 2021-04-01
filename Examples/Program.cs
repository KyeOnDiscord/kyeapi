using System;
using Newtonsoft.Json;
using System.Net;
namespace MinecraftSkinDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)//Command line arguments
            {
                DownloadSkin(args[0]);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("=======");
                Console.WriteLine("Minecraft Skin Stealer by Kye#5000");
                Console.WriteLine("=======");
                Console.WriteLine("");
                Console.WriteLine("Enter a Minecraft username");

                string username = Console.ReadLine();
                DownloadSkin(username);
                Console.Clear();
                Console.WriteLine("Exported to " + username + "'s Skin.png");
                Console.ReadLine();
            }
            
        }


        public static void DownloadSkin(string username)
        {
            try
            {
                //when the magic starts
                WebClient web = new WebClient();
                Root minecraftprofile = JsonConvert.DeserializeObject<Root>(web.DownloadString("https://kyeapi.herokuapp.com/minecraft/username/" + username));
                web.DownloadFile(minecraftprofile.textures.SKIN.url, username + "'s Skin.png");
            }
            catch//Error account doesnt exist
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That username doesn't exist!");
                Console.ReadKey();
                Environment.Exit(0);
            } 
        }
    }
    public class SKIN
    {
        public string url { get; set; }
    }

    public class Textures
    {
        public SKIN SKIN { get; set; }
    }

    public class Root
    {
        public Textures textures { get; set; }
    }


}
