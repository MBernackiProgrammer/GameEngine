using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Engine.Creator.Project
{
    class DirectoryCreator
    {
        static public void CreateProject(string StartDirectory, string ProjectName)
        {
            Directory.CreateDirectory(StartDirectory + "\\" + ProjectName);

            Directory.CreateDirectory(StartDirectory + "\\" + ProjectName + "\\" + "Plugins");

            Directory.CreateDirectory(StartDirectory + "\\" + ProjectName + "\\" + "AutoSaves");

            Directory.CreateDirectory(StartDirectory + "\\" + ProjectName + "\\" + "Content");

            Directory.CreateDirectory(StartDirectory + "\\" + ProjectName + "\\" + "Scipts");

            Directory.CreateDirectory(StartDirectory + "\\" + ProjectName + "\\" + "Settings");

            CreateSettingsSave(StartDirectory + "\\" + ProjectName + "\\" + "Settings");
        }

        static public void CreateSettingsSave(string StartPath)
        {
            string MovingDirectoryHelper;
            MovingDirectoryHelper = StartPath + "\\" + "EngineSettings";
            Directory.CreateDirectory(MovingDirectoryHelper);

            Directory.CreateDirectory(MovingDirectoryHelper + "\\QualitySettings");
            Directory.CreateDirectory(MovingDirectoryHelper + "\\ExportSettings");
            Directory.CreateDirectory(MovingDirectoryHelper + "\\PluginsSettings");
            //MovingDirectoryHelper = MovingDirectoryHelper + "\\QualitySettings"
        }
    }
}
