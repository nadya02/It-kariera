using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster
{
    class Engine
    {
        private bool isRunning;
        private StorageMaster storageMaster;

        public Engine()
        {
            storageMaster = storageMaster;
        }

        public void Run()
        {
            isRunning = true;
            StringBuilder sb = new StringBuilder();

            while(isRunning)
            {
                string output;
                try
                {
                    string line = Console.ReadLine();
                    output = ProcessCommand(line);
                }
                catch (InvalidOperationException e)
                {

                    output = $"Error: {e.Message}";
                }

                sb.Append(output);
            }

            Console.Clear();
            Console.WriteLine(sb.ToString().Trim());
        }

        private string ProcessCommand(string line)
        {
            string[] tokens = line.Split();
            string command = tokens[0];
            string output = string.Empty;
            int garageSlot = 0;
            string storageName;
            switch (command)
            {
                case "AddProduct":
                    string productType = tokens[1];
                    double productPrice = double.Parse(tokens[2]);
                    output = storageMaster.AddProduct(productType, productPrice); 
                    break;
                case "RegisterStorage":
                    string storageType = tokens[1];
                    storageName = tokens[2];
                    output = storageMaster.RegisterStorage(storageType, storageName);
                    break;
                case "SelectVehicle":
                    storageName = tokens[1];
                    garageSlot = int.Parse(tokens[2]);
                    output = storageMaster.SelectVehicle(storageName, garageSlot);
                    break;
                case "LoadVehicle":
                    string[] names = tokens.Skip(1).ToArray();
                    output = storageMaster.LoadVehicle(names);
                    break;
                case "SendVehicleTo":
                    string sourceName = tokens[1];
                    int sourceGarageSlot = int.Parse(tokens[2]);
                    string destinationName = tokens[3];
                    output = storageMaster.SendVehicleTo(sourceName, sourceGarageSlot, destinationName);
                    break;
                case "UnloadVehicle":
                    storageName = tokens[1];
                    garageSlot = int.Parse(tokens[2]);
                    output = storageMaster.UnloadVehicle(storageName, garageSlot);
                    break;
                case "GetStorageStatus":
                    storageName = tokens[1];
                    output = storageMaster.GetStorageStatus(storageName);
                    break;
                case "END":
                    isRunning = false;
                    output = storageMaster.GetSummary();
                    break;
            }
            return output;
        }
    }
}
