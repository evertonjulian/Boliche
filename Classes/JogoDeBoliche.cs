using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boliche.Classes
{
    class JogoDeBoliche
    {
        private int[] jogadas;
        public int jogadaAtual;
        public bool fimDoJogo;

        public JogoDeBoliche()
        {
            jogadas = new int[21];
            jogadaAtual = 0;
            fimDoJogo = false;
        }

        public void Jogar(int pinos)
        {
            jogadas[jogadaAtual] = pinos;
                        
            fimDoJogo = ((jogadaAtual == 20) || 
                         (jogadaAtual == 19 && pinos == 10));

            if (!fimDoJogo)            
                jogadaAtual++;
        }

        public int ObterPontuacao()
        {
            var pontuacao = 0;
            int jogada = 0;

            for (int quadro = 0; quadro < 10; quadro++)
            {
                if (FoiStrike(jogada))
                {
                    pontuacao += 10 + StrikeBonus(jogada);
                    jogada += 2;
                }
                else if (FoiSpare(jogada))
                {
                    pontuacao += 10 + SpareBonus(jogada);
                    jogada += 2;
                }
                else
                {
                    pontuacao += SomaDoQuadro(jogada);
                    jogada += 2;
                }
            }

            return pontuacao;
        }

        private bool FoiStrike(int jogada)
        {
            return jogadas[jogada] == 10;
        }

        private bool FoiSpare(int jogada)
        {
            return jogadas[jogada] + jogadas[jogada + 1] == 10;
        }

        private int SpareBonus(int jogada)
        {
            return jogadas[jogada + 2];
        }

        private int StrikeBonus(int jogada)
        {
            return jogadas[jogada + 1] + jogadas[jogada + 2];
        }

        private int SomaDoQuadro(int jogada)
        {
            return jogadas[jogada] + jogadas[jogada + 1];
        }
    }
}
