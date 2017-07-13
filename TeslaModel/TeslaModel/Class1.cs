using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace TeslaModel
{

    public class TeslaVehicle
    {
        public int VehicleId, VehiclePrice, VehicleManufacture, VehicleEngine;
        public string VehicleName;
        public void GetValue()
        {
            Console.WriteLine("Enter Vehicle Id");
            VehicleId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Vehicle price");
            VehiclePrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Vehicle manufacture year");
            VehicleManufacture = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Vehicle Engine HorsePower");
            VehicleEngine = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Vehicle Name");
            VehicleName = (Console.ReadLine());
        }

    }
    public class TeslaCar : TeslaVehicle
    {
        public int carTypes, deleteType;
        public string CarType;
        public void CarTypeChoose()
        {
            Console.WriteLine("Please choose the appropriate car type\n1.Suv\n2.Sedan\n3.Hatchback\n");
            carTypes = Convert.ToInt16(Console.ReadLine());
        }
        public void TypeAssign()
        {
            if (carTypes == 1) CarType = "Suv";
            if (carTypes == 2) CarType = "Sedan";
            if (carTypes == 3) CarType = "Hatchback";
        }
        public void CarFileSave()
        {
            string path = "c:\\TeslaCar\\";
            path += VehicleId;
            path += "_";
            path += VehicleName;
            path += ".txt";
            //  Console.WriteLine(t);

            string VehicleInfo = "Vehicle Id - " + VehicleId + "," + "Vehicle Name - " + VehicleName + "," + "Vehicle Price - " + VehiclePrice + "," + "Vehicle Engine - " + VehicleEngine + "," + "Vehicle Manufacture - " + VehicleManufacture + "," + "Car Type - " + CarType;
            File.WriteAllText(path, VehicleInfo);
        }
        public void CarDelete()
        {
            Console.WriteLine("Choose how you want to delete:\n1.Id\n2.Name\n");
            deleteType = Convert.ToInt32(Console.ReadLine());
            if (deleteType == 1)
            {
                Console.WriteLine("Please enter the Id:\n");
                string deleteId = (Console.ReadLine());
                deleteId += "_*";
                string[] dirs = Directory.GetFiles(@"c:\TeslaCar", deleteId);
                foreach (string dir in dirs)
                {
                    File.Delete(dir);
                }
            }
            else
            {
                Console.WriteLine("Please enter the Name:\n");
                string deleteName = (Console.ReadLine()), deleteFind;
                deleteFind = "*";
                deleteFind += deleteName;
                deleteFind += ".txt";
                string[] dirs = Directory.GetFiles(@"c:\TeslaCar", deleteFind);
                int fileCounter = 1, fileChoosen, mark = 0;
                if (dirs.Length >= 1)
                {
                    Console.WriteLine("Please choose which specific Id to be deleted\n");
                    foreach (string dir in dirs)
                    {
                        Console.WriteLine(fileCounter + ".\t" + dir);
                        fileCounter++;
                    }
                    mark = 1;
                }
                fileChoosen = Convert.ToInt32(Console.ReadLine());
                fileCounter = 1;
                foreach (string dir in dirs)
                {
                    if (dirs.Length == 1) File.Delete(dir);
                    if (mark == 1 && fileCounter == fileChoosen) File.Delete(dir);
                    fileCounter++;
                }
            }
        }
    }
    public class TeslaTruck : TeslaVehicle
    {
        public int TruckTypes, deleteType;
        public string TruckType;
        public void TruckTypeChoose()
        {
            Console.WriteLine("Please choose the appropriate car type\n1.Van\n2.Pickup Truck\n3.Mobile Crane\n");
            TruckTypes = Convert.ToInt16(Console.ReadLine());
        }
        public void TypeAssign()
        {
            if (TruckTypes == 1) TruckType = "Van";
            if (TruckTypes == 2) TruckType = "Pickup Truck";
            if (TruckTypes == 3) TruckType = "Mobile Crane";
        }
        public void TruckFileSave()
        {
            string path = "c:\\TeslaTruck\\";
            path += VehicleId;
            path += "_";
            path += VehicleName;
            path += ".txt";
            //  Console.WriteLine(t);
            string VehicleInfo = VehicleId + "," + VehicleName + "," + VehiclePrice + "," + VehicleEngine + "," + VehicleManufacture + "," + TruckType;
            File.WriteAllText(path, VehicleInfo);
        }
        public void TruckDelete()
        {
            Console.WriteLine("Choose how you want to delete:\n1.Id\n2.Name\n");
            deleteType = Convert.ToInt32(Console.ReadLine());
            if (deleteType == 1)
            {
                Console.WriteLine("Please enter the Id:\n");
                string deleteId = (Console.ReadLine());
                deleteId += "_*";
                string[] dirs = Directory.GetFiles(@"c:\TeslaTruck", deleteId);
                foreach (string dir in dirs)
                {
                    File.Delete(dir);
                }
            }
            else
            {
                Console.WriteLine("Please enter the Name:\n");
                string deleteName = (Console.ReadLine()), deleteFind;
                deleteFind = "*";
                deleteFind += deleteName;
                deleteFind += ".txt";
                string[] dirs = Directory.GetFiles(@"c:\TeslaTruck", deleteFind);
                int fileCounter = 1, fileChoosen, mark = 0;
                if (dirs.Length >= 1)
                {
                    Console.WriteLine("Please choose which specific Id to be deleted\n");
                    foreach (string dir in dirs)
                    {
                        Console.WriteLine(fileCounter + ".\t" + dir);
                        fileCounter++;
                    }
                    mark = 1;
                }
                fileChoosen = Convert.ToInt32(Console.ReadLine());
                fileCounter = 1;
                foreach (string dir in dirs)
                {
                    if (dirs.Length == 1) File.Delete(dir);
                    if (mark == 1 && fileCounter == fileChoosen) File.Delete(dir);
                    fileCounter++;
                }
            }
        }
    }
    public class find
    {
        public int findType;
        public string Path, findAddress;
        public find() { }
        public find(string vechicalPath)
        {
            Path = vechicalPath;
        }
        public string findme()
        {
            Console.WriteLine("Choose how you want to update:\n1.Id\n2.Name\n");
            findType = Convert.ToInt32(Console.ReadLine());

            if (findType == 1)
            {
                Console.WriteLine("Please enter the Id:\n");
                string findId = (Console.ReadLine());
                findId += "_*";
                string[] dirs = Directory.GetFiles(@Path, findId);
                foreach (string dir in dirs)
                {
                    findAddress = dir;
                }
            }
            else
            {
                Console.WriteLine("Please enter the Name:\n");
                string findName = (Console.ReadLine()), findLook;
                findLook = "*";
                findLook += findName;
                findLook += ".txt";
                string[] dirs = Directory.GetFiles(@Path, findLook);
                int fileCounter = 1, fileChoosen, mark = 0;
                if (dirs.Length >= 1)
                {
                    Console.WriteLine("Please choose which specific Id:\n");
                    foreach (string dir in dirs)
                    {
                        Console.WriteLine(fileCounter + ".\t" + dir);
                        fileCounter++;
                    }
                    mark = 1;
                }
                fileChoosen = Convert.ToInt32(Console.ReadLine());
                fileCounter = 1;
                foreach (string dir in dirs)
                {
                    if (dirs.Length == 1) findAddress = dir;
                    if (mark == 1 && fileCounter == fileChoosen) findAddress = dir;
                    fileCounter++;
                }
            }
            return (findAddress);
        }
    }
    public class display : find
    {
        public string Path;
        public display(string displayPath)
        {
            Path = displayPath;
        }
        public void show()
        {
            Console.WriteLine("The details are as follows");
            string readText = File.ReadAllText(Path);
            string[] lines = readText.Split(',');
            foreach (string s in lines)
            {
                Console.WriteLine(s + "\n");
            }
        }
    }
    public class manupulator{
        public int count=1;
        public string final , temp;
        public string Manupulate(string input){
            string[] lines = input.Split('\\');
            string[] newlines = lines[2].Split('.');
            return (newlines[0]);
        }
    }
    public class displayall
    {
        public string path;
        public void getinfo(int choice) {
            if (choice == 1) path = "c:\\TeslaCar";
            else path = "c:\\TeslaTruck";
            string[] dirs = Directory.GetFiles(@path, "*.txt");
            Console.WriteLine("The number of files is {0}.\n", dirs.Length);
            manupulator change = new manupulator();
            foreach (string dir in dirs)
            {
                Console.WriteLine(change.Manupulate(dir));
            }
        }
    }
    public class update : find
    {
        public string Path, idValue, nameValue;
        public int changer, fileDecider = 1, flagId = 0, flagName = 0;
        public update() { }
        public update(string vechicalPath)
            : base(vechicalPath)
        {
            Path = vechicalPath;
        }
        public void Updator(String paths, int check)
        {
            string finalText = "", newdata;
            string readText = File.ReadAllText(paths);
            string[] lines = readText.Split(',');
            foreach (string s in lines)
            {
                Console.WriteLine(s);
                string[] data = s.Split('-');
                Console.WriteLine("\nTo update:\nPress 0 else Press 1\n ");
                changer = Convert.ToInt32(Console.ReadLine());
                if (changer == 0 && fileDecider == 1) flagId = 1;
                if (changer == 0 && fileDecider == 2) flagName = 1;
                Console.WriteLine("\n");
                int counter = 0;
                foreach (string p in data)
                {
                    // Console.WriteLine(p);
                    if (counter == 0) finalText += p;
                    if (counter == 1)
                    {
                        finalText += " - ";
                        if (changer == 0)
                        {
                            Console.WriteLine("Enter the new updates data\n");
                            newdata = Console.ReadLine();
                            finalText += newdata;
                            if (fileDecider == 1) idValue = newdata;
                            if (fileDecider == 2) nameValue = newdata;
                        }
                        else
                        {
                            finalText += p;
                            if (fileDecider == 1) idValue = p;
                            if (fileDecider == 2) nameValue = p;
                        }
                    }
                    counter++;
                }
                if (fileDecider != 6) finalText += " , ";
                fileDecider++;
            }
           File.Delete(paths);
           if (check == 0) paths = "c:\\TeslaCar\\";
           else paths = "c:\\TeslaCar\\";
           paths += idValue;
           paths += "_";
           paths += nameValue;
           paths += ".txt";
           File.WriteAllText(paths, finalText);
        }
    }
    public class Utility
    {
        static void insert()
        {
            int vechicalType;
            Console.WriteLine("Please choose the type of vehical:\n1.Car\n2.Truck\n");
            vechicalType = Convert.ToInt16(Console.ReadLine());
            if (vechicalType == 1)
            {
                TeslaCar car1 = new TeslaCar();
                car1.GetValue();
                car1.CarTypeChoose();
                car1.TypeAssign();
                car1.CarFileSave();
            }
            else
            {
                TeslaTruck truck1 = new TeslaTruck();
                truck1.GetValue();
                truck1.TruckTypeChoose();
                truck1.TypeAssign();
                truck1.TruckFileSave();

            }
        }
        static void delete()
        {
            int deleteType;
            Console.WriteLine("Choose the type of vehicle to be deleted:\n1.Car\n2.Truck\n");
            deleteType = Convert.ToInt32(Console.ReadLine());
            if (deleteType == 1)
            {
                TeslaCar car1 = new TeslaCar();
                car1.CarDelete();
            }
            else
            {
                TeslaTruck truck1 = new TeslaTruck();
                truck1.TruckDelete();
            }
        }
        static void update()
        {
            int UpdateType;
            string updatePath;
            Console.WriteLine("Choose the type of vehicle to be updated:\n1.Car\n2.Truck\n");
            UpdateType = Convert.ToInt32(Console.ReadLine());
            if (UpdateType == 1)
            {
                update vechicalUpdate = new update("c:\\TeslaCar");
                updatePath = vechicalUpdate.findme();
                vechicalUpdate.Updator(updatePath, 0);
            }
            else
            {
                update vechicalUpdate = new update("c:\\TeslaTruck");
                updatePath = vechicalUpdate.findme();
                vechicalUpdate.Updator(updatePath, 1);
            }


        }
        static void find()
        {
            int findType, actionType,choice=0;
            string findPath;
            Console.WriteLine("Choose the type of vehicle to be Find:\n1.Car\n2.Truck\n");
            findType = Convert.ToInt32(Console.ReadLine());
            if (findType == 1)
            {
                find allVehical = new find("c:\\TeslaCar");
                findPath = allVehical.findme();
                choice = 0;
            }
            else
            {
                find allVehical = new find("c:\\TeslaTruck");
                findPath = allVehical.findme();
                choice = 1;
            }
            //Console.WriteLine(findPath);
            Console.WriteLine("Choose the action to be performed:\n1.Display contents\n2.Update values\n");
            actionType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            if (actionType == 1)
            {
                display data = new display(findPath);
                data.show();
            }
            else
            {
                update updates = new update();
                updates.Updator(findPath,choice);
            }
        }
        static void displayall()
        {
            int choice;
            Console.WriteLine("Choose between:\n1.Car\n2.Truck\n");
            choice = Convert.ToInt32(Console.ReadLine());
            displayall show = new displayall();
            show.getinfo(choice);
        }
        public static int Main()
        {
            while (true)
            {
                int input, flag = 0;
                Console.WriteLine("\nWelcome to Tesla Inc.\nEnter the action to be performed\n1.Add a Vehical.\n2.Delete a Vehical.\n3.Update a Vehical information.\n4.Find a Vehical information\n5.Display all reports\n6.To exit");
                input = Convert.ToInt16(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        insert();
                        break;
                    case 2:
                        delete();
                        break;
                    case 3:
                        update();
                        break;
                    case 4:
                        find();
                        break;
                    case 5:
                        displayall();
                        break;
                    case 6:
                        flag = 1;
                        break;

                }
                if (flag == 1) break;
            }
            // Console.ReadKey();
            return 0;
        }
    }
}
