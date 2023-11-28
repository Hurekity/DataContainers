using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Tree
    {
        public class Element
        {
            public int Data { get; set; }
            public Element pLeft { get; set; }
            public Element pRight { get; set; }
            public Element(int data, Element pLeft = null, Element pRight = null)
            {
                this.Data = data;
                this.pLeft = pLeft;
                this.pRight = pRight;
                Console.WriteLine($"EConstructor:\t{GetHashCode()}");
            }
            ~Element()
            {
                Console.WriteLine($"EDestructor:\t{GetHashCode()}");
            }
        }
        public Element Root { get; set; }
        public Tree()
        {
            Root = null;
            Console.WriteLine($"TConstructor:\t{GetHashCode()}");
        }
        ~Tree()
        {
            Console.WriteLine($"TDestructor:\t{GetHashCode()}");
        }
        public void Insert(int Data)
        {
            Insert(Data, Root);
        }
        private void Insert(int Data, Element Root)
        {
            if (this.Root == null) this.Root = new Element(Data);
            if (Root == null) return;
            if (Data < Root.Data)
            {
                if (Root.pLeft == null) Root.pLeft = new Element(Data);
                else Insert(Data, Root.pLeft);
            }
            else
            {
                if (Root.pRight == null) Root.pRight = new Element(Data);
                else Insert(Data, Root.pRight);
            }
        }
        public int MinValue()
        {
            return MinValue(Root);
        }
        int MinValue(Element Root)
        {
            if (Root == null) throw new Exception("Tree is empty");
            return Root.pLeft == null ? Root.Data : MinValue(Root.pLeft);
        }
        public int MaxValue()
        {
            return MaxValue(Root);
        }
        int MaxValue(Element Root)
        {
            if (Root == null) throw new Exception("Tree is empty");
            return Root.pRight == null ? Root.Data : MaxValue(Root.pRight);
        }
        public int Sum()
        {
            return Sum(Root);
        }
        int Sum(Element Root)
        {
            if (Root == null) return 0;
            else return Sum(Root.pLeft) + Sum(Root.pRight) + Root.Data;
        }
        public int Count()
        {
            return Count(Root);
        }
        int Count(Element Root)
        {
            return Root == null ? 0 : Count(Root.pLeft) + Count(Root.pRight) + 1;
        }
        public double Average()
        {
            return (double)Sum(Root) / Count(Root);
        }
        public void Print()
        {
            Print(Root);
            Console.WriteLine();
        }
        void Print(Element Root)
        {
            if (Root == null) return;
            Print(Root.pLeft);
            Console.Write(Root.Data + "\t");
            Print(Root.pRight);
        }
         ///////////////////
         int Depth(Element Root) 
        { 
            if (Root == null) return 0;
            if (Depth(Root.pLeft) + 1 > Depth(Root.pRight) + 1) return Depth(Root.pLeft) + 1;
            else return Depth(Root.pRight) + 1;
        }
        public int Depth()
        {
            return Depth(Root);
        }
        /////////////////////
        void Clear(Element Root)
        {
            if (Root == null) return;
            Clear(Root.pLeft);
            Clear(Root.pRight);
            Root.Data = 0;
        }
        public void Clear()
        {
           Clear(Root);
        }
        //////////////////////
        void Erase(Element Root, int Data)
        { 
            if (Root == null) return;
            if (Data == Root.Data)
            {
                if (Root.pLeft == null && Root.pRight == null)
                {
                    Root = null;
                }
                else
                {
                    if (Count(Root.pLeft)>Count(Root.pRight))
                    {
                        Root.Data = MaxValue(Root.pLeft);
                        Erase(MaxValue(Root.pLeft)),  Convert.ToInt32(Root.pLeft);
                        // idk
                    }
                   
                }
            }
        }
    }
}