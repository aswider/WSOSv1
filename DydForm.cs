using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSOS_v0._1
{
    public partial class DydForm : Form,ISzukanie
    {
        public DydForm()
        {
            InitializeComponent();
        }
        string login = FormularzLogIn.identity;
        //Zmiana bajtow ktore odczytamy z bazy na zdjecie
        public Image PlanJakoImage(byte[] plan)
        {
            MemoryStream mstream = new MemoryStream(plan);
            return Image.FromStream(mstream);
        }
        private void WylogujPDBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void PobierzDane()
        {
            try
            {
                if (FormularzLogIn.pol.State == ConnectionState.Closed)
                    FormularzLogIn.pol.Open();

                //Pobranie identyfikatora potrzebnego w kolejnym zapytaniu
                string pobierzIdSql = string.Format("SELECT Identyfikator from Osoby WHERE Login='{0}'", login);
                MySqlCommand pobierzIdKom = new MySqlCommand(pobierzIdSql, FormularzLogIn.pol);
                string jakieId = Convert.ToString(pobierzIdKom.ExecuteScalar());

                //Pobranie danych nt wystawionych przez prowadzącego ocen
                string sqlWystOceny = String.Format("SELECT DISTINCT O.Data,P.NazwaPrzedmiotu as Przedmiot, O.Ocena, CONCAT(Os.Nazwisko,' ',Os.Imiona) AS Student, O.Uwagi From Przedmioty P INNER JOIN Ocenianie O ON P.IdPrzedmiotu=O.Przedmiot INNER JOIN Osoby Os ON O.NrIndeksu=Os.Identyfikator WHERE O.Prowadzacy = '{0}'", jakieId);
                MySqlCommand WystOcenyKom = new MySqlCommand(sqlWystOceny, FormularzLogIn.pol);
                MySqlDataReader czytoWOceny = WystOcenyKom.ExecuteReader();
                OcenyWListBox.Items.Clear();
                if (czytoWOceny.HasRows)
                {
                    while (czytoWOceny.Read())
                    {
                        OcenyWListBox.Items.Add(string.Format("{0}      {1}        {2}        {3}         {4}", czytoWOceny[0].ToString(), czytoWOceny[1].ToString(), czytoWOceny[2].ToString(), czytoWOceny[3].ToString(), czytoWOceny[4].ToString()));
                    }

                }
                czytoWOceny.Close();

                //Pobranie planu zajęć
                MySqlDataReader czytplanD;
                string sqlplanD = String.Format("SELECT Plan FROM Osoby WHERE Login='{0}'", FormularzLogIn.identity);
                MySqlCommand PlanKom = new MySqlCommand(sqlplanD, FormularzLogIn.pol);
                czytplanD = PlanKom.ExecuteReader();
                if (czytplanD.HasRows)
                {
                    while (czytplanD.Read())
                    {
                        planPictureD.Image = PlanJakoImage((byte[])czytplanD[0]);
                    }

                }
                czytplanD.Close();

                //Pobranie informacji o studentach do ComboBoxa
                string pobierzStSql = String.Format("SELECT DISTINCT CONCAT(Nazwisko,' ',Imiona) FROM Osoby Os INNER JOIN Studenci S ON S.NrIndeksu=Os.Identyfikator");
                MySqlCommand pobierzStKom = new MySqlCommand(pobierzStSql, FormularzLogIn.pol);
                MySqlDataReader czytSt = pobierzStKom.ExecuteReader();
                if (czytSt.HasRows)
                {
                    while (czytSt.Read())
                    {
                        StudentDBox.Items.Add(czytSt[0].ToString());
                        WyszukajStBox.Items.Add(czytSt[0].ToString());

                    }

                }
                czytSt.Close();

                //Pobranie informacji o pracownikach do ComboBoxa
                string pobierzPrsql = String.Format("SELECT CONCAT(Nazwisko,' ',Imiona)FROM Osoby WHERE Haslo='pracownik'");
                MySqlCommand pobierzPrKom = new MySqlCommand(pobierzPrsql,FormularzLogIn.pol);
                MySqlDataReader czytPr = pobierzPrKom.ExecuteReader();
                if (czytPr.HasRows)
                {
                    while(czytPr.Read())
                    {
                        WyszukajPracBox.Items.Add(czytPr[0].ToString());
                    }
                }
                czytPr.Close();
                //Pobieranie informacji o przedmiotach do CombBoxa
                string pobierzPrzSql = String.Format("SELECT NazwaPrzedmiotu from Przedmioty");
                MySqlCommand pobierzPrzKom = new MySqlCommand(pobierzPrzSql, FormularzLogIn.pol);
                MySqlDataReader czytPrz = pobierzPrzKom.ExecuteReader();
                if (czytPrz.HasRows)
                {
                    while (czytPrz.Read())
                    {
                        PrzedmiotDBox.Items.Add(czytPrz[0].ToString());
                    }

                }
                czytPrz.Close();

            }
            catch (Exception ex)
            {
                string blad = string.Format("Blad podczas pobierania danych:\n{0}", ex.Message);
                MessageBox.Show(blad, "Blad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                FormularzLogIn.pol.Close();
            }
        }
        private void PobierzDanePDBTN_Click(object sender, EventArgs e)
        {
            PobierzDane();
        }
        void DodajOcene()
        {
            if (FormularzLogIn.pol.State == ConnectionState.Closed)
                FormularzLogIn.pol.Open();
            //Znalezienie identyfikatora wybranego przedmiotu
            string jakiPrzSql = String.Format("SELECT IdPrzedmiotu FROM Przedmioty WHERE NazwaPrzedmiotu='{0}'", PrzedmiotDBox.SelectedItem);
            MySqlCommand jakiPrzKom = new MySqlCommand(jakiPrzSql, FormularzLogIn.pol);
            string jakiPrzId = Convert.ToString(jakiPrzKom.ExecuteScalar());

            //Znalezienie identyfikatora wybranego studenta
            string jakiStSql = String.Format("SELECT Identyfikator FROM Osoby WHERE CONCAT(Nazwisko,' ',Imiona)='{0}'", StudentDBox.SelectedItem);
            MySqlCommand jakiStKom = new MySqlCommand(jakiStSql,FormularzLogIn.pol);
            string jakiStId = Convert.ToString(jakiStKom.ExecuteScalar());

            //Znalezienie identyfikatora prowadzacego
            string jakiProSql = String.Format("SELECT Identyfikator FROM Osoby WHERE Login='{0}'",login);
            MySqlCommand jakiProKom = new MySqlCommand(jakiProSql,FormularzLogIn.pol);
            string jakiProId = Convert.ToString(jakiProKom.ExecuteScalar());

            //Zapytanie dodające ocenę do bazy
            string dodajOcSql = String.Format("INSERT INTO Ocenianie(Ocena,NrIndeksu,Prowadzacy,Przedmiot,Data,Uwagi)VALUES('{0}',{1},{2},{3},'{4}','{5}')", OcenaDBox.SelectedItem,jakiStId,jakiProId,jakiPrzId,DateTime.Now.Date.ToString(),UwagiDBox.Text);
            MySqlCommand dodajOcKom = new MySqlCommand(dodajOcSql,FormularzLogIn.pol);
            dodajOcKom.ExecuteNonQuery();
        }
        void EdytujOcene()
        {
            if (FormularzLogIn.pol.State == ConnectionState.Closed)
                FormularzLogIn.pol.Open();
            //Znalezienie identyfikatora wybranego przedmiotu
            string jakiPrzSql = String.Format("SELECT IdPrzedmiotu FROM Przedmioty WHERE NazwaPrzedmiotu='{0}'", PrzedmiotDBox.SelectedItem);
            MySqlCommand jakiPrzKom = new MySqlCommand(jakiPrzSql, FormularzLogIn.pol);
            string jakiPrzId = Convert.ToString(jakiPrzKom.ExecuteScalar());

            //Znalezienie identyfikatora wybranego studenta
            string jakiStSql = String.Format("SELECT Identyfikator FROM Osoby WHERE CONCAT(Nazwisko,' ',Imiona)='{0}'", StudentDBox.SelectedItem);
            MySqlCommand jakiStKom = new MySqlCommand(jakiStSql, FormularzLogIn.pol);
            string jakiStId = Convert.ToString(jakiStKom.ExecuteScalar());

            //Znalezienie identyfikatora prowadzacego
            string jakiProSql = String.Format("SELECT Identyfikator FROM Osoby WHERE Login='{0}'", login);
            MySqlCommand jakiProKom = new MySqlCommand(jakiProSql, FormularzLogIn.pol);
            string jakiProId = Convert.ToString(jakiProKom.ExecuteScalar());

            //Zapytanie edytujące oceny w bazie
            string dodajOcSql = String.Format("UPDATE ocenianie SET Ocena='{0}',NrIndeksu={1},Prowadzacy={2},Przedmiot={3},Data='{4}',Uwagi='{5}' WHERE NrIndeksu={6}", OcenaDBox.SelectedItem, jakiStId, jakiProId, jakiPrzId, DateTime.Now.Date.ToString(), UwagiDBox.Text, jakiStId);
            MySqlCommand dodajOcKom = new MySqlCommand(dodajOcSql, FormularzLogIn.pol);
            dodajOcKom.ExecuteNonQuery();
            PobierzDane();
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
                    listaWyszukiwanychPracownikow.Items.Add(string.Format("{0} {1} - {2} - {3} - {4} - {5} - {6}", czytSzukaniePracownika[0].ToString(), czytSzukaniePracownika[1].ToString(), czytSzukaniePracownika[2].ToString(), czytSzukaniePracownika[3].ToString(),czytSzukaniePracownika[4].ToString(),czytSzukaniePracownika[5].ToString(),czytSzukaniePracownika[6].ToString()));
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
                    listaWyszukiwanychStudentow.Items.Add(string.Format("{0} - {1} - {2} - {3} - {4} - {5} - studia {6} {7}", czytSzukanieStudenta[0].ToString(), czytSzukanieStudenta[1].ToString(), czytSzukanieStudenta[2].ToString(), czytSzukanieStudenta[3].ToString(), czytSzukanieStudenta[4].ToString(), czytSzukanieStudenta[5].ToString(), czytSzukanieStudenta[6].ToString(),czytSzukanieStudenta[7].ToString()));
                }

            }
            czytSzukanieStudenta.Close();
        }
        private void DodajOcBTN_Click(object sender, EventArgs e)
        {
            DodajOcene();
        }
        private void WyszPracBTN_Click(object sender, EventArgs e)
        {
            WyszukajPrac();
        }
        private void WyszStudBTN_Click(object sender, EventArgs e)
        {
            WyszukajSt();
        }
        private void EdytujOcBTN_Click(object sender, EventArgs e)
        {
            EdytujOcene();
        }

        private void WyszukajStBTN_Click(object sender, EventArgs e)
        {

        }

        private void WyszukajPracBTN_Click(object sender, EventArgs e)
        {

        }

       
    }
}
