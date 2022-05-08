
namespace FormOpenCloseDemo
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
            this.closeButton = new System.Windows.Forms.Button();
            this.openForm2Button = new System.Windows.Forms.Button();
            this.openForm3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(527, 319);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(172, 46);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close Form";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // openForm2Button
            // 
            this.openForm2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openForm2Button.Location = new System.Drawing.Point(203, 54);
            this.openForm2Button.Name = "openForm2Button";
            this.openForm2Button.Size = new System.Drawing.Size(395, 53);
            this.openForm2Button.TabIndex = 1;
            this.openForm2Button.Text = "Open Form 2";
            this.openForm2Button.UseVisualStyleBackColor = true;
            this.openForm2Button.Click += new System.EventHandler(this.openForm2Button_Click);
            // 
            // openForm3Button
            // 
            this.openForm3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openForm3Button.Location = new System.Drawing.Point(203, 167);
            this.openForm3Button.Name = "openForm3Button";
            this.openForm3Button.Size = new System.Drawing.Size(395, 53);
            this.openForm3Button.TabIndex = 2;
            this.openForm3Button.Text = "Open Form 3";
            this.openForm3Button.UseVisualStyleBackColor = true;
            this.openForm3Button.Click += new System.EventHandler(this.openForm3Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.openForm3Button);
            this.Controls.Add(this.openForm2Button);
            this.Controls.Add(this.closeButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button openForm2Button;
        private System.Windows.Forms.Button openForm3Button;
    }
}

