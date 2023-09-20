using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Task01_Amr_Atef
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            //1.Variables
            //Introduction
            Console.WriteLine("1.Variables");

            Console.WriteLine("Welcome in our Application sir");
            Console.WriteLine("We are Offering Three Types of Disciplines");
            Console.WriteLine("A: Architecture");
            Console.WriteLine("B: Structural");
            Console.WriteLine("C: MEP");

            Console.WriteLine("---------------");

            //As Structural Engineering

            Console.WriteLine("As structural Engineer");
            Console.WriteLine("Enter the number of floors");
            //Write here Number of floors
            int floorNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Number of floors =" + floorNum + " Floors");

            Console.WriteLine("---------------");
           

            //As Architectural Engineering

            Console.WriteLine("As Architectural Engineer");
            //Enter Value for Each Variable please:
            Console.WriteLine("Enter Value for Each Variable please:");
            Console.WriteLine("Width=");
            Double Width = Double.Parse(Console.ReadLine());
            Console.WriteLine("Length=");
            Double Length = Double.Parse(Console.ReadLine());
            Console.WriteLine("Height=");
            Double Height = Double.Parse(Console.ReadLine());
            Console.WriteLine("Width=" + Width + "m");
            Console.WriteLine("Length=" + Length + "m");
            Console.WriteLine("Height=" + Height + "m");

            Console.WriteLine("---------------");
            

            Console.WriteLine("As MEP Engineer");
            //Enter these Variables please
            Console.WriteLine("Enter these Variables please");
            Console.WriteLine("Pressure=");
            double Pressure = int.Parse(Console.ReadLine());
            Console.WriteLine("Pipe Length=");
            double pipeLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Pressure= " + Pressure + "Pa");
            Console.WriteLine("Pipe Length= " + pipeLength + "m");
            


            Console.WriteLine("---------------");
            Console.WriteLine("---------------");
            Console.WriteLine("---------------");

            //2.Data Types

            //As Structural Engineering

            Console.WriteLine("2.Data Types");
            Console.WriteLine("As structural Engineer");
            Console.WriteLine("Calculate Total Weight of steel beam");
            Console.WriteLine("Enter this variables please");
            Console.WriteLine("Beam Lenght (m) = ");
            Double beamLength = Double.Parse(Console.ReadLine());
            Console.WriteLine("Beam Weight(kg/m) = ");
            Double beamWeight = Double.Parse(Console.ReadLine());
            double bmTotalWeight = beamLength * beamWeight;
            Console.WriteLine("Beam Total Weight= " + bmTotalWeight + "kg");

            Console.WriteLine("---------------");
            //As Architectural Engineering
            Console.WriteLine("As Architectural Engineer");

            Console.WriteLine("Does the room accessible to disabled individuals?");
            bool DoesTheRoomAccess = bool.Parse(Console.ReadLine());
            if (DoesTheRoomAccess == true)
            {
                Console.WriteLine("Room accessible");
            }
            else
            {
                Console.WriteLine("Room Doesn't accessible");
            }
            //As MEP Engineering
            Console.WriteLine("---------------");
            Console.WriteLine("As MEP Engineer");
            Console.WriteLine("Please enter a character panel code");
            char panel = char.Parse(Console.ReadLine());
            Console.WriteLine("Panel code ="+ panel); 


            Console.WriteLine("---------------------");
            Console.WriteLine("---------------------");
            Console.WriteLine("---------------------");

            //3.Operators
            //As Architectural Engineering
            Console.WriteLine("3.Operators");

            Console.WriteLine("As Architectural Engineer");
            Console.WriteLine("To calculate total cost of room flooring");

            Console.WriteLine("Please Enter cost per unit area");

            double costPerUnitArea =double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Room total area");
            double roomArea = double.Parse(Console.ReadLine());
            double totalCost = costPerUnitArea * roomArea;
            Console.WriteLine("The total cost="+totalCost+" Pounds");


            Console.WriteLine("---------------------");
            //As Structural Engineering
            Console.WriteLine("As Structural Engineer");

            double Fcu = 25;
            double Fy = 360;

            Console.WriteLine("Please Enter Column Width");

            Double ColumnWidth =double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Column Depth");
            Double ColumnDepth = double.Parse(Console.ReadLine());

            Double Ac = ColumnWidth * ColumnDepth;
            Console.WriteLine("Ac ="+Ac);
            Console.WriteLine("As=0.01*Ac");
            Double As = 0.01 * Ac;
            Console.WriteLine("As="+As);
            Double Pu = 0.35 * Ac * Fcu + 0.67 * As * Fy;
            Console.WriteLine("Pu= "+Pu);

            Console.WriteLine("---------------");

            //As MEP Engineering

            Console.WriteLine("As MEP Engineer");
            Console.WriteLine("To Calculate the total watt");
            Console.WriteLine("Enter The Num of Lamps ");
            int lampNum=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Watt of Lamps (watt) ");
            int lampWatt  = int.Parse(Console.ReadLine());
            int totalWatt = lampNum * lampWatt;
            Console.WriteLine("Total lamp watt= "+ totalWatt);

            Console.WriteLine("Thank you for using our programming");
            Console.WriteLine("The End");
            //cscacxz

            Console.WriteLine();







        }
    }
}
