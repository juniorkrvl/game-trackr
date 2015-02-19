using GameTrackr.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameTrackr.Core
{
    class Wrapper
    {

        public static string base_img { get; set; }

        public static Game GetGame(int id = 0, string name = "", string platform = "")
        {

            try
            {
                List<string> param = new List<string>();

                if (id > 0)
                    param.Add("id=" + id);
                if (name.Length > 0)
                    param.Add("name=" + name);
                if (platform.Length > 0)
                    param.Add("platform=" + platform);

                string strparam = String.Join("&", param.ToArray());

                XDocument doc = Service.MakeRequest(Service.methods.GetGame, strparam);

                base_img = (string)doc.Element("Data").Element("baseImgUrl").Value;
                XElement game = doc.Element("Data").Element("Game");

                if (game != null)
                {
                    Game gm = new Game();
                    gm.id = int.Parse(game.Element("id").Value);
                    gm.name = game.Element("GameTitle").Value;
                    gm.overview = game.Element("Overview") == null ? "" : game.Element("Overview").Value;

                    foreach (XElement image in game.Element("Images").Elements())
                    {
                        GameImage img = new GameImage();
                        img.type = image.Name.ToString();

                        if (img.type == "fanart")
                        {
                            img.original = base_img + image.Element("original").Value;
                            img.thumb = base_img + image.Element("thumb").Value;
                            img.width = image.Element("original").Attribute("width").Value;
                            img.height = image.Element("original").Attribute("height").Value;
                        }
                        else if (img.type == "boxart")
                        {
                            img.original = base_img + image.Value;
                            img.thumb = base_img + image.Attribute("thumb").Value;
                            img.side = image.Attribute("side").Value;
                            img.width = image.Attribute("width").Value;
                            img.height = image.Attribute("height").Value;
                        }

                        gm.images.Add(img);

                    }
                    return gm;
                }

                return null;

            }
            catch (Exception ex)
            {
                throw ex;

            }

        }

        public static List<Game> GetGames(string name, string platform = "", string genre = "")
        {
            try
            {
                List<string> param = new List<string>();

                if (name.Length > 0)
                    param.Add("name=" + name);
                if (platform.Length > 0)
                    param.Add("platform=" + platform);
                if (genre.Length > 0)
                    param.Add("genre=" + genre);

                string strparam = String.Join("&", param.ToArray());

                XDocument doc = Service.MakeRequest(Service.methods.GetGamesList, strparam);

                List<Game> list = new List<Game>();

                foreach (XElement game in doc.Element("Data").Elements())
                {
                    Game gm = new Game();
                    gm.id = int.Parse(game.Element("id").Value);
                    gm.name = game.Element("GameTitle") == null ? "" : game.Element("GameTitle").Value;
                    gm.releaseDate = game.Element("ReleaseDate") == null ? "" : game.Element("ReleaseDate").Value;
                    gm.platform = game.Element("Platform") == null ? "" : game.Element("Platform").Value;
                    list.Add(gm);
                }

                return list;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
