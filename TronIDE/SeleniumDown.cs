using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public bool baixarDriver(Version versao, string pasta)
        {
            try
            {
                string linkDownload = url + versao + "/chromedriver_win32.zip";
                string caminhoZip = Path.GetTempPath() + @"\chromedriver.zip";

                WebClient webClient = new WebClient();
                webClient.DownloadFile(linkDownload, caminhoZip);
                
                // Extrair e fechar o arquivo
                using (ZipArchive zip = ZipFile.Open(caminhoZip, ZipArchiveMode.Read))
                {
                    zip.ExtractToDirectory(pasta);
                }

                return true;
            }catch(Exception e)
            {
                MessageBox.Show("Erro ao fazer download do webdriver\n" + e.Message);
                return false;
            }
        }
    }
}
