namespace Wilberson_TesteSquadra
{
    partial class frmBussola
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDirecao = new System.Windows.Forms.Label();
            this.txtDirecao = new System.Windows.Forms.TextBox();
            this.lblPosicao = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(183, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(149, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "BÚSSOLA";
            // 
            // lblDirecao
            // 
            this.lblDirecao.AutoSize = true;
            this.lblDirecao.Location = new System.Drawing.Point(32, 85);
            this.lblDirecao.Name = "lblDirecao";
            this.lblDirecao.Size = new System.Drawing.Size(47, 13);
            this.lblDirecao.TabIndex = 1;
            this.lblDirecao.Text = "Direção:";
            // 
            // txtDirecao
            // 
            this.txtDirecao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDirecao.Location = new System.Drawing.Point(85, 82);
            this.txtDirecao.MaxLength = 15;
            this.txtDirecao.Name = "txtDirecao";
            this.txtDirecao.Size = new System.Drawing.Size(370, 20);
            this.txtDirecao.TabIndex = 2;
            this.txtDirecao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDirecao_KeyDown);
            this.txtDirecao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDirecao_KeyPress);
            // 
            // lblPosicao
            // 
            this.lblPosicao.AutoSize = true;
            this.lblPosicao.Location = new System.Drawing.Point(32, 120);
            this.lblPosicao.Name = "lblPosicao";
            this.lblPosicao.Size = new System.Drawing.Size(48, 13);
            this.lblPosicao.TabIndex = 3;
            this.lblPosicao.Text = "Posição:";
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(86, 117);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(369, 20);
            this.txtResultado.TabIndex = 4;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(189, 176);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar e reiniciar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmBussola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 218);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblPosicao);
            this.Controls.Add(this.txtDirecao);
            this.Controls.Add(this.lblDirecao);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.Name = "frmBussola";
            this.Text = "Bússola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDirecao;
        private System.Windows.Forms.TextBox txtDirecao;
        private System.Windows.Forms.Label lblPosicao;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnLimpar;
    }
}

