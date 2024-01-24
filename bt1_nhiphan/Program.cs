using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt1_nhiphan
{
    class Program
    {
        class TNode
        {
            public int Info;
            public TNode left;
            public TNode right;

            public TNode(int x)
            {
                Info = x;
                left = null;
                right = null;
            }
        }
        class Timkiem
        {
            public TNode Root;
            public Timkiem()
            {
                Root = null;
            }
            public void NLR(TNode root)
            {
                if (root != null)
                {
                    Console.Write($"{root.Info}");
                    NLR(root.left);
                    NLR(root.right);
                }
            }
            public void LNR(TNode root)
            {
                if (root != null)
                {

                    LNR(root.left);
                    Console.Write($"{root.Info}");
                    LNR(root.right);
                }
            }
            public void LRN(TNode root)
            {
                if (root != null)
                {

                    LRN(root.left);
                    LRN(root.right);
                    Console.Write($"{root.Info}");
                }
            }
            static void Main(string[] args)
            {
            }
        }
    }
}
