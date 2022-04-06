namespace PW3_2022_1C_Clase_1.Winforms
{
    partial class form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.TxtPregunta = new System.Windows.Forms.TextBox();
            this.informacion = new System.Windows.Forms.Label();
            this.btnAsk = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(80, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(378, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Bienvenido a Bola 8 Magic!";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtPregunta
            // 
            this.TxtPregunta.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtPregunta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPregunta.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPregunta.Location = new System.Drawing.Point(51, 110);
            this.TxtPregunta.Name = "TxtPregunta";
            this.TxtPregunta.PlaceholderText = "Pregunta";
            this.TxtPregunta.Size = new System.Drawing.Size(432, 32);
            this.TxtPregunta.TabIndex = 1;
            // 
            // informacion
            // 
            this.informacion.AutoSize = true;
            this.informacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.informacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.informacion.Location = new System.Drawing.Point(162, 92);
            this.informacion.Name = "informacion";
            this.informacion.Size = new System.Drawing.Size(209, 17);
            this.informacion.TabIndex = 2;
            this.informacion.Text = "Coloque a continuación su pregunta";
            // 
            // btnAsk
            // 
            this.btnAsk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAsk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAsk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAsk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAsk.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAsk.Location = new System.Drawing.Point(51, 172);
            this.btnAsk.Name = "btnAsk";
            this.btnAsk.Size = new System.Drawing.Size(144, 39);
            this.btnAsk.TabIndex = 3;
            this.btnAsk.Text = "Preguntar";
            this.btnAsk.UseVisualStyleBackColor = false;
            this.btnAsk.Click += new System.EventHandler(this.btnAsk_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PW3_2022_1C_Clase_1.Winforms.Properties.Resources.Bola8_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(238, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(529, 371);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAsk);
            this.Controls.Add(this.informacion);
            this.Controls.Add(this.TxtPregunta);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bola 8 Magic";
            this.Load += new System.EventHandler(this.form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox TxtPregunta;
        private System.Windows.Forms.Label informacion;
        private System.Windows.Forms.Button btnAsk;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
