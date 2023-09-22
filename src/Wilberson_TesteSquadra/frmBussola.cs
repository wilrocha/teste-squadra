using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wilberson_TesteSquadra.Class;

namespace Wilberson_TesteSquadra
{
    public partial class frmBussola : Form
    {
        #region Atributos
        //Flag de tecla inválida pressionada
        private bool teclaInvalida = false;

        //Atributos classe Bussola
        private Bussola bussola = null;

        #endregion

        #region Propriedades
        //Propriedade que retorna uma instância da classe Bussola
        protected Bussola Bussola
        {
            get
            {
                if (bussola == null)
                    bussola = new Bussola();

                return bussola;
            }
        }
        #endregion

        #region Construtores
        public frmBussola()
        {
            InitializeComponent();
        }
        #endregion

       

        #region Eventos

        private void txtDirecao_KeyDown(object sender, KeyEventArgs e)
        {
            //Verifica se as teclas pressionadas estão entre A e Z
            if ((e.KeyValue >= 65 && e.KeyValue <= 90))
            {
                string teclaPressionada = e.KeyCode.ToString().ToUpper();

                if (e.KeyCode == Keys.D || e.KeyCode == Keys.E)
                {
                    teclaInvalida = false;
                    this.Bussola.CalcularNovaDirecao(teclaPressionada);
                    txtResultado.Text += Bussola.DirecaoAtual.ToString();
                }
                else
                {
                    teclaInvalida = true;
                }
            }
            else if (e.KeyCode == Keys.Back)//Caso contrário, verifica se a tecla é o BACKSPACE
            {
                int selStart = txtDirecao.SelectionStart;
                int selLength = txtDirecao.SelectionLength;
                int textLength = txtDirecao.TextLength;

                //Este condicional verifica a condição do campo de direção no momento que a tecla backspace é pressionada
                // Neste primeiro caso, significa que ele efetuou a seleção de todo o texto digitado no campo "Direção"
                if (textLength == selLength)
                {
                    txtResultado.Text = string.Empty;
                }
                else if (textLength > selLength && selStart < textLength) //Neste caso, não foi selecionado o texto todo para deleção
                {
                    string subResult = txtResultado.Text.Remove(selStart);
                    txtResultado.Text = subResult;
                }
                else //Neste caso, apaga uma letra por vez
                {
                    string subResult = txtResultado.Text.Remove(selStart - 1);
                    txtResultado.Text = subResult;
                }
            }
            else 
            {
                teclaInvalida = true;
            }
        }

        //Não permite que uma tecla inválida seja inserida
        private void txtDirecao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (teclaInvalida)
                e.Handled = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDirecao.Text = string.Empty;
            txtResultado.Text = string.Empty;
            this.Bussola.DirecaoAtual = DirecaoEnum.None;
        }
        #endregion

      

    }
}
