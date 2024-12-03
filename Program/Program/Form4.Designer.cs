namespace PF_Y8375118G_49275680C
{
    partial class Form4
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
            this.btn_comprar = new System.Windows.Forms.Button();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.tb_precio = new System.Windows.Forms.TextBox();
            this.lbl_lista = new System.Windows.Forms.Label();
            this.cb_salsas = new System.Windows.Forms.ComboBox();
            this.cbl_especias = new System.Windows.Forms.CheckedListBox();
            this.cbl_ingredientes = new System.Windows.Forms.CheckedListBox();
            this.cb_masas = new System.Windows.Forms.ComboBox();
            this.lbl_salsas = new System.Windows.Forms.Label();
            this.lbl_especias = new System.Windows.Forms.Label();
            this.lbl_ingredientes = new System.Windows.Forms.Label();
            this.lbl_masa = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.White;
            this.btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(543, 408);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(118, 34);
            this.btn_salir.TabIndex = 29;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_comprar
            // 
            this.btn_comprar.BackColor = System.Drawing.Color.White;
            this.btn_comprar.Enabled = false;
            this.btn_comprar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_comprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comprar.Location = new System.Drawing.Point(543, 361);
            this.btn_comprar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(118, 34);
            this.btn_comprar.TabIndex = 28;
            this.btn_comprar.Text = "Comprar";
            this.btn_comprar.UseVisualStyleBackColor = true;
            this.btn_comprar.Click += new System.EventHandler(this.btn_comprar_Click);
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.Location = new System.Drawing.Point(537, 206);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(136, 20);
            this.lbl_precio.TabIndex = 27;
            this.lbl_precio.Text = "PRECIO TOTAL";
            // 
            // tb_total
            // 
            this.tb_total.Location = new System.Drawing.Point(543, 237);
            this.tb_total.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_total.Multiline = true;
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(120, 33);
            this.tb_total.TabIndex = 26;
            // 
            // tb_precio
            // 
            this.tb_precio.Location = new System.Drawing.Point(104, 237);
            this.tb_precio.Multiline = true;
            this.tb_precio.Name = "tb_precio";
            this.tb_precio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_precio.Size = new System.Drawing.Size(398, 206);
            this.tb_precio.TabIndex = 25;
            this.tb_precio.TextChanged += new System.EventHandler(this.tb_precio_TextChanged);
            // 
            // lbl_lista
            // 
            this.lbl_lista.AutoSize = true;
            this.lbl_lista.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lista.Location = new System.Drawing.Point(99, 206);
            this.lbl_lista.Name = "lbl_lista";
            this.lbl_lista.Size = new System.Drawing.Size(59, 20);
            this.lbl_lista.TabIndex = 24;
            this.lbl_lista.Text = "LISTA";
            // 
            // cb_salsas
            // 
            this.cb_salsas.FormattingEnabled = true;
            this.cb_salsas.Location = new System.Drawing.Point(723, 68);
            this.cb_salsas.Name = "cb_salsas";
            this.cb_salsas.Size = new System.Drawing.Size(143, 21);
            this.cb_salsas.TabIndex = 23;
            this.cb_salsas.SelectedIndexChanged += new System.EventHandler(this.cb_salsas_SelectedIndexChanged);
            // 
            // cbl_especias
            // 
            this.cbl_especias.CheckOnClick = true;
            this.cbl_especias.FormattingEnabled = true;
            this.cbl_especias.Location = new System.Drawing.Point(488, 68);
            this.cbl_especias.Name = "cbl_especias";
            this.cbl_especias.Size = new System.Drawing.Size(211, 79);
            this.cbl_especias.TabIndex = 22;
            this.cbl_especias.SelectedIndexChanged += new System.EventHandler(this.cbl_especias_SelectedIndexChanged);
            // 
            // cbl_ingredientes
            // 
            this.cbl_ingredientes.CheckOnClick = true;
            this.cbl_ingredientes.FormattingEnabled = true;
            this.cbl_ingredientes.Location = new System.Drawing.Point(254, 68);
            this.cbl_ingredientes.Name = "cbl_ingredientes";
            this.cbl_ingredientes.Size = new System.Drawing.Size(208, 79);
            this.cbl_ingredientes.TabIndex = 21;
            this.cbl_ingredientes.SelectedIndexChanged += new System.EventHandler(this.cbl_ingredientes_SelectedIndexChanged);
            // 
            // cb_masas
            // 
            this.cb_masas.FormattingEnabled = true;
            this.cb_masas.Location = new System.Drawing.Point(90, 68);
            this.cb_masas.Name = "cb_masas";
            this.cb_masas.Size = new System.Drawing.Size(138, 21);
            this.cb_masas.TabIndex = 20;
            // 
            // lbl_salsas
            // 
            this.lbl_salsas.AutoSize = true;
            this.lbl_salsas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_salsas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salsas.Location = new System.Drawing.Point(719, 39);
            this.lbl_salsas.Name = "lbl_salsas";
            this.lbl_salsas.Size = new System.Drawing.Size(79, 20);
            this.lbl_salsas.TabIndex = 19;
            this.lbl_salsas.Text = "SALSAS";
            // 
            // lbl_especias
            // 
            this.lbl_especias.AutoSize = true;
            this.lbl_especias.BackColor = System.Drawing.Color.Transparent;
            this.lbl_especias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_especias.Location = new System.Drawing.Point(482, 39);
            this.lbl_especias.Name = "lbl_especias";
            this.lbl_especias.Size = new System.Drawing.Size(98, 20);
            this.lbl_especias.TabIndex = 18;
            this.lbl_especias.Text = "ESPECIAS";
            // 
            // lbl_ingredientes
            // 
            this.lbl_ingredientes.AutoSize = true;
            this.lbl_ingredientes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ingredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ingredientes.Location = new System.Drawing.Point(249, 39);
            this.lbl_ingredientes.Name = "lbl_ingredientes";
            this.lbl_ingredientes.Size = new System.Drawing.Size(143, 20);
            this.lbl_ingredientes.TabIndex = 17;
            this.lbl_ingredientes.Text = "INGREDIENTES";
            // 
            // lbl_masa
            // 
            this.lbl_masa.AutoSize = true;
            this.lbl_masa.BackColor = System.Drawing.Color.Transparent;
            this.lbl_masa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_masa.Location = new System.Drawing.Point(86, 39);
            this.lbl_masa.Name = "lbl_masa";
            this.lbl_masa.Size = new System.Drawing.Size(71, 20);
            this.lbl_masa.TabIndex = 16;
            this.lbl_masa.Text = "MASAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PF_Y8375118G_49275680C.Properties.Resources.logo_pizza;
            this.pictureBox1.Location = new System.Drawing.Point(697, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(952, 492);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_comprar);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.tb_total);
            this.Controls.Add(this.tb_precio);
            this.Controls.Add(this.lbl_lista);
            this.Controls.Add(this.cb_salsas);
            this.Controls.Add(this.cbl_especias);
            this.Controls.Add(this.cbl_ingredientes);
            this.Controls.Add(this.cb_masas);
            this.Controls.Add(this.lbl_salsas);
            this.Controls.Add(this.lbl_especias);
            this.Controls.Add(this.lbl_ingredientes);
            this.Controls.Add(this.lbl_masa);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form4";
            this.Text = "Personalizar pizzas";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_comprar;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.TextBox tb_precio;
        private System.Windows.Forms.Label lbl_lista;
        public System.Windows.Forms.ComboBox cb_salsas;
        public System.Windows.Forms.CheckedListBox cbl_especias;
        public System.Windows.Forms.CheckedListBox cbl_ingredientes;
        public System.Windows.Forms.ComboBox cb_masas;
        private System.Windows.Forms.Label lbl_salsas;
        private System.Windows.Forms.Label lbl_especias;
        private System.Windows.Forms.Label lbl_ingredientes;
        private System.Windows.Forms.Label lbl_masa;
    }
}