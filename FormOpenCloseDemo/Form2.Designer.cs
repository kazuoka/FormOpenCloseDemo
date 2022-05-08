
namespace FormOpenCloseDemo
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
            this.exitapplicationButton = new System.Windows.Forms.Button();
            this.closeForm2Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitapplicationButton
            // 
            this.exitapplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitapplicationButton.Location = new System.Drawing.Point(195, 191);
            this.exitapplicationButton.Name = "exitapplicationButton";
            this.exitapplicationButton.Size = new System.Drawing.Size(395, 53);
            this.exitapplicationButton.TabIndex = 4;
            this.exitapplicationButton.Text = "Exit Application";
            this.exitapplicationButton.UseVisualStyleBackColor = true;
            this.exitapplicationButton.Click += new System.EventHandler(this.exitapplicationButton_Click);
            // 
            // closeForm2Button
            // 
            this.closeForm2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeForm2Button.Location = new System.Drawing.Point(195, 78);
            this.closeForm2Button.Name = "closeForm2Button";
            this.closeForm2Button.Size = new System.Drawing.Size(395, 53);
            this.closeForm2Button.TabIndex = 3;
            this.closeForm2Button.Text = "Close Form 2";
            this.closeForm2Button.UseVisualStyleBackColor = true;
            this.closeForm2Button.Click += new System.EventHandler(this.closeForm2Button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.exitapplicationButton);
            this.Controls.Add(this.closeForm2Button);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitapplicationButton;
        private System.Windows.Forms.Button closeForm2Button;
    }
}