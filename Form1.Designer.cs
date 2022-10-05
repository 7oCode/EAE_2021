
namespace WOTD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn1 = new System.Windows.Forms.Button();
            this.lblage = new System.Windows.Forms.Label();
            this.tbox1 = new System.Windows.Forms.TextBox();
            this.lblwotd = new System.Windows.Forms.Label();
            this.wmeaning = new System.Windows.Forms.TextBox();
            this.wotd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(148, 263);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Press";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblage.Location = new System.Drawing.Point(145, 175);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(87, 15);
            this.lblage.TabIndex = 1;
            this.lblage.Text = "Input your age!";
            // 
            // tbox1
            // 
            this.tbox1.Location = new System.Drawing.Point(139, 212);
            this.tbox1.MaxLength = 2;
            this.tbox1.Name = "tbox1";
            this.tbox1.Size = new System.Drawing.Size(100, 20);
            this.tbox1.TabIndex = 2;
            this.tbox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox1_KeyPress);
            // 
            // lblwotd
            // 
            this.lblwotd.AutoSize = true;
            this.lblwotd.Location = new System.Drawing.Point(293, 215);
            this.lblwotd.Name = "lblwotd";
            this.lblwotd.Size = new System.Drawing.Size(121, 13);
            this.lblwotd.TabIndex = 3;
            this.lblwotd.Text = "Your word of the day is：";
            this.lblwotd.Click += new System.EventHandler(this.label2_Click);
            // 
            // wmeaning
            // 
            this.wmeaning.Location = new System.Drawing.Point(558, 172);
            this.wmeaning.Multiline = true;
            this.wmeaning.Name = "wmeaning";
            this.wmeaning.ReadOnly = true;
            this.wmeaning.Size = new System.Drawing.Size(155, 124);
            this.wmeaning.TabIndex = 4;
            // 
            // wotd
            // 
            this.wotd.AcceptsReturn = true;
            this.wotd.Location = new System.Drawing.Point(421, 211);
            this.wotd.Name = "wotd";
            this.wotd.ReadOnly = true;
            this.wotd.Size = new System.Drawing.Size(100, 20);
            this.wotd.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wotd);
            this.Controls.Add(this.wmeaning);
            this.Controls.Add(this.lblwotd);
            this.Controls.Add(this.tbox1);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "What\'s your word of the day?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.TextBox tbox1;
        private System.Windows.Forms.Label lblwotd;
        private System.Windows.Forms.TextBox wmeaning;
        private System.Windows.Forms.TextBox wotd;
    }
}

