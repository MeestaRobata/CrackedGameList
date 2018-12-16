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
        public string iggGameData;
        public string iggDatesData;
        public List<DateTime> parsedCroDates = new List<DateTime>();
        public List<DateTime> parsedIGGDates = new List<DateTime>();
        public Color croColor = Color.FromArgb(255, 0, 128, 255);
        public Color iggColor = Color.Green;

        public QueryForm() {
            InitializeComponent();
            infoQueryExe = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"infoQuery.exe");
            Process.Start(infoQueryExe);
            Thread.Sleep(4000);
            croGameData = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"CroGameInfo.txt");
            croDatesData = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"CroGameDates.txt");
            iggGameData = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"IGGGameInfo.txt");
            iggDatesData = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"IGGGameDates.txt");

            string[] croGameInfo = File.ReadAllLines(croGameData);
            string[] croDates = File.ReadAllLines(croDatesData);
            string[] iggGameInfo = File.ReadAllLines(iggGameData);
            string[] iggDates = File.ReadAllLines(iggDatesData);

            for (int i = 0; i < croDates.Length; i++) {
                parsedCroDates.Add(DateTime.Parse(croDates[i]));
            }
            for (int i = 0; i < iggDates.Length; i++) {
                parsedIGGDates.Add(DateTime.Parse(iggDates[i]));
            }

            for (int i = 0; i < croGameInfo.Length; i++) {
                GameData.Rows.Add(croGameInfo[i], "Crohasit.com", parsedCroDates[i]);
            }
            for (int i = 0; i < iggGameInfo.Length; i++) {
                GameData.Rows.Add(iggGameInfo[i], "IGG-Games.com", parsedIGGDates[i]);
            }

            for (int i = 0; i < GameData.Rows.Count; i++) {
                if (GameData.Rows[i].Cells[1].Value == "Crohasit.com") {
                    GameData.Rows[i].DefaultCellStyle.BackColor = croColor;
                } else if (GameData.Rows[i].Cells[1].Value == "IGG-Games.com") {
                    GameData.Rows[i].DefaultCellStyle.BackColor = iggColor;
                }
            }



        }
        //Functions
        private void getUpdate(object sender, EventArgs e) {
            GameData.Rows.Clear();
            Process.Start(infoQueryExe);
            string[] croGameInfo = File.ReadAllLines(croGameData);
            string[] croDates = File.ReadAllLines(croDatesData);
            string[] iggGameInfo = File.ReadAllLines(iggGameData);
            string[] iggDates = File.ReadAllLines(iggDatesData);

            for (int i = 0; i < croDates.Length; i++) {
                parsedCroDates.Add(DateTime.Parse(croDates[i]));
            }
            for (int i = 0; i < iggDates.Length; i++) {
                parsedIGGDates.Add(DateTime.Parse(iggDates[i]));
            }

            for (int i = 0; i < croGameInfo.Length; i++) {
                GameData.Rows.Add(croGameInfo[i], "Crohasit.com", parsedCroDates[i]);
                if (GameData.Rows[i].Cells[1].Value.ToString() == "Crohasit.com") {
                }
            }
            for (int i = 0; i < iggGameInfo.Length; i++) {
                GameData.Rows.Add(iggGameInfo[i], "IGG-Games.com", parsedIGGDates[i]);
            }
            for (int i = 0; i < GameData.Rows.Count; i++) {
                if (GameData.Rows[i].Cells[1].Value == "Crohasit.com") {
                    GameData.Rows[i].DefaultCellStyle.BackColor = croColor;
                } else if (GameData.Rows[i].Cells[1].Value == "IGG-Games.com") {
                    GameData.Rows[i].DefaultCellStyle.BackColor = iggColor;
                }
            }
        }

        private void changeCroColor(object sender, EventArgs e) {
            if (croColorDialog.ShowDialog() == DialogResult.OK) {
                for (int i = 0; i < GameData.Rows.Count; i++) {
                    if (GameData.Rows[i].Cells[1].Value == "Crohasit.com") {
                        croColor = croColorDialog.Color;
                        GameData.Rows[i].DefaultCellStyle.BackColor = croColor;
                    }
                }

            }

        }

        private void changeIGGColor(object sender, EventArgs e) {
            if (iggColorDialog.ShowDialog() == DialogResult.OK) {
                for (int i = 0; i < GameData.Rows.Count; i++) {
                    if (GameData.Rows[i].Cells[1].Value == "IGG-Games.com") {
                        iggColor = iggColorDialog.Color;
                        GameData.Rows[i].DefaultCellStyle.BackColor = iggColor;
                    }
                }
            }
        }

    }
}
