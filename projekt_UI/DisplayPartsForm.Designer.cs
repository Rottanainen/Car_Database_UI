namespace projekt_UI
{
    partial class DisplayPartsForm
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
            this.dataGridViewParts = new System.Windows.Forms.DataGridView();
            this.buttonReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewParts
            // 
            this.dataGridViewParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParts.Location = new System.Drawing.Point(72, 12);
            this.dataGridViewParts.Name = "dataGridViewParts";
            this.dataGridViewParts.RowHeadersWidth = 51;
            this.dataGridViewParts.RowTemplate.Height = 24;
            this.dataGridViewParts.Size = new System.Drawing.Size(659, 347);
            this.dataGridViewParts.TabIndex = 0;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(345, 382);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(114, 34);
            this.buttonReturn.TabIndex = 1;
            this.buttonReturn.Text = "Wróć do menu";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // DisplayPartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.dataGridViewParts);
            this.Name = "DisplayPartsForm";
            this.Text = "DisplayPartsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewParts;
        private System.Windows.Forms.Button buttonReturn;
    }
}