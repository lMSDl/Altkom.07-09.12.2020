﻿using ArchitecturalPatterns.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ArchitecturalPatterns.Views
{
    /// <summary>
    /// Interaction logic for MvcView.xaml
    /// </summary>
    public partial class MvcView : Page
    {
        private readonly Model _model;

        public MvcView()
        {
            InitializeComponent();
            _model = new Model();
        }

        private void Button_Save(object sender, RoutedEventArgs e)
        {
            _model.Value = TextBox_Input.Text;
            Label_Value.Content = _model.Value;
        }
        private void Button_Load(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text = _model.Value;
        }
    }
}
