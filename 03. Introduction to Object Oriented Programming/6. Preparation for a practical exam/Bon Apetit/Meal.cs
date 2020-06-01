using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Meal
	{
		private string name;
		private string type;
		private List<Product> products = new List<Product>();
		private int ordered = 0;
		private double price;

		public string Name
		{
			get { return this.name; }
			set
			{
				if(value.Length < 3)
				{
					throw new ArgumentException("Invalid Command!");
				}
				this.name = value;
			}
		}

		public string Type
		{
			get { return this.type; }
			set
			{
				if(value == "")
				{
					throw new ArgumentException("Invalid Command!");
				}
				this.type = value;
			}
		}

		public List<Product> Products
		{
			get { return this.products; }
			set { this.products = value; }
		}

		public int Ordered
		{
			get { return this.ordered; }
		}

		public double Price
		{
			get
			{
				this.price = CalculatePrice();
				return this.price;
			}
		}

		public double CalculatePrice()
		{
			return this.products.Sum(x => x.Price) + this.products.Sum(x => x.Price) * 0.30
				;
		}

		public Meal(string name, string type)
		{
			this.Name = name;
			this.Type = type;
		}

		public Meal(string name, string type, List<Product> products)
		{
			this.Name = name;
			this.Type = type;
			this.Products = products;
		}

		public void AddProduct(Product p)
		{
			products.Add(p);
		}

		public bool ContainsProduct(string name)
		{
			foreach(var item in products)
			{
				if(item.Name == name)
				{
					return true;
				}
			}
			return false;
		}

		public void PrintRecipe()
		{
			Console.WriteLine("-------------------------");
			Console.WriteLine($"{Name} RECIPE");
			Console.WriteLine("-------------------------");
			foreach(var product in products)
			{
				Console.WriteLine($"{product.Name} - {product.Weight}");
			}
			Console.WriteLine("-------------------------");
		}

		public void Order()
		{
			ordered++;
		}

		public static Meal GetSpecialty(Dictionary<string, Meal> meals)
		{
			return meals.OrderByDescending(x => x.Value.Ordered).First().Value;
		}

		public static Meal RecommendByPrice(double price, Dictionary<string, Meal> meals)
		{
			return meals.Where(x => x.Value.Price <= price)
						.OrderByDescending(x => x.Value.Price)
						.First()
						.Value;
		}

		public static Meal RecommendByPriceAndType(double price, string type, Dictionary<string, Meal> meals)
		{
			return meals.Where(x => x.Value.Price <= price)
						.OrderByDescending(x => x.Value.Price)
						.ThenBy(x => x.Value.Type)
						.First()
						.Value;
		}
		public override string ToString()
		{
			return $"{Name} - {Type}".ToString();
		}
	}
}
