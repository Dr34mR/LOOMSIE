
namespace AppCore.Forms
{
    partial class FormTask
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
            this.gridToComplete = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.lblDue = new System.Windows.Forms.Label();
            this.dteDue = new System.Windows.Forms.DateTimePicker();
            this.dteReported = new System.Windows.Forms.DateTimePicker();
            this.lblReported = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtOffence = new System.Windows.Forms.TextBox();
            this.lblOffence = new System.Windows.Forms.Label();
            this.lblToComplete = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblFolder = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridToComplete)).BeginInit();
            this.SuspendLayout();
            // 
            // gridToComplete
            // 
            this.gridToComplete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridToComplete.Location = new System.Drawing.Point(12, 145);
            this.gridToComplete.Name = "gridToComplete";
            this.gridToComplete.Size = new System.Drawing.Size(315, 253);
            this.gridToComplete.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(7, 15);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(95, 26);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "Task #1";
            // 
            // lblDue
            // 
            this.lblDue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDue.AutoSize = true;
            this.lblDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDue.Location = new System.Drawing.Point(312, 15);
            this.lblDue.Name = "lblDue";
            this.lblDue.Size = new System.Drawing.Size(55, 26);
            this.lblDue.TabIndex = 8;
            this.lblDue.Text = "Due";
            // 
            // dteDue
            // 
            this.dteDue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dteDue.CustomFormat = "dd/MM/yy";
            this.dteDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteDue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dteDue.Location = new System.Drawing.Point(373, 12);
            this.dteDue.Name = "dteDue";
            this.dteDue.Size = new System.Drawing.Size(147, 32);
            this.dteDue.TabIndex = 9;
            // 
            // dteReported
            // 
            this.dteReported.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dteReported.CustomFormat = "dd/MM/yy";
            this.dteReported.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteReported.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dteReported.Location = new System.Drawing.Point(641, 12);
            this.dteReported.Name = "dteReported";
            this.dteReported.Size = new System.Drawing.Size(147, 32);
            this.dteReported.TabIndex = 11;
            // 
            // lblReported
            // 
            this.lblReported.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReported.AutoSize = true;
            this.lblReported.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReported.Location = new System.Drawing.Point(526, 15);
            this.lblReported.Name = "lblReported";
            this.lblReported.Size = new System.Drawing.Size(109, 26);
            this.lblReported.TabIndex = 10;
            this.lblReported.Text = "Reported";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskName.Location = new System.Drawing.Point(12, 83);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(152, 26);
            this.txtTaskName.TabIndex = 18;
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskName.Location = new System.Drawing.Point(8, 60);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(88, 20);
            this.lblTaskName.TabIndex = 17;
            this.lblTaskName.Text = "Brief / Task";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(171, 60);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(127, 20);
            this.lblNumber.TabIndex = 19;
            this.lblNumber.Text = "C / E / H Number";
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(175, 83);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(152, 26);
            this.txtNumber.TabIndex = 20;
            // 
            // txtOffence
            // 
            this.txtOffence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOffence.Location = new System.Drawing.Point(333, 83);
            this.txtOffence.Name = "txtOffence";
            this.txtOffence.Size = new System.Drawing.Size(152, 26);
            this.txtOffence.TabIndex = 21;
            // 
            // lblOffence
            // 
            this.lblOffence.AutoSize = true;
            this.lblOffence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffence.Location = new System.Drawing.Point(333, 60);
            this.lblOffence.Name = "lblOffence";
            this.lblOffence.Size = new System.Drawing.Size(135, 20);
            this.lblOffence.TabIndex = 22;
            this.lblOffence.Text = "Offence / Incident";
            // 
            // lblToComplete
            // 
            this.lblToComplete.AutoSize = true;
            this.lblToComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToComplete.Location = new System.Drawing.Point(8, 122);
            this.lblToComplete.Name = "lblToComplete";
            this.lblToComplete.Size = new System.Drawing.Size(127, 20);
            this.lblToComplete.TabIndex = 23;
            this.lblToComplete.Text = "To be completed";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(713, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolder.Location = new System.Drawing.Point(487, 60);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(87, 20);
            this.lblFolder.TabIndex = 25;
            this.lblFolder.Text = "Link Folder";
            // 
            // txtFolder
            // 
            this.txtFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolder.Location = new System.Drawing.Point(491, 83);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(144, 26);
            this.txtFolder.TabIndex = 26;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(341, 122);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(51, 20);
            this.lblNotes.TabIndex = 27;
            this.lblNotes.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.AcceptsReturn = true;
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(345, 145);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(443, 253);
            this.txtNotes.TabIndex = 28;
            // 
            // FormTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblDue);
            this.Controls.Add(this.dteDue);
            this.Controls.Add(this.lblReported);
            this.Controls.Add(this.dteReported);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblOffence);
            this.Controls.Add(this.txtOffence);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.lblToComplete);
            this.Controls.Add(this.gridToComplete);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.btnSave);
            this.Name = "FormTask";
            this.Text = "FormTask";
            ((System.ComponentModel.ISupportInitialize)(this.gridToComplete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridToComplete;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDue;
        private System.Windows.Forms.DateTimePicker dteDue;
        private System.Windows.Forms.DateTimePicker dteReported;
        private System.Windows.Forms.Label lblReported;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtOffence;
        private System.Windows.Forms.Label lblOffence;
        private System.Windows.Forms.Label lblToComplete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
    }
}