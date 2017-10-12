namespace Cash_Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.calculateTotalsLabel = new System.Windows.Forms.Button();
            this.calculateChangeLabel = new System.Windows.Forms.Button();
            this.printReceiptButton = new System.Windows.Forms.Button();
            this.numberOfLabel = new System.Windows.Forms.Label();
            this.pizzaAmountInput = new System.Windows.Forms.MaskedTextBox();
            this.friesAmountInput = new System.Windows.Forms.MaskedTextBox();
            this.drinksAmountInput = new System.Windows.Forms.MaskedTextBox();
            this.dividerLabel = new System.Windows.Forms.Label();
            this.totalsLabel = new System.Windows.Forms.Label();
            this.totalsLabelWord = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.tenderedAmountInput = new System.Windows.Forms.TextBox();
            this.changeLabelWord = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boneless Pizza";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newOrderButton
            // 
            this.newOrderButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderButton.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold);
            this.newOrderButton.ForeColor = System.Drawing.Color.White;
            this.newOrderButton.Location = new System.Drawing.Point(234, 517);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(226, 33);
            this.newOrderButton.TabIndex = 8;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            this.newOrderButton.Enter += new System.EventHandler(this.newOrderButton_Click);
            // 
            // calculateTotalsLabel
            // 
            this.calculateTotalsLabel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.calculateTotalsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateTotalsLabel.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold);
            this.calculateTotalsLabel.ForeColor = System.Drawing.Color.White;
            this.calculateTotalsLabel.Location = new System.Drawing.Point(12, 184);
            this.calculateTotalsLabel.Name = "calculateTotalsLabel";
            this.calculateTotalsLabel.Size = new System.Drawing.Size(186, 33);
            this.calculateTotalsLabel.TabIndex = 4;
            this.calculateTotalsLabel.Text = "Calulate Totals";
            this.calculateTotalsLabel.UseVisualStyleBackColor = true;
            this.calculateTotalsLabel.Click += new System.EventHandler(this.calculateTotalsLabel_Click);
            this.calculateTotalsLabel.Enter += new System.EventHandler(this.calculateTotalsLabel_Click);
            // 
            // calculateChangeLabel
            // 
            this.calculateChangeLabel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.calculateChangeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateChangeLabel.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold);
            this.calculateChangeLabel.ForeColor = System.Drawing.Color.White;
            this.calculateChangeLabel.Location = new System.Drawing.Point(12, 432);
            this.calculateChangeLabel.Name = "calculateChangeLabel";
            this.calculateChangeLabel.Size = new System.Drawing.Size(186, 33);
            this.calculateChangeLabel.TabIndex = 6;
            this.calculateChangeLabel.Text = "Calulate Change";
            this.calculateChangeLabel.UseVisualStyleBackColor = true;
            this.calculateChangeLabel.Click += new System.EventHandler(this.calculateChangeLabel_Click);
            this.calculateChangeLabel.Enter += new System.EventHandler(this.calculateChangeLabel_Click);
            // 
            // printReceiptButton
            // 
            this.printReceiptButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.printReceiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printReceiptButton.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold);
            this.printReceiptButton.ForeColor = System.Drawing.Color.White;
            this.printReceiptButton.Location = new System.Drawing.Point(12, 517);
            this.printReceiptButton.Name = "printReceiptButton";
            this.printReceiptButton.Size = new System.Drawing.Size(186, 33);
            this.printReceiptButton.TabIndex = 7;
            this.printReceiptButton.Text = "Print Receipt";
            this.printReceiptButton.UseVisualStyleBackColor = true;
            this.printReceiptButton.Click += new System.EventHandler(this.printReceiptButton_Click);
            this.printReceiptButton.Enter += new System.EventHandler(this.printReceiptButton_Click);
            // 
            // numberOfLabel
            // 
            this.numberOfLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfLabel.ForeColor = System.Drawing.Color.White;
            this.numberOfLabel.Location = new System.Drawing.Point(3, 68);
            this.numberOfLabel.Name = "numberOfLabel";
            this.numberOfLabel.Size = new System.Drawing.Size(148, 113);
            this.numberOfLabel.TabIndex = 9;
            // 
            // pizzaAmountInput
            // 
            this.pizzaAmountInput.Location = new System.Drawing.Point(157, 68);
            this.pizzaAmountInput.Name = "pizzaAmountInput";
            this.pizzaAmountInput.Size = new System.Drawing.Size(41, 20);
            this.pizzaAmountInput.TabIndex = 1;
            this.pizzaAmountInput.Tag = "";
            this.pizzaAmountInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // friesAmountInput
            // 
            this.friesAmountInput.Location = new System.Drawing.Point(157, 103);
            this.friesAmountInput.Name = "friesAmountInput";
            this.friesAmountInput.Size = new System.Drawing.Size(41, 20);
            this.friesAmountInput.TabIndex = 2;
            this.friesAmountInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // drinksAmountInput
            // 
            this.drinksAmountInput.Location = new System.Drawing.Point(157, 140);
            this.drinksAmountInput.Name = "drinksAmountInput";
            this.drinksAmountInput.Size = new System.Drawing.Size(41, 20);
            this.drinksAmountInput.TabIndex = 3;
            this.drinksAmountInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dividerLabel
            // 
            this.dividerLabel.BackColor = System.Drawing.Color.Salmon;
            this.dividerLabel.Location = new System.Drawing.Point(12, 364);
            this.dividerLabel.Name = "dividerLabel";
            this.dividerLabel.Size = new System.Drawing.Size(186, 17);
            this.dividerLabel.TabIndex = 9;
            // 
            // totalsLabel
            // 
            this.totalsLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsLabel.ForeColor = System.Drawing.Color.White;
            this.totalsLabel.Location = new System.Drawing.Point(120, 220);
            this.totalsLabel.Name = "totalsLabel";
            this.totalsLabel.Size = new System.Drawing.Size(78, 131);
            this.totalsLabel.TabIndex = 10;
            this.totalsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalsLabelWord
            // 
            this.totalsLabelWord.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsLabelWord.ForeColor = System.Drawing.Color.White;
            this.totalsLabelWord.Location = new System.Drawing.Point(9, 220);
            this.totalsLabelWord.Name = "totalsLabelWord";
            this.totalsLabelWord.Size = new System.Drawing.Size(105, 131);
            this.totalsLabelWord.TabIndex = 11;
            this.totalsLabelWord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.ForeColor = System.Drawing.Color.White;
            this.tenderedLabel.Location = new System.Drawing.Point(9, 395);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(100, 23);
            this.tenderedLabel.TabIndex = 12;
            this.tenderedLabel.Text = "Tendered";
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(8, 220);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(189, 120);
            this.errorLabel.TabIndex = 13;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabel.Visible = false;
            // 
            // tenderedAmountInput
            // 
            this.tenderedAmountInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tenderedAmountInput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tenderedAmountInput.Location = new System.Drawing.Point(124, 395);
            this.tenderedAmountInput.Multiline = true;
            this.tenderedAmountInput.Name = "tenderedAmountInput";
            this.tenderedAmountInput.Size = new System.Drawing.Size(74, 20);
            this.tenderedAmountInput.TabIndex = 5;
            this.tenderedAmountInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // changeLabelWord
            // 
            this.changeLabelWord.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabelWord.ForeColor = System.Drawing.Color.White;
            this.changeLabelWord.Location = new System.Drawing.Point(9, 477);
            this.changeLabelWord.Name = "changeLabelWord";
            this.changeLabelWord.Size = new System.Drawing.Size(100, 37);
            this.changeLabelWord.TabIndex = 15;
            this.changeLabelWord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // changeLabel
            // 
            this.changeLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.ForeColor = System.Drawing.Color.White;
            this.changeLabel.Location = new System.Drawing.Point(121, 477);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(77, 37);
            this.changeLabel.TabIndex = 16;
            this.changeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // changeErrorLabel
            // 
            this.changeErrorLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.changeErrorLabel.Location = new System.Drawing.Point(12, 468);
            this.changeErrorLabel.Name = "changeErrorLabel";
            this.changeErrorLabel.Size = new System.Drawing.Size(186, 31);
            this.changeErrorLabel.TabIndex = 17;
            this.changeErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.changeErrorLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.changeErrorLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeLabelWord);
            this.Controls.Add(this.tenderedAmountInput);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalsLabelWord);
            this.Controls.Add(this.totalsLabel);
            this.Controls.Add(this.dividerLabel);
            this.Controls.Add(this.drinksAmountInput);
            this.Controls.Add(this.friesAmountInput);
            this.Controls.Add(this.pizzaAmountInput);
            this.Controls.Add(this.numberOfLabel);
            this.Controls.Add(this.printReceiptButton);
            this.Controls.Add(this.calculateChangeLabel);
            this.Controls.Add(this.calculateTotalsLabel);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cash Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Button calculateTotalsLabel;
        private System.Windows.Forms.Button calculateChangeLabel;
        private System.Windows.Forms.Button printReceiptButton;
        private System.Windows.Forms.Label numberOfLabel;
        private System.Windows.Forms.MaskedTextBox pizzaAmountInput;
        private System.Windows.Forms.MaskedTextBox friesAmountInput;
        private System.Windows.Forms.MaskedTextBox drinksAmountInput;
        private System.Windows.Forms.Label dividerLabel;
        private System.Windows.Forms.Label totalsLabel;
        private System.Windows.Forms.Label totalsLabelWord;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox tenderedAmountInput;
        private System.Windows.Forms.Label changeLabelWord;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeErrorLabel;
    }
}

