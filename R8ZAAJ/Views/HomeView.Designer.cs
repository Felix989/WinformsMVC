
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeView));
            this.FoodDisplay = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Basket = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectedFoodDisplay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceTag = new System.Windows.Forms.Label();
            this.CloseThis = new System.Windows.Forms.Button();
            this.ClearBasketButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.FoodDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Basket)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FoodDisplay
            // 
            this.FoodDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FoodDisplay.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.FoodDisplay.Location = new System.Drawing.Point(12, 39);
            this.FoodDisplay.Name = "FoodDisplay";
            this.FoodDisplay.ReadOnly = true;
            this.FoodDisplay.RowTemplate.Height = 25;
            this.FoodDisplay.Size = new System.Drawing.Size(795, 245);
            this.FoodDisplay.TabIndex = 0;
            this.FoodDisplay.SelectionChanged += new System.EventHandler(this.SelectionChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Location = new System.Drawing.Point(11, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show Previous Orders";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ShowPreviousOrders);
            // 
            // Basket
            // 
            this.Basket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Basket.Location = new System.Drawing.Point(143, 18);
            this.Basket.Name = "Basket";
            this.Basket.ReadOnly = true;
            this.Basket.RowTemplate.Height = 25;
            this.Basket.Size = new System.Drawing.Size(415, 162);
            this.Basket.TabIndex = 2;
            this.Basket.SelectionChanged += new System.EventHandler(this.RemoveItemFromCart);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.label2.Location = new System.Drawing.Point(392, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Basket:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.button2.Location = new System.Drawing.Point(11, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 47);
            this.button2.TabIndex = 5;
            this.button2.Text = "Order Basket";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.OrderBasket);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(176)))), ((int)(((byte)(98)))));
            this.button3.Location = new System.Drawing.Point(66, 424);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 35);
            this.button3.TabIndex = 6;
            this.button3.Text = "Add To Basket";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.AddToBasket);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.label3.Location = new System.Drawing.Point(75, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Selected Food";
            // 
            // SelectedFoodDisplay
            // 
            this.SelectedFoodDisplay.Location = new System.Drawing.Point(23, 382);
            this.SelectedFoodDisplay.Name = "SelectedFoodDisplay";
            this.SelectedFoodDisplay.ReadOnly = true;
            this.SelectedFoodDisplay.Size = new System.Drawing.Size(183, 23);
            this.SelectedFoodDisplay.TabIndex = 8;
            this.SelectedFoodDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.label4.Location = new System.Drawing.Point(582, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Worth:";
            // 
            // PriceTag
            // 
            this.PriceTag.AutoSize = true;
            this.PriceTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.PriceTag.Location = new System.Drawing.Point(646, 303);
            this.PriceTag.Name = "PriceTag";
            this.PriceTag.Size = new System.Drawing.Size(13, 15);
            this.PriceTag.TabIndex = 10;
            this.PriceTag.Text = "0";
            // 
            // CloseThis
            // 
            this.CloseThis.ForeColor = System.Drawing.Color.IndianRed;
            this.CloseThis.Location = new System.Drawing.Point(779, 13);
            this.CloseThis.Name = "CloseThis";
            this.CloseThis.Size = new System.Drawing.Size(28, 23);
            this.CloseThis.TabIndex = 11;
            this.CloseThis.Text = "X";
            this.CloseThis.UseVisualStyleBackColor = true;
            this.CloseThis.Click += new System.EventHandler(this.CloseWindow);
            // 
            // ClearBasketButton
            // 
            this.ClearBasketButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(176)))), ((int)(((byte)(98)))));
            this.ClearBasketButton.Location = new System.Drawing.Point(25, 141);
            this.ClearBasketButton.Name = "ClearBasketButton";
            this.ClearBasketButton.Size = new System.Drawing.Size(87, 27);
            this.ClearBasketButton.TabIndex = 12;
            this.ClearBasketButton.Text = "Clear Basket";
            this.ClearBasketButton.UseVisualStyleBackColor = false;
            this.ClearBasketButton.Click += new System.EventHandler(this.ClearBasketButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.ClearBasketButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Basket);
            this.panel1.Location = new System.Drawing.Point(236, 303);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 200);
            this.panel1.TabIndex = 13;
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(822, 515);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CloseThis);
            this.Controls.Add(this.PriceTag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SelectedFoodDisplay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FoodDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeView";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HomeView_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.FoodDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Basket)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FoodDisplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SelectedFoodDisplay;
        private System.Windows.Forms.DataGridView Basket;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PriceTag;
        private System.Windows.Forms.Button CloseThis;
        private System.Windows.Forms.Button ClearBasketButton;
        private System.Windows.Forms.Panel panel1;
    }
}