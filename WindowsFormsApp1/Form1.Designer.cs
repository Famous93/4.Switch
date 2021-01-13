
namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.valinta1 = new System.Windows.Forms.Button();
            this.valinta2 = new System.Windows.Forms.Button();
            this.valinta3 = new System.Windows.Forms.Button();
            this.valinta4 = new System.Windows.Forms.Button();
            this.def = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // valinta1
            // 
            this.valinta1.Location = new System.Drawing.Point(38, 60);
            this.valinta1.Name = "valinta1";
            this.valinta1.Size = new System.Drawing.Size(101, 32);
            this.valinta1.TabIndex = 2;
            this.valinta1.Text = "Valinta1";
            this.valinta1.UseVisualStyleBackColor = true;
            this.valinta1.Click += new System.EventHandler(this.valinta1_Click);
            // 
            // valinta2
            // 
            this.valinta2.Location = new System.Drawing.Point(38, 111);
            this.valinta2.Name = "valinta2";
            this.valinta2.Size = new System.Drawing.Size(101, 32);
            this.valinta2.TabIndex = 3;
            this.valinta2.Text = "Valinta2";
            this.valinta2.UseVisualStyleBackColor = true;
            this.valinta2.Click += new System.EventHandler(this.valinta1_Click);
            // 
            // valinta3
            // 
            this.valinta3.Location = new System.Drawing.Point(38, 164);
            this.valinta3.Name = "valinta3";
            this.valinta3.Size = new System.Drawing.Size(101, 32);
            this.valinta3.TabIndex = 4;
            this.valinta3.Text = "Valinta3";
            this.valinta3.UseVisualStyleBackColor = true;
            this.valinta3.Click += new System.EventHandler(this.valinta1_Click);
            // 
            // valinta4
            // 
            this.valinta4.Location = new System.Drawing.Point(38, 217);
            this.valinta4.Name = "valinta4";
            this.valinta4.Size = new System.Drawing.Size(101, 32);
            this.valinta4.TabIndex = 5;
            this.valinta4.Text = "Valinta4";
            this.valinta4.UseVisualStyleBackColor = true;
            this.valinta4.Click += new System.EventHandler(this.valinta1_Click);
            // 
            // def
            // 
            this.def.Location = new System.Drawing.Point(38, 268);
            this.def.Name = "def";
            this.def.Size = new System.Drawing.Size(101, 32);
            this.def.TabIndex = 6;
            this.def.Text = "Default";
            this.def.UseVisualStyleBackColor = true;
            this.def.Click += new System.EventHandler(this.valinta1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.def);
            this.Controls.Add(this.valinta4);
            this.Controls.Add(this.valinta3);
            this.Controls.Add(this.valinta2);
            this.Controls.Add(this.valinta1);
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

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button valinta1;
        private System.Windows.Forms.Button valinta2;
        private System.Windows.Forms.Button valinta3;
        private System.Windows.Forms.Button valinta4;
        private System.Windows.Forms.Button def;
    }
}

