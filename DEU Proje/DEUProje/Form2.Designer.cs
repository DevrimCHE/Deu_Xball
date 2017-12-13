namespace DEUProje
{
    partial class Form2
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
            this.Cubuk = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Top = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Cubuk
            // 
            this.Cubuk.BackColor = System.Drawing.SystemColors.Control;
            this.Cubuk.Enabled = false;
            this.Cubuk.Location = new System.Drawing.Point(212, 526);
            this.Cubuk.Name = "Cubuk";
            this.Cubuk.Size = new System.Drawing.Size(130, 23);
            this.Cubuk.TabIndex = 0;
            this.Cubuk.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Top
            // 
            this.Top.AutoSize = true;
            this.Top.Enabled = false;
            this.Top.Location = new System.Drawing.Point(255, 507);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(14, 13);
            this.Top.TabIndex = 1;
            this.Top.TabStop = true;
            this.Top.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(549, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Top);
            this.Controls.Add(this.Cubuk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Oyun";
            this.Activated += new System.EventHandler(this.Form2_Activated);
            this.Deactivate += new System.EventHandler(this.Form2_Deactivate);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cubuk;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton Top;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer2;
    }
}