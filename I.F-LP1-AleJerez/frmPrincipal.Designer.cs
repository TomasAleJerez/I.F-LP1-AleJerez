namespace I.F_LP1_AleJerez
{
    partial class frmPrincipal
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
            this.btnCargaProducto = new System.Windows.Forms.Button();
            this.btnCargaVenta = new System.Windows.Forms.Button();
            this.btnListado = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCargaProducto
            // 
            this.btnCargaProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCargaProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnCargaProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaProducto.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnCargaProducto.Location = new System.Drawing.Point(125, 205);
            this.btnCargaProducto.Name = "btnCargaProducto";
            this.btnCargaProducto.Size = new System.Drawing.Size(317, 60);
            this.btnCargaProducto.TabIndex = 8;
            this.btnCargaProducto.Text = "Carga de producto";
            this.btnCargaProducto.UseVisualStyleBackColor = false;
            this.btnCargaProducto.Click += new System.EventHandler(this.btnCargaProducto_Click);
            // 
            // btnCargaVenta
            // 
            this.btnCargaVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCargaVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnCargaVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaVenta.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnCargaVenta.Location = new System.Drawing.Point(125, 284);
            this.btnCargaVenta.Name = "btnCargaVenta";
            this.btnCargaVenta.Size = new System.Drawing.Size(317, 60);
            this.btnCargaVenta.TabIndex = 9;
            this.btnCargaVenta.Text = "Carga de ventas";
            this.btnCargaVenta.UseVisualStyleBackColor = false;
            this.btnCargaVenta.Click += new System.EventHandler(this.btnCargaVenta_Click);
            // 
            // btnListado
            // 
            this.btnListado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListado.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnListado.Location = new System.Drawing.Point(125, 364);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(317, 60);
            this.btnListado.TabIndex = 10;
            this.btnListado.Text = "Listado de productos y venta";
            this.btnListado.UseVisualStyleBackColor = false;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::I.F_LP1_AleJerez.Properties.Resources.pngegg;
            this.pictureBox1.Location = new System.Drawing.Point(221, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 32);
            this.panel1.TabIndex = 11;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnSalir.Location = new System.Drawing.Point(524, -1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(34, 33);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnListado);
            this.Controls.Add(this.btnCargaVenta);
            this.Controls.Add(this.btnCargaProducto);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCargaProducto;
        private System.Windows.Forms.Button btnCargaVenta;
        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
    }
}