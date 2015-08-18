// Copyright 2011 Denis Markelov
// This code is distributed under Microsoft Public License 
// (for details please see \docs\Ms-PL)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Reflection;
using AssemblyVisualizer.Infrastructure;
using System.Windows.Media.Animation;

namespace AssemblyVisualizer.About
{    
    partial class AboutWindow : Window
    {    
        public AboutWindow()
        {
            InitializeComponent();
            var version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            txtVersion.Text = version;

            escapeBinding.Command = new DelegateCommand(Close);
        }

        private void SourcesClickHandler(object sender, RoutedEventArgs e)
        {           
            GlobalServices.NavigateToSources();
        }

        private void AuthorClickHandler(object sender, RoutedEventArgs e)
        {
            GlobalServices.NavigateToAuthor();
        }
    }
}
