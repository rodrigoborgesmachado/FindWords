using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public static class Global
    {
        public enum TipoLog
        {
            DETALHADO = 0,
            SIMPLES = 1
        }

        // Caminho principal da aplicação
        public static string app_main_directoty = System.IO.Directory.GetCurrentDirectory() + "\\";

        // Caminho da pasta de arquivos do sistema
        public static string app_files_directory = app_main_directoty + "Files\\";

        // Caminho arquivo de saida
        public static string app_fileSaida_file = app_files_directory + "saida.xml";

        // Caminho da pasta de logs do sistema
        public static string app_logs_directoty = app_main_directoty + "Log\\";

        // Caminho da pasta de arquivos temporários
        public static string app_temp_directory = app_main_directoty + "TEMP\\";

        // Nome do diretório de saída
        public static string app_out_directory = app_main_directoty + "OUT\\";

        // Nome do diretório de configuração
        public static string app_conf_directory = app_main_directoty + "CONF\\";

        public static TipoLog log_system = TipoLog.SIMPLES;
    }
}
