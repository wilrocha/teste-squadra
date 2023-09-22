using System;

namespace Wilberson_TesteSquadra.Class
{
    public class Bussola
    {
        //Constante que marca a direção inicial
        public const DirecaoEnum DIRECAO_INICIAL = DirecaoEnum.N;

        //Propriedades
        public DirecaoEnum DirecaoAtual { get; set; }


        /// <summary>
        /// Calcula a nova posição
        /// </summary>
        /// <param name="direcaoVirada">Direção da virada</param>
        public void CalcularNovaDirecao(string direcaoVirada)
        {
            ViraEnum novaDirecaoVirada = (ViraEnum)Enum.Parse(typeof(ViraEnum), direcaoVirada, true);

            if (DirecaoAtual == DirecaoEnum.None)
                DirecaoAtual = DIRECAO_INICIAL;

            //Lógica: primeiro é verificada a direção que está virando (Direita ou Esquerda). Depois, a partir da posição atual é que a nova direção é setada
            if (novaDirecaoVirada == ViraEnum.D)
            {
                switch (DirecaoAtual) 
                {
                    case DirecaoEnum.N:
                        DirecaoAtual = DirecaoEnum.L;
                        break;
                    case DirecaoEnum.L:
                        DirecaoAtual = DirecaoEnum.S;
                        break;
                    case DirecaoEnum.S:
                        DirecaoAtual = DirecaoEnum.O;
                        break;
                    case DirecaoEnum.O:
                        DirecaoAtual = DirecaoEnum.N;
                        break;
                }
            }
            else if (novaDirecaoVirada == ViraEnum.E)
            {
                switch (DirecaoAtual)
                { 
                    case DirecaoEnum.N:
                        DirecaoAtual = DirecaoEnum.O;
                        break;
                    case DirecaoEnum.O:
                        DirecaoAtual = DirecaoEnum.S;
                        break;
                    case DirecaoEnum.S:
                        DirecaoAtual = DirecaoEnum.L;
                        break;
                    case DirecaoEnum.L:
                        DirecaoAtual = DirecaoEnum.N;
                        break;
                }
            }
                
        }

    }
}
