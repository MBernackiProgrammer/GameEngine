using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Engine;
using Engine.Errors;
using Engine.Creator.Project;

namespace Engine.Interface
{
    public partial class ProjectMenu : Form
    {
        public ProjectMenu()
        {
            InitializeComponent();
        }

        private void ProjectMenu_Load(object sender, EventArgs e)
        {
            L_EngineVersion.Text = "Engine version : " + EngineData.EngineVersion;
        }

        private void B_Browarse_Click(object sender, EventArgs e)
        {
            SearchWhereCreateProject.ShowDialog();
        }

        private void SearchWhereCreateProject_FileOk(object sender, CancelEventArgs e)
        {
            TB_FilePath.Text = SearchWhereCreateProject.ToString();
        }

        private void B_CreateProject_Click(object sender, EventArgs e)
        {
            //Check FilePath was wrote 
            if(TB_FilePath.Text != "")
            {
                //Check Directory whose was wrote is exist 
                if(Directory.Exists(TB_FilePath.Text))
                {
                    //Was wrote project name ?
                    if(TB_ProjectName.Text != "")
                    {
                        DirectoryCreator.CreateProject(TB_FilePath.Text, TB_ProjectName.Text);
                    }
                    else
                    {
                        ErrorManager.PrintError(ErrorType.Basic, "Write project name");
                    }
                }
                else
                {
                    ErrorManager.PrintError(ErrorType.Basic, "Select / write corect project path");
                }
            }
            else
            {
                ErrorManager.PrintError(ErrorType.Basic, "Select / write project path");
            }

        }
    }
}
