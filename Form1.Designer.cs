namespace GasNI2
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
            this.lblAccRef = new System.Windows.Forms.Label();
            this.lblAccName = new System.Windows.Forms.Label();
            this.lblAccAddress = new System.Windows.Forms.Label();
            this.lblAccBalance = new System.Windows.Forms.Label();
            this.lblTotalUnitsUsed = new System.Windows.Forms.Label();
            this.lblUnitCost = new System.Windows.Forms.Label();
            this.txtBoxAccRef = new System.Windows.Forms.TextBox();
            this.txtBoxAccName = new System.Windows.Forms.TextBox();
            this.txtBoxAccAddress = new System.Windows.Forms.TextBox();
            this.txtBoxAccBalance = new System.Windows.Forms.TextBox();
            this.txtBoxTotalUnitsUsed = new System.Windows.Forms.TextBox();
            this.txtBoxUnitCost = new System.Windows.Forms.TextBox();
            this.lstBoxCustomerAccounts = new System.Windows.Forms.ListBox();
            this.txtBoxRecordUnits = new System.Windows.Forms.TextBox();
            this.txtBoxPayment = new System.Windows.Forms.TextBox();
            this.txtBoxSetUnits = new System.Windows.Forms.TextBox();
            this.rdoByRef = new System.Windows.Forms.RadioButton();
            this.rdoByBalance = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRecordUnits = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnSetUnits = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.lblCustomerAccounts = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAccRef
            // 
            this.lblAccRef.AutoSize = true;
            this.lblAccRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccRef.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAccRef.Location = new System.Drawing.Point(12, 34);
            this.lblAccRef.Name = "lblAccRef";
            this.lblAccRef.Size = new System.Drawing.Size(61, 16);
            this.lblAccRef.TabIndex = 0;
            this.lblAccRef.Text = "Acc Ref";
            // 
            // lblAccName
            // 
            this.lblAccName.AutoSize = true;
            this.lblAccName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAccName.Location = new System.Drawing.Point(12, 97);
            this.lblAccName.Name = "lblAccName";
            this.lblAccName.Size = new System.Drawing.Size(78, 16);
            this.lblAccName.TabIndex = 1;
            this.lblAccName.Text = "Acc Name";
            // 
            // lblAccAddress
            // 
            this.lblAccAddress.AutoSize = true;
            this.lblAccAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAccAddress.Location = new System.Drawing.Point(12, 154);
            this.lblAccAddress.Name = "lblAccAddress";
            this.lblAccAddress.Size = new System.Drawing.Size(95, 16);
            this.lblAccAddress.TabIndex = 2;
            this.lblAccAddress.Text = "Acc Address";
            // 
            // lblAccBalance
            // 
            this.lblAccBalance.AutoSize = true;
            this.lblAccBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccBalance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAccBalance.Location = new System.Drawing.Point(12, 224);
            this.lblAccBalance.Name = "lblAccBalance";
            this.lblAccBalance.Size = new System.Drawing.Size(94, 16);
            this.lblAccBalance.TabIndex = 3;
            this.lblAccBalance.Text = "Acc Balance";
            // 
            // lblTotalUnitsUsed
            // 
            this.lblTotalUnitsUsed.AutoSize = true;
            this.lblTotalUnitsUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUnitsUsed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalUnitsUsed.Location = new System.Drawing.Point(7, 293);
            this.lblTotalUnitsUsed.Name = "lblTotalUnitsUsed";
            this.lblTotalUnitsUsed.Size = new System.Drawing.Size(123, 16);
            this.lblTotalUnitsUsed.TabIndex = 4;
            this.lblTotalUnitsUsed.Text = "Total Units Used";
            // 
            // lblUnitCost
            // 
            this.lblUnitCost.AutoSize = true;
            this.lblUnitCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitCost.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUnitCost.Location = new System.Drawing.Point(12, 364);
            this.lblUnitCost.Name = "lblUnitCost";
            this.lblUnitCost.Size = new System.Drawing.Size(69, 16);
            this.lblUnitCost.TabIndex = 5;
            this.lblUnitCost.Text = "Unit Cost";
            // 
            // txtBoxAccRef
            // 
            this.txtBoxAccRef.Location = new System.Drawing.Point(149, 30);
            this.txtBoxAccRef.Name = "txtBoxAccRef";
            this.txtBoxAccRef.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAccRef.TabIndex = 6;
            // 
            // txtBoxAccName
            // 
            this.txtBoxAccName.Location = new System.Drawing.Point(149, 97);
            this.txtBoxAccName.Name = "txtBoxAccName";
            this.txtBoxAccName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAccName.TabIndex = 7;
            // 
            // txtBoxAccAddress
            // 
            this.txtBoxAccAddress.Location = new System.Drawing.Point(149, 154);
            this.txtBoxAccAddress.Name = "txtBoxAccAddress";
            this.txtBoxAccAddress.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAccAddress.TabIndex = 8;
            // 
            // txtBoxAccBalance
            // 
            this.txtBoxAccBalance.Location = new System.Drawing.Point(149, 228);
            this.txtBoxAccBalance.Name = "txtBoxAccBalance";
            this.txtBoxAccBalance.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAccBalance.TabIndex = 9;
            // 
            // txtBoxTotalUnitsUsed
            // 
            this.txtBoxTotalUnitsUsed.Location = new System.Drawing.Point(149, 293);
            this.txtBoxTotalUnitsUsed.Name = "txtBoxTotalUnitsUsed";
            this.txtBoxTotalUnitsUsed.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTotalUnitsUsed.TabIndex = 10;
            // 
            // txtBoxUnitCost
            // 
            this.txtBoxUnitCost.Location = new System.Drawing.Point(149, 376);
            this.txtBoxUnitCost.Name = "txtBoxUnitCost";
            this.txtBoxUnitCost.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUnitCost.TabIndex = 11;
            // 
            // lstBoxCustomerAccounts
            // 
            this.lstBoxCustomerAccounts.FormattingEnabled = true;
            this.lstBoxCustomerAccounts.Location = new System.Drawing.Point(276, 56);
            this.lstBoxCustomerAccounts.Name = "lstBoxCustomerAccounts";
            this.lstBoxCustomerAccounts.Size = new System.Drawing.Size(217, 290);
            this.lstBoxCustomerAccounts.TabIndex = 12;
            this.lstBoxCustomerAccounts.SelectedIndexChanged += new System.EventHandler(this.lstBoxCustomerAccounts_SelectedIndexChanged);
            // 
            // txtBoxRecordUnits
            // 
            this.txtBoxRecordUnits.Location = new System.Drawing.Point(652, 56);
            this.txtBoxRecordUnits.Name = "txtBoxRecordUnits";
            this.txtBoxRecordUnits.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRecordUnits.TabIndex = 13;
            // 
            // txtBoxPayment
            // 
            this.txtBoxPayment.Location = new System.Drawing.Point(652, 143);
            this.txtBoxPayment.Name = "txtBoxPayment";
            this.txtBoxPayment.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPayment.TabIndex = 14;
            // 
            // txtBoxSetUnits
            // 
            this.txtBoxSetUnits.Location = new System.Drawing.Point(652, 228);
            this.txtBoxSetUnits.Name = "txtBoxSetUnits";
            this.txtBoxSetUnits.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSetUnits.TabIndex = 15;
            // 
            // rdoByRef
            // 
            this.rdoByRef.AutoSize = true;
            this.rdoByRef.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoByRef.Location = new System.Drawing.Point(326, 415);
            this.rdoByRef.Name = "rdoByRef";
            this.rdoByRef.Size = new System.Drawing.Size(57, 17);
            this.rdoByRef.TabIndex = 21;
            this.rdoByRef.TabStop = true;
            this.rdoByRef.Text = "By Ref";
            this.rdoByRef.UseVisualStyleBackColor = true;
            // 
            // rdoByBalance
            // 
            this.rdoByBalance.AutoSize = true;
            this.rdoByBalance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoByBalance.Location = new System.Drawing.Point(400, 415);
            this.rdoByBalance.Name = "rdoByBalance";
            this.rdoByBalance.Size = new System.Drawing.Size(79, 17);
            this.rdoByBalance.TabIndex = 22;
            this.rdoByBalance.TabStop = true;
            this.rdoByBalance.Text = "By Balance";
            this.rdoByBalance.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(703, 409);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(594, 409);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRecordUnits
            // 
            this.btnRecordUnits.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnRecordUnits.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRecordUnits.Location = new System.Drawing.Point(535, 34);
            this.btnRecordUnits.Name = "btnRecordUnits";
            this.btnRecordUnits.Size = new System.Drawing.Size(75, 52);
            this.btnRecordUnits.TabIndex = 25;
            this.btnRecordUnits.Text = "Record Units";
            this.btnRecordUnits.UseVisualStyleBackColor = false;
            this.btnRecordUnits.Click += new System.EventHandler(this.btnRecordUnits_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnPayment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPayment.Location = new System.Drawing.Point(535, 134);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(75, 36);
            this.btnPayment.TabIndex = 26;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnSetUnits
            // 
            this.btnSetUnits.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSetUnits.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSetUnits.Location = new System.Drawing.Point(535, 225);
            this.btnSetUnits.Name = "btnSetUnits";
            this.btnSetUnits.Size = new System.Drawing.Size(75, 23);
            this.btnSetUnits.TabIndex = 27;
            this.btnSetUnits.Text = "Set Units";
            this.btnSetUnits.UseVisualStyleBackColor = false;
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSort.Location = new System.Drawing.Point(362, 373);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 28;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lblCustomerAccounts
            // 
            this.lblCustomerAccounts.AutoSize = true;
            this.lblCustomerAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAccounts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCustomerAccounts.Location = new System.Drawing.Point(323, 23);
            this.lblCustomerAccounts.Name = "lblCustomerAccounts";
            this.lblCustomerAccounts.Size = new System.Drawing.Size(139, 16);
            this.lblCustomerAccounts.TabIndex = 29;
            this.lblCustomerAccounts.Text = "Customer Accounts";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStatus.Location = new System.Drawing.Point(532, 333);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 30;
            this.lblStatus.Text = "Status";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCustomerAccounts);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnSetUnits);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnRecordUnits);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rdoByBalance);
            this.Controls.Add(this.rdoByRef);
            this.Controls.Add(this.txtBoxSetUnits);
            this.Controls.Add(this.txtBoxPayment);
            this.Controls.Add(this.txtBoxRecordUnits);
            this.Controls.Add(this.lstBoxCustomerAccounts);
            this.Controls.Add(this.txtBoxUnitCost);
            this.Controls.Add(this.txtBoxTotalUnitsUsed);
            this.Controls.Add(this.txtBoxAccBalance);
            this.Controls.Add(this.txtBoxAccAddress);
            this.Controls.Add(this.txtBoxAccName);
            this.Controls.Add(this.txtBoxAccRef);
            this.Controls.Add(this.lblUnitCost);
            this.Controls.Add(this.lblTotalUnitsUsed);
            this.Controls.Add(this.lblAccBalance);
            this.Controls.Add(this.lblAccAddress);
            this.Controls.Add(this.lblAccName);
            this.Controls.Add(this.lblAccRef);
            this.ForeColor = System.Drawing.Color.DeepPink;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccRef;
        private System.Windows.Forms.Label lblAccName;
        private System.Windows.Forms.Label lblAccAddress;
        private System.Windows.Forms.Label lblAccBalance;
        private System.Windows.Forms.Label lblTotalUnitsUsed;
        private System.Windows.Forms.Label lblUnitCost;
        private System.Windows.Forms.TextBox txtBoxAccRef;
        private System.Windows.Forms.TextBox txtBoxAccName;
        private System.Windows.Forms.TextBox txtBoxAccAddress;
        private System.Windows.Forms.TextBox txtBoxAccBalance;
        private System.Windows.Forms.TextBox txtBoxTotalUnitsUsed;
        private System.Windows.Forms.TextBox txtBoxUnitCost;
        private System.Windows.Forms.ListBox lstBoxCustomerAccounts;
        private System.Windows.Forms.TextBox txtBoxRecordUnits;
        private System.Windows.Forms.TextBox txtBoxPayment;
        private System.Windows.Forms.TextBox txtBoxSetUnits;
        private System.Windows.Forms.RadioButton rdoByRef;
        private System.Windows.Forms.RadioButton rdoByBalance;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRecordUnits;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnSetUnits;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lblCustomerAccounts;
        private System.Windows.Forms.Label lblStatus;
    }
}

