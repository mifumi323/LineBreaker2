namespace LineBreaker2
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblText = new System.Windows.Forms.Label();
            this.lblBreakCode = new System.Windows.Forms.Label();
            this.cmbBreakCode = new System.Windows.Forms.ComboBox();
            this.lblCharCode = new System.Windows.Forms.Label();
            this.cmbCharCode = new System.Windows.Forms.ComboBox();
            this.btnDo = new System.Windows.Forms.Button();
            this.cmbText = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblText, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBreakCode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbBreakCode, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCharCode, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbCharCode, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDo, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbText, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(283, 138);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblText.Location = new System.Drawing.Point(3, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(72, 26);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "削除対象(&T)";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBreakCode
            // 
            this.lblBreakCode.AutoSize = true;
            this.lblBreakCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBreakCode.Location = new System.Drawing.Point(3, 26);
            this.lblBreakCode.Name = "lblBreakCode";
            this.lblBreakCode.Size = new System.Drawing.Size(72, 26);
            this.lblBreakCode.TabIndex = 2;
            this.lblBreakCode.Text = "改行コード(&B)";
            this.lblBreakCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBreakCode
            // 
            this.cmbBreakCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbBreakCode.FormattingEnabled = true;
            this.cmbBreakCode.Location = new System.Drawing.Point(81, 29);
            this.cmbBreakCode.Name = "cmbBreakCode";
            this.cmbBreakCode.Size = new System.Drawing.Size(199, 20);
            this.cmbBreakCode.TabIndex = 3;
            // 
            // lblCharCode
            // 
            this.lblCharCode.AutoSize = true;
            this.lblCharCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCharCode.Location = new System.Drawing.Point(3, 52);
            this.lblCharCode.Name = "lblCharCode";
            this.lblCharCode.Size = new System.Drawing.Size(72, 26);
            this.lblCharCode.TabIndex = 4;
            this.lblCharCode.Text = "文字コード(&C)";
            this.lblCharCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCharCode
            // 
            this.cmbCharCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCharCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCharCode.FormattingEnabled = true;
            this.cmbCharCode.Location = new System.Drawing.Point(81, 55);
            this.cmbCharCode.Name = "cmbCharCode";
            this.cmbCharCode.Size = new System.Drawing.Size(199, 20);
            this.cmbCharCode.TabIndex = 5;
            // 
            // btnDo
            // 
            this.btnDo.AllowDrop = true;
            this.tableLayoutPanel1.SetColumnSpan(this.btnDo, 2);
            this.btnDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDo.Location = new System.Drawing.Point(3, 81);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(277, 54);
            this.btnDo.TabIndex = 6;
            this.btnDo.Text = "実行する(&D)";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            this.btnDo.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnDo_DragDrop);
            this.btnDo.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnDo_DragEnter);
            // 
            // cmbText
            // 
            this.cmbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbText.FormattingEnabled = true;
            this.cmbText.Location = new System.Drawing.Point(81, 3);
            this.cmbText.Name = "cmbText";
            this.cmbText.Size = new System.Drawing.Size(199, 20);
            this.cmbText.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 138);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormMain";
            this.Text = "LineBreaker2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblBreakCode;
        private System.Windows.Forms.ComboBox cmbBreakCode;
        private System.Windows.Forms.Label lblCharCode;
        private System.Windows.Forms.ComboBox cmbCharCode;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.ComboBox cmbText;
    }
}

