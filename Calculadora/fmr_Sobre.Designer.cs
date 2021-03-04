namespace Calculadora
{
    partial class fmr_Sobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmr_Sobre));
            this.pic_Icone_Calculadora = new System.Windows.Forms.PictureBox();
            this.lbl_Calc_2020 = new System.Windows.Forms.Label();
            this.lbl_Assinatura = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Icone_Calculadora)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Icone_Calculadora
            // 
            this.pic_Icone_Calculadora.Image = global::Calculadora.Properties.Resources.calculator__1_;
            this.pic_Icone_Calculadora.Location = new System.Drawing.Point(23, 18);
            this.pic_Icone_Calculadora.Name = "pic_Icone_Calculadora";
            this.pic_Icone_Calculadora.Size = new System.Drawing.Size(252, 296);
            this.pic_Icone_Calculadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_Icone_Calculadora.TabIndex = 0;
            this.pic_Icone_Calculadora.TabStop = false;
            // 
            // lbl_Calc_2020
            // 
            this.lbl_Calc_2020.AutoSize = true;
            this.lbl_Calc_2020.Location = new System.Drawing.Point(75, 335);
            this.lbl_Calc_2020.Name = "lbl_Calc_2020";
            this.lbl_Calc_2020.Size = new System.Drawing.Size(148, 13);
            this.lbl_Calc_2020.TabIndex = 1;
            this.lbl_Calc_2020.Text = "Exemplo de Calculadora 2020";
            // 
            // lbl_Assinatura
            // 
            this.lbl_Assinatura.AutoSize = true;
            this.lbl_Assinatura.Location = new System.Drawing.Point(88, 355);
            this.lbl_Assinatura.Name = "lbl_Assinatura";
            this.lbl_Assinatura.Size = new System.Drawing.Size(123, 13);
            this.lbl_Assinatura.TabIndex = 2;
            this.lbl_Assinatura.Text = "Augusto Siqueira Gomes";
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(112, 376);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 3;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            // 
            // fmr_Sobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 411);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.lbl_Assinatura);
            this.Controls.Add(this.lbl_Calc_2020);
            this.Controls.Add(this.pic_Icone_Calculadora);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmr_Sobre";
            this.Text = "Sobre";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Icone_Calculadora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Icone_Calculadora;
        private System.Windows.Forms.Label lbl_Calc_2020;
        private System.Windows.Forms.Label lbl_Assinatura;
        private System.Windows.Forms.Button btn_Ok;
    }
}