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
using System.IO;

namespace WSOS_v0._1
{
    public partial class StudentForm : Form,ISzukanie
    {
        string login = FormularzLogIn.identity;
       
        public StudentForm()
        {
            InitializeComponent();

        }
        MySqlDataReader czytplan;
        //Zmiana bajtow ktore odczytamy z bazy na zdjecie
        public Image PlanJakoImage(byte[] plan)
        {
            MemoryStream mstream = new MemoryStream(plan);
            return Image.FromStream(mstream);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Pobierz()
        {
            try
            {
                //Pobranie planu zajęć
                if (FormularzLogIn.pol.State == ConnectionState.Closed)
                    FormularzLogIn.pol.Open();
                string sqlplan = String.Format("SELECT S.Plan FROM Studenci S INNER JOIN Osoby O ON S.NrIndeksu=O.Identyfikator WHERE O.Login='{0}'", FormularzLogIn.identity);
                MySqlCommand planKom = new MySqlCommand(sqlplan, FormularzLogIn.pol);
                czytplan = planKom.ExecuteReader();
                if (czytplan.HasRows)
                {
                    while (czytplan.Read())
                    {
                        planPicture.Image = PlanJakoImage((byte[])czytplan[0]);
                    }

                }
                czytplan.Close();

                //Pobranie ocen
                string sqloceny = String.Format("SELECT  O.Data,P.NazwaPrzedmiotu as Przedmiot, O.Ocena, CONCAT(Os.Nazwisko,' ',Os.Imiona) AS Prowadzący, O.Uwagi From Przedmioty P INNER JOIN Ocenianie O ON P.IdPrzedmiotu=O.Przedmiot INNER JOIN Osoby Os ON O.Prowadzacy=Os.Identyfikator WHERE O.NrIndeksu = '{0}'", login.Remove(0, 1));
                MySqlCommand OcenyKom = new MySqlCommand(sqloceny, FormularzLogIn.pol);
                MySqlDataReader czytocena = OcenyKom.ExecuteReader();
                listaOcen.Items.Clear();
                if (czytocena.HasRows)
                {
                    while (czytocena.Read())
                    {
                        listaOcen.Items.Add(string.Format("{0}      {1}        {2}        {3}         {4}", czytocena[0].ToString(), czytocena[1].ToString(), czytocena[2].ToString(), czytocena[3].ToString(), czytocena[4].ToString()));
                    }

                }
                czytocena.Close();

                //Pobranie informacji o studentach do ComboBoxa
                string pobierzStSql = String.Format("SELECT DISTINCT CONCAT(Nazwisko,' ',Imiona) FROM Osoby Os INNER JOIN Studenci S ON S.NrIndeksu=Os.Identyfikator");
                MySqlCommand pobierzStKom = new MySqlCommand(pobierzStSql, FormularzLogIn.pol);
                MySqlDataReader czytSt = pobierzStKom.ExecuteReader();
                if (czytSt.HasRows)
                {
                    while (czytSt.Read())
                    {
                        WyszukajStBox.Items.Add(czytSt[0].ToString());

                    }

                }
                czytSt.Close();

                //Pobranie informacji o pracownikach do ComboBoxa
                string pobierzPrsql = String.Format("SELECT CONCAT(Nazwisko,' ',Imiona)FROM Osoby WHERE Rola='pracownik administracyjny'OR Rola='pracownik dydaktyczny'");
                MySqlCommand pobierzPrKom = new MySqlCommand(pobierzPrsql, FormularzLogIn.pol);
                MySqlDataReader czytPr = pobierzPrKom.ExecuteReader();
                if (czytPr.HasRows)
                {
                    while (czytPr.Read())
                    {
                        WyszukajPracBox.Items.Add(czytPr[0].ToString());
                    }
                }
                czytPr.Close();
            }
            catch (Exception ex)
            {
                string blad = string.Format("Wystąpił błąd.\n{0}", ex.Message);
                MessageBox.Show(blad, "Blad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                FormularzLogIn.pol.Close();
            }
        }
        public void WyszukajPrac()
        {
            MySqlDataReader czytSzukaniePracownika;
            if (FormularzLogIn.pol.State == ConnectionState.Closed)
                FormularzLogIn.pol.Open();
            string sqlSzukaniePracownika = String.Format("SELECT DISTINCT P.Tytul,CONCAT(O.Imiona,' ',O.Nazwisko),O.Email,P.WWW,P.NrTel,P.Pokoj,J.NazwaJednostki,S.NazwaStan FROM Osoby O INNER JOIN Pracownicy P ON P.IdPrac=O.Identyfikator INNER JOIN Jednostki J ON J.IdJednostki=P.Jednostka INNER JOIN Stanowiska S ON S.IdStan=P.Stanowisko WHERE CONCAT(O.Nazwisko,' ' ,O.Imiona)='{0}'", WyszukajPracBox.SelectedItem);
            MySqlCommand SzukaniePracKom = new MySqlCommand(sqlSzukaniePracownika, FormularzLogIn.pol);
            czytSzukaniePracownika = SzukaniePracKom.ExecuteReader();
            listaWyszukiwanychPracownikow.Items.Clear();
            if (czytSzukaniePracownika.HasRows)
            {
                while (czytSzukaniePracownika.Read())
                {
                    listaWyszukiwanychPracownikow.Items.Add(string.Format("{0} {1}     {2}     {3}     {4}     {5}     {6}", czytSzukaniePracownika[0].ToString(), czytSzukaniePracownika[1].ToString(), czytSzukaniePracownika[2].ToString(), czytSzukaniePracownika[3].ToString(), czytSzukaniePracownika[4].ToString(), czytSzukaniePracownika[5].ToString(), czytSzukaniePracownika[6].ToString()));
                }

            }
            czytSzukaniePracownika.Close();
        }
        public void WyszukajSt()
        {
            MySqlDataReader czytSzukanieStudenta;
            if (FormularzLogIn.pol.State == ConnectionState.Closed)
                FormularzLogIn.pol.Open();
            string sqlSzukanieStudenta = String.Format("SELECT DISTINCT S.NrIndeksu,CONCAT(O.Imiona,' ',O.Nazwisko),O.Email,S.ProgramStudiow,P.Kierunek,P.Specjalnosc,P.TrybStudiow,P.RodzajStudiow FROM Osoby O INNER JOIN Studenci S ON S.NrIndeksu=O.Identyfikator INNER JOIN Programy P ON P.IdProgramu=S.ProgramStudiow WHERE CONCAT(O.Nazwisko,' ' ,O.Imiona)='{0}'", WyszukajStBox.SelectedItem);
            MySqlCommand SzukanieStudKom = new MySqlCommand(sqlSzukanieStudenta, FormularzLogIn.pol);
            czytSzukanieStudenta = SzukanieStudKom.ExecuteReader();
            listaWyszukiwanychStudentow.Items.Clear();
            if (czytSzukanieStudenta.HasRows)
            {
                while (czytSzukanieStudenta.Read())
                {
                    listaWyszukiwanychStudentow.Items.Add(string.Format("{0}    {1}      {2}      {3}      {4}      {5}       studia {6} {7}", czytSzukanieStudenta[0].ToString(), czytSzukanieStudenta[1].ToString(), czytSzukanieStudenta[2].ToString(), czytSzukanieStudenta[3].ToString(), czytSzukanieStudenta[4].ToString(), czytSzukanieStudenta[5].ToString(), czytSzukanieStudenta[6].ToString(), czytSzukanieStudenta[7].ToString()));
                }

            }
            czytSzukanieStudenta.Close();
        }
        private void PobierzPlan_btn_Click_1(object sender, EventArgs e)
        {
            Pobierz();
        }

        private void WyszukajStBTN_Click(object sender, EventArgs e)
        {
            WyszukajSt();
        }

        private void WyszukajPracBTN_Click(object sender, EventArgs e)
        {
            WyszukajPrac();
        }
    }
}
