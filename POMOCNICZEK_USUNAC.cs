     //PRACA, chcę żeby w FORM1 pojawiła się wartość ustalona w PRaca
// a teraz chcę, zeby wartość z Form1 wpłynęła na tabela i potem znów na praca?


//tworzymy wydarzenie o argumentach klasy Moje_Arg_Wydarzen, które nazywamy UstawianieLiczbyKolumn
        public event EventHandler<Moje_Arg_Wydarzen> UstawianieLiczbyKolumn;

        //wyzwalacz wydarzenia UstawianieLiczbyKolumn będący metodą (o nazwie WyzwalaczUstawianieLiczbyKolumn), której argument to e z klasy Moje_Arg_Wydarzen
        protected virtual void WyzwalaczUstawianieLiczbyKolumn(Moje_Arg_Wydarzen e)
        {
            //jeśli wywołamy zdarzenie UstawianieLiczbyKolumn, to będzie ono działać na obiekcie wskazanym przez wskaźnik this (tu: Praca)
            // a jego argumentami (wydarzenia UstawianieLiczbyKolumn) będą e
            if (UstawianieLiczbyKolumn != null)
                UstawianieLiczbyKolumn(this, e); //TU CHYBA TABELA ma być
       }
     
        private void button1_Click(object sender, EventArgs e) //TY CHYBA TO MENU STRIP???
        {
           
            //tworzymy zmienną, której przypisujemy wartość właściwości Text obiektu textBox1
            int potrzebnaZmienna = IleGroupBoxwOknie(praca1);;
           //tworzymy egzemplarz klasy Moje_Arg_Wydarzen o nazwie nuea (czyli tworzymy argumenty dla wydarzenia
           Moje_Arg_Wydarzen nuea = new Moje_Arg_Wydarzen();
            //przypisujemy tym argumentom wartość
            nuea.LiczbaKolumn = potrzebnaZmienna;
            //wywołujemy metodę wyzwalającą wydarzenie (let it happen!)
            WyzwalaczUstawianieLiczbyKolumn(nuea);

          //  textBox1.Text =IleGroupBoxwOknie(ActiveForm).ToString();
        }


//FORM 1


 
            {
                Praca praca1 = new Praca();    
                //żeby uaktualniało się okno główne wydarzeniem z okna Praca
                //bierzemy wydarzenie UstawianieLiczbyKolumn okna praca1 (reprezentanta klasy Praca) i zatrudniamy gościa do radzenia sobie z tym wydarzeniem
                praca1.UstawianieLiczbyKolumn += new EventHandler<Moje_Arg_Wydarzen>(praca1_UstawianieLiczbyKolumn);
                praca1.Show();

            }
          


       }
        //co ma czemu przypisywać
        //zawsze gdy wyzwalane jest wydarzenie UstawianieLiczbyKolumn ta metoda wykonuje to wydarzenie i co robi określamy
        private void praca1_UstawianieLiczbyKolumn(object sender, Moje_Arg_Wydarzen e)
        {
              //jeśli są jakieś właściwości argumentów to przypisujemy Name (które niesie wartość z praca1) obiektowi  z okna Form1, tj. label1
            if (e != null && e.Name != null)
                IleKolumn = e.LiczbaKolumn;     
        }
       

