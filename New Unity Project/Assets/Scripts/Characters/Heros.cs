using System;
namespace AssemblyCSharp.Assets.Scripts.Characters
{
    public class Heros
    {
        // HP, MP, Attack
        public static string[] hero = { "50", "20", "75" };
        public static string[] heroine1 = { "45", "30", "25" };
        public static string[] heroine2 = { "40", "40", "10" };

        // get weapon & armor info 


        // function to get hero statistics
        public static string[] getHero(int player)
        {
            string[] a = { "0", "0", "0" };

            switch (player)
            {
                case 1:
                        a = hero;
                        break;
                case 2:
                        a = heroine1;
                        break;
                case 3:
                        a = heroine2;
                        break;
            }

            return a;
        }
    }
}
