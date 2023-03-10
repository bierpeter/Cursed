using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursed
{
    class Vertex
    {
        public int x, y;

        public Vertex(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Edge
    {
        public int v1, v2;

        public Edge(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }

    class DrawGraph
    {
        Bitmap bitmap;
        Pen blackPen;
        Pen redPen;
        Pen darkGoldPen;
        Graphics gr;
        Font fo;
        Brush br;
        PointF point;
        public int R = 15; //радиус окружности вершины

        public DrawGraph(int width, int height)
        {
            bitmap = new Bitmap(width, height);
            gr = Graphics.FromImage(bitmap);
            clearSheet();
            blackPen = new Pen(Color.Black);
            blackPen.Width = 2;
            redPen = new Pen(Color.Red);
            redPen.Width = 2;
            darkGoldPen = new Pen(Color.DarkGoldenrod);
            darkGoldPen.Width = 2;
            fo = new Font("Arial", 15);
            br = Brushes.Black;
        }

        public Bitmap GetBitmap()
        {
            return bitmap;
        }

        public void clearSheet()
        {
            gr.Clear(Color.White);
        }

        public void drawVertex(int x, int y, string number)
        {
            gr.FillEllipse(Brushes.White, (x - R), (y - R), 2 * R, 2 * R);
            gr.DrawEllipse(blackPen, (x - R), (y - R), 2 * R, 2 * R);
            point = new PointF(x - 9, y - 9);
            gr.DrawString(number, fo, br, point);
        }

        public void drawSelectedVertex(int x, int y)
        {
            gr.DrawEllipse(redPen, (x - R), (y - R), 2 * R, 2 * R);
        }

        public void drawEdge(Vertex V1, Vertex V2, Edge E, int numberE)
        {
            if (E.v1 != E.v2)
            {
                gr.DrawLine(darkGoldPen, V1.x, V1.y, V2.x, V2.y);
                point = new PointF((V1.x + V2.x) / 2, (V1.y + V2.y) / 2);
                drawVertex(V1.x, V1.y, (E.v1 + 1).ToString());
                drawVertex(V2.x, V2.y, (E.v2 + 1).ToString());
            }
        }

        public void drawALLGraph(List<Vertex> V, List<Edge> E)
        {
            //рисуем ребра
            for (int i = 0; i < E.Count; i++)
            {
                if (E[i].v1 != E[i].v2)
                {
                    gr.DrawLine(darkGoldPen, V[E[i].v1].x, V[E[i].v1].y, V[E[i].v2].x, V[E[i].v2].y);
                    point = new PointF((V[E[i].v1].x + V[E[i].v2].x) / 2, (V[E[i].v1].y + V[E[i].v2].y) / 2);
                }
            }
            //рисуем вершины
            for (int i = 0; i < V.Count; i++)
            {
                drawVertex(V[i].x, V[i].y, (i + 1).ToString());
            }
        }

        //заполняет Матрицу
        public double[,] fillAdjacencyMatrix(int n, List<Edge> E, double[,] matrix, List<Vertex> V)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = 0;
                }
            }
            for (int i = 0; i < E.Count; i++)
            {
                matrix[E[i].v1, E[i].v2] = 1;
                matrix[E[i].v2, E[i].v1] = 1;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        matrix[i, j] = Math.Sqrt(Math.Pow((V[i].x - V[j].x), 2) + Math.Pow((V[i].y - V[j].y), 2));
                    }
                }
            }

            return matrix;
        }

    }
    public class FW
    {
        public double[,] FloydWarshall(int n, double[,] matrix)
        {
            double[,] dist = new double[n, n];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (matrix[i, j] != 0)
                    {
                        dist[i, j] = matrix[i, j];
                    }
                    else
                    {
                        dist[i, j] = 100000;
                    }
                }
            }

            for (int k = 0; k < n; ++k)
            {
                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < n; ++j)
                    {
                        if (dist[i, k] + dist[k, j] < dist[i, j])
                            dist[i, j] = dist[i, k] + dist[k, j];
                    }
                }
            }
            return dist;
        }
        public string[,] FloydWarshallWay(int n, double[,] matrix)
        {
            double[,] dist = new double[n, n];
            string[,] way = new string[n, n];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (matrix[i, j] != 0)
                    {
                        dist[i, j] = matrix[i, j];
                        way[i, j] = (j + 1).ToString();
                    }
                    else
                    {
                        dist[i, j] = 100000;
                        way[i, j] = (j + 1).ToString();
                    }
                }
            }
            for (int k = 0; k < n; ++k)
            {
                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < n; ++j)
                    {
                        if (dist[i, k] + dist[k, j] < dist[i, j])
                        {
                            dist[i, j] = dist[i, k] + dist[k, j];
                            way[i, j] = way[i, k] + "->" + way[k, j];
                        }
                    }
                }
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (dist[i, j] > 99999)
                    {
                        way[i, j] = "Пути между точками нет";
                    }
                }
            }
            return way;
        }
    }
}
