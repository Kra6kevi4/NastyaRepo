using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//координаты вершин из матрицы смежности
namespace GrafLab1
{
    class Coordinates
    {
        private Boolean edge = false;//ребро графа true- есть ребро false  нет ребра
        private Node startCoordinate = new Node();
        private Node endCoordinate = new Node();


        public Coordinates(Boolean edge, Node startCoordinate, Node endCoordinate)
        {
            this.setEdge(edge);
            this.setStartCoordinate(startCoordinate);
            this.setEndCoordinate(endCoordinate);
        }

        public Coordinates() {
            this.setEdge(false);
            this.setStartCoordinate(null);
            this.setEndCoordinate(null);
        }

        public Boolean getEdge()
        {
            return this.edge;
        }

        public void setEdge(Boolean edge)
        {
            this.edge = edge;
        }

        public Node getStartCoordinate()
        {
            return this.startCoordinate;
        }

        public void setStartCoordinate(Node startCoordinate)
        {
            this.startCoordinate = startCoordinate;
        }

        public Node getEndCoordinate()
        {
            return this.endCoordinate;
        }

        public void setEndCoordinate(Node endCoordinate)
        {
            this.endCoordinate = endCoordinate;
        }

    }
}
