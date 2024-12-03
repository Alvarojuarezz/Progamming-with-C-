namespace PF_Y8375118G_49275680C
{
    partial class Form6
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.cb_nombre = new System.Windows.Forms.ComboBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_anadir = new System.Windows.Forms.Button();
            this.tb_5 = new System.Windows.Forms.TextBox();
            this.tb_4 = new System.Windows.Forms.TextBox();
            this.tb_3 = new System.Windows.Forms.TextBox();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.lbl_5 = new System.Windows.Forms.Label();
            this.lbl_4 = new System.Windows.Forms.Label();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.cb_opciones = new System.Windows.Forms.ComboBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(199, 239);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(43, 13);
            this.lbl_nombre.TabIndex = 33;
            this.lbl_nombre.Text = "Usuario";
            // 
            // cb_nombre
            // 
            this.cb_nombre.FormattingEnabled = true;
            this.cb_nombre.Items.AddRange(new object[] {
            "Ingredientes",
            "Especias",
            "Masas",
            "Salsas",
            "Pizzas",
            "Usuarios (Registrar)",
            "Usuarios (Modificar)"});
            this.cb_nombre.Location = new System.Drawing.Point(165, 256);
            this.cb_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.cb_nombre.Name = "cb_nombre";
            this.cb_nombre.Size = new System.Drawing.Size(115, 21);
            this.cb_nombre.TabIndex = 32;
            this.cb_nombre.SelectedIndexChanged += new System.EventHandler(this.cb_nombre_SelectedIndexChanged);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(13, 254);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(86, 31);
            this.btn_salir.TabIndex = 31;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_anadir
            // 
            this.btn_anadir.Enabled = false;
            this.btn_anadir.Location = new System.Drawing.Point(13, 89);
            this.btn_anadir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_anadir.Name = "btn_anadir";
            this.btn_anadir.Size = new System.Drawing.Size(86, 31);
            this.btn_anadir.TabIndex = 30;
            this.btn_anadir.Text = "Añadir";
            this.btn_anadir.UseVisualStyleBackColor = true;
            this.btn_anadir.Click += new System.EventHandler(this.btn_anadir_Click);
            // 
            // tb_5
            // 
            this.tb_5.Location = new System.Drawing.Point(266, 171);
            this.tb_5.Margin = new System.Windows.Forms.Padding(2);
            this.tb_5.Multiline = true;
            this.tb_5.Name = "tb_5";
            this.tb_5.Size = new System.Drawing.Size(91, 33);
            this.tb_5.TabIndex = 29;
            // 
            // tb_4
            // 
            this.tb_4.Location = new System.Drawing.Point(165, 171);
            this.tb_4.Margin = new System.Windows.Forms.Padding(2);
            this.tb_4.Multiline = true;
            this.tb_4.Name = "tb_4";
            this.tb_4.Size = new System.Drawing.Size(91, 33);
            this.tb_4.TabIndex = 28;
            // 
            // tb_3
            // 
            this.tb_3.Location = new System.Drawing.Point(368, 48);
            this.tb_3.Margin = new System.Windows.Forms.Padding(2);
            this.tb_3.Multiline = true;
            this.tb_3.Name = "tb_3";
            this.tb_3.Size = new System.Drawing.Size(91, 33);
            this.tb_3.TabIndex = 27;
            // 
            // tb_2
            // 
            this.tb_2.Location = new System.Drawing.Point(266, 48);
            this.tb_2.Margin = new System.Windows.Forms.Padding(2);
            this.tb_2.Multiline = true;
            this.tb_2.Name = "tb_2";
            this.tb_2.Size = new System.Drawing.Size(91, 33);
            this.tb_2.TabIndex = 26;
            // 
            // tb_1
            // 
            this.tb_1.Location = new System.Drawing.Point(165, 48);
            this.tb_1.Margin = new System.Windows.Forms.Padding(2);
            this.tb_1.Multiline = true;
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(91, 33);
            this.tb_1.TabIndex = 25;
            // 
            // lbl_5
            // 
            this.lbl_5.AutoSize = true;
            this.lbl_5.Location = new System.Drawing.Point(287, 150);
            this.lbl_5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_5.Name = "lbl_5";
            this.lbl_5.Size = new System.Drawing.Size(35, 13);
            this.lbl_5.TabIndex = 24;
            this.lbl_5.Text = "label5";
            // 
            // lbl_4
            // 
            this.lbl_4.AutoSize = true;
            this.lbl_4.Location = new System.Drawing.Point(180, 150);
            this.lbl_4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(35, 13);
            this.lbl_4.TabIndex = 23;
            this.lbl_4.Text = "label4";
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Location = new System.Drawing.Point(397, 24);
            this.lbl_3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(35, 13);
            this.lbl_3.TabIndex = 22;
            this.lbl_3.Text = "label3";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(287, 24);
            this.lbl_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(35, 13);
            this.lbl_2.TabIndex = 21;
            this.lbl_2.Text = "label2";
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(180, 24);
            this.lbl_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(35, 13);
            this.lbl_1.TabIndex = 20;
            this.lbl_1.Text = "label1";
            // 
            // cb_opciones
            // 
            this.cb_opciones.FormattingEnabled = true;
            this.cb_opciones.Items.AddRange(new object[] {
            "Ingredientes",
            "Especias",
            "Masas",
            "Salsas",
            "Pizzas",
            "Usuarios (Registrar)",
            "Usuarios (Modificar)"});
            this.cb_opciones.Location = new System.Drawing.Point(13, 48);
            this.cb_opciones.Margin = new System.Windows.Forms.Padding(2);
            this.cb_opciones.Name = "cb_opciones";
            this.cb_opciones.Size = new System.Drawing.Size(115, 21);
            this.cb_opciones.TabIndex = 19;
            this.cb_opciones.SelectedIndexChanged += new System.EventHandler(this.cb_opciones_SelectedIndexChanged);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(9, 17);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(66, 20);
            this.lbl_titulo.TabIndex = 18;
            this.lbl_titulo.Text = "ADMIN";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(518, 328);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.cb_nombre);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_anadir);
            this.Controls.Add(this.tb_5);
            this.Controls.Add(this.tb_4);
            this.Controls.Add(this.tb_3);
            this.Controls.Add(this.tb_2);
            this.Controls.Add(this.tb_1);
            this.Controls.Add(this.lbl_5);
            this.Controls.Add(this.lbl_4);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.cb_opciones);
            this.Controls.Add(this.lbl_titulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form6";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_nombre;
        public System.Windows.Forms.ComboBox cb_nombre;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_anadir;
        public System.Windows.Forms.TextBox tb_5;
        public System.Windows.Forms.TextBox tb_4;
        public System.Windows.Forms.TextBox tb_3;
        public System.Windows.Forms.TextBox tb_2;
        public System.Windows.Forms.TextBox tb_1;
        public System.Windows.Forms.Label lbl_5;
        public System.Windows.Forms.Label lbl_4;
        public System.Windows.Forms.Label lbl_3;
        public System.Windows.Forms.Label lbl_2;
        public System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.ComboBox cb_opciones;
        private System.Windows.Forms.Label lbl_titulo;
    }
}