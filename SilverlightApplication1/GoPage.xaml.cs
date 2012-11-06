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
using System.Windows.Navigation;

namespace SilverlightApplication1
{
    public partial class GoPage : Page
    {
        public GoPage()
        {
            InitializeComponent();
        }

        Engine engine;
        bool done = false;
        

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

        }

        private void Storyboard1_Completed(object sender, EventArgs e)
        {
            this.textBlockQuestion.Text = "Time :(";
            App app = (App)App.Current;
            this.textBlockInfo.Text = string.Format("{0} questions correctly answered in {1} seconds, Avg: {2}", engine.Count, app.TimeInSecs, Math.Round(new Decimal(app.TimeInSecs) / new Decimal(engine.Count) , 2));
            this.done = true;
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            engine = new Engine();
            App app = (App)App.Current;
            engine.MaxCount = app.NumOProbs;
            engine.Operation = app.SelectedOp;
            engine.Constant = app.By;
            this.textBlockQuestion.Text = engine.NextQuestion();
            this.Storyboard1.Duration = new Duration(new TimeSpan(0, 0, app.TimeInSecs));
            this.Storyboard1.Begin();
        }

        private void LayoutRoot_KeyDown(object sender, KeyEventArgs e)
        {
            if (!done)
            {
                if (e.Key == Key.Back)
                {
                    if (this.textBlockAnswer.Text.Length > 0)
                        this.textBlockAnswer.Text = this.textBlockAnswer.Text.Substring(0, this.textBlockAnswer.Text.Length - 1);

                    textBlockInfo.Text = string.Empty;
                }
                else
                {
                    int num = -1;

                    switch (e.Key)
                    {
                        case Key.NumPad0:
                            num = 0;
                            break;

                        case Key.NumPad1:
                            num = 1;
                            break;

                        case Key.NumPad2:
                            num = 2;
                            break;

                        case Key.NumPad3:
                            num = 3;
                            break;

                        case Key.NumPad4:
                            num = 4;
                            break;

                        case Key.NumPad5:
                            num = 5;
                            break;

                        case Key.NumPad6:
                            num = 6;
                            break;

                        case Key.NumPad7:
                            num = 7;
                            break;

                        case Key.NumPad8:
                            num = 8;
                            break;

                        case Key.NumPad9:
                            num = 9;
                            break;

                        case Key.D0:
                            num = 0;
                            break;

                        case Key.D1:
                            num = 1;
                            break;

                        case Key.D2:
                            num = 2;
                            break;

                        case Key.D3:
                            num = 3;
                            break;

                        case Key.D4:
                            num = 4;
                            break;

                        case Key.D5:
                            num = 5;
                            break;

                        case Key.D6:
                            num = 6;
                            break;

                        case Key.D7:
                            num = 7;
                            break;

                        case Key.D8:
                            num = 8;
                            break;

                        case Key.D9:
                            num = 9;
                            break;

                        default:
                            displayHint();
                            break;
                    }

                    if (num != -1)
                    {
                        this.textBlockAnswer.Text = this.textBlockAnswer.Text + num;
                        textBlockInfo.Text = string.Empty;
                    }


                }

                if (engine.checkAnswer(this.textBlockAnswer.Text))
                {
                    this.Storyboard2.Begin();
                }

                
            }
        }


        private void displayHint()
        {
            textBlockInfo.Text = "Use numbers and Backspace keys only!";
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new EntryPage());
        }

        private void Storyboard2_Completed(object sender, EventArgs e)
        {
            this.textBlockQuestion.Opacity = 100;
            this.textBlockAnswer.Opacity = 100;
            this.textBlockQuestion.Text = engine.NextQuestion();
            this.textBlockAnswer.Text = string.Empty;

            if (this.textBlockQuestion.Text == Engine.EngineDone)
            {
                this.Storyboard1.Stop();
                this.textBlockInfo.Text = string.Format("Level completed in {0} seconds", this.Storyboard1.GetCurrentTime().TotalSeconds);
            }
        }

    }
}
