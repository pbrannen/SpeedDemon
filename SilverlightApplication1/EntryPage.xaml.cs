/*
* Written by Patrick Brannen for Dealia LLC, Speed Demon, a timed test learning application for elementary school children
*     Copyright (C) 2009 Dealia LLC
*
*     This program is free software: you can redistribute it and/or modify
*     it under the terms of the GNU General Public License as published by
*     the Free Software Foundation, either version 3 of the License, or
*     (at your option) any later version.
*
*     This program is distributed in the hope that it will be useful,
*     but WITHOUT ANY WARRANTY; without even the implied warranty of
*     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
*     GNU General Public License for more details.
*
*     You should have received a copy of the GNU General Public License
*     along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SilverlightApplication1
{
    public partial class EntryPage : UserControl
    {
        public EntryPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App app = (App)Application.Current;

            //comboboxes
            //operation
            //time (min vs sec)
            //orientation
            //mode

            try
            {
                if (((ComboBoxItem)comboBoxOperation.SelectedItem).Content.Equals("Multiplication"))
                    app.SelectedOp = App.Operation.Multiplication;
                else if (((ComboBoxItem)comboBoxOperation.SelectedItem).Content.Equals( "Addition"))
                    app.SelectedOp = App.Operation.Addition;
                else if (((ComboBoxItem)comboBoxOperation.SelectedItem).Content.Equals("Subtraction"))
                    app.SelectedOp = App.Operation.Subtraction;
                else if (((ComboBoxItem)comboBoxOperation.SelectedItem).Content.Equals("Division"))
                    app.SelectedOp = App.Operation.Division;

                if (((ComboBoxItem)comboBoxTime.SelectedItem).Content.Equals("Minutes"))
                    app.TimeInSecs = int.Parse(textBoxTime.Text) * 60;
                else if (((ComboBoxItem)comboBoxTime.SelectedItem).Content.Equals("Seconds"))
                    app.TimeInSecs = int.Parse(textBoxTime.Text);

                app.Orientation = comboBoxOrientation.SelectedItem.ToString();

                app.Mode = comboBoxMode.SelectedItem.ToString();

                app.By = int.Parse(textBoxBy.Text);

                app.NumOProbs = int.Parse(textBoxNumberOfProblems.Text);
            }
            catch (FormatException)
            {
                // warn user that numeric fields have bad chars
            }

            App.Navigate(new GetReadyPage());
        }


    }
}
