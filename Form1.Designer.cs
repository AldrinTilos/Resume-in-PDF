namespace Resume_PDF
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_generate = new System.Windows.Forms.Button();
            this.lbl_generate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_generate
            // 
            this.btn_generate.BackColor = System.Drawing.Color.LightCoral;
            this.btn_generate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_generate.Location = new System.Drawing.Point(63, 103);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(147, 66);
            this.btn_generate.TabIndex = 0;
            this.btn_generate.Text = "Generate PDF";
            this.btn_generate.UseVisualStyleBackColor = false;
            // 
            // lbl_generate
            // 
            this.lbl_generate.AutoSize = true;
            this.lbl_generate.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_generate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_generate.Location = new System.Drawing.Point(11, 45);
            this.lbl_generate.Name = "lbl_generate";
            this.lbl_generate.Size = new System.Drawing.Size(249, 25);
            this.lbl_generate.TabIndex = 1;
            this.lbl_generate.Text = "Generate Resume into PDF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(272, 268);
            this.Controls.Add(this.lbl_generate);
            this.Controls.Add(this.btn_generate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Generate PDF Resume";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_generate;
        private Label lbl_generate;
    }
}