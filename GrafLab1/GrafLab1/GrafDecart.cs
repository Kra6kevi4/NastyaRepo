using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrafLab1
{
    class Nodes
    {

        private List<List<int>> grafMatrixDecart = new List<List<int>>();
        private int sizeDecartGrafMatrixX = 0;
        private int sizeDecartGrafMatrixY = 0;

        public Nodes(int x, int y, Boolean randomCoordinate)
        {
            this.setSizeDecartGrafMatrixX(x);
            this.setSizeDecartGrafMatrixY(y);
            this.createDecartGraf(randomCoordinate); 
            
        }



        public List<List<int>> getGrafMatrixDecart()
        {
            return this.grafMatrixDecart;
        }

        public void setGrafMatrixDecart(int x,int y,int value)
        {
            this.grafMatrixDecart[x][y] = value;
        }


        public int findLastDot()
        {
            int max = 0;
            for (int y = 0; y < this.getSizeDecartGrafMatrixY(); y++)
            {
                for (int x = 0; x < this.getSizeDecartGrafMatrixX(); x++)
                {
                    if (this.getGrafMatrixDecart()[x][y]>max)
                    {
                        max = this.getGrafMatrixDecart()[x][y];
                    }
                }
            }
            return max;
        }
        private void setSizeDecartGrafMatrixX(int x)
        {
            this.sizeDecartGrafMatrixX = x;
        }

        public int getSizeDecartGrafMatrixX()
        {
            return this.sizeDecartGrafMatrixX;
        }


        private void setSizeDecartGrafMatrixY(int y)
        {
            this.sizeDecartGrafMatrixY = y;
        }


        public int getSizeDecartGrafMatrixY()
        {
            return this.sizeDecartGrafMatrixY;
        }

        /// <summary>
        /// функция создания вершин графа 
        /// </summary>
        private void createDecartGraf(Boolean randomCoordinate)
        {
            Random random = new Random();
            for (int y = 0; y < this.getSizeDecartGrafMatrixY(); y++)
            {
                List<int> bufDecartGrafMatrix = new List<int>();
                for (int x = 0; x < this.getSizeDecartGrafMatrixX(); x++)
                {
                    bufDecartGrafMatrix.Add(0);
                }
                grafMatrixDecart.Add(bufDecartGrafMatrix);
            }
            for (int y = 0; y < this.getSizeDecartGrafMatrixY(); y++)
            {
                for (int x = 0; x < this.getSizeDecartGrafMatrixX(); x++)
                {
                   this.setGrafMatrixDecart(x,y,randomCoordinate==true? (random.Next(2)>0?this.findLastDot()+1:0):0);
                }
            }
        }


        /// <summary>
        /// получение значения в выбранной точке
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int getElementDecartGraf(int x, int y)
        {
            return this.grafMatrixDecart[x][y];
        }

        /// <summary>
        /// количество вершин графа
        /// </summary>
        /// <returns>
        /// количество вершин графа
        /// </returns>

        public int count()
        {
            int count = 0;
            for (int y = 0; y < this.getSizeDecartGrafMatrixY(); y++)
            {
                for (int x = 0; x < this.getSizeDecartGrafMatrixX(); x++)
                {
                    if (getElementDecartGraf(x, y) > 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        //получение координаты точки
        public Node getCoordinateDot(int numberDot)
        {
            Node coordinates=null;
            for (int y = 0; y < this.getSizeDecartGrafMatrixY(); y++)
            {
                for (int x = 0; x < this.getSizeDecartGrafMatrixX(); x++)
                {
                    if (getElementDecartGraf(x, y) > 0)
                    {
                        if (getElementDecartGraf(x, y) == numberDot)
                        {
                            coordinates = new Node(x,y);
                            break;   
                        }
                    }
                }
                if (coordinates!=null) {break;}
            }
            return coordinates;
        }

    }
}
