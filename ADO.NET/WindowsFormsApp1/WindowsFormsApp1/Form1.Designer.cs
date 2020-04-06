namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbDatSource = new System.Windows.Forms.TextBox();
            this.tbInitCat = new System.Windows.Forms.TextBox();
            this.tbRequest = new System.Windows.Forms.TextBox();
            this.labDataSourse = new System.Windows.Forms.Label();
            this.labInitCat = new System.Windows.Forms.Label();
            this.labSqlReq = new System.Windows.Forms.Label();
            this.DatGridDBTables = new System.Windows.Forms.DataGridView();
            this.datGridSQLResult = new System.Windows.Forms.DataGridView();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnRequest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatGridDBTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datGridSQLResult)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDatSource
            // 
            this.tbDatSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDatSource.BackColor = System.Drawing.Color.LightGray;
            this.tbDatSource.Font = new System.Drawing.Font("Arial Unicode MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDatSource.ForeColor = System.Drawing.Color.Black;
            this.tbDatSource.Location = new System.Drawing.Point(176, 46);
            this.tbDatSource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDatSource.Name = "tbDatSource";
            this.tbDatSource.Size = new System.Drawing.Size(299, 25);
            this.tbDatSource.TabIndex = 2;
            this.tbDatSource.Text = "localhost\\VSdotNET";
            // 
            // tbInitCat
            // 
            this.tbInitCat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInitCat.BackColor = System.Drawing.Color.LightGray;
            this.tbInitCat.Font = new System.Drawing.Font("Arial Unicode MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInitCat.ForeColor = System.Drawing.Color.Black;
            this.tbInitCat.Location = new System.Drawing.Point(176, 98);
            this.tbInitCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbInitCat.Name = "tbInitCat";
            this.tbInitCat.Size = new System.Drawing.Size(299, 25);
            this.tbInitCat.TabIndex = 3;
            this.tbInitCat.Text = "Initial Catalog: ";
            // 
            // tbRequest
            // 
            this.tbRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRequest.BackColor = System.Drawing.Color.LightGray;
            this.tbRequest.Enabled = false;
            this.tbRequest.Font = new System.Drawing.Font("Arial Unicode MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRequest.ForeColor = System.Drawing.Color.Black;
            this.tbRequest.Location = new System.Drawing.Point(176, 238);
            this.tbRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRequest.Name = "tbRequest";
            this.tbRequest.Size = new System.Drawing.Size(365, 25);
            this.tbRequest.TabIndex = 4;
            this.tbRequest.Text = "SELECT * FROM Table";
            // 
            // labDataSourse
            // 
            this.labDataSourse.AutoSize = true;
            this.labDataSourse.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labDataSourse.Location = new System.Drawing.Point(27, 46);
            this.labDataSourse.Name = "labDataSourse";
            this.labDataSourse.Size = new System.Drawing.Size(90, 24);
            this.labDataSourse.TabIndex = 5;
            this.labDataSourse.Text = "Data Source";
            this.labDataSourse.Click += new System.EventHandler(this.label1_Click);
            // 
            // labInitCat
            // 
            this.labInitCat.AutoSize = true;
            this.labInitCat.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labInitCat.Location = new System.Drawing.Point(27, 93);
            this.labInitCat.Name = "labInitCat";
            this.labInitCat.Size = new System.Drawing.Size(101, 24);
            this.labInitCat.TabIndex = 6;
            this.labInitCat.Text = "Initial Catalog";
            // 
            // labSqlReq
            // 
            this.labSqlReq.AutoSize = true;
            this.labSqlReq.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSqlReq.Location = new System.Drawing.Point(27, 236);
            this.labSqlReq.Name = "labSqlReq";
            this.labSqlReq.Size = new System.Drawing.Size(91, 24);
            this.labSqlReq.TabIndex = 7;
            this.labSqlReq.Text = "SQL Request";
            // 
            // DatGridDBTables
            // 
            this.DatGridDBTables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatGridDBTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatGridDBTables.Enabled = false;
            this.DatGridDBTables.Location = new System.Drawing.Point(29, 138);
            this.DatGridDBTables.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DatGridDBTables.Name = "DatGridDBTables";
            this.DatGridDBTables.ReadOnly = true;
            this.DatGridDBTables.RowHeadersWidth = 51;
            this.DatGridDBTables.RowTemplate.Height = 24;
            this.DatGridDBTables.Size = new System.Drawing.Size(657, 91);
            this.DatGridDBTables.TabIndex = 8;
            // 
            // datGridSQLResult
            // 
            this.datGridSQLResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datGridSQLResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datGridSQLResult.Enabled = false;
            this.datGridSQLResult.Location = new System.Drawing.Point(29, 288);
            this.datGridSQLResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datGridSQLResult.Name = "datGridSQLResult";
            this.datGridSQLResult.ReadOnly = true;
            this.datGridSQLResult.RowHeadersWidth = 51;
            this.datGridSQLResult.RowTemplate.Height = 24;
            this.datGridSQLResult.Size = new System.Drawing.Size(657, 141);
            this.datGridSQLResult.TabIndex = 9;
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(565, 95);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(121, 28);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect to DB";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRequest.Enabled = false;
            this.btnRequest.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.Location = new System.Drawing.Point(565, 235);
            this.btnRequest.Margin = new System.Windows.Forms.Padding(4);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(121, 28);
            this.btnRequest.TabIndex = 11;
            this.btnRequest.Text = "Send Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(723, 477);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.datGridSQLResult);
            this.Controls.Add(this.DatGridDBTables);
            this.Controls.Add(this.labSqlReq);
            this.Controls.Add(this.labInitCat);
            this.Controls.Add(this.labDataSourse);
            this.Controls.Add(this.tbRequest);
            this.Controls.Add(this.tbInitCat);
            this.Controls.Add(this.tbDatSource);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(299, 349);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Base Requests";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatGridDBTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datGridSQLResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.TextBox tbDatSource;
        private System.Windows.Forms.TextBox tbInitCat;
        private System.Windows.Forms.TextBox tbRequest;
        private System.Windows.Forms.Label labDataSourse;
        private System.Windows.Forms.Label labInitCat;
        private System.Windows.Forms.Label labSqlReq;
        private System.Windows.Forms.DataGridView DatGridDBTables;
        private System.Windows.Forms.DataGridView datGridSQLResult;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnRequest;
    }
}

