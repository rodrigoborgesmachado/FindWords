using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindWords
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Util.CL_Files.CreateMainDirectories();
            if (args.Length == 0)
            {
                AbreAplicacaoVisual();
            }
            else
            {
                AbreAplicacaoLinhaComando(args.ToList());
            }
        }

        /// <summary>
        /// Método que abre interface do programa
        /// </summary>
        private static void AbreAplicacaoVisual()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Fo_Principal());
        }

        /// <summary>
        /// Método que abre aplicação para execução dos comandos
        /// </summary>
        /// <param name="comandos"></param>
        private static void AbreAplicacaoLinhaComando(List<string> comandos)
        {
            if(comandos.Count < 6)
            {
                Util.CL_Files.WriteOnTheLog("Não há argumentos suficientes", Util.Global.TipoLog.SIMPLES);
                return;
            }
            
            List<string> sentenca = new List<string>();
            string caminho_busca = string.Empty;
            string caminho_saida = string.Empty;

            bool sentencas = false;
            bool caminhoBusca = false;
            bool caminhoSaida = false;

            foreach(string comando in comandos)
            {
                if (comando.ToLower() == "-s")
                {
                    sentencas = true;
                }
                else if (comando.ToLower().Equals("-i"))
                {
                    caminhoBusca = true;
                }
                else if (comando.ToLower().Equals("-o"))
                {
                    caminhoSaida = true;
                }
                else if (comando.ToLower().Equals("-l"))
                {
                    Util.Global.log_system = Util.Global.TipoLog.DETALHADO;
                }
                else if (sentencas)
                {
                    sentencas = false;
                    sentenca = comando.Split(';').ToList();
                }
                else if (caminhoBusca)
                {
                    caminhoBusca = false;
                    caminho_busca = comando;
                }
                else if (caminhoSaida)
                {
                    caminhoSaida = false;
                    caminho_saida = comando;
                }
            }

            string mensagem = string.Empty;
            if(Util.DocumentSerach.Busca(sentenca, caminho_busca, caminho_saida, ref mensagem))
            {
                Util.CL_Files.WriteOnTheLog("Busca efetuada com sucesso e arquivo disponibilizado no caminho " + caminho_saida, Util.Global.TipoLog.SIMPLES);
                System.Console.WriteLine("Busca efetuada com sucesso e arquivo disponibilizado no caminho " + caminho_saida);
            }
            else
            {
                Util.CL_Files.WriteOnTheLog("Não foi possível efetuar a busca", Util.Global.TipoLog.SIMPLES);
                System.Console.WriteLine("Não foi possível efetuar a busca" + caminho_saida);
            }
        }
    }
}
