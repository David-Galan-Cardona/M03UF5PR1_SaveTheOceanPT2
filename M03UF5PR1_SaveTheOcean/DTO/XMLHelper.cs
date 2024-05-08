using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace M03UF5PR1_SaveTheOcean.DTO
{
    public class XMLHelper
    {
        /// <summary>
        /// Crea un fitxer XML amb LINQ
        /// </summary>
        /// <param name="player"></param>
        /// <param name="res"></param>
        /// <param name="date"></param>
        /// <param name="superfamily"></param>
        /// <param name="loc"></param>
        /// <param name="GA"></param>
        /// <param name="newGA"></param>
        /// <param name="species"></param>
        public static void CreateXMLFileWithLINQ(PlayerDTO player, string res, string date, string superfamily, string loc, int GA, int newGA, string species)
        {
            string xmlFilePath = @"..\..\..\GameData.xml";
            if (!System.IO.File.Exists(xmlFilePath))
            {
                XDocument xmlDoc = new XDocument(new XElement("rescues",
                    new XElement("rescue",
                    new XElement("Jugador", player.Name),
                    new XElement("Rescat", res),
                    new XElement("Data", date),
                    new XElement("Superfamília", superfamily),
                    new XElement("GA", GA),
                    new XElement("Localització", loc),
                    new XElement("Espècie", species),
                    new XElement("GANou", newGA),
                    new XElement("Exp", player.Exp)
                    )
                    ));
                xmlDoc.Save(xmlFilePath);
            }
            else
            {
                XDocument xmlDoc = XDocument.Load(xmlFilePath);
                xmlDoc.Element("rescues").Add(
                    new XElement("rescue",
                    new XElement("Jugador", player.Name),
                    new XElement("Rescat", res),
                    new XElement("Data", date),
                    new XElement("Superfamília", superfamily),
                    new XElement("GA", GA),
                    new XElement("Localització", loc),
                    new XElement("Espècie", species),
                    new XElement("GANou", newGA),
                    new XElement("Exp", player.Exp)
                    )
                    );
                xmlDoc.Save(xmlFilePath);
            }
        }
        /// <summary>
        /// Llegeix un fitxer XML amb LINQ
        /// </summary>
        /// <param name="res"></param>
        public static void ReadXMLFileWithLINQ(string res)
        {
            string xmlFilePath = @"..\..\..\GameData.xml";
            if (System.IO.File.Exists(xmlFilePath))
            {
                XDocument xmlDoc = XDocument.Load(xmlFilePath);
                XElement rescue = xmlDoc.Descendants("rescue").Where(x => x.Element("Rescat").Value == res).FirstOrDefault();
                if (rescue != null)
                {
                    string[] returnRes = new string[9];

                    returnRes[0] = rescue.Element("Jugador").Value;
                    returnRes[1] = rescue.Element("Rescat").Value;
                    returnRes[2] = rescue.Element("Data").Value;
                    returnRes[3] = rescue.Element("Superfamília").Value;
                    returnRes[4] = rescue.Element("GA").Value;
                    returnRes[5] = rescue.Element("Localització").Value;
                    returnRes[6] = rescue.Element("Espècie").Value;
                    returnRes[7] = rescue.Element("GANou").Value;
                    returnRes[8] = rescue.Element("Exp").Value;
                    MessageBox.Show("Jugador: " + returnRes[0] + "\nRescat: " + returnRes[1] + "\nData: " + returnRes[2] + "\nSuperfamília: " + returnRes[3] + "\nGA: " + returnRes[4] + "\nLocalització: " + returnRes[5] + "\nEspècie: " + returnRes[6] + "\nGANou: " + returnRes[7] + "\nExp: " + returnRes[8]);
                }
                else
                {
                    MessageBox.Show("Rescat no trobat");
                }
            }

        }
        /// <summary>
        /// Retorna tots els RES dels rescats del fitxer XML
        /// </summary>
        /// <returns></returns>
        public static string[] ReturnAllRES()
        {
            string xmlFilePath = @"..\..\..\GameData.xml";
            List<string> rescues = new List<string>();
            if (System.IO.File.Exists(xmlFilePath))
            {
                XDocument xmlDoc = XDocument.Load(xmlFilePath);
                foreach (XElement rescue in xmlDoc.Descendants("rescue"))
                {
                    rescues.Add(rescue.Element("Rescat").Value);
                }
            }
            return rescues.ToArray();
        }

    }
}
