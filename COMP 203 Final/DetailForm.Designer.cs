namespace COMP_203_Final
{
    partial class DetailForm
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
            System.Windows.Forms.Label bankAccountIDLabel;
            System.Windows.Forms.Label lastnameLabel;
            System.Windows.Forms.Label firstnameLabel;
            System.Windows.Forms.Label savingsBalanceLabel;
            System.Windows.Forms.Label checkingBalanceLabel;
            System.Windows.Forms.Label loanBalanceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailForm));
            this.accountDataSet1 = new COMP_203_Final.AccountDataSet();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountTableAdapter1 = new COMP_203_Final.AccountDataSetTableAdapters.AccountTableAdapter();
            this.tableAdapterManager1 = new COMP_203_Final.AccountDataSetTableAdapters.TableAdapterManager();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bankAccountIDTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.savingsBalanceTextBox = new System.Windows.Forms.TextBox();
            this.checkingBalanceTextBox = new System.Windows.Forms.TextBox();
            this.loanBalanceTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.fastCashButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.newSavingsTextBox = new System.Windows.Forms.TextBox();
            this.newCheckingTextBox = new System.Windows.Forms.TextBox();
            this.newLoanTextBox = new System.Windows.Forms.TextBox();
            this.withdrawCheckingButton = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.withdrawSavingsButton = new System.Windows.Forms.Button();
            this.loanPaymentButton = new System.Windows.Forms.Button();
            this.depositCheckingButton = new System.Windows.Forms.Button();
            this.depositSavingsButton = new System.Windows.Forms.Button();
            this.generateReceiptButton = new System.Windows.Forms.Button();
            bankAccountIDLabel = new System.Windows.Forms.Label();
            lastnameLabel = new System.Windows.Forms.Label();
            firstnameLabel = new System.Windows.Forms.Label();
            savingsBalanceLabel = new System.Windows.Forms.Label();
            checkingBalanceLabel = new System.Windows.Forms.Label();
            loanBalanceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bankAccountIDLabel
            // 
            bankAccountIDLabel.AutoSize = true;
            bankAccountIDLabel.Location = new System.Drawing.Point(47, 60);
            bankAccountIDLabel.Name = "bankAccountIDLabel";
            bankAccountIDLabel.Size = new System.Drawing.Size(92, 13);
            bankAccountIDLabel.TabIndex = 3;
            bankAccountIDLabel.Text = "Bank Account ID:";
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Location = new System.Drawing.Point(172, 15);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new System.Drawing.Size(56, 13);
            lastnameLabel.TabIndex = 5;
            lastnameLabel.Text = "Lastname:";
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new System.Drawing.Point(66, 15);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new System.Drawing.Size(55, 13);
            firstnameLabel.TabIndex = 7;
            firstnameLabel.Text = "Firstname:";
            // 
            // savingsBalanceLabel
            // 
            savingsBalanceLabel.AutoSize = true;
            savingsBalanceLabel.Location = new System.Drawing.Point(399, 64);
            savingsBalanceLabel.Name = "savingsBalanceLabel";
            savingsBalanceLabel.Size = new System.Drawing.Size(90, 13);
            savingsBalanceLabel.TabIndex = 9;
            savingsBalanceLabel.Text = "Savings Balance:";
            // 
            // checkingBalanceLabel
            // 
            checkingBalanceLabel.AutoSize = true;
            checkingBalanceLabel.Location = new System.Drawing.Point(392, 90);
            checkingBalanceLabel.Name = "checkingBalanceLabel";
            checkingBalanceLabel.Size = new System.Drawing.Size(97, 13);
            checkingBalanceLabel.TabIndex = 11;
            checkingBalanceLabel.Text = "Checking Balance:";
            // 
            // loanBalanceLabel
            // 
            loanBalanceLabel.AutoSize = true;
            loanBalanceLabel.Location = new System.Drawing.Point(406, 116);
            loanBalanceLabel.Name = "loanBalanceLabel";
            loanBalanceLabel.Size = new System.Drawing.Size(76, 13);
            loanBalanceLabel.TabIndex = 13;
            loanBalanceLabel.Text = "Loan Balance:";
            // 
            // accountDataSet1
            // 
            this.accountDataSet1.DataSetName = "AccountDataSet";
            this.accountDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.accountDataSet1;
            // 
            // accountTableAdapter1
            // 
            this.accountTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AccountTableAdapter = this.accountTableAdapter1;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = COMP_203_Final.AccountDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.accountBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(725, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Enabled = false;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Enabled = false;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Enabled = false;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Enabled = false;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bankAccountIDTextBox
            // 
            this.bankAccountIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "BankAccountID", true));
            this.bankAccountIDTextBox.Location = new System.Drawing.Point(150, 57);
            this.bankAccountIDTextBox.Name = "bankAccountIDTextBox";
            this.bankAccountIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.bankAccountIDTextBox.TabIndex = 4;
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "Lastname", true));
            this.lastnameTextBox.Location = new System.Drawing.Point(150, 31);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastnameTextBox.TabIndex = 6;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "Firstname", true));
            this.firstnameTextBox.Location = new System.Drawing.Point(44, 31);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstnameTextBox.TabIndex = 8;
            // 
            // savingsBalanceTextBox
            // 
            this.savingsBalanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "SavingsBalance", true));
            this.savingsBalanceTextBox.Location = new System.Drawing.Point(495, 61);
            this.savingsBalanceTextBox.Name = "savingsBalanceTextBox";
            this.savingsBalanceTextBox.Size = new System.Drawing.Size(159, 20);
            this.savingsBalanceTextBox.TabIndex = 10;
            // 
            // checkingBalanceTextBox
            // 
            this.checkingBalanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "CheckingBalance", true));
            this.checkingBalanceTextBox.Location = new System.Drawing.Point(495, 87);
            this.checkingBalanceTextBox.Name = "checkingBalanceTextBox";
            this.checkingBalanceTextBox.Size = new System.Drawing.Size(159, 20);
            this.checkingBalanceTextBox.TabIndex = 12;
            // 
            // loanBalanceTextBox
            // 
            this.loanBalanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "LoanBalance", true));
            this.loanBalanceTextBox.Location = new System.Drawing.Point(495, 113);
            this.loanBalanceTextBox.Name = "loanBalanceTextBox";
            this.loanBalanceTextBox.Size = new System.Drawing.Size(159, 20);
            this.loanBalanceTextBox.TabIndex = 14;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(517, 334);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // fastCashButton
            // 
            this.fastCashButton.Location = new System.Drawing.Point(50, 116);
            this.fastCashButton.Name = "fastCashButton";
            this.fastCashButton.Size = new System.Drawing.Size(105, 54);
            this.fastCashButton.TabIndex = 18;
            this.fastCashButton.Text = "FAST CASH $40 from checking";
            this.fastCashButton.UseVisualStyleBackColor = true;
            this.fastCashButton.Click += new System.EventHandler(this.fastCashButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Current Balances";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Balances After Transaction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Hello";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Please enter an amount then select an option";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Amount ==>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Savings Balance:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Checking Balance:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Loan Balance:";
            // 
            // newSavingsTextBox
            // 
            this.newSavingsTextBox.Location = new System.Drawing.Point(495, 195);
            this.newSavingsTextBox.Name = "newSavingsTextBox";
            this.newSavingsTextBox.Size = new System.Drawing.Size(159, 20);
            this.newSavingsTextBox.TabIndex = 27;
            // 
            // newCheckingTextBox
            // 
            this.newCheckingTextBox.Location = new System.Drawing.Point(495, 221);
            this.newCheckingTextBox.Name = "newCheckingTextBox";
            this.newCheckingTextBox.Size = new System.Drawing.Size(159, 20);
            this.newCheckingTextBox.TabIndex = 28;
            // 
            // newLoanTextBox
            // 
            this.newLoanTextBox.Location = new System.Drawing.Point(495, 247);
            this.newLoanTextBox.Name = "newLoanTextBox";
            this.newLoanTextBox.Size = new System.Drawing.Size(159, 20);
            this.newLoanTextBox.TabIndex = 29;
            // 
            // withdrawCheckingButton
            // 
            this.withdrawCheckingButton.Location = new System.Drawing.Point(38, 281);
            this.withdrawCheckingButton.Name = "withdrawCheckingButton";
            this.withdrawCheckingButton.Size = new System.Drawing.Size(92, 47);
            this.withdrawCheckingButton.TabIndex = 30;
            this.withdrawCheckingButton.Text = "Withdraw from Checking";
            this.withdrawCheckingButton.UseVisualStyleBackColor = true;
            this.withdrawCheckingButton.Click += new System.EventHandler(this.withdrawCheckingButton_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(87, 224);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(159, 20);
            this.amountTextBox.TabIndex = 31;
            // 
            // withdrawSavingsButton
            // 
            this.withdrawSavingsButton.Location = new System.Drawing.Point(136, 281);
            this.withdrawSavingsButton.Name = "withdrawSavingsButton";
            this.withdrawSavingsButton.Size = new System.Drawing.Size(92, 47);
            this.withdrawSavingsButton.TabIndex = 32;
            this.withdrawSavingsButton.Text = "Withdraw from Savings";
            this.withdrawSavingsButton.UseVisualStyleBackColor = true;
            this.withdrawSavingsButton.Click += new System.EventHandler(this.withdrawSavingsButton_Click);
            // 
            // loanPaymentButton
            // 
            this.loanPaymentButton.Location = new System.Drawing.Point(234, 281);
            this.loanPaymentButton.Name = "loanPaymentButton";
            this.loanPaymentButton.Size = new System.Drawing.Size(92, 47);
            this.loanPaymentButton.TabIndex = 33;
            this.loanPaymentButton.Text = "Loan Payment";
            this.loanPaymentButton.UseVisualStyleBackColor = true;
            this.loanPaymentButton.Click += new System.EventHandler(this.loanPaymentButton_Click);
            // 
            // depositCheckingButton
            // 
            this.depositCheckingButton.Location = new System.Drawing.Point(38, 334);
            this.depositCheckingButton.Name = "depositCheckingButton";
            this.depositCheckingButton.Size = new System.Drawing.Size(92, 47);
            this.depositCheckingButton.TabIndex = 34;
            this.depositCheckingButton.Text = "Checking Deposit";
            this.depositCheckingButton.UseVisualStyleBackColor = true;
            this.depositCheckingButton.Click += new System.EventHandler(this.depositCheckingButton_Click);
            // 
            // depositSavingsButton
            // 
            this.depositSavingsButton.Location = new System.Drawing.Point(136, 334);
            this.depositSavingsButton.Name = "depositSavingsButton";
            this.depositSavingsButton.Size = new System.Drawing.Size(92, 47);
            this.depositSavingsButton.TabIndex = 35;
            this.depositSavingsButton.Text = "Savings Deposit";
            this.depositSavingsButton.UseVisualStyleBackColor = true;
            this.depositSavingsButton.Click += new System.EventHandler(this.depositSavingsButton_Click);
            // 
            // generateReceiptButton
            // 
            this.generateReceiptButton.Location = new System.Drawing.Point(234, 334);
            this.generateReceiptButton.Name = "generateReceiptButton";
            this.generateReceiptButton.Size = new System.Drawing.Size(92, 47);
            this.generateReceiptButton.TabIndex = 36;
            this.generateReceiptButton.Text = "Generate Receipt";
            this.generateReceiptButton.UseVisualStyleBackColor = true;
            this.generateReceiptButton.Click += new System.EventHandler(this.generateReceiptButton_Click);
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 414);
            this.Controls.Add(this.generateReceiptButton);
            this.Controls.Add(this.depositSavingsButton);
            this.Controls.Add(this.depositCheckingButton);
            this.Controls.Add(this.loanPaymentButton);
            this.Controls.Add(this.withdrawSavingsButton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.withdrawCheckingButton);
            this.Controls.Add(this.newLoanTextBox);
            this.Controls.Add(this.newCheckingTextBox);
            this.Controls.Add(this.newSavingsTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fastCashButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(bankAccountIDLabel);
            this.Controls.Add(this.bankAccountIDTextBox);
            this.Controls.Add(lastnameLabel);
            this.Controls.Add(this.lastnameTextBox);
            this.Controls.Add(firstnameLabel);
            this.Controls.Add(this.firstnameTextBox);
            this.Controls.Add(savingsBalanceLabel);
            this.Controls.Add(this.savingsBalanceTextBox);
            this.Controls.Add(checkingBalanceLabel);
            this.Controls.Add(this.checkingBalanceTextBox);
            this.Controls.Add(loanBalanceLabel);
            this.Controls.Add(this.loanBalanceTextBox);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "DetailForm";
            this.Text = "DetailForm";
            this.Load += new System.EventHandler(this.DetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AccountDataSet accountDataSet;
        private AccountDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private AccountDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AccountDataSet accountDataSet1;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private AccountDataSetTableAdapters.AccountTableAdapter accountTableAdapter1;
        private AccountDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox bankAccountIDTextBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.TextBox savingsBalanceTextBox;
        private System.Windows.Forms.TextBox checkingBalanceTextBox;
        private System.Windows.Forms.TextBox loanBalanceTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button fastCashButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox newSavingsTextBox;
        private System.Windows.Forms.TextBox newCheckingTextBox;
        private System.Windows.Forms.TextBox newLoanTextBox;
        private System.Windows.Forms.Button withdrawCheckingButton;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button withdrawSavingsButton;
        private System.Windows.Forms.Button loanPaymentButton;
        private System.Windows.Forms.Button depositCheckingButton;
        private System.Windows.Forms.Button depositSavingsButton;
        private System.Windows.Forms.Button generateReceiptButton;
    }
}