﻿using System;
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

namespace AcademiaDoZe
{
    /// <summary>
    /// Interação lógica para CadastroAlunosControl.xam
    /// </summary>
    public partial class CadastroAlunosControl : UserControl
    {
        public CadastroAlunosControl()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Console.Write("oi");
        }
    }
}
