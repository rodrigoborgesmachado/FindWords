using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public static class DocumentSerach
    {
        /// <summary>
        /// Método que busca no arquivo o texto passado por referência e retorna uma lista explicando cada incidência da palavra em forma de xml
        /// </summary>
        /// <param name="textoParaBusca"></param>
        /// <param name="file"></param>
        /// <param name="mensagemErro"></param>
        /// <returns></returns>
        public static List<string> BuscaEmArquivo(string textoParaBusca, FileInfo file, ref string mensagemErro)
        {
            Util.CL_Files.WriteOnTheLog("DocumentSerach.BuscaEmArquivo", Util.Global.TipoLog.DETALHADO);

            CL_Files fileToRead = new CL_Files(file.FullName);
            mensagemErro = "";
            List<string> texto_file = fileToRead.ReadArchive(ref mensagemErro);

            if (!string.IsNullOrEmpty(mensagemErro))
            {
                return null;
            }

            List<string> saida = new List<string>();
            int linha_texto = 0;

            foreach(string texto in texto_file)
            {
                if (texto.ToUpper().Contains(textoParaBusca.ToUpper()))
                {
                    StringBuilder saidaTexto = new StringBuilder();
                    saidaTexto.Append("\t<match>" + Environment.NewLine);
                    saidaTexto.Append("\t\t<sentence>" + Environment.NewLine);
                    saidaTexto.Append("\t\t\t" + textoParaBusca + Environment.NewLine);
                    saidaTexto.Append("\t\t</sentence>" + Environment.NewLine);
                    saidaTexto.Append("\t\t<file>" + Environment.NewLine);
                    saidaTexto.Append("\t\t\t" + file.FullName + Environment.NewLine);
                    saidaTexto.Append("\t\t</file>" + Environment.NewLine);
                    saidaTexto.Append("\t\t<line>" + Environment.NewLine);
                    saidaTexto.Append("\t\t\t" + linha_texto.ToString().Trim() + Environment.NewLine);
                    saidaTexto.Append("\t\t</line>" + Environment.NewLine);
                    saidaTexto.Append("\t\t<text>" + Environment.NewLine);
                    saidaTexto.Append("\t\t\t" + texto + Environment.NewLine);
                    saidaTexto.Append("\t\t</text>" + Environment.NewLine);
                    saidaTexto.Append("\t</match>" + Environment.NewLine);


                    saida.Add(saidaTexto.ToString());
                }
                linha_texto++;
            }

            fileToRead = null;
            texto_file.Clear();
            texto_file = null;

            return saida;
        }

        /// <summary>
        /// Método que efetua a busca nos arquivos xml do diretório e subdiretorio passado de referencia
        /// </summary>
        /// <param name="sentencas"></param>
        /// <param name="directory"></param>
        /// <param name="mensagemErro"></param>
        /// <returns></returns>
        public static List<string> BuscaEmDiretorioXML(List<string> sentencas, DirectoryInfo directory, ref string mensagemErro)
        {
            Util.CL_Files.WriteOnTheLog("DocumentSerach.BuscaEmDiretorioXML", Util.Global.TipoLog.DETALHADO);

            List<string> retorno = new List<string>();

            foreach (DirectoryInfo directorySub in directory.GetDirectories())
            {
                List<string> retornodir = BuscaEmDiretorioXML(sentencas, directorySub, ref mensagemErro);
                foreach(string dir in retornodir)
                {
                    retorno.Add(dir);
                }
                retornodir.Clear();
                retornodir = null;
            }

            foreach(FileInfo file in directory.GetFiles())
            {
                if(file.Extension == ".xml")
                {
                    foreach(string sentenca in sentencas)
                    {
                        List<string> doarquivo = BuscaEmArquivo(sentenca, file, ref mensagemErro);
                        foreach (string ret in doarquivo)
                        {
                            retorno.Add(ret);
                        }
                        doarquivo.Clear();
                        doarquivo = null;
                    }
                }
            }

            return retorno;
        }

        /// <summary>
        /// Método que efetua a busca nos arquivos através das sentencas passadas por referência
        /// </summary>
        /// <param name="sentencas">Sentencas de busca</param>
        /// <param name="diretorio">Diretório para efetuar a busca</param>
        /// <param name="mensagemErro">Mensagem de referência casa haja erro</param>
        /// <returns>True - foi possível efetuar a busca sem erro; False - houve erro na busca</returns>
        public static bool Busca(List<string> sentencas, string diretorio, string saida, ref string mensagemErro)
        {
            Util.CL_Files.WriteOnTheLog("DocumentSerach.Busca", Util.Global.TipoLog.DETALHADO);
            Util.CL_Files.WriteOnTheLog("Argumentos:" + sentencas.ToString() + "; " + diretorio + "; " + saida, Util.Global.TipoLog.DETALHADO);

            try
            {
                StringBuilder builder = new StringBuilder();
                DirectoryInfo dir = new DirectoryInfo(diretorio);
                List<string> buscas = BuscaEmDiretorioXML(sentencas, dir, ref mensagemErro);

                builder.Append("<?xml version=\"1.0\" encoding=\"UTF - 8\"?>" + Environment.NewLine);
                builder.Append("<result>" + Environment.NewLine);
                foreach(string busca in buscas)
                {
                    builder.Append(busca);
                }
                builder.Append("</result>");

                if (File.Exists(saida))
                    File.Delete(saida);

                CL_Files file_saida = new CL_Files(saida);
                file_saida.WriteOnTheEnd(builder.ToString());
                file_saida = null;
                buscas.Clear();
                buscas = null;
            }
            catch(Exception e)
            {
                mensagemErro += Environment.NewLine + "Houve erro ao tentar efetuar a busca! Verifique o log";
                CL_Files.WriteOnTheLog("Erro: " + e.Message, Global.TipoLog.SIMPLES);
                return false;
            }
            return true;
        }
    }
}
