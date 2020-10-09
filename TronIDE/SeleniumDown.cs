using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TronIDE
{
    class SeleniumDown
    {
        private Version versaoSelecionada;
        private string url = "https://chromedriver.storage.googleapis.com/";

        public List<Version> versoes
        {
            get
            {
                List<Version> lista = new List<Version>();
                XmlTextReader reader = null;

                try
                {
                    reader = new XmlTextReader(url);
                    reader.MoveToContent();

                    string nomeElemento = "";
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            nomeElemento = reader.Name;
                        }
                        
                        if (reader.NodeType == XmlNodeType.Text && nomeElemento == "Key")
                        {
                            string versao = reader.Value;

                            if (versao.EndsWith("/chromedriver_win32.zip"))
                            {
                                // valor antes da barra
                                versao = versao.Substring(0, versao.IndexOf("/"));
                                lista.Add(new Version(versao));
                            }
                        }
                    }
                }catch(Exception e) { }

                if (reader != null)
                {
                    reader.Close();
                }

                return lista;
            }
        }

    }
}
