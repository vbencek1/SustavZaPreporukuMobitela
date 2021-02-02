namespace SustavZaPreporukuMobitela
{
    partial class Pitanje4
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
            this.radioOSWindows = new System.Windows.Forms.RadioButton();
            this.radioOSAndroid = new System.Windows.Forms.RadioButton();
            this.radioOSiOS = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(159, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Koji operacijski sustav preferirate?";
            // 
            // radioOSWindows
            // 
            this.radioOSWindows.AutoSize = true;
            this.radioOSWindows.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioOSWindows.Location = new System.Drawing.Point(67, 260);
            this.radioOSWindows.Name = "radioOSWindows";
            this.radioOSWindows.Size = new System.Drawing.Size(87, 21);
            this.radioOSWindows.TabIndex = 9;
            this.radioOSWindows.TabStop = true;
            this.radioOSWindows.Text = "Windows";
            this.radioOSWindows.UseVisualStyleBackColor = true;
            this.radioOSWindows.CheckedChanged += new System.EventHandler(this.radioOSWindows_CheckedChanged);
            // 
            // radioOSAndroid
            // 
            this.radioOSAndroid.AutoSize = true;
            this.radioOSAndroid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioOSAndroid.Location = new System.Drawing.Point(67, 220);
            this.radioOSAndroid.Name = "radioOSAndroid";
            this.radioOSAndroid.Size = new System.Drawing.Size(75, 21);
            this.radioOSAndroid.TabIndex = 8;
            this.radioOSAndroid.TabStop = true;
            this.radioOSAndroid.Text = "Android";
            this.radioOSAndroid.UseVisualStyleBackColor = true;
            this.radioOSAndroid.CheckedChanged += new System.EventHandler(this.radioOSAndroid_CheckedChanged);
            // 
            // radioOSiOS
            // 
            this.radioOSiOS.AutoSize = true;
            this.radioOSiOS.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioOSiOS.Location = new System.Drawing.Point(67, 180);
            this.radioOSiOS.Name = "radioOSiOS";
            this.radioOSiOS.Size = new System.Drawing.Size(51, 21);
            this.radioOSiOS.TabIndex = 7;
            this.radioOSiOS.TabStop = true;
            this.radioOSiOS.Text = "iOS";
            this.radioOSiOS.UseVisualStyleBackColor = true;
            this.radioOSiOS.CheckedChanged += new System.EventHandler(this.radioOSiOS_CheckedChanged);
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
            this.btnBack.TabIndex = 11;
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
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseEnter += new System.EventHandler(this.btnNext_MouseEnter);
            this.btnNext.MouseLeave += new System.EventHandler(this.btnNext_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(64, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tri su najpopularnija operacijska sustava, odaberite koji je Vaš omiljeni!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(582, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "4/15";
            // 
            // Pitanje4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::SustavZaPreporukuMobitela.Properties.Resources.basic_theme;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.radioOSWindows);
            this.Controls.Add(this.radioOSAndroid);
            this.Controls.Add(this.radioOSiOS);
            this.Controls.Add(this.label1);
            this.Name = "Pitanje4";
            this.Size = new System.Drawing.Size(634, 461);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioOSWindows;
        private System.Windows.Forms.RadioButton radioOSAndroid;
        private System.Windows.Forms.RadioButton radioOSiOS;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}
