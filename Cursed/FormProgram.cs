using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cursed
{
    public partial class FormProgram : Form
    {
        DrawGraph G;
        List<Vertex> V;
        List<Edge> E;
        FW F;

        double[,] Matrix; //матрица
        double[,] Dist; //матрица расстояний
        string[,] DistWay; //матрица путей

        int selected1; //выбранные вершины, для соединения линиями
        int selected2;

        bool dist = false;
        bool way = false;

        public FormProgram()
        {
            InitializeComponent();
            V = new List<Vertex>();
            E = new List<Edge>();
            G = new DrawGraph(sheet.Width, sheet.Height);
            sheet.Image = G.GetBitmap();
            F = new FW();
        }

        private void FormProgram_Load(object sender, EventArgs e)
        {

        }

        private void MouseButton_Click(object sender, EventArgs e)
        {
            MouseButton.Enabled = false;
            VertexButton.Enabled = true;
            EdgeButton.Enabled = true;
            DeleteButton.Enabled = true;
            G.clearSheet();
            G.drawALLGraph(V, E);
            sheet.Image = G.GetBitmap();
            selected1 = -1;
        }

        private void VertexButton_Click(object sender, EventArgs e)
        {
            VertexButton.Enabled = false;
            MouseButton.Enabled = true;
            EdgeButton.Enabled = true;
            DeleteButton.Enabled = true;
            G.clearSheet();
            G.drawALLGraph(V, E);
            sheet.Image = G.GetBitmap();
        }

        private void EdgeButton_Click(object sender, EventArgs e)
        {
            EdgeButton.Enabled = false;
            MouseButton.Enabled = true;
            VertexButton.Enabled = true;
            DeleteButton.Enabled = true;
            G.clearSheet();
            G.drawALLGraph(V, E);
            sheet.Image = G.GetBitmap();
            selected1 = -1;
            selected2 = -1;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteButton.Enabled = false;
            MouseButton.Enabled = true;
            VertexButton.Enabled = true;
            EdgeButton.Enabled = true;
            G.clearSheet();
            G.drawALLGraph(V, E);
            sheet.Image = G.GetBitmap();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            MouseButton.Enabled = true;
            VertexButton.Enabled = true;
            EdgeButton.Enabled = true;
            DeleteButton.Enabled = true;
            const string message = "Вы действительно хотите полностью удалить граф?";
            const string caption = "Удаление";
            var MBSave = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (MBSave == DialogResult.Yes)
            {
                Fresh();
                V.Clear();
                E.Clear();
                G.clearSheet();
                sheet.Image = G.GetBitmap();
            }
        }

        private void sheet_MouseClick(object sender, MouseEventArgs e)
        {
            if (VertexButton.Enabled == false)
            {
                if (V.Count < 9)
                {
                    bool flag = true;
                    for(int i = 0; i < V.Count; i++)
                    {
                        if ((e.X > V[i].x - 35) && (e.X < V[i].x +35) && (e.Y > V[i].y - 35) && (e.Y < V[i].y + 35))
                        {
                            flag = false;
                        }
                    }
                    if (flag)
                    {
                        V.Add(new Vertex(e.X, e.Y));
                        G.drawVertex(e.X, e.Y, V.Count.ToString());
                        sheet.Image = G.GetBitmap();
                        Fresh();
                    }
                }
            }
            if (EdgeButton.Enabled == false)
            {
                if (e.Button == MouseButtons.Left)
                {
                    for (int i = 0; i < V.Count; i++)
                    {
                        if (Math.Pow((V[i].x - e.X), 2) + Math.Pow((V[i].y - e.Y), 2) <= G.R * G.R)
                        {
                            if (selected1 == -1)
                            {
                                G.drawSelectedVertex(V[i].x, V[i].y);
                                selected1 = i;
                                sheet.Image = G.GetBitmap();
                                break;
                            }
                            if (selected2 == -1)
                            {
                                G.drawSelectedVertex(V[i].x, V[i].y);
                                selected2 = i;
                                E.Add(new Edge(selected1, selected2));
                                G.drawEdge(V[selected1], V[selected2], E[E.Count - 1], E.Count - 1);
                                selected1 = -1;
                                selected2 = -1;
                                sheet.Image = G.GetBitmap();
                                Fresh();
                                break;
                            }
                        }
                    }
                }
            }
            if (DeleteButton.Enabled == false)
            {
                bool flag = false;
                for (int i = 0; i < V.Count; i++)
                {
                    if (Math.Pow((V[i].x - e.X), 2) + Math.Pow((V[i].y - e.Y), 2) <= G.R * G.R)
                    {
                        for (int j = 0; j < E.Count; j++)
                        {
                            if ((E[j].v1 == i) || (E[j].v2 == i))
                            {
                                E.RemoveAt(j);
                                j--;
                            }
                            else
                            {
                                if (E[j].v1 > i) E[j].v1--;
                                if (E[j].v2 > i) E[j].v2--;
                            }
                        }
                        V.RemoveAt(i);
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    for (int i = 0; i < E.Count; i++)
                    {
                        if (E[i].v1 == E[i].v2)
                        {
                        }
                        else
                        {
                            if (((e.X - V[E[i].v1].x) * (V[E[i].v2].y - V[E[i].v1].y) / (V[E[i].v2].x - V[E[i].v1].x) + V[E[i].v1].y) <= (e.Y + 4) &&
                                ((e.X - V[E[i].v1].x) * (V[E[i].v2].y - V[E[i].v1].y) / (V[E[i].v2].x - V[E[i].v1].x) + V[E[i].v1].y) >= (e.Y - 4))
                            {
                                if ((V[E[i].v1].x <= V[E[i].v2].x && V[E[i].v1].x <= e.X && e.X <= V[E[i].v2].x) ||
                                    (V[E[i].v1].x >= V[E[i].v2].x && V[E[i].v1].x >= e.X && e.X >= V[E[i].v2].x))
                                {
                                    E.RemoveAt(i);
                                    flag = true;
                                    break;
                                }
                            }
                        }
                    }
                }
                if (flag)
                {
                    G.clearSheet();
                    G.drawALLGraph(V, E);
                    sheet.Image = G.GetBitmap();
                    Fresh();
                }
            }
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            Matrix = new double[V.Count, V.Count];
            Matrix = G.fillAdjacencyMatrix(V.Count, E, Matrix, V);
            Dist = F.FloydWarshall(V.Count, Matrix);
            try
            {
                int a = Convert.ToUInt16(FirstTextBox.Text) - 1;
                int b = Convert.ToUInt16(SecondTextBox.Text) - 1;
                if (Dist[a, b] < 99999)
                {
                    ResultTextBox.Text = Dist[a, b].ToString();
                    dist = true;
                }
                else
                {
                    ResultTextBox.Text = "Пути между точками нет";
                    dist = true;
                }
            }
            catch
            {
                MessageBox.Show("Номера точек введены неправильно.");
            }
        }

        private void WayButton_Click(object sender, EventArgs e)
        {
            Matrix = new double[V.Count, V.Count];
            Matrix = G.fillAdjacencyMatrix(V.Count, E, Matrix, V);
            DistWay = F.FloydWarshallWay(V.Count, Matrix);
            try
            {
                int a = Convert.ToUInt16(FirstTextBox.Text) - 1;
                int b = Convert.ToUInt16(SecondTextBox.Text) - 1;
                if (DistWay[a,b] == "Пути между точками нет")
                {
                    WayTextBox.Text = DistWay[a, b];
                    way = true;
                }
                else
                {
                    WayTextBox.Text = (a + 1) + "->" + DistWay[a, b];
                    way = true;
                }
            }
            catch
            {
                MessageBox.Show("Номера точек введены неправильно.");
            }
        }

        private void SaveGraphButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image Files(*.JPG)|*.JPG|Image Files(*.PNG)|*.PNG";
            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName.Length > 0)
            {
                try
                {
                    sheet.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                catch
                {
                    MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            FormInform FormInformDialog = new FormInform();
            FormInformDialog.ShowDialog();
        }

        private void SaveResultButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Filter = "Text Files | *.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName.Length > 0)
            {
                using (StreamWriter SW = new StreamWriter(saveFileDialog.FileName, false))
                {
                    SW.WriteLine("Результаты работы программы.");
                    SW.WriteLine("Граф состоит из {0} точек.",V.Count);
                    if (V.Count > 0)
                    {
                        SW.WriteLine();
                        SW.WriteLine("Точки:");
                        for (int i = 0; i < V.Count; i++)
                        {
                            SW.WriteLine("Точка {0}: ({1};{2})", i + 1, V[i].x, V[i].y);
                        }
                    }

                    if (dist)
                    {
                        SW.WriteLine();
                        SW.WriteLine("Минимальное расстояние из пункта {0} в пункт {1}:", FirstTextBox.Text, SecondTextBox.Text);
                        SW.WriteLine("{0}",ResultTextBox.Text);
                    }

                    if (way)
                    {
                        SW.WriteLine();
                        SW.WriteLine("Кратчайший путь из пункта {0} в пункт {1}:", FirstTextBox.Text, SecondTextBox.Text);
                        SW.WriteLine("{0}", WayTextBox.Text);
                    }
                    SW.Close();
                }
            }
        }
        private void Fresh()
        {
            dist = false;
            way = false;
            ResultTextBox.Text = "";
            WayTextBox.Text = "";
        }
    }
}
