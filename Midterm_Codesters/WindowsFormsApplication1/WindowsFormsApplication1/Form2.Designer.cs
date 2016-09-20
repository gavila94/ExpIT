namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.chkSmoothie = new System.Windows.Forms.CheckBox();
            this.chkHotChocolate = new System.Windows.Forms.CheckBox();
            this.chkLatte = new System.Windows.Forms.CheckBox();
            this.chkTea = new System.Windows.Forms.CheckBox();
            this.chkIcedCoffee = new System.Windows.Forms.CheckBox();
            this.chkCoffee = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDonut = new System.Windows.Forms.CheckBox();
            this.chkWrap = new System.Windows.Forms.CheckBox();
            this.chkBfastSand = new System.Windows.Forms.CheckBox();
            this.chkFruit = new System.Windows.Forms.CheckBox();
            this.chkCoffeeCake = new System.Windows.Forms.CheckBox();
            this.chkBagel = new System.Windows.Forms.CheckBox();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.GroupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.chkSmoothie);
            this.GroupBox3.Controls.Add(this.chkHotChocolate);
            this.GroupBox3.Controls.Add(this.chkLatte);
            this.GroupBox3.Controls.Add(this.chkTea);
            this.GroupBox3.Controls.Add(this.chkIcedCoffee);
            this.GroupBox3.Controls.Add(this.chkCoffee);
            this.GroupBox3.Location = new System.Drawing.Point(12, 23);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(168, 193);
            this.GroupBox3.TabIndex = 10;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Drinks";
            this.GroupBox3.Enter += new System.EventHandler(this.GroupBox3_Enter);
            // 
            // chkSmoothie
            // 
            this.chkSmoothie.AutoSize = true;
            this.chkSmoothie.Location = new System.Drawing.Point(6, 155);
            this.chkSmoothie.Name = "chkSmoothie";
            this.chkSmoothie.Size = new System.Drawing.Size(106, 17);
            this.chkSmoothie.TabIndex = 5;
            this.chkSmoothie.Text = "Smoothie ($4.00)";
            this.chkSmoothie.UseVisualStyleBackColor = true;
            // 
            // chkHotChocolate
            // 
            this.chkHotChocolate.AutoSize = true;
            this.chkHotChocolate.Location = new System.Drawing.Point(6, 132);
            this.chkHotChocolate.Name = "chkHotChocolate";
            this.chkHotChocolate.Size = new System.Drawing.Size(130, 17);
            this.chkHotChocolate.TabIndex = 4;
            this.chkHotChocolate.Text = "Hot Chocolate ($2.50)";
            this.chkHotChocolate.UseVisualStyleBackColor = true;
            // 
            // chkLatte
            // 
            this.chkLatte.AutoSize = true;
            this.chkLatte.Location = new System.Drawing.Point(6, 104);
            this.chkLatte.Name = "chkLatte";
            this.chkLatte.Size = new System.Drawing.Size(86, 17);
            this.chkLatte.TabIndex = 3;
            this.chkLatte.Text = "Latte ($2.99)";
            this.chkLatte.UseVisualStyleBackColor = true;
            // 
            // chkTea
            // 
            this.chkTea.AutoSize = true;
            this.chkTea.Location = new System.Drawing.Point(6, 76);
            this.chkTea.Name = "chkTea";
            this.chkTea.Size = new System.Drawing.Size(81, 17);
            this.chkTea.TabIndex = 2;
            this.chkTea.Text = "Tea ($1.99)";
            this.chkTea.UseVisualStyleBackColor = true;
            // 
            // chkIcedCoffee
            // 
            this.chkIcedCoffee.AutoSize = true;
            this.chkIcedCoffee.Location = new System.Drawing.Point(7, 48);
            this.chkIcedCoffee.Name = "chkIcedCoffee";
            this.chkIcedCoffee.Size = new System.Drawing.Size(117, 17);
            this.chkIcedCoffee.TabIndex = 1;
            this.chkIcedCoffee.Text = "Iced Coffee ($2.50)";
            this.chkIcedCoffee.UseVisualStyleBackColor = true;
            // 
            // chkCoffee
            // 
            this.chkCoffee.AutoSize = true;
            this.chkCoffee.Location = new System.Drawing.Point(7, 20);
            this.chkCoffee.Name = "chkCoffee";
            this.chkCoffee.Size = new System.Drawing.Size(93, 17);
            this.chkCoffee.TabIndex = 0;
            this.chkCoffee.Text = "Coffee ($1.99)";
            this.chkCoffee.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkDonut);
            this.groupBox1.Controls.Add(this.chkWrap);
            this.groupBox1.Controls.Add(this.chkBfastSand);
            this.groupBox1.Controls.Add(this.chkFruit);
            this.groupBox1.Controls.Add(this.chkCoffeeCake);
            this.groupBox1.Controls.Add(this.chkBagel);
            this.groupBox1.Location = new System.Drawing.Point(256, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 172);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Food";
            // 
            // chkDonut
            // 
            this.chkDonut.AutoSize = true;
            this.chkDonut.Location = new System.Drawing.Point(6, 155);
            this.chkDonut.Name = "chkDonut";
            this.chkDonut.Size = new System.Drawing.Size(91, 17);
            this.chkDonut.TabIndex = 5;
            this.chkDonut.Text = "Donut ($0.99)";
            this.chkDonut.UseVisualStyleBackColor = true;
            // 
            // chkWrap
            // 
            this.chkWrap.AutoSize = true;
            this.chkWrap.Location = new System.Drawing.Point(6, 132);
            this.chkWrap.Name = "chkWrap";
            this.chkWrap.Size = new System.Drawing.Size(88, 17);
            this.chkWrap.TabIndex = 4;
            this.chkWrap.Text = "Wrap ($5.00)";
            this.chkWrap.UseVisualStyleBackColor = true;
            // 
            // chkBfastSand
            // 
            this.chkBfastSand.AutoSize = true;
            this.chkBfastSand.Location = new System.Drawing.Point(6, 104);
            this.chkBfastSand.Name = "chkBfastSand";
            this.chkBfastSand.Size = new System.Drawing.Size(157, 17);
            this.chkBfastSand.TabIndex = 3;
            this.chkBfastSand.Text = "Breakfast Sandwich ($2.75)";
            this.chkBfastSand.UseVisualStyleBackColor = true;
            // 
            // chkFruit
            // 
            this.chkFruit.AutoSize = true;
            this.chkFruit.Location = new System.Drawing.Point(6, 76);
            this.chkFruit.Name = "chkFruit";
            this.chkFruit.Size = new System.Drawing.Size(82, 17);
            this.chkFruit.TabIndex = 2;
            this.chkFruit.Text = "Fruit ($2.00)";
            this.chkFruit.UseVisualStyleBackColor = true;
            // 
            // chkCoffeeCake
            // 
            this.chkCoffeeCake.AutoSize = true;
            this.chkCoffeeCake.Location = new System.Drawing.Point(7, 48);
            this.chkCoffeeCake.Name = "chkCoffeeCake";
            this.chkCoffeeCake.Size = new System.Drawing.Size(121, 17);
            this.chkCoffeeCake.TabIndex = 1;
            this.chkCoffeeCake.Text = "Coffee Cake ($3.50)";
            this.chkCoffeeCake.UseVisualStyleBackColor = true;
            // 
            // chkBagel
            // 
            this.chkBagel.AutoSize = true;
            this.chkBagel.Location = new System.Drawing.Point(7, 20);
            this.chkBagel.Name = "chkBagel";
            this.chkBagel.Size = new System.Drawing.Size(89, 17);
            this.chkBagel.TabIndex = 0;
            this.chkBagel.Text = "Bagel ($1.50)";
            this.chkBagel.UseVisualStyleBackColor = true;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.lblTotal);
            this.GroupBox4.Controls.Add(this.lblTax);
            this.GroupBox4.Controls.Add(this.lblSubtotal);
            this.GroupBox4.Controls.Add(this.Label3);
            this.GroupBox4.Controls.Add(this.Label2);
            this.GroupBox4.Controls.Add(this.Label1);
            this.GroupBox4.Location = new System.Drawing.Point(248, 205);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(200, 126);
            this.GroupBox4.TabIndex = 12;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Price";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(84, 90);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 5;
            // 
            // lblTax
            // 
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(84, 56);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(100, 23);
            this.lblTax.TabIndex = 4;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(84, 22);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(100, 23);
            this.lblSubtotal.TabIndex = 3;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(22, 94);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(34, 13);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Total:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(28, 61);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(28, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Tax:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(7, 27);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(49, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Subtotal:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(8, 337);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(96, 42);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "&Calculate Total";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(119, 337);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 42);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "&Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(215, 337);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 42);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 24);
            this.button1.TabIndex = 16;
            this.button1.Text = "Cash";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 24);
            this.button2.TabIndex = 17;
            this.button2.Text = "Check";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 24);
            this.button3.TabIndex = 18;
            this.button3.Text = "Credit Card";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 391);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBox3);
            this.Name = "Form2";
            this.Text = "Codesters Coffee Shop";
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.CheckBox chkSmoothie;
        internal System.Windows.Forms.CheckBox chkHotChocolate;
        internal System.Windows.Forms.CheckBox chkLatte;
        internal System.Windows.Forms.CheckBox chkTea;
        internal System.Windows.Forms.CheckBox chkIcedCoffee;
        internal System.Windows.Forms.CheckBox chkCoffee;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.CheckBox chkWrap;
        internal System.Windows.Forms.CheckBox chkBfastSand;
        internal System.Windows.Forms.CheckBox chkFruit;
        internal System.Windows.Forms.CheckBox chkCoffeeCake;
        internal System.Windows.Forms.CheckBox chkBagel;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.Label lblTotal;
        internal System.Windows.Forms.Label lblTax;
        internal System.Windows.Forms.Label lblSubtotal;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnCalculate;
        internal System.Windows.Forms.Button btnReset;
        internal System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        internal System.Windows.Forms.CheckBox chkDonut;
    }
}