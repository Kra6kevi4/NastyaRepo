using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrafLab1
{
    internal class Graph
    {
        private List<List<Boolean>> graf = new List<List<Boolean>>(); //матрица смежности 
        private List<List<OptionsGraf>> grafSizeWay = new List<List<OptionsGraf>>(); //карта велечины путей

        private int size = 0; // количество точек
        private Nodes grafDecart; // кооординаты точек
        public int contractionDot = -1;
        public List<int> pointsBuf = new List<int>(); //лист который будет хранить вершины которые уже обошли
        public List<List<OptionsGraf>> resultSizeWay = new List<List<OptionsGraf>>();

        //метод получения и становки длины путей графа
        public List<List<OptionsGraf>> GrafSizeWay
        {
            get { return grafSizeWay; }
            set { grafSizeWay = value; }
        }

        // метода формирования матрицы длины путей 
        public void createGrafSizeWay()
        {
            Random random = new Random(Convert.ToInt32(System.DateTime.Now.Ticks.ToString().Remove(4)));
            for (int i = 0; i < this.size; i++)
            {
                List<OptionsGraf> optionsGrafs = new List<OptionsGraf>();
                List<OptionsGraf> resultOptionGrafs = new List<OptionsGraf>();
                for (int j = 0; j < this.size; j++)
                {
                   
                    if (i <= j || graf[j][i] == false)
                    {
                        optionsGrafs.Add(new OptionsGraf(0));
                        resultOptionGrafs.Add(new OptionsGraf(100000));
                    }
                    else
                    {
                        optionsGrafs.Add(new OptionsGraf(random.Next(6) + 1));
                        int kk = optionsGrafs[j].SizeWay;
                        resultOptionGrafs.Add(new OptionsGraf(kk));
                    }
                }
                    //pointsBuf.Add(-1);
               this.resultSizeWay.Add(resultOptionGrafs);
                    this.grafSizeWay.Add(optionsGrafs);
            }
            for (int i = 0; i < this.size; i++)
            {
                for (int j = 0; j < this.size; j++)
                {
                    if (i!=j && i<j)
                    {
                        this.grafSizeWay[i][j] =grafSizeWay[j][i];
                        this.resultSizeWay[i][j] = resultSizeWay[j][i];
                    }
                }
            }
        }

        private Boolean isClosePoint(Int32 point)
        {
            for (int i = 0; i < pointsBuf.Count; i++)
            {
                if (point == pointsBuf[i])
                {
                    return true;
                }
            }
            return false;
        }

        public void setGrafDecart(Nodes grafDecart)
        {
            this.grafDecart = grafDecart;
        }

        public Nodes getGrafDecart()
        {
            return this.grafDecart;
        }

        public Graph(int size)
        {
            this.createGraf(size);
        }

        public void setSize(int size)
        {
            this.size = size;
        }

        public int getSize()
        {
            return this.size;
        }

        //получение координаты точки
        public Coordinates getCoordinatePoint(int number)
        {
            int numberBuf = number + 1;
            if (this.getGrafDecart().getCoordinateDot(numberBuf) != null)
                return new Coordinates(true,
                                       new Node(this.getGrafDecart().getCoordinateDot(numberBuf).getX(),
                                                             this.getGrafDecart().getCoordinateDot(numberBuf).getY()),
                                       null);
            else
            {
                return null;
            }
        }

        //операция объединения
        public static Graph operator +(Graph graf1, Graph graf2)
        {
            Graph graf = graf1.getSize() > graf2.getSize()
                            ? new Graph(graf1.getCountPoint(graf2.getGrafDecart()))
                            : new Graph(graf2.getCountPoint(graf1.getGrafDecart()));

            //заполняю координаты в пространстве
            int grafDecartX = graf1.getGrafDecart().getSizeDecartGrafMatrixX() >
                              graf2.getGrafDecart().getSizeDecartGrafMatrixX()
                                  ? graf1.getGrafDecart().getSizeDecartGrafMatrixX()
                                  : graf2.getGrafDecart().getSizeDecartGrafMatrixX();
            int grafDecartY = graf1.getGrafDecart().getSizeDecartGrafMatrixY() >
                              graf2.getGrafDecart().getSizeDecartGrafMatrixY()
                                  ? graf1.getGrafDecart().getSizeDecartGrafMatrixY()
                                  : graf2.getGrafDecart().getSizeDecartGrafMatrixY();

            Nodes grafDecart = new Nodes(grafDecartX, grafDecartY, false);
            for (int y = 0; y < graf2.getGrafDecart().getSizeDecartGrafMatrixY(); y++)
            {
                for (int x = 0; x < graf2.getGrafDecart().getSizeDecartGrafMatrixX(); x++)
                {
                    grafDecart.setGrafMatrixDecart(x, y, graf2.getGrafDecart().getElementDecartGraf(x, y));
                }
            }

            for (int y = 0; y < graf1.getGrafDecart().getSizeDecartGrafMatrixY(); y++)
            {
                for (int x = 0; x < graf1.getGrafDecart().getSizeDecartGrafMatrixX(); x++)
                {
                    if (grafDecart.getElementDecartGraf(x, y) == 0)
                    {
                        grafDecart.setGrafMatrixDecart(x, y,
                                                       graf1.getGrafDecart().getElementDecartGraf(x, y) > 0
                                                           ? grafDecart.findLastDot() + 1
                                                           : 0);
                    }

                }
            }
            graf.setGrafDecart(grafDecart);

            //заполняю грани в пространстве
            for (int y = 0; y < graf2.getSize(); y++)
            {
                for (int x = 0; x < graf2.getSize(); x++)
                {
                    if (graf2.getCoordinates(x, y))
                    {
                        graf.setCoordinates(x, y, true);
                    }
                }
            }

            for (int y = 0; y < graf1.getGraf().Count; y++)
            {
                for (int x = 0; x < graf1.getGraf().Count; x++)
                {
                    if (graf1.getCoordinates(x, y))
                    {
                        graf.setCoordinates(
                            graf.getGrafDecart().getElementDecartGraf(
                                graf1.getCoordinatePoint(x).getStartCoordinate().getX(),
                                graf1.getCoordinatePoint(x).getStartCoordinate().getY()) - 1,
                            graf.getGrafDecart().getElementDecartGraf(
                                graf1.getCoordinatePoint(y).getStartCoordinate().getX(),
                                graf1.getCoordinatePoint(y).getStartCoordinate().getY()) - 1, true);

                    }
                }
            }

            return graf;

        }



        /// <summary>
        /// операции соединения
        /// </summary>
        /// <param name="graf1"></param>
        /// <param name="graf2"></param>
        /// <returns></returns>
        public static Graph operator *(Graph graf1, Graph graf2)
        {
            Graph graf = graf1 + graf2;

            for (int y = 0; y < graf1.getGrafDecart().getSizeDecartGrafMatrixY(); y++)
            {
                for (int x = 0; x < graf1.getGrafDecart().getSizeDecartGrafMatrixX(); x++)
                {
                    if (graf1.getGrafDecart().getElementDecartGraf(x, y) > 0)
                    {
                        int nameDot1 = graf.getGrafDecart().getElementDecartGraf(x, y) - 1;
                        for (int y1 = 0; y1 < graf2.getGrafDecart().getSizeDecartGrafMatrixY(); y1++)
                        {
                            for (int x1 = 0; x1 < graf2.getGrafDecart().getSizeDecartGrafMatrixX(); x1++)
                            {
                                if (graf2.getGrafDecart().getElementDecartGraf(x1, y1) > 0)
                                {
                                    int nameDot2 = graf.getGrafDecart().getElementDecartGraf(x1, y1) - 1;
                                    graf.setCoordinates(nameDot1, nameDot2, true);
                                }
                            }
                        }
                    }
                }
            }
            return graf;
        }

        /// <summary>
        /// операция дополнения
        /// </summary>
        /// <param name="grafForAdditional"></param>
        /// <returns></returns>
        public static Graph operator ++(Graph grafForAdditional)
        {
            Graph graf = grafForAdditional;
            for (int y = 0; y < graf.getGraf().Count; y++)
            {
                for (int x = 0; x < graf.getGraf().Count; x++)
                {
                    graf.setCoordinates(x, y, !graf.getCoordinates(x, y));
                }
            }
            return graf;
        }

        /// <summary>
        /// операция сведения графа
        /// </summary>
        /// <param name="grafForContraction"></param>
        /// <returns></returns>
        public Graph contraction(Graph grafForContraction, List<int> itemForContraction)
        {

            Graph graf = grafForContraction;

            contractionDot = itemForContraction[0];
            /* for (int y = 0; y < graf.getGrafDecart().getSizeDecartGrafMatrixY(); y++)
             {
                 for (int x = 0; x < graf.getGrafDecart().getSizeDecartGrafMatrixX(); x++)
                 {
                     if (graf.getGrafDecart().getElementDecartGraf(x,y)>0)
                     {*/
            for (int y1 = 0; y1 < graf.getGraf().Count; y1++)
            {
                for (int x1 = 0; x1 < graf.getGraf().Count(); x1++)
                {
                    if (graf.getCoordinates(x1, y1))
                    {
                        for (int i = 1; i < itemForContraction.Count; i++)
                        {
                            if (itemForContraction[i] == x1 + 1 || itemForContraction[i] == y1 + 1)
                            {
                                // graf.setCoordinates(x1,y1,false);
                                if (itemForContraction[i] == x1 + 1 && itemForContraction[i] == y1 + 1)
                                {
                                    graf.setCoordinates(x1, y1, false);
                                }
                                else
                                {
                                    if (itemForContraction[i] == x1 + 1)
                                    {
                                        graf.setCoordinates(x1, contractionDot, true);
                                    }
                                    else
                                    {
                                        if (itemForContraction[i] == y1 + 1)
                                        {
                                            graf.setCoordinates(contractionDot, y1, true);
                                        }
                                    }
                                }

                            }
                        }
                    }
                }
            }
            //                    }
            //                }
            //            }

            //удаляю лишние точки
            for (int y = 0; y < graf.getGrafDecart().getSizeDecartGrafMatrixY(); y++)
            {
                for (int x = 0; x < graf.getGrafDecart().getSizeDecartGrafMatrixX(); x++)
                {
                    if (graf.getGrafDecart().getElementDecartGraf(x, y) > 0)
                    {
                        for (int i = 1; i < itemForContraction.Count; i++)
                        {
                            if (itemForContraction[i] == graf.getGrafDecart().getElementDecartGraf(x, y))
                            {
                                graf.getGrafDecart().setGrafMatrixDecart(x, y, 0);
                            }
                        }
                    }
                }
            }

            //переписываю матрицу смежности с новыми точками
            List<int> mergeDot = new List<int>(); //таблица соотношения текущих точек с точками новой матрицы смежности

            for (int i = 0; i < graf.getGraf().Count; i++)
                mergeDot.Add(0);

            //переписываю имена точек которые удалил
            int nameDot = 0; //имя перезаписываемой точки
            for (int y = 0; y < graf.getGrafDecart().getSizeDecartGrafMatrixY(); y++)
            {
                for (int x = 0; x < graf.getGrafDecart().getSizeDecartGrafMatrixX(); x++)
                {
                    if (graf.getGrafDecart().getElementDecartGraf(x, y) > 0)
                    {
                        nameDot++;

                        //graf.getGrafDecart().setGrafMatrixDecart(x, y, nameDot); 
                        mergeDot[graf.getGrafDecart().getElementDecartGraf(x, y) - 1] = nameDot;
                    }
                }
            }

            //переписываю матрицу смежности

            //создал матрицу смежности для дальнейшего заполнения
            List<List<Boolean>> grafBuf = new List<List<bool>>();
            for (int i = 0; i < graf.getGrafDecart().count(); i++)
            {
                List<Boolean> grafBufBuf = new List<bool>();
                for (int j = 0; j < graf.getGrafDecart().count(); j++)
                {
                    grafBufBuf.Add(false);
                }
                grafBuf.Add(grafBufBuf);
            }

            //заполняю матрицу смежности со сдвигом точек по созданной маске


            for (int y = 0; y < graf.getGraf().Count; y++)
            {
                for (int x = 0; x < graf.getGraf().Count; x++)
                {
                    if (graf.getCoordinates(x, y))
                    {
                        for (int i = 1; i < itemForContraction.Count; i++)
                        {
                            /*if (itemForContraction[i] != x && itemForContraction[i] != y)
                            {*/
                            if (mergeDot[x] != 0 && mergeDot[y] != 0)
                            {
                                grafBuf[mergeDot[x] - 1][mergeDot[y] - 1] = true;
                            }

                            //                           }
                        }

                    }
                }
            }
            graf.setGraf(grafBuf);


            //переписываю имена точек которые удалил
            int nameDot1 = 0; //имя перезаписываемой точки
            for (int y = 0; y < graf.getGrafDecart().getSizeDecartGrafMatrixY(); y++)
            {
                for (int x = 0; x < graf.getGrafDecart().getSizeDecartGrafMatrixX(); x++)
                {
                    if (graf.getGrafDecart().getElementDecartGraf(x, y) > 0)
                    {
                        nameDot1++;
                        if (graf.getGrafDecart().getElementDecartGraf(x, y) == contractionDot)
                        {
                            contractionDot = nameDot1;
                        }
                        graf.getGrafDecart().setGrafMatrixDecart(x, y, nameDot1);
                    }

                }
            }
            return graf;
        }


        public Graph(Nodes grafDecart)
        {
            setGrafDecart(grafDecart);
            createGraf(getGrafDecart());
            createGrafSizeWay();
        }

        public Graph()
        {
        }

        /// <summary>
        /// генерит связанный граф
        /// </summary>
        /// <param name="grafDecart"></param>
        /// <param name="countDot"></param>
        /// <param name="countEdge"></param>
        public Graph(Nodes grafDecart, int countDot, int countEdge)
        {

        }

        public List<List<Boolean>> getGraf()
        {
            return this.graf;
        }

        public void setGraf(List<List<Boolean>> graf)
        {
            this.graf = graf;
        }

        /// <summary>
        /// получение элемента матрицы смежности
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public Boolean getCoordinates(int x, int y)
        {
            return this.graf[x][y];
        }

        public void setCoordinates(int x, int y, Boolean hasDot)
        {
            this.graf[x][y] = hasDot;
        }

        /// <summary>
        /// генераци ребер графа 
        /// </summary>
        private void createGraf(Nodes grafDecard)
        {
            Random random = new Random();
            this.setSize(grafDecard.count());
            for (int y = 0; y < grafDecard.count(); y++)
            {
                List<Boolean> bufGrafMatrix = new List<Boolean>();
                for (int x = 0; x < grafDecard.count(); x++)
                {
                    Boolean hasLink = false;
                    int edgeGraf = random.Next(2);
                    if (edgeGraf == 1)
                    {
                        hasLink = true;
                    }

                    bufGrafMatrix.Add(hasLink);

                }
                graf.Add(bufGrafMatrix);
            }
            for (int y = 0; y < grafDecard.count(); y++)
            {
                for (int x = 0; x < grafDecard.count(); x++)
                {
                    if (!graf[x][y])
                    {
                        graf[x][y] = graf[y][x];
                    }
                }
            }
        }

        /// <summary>
        /// создает грав заданного размера(пустой граф)
        /// </summary>
        /// <param name="size"></param>

        private void createGraf(int size)
        {
            for (int y = 0; y < size; y++)
            {
                List<Boolean> bufGrafMatrix = new List<Boolean>();
                for (int x = 0; x < size; x++)
                {
                    bufGrafMatrix.Add(false);
                }
                this.graf.Add(bufGrafMatrix);
            }

        }

        public Graph setWith(Graph graf)
        {

            Graph graf1 = new Graph(graf.getGrafDecart().count());

            //заполняю координаты в пространстве
            Nodes grafDecart = new Nodes(graf.getGrafDecart().getSizeDecartGrafMatrixX(),
                                                   graf.getGrafDecart().getSizeDecartGrafMatrixY(), false);
            for (int y = 0; y < graf.getGrafDecart().getSizeDecartGrafMatrixY(); y++)
            {
                for (int x = 0; x < graf.getGrafDecart().getSizeDecartGrafMatrixX(); x++)
                {
                    grafDecart.setGrafMatrixDecart(x, y, graf.getGrafDecart().getElementDecartGraf(x, y));
                }
            }
            graf1.setGrafDecart(grafDecart);

            //заполняю грани в пространстве
            for (int y = 0; y < graf.getSize(); y++)
            {
                for (int x = 0; x < graf.getSize(); x++)
                {
                    graf1.setCoordinates(x, y, graf.getCoordinates(x, y));
                }
            }
            //заполняю размеры путей
            for (int y = 0; y < graf.getSize(); y++)
            {
                List<OptionsGraf> listbuf = new List<OptionsGraf>();
                for (int x = 0; x < graf.getSize(); x++)
                {
                    listbuf.Add(graf.grafSizeWay[x][y]);
                }
                graf1.grafSizeWay.Add(listbuf);
            }

            for (int y = 0; y < graf.getSize(); y++)
            {
                List<OptionsGraf> listbuf = new List<OptionsGraf>();
                for (int x = 0; x < graf.getSize(); x++)
                {
                    listbuf.Add(graf.resultSizeWay[x][y]);
                }
                graf1.resultSizeWay.Add(listbuf);
            }

            return graf1;

        }

        /// <summary>
        /// получение количкство точек на декартовой поверхности от двух пространственных 
        /// </summary>
        /// <param name="grafDecart"></param>
        /// <returns></returns>
        public int getCountPoint(Nodes grafDecart)
        {
            int count = getGrafDecart().count();
            for (int y = 0; y < grafDecart.getSizeDecartGrafMatrixY(); y++)
            {
                for (int x = 0; x < grafDecart.getSizeDecartGrafMatrixX(); x++)
                {
                    if (grafDecart.getElementDecartGraf(x, y) > 0)
                    {
                        if (this.grafDecart.getSizeDecartGrafMatrixX() <= grafDecart.getSizeDecartGrafMatrixX() &&
                            this.grafDecart.getSizeDecartGrafMatrixY() <= grafDecart.getSizeDecartGrafMatrixY())
                        {
                            if (this.grafDecart.getElementDecartGraf(x, y) == 0)
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            return count;
        }




        //======================================
        /// <summary>
        /// алгоритм дейкстры
        /// </summary>
        /// <param name="pointStart"></param>
        public void algoritmDeikster(int pointStart)
        {
            pointsBuf.Clear();
            deikster(pointStart);
        }

        private void deikster(int pointStart)
        {
            int lookPoint = pointStart;
            List<int> listBuf = new List<int>();
            if (isClosePoint(lookPoint) == false)
            {

                for (int x = 0; x < this.getGrafDecart().count(); x++)
                {

                    if (x != lookPoint && isClosePoint(x) == false)
                    {
                        if (this.graf[lookPoint][x] || this.graf[x][lookPoint])
                        {
                            int sumWay = this.grafSizeWay[lookPoint][lookPoint].SizeWay +
                                         (this.grafSizeWay[lookPoint][x].SizeWay == 0
                                              ? this.grafSizeWay[x][lookPoint].SizeWay
                                              : this.grafSizeWay[lookPoint][x].SizeWay);
                            if (this.grafSizeWay[x][x].SizeWay > sumWay && this.grafSizeWay[x][x].SizeWay != 0)
                            {
                                this.grafSizeWay[x][x].SizeWay = sumWay;
                                listBuf.Add(x);
                            }
                            else
                            {
                                if (this.grafSizeWay[x][x].SizeWay == 0)
                                {
                                    this.grafSizeWay[x][x].SizeWay = sumWay;
                                    listBuf.Add(x);
                                }
                            }
                        }
                    }
                }
            }
            pointsBuf.Add(lookPoint);
            for (int i = 0; i < listBuf.Count; i++)
            {
                deikster(listBuf[i]);
            }
        }

        /// <summary>
        /// Алгоритм флойда
        /// </summary>
        public void algoritmFloid()
        {
            int n = this.grafDecart.count();
            for (int k = 0; k < n; ++k)
                for (int i = 0; i < n; ++i)
                    for (int j = 0; j < n; ++j)
                    {
                        
                        int nextElem = resultSizeWay[i][k].SizeWay + resultSizeWay[k][j].SizeWay;
                        

                        int sizeWay = resultSizeWay[i][j].SizeWay;
                        
                        resultSizeWay[i][j].SizeWay = Math.Min(sizeWay,nextElem);
                    }
        }


    }
}

