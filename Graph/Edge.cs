namespace Graph
{
	/// <summary>
	/// Класс ребро графа
	/// </summary>
	public class Edge
	{
		public Edge(Vertex from, Vertex to, int weight = 1)
		{
			From = from;
			To = to;
			Weight = weight;
		}

		/// <summary>
		/// Вершина - начало пути
		/// </summary>
		public Vertex To { get; set; }
		/// <summary>
		/// Вершина - конец пути
		/// </summary>
		public Vertex From { get; set; }
		/// <summary>
		/// Вес ребра
		/// </summary>
		public int Weight { get; set; }

		public override string ToString()
		{
			return $"({From};{To})";
		}
	}
}
