
namespace Engine.Interface
{
    partial class ProjectMenu
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
            this.L_EngineVersion = new System.Windows.Forms.Label();
            this.TB_FilePath = new System.Windows.Forms.TextBox();
            this.TB_ProjectName = new System.Windows.Forms.TextBox();
            this.B_CreateProject = new System.Windows.Forms.Button();
            this.B_Browarse = new System.Windows.Forms.Button();
            this.L_ProjectPath = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchWhereCreateProject = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // L_EngineVersion
            // 
            this.L_EngineVersion.AutoSize = true;
            this.L_EngineVersion.Location = new System.Drawing.Point(13, 13);
            this.L_EngineVersion.Name = "L_EngineVersion";
            this.L_EngineVersion.Size = new System.Drawing.Size(46, 17);
            this.L_EngineVersion.TabIndex = 0;
            this.L_EngineVersion.Text = "label1";
            // 
            // TB_FilePath
            // 
            this.TB_FilePath.Location = new System.Drawing.Point(13, 416);
            this.TB_FilePath.Name = "TB_FilePath";
            this.TB_FilePath.Size = new System.Drawing.Size(334, 22);
            this.TB_FilePath.TabIndex = 1;
            // 
            // TB_ProjectName
            // 
            this.TB_ProjectName.Location = new System.Drawing.Point(451, 416);
            this.TB_ProjectName.Name = "TB_ProjectName";
            this.TB_ProjectName.Size = new System.Drawing.Size(209, 22);
            this.TB_ProjectName.TabIndex = 2;
            // 
            // B_CreateProject
            // 
            this.B_CreateProject.Location = new System.Drawing.Point(666, 393);
            this.B_CreateProject.Name = "B_CreateProject";
            this.B_CreateProject.Size = new System.Drawing.Size(122, 45);
            this.B_CreateProject.TabIndex = 3;
            this.B_CreateProject.Text = "Create project";
            this.B_CreateProject.UseVisualStyleBackColor = true;
            this.B_CreateProject.Click += new System.EventHandler(this.B_CreateProject_Click);
            // 
            // B_Browarse
            // 
            this.B_Browarse.Location = new System.Drawing.Point(353, 393);
            this.B_Browarse.Name = "B_Browarse";
            this.B_Browarse.Size = new System.Drawing.Size(92, 46);
            this.B_Browarse.TabIndex = 4;
            this.B_Browarse.Text = "Browarse";
            this.B_Browarse.UseVisualStyleBackColor = true;
            this.B_Browarse.Click += new System.EventHandler(this.B_Browarse_Click);
            // 
            // L_ProjectPath
            // 
            this.L_ProjectPath.AutoSize = true;
            this.L_ProjectPath.Location = new System.Drawing.Point(13, 393);
            this.L_ProjectPath.Name = "L_ProjectPath";
            this.L_ProjectPath.Size = new System.Drawing.Size(88, 17);
            this.L_ProjectPath.TabIndex = 5;
            this.L_ProjectPath.Text = "Folder path :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Project name :";
            // 
            // SearchWhereCreateProject
            // 
            this.SearchWhereCreateProject.FileName = "openFileDialog1";
            this.SearchWhereCreateProject.FileOk += new System.ComponentModel.CancelEventHandler(this.SearchWhereCreateProject_FileOk);
            // 
            // ProjectMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.L_ProjectPath);
            this.Controls.Add(this.B_Browarse);
            this.Controls.Add(this.B_CreateProject);
            this.Controls.Add(this.TB_ProjectName);
            this.Controls.Add(this.TB_FilePath);
            this.Controls.Add(this.L_EngineVersion);
            this.Name = "ProjectMenu";
            this.ShowIcon = false;
            this.Text = "Create game project";
            this.Load += new System.EventHandler(this.ProjectMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_EngineVersion;
        private System.Windows.Forms.TextBox TB_FilePath;
        private System.Windows.Forms.TextBox TB_ProjectName;
        private System.Windows.Forms.Button B_CreateProject;
        private System.Windows.Forms.Button B_Browarse;
        private System.Windows.Forms.Label L_ProjectPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog SearchWhereCreateProject;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}