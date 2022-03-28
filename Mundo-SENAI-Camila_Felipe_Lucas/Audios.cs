using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Mundo_SENAI_Camila_Felipe_Lucas
{
    class Audios
    {
        public SoundPlayer inico_fim = new SoundPlayer(@"Audio e videos\Wallpaper - Kevin MacLeod.wav");

        public SoundPlayer fase1 = new SoundPlayer(@"Audio e videos\Fase 1 lukinhas.wav");
        public SoundPlayer fase1_acertou = new SoundPlayer(@"Audio e videos\Fase 1 passou.wav");
        public SoundPlayer fase1_errou = new SoundPlayer(@"Audio e videos\fase 1 errou.wav");
        public SoundPlayer fase1_esqueceu = new SoundPlayer(@"Audio e videos\esqueceu1.wav");

        public SoundPlayer fase2 = new SoundPlayer(@"Audio e videos\Fase2Frase.wav");
        public SoundPlayer fase2_acertou = new SoundPlayer(@"Audio e videos\Fase2Acertou.wav");
        public SoundPlayer fase2_errou = new SoundPlayer(@"Audio e videos\fase 2 errou.wav");
        public SoundPlayer fase2_esqueceu = new SoundPlayer(@"Audio e videos\esqueceu2.wav");
        public SoundPlayer prato = new SoundPlayer(@"Audio e videos\Prato.wav");

        public SoundPlayer fase3 = new SoundPlayer(@"Audio e videos\Fase03Frase.wav");
        public SoundPlayer fase3_acertou = new SoundPlayer(@"Audio e videos\Fase3AcertouUaw.wav");
        public SoundPlayer fase3_errou = new SoundPlayer(@"Audio e videos\fase3 errou.wav");
        public SoundPlayer fase3_esqueceu = new SoundPlayer(@"Audio e videos\esqueceu3.wav");
        public SoundPlayer mochila = new SoundPlayer(@"Audio e videos\Mochila.wav");

        public SoundPlayer fase4 = new SoundPlayer(@"Audio e videos\Escola.wav");
        public SoundPlayer fase4_lembrete = new SoundPlayer(@"Audio e videos\Escola_lembrete.wav");
        public SoundPlayer fase4_esqueceu = new SoundPlayer(@"Audio e videos\esqueceu4.wav");
        public SoundPlayer fase4_acertou = new SoundPlayer(@"Audio e videos\EscolaCerto.wav");
        public SoundPlayer fase4_errou = new SoundPlayer(@"Audio e videos\Escola errou.wav");

        public SoundPlayer fase5 = new SoundPlayer(@"Audio e videos\Fase5Fala.wav");
        public SoundPlayer fase5_acertou = new SoundPlayer(@"Audio e videos\Fase5Acertou.wav");
        public SoundPlayer fase5_errou = new SoundPlayer(@"Audio e videos\Fase5Errou.wav");
        public SoundPlayer fase5_esqueceu = new SoundPlayer(@"Audio e videos\esqueceu5.wav");

        public SoundPlayer fase6 = new SoundPlayer(@"Audio e videos\Fase 06Normal.wav");
        public SoundPlayer fase6_errou = new SoundPlayer(@"Audio e videos\esqueceu6.wav");
        public SoundPlayer bau = new SoundPlayer(@"Audio e videos\Bau.wav");

    }
}
