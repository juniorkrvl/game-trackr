using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace GameTrackr.Core
{
    class Service
    {
        private const string base_api = "http://thegamesdb.net/api/";

        public enum methods
        {
            GetGame,
            GetGamesList
        }

        public static XDocument MakeRequest(methods method, string param)
        {
            try
            {
                string url = base_api + method.ToString() + ".php?" + param;

                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(response.GetResponseStream());

                XDocument doc = new XDocument();
                doc = XDocument.Parse(xmlDoc.InnerXml);

                return doc;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
                return null;
            }
        }

    }
}
