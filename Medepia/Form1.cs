using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Collections;

namespace Medepia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rd = new Random();

        model.LeagueStage ls = new model.LeagueStage();

        model.LeagueTable fb = new model.LeagueTable();
        model.LeagueTable gs = new model.LeagueTable();
        model.LeagueTable bjk = new model.LeagueTable();
        model.LeagueTable mucur = new model.LeagueTable();
        model.LeagueTable trabzon = new model.LeagueTable();
        model.LeagueTable sivas = new model.LeagueTable();
        model.LeagueTable team1 = new model.LeagueTable();
        model.LeagueTable team2 = new model.LeagueTable();

        parser deneme = new parser();

        private void Form1_Load(object sender, EventArgs e)
        {
            string leagueStage = "{\"id\": \"1\", \"name\": \"2017/2018 Sezonu\", \"tournamentName\": \"Spor Toto Süper Lig\",\"logo\": \"http://zmdp.cloud/iseAlim/images/1.png\"}";

            ls = JsonConvert.DeserializeObject<model.LeagueStage>(leagueStage);
            //  deneme.parse();

            lbl_ls_name.Text = ls.name;
            lbl_ls_tourname.Text = ls.tournamentName;
            pb_ls_logo.ImageLocation = ls.logo;

            string json = @"[
                {
                    'teamId':1,
                    'name':'Fenerbahçe',
                    'overall':75,
                    'teamLogo':'http://zmdp.cloud/iseAlim/images/2.png'
                 },
                {
                   'teamId':2,
                    'name':'Galatasaray',
                    'overall':74,
                    'teamLogo':'http://zmdp.cloud/iseAlim/images/3.png'
                },
                {
                    'teamId':3,
                    'name':'Beşiktaş',
                    'overall':77,
                    'teamLogo':'http://zmdp.cloud/iseAlim/images/4.png'
                },
                {   'teamId':4,
                    'name':'Mucur Gücü',
                    'overall':73,
                    'teamLogo':'http://zmdp.cloud/iseAlim/images/5.png'
                },
                {
                    'teamId':5,
                    'name':'Trabzonspor',
                    'overall':72,
                    'teamLogo':'http://zmdp.cloud/iseAlim/images/6.png'
                },
                {   'teamId':6,
                    'name':'Demir Grup Sivasspor',
                    'overall':70,
                    'teamLogo':'http://zmdp.cloud/iseAlim/images/7.png'
                }

]";

            JArray leagueTableArray = JArray.Parse(json);

            IList<model.LeagueTable> leagueTable = leagueTableArray.Select(p => new model.LeagueTable
            {
                teamId = (int)p["teamId"],
                name = (string)p["name"],
                overall = (int)p["overall"],
                teamLogo = (string)p["teamLogo"]
            }).ToList();

            createTable();
        }
        public void newTable()
        {
            DataTable table = new DataTable();
            DataRow rows = table.NewRow();
            table.Columns.Add("Takımlar");
            table.Columns.Add("Takımlar1");
            table.Columns.Add("Score");
            table.Columns.Add("Score1");

            List<string> myTakimlar = new List<string>(new string[] { "Fenerbahçe", "Galatasaray", "Beşiktaş", "Grup Demir Sivasspor", "Mucur Gücü", "Trabzonspor" });
            string[,] dizi = new string[(myTakimlar.Count / 2), 2];
            string[,] dizi1 = new string[(myTakimlar.Count / 2), 2];


            int random = 0, random1 = 0;

            for (int i = 0; i < 3; i++)
            {
                random = rd.Next(0, myTakimlar.Count);
                random1 = rd.Next(0, myTakimlar.Count);

                while (random == random1)
                {
                    random1 = rd.Next(0, myTakimlar.Count);

                }

                dizi[i, 0] = myTakimlar[random];
                dizi1[i, 1] = myTakimlar[random1];
                myTakimlar.RemoveAt(random);
                random1 = random1 > random ? random1 - 1 : random1;
                myTakimlar.RemoveAt(random1);
                table.Rows.Add(dizi[i, 0], dizi1[i, 1], rd.Next(0, 6), rd.Next(0, 6));

            }

            int team1Score, team2Score;

            dataGridView2.DataSource = table;
            team1.name = dataGridView2.Rows[0].Cells["Takımlar"].Value.ToString();
            team2.name = dataGridView2.Rows[0].Cells["Takımlar1"].Value.ToString();
            team1Score = Convert.ToInt32(dataGridView2.Rows[0].Cells["Score"].Value);
            team2Score = Convert.ToInt32(dataGridView2.Rows[0].Cells["Score1"].Value);

            compareTeam(team1Score, team2Score, team1, team2);

            team1.name = dataGridView2.Rows[1].Cells["Takımlar"].Value.ToString();
            team2.name = dataGridView2.Rows[1].Cells["Takımlar1"].Value.ToString();
            team1Score = Convert.ToInt32(dataGridView2.Rows[1].Cells["Score"].Value);
            team2Score = Convert.ToInt32(dataGridView2.Rows[1].Cells["Score1"].Value);

            compareTeam(team1Score, team2Score, team1, team2);

            team1.name = dataGridView2.Rows[2].Cells["Takımlar"].Value.ToString();
            team2.name = dataGridView2.Rows[2].Cells["Takımlar1"].Value.ToString();
            team1Score = Convert.ToInt32(dataGridView2.Rows[2].Cells["Score"].Value);
            team2Score = Convert.ToInt32(dataGridView2.Rows[2].Cells["Score1"].Value);

            compareTeam(team1Score, team2Score, team1, team2);
         
        }  
        private void createTable()
        {
            DataTable table = new DataTable();
            DataRow rows = table.NewRow();
            table.Columns.Add("Takım");
            table.Columns.Add("Oynanan Maç");
            table.Columns.Add("Galibiyet");
            table.Columns.Add("Mağlubiyet");
            table.Columns.Add("Beraberlik");
            table.Columns.Add("Puan");

            table.Rows.Add("Fenerbahçe", fb.playedMatch, fb.win, fb.loss, fb.onTerms, fb.score);
            table.Rows.Add("Beşiktaş", bjk.playedMatch, bjk.win, bjk.loss, bjk.onTerms, bjk.score);
            table.Rows.Add("Galatasaray", gs.playedMatch, gs.win, gs.loss, gs.onTerms, gs.score);
            table.Rows.Add("Mucur", mucur.playedMatch, mucur.win, mucur.loss, mucur.onTerms, mucur.score);
            table.Rows.Add("Trabzonspor", trabzon.playedMatch, trabzon.win, trabzon.loss, trabzon.onTerms, trabzon.score);
            table.Rows.Add("Sivasspor", sivas.playedMatch, sivas.win, sivas.loss, sivas.onTerms, sivas.score);

            dataGridView1.DataSource = table;
            dataGridView1.Sort(dataGridView1.Columns[5], System.ComponentModel.ListSortDirection.Descending);

        }
        private void compareTeam(int team1, int team2, model.LeagueTable team1Name, model.LeagueTable team2Name)
        {
            if (team1 > team2)
            {
                team1Name.score += 3;
                team1Name.playedMatch++;
                team2Name.playedMatch++;

                team1Name.win++;
                team2Name.loss++;

                createTable();

            }
            else if (team1 == team2)
            {
                team1Name.score++;
                team2Name.score++;

                team1Name.playedMatch++;
                team2Name.playedMatch++;

                team1Name.onTerms++;
                team2Name.onTerms++;

                createTable();
            }
            else
            {
                team2Name.score += 3;

                team1Name.playedMatch++;
                team2Name.playedMatch++;

                team1Name.loss++;
                team2Name.win++;

                createTable();
            }
            denemeLbl.Text = team1Name.name;
            denemeLbl1.Text = team1Name.win.ToString();
            denemeLbl2.Text = team1Name.onTerms.ToString();
            denemeLbl3.Text = team1Name.loss.ToString();

        }
      
        private void run_Click(object sender, EventArgs e)
        {

            newTable();

        }

    }
}






