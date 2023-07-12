namespace Caja_Sistema_bancario
{
    partial class Historial_de__transacciones
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
            this.button9 = new System.Windows.Forms.Button();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Caja_Sistema_bancario.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Caja_Sistema_bancario.DataSet1TableAdapters.usersTableAdapter();
            this.transactionsTableAdapter = new Caja_Sistema_bancario.DataSet1TableAdapters.transactionsTableAdapter();
            this.gettransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gettransactionsTableAdapter = new Caja_Sistema_bancario.DataSet1TableAdapters.gettransactionsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gettransactionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payerAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payerIdentificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payeeAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payeeIdentificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payeeBankIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conceptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effectiveDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payerBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payeeBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payeeProductNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payeeProductTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gettransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gettransactionsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(353, 442);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(131, 50);
            this.button9.TabIndex = 10;
            this.button9.Text = "Cerrar";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "transactions";
            this.transactionsBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // transactionsBindingSource1
            // 
            this.transactionsBindingSource1.DataMember = "transactions";
            this.transactionsBindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // transactionsTableAdapter
            // 
            this.transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // gettransactionsBindingSource
            // 
            this.gettransactionsBindingSource.DataMember = "gettransactions";
            this.gettransactionsBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // gettransactionsTableAdapter
            // 
            this.gettransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.payerIdDataGridViewTextBoxColumn,
            this.payerAccountDataGridViewTextBoxColumn,
            this.payerIdentificationDataGridViewTextBoxColumn,
            this.payeeIdDataGridViewTextBoxColumn,
            this.payeeAccountDataGridViewTextBoxColumn,
            this.payeeIdentificationDataGridViewTextBoxColumn,
            this.payeeBankIdDataGridViewTextBoxColumn,
            this.transactionTypeIdDataGridViewTextBoxColumn,
            this.creationDateDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.conceptDataGridViewTextBoxColumn,
            this.debitDataGridViewTextBoxColumn,
            this.creditDataGridViewTextBoxColumn,
            this.currencyTypeIdDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.referenceNumberDataGridViewTextBoxColumn,
            this.effectiveDateDataGridViewTextBoxColumn,
            this.statusIdDataGridViewTextBoxColumn,
            this.payerBalanceDataGridViewTextBoxColumn,
            this.payeeBalanceDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.payeeProductNumberDataGridViewTextBoxColumn,
            this.payeeProductTypeIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gettransactionsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(63, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(705, 360);
            this.dataGridView1.TabIndex = 11;
            // 
            // gettransactionsBindingSource1
            // 
            this.gettransactionsBindingSource1.DataMember = "gettransactions";
            this.gettransactionsBindingSource1.DataSource = this.dataSet1BindingSource;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // payerIdDataGridViewTextBoxColumn
            // 
            this.payerIdDataGridViewTextBoxColumn.DataPropertyName = "PayerId";
            this.payerIdDataGridViewTextBoxColumn.HeaderText = "PayerId";
            this.payerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payerIdDataGridViewTextBoxColumn.Name = "payerIdDataGridViewTextBoxColumn";
            this.payerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.payerIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // payerAccountDataGridViewTextBoxColumn
            // 
            this.payerAccountDataGridViewTextBoxColumn.DataPropertyName = "PayerAccount";
            this.payerAccountDataGridViewTextBoxColumn.HeaderText = "PayerAccount";
            this.payerAccountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payerAccountDataGridViewTextBoxColumn.Name = "payerAccountDataGridViewTextBoxColumn";
            this.payerAccountDataGridViewTextBoxColumn.ReadOnly = true;
            this.payerAccountDataGridViewTextBoxColumn.Width = 125;
            // 
            // payerIdentificationDataGridViewTextBoxColumn
            // 
            this.payerIdentificationDataGridViewTextBoxColumn.DataPropertyName = "PayerIdentification";
            this.payerIdentificationDataGridViewTextBoxColumn.HeaderText = "PayerIdentification";
            this.payerIdentificationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payerIdentificationDataGridViewTextBoxColumn.Name = "payerIdentificationDataGridViewTextBoxColumn";
            this.payerIdentificationDataGridViewTextBoxColumn.ReadOnly = true;
            this.payerIdentificationDataGridViewTextBoxColumn.Width = 125;
            // 
            // payeeIdDataGridViewTextBoxColumn
            // 
            this.payeeIdDataGridViewTextBoxColumn.DataPropertyName = "PayeeId";
            this.payeeIdDataGridViewTextBoxColumn.HeaderText = "PayeeId";
            this.payeeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payeeIdDataGridViewTextBoxColumn.Name = "payeeIdDataGridViewTextBoxColumn";
            this.payeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.payeeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // payeeAccountDataGridViewTextBoxColumn
            // 
            this.payeeAccountDataGridViewTextBoxColumn.DataPropertyName = "PayeeAccount";
            this.payeeAccountDataGridViewTextBoxColumn.HeaderText = "PayeeAccount";
            this.payeeAccountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payeeAccountDataGridViewTextBoxColumn.Name = "payeeAccountDataGridViewTextBoxColumn";
            this.payeeAccountDataGridViewTextBoxColumn.ReadOnly = true;
            this.payeeAccountDataGridViewTextBoxColumn.Width = 125;
            // 
            // payeeIdentificationDataGridViewTextBoxColumn
            // 
            this.payeeIdentificationDataGridViewTextBoxColumn.DataPropertyName = "PayeeIdentification";
            this.payeeIdentificationDataGridViewTextBoxColumn.HeaderText = "PayeeIdentification";
            this.payeeIdentificationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payeeIdentificationDataGridViewTextBoxColumn.Name = "payeeIdentificationDataGridViewTextBoxColumn";
            this.payeeIdentificationDataGridViewTextBoxColumn.ReadOnly = true;
            this.payeeIdentificationDataGridViewTextBoxColumn.Width = 125;
            // 
            // payeeBankIdDataGridViewTextBoxColumn
            // 
            this.payeeBankIdDataGridViewTextBoxColumn.DataPropertyName = "PayeeBankId";
            this.payeeBankIdDataGridViewTextBoxColumn.HeaderText = "PayeeBankId";
            this.payeeBankIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payeeBankIdDataGridViewTextBoxColumn.Name = "payeeBankIdDataGridViewTextBoxColumn";
            this.payeeBankIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.payeeBankIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // transactionTypeIdDataGridViewTextBoxColumn
            // 
            this.transactionTypeIdDataGridViewTextBoxColumn.DataPropertyName = "TransactionTypeId";
            this.transactionTypeIdDataGridViewTextBoxColumn.HeaderText = "TransactionTypeId";
            this.transactionTypeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transactionTypeIdDataGridViewTextBoxColumn.Name = "transactionTypeIdDataGridViewTextBoxColumn";
            this.transactionTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.transactionTypeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // creationDateDataGridViewTextBoxColumn
            // 
            this.creationDateDataGridViewTextBoxColumn.DataPropertyName = "CreationDate";
            this.creationDateDataGridViewTextBoxColumn.HeaderText = "CreationDate";
            this.creationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.creationDateDataGridViewTextBoxColumn.Name = "creationDateDataGridViewTextBoxColumn";
            this.creationDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.creationDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn.Width = 125;
            // 
            // conceptDataGridViewTextBoxColumn
            // 
            this.conceptDataGridViewTextBoxColumn.DataPropertyName = "Concept";
            this.conceptDataGridViewTextBoxColumn.HeaderText = "Concept";
            this.conceptDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.conceptDataGridViewTextBoxColumn.Name = "conceptDataGridViewTextBoxColumn";
            this.conceptDataGridViewTextBoxColumn.ReadOnly = true;
            this.conceptDataGridViewTextBoxColumn.Width = 125;
            // 
            // debitDataGridViewTextBoxColumn
            // 
            this.debitDataGridViewTextBoxColumn.DataPropertyName = "Debit";
            this.debitDataGridViewTextBoxColumn.HeaderText = "Debit";
            this.debitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.debitDataGridViewTextBoxColumn.Name = "debitDataGridViewTextBoxColumn";
            this.debitDataGridViewTextBoxColumn.ReadOnly = true;
            this.debitDataGridViewTextBoxColumn.Width = 125;
            // 
            // creditDataGridViewTextBoxColumn
            // 
            this.creditDataGridViewTextBoxColumn.DataPropertyName = "Credit";
            this.creditDataGridViewTextBoxColumn.HeaderText = "Credit";
            this.creditDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.creditDataGridViewTextBoxColumn.Name = "creditDataGridViewTextBoxColumn";
            this.creditDataGridViewTextBoxColumn.ReadOnly = true;
            this.creditDataGridViewTextBoxColumn.Width = 125;
            // 
            // currencyTypeIdDataGridViewTextBoxColumn
            // 
            this.currencyTypeIdDataGridViewTextBoxColumn.DataPropertyName = "CurrencyTypeId";
            this.currencyTypeIdDataGridViewTextBoxColumn.HeaderText = "CurrencyTypeId";
            this.currencyTypeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currencyTypeIdDataGridViewTextBoxColumn.Name = "currencyTypeIdDataGridViewTextBoxColumn";
            this.currencyTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.currencyTypeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.balanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // referenceNumberDataGridViewTextBoxColumn
            // 
            this.referenceNumberDataGridViewTextBoxColumn.DataPropertyName = "ReferenceNumber";
            this.referenceNumberDataGridViewTextBoxColumn.HeaderText = "ReferenceNumber";
            this.referenceNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.referenceNumberDataGridViewTextBoxColumn.Name = "referenceNumberDataGridViewTextBoxColumn";
            this.referenceNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.referenceNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // effectiveDateDataGridViewTextBoxColumn
            // 
            this.effectiveDateDataGridViewTextBoxColumn.DataPropertyName = "EffectiveDate";
            this.effectiveDateDataGridViewTextBoxColumn.HeaderText = "EffectiveDate";
            this.effectiveDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.effectiveDateDataGridViewTextBoxColumn.Name = "effectiveDateDataGridViewTextBoxColumn";
            this.effectiveDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.effectiveDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusIdDataGridViewTextBoxColumn
            // 
            this.statusIdDataGridViewTextBoxColumn.DataPropertyName = "StatusId";
            this.statusIdDataGridViewTextBoxColumn.HeaderText = "StatusId";
            this.statusIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusIdDataGridViewTextBoxColumn.Name = "statusIdDataGridViewTextBoxColumn";
            this.statusIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // payerBalanceDataGridViewTextBoxColumn
            // 
            this.payerBalanceDataGridViewTextBoxColumn.DataPropertyName = "PayerBalance";
            this.payerBalanceDataGridViewTextBoxColumn.HeaderText = "PayerBalance";
            this.payerBalanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payerBalanceDataGridViewTextBoxColumn.Name = "payerBalanceDataGridViewTextBoxColumn";
            this.payerBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.payerBalanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // payeeBalanceDataGridViewTextBoxColumn
            // 
            this.payeeBalanceDataGridViewTextBoxColumn.DataPropertyName = "PayeeBalance";
            this.payeeBalanceDataGridViewTextBoxColumn.HeaderText = "PayeeBalance";
            this.payeeBalanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payeeBalanceDataGridViewTextBoxColumn.Name = "payeeBalanceDataGridViewTextBoxColumn";
            this.payeeBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.payeeBalanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // payeeProductNumberDataGridViewTextBoxColumn
            // 
            this.payeeProductNumberDataGridViewTextBoxColumn.DataPropertyName = "PayeeProductNumber";
            this.payeeProductNumberDataGridViewTextBoxColumn.HeaderText = "PayeeProductNumber";
            this.payeeProductNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payeeProductNumberDataGridViewTextBoxColumn.Name = "payeeProductNumberDataGridViewTextBoxColumn";
            this.payeeProductNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.payeeProductNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // payeeProductTypeIdDataGridViewTextBoxColumn
            // 
            this.payeeProductTypeIdDataGridViewTextBoxColumn.DataPropertyName = "PayeeProductTypeId";
            this.payeeProductTypeIdDataGridViewTextBoxColumn.HeaderText = "PayeeProductTypeId";
            this.payeeProductTypeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payeeProductTypeIdDataGridViewTextBoxColumn.Name = "payeeProductTypeIdDataGridViewTextBoxColumn";
            this.payeeProductTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.payeeProductTypeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // Historial_de__transacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 498);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button9);
            this.Name = "Historial_de__transacciones";
            this.Text = "Historial_de__transacciones";
            this.Load += new System.EventHandler(this.Historial_de__transacciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gettransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gettransactionsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DataSet1TableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private DataSet1TableAdapters.transactionsTableAdapter transactionsTableAdapter;
        private System.Windows.Forms.BindingSource transactionsBindingSource1;
        private System.Windows.Forms.BindingSource gettransactionsBindingSource;
        private DataSet1TableAdapters.gettransactionsTableAdapter gettransactionsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payerAccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payerIdentificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payeeAccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payeeIdentificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payeeBankIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conceptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn effectiveDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payerBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payeeBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payeeProductNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payeeProductTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gettransactionsBindingSource1;
    }
}