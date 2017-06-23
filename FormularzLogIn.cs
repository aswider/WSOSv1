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
    public partial class FormularzLogIn : Form
    {
        static public string pass;
        static public string identity;
        static public MySqlConnection pol;
        MySqlCommand komendarola;
        public FormularzLogIn()
        {
            InitializeComponent();
        }
        
        //Logowanie do bazy danych zawarte w metodzie przycisku Zaloguj
        //Blok try catch przechwyci błąd
        private void ZalogujBTN_Click(object sender, EventArgs e)
        {
            FormularzLogIn log = new FormularzLogIn();

            //Pobranie danych od użytkownika z TextBoxów
            pass = PasswordBoxN.Text;
            identity = LoginBox.Text;

            try
            {
                
                pol= new MySqlConnection("server=localhost;user="+identity+";password="+pass+";database=WSOS");
                pol.Open();

                //Zapytanie sprawdzajace jaki uzytkownik sie zalogowal(student,pracDydaktyczny,pracAdministracyjny)
                string sqlrola = String.Format("SELECT Rola FROM Osoby WHERE Osoby.Login='{0}'", identity);
                komendarola = new MySqlCommand(sqlrola, pol);
                string jakaRola = Convert.ToString(komendarola.ExecuteScalar());
                //Otwarcie formularza w zaleznosci od zalogowanego uzykownika

                switch (jakaRola)
                {
                    case "student":
                        StudentForm Stud = new StudentForm();
                        this.Hide();
                        Stud.ShowDialog();
                        break;
                    case "pracownik administracyjny":
                        AdminForm Admin = new AdminForm();
                        this.Hide();
                        Admin.ShowDialog();
                        break;
                    case "pracownik dydaktyczny":
                        DydForm Dyd = new DydForm();
                        this.Hide();
                        Dyd.ShowDialog();
                        break;
                    
                    default:
                        MessageBox.Show("Nie masz dostępu.", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
                //Ponowne wyświetlenie formularza logowania po zamknięciu ww. formularzy
                log.ShowDialog();
            }
            catch (Exception ex)
            {
                string blad = string.Format("Wystąpił błąd.\n{0}", ex.Message);
                MessageBox.Show(blad, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                pol.Close();
                
            }
        }
        //Metoda służąca do obsługi przycisku zamykającego program
        private void Zamknij_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

    }
}
