using System.Drawing;
using System.Windows.Forms;
using System;

namespace SierpinskiCarpet
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxA;
        private TextBox textBoxB;
        private TextBox textBoxK;
        private Button buttonDraw;
        private Panel panelDraw;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxA = new TextBox();
            this.textBoxB = new TextBox();
            this.textBoxK = new TextBox();
            this.buttonDraw = new Button();
            this.panelDraw = new Panel();
            this.SuspendLayout();

            // 
            // textBoxA
            // 
            this.textBoxA.Location = new Point(12, 12);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new Size(100, 20);
            this.textBoxA.TabIndex = 0;

            // 
            // textBoxB
            // 
            this.textBoxB.Location = new Point(12, 38);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new Size(100, 20);
            this.textBoxB.TabIndex = 1;

            // 
            // textBoxK
            // 
            this.textBoxK.Location = new Point(12, 64);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new Size(100, 20);
            this.textBoxK.TabIndex = 2;

            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new Point(12, 90);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new Size(100, 23);
            this.buttonDraw.TabIndex = 3;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new EventHandler(this.buttonDraw_Click);

            // 
            // panelDraw
            // 
            this.panelDraw.Location = new Point(130, 12);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new Size(400, 400);
            this.panelDraw.TabIndex = 4;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(544, 421);
            this.Controls.Add(this.panelDraw);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Name = "Form1";
            this.Text = "Sierpinski Carpet";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
