namespace CodigoQRSaew
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.qrCodigo = new Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtruta = new System.Windows.Forms.TextBox();
            this.btnArchivo = new System.Windows.Forms.Button();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnQRHorario = new System.Windows.Forms.Button();
            this.btnPrueba = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // qrCodigo
            // 
            this.qrCodigo.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M;
            this.qrCodigo.Image = ((System.Drawing.Image)(resources.GetObject("qrCodigo.Image")));
            this.qrCodigo.Location = new System.Drawing.Point(530, 122);
            this.qrCodigo.Name = "qrCodigo";
            this.qrCodigo.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two;
            this.qrCodigo.Size = new System.Drawing.Size(177, 173);
            this.qrCodigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qrCodigo.TabIndex = 0;
            this.qrCodigo.TabStop = false;
            this.qrCodigo.Text = "qrCodeImgControl1";
            this.qrCodigo.Click += new System.EventHandler(this.qrCodeImgControl1_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(19, 73);
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(335, 43);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(360, 73);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 39);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtruta
            // 
            this.txtruta.Location = new System.Drawing.Point(19, 33);
            this.txtruta.Name = "txtruta";
            this.txtruta.Size = new System.Drawing.Size(288, 20);
            this.txtruta.TabIndex = 3;
            // 
            // btnArchivo
            // 
            this.btnArchivo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArchivo.BackgroundImage")));
            this.btnArchivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArchivo.Location = new System.Drawing.Point(313, 22);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(41, 41);
            this.btnArchivo.TabIndex = 4;
            this.btnArchivo.UseVisualStyleBackColor = true;
            this.btnArchivo.Click += new System.EventHandler(this.btnArchivo_Click);
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.Location = new System.Drawing.Point(19, 122);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(505, 173);
            this.lstDatos.TabIndex = 5;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(359, 30);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 6;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnQRHorario
            // 
            this.btnQRHorario.Location = new System.Drawing.Point(441, 55);
            this.btnQRHorario.Name = "btnQRHorario";
            this.btnQRHorario.Size = new System.Drawing.Size(84, 57);
            this.btnQRHorario.TabIndex = 7;
            this.btnQRHorario.Text = "Enviar horario a QR";
            this.btnQRHorario.UseVisualStyleBackColor = true;
            this.btnQRHorario.Click += new System.EventHandler(this.btnQRHorario_Click);
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(19, 301);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(75, 23);
            this.btnPrueba.TabIndex = 8;
            this.btnPrueba.Text = "prueba";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 357);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.btnQRHorario);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.lstDatos);
            this.Controls.Add(this.btnArchivo);
            this.Controls.Add(this.txtruta);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.qrCodigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qrCodigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl qrCodigo;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtruta;
        private System.Windows.Forms.Button btnArchivo;
        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnQRHorario;
        private System.Windows.Forms.Button btnPrueba;
    }
}

