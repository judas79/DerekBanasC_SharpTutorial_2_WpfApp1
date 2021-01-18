﻿using Microsoft.Win32;
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

// Windows Presentation Foundation (WPF)
// is used to create graphical user interfaces
// of a traditional format or within a
// browser (XAML Browser Based App / XBAP)

// Using XAML eXtensible Application Markup Language
// you can create the UI using XML
// XAML allows you to define buttons, boxes,
// animations, 2d / 3d graphics and more

// Create a New Project -> Visual C# -> Windows
// Classic Desktop -> WPF App

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // for Send_Button_Click method
        string usersName = "";
        public MainWindow()
        {
            // Initializes and displays the window
            InitializeComponent();

            // You can set window properties in code
            this.Title = "Hello World";
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

        }

        // This method was generated from the MainWindow.xaml after typing MouseMove= 
        // in the  MainWindow.xaml, we then click on the 'new event handler' popup to generate our method
        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            // when mouse moves, display x and y coordinates in the Title, 'this' is the mouse
            Title = e.GetPosition(this).ToString();

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The app is Closing", "Close app");
            this.Close();
        }

        private void BtnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.ShowDialog();
        }

        private void BtnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.ShowDialog();
        }
        // comented out for Grid Panel portion of tutorial, only
        /*
        private void Send_Button_Click(object sender, RoutedEventArgs e)
        {
            usersName = UsersName.Text;
            MessageBox.Show($"Hello {usersName}");
            
        }
        */
    }
}
