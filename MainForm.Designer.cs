namespace LeadershipManager
{
   partial class frmInfoViewer
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
         this.dgvStudentInfo = new System.Windows.Forms.DataGridView();
         this.btnConnect = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInfo)).BeginInit();
         this.SuspendLayout();
         // 
         // dgvStudentInfo
         // 
         this.dgvStudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvStudentInfo.Location = new System.Drawing.Point(0, 0);
         this.dgvStudentInfo.Name = "dgvStudentInfo";
         this.dgvStudentInfo.RowTemplate.Height = 24;
         this.dgvStudentInfo.Size = new System.Drawing.Size(662, 246);
         this.dgvStudentInfo.TabIndex = 0;
         // 
         // btnConnect
         // 
         this.btnConnect.Location = new System.Drawing.Point(60, 325);
         this.btnConnect.Name = "btnConnect";
         this.btnConnect.Size = new System.Drawing.Size(75, 23);
         this.btnConnect.TabIndex = 1;
         this.btnConnect.Text = "Connect";
         this.btnConnect.UseVisualStyleBackColor = true;
         this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
         // 
         // frmInfoViewer
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(674, 423);
         this.Controls.Add(this.btnConnect);
         this.Controls.Add(this.dgvStudentInfo);
         this.Name = "frmInfoViewer";
         this.Text = "Student Info Viewer";
         this.Load += new System.EventHandler(this.frmInfoViewer_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInfo)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.DataGridView dgvStudentInfo;
      private System.Windows.Forms.Button btnConnect;
   }
}

