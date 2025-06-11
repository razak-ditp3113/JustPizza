namespace JustPizza
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circlePizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squarePizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexagonPizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pizzaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(882, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pizzaToolStripMenuItem
            // 
            this.pizzaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.circlePizzaToolStripMenuItem,
            this.squarePizzaToolStripMenuItem,
            this.hexagonPizzaToolStripMenuItem});
            this.pizzaToolStripMenuItem.Name = "pizzaToolStripMenuItem";
            this.pizzaToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.pizzaToolStripMenuItem.Text = "Pizza";
            // 
            // circlePizzaToolStripMenuItem
            // 
            this.circlePizzaToolStripMenuItem.Name = "circlePizzaToolStripMenuItem";
            this.circlePizzaToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.circlePizzaToolStripMenuItem.Text = "Circle Pizza";
            this.circlePizzaToolStripMenuItem.Click += new System.EventHandler(this.circlePizzaToolStripMenuItem_Click);
            // 
            // squarePizzaToolStripMenuItem
            // 
            this.squarePizzaToolStripMenuItem.Name = "squarePizzaToolStripMenuItem";
            this.squarePizzaToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.squarePizzaToolStripMenuItem.Text = "Square Pizza";
            this.squarePizzaToolStripMenuItem.Click += new System.EventHandler(this.squarePizzaToolStripMenuItem_Click);
            // 
            // hexagonPizzaToolStripMenuItem
            // 
            this.hexagonPizzaToolStripMenuItem.Name = "hexagonPizzaToolStripMenuItem";
            this.hexagonPizzaToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.hexagonPizzaToolStripMenuItem.Text = "Hexagon Pizza";
            this.hexagonPizzaToolStripMenuItem.Click += new System.EventHandler(this.hexagonPizzaToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JustPizza.Properties.Resources.just_pizza_5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circlePizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem squarePizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hexagonPizzaToolStripMenuItem;
    }
}

