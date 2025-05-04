namespace projekt_UI
{
    partial class AddPartForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPartName = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.textBoxMaterial = new System.Windows.Forms.TextBox();
            this.buttonAddPart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(262, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa nowej części:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(262, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kolor nowej części:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(260, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Materiał nowej części:";
            // 
            // textBoxPartName
            // 
            this.textBoxPartName.Location = new System.Drawing.Point(265, 96);
            this.textBoxPartName.Name = "textBoxPartName";
            this.textBoxPartName.Size = new System.Drawing.Size(233, 22);
            this.textBoxPartName.TabIndex = 3;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(265, 208);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(233, 22);
            this.textBoxColor.TabIndex = 4;
            // 
            // textBoxMaterial
            // 
            this.textBoxMaterial.Location = new System.Drawing.Point(265, 320);
            this.textBoxMaterial.Name = "textBoxMaterial";
            this.textBoxMaterial.Size = new System.Drawing.Size(233, 22);
            this.textBoxMaterial.TabIndex = 5;
            // 
            // buttonAddPart
            // 
            this.buttonAddPart.Location = new System.Drawing.Point(309, 373);
            this.buttonAddPart.Name = "buttonAddPart";
            this.buttonAddPart.Size = new System.Drawing.Size(144, 48);
            this.buttonAddPart.TabIndex = 6;
            this.buttonAddPart.Text = "Dodaj nową część";
            this.buttonAddPart.UseVisualStyleBackColor = true;
            this.buttonAddPart.Click += new System.EventHandler(this.buttonAddPart_Click);
            // 
            // AddPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddPart);
            this.Controls.Add(this.textBoxMaterial);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.textBoxPartName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPartForm";
            this.Text = "AddPartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPartName;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.TextBox textBoxMaterial;
        private System.Windows.Forms.Button buttonAddPart;
    }
}