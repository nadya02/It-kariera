using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
	class Fridge
	{
		private Product head;
		private Product tail;
		private int count;

		public Fridge()
		{
			head = null;
			tail = null;
			Count = 0;
		}

		public int Count
		{
			get;
			private set;
		}

		public void AddProduct(string ProductName)
		{
			if (Count == 0)
			{
				head = new Product(ProductName);
				tail = head;
			}
			else
			{
				var newTail = new Product(ProductName);
				tail.Next = newTail;
				tail = newTail;
			}
			Count++;
		}

		public string[] CookMeal(int startIndex, int endIndex)
		{
			List<string> result = new List<string>();
			int index = 0;
			Product current = head;
			if (endIndex > Count)
			{
				endIndex = Count;
			}
			int current_index = 0;
			while (current_index != startIndex)
			{
				current = current.Next;
				current_index++;
			}
			for (int i = startIndex; i < endIndex; i++)
			{
				result.Add(current.Name);
				current = current.Next;
				startIndex++;
			}
			return result.ToArray();
		}

		public string RemoveProductByIndex(int index)
		{
			if (index >= Count || index < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			int current_index = 0;
			Product current = head;
			Product previous = null;
			while (current_index < index)
			{
				current_index++;
				previous = current;
				current = current.Next;
			}
			string removed = current.Name;
			if (index == 0)
			{
				head = head.Next;
			}
			else
			{
				previous.Next = current.Next;
			}
			if (current == tail)
			{
				tail = previous;
			}
			Count--;
			return removed;
		}

		public string RemoveProductByName(string name)
		{
			Product current = head;
			int index = 0;
			while (current != null && !current.Name.Equals(name))
			{
				current = current.Next;
				index++;
			}
			if (current == null)
			{
				return null;
			}
			else
			{
				return RemoveProductByIndex(index);
			}
		}

		public bool CheckProductIsInStock(string name)
		{
			Product current = head;
			int current_index = 0;
			while (current != null)
			{
				if (name == current.Name)
				{
					return true;
					break;
				}
				current = current.Next;
				current_index++;
			}
			return false;
		}

		public string[] ProvideInformationAboutAllProducts()
		{
			var allProducts = new List<string>();
			Product current = head;
			//int current_index = 0;
			while (current != null)
			{
				allProducts.Add(current.Name);
				current = current.Next;
				//current_index++;
			}
			return allProducts.ToArray();
		}

	}
}