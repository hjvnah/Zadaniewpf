﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zadaniewpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    const int DLUGOSC_HASLA = 10;
    const string ZNAKI_SPECJALNE = "!@#$$%^&*())_+-=";
    bool czyKoniec = false;
    char znak;
    string haslo = "";

    int losujSpecjalny()
    {
        Random rand = new Random();
        return rand.Next(0, ZNAKI_SPECJALNE.Length);
    }

    while(!czyKoniec){

    }



    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}