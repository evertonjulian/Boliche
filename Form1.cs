using Boliche.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boliche
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        JogoDeBoliche jogo;

        private void Form1_Load(object sender, EventArgs e)
        {
            jogo = new JogoDeBoliche();
        }

        private void btnJogada_Click(object sender, EventArgs e)
        {
            var pinosDerrubados = Convert.ToInt32(numPinos.Value);
                                    
            jogo.Jogar(pinosDerrubados);

            if (jogo.jogadaAtual % 2 == 0)
                numPinos.Maximum = 10 - pinosDerrubados;
            else
                numPinos.Maximum = 10;

            if (pinosDerrubados == 10 
                && jogo.jogadaAtual % 2 != 0 
                && jogo.jogadaAtual < 19)
            {
                jogo.Jogar(0);
                numPinos.Maximum = 10;
            }
            
            if (jogo.fimDoJogo)
            {
                var pontuacao = jogo.ObterPontuacao();
                lblPontuacao.Text = "Pontuação Final: " + pontuacao;
                btnJogada.Enabled = false;
            }

            numPinos.Value = 0;
        }

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            jogo = new JogoDeBoliche();
            lblPontuacao.Text = "Pontuação Final: -";
            numPinos.Maximum = 10;
            btnJogada.Enabled = true;
        }
    }
}
