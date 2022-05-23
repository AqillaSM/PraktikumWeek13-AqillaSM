using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PraktikumWeek13_AqillaSM
{
    public partial class FormPlayer : Form
    {
        public FormPlayer()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league"); // sebagai data koneksi ke DBMSnya, memasukkan IP Address, localhost, user, password
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter; // hasil query akan disimpan olehnya atau menjadi penampung
        string sqlQuery;
        DataTable dtPlayer = new DataTable();
        int PosisiSekarang = 0;
        DataTable dtTeamNumber = new DataTable();

        private void FormPlayer_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();

            //copy mulai sini
            sqlQuery = "select distinct player.player_id as 'Player ID', player.player_name as 'Player Name', player.birthdate as 'Birthdate', nationality.nation as 'Nationality', team.team_name as 'Team', player.team_number as 'Team Number' from player, nationality, team where player.team_id = team.team_id and player.nationality_id = nationality.nationality_id; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer); // sampai sini
            IsiDataPemain(0);

            DataTable dtNation = new DataTable();
            
            

            sqlQuery = "select n.nation as `Nationality`, p.nationality_id as Negarah from player p, nationality n where p.nationality_id = n.nationality_id group by p.nationality_id; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtNation);
            IsiDataPemain(0);
            ComboBoxNation.DataSource = dtNation;
            ComboBoxNation.DisplayMember = "Nationality";
            ComboBoxNation.ValueMember = "Negarah";

            DataTable dtteam = new DataTable();
            sqlQuery = "SELECT team.team_name as `Team`, player.team_id as 'Tim id' from player, team where player.team_id = team.team_id group by 1";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtteam);
            ComboBoxTeam.DataSource = dtteam;
            ComboBoxTeam.DisplayMember = "Team";
            ComboBoxTeam.ValueMember = "Tim id";

            DateTimeBirthdate.CustomFormat = "dddd, MMMM dd, yyyy";
            DateTimeBirthdate.Format = DateTimePickerFormat.Custom;

        }



        public void IsiDataPemain(int Posisi)
        {
            //MessageBox.Show(Posisi.ToString());
            TextBoxPlayerID.Text = dtPlayer.Rows[Posisi][0].ToString();
            TextBoxPlayerName.Text = dtPlayer.Rows[Posisi][1].ToString();
            DateTimeBirthdate.Text = dtPlayer.Rows[Posisi][2].ToString();
            ComboBoxNation.Text = dtPlayer.Rows[Posisi][3].ToString();
            ComboBoxTeam.Text = dtPlayer.Rows[Posisi][4].ToString();
            NumericTeamNumber.Text = dtPlayer.Rows[Posisi][5].ToString();
            PosisiSekarang = Posisi;
        }

        private void ButtonFirst_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang > 0)
            {
                IsiDataPemain(0);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }
        }

        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang > 0)
            {
                PosisiSekarang--;
                IsiDataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang < dtPlayer.Rows.Count - 1)
            {
                PosisiSekarang++;
                IsiDataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Terakhir");
            }
        }

        private void ButtonLast_Click(object sender, EventArgs e)
        {

            if (PosisiSekarang < dtPlayer.Rows.Count - 1)
            {
                IsiDataPemain(dtPlayer.Rows.Count - 1);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }
        }

        private void NumericTeamNumber_ValueChanged(object sender, EventArgs e)
        {
            sqlQuery = $"SELECT * FROM player WHERE team_id='{ComboBoxTeam.SelectedValue}' and team_number={NumericTeamNumber.Value}";
            dtTeamNumber = new DataTable();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamNumber);

            if (dtTeamNumber.Rows.Count > 0)
            {
                LabelAvail.Text = "Not Available";
            }
            else
            {
                LabelAvail.Text = "Available";
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            sqlQuery = $"UPDATE player SET player_name = '" + TextBoxPlayerName.Text + "', team_number = '" + NumericTeamNumber.Value.ToString() + "', nationality_id = '" + ComboBoxNation.SelectedValue.ToString() + "', team_id = '" + ComboBoxTeam.SelectedValue.ToString() + "' where player_id = '" + TextBoxPlayerID.Text + "' ";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
        }
    }
}
