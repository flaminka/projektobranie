using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKT_CSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // działanie opcji  z zakładki Plik/Nowa ankieta/Szkoła - robię to w oknie głównym
        private void szkołaToolStripMenuItem_Click(object sender, EventArgs e)
        {
               // nadaję funckcjonalność opcji Szkoła w Nowa Ankieta - otwieranie okna Szkoła
               Szkoła newMDIChild = new Szkoła();
               // ustawiam obecne okno (Form1 jako okno główne, w którym wyświetlę okno Szkoła
               newMDIChild.MdiParent = this;
               // wyświetlam nowe okno w oknie głównym
               newMDIChild.Show();
            
        }

    
        // działanie opcji  z zakładki Plik/Nowa ankieta/Praca - robię to jako oddzielne okno a nie w oknie głównym
        private void pracaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //zapobiegam kilkukrotnemu otwarciu tego samego okna; zmodyfikowana wersja kodu z 
            //www.c-sharpcorner.com/UploadFile/kirtan007/how-to-prevent-multiple-instances-of-child-form-in-mdi-windows-form-application/
            bool OknoOtwarte = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "Praca") 
                {
                    OknoOtwarte = true;
                    f.Focus(); //przełącza na otwarte okno
                    break;
                }
            }

            if (OknoOtwarte == false)
            {
                Praca praca1 = new Praca();
                praca1.Show();
            }
            
        }
    }
}
