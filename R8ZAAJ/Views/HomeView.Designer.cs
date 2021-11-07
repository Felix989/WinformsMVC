
namespace R8ZAAJ.Views
{
    partial class HomeView
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
            this.FoodDisplay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.FoodDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // FoodDisplay
            // 
            this.FoodDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FoodDisplay.Location = new System.Drawing.Point(12, 12);
            this.FoodDisplay.Name = "FoodDisplay";
            this.FoodDisplay.RowTemplate.Height = 25;
            this.FoodDisplay.Size = new System.Drawing.Size(1294, 272);
            this.FoodDisplay.TabIndex = 0;
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 515);
            this.Controls.Add(this.FoodDisplay);
            this.Name = "HomeView";
            this.Text = "HomeView";
            ((System.ComponentModel.ISupportInitialize)(this.FoodDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FoodDisplay;
    }
}