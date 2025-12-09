namespace Contador_de_Partidos
{
    public partial class MainPage : ContentPage
    {
        int score1 = 0;
        int score2 = 0;

        public MainPage()
        {
            InitializeComponent();
            Team1Label.Text = "Equipo 1";
            Team2Label.Text = "Equipo 2";
            TeamsLabel.Text = "Equipo 1 vs Equipo 2";
            UpdateScore();
        }

        void OnSaveNames(object sender, EventArgs e)
        {
            string team1 = string.IsNullOrWhiteSpace(Team1Entry.Text) ? "Equipo 1" : Team1Entry.Text;
            string team2 = string.IsNullOrWhiteSpace(Team2Entry.Text) ? "Equipo 2" : Team2Entry.Text;

            Team1Label.Text = team1;
            Team2Label.Text = team2;
            TeamsLabel.Text = $"{team1} vs {team2}";
        }

        void UpdateScore()
        {
            ScoreLabel.Text = $"{score1} - {score2}";

            // Color dinámico según quién va ganando
            if (score1 > score2)
                ScoreLabel.TextColor = Colors.Blue;
            else if (score2 > score1)
                ScoreLabel.TextColor = Colors.Orange;
            else
                ScoreLabel.TextColor = Colors.Black;
        }

        void OnAddTeam1(object sender, EventArgs e)
        {
            score1++;
            UpdateScore();
        }

        void OnSubTeam1(object sender, EventArgs e)
        {
            if (score1 > 0) score1--;
            UpdateScore();
        }

        void OnAddTeam2(object sender, EventArgs e)
        {
            score2++;
            UpdateScore();
        }

        void OnSubTeam2(object sender, EventArgs e)
        {
            if (score2 > 0) score2--;
            UpdateScore();
        }

        void OnResetScore(object sender, EventArgs e)
        {
            score1 = 0;
            score2 = 0;
            UpdateScore();
        }
    }

}
