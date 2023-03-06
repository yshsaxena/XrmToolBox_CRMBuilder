
namespace CRM_Rest_Builder
{
    partial class MyPluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSample = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProcess = new System.Windows.Forms.Label();
            this.Action = new System.Windows.Forms.Label();
            this.lblFormat = new System.Windows.Forms.Label();
            this.lblEntity = new System.Windows.Forms.Label();
            this.rdoCreate = new System.Windows.Forms.RadioButton();
            this.lblSynchronous = new System.Windows.Forms.RadioButton();
            this.rdoAsync = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoXmlHttp = new System.Windows.Forms.RadioButton();
            this.rdoWebApi = new System.Windows.Forms.RadioButton();
            this.cmbEntity = new System.Windows.Forms.ComboBox();
            this.groupColumns = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.CmbFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEqual = new System.Windows.Forms.TextBox();
            this.Execute = new System.Windows.Forms.Button();
            this.tabCode = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox_Code = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox_Result = new System.Windows.Forms.RichTextBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.labelCopied = new System.Windows.Forms.Label();
            this.toolStripMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupColumns.SuspendLayout();
            this.tabCode.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1,
            this.tsbSample});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(2651, 39);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(107, 36);
            this.tsbClose.Text = "Close this tool";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbSample
            // 
            this.tsbSample.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSample.Name = "tsbSample";
            this.tsbSample.Size = new System.Drawing.Size(57, 36);
            this.tsbSample.Text = "Try me";
            this.tsbSample.Click += new System.EventHandler(this.tsbSample_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "CRM Rest Builder";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Location = new System.Drawing.Point(58, 160);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(59, 17);
            this.lblProcess.TabIndex = 6;
            this.lblProcess.Text = "Process";
            // 
            // Action
            // 
            this.Action.AutoSize = true;
            this.Action.Location = new System.Drawing.Point(58, 102);
            this.Action.Name = "Action";
            this.Action.Size = new System.Drawing.Size(47, 17);
            this.Action.TabIndex = 7;
            this.Action.Text = "Action";
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(58, 221);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(52, 17);
            this.lblFormat.TabIndex = 8;
            this.lblFormat.Text = "Format";
            // 
            // lblEntity
            // 
            this.lblEntity.AutoSize = true;
            this.lblEntity.Location = new System.Drawing.Point(58, 268);
            this.lblEntity.Name = "lblEntity";
            this.lblEntity.Size = new System.Drawing.Size(43, 17);
            this.lblEntity.TabIndex = 9;
            this.lblEntity.Text = "Entity";
            // 
            // rdoCreate
            // 
            this.rdoCreate.AutoSize = true;
            this.rdoCreate.Checked = true;
            this.rdoCreate.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdoCreate.Location = new System.Drawing.Point(162, 100);
            this.rdoCreate.Name = "rdoCreate";
            this.rdoCreate.Size = new System.Drawing.Size(134, 21);
            this.rdoCreate.TabIndex = 10;
            this.rdoCreate.TabStop = true;
            this.rdoCreate.Text = "Retrieve Multiple";
            this.rdoCreate.UseVisualStyleBackColor = true;
            // 
            // lblSynchronous
            // 
            this.lblSynchronous.AutoSize = true;
            this.lblSynchronous.Checked = true;
            this.lblSynchronous.Location = new System.Drawing.Point(145, 19);
            this.lblSynchronous.Name = "lblSynchronous";
            this.lblSynchronous.Size = new System.Drawing.Size(112, 21);
            this.lblSynchronous.TabIndex = 11;
            this.lblSynchronous.TabStop = true;
            this.lblSynchronous.Text = "Synchronous";
            this.lblSynchronous.UseVisualStyleBackColor = true;
            this.lblSynchronous.CheckedChanged += new System.EventHandler(this.lblSynchronous_CheckedChanged);
            // 
            // rdoAsync
            // 
            this.rdoAsync.AutoSize = true;
            this.rdoAsync.Location = new System.Drawing.Point(20, 19);
            this.rdoAsync.Name = "rdoAsync";
            this.rdoAsync.Size = new System.Drawing.Size(119, 21);
            this.rdoAsync.TabIndex = 12;
            this.rdoAsync.Text = "Asynchronous";
            this.rdoAsync.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoAsync);
            this.groupBox1.Controls.Add(this.lblSynchronous);
            this.groupBox1.Location = new System.Drawing.Point(141, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 48);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoXmlHttp);
            this.groupBox3.Controls.Add(this.rdoWebApi);
            this.groupBox3.Location = new System.Drawing.Point(141, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 48);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // rdoXmlHttp
            // 
            this.rdoXmlHttp.AutoSize = true;
            this.rdoXmlHttp.Checked = true;
            this.rdoXmlHttp.Location = new System.Drawing.Point(20, 19);
            this.rdoXmlHttp.Name = "rdoXmlHttp";
            this.rdoXmlHttp.Size = new System.Drawing.Size(94, 21);
            this.rdoXmlHttp.TabIndex = 12;
            this.rdoXmlHttp.TabStop = true;
            this.rdoXmlHttp.Text = "XMLHTTP";
            this.rdoXmlHttp.UseVisualStyleBackColor = true;
            // 
            // rdoWebApi
            // 
            this.rdoWebApi.AutoSize = true;
            this.rdoWebApi.Location = new System.Drawing.Point(145, 19);
            this.rdoWebApi.Name = "rdoWebApi";
            this.rdoWebApi.Size = new System.Drawing.Size(83, 21);
            this.rdoWebApi.TabIndex = 11;
            this.rdoWebApi.Text = "Web.API";
            this.rdoWebApi.UseVisualStyleBackColor = true;
            this.rdoWebApi.CheckedChanged += new System.EventHandler(this.rdoWebApi_CheckedChanged);
            // 
            // cmbEntity
            // 
            this.cmbEntity.FormattingEnabled = true;
            this.cmbEntity.Location = new System.Drawing.Point(141, 265);
            this.cmbEntity.Name = "cmbEntity";
            this.cmbEntity.Size = new System.Drawing.Size(300, 24);
            this.cmbEntity.TabIndex = 16;
            this.cmbEntity.Text = "Select an Entity";
            this.cmbEntity.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // groupColumns
            // 
            this.groupColumns.Controls.Add(this.checkedListBox1);
            this.groupColumns.Location = new System.Drawing.Point(61, 322);
            this.groupColumns.Name = "groupColumns";
            this.groupColumns.Size = new System.Drawing.Size(380, 190);
            this.groupColumns.TabIndex = 17;
            this.groupColumns.TabStop = false;
            this.groupColumns.Text = "Columns";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(7, 22);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(367, 157);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // CmbFilter
            // 
            this.CmbFilter.FormattingEnabled = true;
            this.CmbFilter.Location = new System.Drawing.Point(61, 583);
            this.CmbFilter.Name = "CmbFilter";
            this.CmbFilter.Size = new System.Drawing.Size(194, 24);
            this.CmbFilter.TabIndex = 18;
            this.CmbFilter.Text = "Filter Column";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 539);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Filter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 586);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Equal";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxEqual
            // 
            this.textBoxEqual.Location = new System.Drawing.Point(330, 583);
            this.textBoxEqual.Name = "textBoxEqual";
            this.textBoxEqual.Size = new System.Drawing.Size(394, 22);
            this.textBoxEqual.TabIndex = 21;
            this.textBoxEqual.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Execute
            // 
            this.Execute.Location = new System.Drawing.Point(61, 641);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(121, 37);
            this.Execute.TabIndex = 22;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // tabCode
            // 
            this.tabCode.Controls.Add(this.tabPage1);
            this.tabCode.Controls.Add(this.tabPage2);
            this.tabCode.Location = new System.Drawing.Point(761, 100);
            this.tabCode.Name = "tabCode";
            this.tabCode.SelectedIndex = 0;
            this.tabCode.Size = new System.Drawing.Size(951, 662);
            this.tabCode.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox_Code);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(943, 633);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Code";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox_Code
            // 
            this.richTextBox_Code.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_Code.Name = "richTextBox_Code";
            this.richTextBox_Code.Size = new System.Drawing.Size(940, 630);
            this.richTextBox_Code.TabIndex = 0;
            this.richTextBox_Code.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox_Result);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(943, 633);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Result";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox_Result
            // 
            this.richTextBox_Result.Location = new System.Drawing.Point(1, 1);
            this.richTextBox_Result.Name = "richTextBox_Result";
            this.richTextBox_Result.Size = new System.Drawing.Size(940, 630);
            this.richTextBox_Result.TabIndex = 1;
            this.richTextBox_Result.Text = "";
            this.richTextBox_Result.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(188, 641);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(108, 37);
            this.buttonCopy.TabIndex = 26;
            this.buttonCopy.Text = "Copy Code";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // labelCopied
            // 
            this.labelCopied.AutoSize = true;
            this.labelCopied.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopied.Location = new System.Drawing.Point(302, 646);
            this.labelCopied.Name = "labelCopied";
            this.labelCopied.Size = new System.Drawing.Size(98, 30);
            this.labelCopied.TabIndex = 27;
            this.labelCopied.Text = "copied!!";
            this.labelCopied.Visible = false;
            this.labelCopied.Click += new System.EventHandler(this.labelCopied_Click);
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelCopied);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.tabCode);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.textBoxEqual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbFilter);
            this.Controls.Add(this.groupColumns);
            this.Controls.Add(this.cmbEntity);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdoCreate);
            this.Controls.Add(this.lblEntity);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.Action);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStripMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(2121, 776);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupColumns.ResumeLayout(false);
            this.tabCode.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton tsbSample;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label Action;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Label lblEntity;
        private System.Windows.Forms.RadioButton rdoCreate;
        private System.Windows.Forms.RadioButton lblSynchronous;
        private System.Windows.Forms.RadioButton rdoAsync;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoXmlHttp;
        private System.Windows.Forms.RadioButton rdoWebApi;
        private System.Windows.Forms.ComboBox cmbEntity;
        private System.Windows.Forms.GroupBox groupColumns;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox CmbFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEqual;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.TabControl tabCode;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox_Code;
        private System.Windows.Forms.RichTextBox richTextBox_Result;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Label labelCopied;
    }
}
