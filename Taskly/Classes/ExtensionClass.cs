using System;

namespace Taskly.Classes
{
    public static class ExtensionClass
    {

        public static Color GetColor(this string str)
        {
            
            switch (str)
            {
                case "Yellow":
                    return Color.FromArgb(255,242,0);
                case "Orange":
                    return Color.FromArgb(255,94,0);
                case "Pink":
                    return Color.FromArgb(255,0,106);
                case "Violet":
                    return Color.FromArgb(208,0,255);
                case "Dark blue":
                    return Color.FromArgb(43,0,255);
                case "Blue":
                    return Color.FromArgb(0,217,155);
                case "Mint":
                    return Color.FromArgb(0,255,179);
                case "Green":
                    return Color.FromArgb(47,255,0);
                case "Black":
                    return Color.FromArgb(0,0,0);
                default:
                    return Color.FromArgb(255,255,255);
            }
        }
        public static string GetStr(this Color color)
        {
            if (color== Color.FromArgb(255, 242, 0))
            {
                return "Yellow";
            }
            else if (color == Color.FromArgb(255, 94, 0))
            {
                return "Orange";
            }
            else if (color == Color.FromArgb(255, 0, 106))
            {
                return "Pink";
            }
            else if (color == Color.FromArgb(208, 0, 255))
            {
                return "Violet";
            }
            else if (color == Color.FromArgb(43, 0, 255))
            {
                return "Dark blue";
            }
            else if (color == Color.FromArgb(0, 217, 155))
            {
                return "Blue";
            }
            else if (color == Color.FromArgb(0, 255, 179))
            {
                return "Mint";
            }
            else if (color == Color.FromArgb(47, 255, 0))
            {
                return "Green";
            }
            else if (color == Color.FromArgb(0, 0, 0))
            {
                return "Black";
            }
            else 
            {
                return "White";

            }
        }

    }
}
