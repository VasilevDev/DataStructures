Граф - это совокупность точек и связей между ними (вершины и ребра).
Граф бывает направленный, если можно двигаться в одном заданном направлении и ненаправленный, если можно двигаться в обе стороны.
Нагруженный (взвешенный) - если ребра имеют вес, ненагруженный если ребра не имеют вес.

Программно граф может быть представлен 3 способами:
1 - Матрица смежности - двумерный массив.
2 - Списки смежных вершин. (Если граф взвешенный, то использовать лучше множество, например Dictionary).
3 - Списки ребер.

Возможные задачи по работе с графами:
1 - Определить есть ли связь между 2 вершинами (решение через матрицу смежности). Можно через список смежных вершин, но тогда лучше представить их в виде Dicrionary, чтобы выполнить за O(1)
2 - Получить список всех смежный вершин с какой либо вершиной. Решение аналогично предыдущему пункту.
3 - Поиск кратчайшего пути, от одной вершины до другой. Возможные решения: обход в ширину, обход в глубину.