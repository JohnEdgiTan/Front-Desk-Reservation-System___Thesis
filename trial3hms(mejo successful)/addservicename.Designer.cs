
namespace WindowsFormsApplication1
{
    partial class addservicename
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addservicename));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ratetb = new System.Windows.Forms.TextBox();
            this.servicenametb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.typetb = new System.Windows.Forms.TextBox();
            this.servicenameelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.servicerateelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.typeelipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button1elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button2elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(15, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(159, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ratetb
            // 
            this.ratetb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ratetb.Location = new System.Drawing.Point(92, 41);
            this.ratetb.Multiline = true;
            this.ratetb.Name = "ratetb";
            this.ratetb.Size = new System.Drawing.Size(142, 20);
            this.ratetb.TabIndex = 3;
            this.ratetb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ratetb_KeyPress);
            // 
            // servicenametb
            // 
            this.servicenametb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.servicenametb.Location = new System.Drawing.Point(92, 10);
            this.servicenametb.Multiline = true;
            this.servicenametb.Name = "servicenametb";
            this.servicenametb.Size = new System.Drawing.Size(142, 20);
            this.servicenametb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Service Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Service Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Service Type";
            // 
            // typetb
            // 
            this.typetb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.typetb.Location = new System.Drawing.Point(92, 73);
            this.typetb.Multiline = true;
            this.typetb.Name = "typetb";
            this.typetb.Size = new System.Drawing.Size(142, 20);
            this.typetb.TabIndex = 8;
            // 
            // servicenameelipse
            // 
            this.servicenameelipse.ElipseRadius = 7;
            this.servicenameelipse.TargetControl = this.servicenametb;
            // 
            // servicerateelipse
            // 
            this.servicerateelipse.ElipseRadius = 7;
            this.servicerateelipse.TargetControl = this.ratetb;
            // 
            // typeelipse
            // 
            this.typeelipse.ElipseRadius = 7;
            this.typeelipse.TargetControl = this.typetb;
            // 
            // button1elipse
            // 
            this.button1elipse.ElipseRadius = 7;
            this.button1elipse.TargetControl = this.button1;
            // 
            // button2elipse
            // 
            this.button2elipse.ElipseRadius = 7;
            this.button2elipse.TargetControl = this.button2;
            // 
            // addservicename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(247, 146);
            this.Controls.Add(this.typetb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.servicenametb);
            this.Controls.Add(this.ratetb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addservicename";
            this.Text = "Add Service Name";
            this.Load += new System.EventHandler(this.addservicename_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ratetb;
        private System.Windows.Forms.TextBox servicenametb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox typetb;
        private Bunifu.Framework.UI.BunifuElipse servicenameelipse;
        private Bunifu.Framework.UI.BunifuElipse servicerateelipse;
        private Bunifu.Framework.UI.BunifuElipse typeelipse;
        private Bunifu.Framework.UI.BunifuElipse button1elipse;
        private Bunifu.Framework.UI.BunifuElipse button2elipse;
    }
}