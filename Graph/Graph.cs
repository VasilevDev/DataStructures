using System.Collections.Generic;

namespace Graph
{
	/// <summary>
	/// Граф
	/// </summary>
	public class Graph
	{
		/// <summary>
		/// Список вершин
		/// </summary>
		List<Vertex> Vertexes = new List<Vertex>();
		/// <summary>
		/// Список ребер
		/// </summary>
		List<Edge> Edges = new List<Edge>();

		/// <summary>
		/// Количество вершин графа
		/// </summary>
		public int VertexCount => Vertexes.Count;

		/// <summary>
		/// Количество ребер в графе
		/// </summary>
		public int EdgeCount => Edges.Count;

		/// <summary>
		/// Метод добавления вершины графа
		/// </summary>
		/// <param name="vertex"></param>
		public void AddVertex(Vertex vertex)
		{
			// Добавляем вершину, если таковой нет
			if(!Vertexes.Contains(vertex))
				Vertexes.Add(vertex);
		}

		/// <summary>
		/// Метод добавления ребра между вершинами графа
		/// </summary>
		/// <param name="from">Вершина из которой выходит ребро</param>
		/// <param name="to">Вершина в которое заходит ребро</param>
		public void AddEdge(Vertex from, Vertex to)
		{
			var edge = new Edge(from, to);

			// Добавляем ребро(связь), только если таковой нет
			if(!Edges.Contains(edge))
				Edges.Add(edge);
		}

		/// <summary>
		/// Метод проверяет содержит ли граф заданную вершину
		/// </summary>
		/// <param name="vertex"></param>
		/// <returns></returns>
		public bool ContainsVertex(Vertex vertex)
		{
			return Vertexes.Contains(vertex);
		}

		/// <summary>
		/// Метод получения графа в виде матрицы смежности
		/// </summary>
		/// <returns></returns>
		public int[,] GetMatrix()
		{
			var matrix = new int[Vertexes.Count, Vertexes.Count];

			// Обход всех ребер
			foreach (var edge in Edges)
			{
				var row = edge.From.Number - 1;
				var column = edge.To.Number - 1;

				matrix[row, column] = edge.Weight;
			}

			return matrix;
		}

		/// <summary>
		/// Метод получения всех смежных вершин для заданой вершины
		/// </summary>
		/// <param name="vertex">Вершина для которой необходимо найти смежные</param>
		/// <returns></returns>
		public List<Vertex> GetLinkedVertex(Vertex vertex)
		{
			var result = new List<Vertex>();

			foreach (var edge in Edges)
			{
				if (edge.From == vertex)
				{
					result.Add(edge.To);
				}
			}

			return result;
		}

		/// <summary>
		/// Проверяет наличие пути между дву вершинами
		/// </summary>
		/// <param name="start"></param>
		/// <param name="finish"></param>
		/// <returns></returns>
		public bool IsExistsWay(Vertex start, Vertex finish)
		{
			var list = new List<Vertex>() {
				start
			};

			for (int i = 0; i < list.Count; i++)
			{
				var vertex = list[i];

				foreach (var v in GetLinkedVertex(vertex))
				{
					if (!list.Contains(v))
					{
						list.Add(v);
					}
				}
			}

			return list.Contains(finish);
		}
	}
}
