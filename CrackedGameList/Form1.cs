using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrackedGameList {
    public partial class QueryForm : Form {
        public string infoQueryExe;
        public string croGameData;
        public string croDatesData;
        public QueryForm() {
            InitializeComponent();
            infoQueryExe = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"infoQuery.exe");
            Process.Start(infoQueryExe);
            Thread.Sleep(2000);
            croGameData = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"CroGameInfo.txt");
            croDatesData = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"CroGameDates.txt");


            string[] croGameInfo = System.IO.File.ReadAllLines(croGameData);
            string[] croDates = System.IO.File.ReadAllLines(croDatesData);
            List<DateTime> parsedDates = new List<DateTime>();

            for(int i=0;i<croDates.Length;i++) {
                parsedDates.Add(DateTime.Parse(croDates[i]));
            }
            foreach(DateTime date in parsedDates) {
                Debug.WriteLine(date.ToString("d"));
            }
        
            for(int i=0;i<croGameInfo.Length;i++) {
                GameData.Rows.Add(croGameInfo[i], "Crohasit.com", parsedDates[i]);
            }


        }
        //Functions
        private void getUpdate(object sender, EventArgs e) {
            GameData.Rows.Clear();
            Process.Start(infoQueryExe);
            string[] croGameInfo = System.IO.File.ReadAllLines(croGameData);
            string[] croDates = System.IO.File.ReadAllLines(croDatesData);
            for (int i = 0; i < croGameInfo.Length; i++) {
                GameData.Rows.Add(croGameInfo[i], "Crohasit.com", croDates[i]);
            }
        }

        private void changeCroColor(object sender, EventArgs e) {
            string testinput = "December 12, 2018";
            DateTime parsedDate = DateTime.Parse(testinput);
            Debug.WriteLine(parsedDate.ToString("d"));


            if(colorDialog.ShowDialog() == DialogResult.OK) {
                for(int i=0;i<GameData.Rows.Count;i++) {
                    if(GameData.Rows[i].Cells[1].Value.ToString() == "Crohasit.com") {
                        GameData.Rows[i].DefaultCellStyle.BackColor = colorDialog.Color;
                    }
                }
                
            }
        }

    }
}
