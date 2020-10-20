using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FirstGUI
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()     //das ist wie unsere Main in Konsolenapplikationen
        {
            InitializeComponent();


            ////// WAS WIR IN DER XAML Schreiben wird intern als CodeBehind Übersetzt und ausgeführt!!
            ////// Aber wenn wir es nur via CodeBehind setzen, dann ist es NICHT VERFÜGBAR in der xaml Entwurf view!!
            ////// XAML ist sehr Praktisch um alles sichtbar und verstandbar darstellen und Programmieren!!

            //////wir setzen ein grid:
            ////Grid grid = new Grid();
            ////this.Content = grid;
            ////// so das grid ist der inhalt von unsere MainWindow.

            //////mit einem Button
            ////Button btn = new Button();
            ////btn.FontSize = 26;
            //////"Herausforderung" Button Größe korrigieren
            ////btn.Height = 100;
            ////btn.Width = 250;

            //////und ein WrapPanel
            ////WrapPanel wrapPanel = new WrapPanel();

            //////textblöcke 
            ////TextBlock txt = new TextBlock();
            ////txt.Text = "Multi";
            ////txt.Foreground = Brushes.Blue;

           
            ////// textblöcke als Inhälte von WrapPanel setzen
            ////wrapPanel.Children.Add(txt);
            ////// "Herausforderung" Texte vervollständigen
            ////// wir überschreiben mit "new" unsere txt TextBlock, 
            ////// anstatt txt2 und txt3 zu verbrauchen.... BEIDE GEHEN.
            ////txt = new TextBlock();
            ////txt.Text = "Color";
            ////txt.Foreground = Brushes.Red;

            ////wrapPanel.Children.Add(txt);

            ////txt = new TextBlock();
            ////txt.Text = "Button";
            ////txt.Foreground = Brushes.Green;

            ////wrapPanel.Children.Add(txt);

            ////// Der Inhalt von Button ist unser wrapPanel..
            ////btn.Content = wrapPanel;

            ////// und Inhalt von unser grid hinzufügen der Button.
            ////grid.Children.Add(btn);

        }

        //Generierter event wenn click auf Button mit Sender und Argumente e...
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Direkter Event(Ereigniss) \nDanke fürs klicken.");
            // hier ein Breakpoint setzen, dann ausführen und button drücken.
            // es wird hier anhalten, dann in Auto Fenster, unter Wert für "sender" ganz rechts die Lupe auswählen und WPF Tree Visualizer auswählen!
            // es zeigt die ganze Hierarchie bis dieses Objekt:
            // VISUELLER BAUM zeigt Graphisch wo dieses Objekt liegt. NUR DIE "LINIE" zu unsere Objekt, nicht alle "Branches" so zu sagen, nur unsere...
            // da sind alle Objekte dargestellt, auch wenn sie unsichtbar sind. auch alle die default gesetzten Eigenschaften werden angezeigt.
            // EIGENSCHAFTEN VON: Button (in diesem fall) zeigt ALLE die egenschaften von dieses Button oder das ausgewählte Objekt vom Button. Kann man nicht direkt ändern

            // Das ist ein Standard Event, das am meistens benutzt wird
        }

        private void Button_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Bubbling Event(Ereigniss) \nButton wurde losgelassen.");
            // wie eine Blase die nach oben geht... in der Visual Tree!!
            // es schickt der Event nach oben, immer weiter bis irgendeine Stufe es handeln kann...
            // wenn es nirgendwo behandelt ist, wird es verloren gehen... muss man anpassen in diesem fall.
            // NICHT MEHR ERKLÄRT!!!!!
        }

        private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Tunneling Event(Ereigniss) \nButton L/R wurde losgelassen.");
            // Preview = Tunneling, es auchtet drauf waas es passieren wird...
            // es schickt der Event nach unten in TreeView
            // WAS SOWAS FÜR UNS BEDEUTET WIRD NICHT RICHTIG ERKLÄRT...
        }

        /// <summary>
        /// EVENTS: Routed Events - Direct, am meistens benutzt und einfacher zu  nachvollziehen
        ///         Bubbling      - wie eine Blase die nach oben geht... in der Visual Tree!!
        //                          es schickt der Event nach oben, immer weiter bis irgendeine Stufe es handeln kann...
        //                          wenn es nirgendwo behandelt ist, wird es verloren gehen... muss man anpassen in diesem fall.
        ///         Tunneling     - Preview = Tunneling, es auchtet drauf waas es passieren wird...
        ///                         es schickt der Event nach unten in TreeView...
        /// ZUSAMMENFASSUNG - Einfache Direct Events verwenden!!
        /// </summary>

        private void Button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Tunneling Event(Ereigniss) \nButton Left wurde angeclickt.");
        }

        private void Button_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Tunneling Event(Ereigniss) \nButton wurde Right losgelassen.\nRight Mouse Clicks should display more info");
        }

        //// selber erstellt Event-Methode, brauchen immer sender und RoutedEventArgs. Damit wird zur auswahl in XAML IntelliSense direkt angezeigt.
        //private void MeineEigeneKlickMethode(object sender, RoutedEventArgs rea)
        //{

        //}
    }
}


    // Wir versuchen die Buttons usw Programatisch zu erstellen.
    //< !--eXtensible Application Markup Language -->
    //<!--<Grid>
    //    --><!--<TextBox  HorizontalAlignment="Left" Height="23" Margin="50,50,0,0" TextWrapping="Wrap" Text="Hey Hallo! Ich bin ein TextBox! Gar kein Label oder so was...!" VerticalAlignment="Top" Width="390" />-->
    //    <!--<TextBlock HorizontalAlignment="Left" Margin="50,100,0,0" TextWrapping="Wrap" Text="HALLO ANDRES..." VerticalAlignment="Top"/>

    //    <Button Content="Dies ist ein Button" HorizontalAlignment="Left" Margin="50,150,0,0" VerticalAlignment="Top" Width="150"/>
    //    <Button Content="click mich!" Height="40" Width="100"  FontSize="16" />-->        
    //    <!--Um Code-Snippets oder wie auch immer zu verwenden, einfach der > eingeben, damit wird automatisch das Objekt schluss selber generiert! SEHR PRAKTISCH!!--><!--
    //    <Button>
    //        <Button.FontSize>32</Button.FontSize>
    //        <Button.Width>250</Button.Width>
    //        <Button.Height>100</Button.Height>
    //        <Button.Content>
    //            <WrapPanel>
    //                --><!--wrappanel versuch die Inhälte nebeninander von links zu rechts zu zeigen 
    //                und wenn es nicht mehr passt in eine neue Linie!--><!--
    //                <TextBlock Foreground="Blue" Background="Gray" >Multi</TextBlock>
    //                --><!--Vordergrund, bzw. Schriftfarbe--><!--
    //                <TextBlock Foreground="Red" Background="Gray" >Color</TextBlock>
    //                <TextBlock Foreground="green" Background="Gray" >Button</TextBlock>
    //            </WrapPanel>
    //        </Button.Content>
    //    </Button>
    //</Grid>-->
