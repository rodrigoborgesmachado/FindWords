using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindWords
{
    public partial class Fo_Principal : Form
    {
        #region Enumeradores

        private enum TipoDiretorio
        {
            PESQUISA = 0,
            SAIDA = 1
        }

        #endregion Enumeradores

        #region Eventos

        private void ckb_log_detalhado_CheckedChanged(object sender, EventArgs e)
        {
            Util.Global.log_system = ckb_log_detalhado.Checked ? Util.Global.TipoLog.DETALHADO : Util.Global.TipoLog.SIMPLES;
        }

        private void btn_folder_Click(object sender, EventArgs e)
        {
            this.AbreSelecaoDiretorio(TipoDiretorio.SAIDA);
        }

        private void btn_diretorioBusca_Click(object sender, EventArgs e)
        {
            this.AbreSelecaoDiretorio(TipoDiretorio.PESQUISA);
        }

        private void btn_gerar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        #endregion Eventos

        #region Construtores

        public Fo_Principal()
        {
            InitializeComponent();
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que abre a seleção do diretório
        /// </summary>
        /// <param name="tipo">Identifica se é para seleção da busca ou da saída do resultado</param>
        private void AbreSelecaoDiretorio(TipoDiretorio tipo)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = tipo == TipoDiretorio.PESQUISA ? "Diretório para busca nos arquivos." : "Diretório para saída do resultado.";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if(tipo == TipoDiretorio.SAIDA)
                {
                    this.tbx_saida.Text = dialog.SelectedPath.ToString();
                }
                else
                {
                    this.tbx_diretorioBusca.Text = dialog.SelectedPath.ToString();
                }
            }
        }

        /// <summary>
        /// Método que valida se os campos foram preenchidos corretamente
        /// </summary>
        /// <param name="mensagem"></param>
        /// <returns></returns>
        private bool ValidarCampos(ref string mensagem)
        {
            bool valido = true;

            if (string.IsNullOrEmpty(this.tbx_sentencas.Text))
            {
                mensagem = "Nenhuma sentenca de busca!";
                this.tbx_sentencas.Focus();
                valido = false;
            }
            else if (string.IsNullOrEmpty(this.tbx_diretorioBusca.Text))
            {
                mensagem = "Nenhum diretório de busca selecionado!";
                this.tbx_diretorioBusca.Focus();
                valido = false;
            }
            else if (!System.IO.Directory.Exists(this.tbx_diretorioBusca.Text))
            {
                mensagem = "Diretorio de busca não existe!";
                valido = false;
            }

            return valido;
        }

        /// <summary>
        /// Método que faz a busca das palavras
        /// </summary>
        private void Buscar()
        {
            string mensagem = string.Empty;
            if(this.ValidarCampos(ref mensagem))
            {
                btn_gerar.Enabled = false;
                List<string> sentenca = this.tbx_sentencas.Text.Split(';').ToList();
                string saida = string.IsNullOrEmpty(this.tbx_saida.Text) ? Util.Global.app_fileSaida_file : (Directory.Exists(this.tbx_saida.Text) ? this.tbx_saida.Text + "\\saida.xml" : Util.Global.app_fileSaida_file);
                if(Util.DocumentSerach.Busca(sentenca, this.tbx_diretorioBusca.Text, saida, ref mensagem))
                {
                    MessageBox.Show("Busca Efetuada com sucesso! O arquivo de saída se encontra em " + saida, "Sucesso!");
                }
                else
                {
                    MessageBox.Show("Houve erro na busca, verificar log", "Erro");
                }
                btn_gerar.Enabled = true;
            }
            else
            {
                MessageBox.Show(mensagem, "Atenção!");
            }
        }

        #endregion Métodos

    }
}
