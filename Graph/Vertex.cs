namespace Graph
{
	/// <summary>
	/// Класс вершина графа
	/// </summary>
	public class Vertex
	{
		public Vertex(int number)
		{
			Number = number;
		}

		/// <summary>
		/// Вершина характеризуется номером
		/// </summary>
		public int Number { get; set; }

		public override string ToString()
		{
			return Number.ToString();
		}
	}
}
