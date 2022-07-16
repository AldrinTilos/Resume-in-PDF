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
            this.btn_generate = new System.Windows.Forms.Button();
            this.lbl_generate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(322, 111);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(81, 66);
            this.btn_generate.TabIndex = 0;
            this.btn_generate.Text = "button1";
            this.btn_generate.UseVisualStyleBackColor = true;
            // 
            // lbl_generate
            // 
            this.lbl_generate.AutoSize = true;
            this.lbl_generate.Location = new System.Drawing.Point(303, 62);
            this.lbl_generate.Name = "lbl_generate";
            this.lbl_generate.Size = new System.Drawing.Size(38, 15);
            this.lbl_generate.TabIndex = 1;
            this.lbl_generate.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_generate);
            this.Controls.Add(this.btn_generate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_generate;
        private Label lbl_generate;
    }
}