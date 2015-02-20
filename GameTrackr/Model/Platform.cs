using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTrackr.Model
{
    [Serializable]
    class Platform
    {

        public enum Type
        {
            PSP,
            PSOne,
            GBA
        }

        public Platform(string name, Type type)
        {
            this.name = name;
            this.type = type;
            games = new List<Game>();

            if (type == Type.PSP)
            {
                boxWidth = 121;
                boxHeight = 209;
            }
            else
            {
                boxWidth = 157;
                boxHeight = 157;
            }

        }

        public int id { get; set; }
        public string name { get; set; }
        public string folder { get; set; }
        public Type type { get; set; }
        public List<Game> games { get; set; }

        public int boxWidth { get; set; }
        public int boxHeight { get; set; }

    }
}
