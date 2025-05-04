namespace projekt_UI
{
    partial class DeletePartForm
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
            this.labelPrompt = new System.Windows.Forms.Label();
            this.textBoxPartId = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPrompt
            // 
            this.labelPrompt.AutoSize = true;
            this.labelPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrompt.Location = new System.Drawing.Point(163, 79);
            this.labelPrompt.Name = "labelPrompt";
            this.labelPrompt.Size = new System.Drawing.Size(458, 29);
            this.labelPrompt.TabIndex = 0;
            this.labelPrompt.Text = "Podaj ID części, która ma zostać usunięta:";
            // 
            // textBoxPartId
            // 
            this.textBoxPartId.Location = new System.Drawing.Point(237, 127);
            this.textBoxPartId.Name = "textBoxPartId";
            this.textBoxPartId.Size = new System.Drawing.Size(303, 22);
            this.textBoxPartId.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(318, 178);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(135, 50);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Usuń część";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(321, 368);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(132, 52);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Wróć do menu";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // DeletePartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxPartId);
            this.Controls.Add(this.labelPrompt);
            this.Name = "DeletePartForm";
            this.Text = "DeletePartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrompt;
        private System.Windows.Forms.TextBox textBoxPartId;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClose;
    }
}