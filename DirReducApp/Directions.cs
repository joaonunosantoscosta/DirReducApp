using System;
using System.Collections.Generic;
using System.Text;

namespace DirReducApp
{
    public class Directions
    {
        public string[] DirReduc(string[] array)
        {
            if (array == null) return null;

            int dirH = 0, dirV = 0;
            foreach (string str in array)
            {
                switch (str.ToUpper().Trim())
                {
                    case "NORTH":
                        dirV++;
                        break;
                    case "SOUTH":
                        dirV--;
                        break;
                    case "EAST":
                        dirH++;
                        break;
                    case "WEST":
                        dirH--;
                        break;

                    default:
                        break;
                }
            }

            List<string> result = new List<string>();
            string strFinal = (dirH > 0 ? "EAST" : "WEST");
            for (int i = 0; i < Math.Abs(dirH); i++)
            {
                result.Add(strFinal);
            }
            strFinal = (dirV > 0 ? "NORTH" : "SOUTH");
            for (int i = 0; i < Math.Abs(dirV); i++)
            {
                result.Add(strFinal);
            }

            if (result.Count == 0)
            {
                return null;
            }

            return result.ToArray();
        }


    }
}
