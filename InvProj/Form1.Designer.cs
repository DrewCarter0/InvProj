namespace InvProj
{
    partial class InvMgmt
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
            this.buttonClear = new System.Windows.Forms.Button();
            this.textUPC = new System.Windows.Forms.TextBox();
            this.textVendor = new System.Windows.Forms.TextBox();
            this.textReorderQty = new System.Windows.Forms.TextBox();
            this.textQtyoOrder = new System.Windows.Forms.TextBox();
            this.textReorderPt = new System.Windows.Forms.TextBox();
            this.textQTYoH = new System.Windows.Forms.TextBox();
            this.buttonPull = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.UPC = new System.Windows.Forms.Label();
            this.textDesc = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonVendOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 261);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 0;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textUPC
            // 
            this.textUPC.Location = new System.Drawing.Point(88, 9);
            this.textUPC.Name = "textUPC";
            this.textUPC.Size = new System.Drawing.Size(100, 20);
            this.textUPC.TabIndex = 1;
            // 
            // textVendor
            // 
            this.textVendor.Location = new System.Drawing.Point(88, 199);
            this.textVendor.Name = "textVendor";
            this.textVendor.Size = new System.Drawing.Size(100, 20);
            this.textVendor.TabIndex = 3;
            // 
            // textReorderQty
            // 
            this.textReorderQty.Location = new System.Drawing.Point(272, 173);
            this.textReorderQty.Name = "textReorderQty";
            this.textReorderQty.Size = new System.Drawing.Size(100, 20);
            this.textReorderQty.TabIndex = 4;
            // 
            // textQtyoOrder
            // 
            this.textQtyoOrder.Location = new System.Drawing.Point(88, 173);
            this.textQtyoOrder.Name = "textQtyoOrder";
            this.textQtyoOrder.Size = new System.Drawing.Size(100, 20);
            this.textQtyoOrder.TabIndex = 5;
            // 
            // textReorderPt
            // 
            this.textReorderPt.Location = new System.Drawing.Point(272, 147);
            this.textReorderPt.Name = "textReorderPt";
            this.textReorderPt.Size = new System.Drawing.Size(100, 20);
            this.textReorderPt.TabIndex = 6;
            // 
            // textQTYoH
            // 
            this.textQTYoH.Location = new System.Drawing.Point(88, 147);
            this.textQTYoH.Name = "textQTYoH";
            this.textQTYoH.Size = new System.Drawing.Size(100, 20);
            this.textQTYoH.TabIndex = 7;
            // 
            // buttonPull
            // 
            this.buttonPull.Location = new System.Drawing.Point(302, 232);
            this.buttonPull.Name = "buttonPull";
            this.buttonPull.Size = new System.Drawing.Size(75, 23);
            this.buttonPull.TabIndex = 8;
            this.buttonPull.Text = "Pull";
            this.buttonPull.UseVisualStyleBackColor = true;
            this.buttonPull.Click += new System.EventHandler(this.buttonPull_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(302, 261);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // UPC
            // 
            this.UPC.AutoSize = true;
            this.UPC.Location = new System.Drawing.Point(13, 12);
            this.UPC.Name = "UPC";
            this.UPC.Size = new System.Drawing.Size(57, 13);
            this.UPC.TabIndex = 11;
            this.UPC.Text = "UPC Code";
            // 
            // textDesc
            // 
            this.textDesc.Location = new System.Drawing.Point(88, 35);
            this.textDesc.Name = "textDesc";
            this.textDesc.Size = new System.Drawing.Size(284, 106);
            this.textDesc.TabIndex = 12;
            this.textDesc.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Qty On Hand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Reorder Point";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Reorder Qty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Qty-On-Order";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Vendor";
            // 
            // buttonVendOpen
            // 
            this.buttonVendOpen.Location = new System.Drawing.Point(12, 232);
            this.buttonVendOpen.Name = "buttonVendOpen";
            this.buttonVendOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonVendOpen.TabIndex = 19;
            this.buttonVendOpen.Text = "Vendor";
            this.buttonVendOpen.UseVisualStyleBackColor = true;
            this.buttonVendOpen.Click += new System.EventHandler(this.buttonVendOpen_Click);
            // 
            // InvMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 296);
            this.Controls.Add(this.buttonVendOpen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDesc);
            this.Controls.Add(this.UPC);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonPull);
            this.Controls.Add(this.textQTYoH);
            this.Controls.Add(this.textReorderPt);
            this.Controls.Add(this.textQtyoOrder);
            this.Controls.Add(this.textReorderQty);
            this.Controls.Add(this.textVendor);
            this.Controls.Add(this.textUPC);
            this.Controls.Add(this.buttonClear);
            this.Name = "InvMgmt";
            this.Text = "InvMgmt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textUPC;
        private System.Windows.Forms.TextBox textVendor;
        private System.Windows.Forms.TextBox textReorderQty;
        private System.Windows.Forms.TextBox textQtyoOrder;
        private System.Windows.Forms.TextBox textReorderPt;
        private System.Windows.Forms.TextBox textQTYoH;
        private System.Windows.Forms.Button buttonPull;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label UPC;
        private System.Windows.Forms.RichTextBox textDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonVendOpen;
    }
}

