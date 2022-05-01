using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo
{
     class Game
    {
        public enum Resultado
        {
            Ganhar, Perder, Empatar
        }

        public static Image[] imagens =
        {
            Image.FromFile("imagens/Pedra.png"),
            Image.FromFile("imagens/Papel.png"),
            Image.FromFile("imagens/Tesoura.png")
        };

        public Image imgPC { get; private set; }
        public Image imgJogador { get; private set; }

        public Resultado Jogar(int jogador)
        {
            int pc = JogadaPC();

            imgJogador = imagens[jogador];
            imgPC = imagens[pc];

            if(jogador == pc)
            {
                return Resultado.Empatar;

            } else if((jogador == 0 && pc == 2) || (jogador == 1 && pc == 0) || (jogador == 2 && pc == 1))
            {
                return Resultado.Ganhar;

            } else
            {
                return Resultado.Perder;
            }
        }

        private int JogadaPC()
        {
           int mil = DateTime.Now.Millisecond;
           int PcJogou;

            if(mil <= 333)
            {
                return 0;

            } else if(mil <= 666 && mil > 333)
            {
                return 1;

            } else 
            {
                return 2;
            }
        }
    }
}
