
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поменятьЦветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создаьОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поменятьЦветToolStripMenuItem,
            this.создаьОкноToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поменятьЦветToolStripMenuItem
            // 
            this.поменятьЦветToolStripMenuItem.Name = "поменятьЦветToolStripMenuItem";
            this.поменятьЦветToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.поменятьЦветToolStripMenuItem.Text = "Поменять цвет";
            this.поменятьЦветToolStripMenuItem.Click += new System.EventHandler(this.поменятьЦветToolStripMenuItem_Click);
            // 
            // создаьОкноToolStripMenuItem
            // 
            this.создаьОкноToolStripMenuItem.Name = "создаьОкноToolStripMenuItem";
            this.создаьОкноToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.создаьОкноToolStripMenuItem.Text = "Создать окно";
            this.создаьОкноToolStripMenuItem.Click += new System.EventHandler(this.создаьОкноToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поменятьЦветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создаьОкноToolStripMenuItem;
    }
}

