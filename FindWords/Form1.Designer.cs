namespace FindWords
{
    partial class Fo_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fo_Principal));
            this.pan_total = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ckb_log_detalhado = new System.Windows.Forms.CheckBox();
            this.lbl_busca = new System.Windows.Forms.Label();
            this.grb_saida = new System.Windows.Forms.GroupBox();
            this.btn_folder = new System.Windows.Forms.Button();
            this.lbl_caminhoSaida = new System.Windows.Forms.Label();
            this.tbx_saida = new System.Windows.Forms.TextBox();
            this.tbx_sentencas = new System.Windows.Forms.TextBox();
            this.pan_botoes = new System.Windows.Forms.Panel();
            this.btn_gerar = new System.Windows.Forms.Button();
            this.tbx_diretorioBusca = new System.Windows.Forms.TextBox();
            this.lbl_diretorioBusca = new System.Windows.Forms.Label();
            this.btn_diretorioBusca = new System.Windows.Forms.Button();
            this.pan_total.SuspendLayout();
            this.panel4.SuspendLayout();
            this.grb_saida.SuspendLayout();
            this.pan_botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_total
            // 
            this.pan_total.BackColor = System.Drawing.Color.Transparent;
            this.pan_total.Controls.Add(this.panel4);
            this.pan_total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_total.Location = new System.Drawing.Point(0, 0);
            this.pan_total.Name = "pan_total";
            this.pan_total.Size = new System.Drawing.Size(397, 195);
            this.pan_total.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ckb_log_detalhado);
            this.panel4.Controls.Add(this.lbl_busca);
            this.panel4.Controls.Add(this.grb_saida);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(397, 158);
            this.panel4.TabIndex = 8;
            // 
            // ckb_log_detalhado
            // 
            this.ckb_log_detalhado.AutoSize = true;
            this.ckb_log_detalhado.Location = new System.Drawing.Point(11, 76);
            this.ckb_log_detalhado.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ckb_log_detalhado.Name = "ckb_log_detalhado";
            this.ckb_log_detalhado.Size = new System.Drawing.Size(135, 17);
            this.ckb_log_detalhado.TabIndex = 19;
            this.ckb_log_detalhado.Text = "Gerar Logs Detalhados";
            this.ckb_log_detalhado.UseVisualStyleBackColor = true;
            this.ckb_log_detalhado.CheckedChanged += new System.EventHandler(this.ckb_log_detalhado_CheckedChanged);
            // 
            // lbl_busca
            // 
            this.lbl_busca.AutoSize = true;
            this.lbl_busca.Location = new System.Drawing.Point(6, 23);
            this.lbl_busca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_busca.Name = "lbl_busca";
            this.lbl_busca.Size = new System.Drawing.Size(229, 13);
            this.lbl_busca.TabIndex = 0;
            this.lbl_busca.Text = "Sentencas (se for mais de uma dividir com \"\\;\")";
            // 
            // grb_saida
            // 
            this.grb_saida.BackColor = System.Drawing.Color.Transparent;
            this.grb_saida.Controls.Add(this.tbx_sentencas);
            this.grb_saida.Controls.Add(this.btn_diretorioBusca);
            this.grb_saida.Controls.Add(this.btn_folder);
            this.grb_saida.Controls.Add(this.lbl_diretorioBusca);
            this.grb_saida.Controls.Add(this.tbx_diretorioBusca);
            this.grb_saida.Controls.Add(this.lbl_caminhoSaida);
            this.grb_saida.Controls.Add(this.tbx_saida);
            this.grb_saida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_saida.Location = new System.Drawing.Point(0, 0);
            this.grb_saida.Name = "grb_saida";
            this.grb_saida.Size = new System.Drawing.Size(397, 158);
            this.grb_saida.TabIndex = 2;
            this.grb_saida.TabStop = false;
            this.grb_saida.Text = "Search";
            // 
            // btn_folder
            // 
            this.btn_folder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_folder.Location = new System.Drawing.Point(317, 132);
            this.btn_folder.Name = "btn_folder";
            this.btn_folder.Size = new System.Drawing.Size(61, 24);
            this.btn_folder.TabIndex = 20;
            this.btn_folder.Text = "Folder";
            this.btn_folder.UseVisualStyleBackColor = true;
            this.btn_folder.Click += new System.EventHandler(this.btn_folder_Click);
            // 
            // lbl_caminhoSaida
            // 
            this.lbl_caminhoSaida.AutoSize = true;
            this.lbl_caminhoSaida.Location = new System.Drawing.Point(9, 135);
            this.lbl_caminhoSaida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_caminhoSaida.Name = "lbl_caminhoSaida";
            this.lbl_caminhoSaida.Size = new System.Drawing.Size(98, 13);
            this.lbl_caminhoSaida.TabIndex = 0;
            this.lbl_caminhoSaida.Text = "Caminho de Saída:";
            // 
            // tbx_saida
            // 
            this.tbx_saida.Location = new System.Drawing.Point(130, 132);
            this.tbx_saida.Name = "tbx_saida";
            this.tbx_saida.Size = new System.Drawing.Size(181, 20);
            this.tbx_saida.TabIndex = 1;
            // 
            // tbx_sentencas
            // 
            this.tbx_sentencas.Location = new System.Drawing.Point(11, 39);
            this.tbx_sentencas.Name = "tbx_sentencas";
            this.tbx_sentencas.Size = new System.Drawing.Size(300, 20);
            this.tbx_sentencas.TabIndex = 21;
            // 
            // pan_botoes
            // 
            this.pan_botoes.BackColor = System.Drawing.Color.Transparent;
            this.pan_botoes.Controls.Add(this.btn_gerar);
            this.pan_botoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_botoes.Location = new System.Drawing.Point(0, 158);
            this.pan_botoes.Name = "pan_botoes";
            this.pan_botoes.Size = new System.Drawing.Size(397, 37);
            this.pan_botoes.TabIndex = 23;
            // 
            // btn_gerar
            // 
            this.btn_gerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_gerar.Location = new System.Drawing.Point(271, 6);
            this.btn_gerar.Name = "btn_gerar";
            this.btn_gerar.Size = new System.Drawing.Size(107, 28);
            this.btn_gerar.TabIndex = 21;
            this.btn_gerar.Text = "Gerar";
            this.btn_gerar.UseVisualStyleBackColor = true;
            this.btn_gerar.Click += new System.EventHandler(this.btn_gerar_Click);
            // 
            // tbx_diretorioBusca
            // 
            this.tbx_diretorioBusca.Location = new System.Drawing.Point(130, 104);
            this.tbx_diretorioBusca.Name = "tbx_diretorioBusca";
            this.tbx_diretorioBusca.Size = new System.Drawing.Size(181, 20);
            this.tbx_diretorioBusca.TabIndex = 1;
            // 
            // lbl_diretorioBusca
            // 
            this.lbl_diretorioBusca.AutoSize = true;
            this.lbl_diretorioBusca.Location = new System.Drawing.Point(9, 107);
            this.lbl_diretorioBusca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_diretorioBusca.Name = "lbl_diretorioBusca";
            this.lbl_diretorioBusca.Size = new System.Drawing.Size(96, 13);
            this.lbl_diretorioBusca.TabIndex = 0;
            this.lbl_diretorioBusca.Text = "Diretório de busca:";
            // 
            // btn_diretorioBusca
            // 
            this.btn_diretorioBusca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_diretorioBusca.Location = new System.Drawing.Point(317, 104);
            this.btn_diretorioBusca.Name = "btn_diretorioBusca";
            this.btn_diretorioBusca.Size = new System.Drawing.Size(61, 24);
            this.btn_diretorioBusca.TabIndex = 20;
            this.btn_diretorioBusca.Text = "Folder";
            this.btn_diretorioBusca.UseVisualStyleBackColor = true;
            this.btn_diretorioBusca.Click += new System.EventHandler(this.btn_diretorioBusca_Click);
            // 
            // Fo_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(397, 195);
            this.Controls.Add(this.pan_botoes);
            this.Controls.Add(this.pan_total);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Fo_Principal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.pan_total.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.grb_saida.ResumeLayout(false);
            this.grb_saida.PerformLayout();
            this.pan_botoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_total;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox ckb_log_detalhado;
        private System.Windows.Forms.Label lbl_busca;
        private System.Windows.Forms.GroupBox grb_saida;
        private System.Windows.Forms.Button btn_folder;
        private System.Windows.Forms.Label lbl_caminhoSaida;
        private System.Windows.Forms.TextBox tbx_saida;
        private System.Windows.Forms.TextBox tbx_sentencas;
        private System.Windows.Forms.Panel pan_botoes;
        private System.Windows.Forms.Button btn_gerar;
        private System.Windows.Forms.Button btn_diretorioBusca;
        private System.Windows.Forms.Label lbl_diretorioBusca;
        private System.Windows.Forms.TextBox tbx_diretorioBusca;
    }
}

