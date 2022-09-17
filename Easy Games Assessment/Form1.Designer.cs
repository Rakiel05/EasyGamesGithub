namespace Easy_Games_Assessment
{
    partial class EasyGames
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxClientName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBoxTransactionType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTransComment = new System.Windows.Forms.TextBox();
            this.txtCommentEdit = new System.Windows.Forms.TextBox();
            this.btnEditComment = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnOrderAmount = new System.Windows.Forms.Button();
            this.btnOrderTransType = new System.Windows.Forms.Button();
            this.btnOrderComment = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(324, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "EASY GAMES";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionID,
            this.Amount,
            this.TransactionTypeID,
            this.Comment,
            this.TransactionType});
            this.dataGridView1.Location = new System.Drawing.Point(372, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TransactionID
            // 
            this.TransactionID.HeaderText = "Transaction ID";
            this.TransactionID.Name = "TransactionID";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // TransactionTypeID
            // 
            this.TransactionTypeID.HeaderText = "Transaction Type ID";
            this.TransactionTypeID.Name = "TransactionTypeID";
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            // 
            // TransactionType
            // 
            this.TransactionType.HeaderText = "Transaction Type";
            this.TransactionType.Name = "TransactionType";
            // 
            // comboBoxClientName
            // 
            this.comboBoxClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.comboBoxClientName.FormattingEnabled = true;
            this.comboBoxClientName.Location = new System.Drawing.Point(88, 159);
            this.comboBoxClientName.Name = "comboBoxClientName";
            this.comboBoxClientName.Size = new System.Drawing.Size(121, 25);
            this.comboBoxClientName.TabIndex = 2;
            this.comboBoxClientName.SelectedIndexChanged += new System.EventHandler(this.comboBoxClientName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(53, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "ADD A TRANSACTION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(36, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Client Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(36, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Amount :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(36, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Transaction Type : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(36, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Comment : ";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(163, 292);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(121, 20);
            this.txtClientName.TabIndex = 8;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(163, 326);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(121, 20);
            this.txtAmount.TabIndex = 9;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(163, 394);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(121, 20);
            this.txtComment.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSave.ForeColor = System.Drawing.Color.Red;
            this.btnSave.Location = new System.Drawing.Point(134, 443);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBoxTransactionType
            // 
            this.comboBoxTransactionType.FormattingEnabled = true;
            this.comboBoxTransactionType.Location = new System.Drawing.Point(163, 364);
            this.comboBoxTransactionType.Name = "comboBoxTransactionType";
            this.comboBoxTransactionType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTransactionType.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(355, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Enter Transaction ID";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(355, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Enter Comment";
            // 
            // txtTransComment
            // 
            this.txtTransComment.Location = new System.Drawing.Point(535, 313);
            this.txtTransComment.Name = "txtTransComment";
            this.txtTransComment.Size = new System.Drawing.Size(100, 20);
            this.txtTransComment.TabIndex = 16;
            // 
            // txtCommentEdit
            // 
            this.txtCommentEdit.Location = new System.Drawing.Point(535, 349);
            this.txtCommentEdit.Name = "txtCommentEdit";
            this.txtCommentEdit.Size = new System.Drawing.Size(100, 20);
            this.txtCommentEdit.TabIndex = 17;
            // 
            // btnEditComment
            // 
            this.btnEditComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnEditComment.ForeColor = System.Drawing.Color.Red;
            this.btnEditComment.Location = new System.Drawing.Point(481, 388);
            this.btnEditComment.Name = "btnEditComment";
            this.btnEditComment.Size = new System.Drawing.Size(113, 23);
            this.btnEditComment.TabIndex = 18;
            this.btnEditComment.Text = "Edit Comment";
            this.btnEditComment.UseVisualStyleBackColor = true;
            this.btnEditComment.Click += new System.EventHandler(this.btnEditComment_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(674, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Choose Filter Option";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(674, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Enter Filter Value";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(817, 349);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(100, 20);
            this.txtFilterValue.TabIndex = 22;
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(817, 313);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(100, 21);
            this.comboBoxFilter.TabIndex = 23;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnFilter.ForeColor = System.Drawing.Color.Red;
            this.btnFilter.Location = new System.Drawing.Point(771, 388);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(79, 23);
            this.btnFilter.TabIndex = 24;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnOrderAmount
            // 
            this.btnOrderAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnOrderAmount.ForeColor = System.Drawing.Color.Red;
            this.btnOrderAmount.Location = new System.Drawing.Point(480, 448);
            this.btnOrderAmount.Name = "btnOrderAmount";
            this.btnOrderAmount.Size = new System.Drawing.Size(130, 23);
            this.btnOrderAmount.TabIndex = 25;
            this.btnOrderAmount.Text = "Order By Amount";
            this.btnOrderAmount.UseVisualStyleBackColor = true;
            this.btnOrderAmount.Click += new System.EventHandler(this.btnOrderAmount_Click);
            // 
            // btnOrderTransType
            // 
            this.btnOrderTransType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnOrderTransType.ForeColor = System.Drawing.Color.Red;
            this.btnOrderTransType.Location = new System.Drawing.Point(585, 500);
            this.btnOrderTransType.Name = "btnOrderTransType";
            this.btnOrderTransType.Size = new System.Drawing.Size(159, 23);
            this.btnOrderTransType.TabIndex = 26;
            this.btnOrderTransType.Text = "Order By Transaction Type";
            this.btnOrderTransType.UseVisualStyleBackColor = true;
            this.btnOrderTransType.Click += new System.EventHandler(this.btnOrderTransType_Click);
            // 
            // btnOrderComment
            // 
            this.btnOrderComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnOrderComment.ForeColor = System.Drawing.Color.Red;
            this.btnOrderComment.Location = new System.Drawing.Point(736, 448);
            this.btnOrderComment.Name = "btnOrderComment";
            this.btnOrderComment.Size = new System.Drawing.Size(142, 23);
            this.btnOrderComment.TabIndex = 27;
            this.btnOrderComment.Text = "Order By Comment";
            this.btnOrderComment.UseVisualStyleBackColor = true;
            this.btnOrderComment.Click += new System.EventHandler(this.btnOrderComment_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label11.Location = new System.Drawing.Point(66, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "CLIENT NAMES";
            // 
            // EasyGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(927, 535);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnOrderComment);
            this.Controls.Add(this.btnOrderTransType);
            this.Controls.Add(this.btnOrderAmount);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEditComment);
            this.Controls.Add(this.txtCommentEdit);
            this.Controls.Add(this.txtTransComment);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxTransactionType);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxClientName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "EasyGames";
            this.Text = "EasyGames";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxClientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboBoxTransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTransComment;
        private System.Windows.Forms.TextBox txtCommentEdit;
        private System.Windows.Forms.Button btnEditComment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnOrderAmount;
        private System.Windows.Forms.Button btnOrderTransType;
        private System.Windows.Forms.Button btnOrderComment;
        private System.Windows.Forms.Label label11;
    }
}

