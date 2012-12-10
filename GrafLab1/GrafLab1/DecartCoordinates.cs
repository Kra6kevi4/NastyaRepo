using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//декартовы координаты
namespace GrafLab1
{
    class Node
    {
        private int x = 0;
        private int y = 0;

        public Node() {
            this.setX(0);
            this.setY(0);
        }

        public Node(int x , int y) {
            this.setX(x);
            this.setY(y);
        }


        public int getX()
        {
            return this.x;

        }

        public void setX(int x)
        {
            this.x = x;
        }

        public int getY()
        {
            return this.y;

        }

        public void setY(int y)
        {
            this.y = y;
        }
    }
}
