namespace PF_Y8375118G_49275680C
{
    partial class Form5
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.tb_preciofinal = new System.Windows.Forms.TextBox();
            this.btn_comprar = new System.Windows.Forms.Button();
            this.tb_lista_pizzas = new System.Windows.Forms.TextBox();
            this.btn_anadir = new System.Windows.Forms.Button();
            this.cb_pizzas = new System.Windows.Forms.ComboBox();
            this.lbl_nompizzas = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_pizzas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pizzas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.White;
            this.btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(372, 395);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(121, 46);
            this.btn_salir.TabIndex = 29;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // tb_preciofinal
            // 
            this.tb_preciofinal.Location = new System.Drawing.Point(723, 37);
            this.tb_preciofinal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_preciofinal.Multiline = true;
            this.tb_preciofinal.Name = "tb_preciofinal";
            this.tb_preciofinal.Size = new System.Drawing.Size(140, 34);
            this.tb_preciofinal.TabIndex = 28;
            this.tb_preciofinal.TextChanged += new System.EventHandler(this.tb_preciofinal_TextChanged);
            // 
            // btn_comprar
            // 
            this.btn_comprar.BackColor = System.Drawing.Color.White;
            this.btn_comprar.Enabled = false;
            this.btn_comprar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_comprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comprar.Location = new System.Drawing.Point(372, 345);
            this.btn_comprar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(121, 46);
            this.btn_comprar.TabIndex = 27;
            this.btn_comprar.Text = "Comprar";
            this.btn_comprar.UseVisualStyleBackColor = false;
            this.btn_comprar.Click += new System.EventHandler(this.btn_comprar_Click);
            // 
            // tb_lista_pizzas
            // 
            this.tb_lista_pizzas.BackColor = System.Drawing.SystemColors.Window;
            this.tb_lista_pizzas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_lista_pizzas.Location = new System.Drawing.Point(372, 37);
            this.tb_lista_pizzas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_lista_pizzas.Multiline = true;
            this.tb_lista_pizzas.Name = "tb_lista_pizzas";
            this.tb_lista_pizzas.Size = new System.Drawing.Size(296, 304);
            this.tb_lista_pizzas.TabIndex = 26;
            this.tb_lista_pizzas.TextChanged += new System.EventHandler(this.tb_lista_pizzas_TextChanged);
            // 
            // btn_anadir
            // 
            this.btn_anadir.BackColor = System.Drawing.Color.White;
            this.btn_anadir.Enabled = false;
            this.btn_anadir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_anadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anadir.Location = new System.Drawing.Point(12, 281);
            this.btn_anadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_anadir.Name = "btn_anadir";
            this.btn_anadir.Size = new System.Drawing.Size(121, 46);
            this.btn_anadir.TabIndex = 25;
            this.btn_anadir.Text = "Añadir";
            this.btn_anadir.UseVisualStyleBackColor = false;
            this.btn_anadir.Click += new System.EventHandler(this.btn_anadir_Click);
            // 
            // cb_pizzas
            // 
            this.cb_pizzas.FormattingEnabled = true;
            this.cb_pizzas.Location = new System.Drawing.Point(12, 254);
            this.cb_pizzas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_pizzas.Name = "cb_pizzas";
            this.cb_pizzas.Size = new System.Drawing.Size(225, 24);
            this.cb_pizzas.TabIndex = 23;
            this.cb_pizzas.SelectedIndexChanged += new System.EventHandler(this.cb_pizzas_SelectedIndexChanged);
            // 
            // lbl_nompizzas
            // 
            this.lbl_nompizzas.AutoSize = true;
            this.lbl_nompizzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nompizzas.Location = new System.Drawing.Point(9, 10);
            this.lbl_nompizzas.Name = "lbl_nompizzas";
            this.lbl_nompizzas.Size = new System.Drawing.Size(62, 17);
            this.lbl_nompizzas.TabIndex = 22;
            this.lbl_nompizzas.Text = "PIZZAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PF_Y8375118G_49275680C.Properties.Resources.logo_pizza;
            this.pictureBox1.Location = new System.Drawing.Point(676, 212);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pb_pizzas
            // 
            this.pb_pizzas.Location = new System.Drawing.Point(12, 37);
            this.pb_pizzas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_pizzas.Name = "pb_pizzas";
            this.pb_pizzas.Size = new System.Drawing.Size(341, 213);
            this.pb_pizzas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_pizzas.TabIndex = 24;
            this.pb_pizzas.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(965, 492);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.tb_preciofinal);
            this.Controls.Add(this.btn_comprar);
            this.Controls.Add(this.tb_lista_pizzas);
            this.Controls.Add(this.btn_anadir);
            this.Controls.Add(this.pb_pizzas);
            this.Controls.Add(this.cb_pizzas);
            this.Controls.Add(this.lbl_nompizzas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form5";
            this.Text = "Comprar pizzas";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pizzas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.TextBox tb_preciofinal;
        private System.Windows.Forms.Button btn_comprar;
        private System.Windows.Forms.TextBox tb_lista_pizzas;
        private System.Windows.Forms.Button btn_anadir;
        private System.Windows.Forms.PictureBox pb_pizzas;
        public System.Windows.Forms.ComboBox cb_pizzas;
        private System.Windows.Forms.Label lbl_nompizzas;
    }
}