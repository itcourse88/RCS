namespace D7
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
            this.labelcount = new System.Windows.Forms.Label();
            this.inputnumber = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelcount
            // 
            this.labelcount.AutoSize = true;
            this.labelcount.Location = new System.Drawing.Point(35, 42);
            this.labelcount.Name = "labelcount";
            this.labelcount.Size = new System.Drawing.Size(36, 13);
            this.labelcount.TabIndex = 0;
            this.labelcount.Text = "Skaits";
            // 
            // inputnumber
            // 
            this.inputnumber.Location = new System.Drawing.Point(76, 42);
            this.inputnumber.Name = "inputnumber";
            this.inputnumber.Size = new System.Drawing.Size(159, 20);
            this.inputnumber.TabIndex = 1;
            this.inputnumber.Text = "1";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(44, 96);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(95, 29);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Pieskaitit";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(162, 96);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(84, 29);
            this.buttonMinus.TabIndex = 3;
            this.buttonMinus.Text = "Atnemt";
            this.buttonMinus.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(44, 148);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(201, 45);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Notirit";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 339);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.inputnumber);
            this.Controls.Add(this.labelcount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelcount;
        private System.Windows.Forms.TextBox inputnumber;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonClear;
    }
}

