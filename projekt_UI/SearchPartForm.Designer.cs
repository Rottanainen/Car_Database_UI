namespace projekt_UI
{
    partial class SearchPartForm
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
            this.textBoxSearchValue = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearchValue
            // 
            this.textBoxSearchValue.Location = new System.Drawing.Point(264, 22);
            this.textBoxSearchValue.Name = "textBoxSearchValue";
            this.textBoxSearchValue.Size = new System.Drawing.Size(267, 22);
            this.textBoxSearchValue.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(338, 50);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(123, 36);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Wyszukaj";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(127, 118);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.RowHeadersWidth = 51;
            this.dataGridViewResults.RowTemplate.Height = 24;
            this.dataGridViewResults.Size = new System.Drawing.Size(555, 237);
            this.dataGridViewResults.TabIndex = 2;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(348, 381);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(129, 39);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Wróć do menu";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // SearchPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearchValue);
            this.Name = "SearchPartForm";
            this.Text = "SearchPartForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearchValue;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.Button buttonClose;
    }
}