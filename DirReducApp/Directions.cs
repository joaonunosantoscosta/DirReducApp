using System;
using System.Collections.Generic;
using System.Text;

namespace DirReducApp
{
    public class Directions
    {

        public string[] DirReduc_versionHaskell(string input)
        {
            return DirReduc(input.Split('|'));
        }

        public string[] DirReduc_versionClojure(string[] array)
        {
            string[] result = DirReduc(array);
            return (result == null || result.Length == 0 ? null : result);
        }

        public string[] DirReduc_versionRust(List<ENUM_DIRECTIONS> listDirections)
        {
            List<string> list = new List<string>();
            listDirections.ForEach(x => list.Add(x.ToString()));
            return DirReduc(list.ToArray());
        }

        public string[] DirReduc(string[] array)
        {
            if (array == null) return null;
            if (array.Length == 0) return array;

            List<string> result = new List<string>(array);
            int i = -1;
            bool finish = false;
            while (!finish)
            {
                i++;
                if (i < 0) i = 0;

                string next = (i == result.Count - 1 ? null : result[i + 1].ToUpper().Trim());
                switch (result[i].ToUpper().Trim())
                {
                    case "NORTH":
                        if (next != null && next.Equals("SOUTH"))
                        {
                            result.RemoveAt(i + 1);
                            result.RemoveAt(i);
                            i = i - 2;
                            break;
                        }
                        break;
                    case "SOUTH":
                        if (next != null && next.Equals("NORTH"))
                        {
                            result.RemoveAt(i + 1);
                            result.RemoveAt(i);
                            i = i - 2;
                            break;
                        }
                        break;
                    case "EAST":
                        if (next != null && next.Equals("WEST"))
                        {
                            result.RemoveAt(i + 1);
                            result.RemoveAt(i);
                            i = i - 2;
                            break;
                        }
                        break;
                    case "WEST":
                        if (next != null && next.Equals("EAST"))
                        {
                            result.RemoveAt(i + 1);
                            result.RemoveAt(i);
                            i = i - 2;
                            break;
                        }
                        break;

                    default:
                        result.RemoveAt(i);
                        i = i - 2;
                        break;
                }

                if (next == null || result.Count == 0) finish = true;
            }

            return result.ToArray();
        }


    }

    public enum ENUM_DIRECTIONS
    {
        NORTH = 1,
        SOUTH = 2,
        EAST = 3,
        WEST = 4
    }
}
