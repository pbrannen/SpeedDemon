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
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SilverlightApplication1
{
    public class Engine
    {
        int one;
        public static string EngineDone = "Done :)";

        public int One
        {
            get { return one; }
            set { one = value; }
        }
        int count = 1;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public int MaxCount { get; set; }
        public int Constant { get; set; }
        public App.Operation Operation { get; set; }

        public string NextQuestion()
        {
            Random r = new Random();
            int oldOne = One;
            
            
            if (Op() == "-")
            {
                while (oldOne == One)
                    One = r.Next(Constant + 1);
            }
            else
            {
                while (oldOne == One)
                    One = r.Next(11);
            }
            
            if (count++ > MaxCount)
                return EngineDone;
            else
                return string.Format("{0} {1} {2} = ", Constant, Op(), one);
            
        }

        private string Op()
        {
            string op = string.Empty;
            
            if (Operation == App.Operation.Multiplication)
            {
                op = "X";
            }
            else if (Operation == App.Operation.Addition)
            {
                op = "+";
            }
            else if (Operation == App.Operation.Subtraction)
            {
                op = "-";
            }
            else if (Operation == App.Operation.Division)
            {
                op = "÷";
            }


            return op;
        }

        public bool checkAnswer(string answer)
        {
            try
            {
                if (Operation == App.Operation.Multiplication)
                {
                    if (Constant * one == int.Parse(answer))
                        return true;
                }
                else if (Operation == App.Operation.Addition)
                {
                    if (Constant + one == int.Parse(answer))
                        return true;
                }
                else if (Operation == App.Operation.Subtraction)
                {
                    if (Constant - one == int.Parse(answer))
                        return true;
                }
                else if (Operation == App.Operation.Division)
                {
                    if (Constant / one == int.Parse(answer))
                        return true;
                }
            }
            catch (FormatException)
            {

            }

            return false;
        }
    }

    
}

