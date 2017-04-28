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
using System.Web.Script.Serialization;
using System.Xml.Serialization;
namespace Traduttore_Json
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private string readingMatches()
        {

            using (TextReader fs = new StreamReader(@"C:\Users\Tony\Desktop\Esercizi Scuola\JSON\matches_today.json"))
            {
                return fs.ReadToEnd();
            } 
        }
        private string readingMatches2() {

            using (TextReader fs = new StreamReader(@"C:\Users\Tony\Desktop\Esercizi Scuola\JSON\livematches_live.json"))
            {
                return fs.ReadToEnd();
            }
        }


        private List<Match> loadMatchList()
        {
            
            JavaScriptSerializer js = new JavaScriptSerializer();
            MatchLiveList ml = js.Deserialize<MatchLiveList>(readingMatches());
            return ml.MatchLive;
            }
        private List<MacthLive> loadMatchList2() {

            JavaScriptSerializer js = new JavaScriptSerializer();
            MatchesList ml = js.Deserialize<MatchesList>(readingMatches2());
            return ml.Matches;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            var liveMatchList = loadMatchList2();
            dataGridView1.DataSource = liveMatchList.Select(l => new
            {
                id = l.Id,
                live =l.isLive,
                Finish = l.isFinished,
                Start = l.StartTime,
                Match = string.Concat(l.TeamHomeName, " VS ", l.TeamAwayName),
                Score = l.ScoreHome.HasValue && l.ScoreAway.HasValue ? string.Concat(l.ScoreHome, " - ", l.ScoreAway) : string.Empty
                
                
            }).OrderBy(l => l.id).ToList();

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {


            saveFileDialog1.ShowDialog();
        
        }

        private void button3_Click(object sender, EventArgs e) {

            
            
             dataGridView1.DataSource = loadMatchList().Select(m => new
            {
                IdMatch = m.IdMatch,
                Matchname = string.Concat(m.HomeTeamName, " VS ", m.AwayTeamName),
                MatchDate = m.MatchDate.ToString("yyyy-MM-dd HH:mm"),
                Score= m.ScoreHome.HasValue && m.ScoreAway.HasValue ? string.Concat(m.ScoreHome," - ",m.ScoreAway):string.Empty

            }).OrderBy(m => m.IdMatch).ToList();
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
