using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//класс рисования графа по заданной матрице смежности и сдвигу для рисования

namespace GrafLab1
{
    class VisualGraph
    {
        // сдвиг на который нужно передвинуть нарисованный граф
        private  int displasmentX;
        private int displasmentY;
        private Panel panel;
        private const int scaleGraf = 50;
        private const int scalePoint = 3;//должено быть нечетно что бы поставить в центр 


        public VisualGraph(int displasmentX, int displasmentY, Panel panel)
        {
            this.setDisplasmentX(displasmentX);
            this.setDisplasmentY(displasmentY);
            this.panel = panel;
        }



        public int getdisplasmentX()
        {
            return this.displasmentX;
        }

        private void setDisplasmentX(int displasment)
        {
            this.displasmentX = displasment;
        }


        private void setDisplasmentY(int displasmentY)
        {
            this.displasmentY = displasmentY;
        }

        public int getDisplasmentY()
        {
            return this.displasmentY;
        }

        public int getBetweenScalePoint() {
            return scalePoint / 2 + 1;
        }

        /// <summary>
        /// Функция вывода графа на экран
        /// </summary>
        /// <param name="graf">
        /// матрица смежности графа котороый нужно построить
        /// </param>
        public void paintGraf(Graph graf)
        {
            System.Drawing.Point pointStart = new System.Drawing.Point();
            System.Drawing.Point pointEnd = new System.Drawing.Point();
            System.Drawing.Graphics grafic = this.panel.CreateGraphics();
            grafic.Clear(Color.FromName("Control"));

            //рисую точки графа
            for (int y = 0; y < graf.getGrafDecart().getSizeDecartGrafMatrixY() ; y++)
            {
                for (int x = 0; x < graf.getGrafDecart().getSizeDecartGrafMatrixX() ; x++)
                {
                    if (graf.getGrafDecart().getElementDecartGraf(x, y) > 0)
                    {
                        pointStart =
                            new System.Drawing.Point(x*scaleGraf + displasmentX,
                                                     y*scaleGraf + displasmentY);
                        String stringWay = "";
                        int bufi = graf.getGrafDecart().getElementDecartGraf(x, y);
                        if (graf.GrafSizeWay.Count>0)
                        stringWay = "(" + graf.GrafSizeWay[bufi-1][bufi-1].SizeWay.ToString() + ")";
                        if (graf.contractionDot == graf.getGrafDecart().getElementDecartGraf(x, y))
                        {
                            grafic.DrawRectangle(System.Drawing.Pens.Red,
                                                 new System.Drawing.Rectangle(pointStart.X - getBetweenScalePoint(),
                                                                              pointStart.Y - getBetweenScalePoint(),
                                                                              scalePoint, scalePoint));
                            grafic.DrawString(Convert.ToString(graf.getGrafDecart().getElementDecartGraf(x, y))+stringWay,
                                              new Font("Arial", 10), new SolidBrush(Color.Red), pointStart);
                        }
                        else
                        {
                            grafic.DrawRectangle(System.Drawing.Pens.Black,
                                                 new System.Drawing.Rectangle(pointStart.X - getBetweenScalePoint(),
                                                                              pointStart.Y - getBetweenScalePoint(),
                                                                              scalePoint, scalePoint));
                            grafic.DrawString(Convert.ToString(graf.getGrafDecart().getElementDecartGraf(x, y))+stringWay,
                                              new Font("Arial", 10), new SolidBrush(Color.Black), pointStart);
                        }

                    }
                   /* if (coordinates.getEdge())
                    {
                            grafic.DrawLine(System.Drawing.Pens.Black, pointStart , pointEnd);
                    }*/
                }
            }
            //рисую ребра графа
           for (int y = 0; y<graf.getGraf().Count;y++)
           {
               for (int x = 0; x < graf.getGraf().Count; x++)
               {
                   if (graf.getCoordinates(x, y))
                   {

                       pointStart =
                           new Point(graf.getCoordinatePoint(x).getStartCoordinate().getX()*scaleGraf + displasmentX,
                                     graf.getCoordinatePoint(x).getStartCoordinate().getY()*scaleGraf + displasmentY);
                       pointEnd =
                           new Point(graf.getCoordinatePoint(y).getStartCoordinate().getX()*scaleGraf + displasmentX,
                                     graf.getCoordinatePoint(y).getStartCoordinate().getY()*scaleGraf + displasmentY);
                       grafic.DrawLine(System.Drawing.Pens.Black, pointStart, pointEnd);
                       Point pointString = new Point(((pointStart.X + pointEnd.X)/2),
                                                     ((pointStart.Y + pointEnd.Y)/2));
                    /*   if(x<y)
                       {
                           if (graf.GrafSizeWay[x][y].SizeWay == 0)
                           {
                               grafic.DrawString(Convert.ToString(graf.GrafSizeWay[y][x].SizeWay),
                                                 new Font("Arial", 10), new SolidBrush(Color.Brown), pointString);
                           }
                       else
                           {

                               grafic.DrawString(Convert.ToString(graf.GrafSizeWay[x][y].SizeWay),
                                                 new Font("Arial", 10), new SolidBrush(Color.Brown), pointString);
                           }
                       }*/
                   }

               }
           }

        }
    }
}
