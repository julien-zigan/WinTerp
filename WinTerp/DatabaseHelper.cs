using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinTerp
{
    public static class DatabaseHelper
    {
        private const string DatabaseDir = "WinTerp"; 
        private const string DatabaseFile = "UserData.db";
        private const string FileSeparator = @"/";


        public static void InitializeDatabase()
        {
            string PathToDatabaseFile =
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            if (!Directory.Exists(PathToDatabaseFile + FileSeparator + DatabaseDir))
            {
                Directory.CreateDirectory(PathToDatabaseFile + FileSeparator + DatabaseDir);
            }

            if (!File.Exists(DatabaseFile))
            {
                File.Create(PathToDatabaseFile 
                    + FileSeparator 
                    + DatabaseDir
                    + FileSeparator
                    + DatabaseFile);
            }

        }
    }
}
