namespace LunchOrder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbxMainCourse = new System.Windows.Forms.GroupBox();
            radSalad = new System.Windows.Forms.RadioButton();
            radHamburger = new System.Windows.Forms.RadioButton();
            radPizza = new System.Windows.Forms.RadioButton();
            groupBox2 = new System.Windows.Forms.GroupBox();
            txtOrderTotal = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtSalesTax = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtSubtotal = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnPlaceOrder = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            gbxAddOn = new System.Windows.Forms.GroupBox();
            chbx3 = new System.Windows.Forms.CheckBox();
            chbx2 = new System.Windows.Forms.CheckBox();
            chbx1 = new System.Windows.Forms.CheckBox();
            gbxMainCourse.SuspendLayout();
            groupBox2.SuspendLayout();
            gbxAddOn.SuspendLayout();
            SuspendLayout();
            // 
            // gbxMainCourse
            // 
            gbxMainCourse.Controls.Add(radSalad);
            gbxMainCourse.Controls.Add(radHamburger);
            gbxMainCourse.Controls.Add(radPizza);
            gbxMainCourse.Location = new System.Drawing.Point(63, 36);
            gbxMainCourse.Margin = new System.Windows.Forms.Padding(4);
            gbxMainCourse.Name = "gbxMainCourse";
            gbxMainCourse.Padding = new System.Windows.Forms.Padding(4);
            gbxMainCourse.Size = new System.Drawing.Size(295, 209);
            gbxMainCourse.TabIndex = 0;
            gbxMainCourse.TabStop = false;
            gbxMainCourse.Text = "Main Course";
            // 
            // radSalad
            // 
            radSalad.AutoSize = true;
            radSalad.Location = new System.Drawing.Point(23, 166);
            radSalad.Name = "radSalad";
            radSalad.Size = new System.Drawing.Size(183, 36);
            radSalad.TabIndex = 6;
            radSalad.Text = "Salad - $4.95";
            radSalad.UseVisualStyleBackColor = true;
            radSalad.CheckedChanged += radSalad_CheckedChanged;
            // 
            // radHamburger
            // 
            radHamburger.AutoSize = true;
            radHamburger.Checked = true;
            radHamburger.Location = new System.Drawing.Point(23, 52);
            radHamburger.Name = "radHamburger";
            radHamburger.Size = new System.Drawing.Size(247, 36);
            radHamburger.TabIndex = 4;
            radHamburger.TabStop = true;
            radHamburger.Text = "Hamburger - $6.95";
            radHamburger.UseVisualStyleBackColor = true;
            radHamburger.CheckedChanged += radHamburger_CheckedChanged;
            // 
            // radPizza
            // 
            radPizza.AutoSize = true;
            radPizza.Location = new System.Drawing.Point(23, 108);
            radPizza.Name = "radPizza";
            radPizza.Size = new System.Drawing.Size(179, 36);
            radPizza.TabIndex = 5;
            radPizza.Text = "Pizza - $5.95";
            radPizza.UseVisualStyleBackColor = true;
            radPizza.CheckedChanged += radPizza_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtOrderTotal);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtSalesTax);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtSubtotal);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new System.Drawing.Point(63, 284);
            groupBox2.Margin = new System.Windows.Forms.Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4);
            groupBox2.Size = new System.Drawing.Size(483, 245);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Location = new System.Drawing.Point(208, 162);
            txtOrderTotal.Margin = new System.Windows.Forms.Padding(4);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.ReadOnly = true;
            txtOrderTotal.Size = new System.Drawing.Size(193, 39);
            txtOrderTotal.TabIndex = 5;
            txtOrderTotal.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(52, 169);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(138, 32);
            label3.TabIndex = 4;
            label3.Text = "Order Total:";
            // 
            // txtSalesTax
            // 
            txtSalesTax.Location = new System.Drawing.Point(208, 107);
            txtSalesTax.Margin = new System.Windows.Forms.Padding(4);
            txtSalesTax.Name = "txtSalesTax";
            txtSalesTax.ReadOnly = true;
            txtSalesTax.Size = new System.Drawing.Size(193, 39);
            txtSalesTax.TabIndex = 3;
            txtSalesTax.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(52, 113);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(137, 32);
            label2.TabIndex = 2;
            label2.Text = "Tax (7.75%):";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new System.Drawing.Point(208, 49);
            txtSubtotal.Margin = new System.Windows.Forms.Padding(4);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new System.Drawing.Size(193, 39);
            txtSubtotal.TabIndex = 1;
            txtSubtotal.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(80, 55);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(108, 32);
            label1.TabIndex = 0;
            label1.Text = "Subtotal:";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new System.Drawing.Point(594, 305);
            btnPlaceOrder.Margin = new System.Windows.Forms.Padding(4);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new System.Drawing.Size(145, 53);
            btnPlaceOrder.TabIndex = 2;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(594, 474);
            btnExit.Margin = new System.Windows.Forms.Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(145, 53);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // gbxAddOn
            // 
            gbxAddOn.Controls.Add(chbx3);
            gbxAddOn.Controls.Add(chbx2);
            gbxAddOn.Controls.Add(chbx1);
            gbxAddOn.Location = new System.Drawing.Point(385, 36);
            gbxAddOn.Name = "gbxAddOn";
            gbxAddOn.Size = new System.Drawing.Size(395, 209);
            gbxAddOn.TabIndex = 4;
            gbxAddOn.TabStop = false;
            gbxAddOn.Text = "Add-on items ($.75/each)";
            // 
            // chbx3
            // 
            chbx3.AutoSize = true;
            chbx3.Location = new System.Drawing.Point(27, 166);
            chbx3.Name = "chbx3";
            chbx3.Size = new System.Drawing.Size(174, 36);
            chbx3.TabIndex = 2;
            chbx3.Text = "French Fries";
            chbx3.UseVisualStyleBackColor = true;
            chbx3.CheckedChanged += chbx3_CheckedChanged;
            // 
            // chbx2
            // 
            chbx2.AutoSize = true;
            chbx2.Location = new System.Drawing.Point(27, 109);
            chbx2.Name = "chbx2";
            chbx2.Size = new System.Drawing.Size(351, 36);
            chbx2.TabIndex = 1;
            chbx2.Text = "Ketchup, mustard, and mayo";
            chbx2.UseVisualStyleBackColor = true;
            chbx2.CheckedChanged += chbx2_CheckedChanged;
            // 
            // chbx1
            // 
            chbx1.AutoSize = true;
            chbx1.Location = new System.Drawing.Point(27, 55);
            chbx1.Name = "chbx1";
            chbx1.Size = new System.Drawing.Size(344, 36);
            chbx1.TabIndex = 0;
            chbx1.Text = "Lettuce, tomato, and onions";
            chbx1.UseVisualStyleBackColor = true;
            chbx1.CheckedChanged += chbx1_CheckedChanged;
            // 
            // Form1
            // 
            AcceptButton = btnPlaceOrder;
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new System.Drawing.Size(804, 585);
            Controls.Add(gbxAddOn);
            Controls.Add(btnExit);
            Controls.Add(btnPlaceOrder);
            Controls.Add(groupBox2);
            Controls.Add(gbxMainCourse);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Dinesh Adhikari’s Lunch Order Application";
            gbxMainCourse.ResumeLayout(false);
            gbxMainCourse.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gbxAddOn.ResumeLayout(false);
            gbxAddOn.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMainCourse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton radSalad;
        private System.Windows.Forms.RadioButton radHamburger;
        private System.Windows.Forms.RadioButton radPizza;
        private System.Windows.Forms.GroupBox gbxAddOn;
        private System.Windows.Forms.CheckBox chbx3;
        private System.Windows.Forms.CheckBox chbx2;
        private System.Windows.Forms.CheckBox chbx1;
    }
}

