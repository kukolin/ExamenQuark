
namespace ExamenQuark
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.txtNombreTienda = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.Label();
            this.txtNombreVendedor = new System.Windows.Forms.Label();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.rbCamisa = new System.Windows.Forms.RadioButton();
            this.rbPantalon = new System.Windows.Forms.RadioButton();
            this.cbMangaCorta = new System.Windows.Forms.CheckBox();
            this.cbCuelloMao = new System.Windows.Forms.CheckBox();
            this.cbChupin = new System.Windows.Forms.CheckBox();
            this.txtStock = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbPremium = new System.Windows.Forms.RadioButton();
            this.rbStandard = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtResultado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreTienda
            // 
            this.txtNombreTienda.AutoSize = true;
            this.txtNombreTienda.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreTienda.Location = new System.Drawing.Point(158, 17);
            this.txtNombreTienda.Name = "txtNombreTienda";
            this.txtNombreTienda.Size = new System.Drawing.Size(167, 24);
            this.txtNombreTienda.TabIndex = 0;
            this.txtNombreTienda.Text = "txtNombreTienda";
            // 
            // txtDireccion
            // 
            this.txtDireccion.AutoSize = true;
            this.txtDireccion.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDireccion.Location = new System.Drawing.Point(402, 17);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(117, 24);
            this.txtDireccion.TabIndex = 1;
            this.txtDireccion.Text = "txtDireccion";
            // 
            // txtNombreVendedor
            // 
            this.txtNombreVendedor.AutoSize = true;
            this.txtNombreVendedor.Location = new System.Drawing.Point(159, 50);
            this.txtNombreVendedor.Name = "txtNombreVendedor";
            this.txtNombreVendedor.Size = new System.Drawing.Size(145, 20);
            this.txtNombreVendedor.TabIndex = 2;
            this.txtNombreVendedor.Text = "txtNombreVendedor";
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(593, 63);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(203, 29);
            this.btnHistorial.TabIndex = 3;
            this.btnHistorial.Text = "Historial de cotizaciones";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // rbCamisa
            // 
            this.rbCamisa.AutoSize = true;
            this.rbCamisa.Checked = true;
            this.rbCamisa.Location = new System.Drawing.Point(24, 6);
            this.rbCamisa.Name = "rbCamisa";
            this.rbCamisa.Size = new System.Drawing.Size(78, 24);
            this.rbCamisa.TabIndex = 4;
            this.rbCamisa.TabStop = true;
            this.rbCamisa.Text = "Camisa";
            this.rbCamisa.UseVisualStyleBackColor = true;
            this.rbCamisa.CheckedChanged += new System.EventHandler(this.rbCamisa_CheckedChanged);
            // 
            // rbPantalon
            // 
            this.rbPantalon.AutoSize = true;
            this.rbPantalon.Location = new System.Drawing.Point(24, 48);
            this.rbPantalon.Name = "rbPantalon";
            this.rbPantalon.Size = new System.Drawing.Size(87, 24);
            this.rbPantalon.TabIndex = 5;
            this.rbPantalon.Text = "Pantalón";
            this.rbPantalon.UseVisualStyleBackColor = true;
            this.rbPantalon.CheckedChanged += new System.EventHandler(this.rbPantalon_CheckedChanged);
            // 
            // cbMangaCorta
            // 
            this.cbMangaCorta.AutoSize = true;
            this.cbMangaCorta.Location = new System.Drawing.Point(185, 5);
            this.cbMangaCorta.Name = "cbMangaCorta";
            this.cbMangaCorta.Size = new System.Drawing.Size(117, 24);
            this.cbMangaCorta.TabIndex = 7;
            this.cbMangaCorta.Text = "Manga Corta";
            this.cbMangaCorta.UseVisualStyleBackColor = true;
            this.cbMangaCorta.CheckedChanged += new System.EventHandler(this.cbMangaCorta_CheckedChanged);
            // 
            // cbCuelloMao
            // 
            this.cbCuelloMao.AutoSize = true;
            this.cbCuelloMao.Location = new System.Drawing.Point(336, 6);
            this.cbCuelloMao.Name = "cbCuelloMao";
            this.cbCuelloMao.Size = new System.Drawing.Size(107, 24);
            this.cbCuelloMao.TabIndex = 8;
            this.cbCuelloMao.Text = "Cuello Mao";
            this.cbCuelloMao.UseVisualStyleBackColor = true;
            this.cbCuelloMao.CheckedChanged += new System.EventHandler(this.cbCuelloMao_CheckedChanged);
            // 
            // cbChupin
            // 
            this.cbChupin.AutoSize = true;
            this.cbChupin.Enabled = false;
            this.cbChupin.Location = new System.Drawing.Point(185, 48);
            this.cbChupin.Name = "cbChupin";
            this.cbChupin.Size = new System.Drawing.Size(77, 24);
            this.cbChupin.TabIndex = 9;
            this.cbChupin.Text = "Chupin";
            this.cbChupin.UseVisualStyleBackColor = true;
            this.cbChupin.CheckedChanged += new System.EventHandler(this.cbChupin_CheckedChanged);
            // 
            // txtStock
            // 
            this.txtStock.AutoSize = true;
            this.txtStock.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtStock.Location = new System.Drawing.Point(29, 464);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(201, 24);
            this.txtStock.TabIndex = 10;
            this.txtStock.Text = "Stock disponible: 350";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Calidad de prenda:";
            // 
            // rbPremium
            // 
            this.rbPremium.AutoSize = true;
            this.rbPremium.Checked = true;
            this.rbPremium.Location = new System.Drawing.Point(13, 12);
            this.rbPremium.Name = "rbPremium";
            this.rbPremium.Size = new System.Drawing.Size(89, 24);
            this.rbPremium.TabIndex = 12;
            this.rbPremium.TabStop = true;
            this.rbPremium.Text = "Premium";
            this.rbPremium.UseVisualStyleBackColor = true;
            // 
            // rbStandard
            // 
            this.rbStandard.AutoSize = true;
            this.rbStandard.Location = new System.Drawing.Point(275, 12);
            this.rbStandard.Name = "rbStandard";
            this.rbStandard.Size = new System.Drawing.Size(90, 24);
            this.rbStandard.TabIndex = 13;
            this.rbStandard.Text = "Standard";
            this.rbStandard.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(119, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Precio unitario: ";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(290, 388);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(125, 27);
            this.tbPrecio.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(428, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cantidad: ";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(552, 388);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(125, 27);
            this.tbCantidad.TabIndex = 17;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(29, 548);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(301, 57);
            this.btnCalcular.TabIndex = 18;
            this.btnCalcular.Text = "Calcular cotización";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.rbStandard);
            this.panel1.Controls.Add(this.rbPremium);
            this.panel1.Location = new System.Drawing.Point(205, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 49);
            this.panel1.TabIndex = 19;
            // 
            // txtResultado
            // 
            this.txtResultado.AutoSize = true;
            this.txtResultado.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtResultado.Location = new System.Drawing.Point(354, 553);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(159, 37);
            this.txtResultado.TabIndex = 20;
            this.txtResultado.Text = "Resultado: ";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ExamenQuark.Properties.Resources.closeIcon;
            this.button1.Location = new System.Drawing.Point(746, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 54);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(105)))));
            this.panel2.Controls.Add(this.cbMangaCorta);
            this.panel2.Controls.Add(this.rbCamisa);
            this.panel2.Controls.Add(this.rbPantalon);
            this.panel2.Controls.Add(this.cbCuelloMao);
            this.panel2.Controls.Add(this.cbChupin);
            this.panel2.Location = new System.Drawing.Point(158, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 82);
            this.panel2.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Image = global::ExamenQuark.Properties.Resources.quark_logo1;
            this.label4.Location = new System.Drawing.Point(-2, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 125);
            this.label4.TabIndex = 23;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 668);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.txtNombreVendedor);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombreTienda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNombreTienda;
        private System.Windows.Forms.Label txtDireccion;
        private System.Windows.Forms.Label txtNombreVendedor;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.RadioButton rbCamisa;
        private System.Windows.Forms.RadioButton rbPantalon;
        private System.Windows.Forms.CheckBox cbMangaCorta;
        private System.Windows.Forms.CheckBox cbCuelloMao;
        private System.Windows.Forms.CheckBox cbChupin;
        private System.Windows.Forms.Label txtStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPremium;
        private System.Windows.Forms.RadioButton rbStandard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtResultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}

