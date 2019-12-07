namespace LinkedList.Model
{
	/// <summary>
	/// Связный список
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class LinkedList<T>
	{
		/// <summary>
		/// Первый элемент списка
		/// </summary>
		public Item<T> First { get; private set; }
		/// <summary>
		/// Последний элемент списка
		/// </summary>
		public Item<T> Last { get; private set; }
		/// <summary>
		/// Количество элементов в списке
		/// </summary>
		public int Count { get; set; }

		public LinkedList()
		{
			First = null;
			Last = null;
			Count = 0;
		}

		public LinkedList(T data)
		{
			var item = new Item<T>(data);
			SetFirstAndLast(item);
		}

		/// <summary>
		/// Метод добавления элемента в список
		/// </summary>
		/// <param name="data"></param>
		public void Add(T data)
		{
			var item = new Item<T>(data);

			if(Last != null)
			{
				Last.Next = item;
				Last = item;
				Count++;
			}
			else
			{
				SetFirstAndLast(item);
			}
		}

		/// <summary>
		/// Метод удаления элемента из списка
		/// </summary>
		public void Remove(T data)
		{
			if(First != null)
			{
				if (First.Data.Equals(data))
				{
					First = First.Next;
					Count--;
					return;
				}

				var current = First.Next;
				var previous = First;

				while (current != null)
				{
					if (current.Data.Equals(data))
					{
						previous.Next = current.Next;
						Count--;
						break;
					}

					previous = current;
					current = current.Next;
				}
			}
		}

		private void SetFirstAndLast(Item<T> item)
		{
			First = item;
			Last = item;
			Count++;
		}
	}
}
