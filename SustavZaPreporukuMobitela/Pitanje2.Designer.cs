namespace SustavZaPreporukuMobitela
{
    partial class Pitanje2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarBudzet = new System.Windows.Forms.TrackBar();
            this.trenutniBudzet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBudzet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(171, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Koliki vam je prosjecni budzet?";
            // 
            // trackBarBudzet
            // 
            this.trackBarBudzet.LargeChange = 10;
            this.trackBarBudzet.Location = new System.Drawing.Point(80, 226);
            this.trackBarBudzet.Maximum = 2000;
            this.trackBarBudzet.Minimum = 100;
            this.trackBarBudzet.Name = "trackBarBudzet";
            this.trackBarBudzet.Size = new System.Drawing.Size(463, 45);
            this.trackBarBudzet.SmallChange = 10;
            this.trackBarBudzet.TabIndex = 2;
            this.trackBarBudzet.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarBudzet.Value = 1050;
            this.trackBarBudzet.Scroll += new System.EventHandler(this.trackBarBudzet_Scroll);
            this.trackBarBudzet.ValueChanged += new System.EventHandler(this.trackBarBudzet_ValueChanged);
            // 
            // trenutniBudzet
            // 
            this.trenutniBudzet.AutoSize = true;
            this.trenutniBudzet.BackColor = System.Drawing.Color.Transparent;
            this.trenutniBudzet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trenutniBudzet.Location = new System.Drawing.Point(284, 188);
            this.trenutniBudzet.Name = "trenutniBudzet";
            this.trenutniBudzet.Size = new System.Drawing.Size(45, 19);
            this.trenutniBudzet.TabIndex = 3;
            this.trenutniBudzet.Text = "1050";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(323, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "€";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.Location = new System.Drawing.Point(280, 410);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(30, 30);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNext.Location = new System.Drawing.Point(316, 410);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 30);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseEnter += new System.EventHandler(this.btnNext_MouseEnter);
            this.btnNext.MouseLeave += new System.EventHandler(this.btnNext_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(64, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(487, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Povucite klizač na maksimalni iznos koji ste spremni izdvojiti za Vaš novi mobiln" +
    "i uređaj. \r\nCijene uređaja kreću se od minimalno 100€ do maksimalno 2000€.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(582, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "2/15";
            // 
            // Pitanje2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::SustavZaPreporukuMobitela.Properties.Resources.basic_theme;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trenutniBudzet);
            this.Controls.Add(this.trackBarBudzet);
            this.Controls.Add(this.label1);
            this.Name = "Pitanje2";
            this.Size = new System.Drawing.Size(634, 461);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBudzet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarBudzet;
        private System.Windows.Forms.Label trenutniBudzet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
