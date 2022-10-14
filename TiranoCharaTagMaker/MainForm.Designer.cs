
namespace TiranoCharaTagMaker
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxTargetDir = new System.Windows.Forms.TextBox();
            this.buttonrefer = new System.Windows.Forms.Button();
            this.listBoxParts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGenerateDefine = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.comboBoxTargetDirectory = new System.Windows.Forms.ComboBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGenerateTestTag = new System.Windows.Forms.Button();
            this.listBoxCommonparts = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxPartsParents = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxPartsChildren = new System.Windows.Forms.ComboBox();
            this.listBoxPartsCollection = new System.Windows.Forms.ListBox();
            this.buttonAddMacroParts = new System.Windows.Forms.Button();
            this.buttonGenerateImgMacro = new System.Windows.Forms.Button();
            this.textBoxMacroId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.buttonDeletePartsSelect = new System.Windows.Forms.Button();
            this.buttonDeleteAllParts = new System.Windows.Forms.Button();
            this.groupbox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTargetDir
            // 
            this.textBoxTargetDir.Location = new System.Drawing.Point(21, 30);
            this.textBoxTargetDir.Name = "textBoxTargetDir";
            this.textBoxTargetDir.Size = new System.Drawing.Size(267, 19);
            this.textBoxTargetDir.TabIndex = 0;
            // 
            // buttonrefer
            // 
            this.buttonrefer.Location = new System.Drawing.Point(304, 28);
            this.buttonrefer.Name = "buttonrefer";
            this.buttonrefer.Size = new System.Drawing.Size(75, 23);
            this.buttonrefer.TabIndex = 1;
            this.buttonrefer.Text = "参照";
            this.buttonrefer.UseVisualStyleBackColor = true;
            this.buttonrefer.Click += new System.EventHandler(this.buttonrefer_Click);
            // 
            // listBoxParts
            // 
            this.listBoxParts.FormattingEnabled = true;
            this.listBoxParts.ItemHeight = 12;
            this.listBoxParts.Location = new System.Drawing.Point(18, 34);
            this.listBoxParts.Name = "listBoxParts";
            this.listBoxParts.Size = new System.Drawing.Size(120, 112);
            this.listBoxParts.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "フォルダ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "パーツ(ZIndex順、下が上のパーツ)";
            // 
            // buttonGenerateDefine
            // 
            this.buttonGenerateDefine.Location = new System.Drawing.Point(149, 34);
            this.buttonGenerateDefine.Name = "buttonGenerateDefine";
            this.buttonGenerateDefine.Size = new System.Drawing.Size(216, 31);
            this.buttonGenerateDefine.TabIndex = 5;
            this.buttonGenerateDefine.Text = "定義用タグ生成";
            this.buttonGenerateDefine.UseVisualStyleBackColor = true;
            this.buttonGenerateDefine.Click += new System.EventHandler(this.buttonGenerateDefine_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(17, 353);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(408, 183);
            this.textBoxOutput.TabIndex = 6;
            // 
            // comboBoxTargetDirectory
            // 
            this.comboBoxTargetDirectory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTargetDirectory.FormattingEnabled = true;
            this.comboBoxTargetDirectory.Location = new System.Drawing.Point(21, 77);
            this.comboBoxTargetDirectory.Name = "comboBoxTargetDirectory";
            this.comboBoxTargetDirectory.Size = new System.Drawing.Size(121, 20);
            this.comboBoxTargetDirectory.TabIndex = 7;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(148, 75);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 8;
            this.buttonRefresh.Text = "更新";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "定義名";
            // 
            // buttonGenerateTestTag
            // 
            this.buttonGenerateTestTag.Location = new System.Drawing.Point(149, 71);
            this.buttonGenerateTestTag.Name = "buttonGenerateTestTag";
            this.buttonGenerateTestTag.Size = new System.Drawing.Size(216, 31);
            this.buttonGenerateTestTag.TabIndex = 10;
            this.buttonGenerateTestTag.Text = "テスト用タグ生成";
            this.buttonGenerateTestTag.UseVisualStyleBackColor = true;
            this.buttonGenerateTestTag.Click += new System.EventHandler(this.buttonGenerateTestTag_Click);
            // 
            // listBoxCommonparts
            // 
            this.listBoxCommonparts.FormattingEnabled = true;
            this.listBoxCommonparts.ItemHeight = 12;
            this.listBoxCommonparts.Items.AddRange(new object[] {
            "back"});
            this.listBoxCommonparts.Location = new System.Drawing.Point(18, 170);
            this.listBoxCommonparts.Name = "listBoxCommonparts";
            this.listBoxCommonparts.Size = new System.Drawing.Size(120, 28);
            this.listBoxCommonparts.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "共通パーツ";
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.listBoxParts);
            this.groupbox1.Controls.Add(this.label4);
            this.groupbox1.Controls.Add(this.label2);
            this.groupbox1.Controls.Add(this.listBoxCommonparts);
            this.groupbox1.Controls.Add(this.buttonGenerateDefine);
            this.groupbox1.Controls.Add(this.buttonGenerateTestTag);
            this.groupbox1.Location = new System.Drawing.Point(22, 114);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(403, 211);
            this.groupbox1.TabIndex = 13;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "詳細";
            // 
            // comboBoxPartsParents
            // 
            this.comboBoxPartsParents.FormattingEnabled = true;
            this.comboBoxPartsParents.Location = new System.Drawing.Point(25, 247);
            this.comboBoxPartsParents.Name = "comboBoxPartsParents";
            this.comboBoxPartsParents.Size = new System.Drawing.Size(121, 20);
            this.comboBoxPartsParents.TabIndex = 14;
            this.comboBoxPartsParents.SelectedIndexChanged += new System.EventHandler(this.comboBoxPartsParents_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "の";
            // 
            // comboBoxPartsChildren
            // 
            this.comboBoxPartsChildren.FormattingEnabled = true;
            this.comboBoxPartsChildren.Items.AddRange(new object[] {
            "eyebrow",
            "eye",
            "mouth"});
            this.comboBoxPartsChildren.Location = new System.Drawing.Point(174, 246);
            this.comboBoxPartsChildren.Name = "comboBoxPartsChildren";
            this.comboBoxPartsChildren.Size = new System.Drawing.Size(50, 20);
            this.comboBoxPartsChildren.TabIndex = 16;
            // 
            // listBoxPartsCollection
            // 
            this.listBoxPartsCollection.FormattingEnabled = true;
            this.listBoxPartsCollection.ItemHeight = 12;
            this.listBoxPartsCollection.Location = new System.Drawing.Point(25, 284);
            this.listBoxPartsCollection.Name = "listBoxPartsCollection";
            this.listBoxPartsCollection.Size = new System.Drawing.Size(291, 88);
            this.listBoxPartsCollection.TabIndex = 18;
            // 
            // buttonAddMacroParts
            // 
            this.buttonAddMacroParts.Location = new System.Drawing.Point(231, 245);
            this.buttonAddMacroParts.Name = "buttonAddMacroParts";
            this.buttonAddMacroParts.Size = new System.Drawing.Size(75, 23);
            this.buttonAddMacroParts.TabIndex = 19;
            this.buttonAddMacroParts.Text = "追加";
            this.buttonAddMacroParts.UseVisualStyleBackColor = true;
            this.buttonAddMacroParts.Click += new System.EventHandler(this.buttonAddMacroParts_Click);
            // 
            // buttonGenerateImgMacro
            // 
            this.buttonGenerateImgMacro.Location = new System.Drawing.Point(206, 428);
            this.buttonGenerateImgMacro.Name = "buttonGenerateImgMacro";
            this.buttonGenerateImgMacro.Size = new System.Drawing.Size(114, 35);
            this.buttonGenerateImgMacro.TabIndex = 20;
            this.buttonGenerateImgMacro.Text = "マクロ生成";
            this.buttonGenerateImgMacro.UseVisualStyleBackColor = true;
            this.buttonGenerateImgMacro.Click += new System.EventHandler(this.buttonGenerateImgMacro_Click);
            // 
            // textBoxMacroId
            // 
            this.textBoxMacroId.Location = new System.Drawing.Point(100, 436);
            this.textBoxMacroId.Name = "textBoxMacroId";
            this.textBoxMacroId.Size = new System.Drawing.Size(100, 19);
            this.textBoxMacroId.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "マクロ定義名";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDeleteAllParts);
            this.groupBox2.Controls.Add(this.pictureBoxImage);
            this.groupBox2.Controls.Add(this.buttonDeletePartsSelect);
            this.groupBox2.Controls.Add(this.comboBoxPartsParents);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxMacroId);
            this.groupBox2.Controls.Add(this.comboBoxPartsChildren);
            this.groupBox2.Controls.Add(this.buttonGenerateImgMacro);
            this.groupBox2.Controls.Add(this.listBoxPartsCollection);
            this.groupBox2.Controls.Add(this.buttonAddMacroParts);
            this.groupBox2.Location = new System.Drawing.Point(431, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 470);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "表情変更用マクロ追加";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(67, 20);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxImage.TabIndex = 24;
            this.pictureBoxImage.TabStop = false;
            // 
            // buttonDeletePartsSelect
            // 
            this.buttonDeletePartsSelect.Location = new System.Drawing.Point(25, 382);
            this.buttonDeletePartsSelect.Name = "buttonDeletePartsSelect";
            this.buttonDeletePartsSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletePartsSelect.TabIndex = 23;
            this.buttonDeletePartsSelect.Text = "選択中削除";
            this.buttonDeletePartsSelect.UseVisualStyleBackColor = true;
            this.buttonDeletePartsSelect.Click += new System.EventHandler(this.buttonDeletePartsSelect_Click);
            // 
            // buttonDeleteAllParts
            // 
            this.buttonDeleteAllParts.Location = new System.Drawing.Point(106, 382);
            this.buttonDeleteAllParts.Name = "buttonDeleteAllParts";
            this.buttonDeleteAllParts.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteAllParts.TabIndex = 25;
            this.buttonDeleteAllParts.Text = "全削除";
            this.buttonDeleteAllParts.UseVisualStyleBackColor = true;
            this.buttonDeleteAllParts.Click += new System.EventHandler(this.buttonDeleteAllParts_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 548);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupbox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.comboBoxTargetDirectory);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonrefer);
            this.Controls.Add(this.textBoxTargetDir);
            this.Name = "MainForm";
            this.Text = "差分タグ生成器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTargetDir;
        private System.Windows.Forms.Button buttonrefer;
        private System.Windows.Forms.ListBox listBoxParts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGenerateDefine;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.ComboBox comboBoxTargetDirectory;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGenerateTestTag;
        private System.Windows.Forms.ListBox listBoxCommonparts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.ComboBox comboBoxPartsParents;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxPartsChildren;
        private System.Windows.Forms.ListBox listBoxPartsCollection;
        private System.Windows.Forms.Button buttonAddMacroParts;
        private System.Windows.Forms.Button buttonGenerateImgMacro;
        private System.Windows.Forms.TextBox textBoxMacroId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Button buttonDeletePartsSelect;
        private System.Windows.Forms.Button buttonDeleteAllParts;
    }
}

