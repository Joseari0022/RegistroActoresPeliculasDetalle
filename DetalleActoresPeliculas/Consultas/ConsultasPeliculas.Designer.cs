namespace DetalleActoresPeliculas.Consultas
{
    partial class ConsultasPeliculas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultasPeliculas));
            this.FiltrotextBox = new System.Windows.Forms.TextBox();
            this.Idbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.ConsultaPeliculadataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltrarcomboBox = new System.Windows.Forms.ComboBox();
            this.IderrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaPeliculadataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IderrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltrotextBox
            // 
            this.FiltrotextBox.Location = new System.Drawing.Point(218, 42);
            this.FiltrotextBox.Name = "FiltrotextBox";
            this.FiltrotextBox.Size = new System.Drawing.Size(217, 22);
            this.FiltrotextBox.TabIndex = 86;
            // 
            // Idbutton
            // 
            this.Idbutton.Image = ((System.Drawing.Image)(resources.GetObject("Idbutton.Image")));
            this.Idbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Idbutton.Location = new System.Drawing.Point(456, 12);
            this.Idbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Idbutton.Name = "Idbutton";
            this.Idbutton.Size = new System.Drawing.Size(83, 52);
            this.Idbutton.TabIndex = 88;
            this.Idbutton.Text = "Id";
            this.Idbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Idbutton.UseVisualStyleBackColor = true;
            this.Idbutton.Click += new System.EventHandler(this.Idbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NombretextBox);
            this.groupBox1.Controls.Add(this.ConsultaPeliculadataGridView);
            this.groupBox1.Location = new System.Drawing.Point(9, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 208);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(436, 22);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(132, 22);
            this.NombretextBox.TabIndex = 1;
            // 
            // ConsultaPeliculadataGridView
            // 
            this.ConsultaPeliculadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaPeliculadataGridView.Location = new System.Drawing.Point(6, 50);
            this.ConsultaPeliculadataGridView.Name = "ConsultaPeliculadataGridView";
            this.ConsultaPeliculadataGridView.RowTemplate.Height = 24;
            this.ConsultaPeliculadataGridView.Size = new System.Drawing.Size(562, 150);
            this.ConsultaPeliculadataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 85;
            this.label1.Text = "Filtrar";
            // 
            // FiltrarcomboBox
            // 
            this.FiltrarcomboBox.FormattingEnabled = true;
            this.FiltrarcomboBox.Location = new System.Drawing.Point(62, 40);
            this.FiltrarcomboBox.Name = "FiltrarcomboBox";
            this.FiltrarcomboBox.Size = new System.Drawing.Size(150, 24);
            this.FiltrarcomboBox.TabIndex = 84;
            // 
            // IderrorProvider
            // 
            this.IderrorProvider.ContainerControl = this;
            // 
            // ConsultasPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 329);
            this.Controls.Add(this.FiltrotextBox);
            this.Controls.Add(this.Idbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiltrarcomboBox);
            this.Name = "ConsultasPeliculas";
            this.Text = "ConsultasPeliculas";
            this.Load += new System.EventHandler(this.ConsultasPeliculas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaPeliculadataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IderrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FiltrotextBox;
        private System.Windows.Forms.Button Idbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.DataGridView ConsultaPeliculadataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FiltrarcomboBox;
        private System.Windows.Forms.ErrorProvider IderrorProvider;
    }
}