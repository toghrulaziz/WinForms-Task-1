namespace WinFormsTask1
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
            this.button_london = new System.Windows.Forms.Button();
            this.button_baku = new System.Windows.Forms.Button();
            this.label_clock = new System.Windows.Forms.Label();
            this.button_donttouchme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_london
            // 
            this.button_london.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_london.Location = new System.Drawing.Point(164, 63);
            this.button_london.Name = "button_london";
            this.button_london.Size = new System.Drawing.Size(75, 23);
            this.button_london.TabIndex = 0;
            this.button_london.Text = "London";
            this.button_london.UseVisualStyleBackColor = true;
            this.button_london.Click += new System.EventHandler(this.button_london_Click);
            // 
            // button_baku
            // 
            this.button_baku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_baku.Location = new System.Drawing.Point(515, 63);
            this.button_baku.Name = "button_baku";
            this.button_baku.Size = new System.Drawing.Size(75, 23);
            this.button_baku.TabIndex = 1;
            this.button_baku.Text = "Baku";
            this.button_baku.UseVisualStyleBackColor = true;
            this.button_baku.Click += new System.EventHandler(this.button_baku_Click);
            // 
            // label_clock
            // 
            this.label_clock.AutoSize = true;
            this.label_clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_clock.Location = new System.Drawing.Point(336, 38);
            this.label_clock.Name = "label_clock";
            this.label_clock.Size = new System.Drawing.Size(46, 16);
            this.label_clock.TabIndex = 2;
            this.label_clock.Text = "Clock";
            // 
            // button_donttouchme
            // 
            this.button_donttouchme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_donttouchme.Location = new System.Drawing.Point(304, 206);
            this.button_donttouchme.Name = "button_donttouchme";
            this.button_donttouchme.Size = new System.Drawing.Size(145, 23);
            this.button_donttouchme.TabIndex = 3;
            this.button_donttouchme.Text = "Dont touch me";
            this.button_donttouchme.UseVisualStyleBackColor = true;
            this.button_donttouchme.MouseEnter += new System.EventHandler(this.button_donttouchme_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_donttouchme);
            this.Controls.Add(this.label_clock);
            this.Controls.Add(this.button_baku);
            this.Controls.Add(this.button_london);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_london;
        private System.Windows.Forms.Button button_baku;
        private System.Windows.Forms.Label label_clock;
        private System.Windows.Forms.Button button_donttouchme;
    }
}

