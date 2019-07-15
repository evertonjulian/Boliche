namespace Boliche
{
    partial class Form1
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
            this.btnJogada = new System.Windows.Forms.Button();
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.numPinos = new System.Windows.Forms.NumericUpDown();
            this.btnNovoJogo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPinos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJogada
            // 
            this.btnJogada.Location = new System.Drawing.Point(130, 34);
            this.btnJogada.Name = "btnJogada";
            this.btnJogada.Size = new System.Drawing.Size(98, 40);
            this.btnJogada.TabIndex = 0;
            this.btnJogada.Text = "Informar Jogada";
            this.btnJogada.UseVisualStyleBackColor = true;
            this.btnJogada.Click += new System.EventHandler(this.btnJogada_Click);
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.Location = new System.Drawing.Point(31, 105);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(93, 13);
            this.lblPontuacao.TabIndex = 1;
            this.lblPontuacao.Text = "Pontuação Final: -";
            // 
            // numPinos
            // 
            this.numPinos.Location = new System.Drawing.Point(34, 46);
            this.numPinos.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPinos.Name = "numPinos";
            this.numPinos.Size = new System.Drawing.Size(64, 20);
            this.numPinos.TabIndex = 2;
            // 
            // btnNovoJogo
            // 
            this.btnNovoJogo.Location = new System.Drawing.Point(56, 147);
            this.btnNovoJogo.Name = "btnNovoJogo";
            this.btnNovoJogo.Size = new System.Drawing.Size(98, 40);
            this.btnNovoJogo.TabIndex = 3;
            this.btnNovoJogo.Text = "Novo jogo";
            this.btnNovoJogo.UseVisualStyleBackColor = true;
            this.btnNovoJogo.Click += new System.EventHandler(this.btnNovoJogo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 225);
            this.Controls.Add(this.btnNovoJogo);
            this.Controls.Add(this.numPinos);
            this.Controls.Add(this.lblPontuacao);
            this.Controls.Add(this.btnJogada);
            this.Name = "Form1";
            this.Text = "Jogo de boliche";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPinos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJogada;
        private System.Windows.Forms.Label lblPontuacao;
        private System.Windows.Forms.NumericUpDown numPinos;
        private System.Windows.Forms.Button btnNovoJogo;

    }
}

