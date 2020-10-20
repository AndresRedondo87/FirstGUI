using System;
using System.Collections.Generic;   // automatisch hinzufügen wird benötigt.
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGUI
{
    public class Sum : INotifyPropertyChanged // nicht vergessen es public zu machen sonst geht es gar nicht
    {
        private string num1;
        private string num2;
        private string result;

        public string Num1
        {
            get { return num1; }
            set 
            {
                int number;
                bool res = int.TryParse(value, out number);
                if (res) num1 = value;  //hiermit werden alle nicht gültige werte rausgefiltert, bzw gar nicht übernommen und in das alte wert bleibt da.
                //else nichts machen, kein Wert übernehmen einfach, den Wert bleibt wie er  vorher war.
                OnPropertyChanged("Num1");// wenn Num1 geändert wird, wird der INotifyPropertyChanged gerufen, bzw Property geändert...
                OnPropertyChanged("Result");    //unsere result meldet es hat sich geändert bzw. es mus sich was ändern

            }
        }

        public string Num2
        {
            get { return num2; }
            set
            {
                int number;
                bool res = int.TryParse(value, out number);
                if (res) num2 = value;
                //else nichts machen
                OnPropertyChanged("Num2");
                OnPropertyChanged("Result");    //unsere result meldet es hat sich geändert bzw. es mus sich was ändern

            }
        }// einfach dupliziert für num2

        public string Result
        {
            //get { return result; } //hier wollen wir was cooles machen.
            get
            {
                int res = int.Parse(Num1) + int.Parse(Num2);
                // hier wird Parse immer funktionieren, kein Tryparse nötig, es war schon in num1&2.
                return res.ToString();  //der int wieder in string umgewandelt
            }
            set //wenn wir versuchen den resultat zu ändern, bekommen wir wieder die summe berechnet. Result zu setten wurde hier kein Sinn ergeben.
            {
                int res = int.Parse(Num1) + int.Parse(Num2);    
                result = res.ToString();
                OnPropertyChanged("Result");    //unsere result meldet es hat sich geändert bzw. es mus sich was ändern
            }
        }// einfach dupliziert für result auch


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            // was wenn property leer ist??? um sicher zu gehen!
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
