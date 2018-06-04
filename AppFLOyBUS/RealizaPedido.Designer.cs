namespace AppFLOyBUS
{
    partial class RealizarPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealizarPedido));
            this.selecPlanta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valorDisponible = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.selectAdorno = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dLargo = new System.Windows.Forms.TextBox();
            this.dAncho = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comentarios = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nombreUsuario = new System.Windows.Forms.TextBox();
            this.btnEnviarPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // selecPlanta
            // 
            this.selecPlanta.FormattingEnabled = true;
            this.selecPlanta.Location = new System.Drawing.Point(62, 131);
            this.selecPlanta.Name = "selecPlanta";
            this.selecPlanta.Size = new System.Drawing.Size(257, 21);
            this.selecPlanta.TabIndex = 1;
            this.selecPlanta.SelectedIndexChanged += new System.EventHandler(this.itemselect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pedido N°";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(707, 423);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 63;
            this.lineShape1.X2 = 319;
            this.lineShape1.Y1 = 76;
            this.lineShape1.Y2 = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccione Planta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seleccione Adornos";
            // 
            // valorDisponible
            // 
            this.valorDisponible.Location = new System.Drawing.Point(62, 279);
            this.valorDisponible.Name = "valorDisponible";
            this.valorDisponible.Size = new System.Drawing.Size(257, 20);
            this.valorDisponible.TabIndex = 6;
            this.valorDisponible.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorDisponible_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(414, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // selectAdorno
            // 
            this.selectAdorno.FormattingEnabled = true;
            this.selectAdorno.Location = new System.Drawing.Point(62, 203);
            this.selectAdorno.Name = "selectAdorno";
            this.selectAdorno.Size = new System.Drawing.Size(257, 21);
            this.selectAdorno.TabIndex = 8;
            this.selectAdorno.SelectedIndexChanged += new System.EventHandler(this.adornoSelect);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Disponible a Pagar $:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dimensiones :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Largo";
            // 
            // dLargo
            // 
            this.dLargo.Location = new System.Drawing.Point(425, 278);
            this.dLargo.Name = "dLargo";
            this.dLargo.Size = new System.Drawing.Size(74, 20);
            this.dLargo.TabIndex = 12;
            this.dLargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorDisponible_KeyPress);
            // 
            // dAncho
            // 
            this.dAncho.Location = new System.Drawing.Point(577, 278);
            this.dAncho.Name = "dAncho";
            this.dAncho.Size = new System.Drawing.Size(77, 20);
            this.dAncho.TabIndex = 13;
            this.dAncho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorDisponible_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(533, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ancho";
            // 
            // comentarios
            // 
            this.comentarios.Location = new System.Drawing.Point(64, 340);
            this.comentarios.Multiline = true;
            this.comentarios.Name = "comentarios";
            this.comentarios.Size = new System.Drawing.Size(255, 44);
            this.comentarios.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Comentarios";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(357, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nombre";
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.Location = new System.Drawing.Point(360, 364);
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.Size = new System.Drawing.Size(157, 20);
            this.nombreUsuario.TabIndex = 18;
            // 
            // btnEnviarPedido
            // 
            this.btnEnviarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEnviarPedido.FlatAppearance.BorderSize = 0;
            this.btnEnviarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarPedido.ForeColor = System.Drawing.Color.DarkRed;
            this.btnEnviarPedido.Location = new System.Drawing.Point(536, 340);
            this.btnEnviarPedido.Name = "btnEnviarPedido";
            this.btnEnviarPedido.Size = new System.Drawing.Size(119, 44);
            this.btnEnviarPedido.TabIndex = 19;
            this.btnEnviarPedido.Text = "Enviar Pedido";
            this.btnEnviarPedido.UseVisualStyleBackColor = false;
            this.btnEnviarPedido.Click += new System.EventHandler(this.btnEnviarPedido_Click);
            // 
            // RealizarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 423);
            this.Controls.Add(this.btnEnviarPedido);
            this.Controls.Add(this.nombreUsuario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comentarios);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dAncho);
            this.Controls.Add(this.dLargo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.selectAdorno);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.valorDisponible);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selecPlanta);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "RealizarPedido";
            this.Text = "Realizar Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selecPlanta;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox valorDisponible;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox selectAdorno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dLargo;
        private System.Windows.Forms.TextBox dAncho;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox comentarios;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nombreUsuario;
        private System.Windows.Forms.Button btnEnviarPedido;

    }
}