namespace UnifiedCSPROJOutputPath.Views
{
    partial class TestUnifiedCSPROJOutputPathUserControl
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TableLayoutPanel_1 = new System.Windows.Forms.TableLayoutPanel();
            this.BakToCSPROJ_Button_1 = new System.Windows.Forms.Button();
            this.DelBak_Button_1 = new System.Windows.Forms.Button();
            this.Search_Folder_Label_1 = new System.Windows.Forms.Label();
            this.OuputFolder_TextBox_1 = new System.Windows.Forms.TextBox();
            this.OuputFolder_Label_1 = new System.Windows.Forms.Label();
            this.DES_Folder_Label_1 = new System.Windows.Forms.Label();
            this.DES_Folder_TextBox_1 = new System.Windows.Forms.TextBox();
            this.DES_Folder_Button_1 = new System.Windows.Forms.Button();
            this.Search_Folder_Button_1 = new System.Windows.Forms.Button();
            this.Search_Folder_TextBox_1 = new System.Windows.Forms.TextBox();
            this.Execute_Button_1 = new System.Windows.Forms.Button();
            this.TableLayoutPanel_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel_1
            // 
            this.TableLayoutPanel_1.ColumnCount = 3;
            this.TableLayoutPanel_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel_1.Controls.Add(this.BakToCSPROJ_Button_1, 0, 3);
            this.TableLayoutPanel_1.Controls.Add(this.DelBak_Button_1, 0, 3);
            this.TableLayoutPanel_1.Controls.Add(this.Search_Folder_Label_1, 0, 0);
            this.TableLayoutPanel_1.Controls.Add(this.OuputFolder_TextBox_1, 1, 2);
            this.TableLayoutPanel_1.Controls.Add(this.OuputFolder_Label_1, 0, 2);
            this.TableLayoutPanel_1.Controls.Add(this.DES_Folder_Label_1, 0, 1);
            this.TableLayoutPanel_1.Controls.Add(this.DES_Folder_TextBox_1, 1, 1);
            this.TableLayoutPanel_1.Controls.Add(this.DES_Folder_Button_1, 2, 1);
            this.TableLayoutPanel_1.Controls.Add(this.Search_Folder_Button_1, 2, 0);
            this.TableLayoutPanel_1.Controls.Add(this.Search_Folder_TextBox_1, 1, 0);
            this.TableLayoutPanel_1.Controls.Add(this.Execute_Button_1, 0, 3);
            this.TableLayoutPanel_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel_1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel_1.Name = "TableLayoutPanel_1";
            this.TableLayoutPanel_1.RowCount = 4;
            this.TableLayoutPanel_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel_1.Size = new System.Drawing.Size(323, 197);
            this.TableLayoutPanel_1.TabIndex = 0;
            // 
            // BakToCSPROJ_Button_1
            // 
            this.BakToCSPROJ_Button_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BakToCSPROJ_Button_1.Location = new System.Drawing.Point(224, 154);
            this.BakToCSPROJ_Button_1.Name = "BakToCSPROJ_Button_1";
            this.BakToCSPROJ_Button_1.Size = new System.Drawing.Size(89, 36);
            this.BakToCSPROJ_Button_1.TabIndex = 10;
            this.BakToCSPROJ_Button_1.Text = "Restore .bak To .csproj";
            this.BakToCSPROJ_Button_1.UseVisualStyleBackColor = true;
            this.BakToCSPROJ_Button_1.Click += new System.EventHandler(this.BakToCSPROJ_Button_1_Click);
            // 
            // DelBak_Button_1
            // 
            this.DelBak_Button_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DelBak_Button_1.Location = new System.Drawing.Point(123, 161);
            this.DelBak_Button_1.Name = "DelBak_Button_1";
            this.DelBak_Button_1.Size = new System.Drawing.Size(75, 21);
            this.DelBak_Button_1.TabIndex = 9;
            this.DelBak_Button_1.Text = "del .bak";
            this.DelBak_Button_1.UseVisualStyleBackColor = true;
            this.DelBak_Button_1.Click += new System.EventHandler(this.DelBak_Button_1_Click);
            // 
            // Search_Folder_Label_1
            // 
            this.Search_Folder_Label_1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Search_Folder_Label_1.AutoSize = true;
            this.Search_Folder_Label_1.Location = new System.Drawing.Point(69, 18);
            this.Search_Folder_Label_1.Name = "Search_Folder_Label_1";
            this.Search_Folder_Label_1.Size = new System.Drawing.Size(35, 12);
            this.Search_Folder_Label_1.TabIndex = 8;
            this.Search_Folder_Label_1.Text = "Folder";
            this.Search_Folder_Label_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OuputFolder_TextBox_1
            // 
            this.OuputFolder_TextBox_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OuputFolder_TextBox_1.Location = new System.Drawing.Point(110, 111);
            this.OuputFolder_TextBox_1.Name = "OuputFolder_TextBox_1";
            this.OuputFolder_TextBox_1.Size = new System.Drawing.Size(101, 22);
            this.OuputFolder_TextBox_1.TabIndex = 4;
            this.OuputFolder_TextBox_1.Text = "outputExe";
            // 
            // OuputFolder_Label_1
            // 
            this.OuputFolder_Label_1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OuputFolder_Label_1.AutoSize = true;
            this.OuputFolder_Label_1.Location = new System.Drawing.Point(40, 116);
            this.OuputFolder_Label_1.Name = "OuputFolder_Label_1";
            this.OuputFolder_Label_1.Size = new System.Drawing.Size(64, 12);
            this.OuputFolder_Label_1.TabIndex = 1;
            this.OuputFolder_Label_1.Text = "OuputFolder";
            this.OuputFolder_Label_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DES_Folder_Label_1
            // 
            this.DES_Folder_Label_1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DES_Folder_Label_1.AutoSize = true;
            this.DES_Folder_Label_1.Location = new System.Drawing.Point(45, 67);
            this.DES_Folder_Label_1.Name = "DES_Folder_Label_1";
            this.DES_Folder_Label_1.Size = new System.Drawing.Size(59, 12);
            this.DES_Folder_Label_1.TabIndex = 0;
            this.DES_Folder_Label_1.Text = "DES Folder";
            this.DES_Folder_Label_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DES_Folder_TextBox_1
            // 
            this.DES_Folder_TextBox_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DES_Folder_TextBox_1.Location = new System.Drawing.Point(110, 62);
            this.DES_Folder_TextBox_1.Name = "DES_Folder_TextBox_1";
            this.DES_Folder_TextBox_1.Size = new System.Drawing.Size(101, 22);
            this.DES_Folder_TextBox_1.TabIndex = 3;
            this.DES_Folder_TextBox_1.Text = "D:\\GoogleDrive\\projects\\";
            // 
            // DES_Folder_Button_1
            // 
            this.DES_Folder_Button_1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DES_Folder_Button_1.Location = new System.Drawing.Point(217, 63);
            this.DES_Folder_Button_1.Name = "DES_Folder_Button_1";
            this.DES_Folder_Button_1.Size = new System.Drawing.Size(75, 21);
            this.DES_Folder_Button_1.TabIndex = 2;
            this.DES_Folder_Button_1.Text = "Folder";
            this.DES_Folder_Button_1.UseVisualStyleBackColor = true;
            this.DES_Folder_Button_1.Click += new System.EventHandler(this.DES_Folder_Button_1_Click);
            // 
            // Search_Folder_Button_1
            // 
            this.Search_Folder_Button_1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Search_Folder_Button_1.Location = new System.Drawing.Point(217, 14);
            this.Search_Folder_Button_1.Name = "Search_Folder_Button_1";
            this.Search_Folder_Button_1.Size = new System.Drawing.Size(75, 21);
            this.Search_Folder_Button_1.TabIndex = 6;
            this.Search_Folder_Button_1.Text = "Folder";
            this.Search_Folder_Button_1.UseVisualStyleBackColor = true;
            this.Search_Folder_Button_1.Click += new System.EventHandler(this.Search_Folder_Button_1_Click);
            // 
            // Search_Folder_TextBox_1
            // 
            this.Search_Folder_TextBox_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_Folder_TextBox_1.Location = new System.Drawing.Point(110, 13);
            this.Search_Folder_TextBox_1.Name = "Search_Folder_TextBox_1";
            this.Search_Folder_TextBox_1.Size = new System.Drawing.Size(101, 22);
            this.Search_Folder_TextBox_1.TabIndex = 7;
            this.Search_Folder_TextBox_1.Text = "D:\\GoogleDrive\\projects\\Work-CSUN\\DI\\";
            // 
            // Execute_Button_1
            // 
            this.Execute_Button_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Execute_Button_1.Location = new System.Drawing.Point(16, 161);
            this.Execute_Button_1.Name = "Execute_Button_1";
            this.Execute_Button_1.Size = new System.Drawing.Size(75, 21);
            this.Execute_Button_1.TabIndex = 5;
            this.Execute_Button_1.Text = "Execute";
            this.Execute_Button_1.UseVisualStyleBackColor = true;
            this.Execute_Button_1.Click += new System.EventHandler(this.Execute_Button_1_Click);
            // 
            // TestUnifiedCSPROJOutputPathUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TableLayoutPanel_1);
            this.Name = "TestUnifiedCSPROJOutputPathUserControl";
            this.Size = new System.Drawing.Size(323, 197);
            this.TableLayoutPanel_1.ResumeLayout(false);
            this.TableLayoutPanel_1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel_1;
        private System.Windows.Forms.Label DES_Folder_Label_1;
        private System.Windows.Forms.Label OuputFolder_Label_1;
        private System.Windows.Forms.Button DES_Folder_Button_1;
        private System.Windows.Forms.TextBox DES_Folder_TextBox_1;
        private System.Windows.Forms.TextBox OuputFolder_TextBox_1;
        private System.Windows.Forms.Button Execute_Button_1;
        private System.Windows.Forms.Label Search_Folder_Label_1;
        private System.Windows.Forms.Button Search_Folder_Button_1;
        private System.Windows.Forms.TextBox Search_Folder_TextBox_1;
        private System.Windows.Forms.Button DelBak_Button_1;
        private System.Windows.Forms.Button BakToCSPROJ_Button_1;
    }
}
