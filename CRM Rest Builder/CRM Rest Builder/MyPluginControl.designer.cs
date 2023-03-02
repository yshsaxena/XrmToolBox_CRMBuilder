
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
            this.toolStripMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupColumns.SuspendLayout();
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
            this.toolStripMenu.Size = new System.Drawing.Size(1029, 27);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(107, 24);
            this.tsbClose.Text = "Close this tool";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbSample
            // 
            this.tsbSample.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSample.Name = "tsbSample";
            this.tsbSample.Size = new System.Drawing.Size(57, 24);
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
            this.lblSynchronous.Location = new System.Drawing.Point(145, 19);
            this.lblSynchronous.Name = "lblSynchronous";
            this.lblSynchronous.Size = new System.Drawing.Size(112, 21);
            this.lblSynchronous.TabIndex = 11;
            this.lblSynchronous.TabStop = true;
            this.lblSynchronous.Text = "Synchronous";
            this.lblSynchronous.UseVisualStyleBackColor = true;
            // 
            // rdoAsync
            // 
            this.rdoAsync.AutoSize = true;
            this.rdoAsync.Location = new System.Drawing.Point(20, 19);
            this.rdoAsync.Name = "rdoAsync";
            this.rdoAsync.Size = new System.Drawing.Size(119, 21);
            this.rdoAsync.TabIndex = 12;
            this.rdoAsync.TabStop = true;
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
            this.rdoWebApi.TabStop = true;
            this.rdoWebApi.Text = "Web.API";
            this.rdoWebApi.UseVisualStyleBackColor = true;
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
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(1029, 788);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupColumns.ResumeLayout(false);
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
    }
}
