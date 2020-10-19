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


            // WAS WIR IN DER XAML Schreiben wird intern als CodeBehind Übersetzt und ausgeführt!!
            // Aber wenn wir es nur via CodeBehind setzen, dann ist es NICHT VERFÜGBAR in der xaml Entwurf view!!
            // XAML ist sehr Praktisch um alles sichtbar und verstandbar darstellen und Programmieren!!

            //wir setzen ein grid:
            Grid grid = new Grid();
            this.Content = grid;
            // so das grid ist der inhalt von unsere MainWindow.

            //mit einem Button
            Button btn = new Button();
            btn.FontSize = 26;
            //"Herausforderung" Button Größe korrigieren
            btn.Height = 100;
            btn.Width = 250;

            //und ein WrapPanel
            WrapPanel wrapPanel = new WrapPanel();

            //textblöcke 
            TextBlock txt = new TextBlock();
            txt.Text = "Multi";
            txt.Foreground = Brushes.Blue;

           
            // textblöcke als Inhälte von WrapPanel setzen
            wrapPanel.Children.Add(txt);
            // "Herausforderung" Texte vervollständigen
            // wir überschreiben mit "new" unsere txt TextBlock, 
            // anstatt txt2 und txt3 zu verbrauchen.... BEIDE GEHEN.
            txt = new TextBlock();
            txt.Text = "Color";
            txt.Foreground = Brushes.Red;

            wrapPanel.Children.Add(txt);

            txt = new TextBlock();
            txt.Text = "Button";
            txt.Foreground = Brushes.Green;

            wrapPanel.Children.Add(txt);

            // Der Inhalt von Button ist unser wrapPanel..
            btn.Content = wrapPanel;

            // und Inhalt von unser grid hinzufügen der Button.
            grid.Children.Add(btn);

        }


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
