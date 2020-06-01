using StorageMaster.Entities.Products;
using StorageMaster.Entities.Storage;
using StorageMaster.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster
{
    class StorageMaster
    {
        private Dictionary<string,Stack<Product>> productsPool;
        private Dictionary<string, Storage> storages;
        private Vehicle vehicle;

        public StorageMaster(Dictionary<string, Stack<Product>> productsPool, Dictionary<string, Storage> storages)
        {
            this.productsPool = productsPool;
            this.storages = storages;
        }

        public string AddProduct(string type, double price)
        {
            Product newProduct;
            if (type == "Gpu") newProduct = new Gpu(price);
            else if (type == "HardDrive") newProduct = new HardDrive(price);
            else if (type == "Ram") newProduct = new Ram(price);
            else if (type == "SolidStateDrive") newProduct = new SolidStateDrive(price);
            else throw new InvalidOperationException("Invalid product type!");

            if(productsPool.ContainsKey(type) == false)
            {
                 productsPool.Add(type, new Stack<Product>());
            }
            productsPool[type].Push(newProduct);

            return $"Added {type} to pool";
        }
        public string RegisterStorage(string type, string name)
        {
            Storage newStorage;
            if (type == "AutomatedWarehouse") newStorage = new AutomatedWarehouse(name);
            else if (type == "DistributionCenter") newStorage = new DistributionCenter(name);
            else if (type == "Warehouse") newStorage = new Warehouse(name);
            else throw new InvalidOperationException("Invalid storage type!");
            storages.Add(name, newStorage);
            return $"Registered {name}";
        }
        public string SelectVehicle(string storageName, int garageSlot)
        {
            Storage storage = this.storages[storageName];
            Vehicle selectedVehicle = storage.GetVehicle(garageSlot);

            vehicle = selectedVehicle;
            return $"Selected {vehicle.GetType().Name}";
        }
        public string LoadVehicle(IEnumerable<string> productNames)
        {
            int count = 0;
            foreach(string productName in productNames)
            {
                if(vehicle.IsFull())
                {
                    break;
                }

                if(productsPool.ContainsKey(productName) == false)
                {
                    throw new InvalidOperationException($"{productName} is out of stock!");
                }

                if(productsPool.ContainsKey(productName) && productsPool[productName].Count == 0)
                {
                    throw new InvalidOperationException($"{productName} is out of stock!");
                }

                vehicle.LoadProduct(productsPool[productName].Pop());
                count++;
            }

            return $"Loaded {count}/{productNames.Count()} products into {vehicle.GetType().Name}";
        }
        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            if(storages.ContainsKey(sourceName) == false)
            {
                throw new InvalidOperationException("Invalid source storage!");
            }
            
            if(storages.ContainsKey(destinationName) == false)
            {
                throw new InvalidOperationException("Invalid destination storage!");
            }

            Storage sourceStorage = storages[sourceName];
            Storage destinationStorage = storages[destinationName];
            Vehicle movedVehicle = sourceStorage.GetVehicle(sourceGarageSlot);

            int destinationGarageSlot = sourceStorage.SendVehicleTo(sourceGarageSlot, destinationStorage);//

            return $"Sent {vehicle.GetType().Name} to {destinationName} (slot {destinationGarageSlot})";
        }

        public string UnloadVehicle(string storageName, int garageSlot)
        {
            Storage storage = storages[storageName];
            Vehicle unloadingVehicle = storage.GetVehicle(garageSlot);

            int count = storage.UnloadVehicle(garageSlot);

            return $"Unloaded {count}/{unloadingVehicle.Trunk.Count} products at {storageName}";
        }
        public string GetStorageStatus(string storageName)
        {
            Storage storage = storages[storageName];
            Dictionary<string, int> productAndCounts = new Dictionary<string, int>();

            foreach (var product in storage.Products)
            {
                string type = product.GetType().Name;
                if(productAndCounts.ContainsKey(type) == false)
                {
                    productAndCounts.Add(type, 0);
                }
                productAndCounts[type]++;
            }

            double productsWeightSum = storage.Products.Sum(x => x.Weight);

            string[] productsInfo = productAndCounts
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .Select(kvp => $"{kvp.Key} ({kvp.Value})")
                .ToArray();

            string stockLine = $"Stock ({productsWeightSum}/{storage.Capacity}): [{String.Join(", ", productsInfo)}]";//

            string[] garageNames = storage.Garage
                .Select(x => 
                {
                    string result;
                    if (x == null)
                    {
                        result = "empty";
                    }
                    else
                    {
                        result =  x.GetType().Name;
                    }
                    return result;
                })
                .ToArray();

            string garageLine = $"Garage: [{String.Join("|", garageNames)}]";

            /*List<string> vehicleNames = new List<string>();
            foreach (var vehicle in storage.Garage)
            {
                if (vehicle != null)
                    vehicleNames.Add(vehicle.GetType().Name);
                else
                    vehicleNames.Add("empty");
            }
            string statusVehicles = $"Garage: [{String.Join("|", vehicleNames)}]";*/

            return stockLine +Environment.NewLine + garageLine;
        }
        public string GetSummary()
        {
            var sortedStorages = storages
                .OrderByDescending(x => x.Value.Products.Sum(p => p.Price))
                .ToDictionary(q => q.Key, q => q.Value);

            StringBuilder sb = new StringBuilder();
            foreach (var storage in sortedStorages)
            {
                double totalMoney = storage.Value.Products.Sum(x => x.Price);
                sb.Append($"{storage.Key}");
                sb.Append($"Storage worth: ${totalMoney:F2}");
            }

            return sb.ToString().Trim();
        }
    }
}
