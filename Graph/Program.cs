using System;
using System.Collections.Generic;

namespace Graph
{
	class Program
	{
		/// <summary>
		/// Точка входа выполнения программы
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			// Создаем пустой граф
			var graph = new Graph();

			// Создаем несколько вершин для графа
			var v1 = new Vertex(1);
			var v2 = new Vertex(2);
			var v3 = new Vertex(3);
			var v4 = new Vertex(4);
			var v5 = new Vertex(5);
			var v6 = new Vertex(6);
			var v7 = new Vertex(7);

			// Устанавливаем вершины графа
			graph.AddVertex(v1);
			graph.AddVertex(v2);
			graph.AddVertex(v3);
			graph.AddVertex(v4);
			graph.AddVertex(v5);
			graph.AddVertex(v6);
			graph.AddVertex(v7);

			// Устанавливаем ребра графа
			graph.AddEdge(v1, v2);
			graph.AddEdge(v1, v3);
			graph.AddEdge(v3, v4);
			graph.AddEdge(v2, v5);
			graph.AddEdge(v2, v6);
			graph.AddEdge(v6, v5);
			graph.AddEdge(v5, v6);

			// Вывод графа в виде матрицы смежности
			ShowGraphMatrix(graph);

			// Вывод списка смежных вершин для вершин
			ShowLinkedVertex(graph, v1);
			ShowLinkedVertex(graph, v2);
			ShowLinkedVertex(graph, v3);
			ShowLinkedVertex(graph, v4);
			ShowLinkedVertex(graph, v5);
			ShowLinkedVertex(graph, v6);
			ShowLinkedVertex(graph, v7);

			// Ожидаем ввод для завершения программы
			Console.ReadLine();
		}
		
		/// <summary>
		/// Метод вывод матрицы смежности на консоль
		/// </summary>
		/// <param name="graph"></param>
		private static void ShowGraphMatrix(Graph graph)
		{
			var matrix = graph.GetMatrix();

			for (int i = 0; i < graph.VertexCount; i++)
			{
				Console.Write(i + 1);

				for (int j = 0; j < graph.EdgeCount; j++)
				{
					Console.Write($" | {matrix[i,j]} |");
				}

				Console.WriteLine();
			}

			Console.WriteLine(new string('_', 45));
			Console.WriteLine(" ");

			for (int i = 0; i < graph.VertexCount; i++)
			{
				Console.Write($" | {i + 1} |");
			}

			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
		}

		/// <summary>
		/// Показать смежные вершины для вершины из графа
		/// </summary>
		/// <param name="graph"></param>
		/// <param name="vertex"></param>
		private static void ShowLinkedVertex(Graph graph, Vertex vertex)
		{
			if (!graph.ContainsVertex(vertex))
			{
				Console.WriteLine($"Не удалось показать смежные вершины, т.к заданная вершина {vertex.Number} не входит в состав графа!");
				return;
			}

			var linkedVertex = new List<string>();
			foreach (var v in graph.GetLinkedVertex(vertex))
			{
				linkedVertex.Add(v.Number.ToString());
			}

			var resultText = (linkedVertex.Count > 0) ? "связана с" : "не имеет связей";
			Console.WriteLine($"Вершина {vertex.Number} {resultText} {string.Join(", ", linkedVertex)}");
		}
	}
}
