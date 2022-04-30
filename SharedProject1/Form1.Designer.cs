
namespace TemplateModWizard
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
            this.modAuthorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.modDescTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.targetTypeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.targetMethodTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // modAuthorTextBox
            // 
            this.modAuthorTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.modAuthorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modAuthorTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modAuthorTextBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.modAuthorTextBox.Location = new System.Drawing.Point(12, 73);
            this.modAuthorTextBox.MaxLength = 64;
            this.modAuthorTextBox.Name = "modAuthorTextBox";
            this.modAuthorTextBox.Size = new System.Drawing.Size(476, 22);
            this.modAuthorTextBox.TabIndex = 0;
            this.modAuthorTextBox.WordWrap = false;
            this.modAuthorTextBox.TextChanged += new System.EventHandler(this.modAuthorField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mod Author:";
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MediumPurple;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Template Options";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_OK
            // 
            this.BTN_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.BTN_OK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_OK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.BTN_OK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.BTN_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_OK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_OK.Location = new System.Drawing.Point(342, 297);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(146, 27);
            this.BTN_OK.TabIndex = 3;
            this.BTN_OK.Text = "OK";
            this.BTN_OK.UseVisualStyleBackColor = false;
            this.BTN_OK.Click += new System.EventHandler(this.BTN_OK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mod Description:";
            this.label3.UseMnemonic = false;
            // 
            // modDescTextBox
            // 
            this.modDescTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modDescTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.modDescTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modDescTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modDescTextBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.modDescTextBox.Location = new System.Drawing.Point(12, 123);
            this.modDescTextBox.MaxLength = 256;
            this.modDescTextBox.Multiline = true;
            this.modDescTextBox.Name = "modDescTextBox";
            this.modDescTextBox.Size = new System.Drawing.Size(476, 59);
            this.modDescTextBox.TabIndex = 4;
            this.modDescTextBox.Text = "Modifies Neos to do something";
            this.modDescTextBox.TextChanged += new System.EventHandler(this.modDescTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Target Type:";
            this.label4.UseMnemonic = false;
            // 
            // targetTypeTextBox
            // 
            this.targetTypeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.targetTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.targetTypeTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetTypeTextBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.targetTypeTextBox.Location = new System.Drawing.Point(12, 207);
            this.targetTypeTextBox.MaxLength = 64;
            this.targetTypeTextBox.Name = "targetTypeTextBox";
            this.targetTypeTextBox.Size = new System.Drawing.Size(476, 22);
            this.targetTypeTextBox.TabIndex = 6;
            this.targetTypeTextBox.Text = "InventoryBrowser";
            this.targetTypeTextBox.WordWrap = false;
            this.targetTypeTextBox.TextChanged += new System.EventHandler(this.targetTypeTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(12, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Target Method:";
            this.label5.UseMnemonic = false;
            // 
            // targetMethodTextBox
            // 
            this.targetMethodTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.targetMethodTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.targetMethodTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetMethodTextBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.targetMethodTextBox.Location = new System.Drawing.Point(12, 259);
            this.targetMethodTextBox.MaxLength = 64;
            this.targetMethodTextBox.Name = "targetMethodTextBox";
            this.targetMethodTextBox.Size = new System.Drawing.Size(476, 22);
            this.targetMethodTextBox.TabIndex = 8;
            this.targetMethodTextBox.Text = "OnItemSelected";
            this.targetMethodTextBox.WordWrap = false;
            this.targetMethodTextBox.TextChanged += new System.EventHandler(this.targetMethodTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.BTN_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.CancelButton = this.BTN_OK;
            this.ClientSize = new System.Drawing.Size(500, 334);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.targetMethodTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.targetTypeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modDescTextBox);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modAuthorTextBox);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox modAuthorTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_OK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox modDescTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox targetTypeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox targetMethodTextBox;
    }
}