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
        class TimkiemCayNhiPhan
        {
            public TNode Root;
            public TimkiemCayNhiPhan()
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
            public void ThemNode(ref TNode root, int x)
            {
                if (root == null)
                {
                    TNode p = new TNode(x);
                    root = p;
                }
                else if (root.Info > x)
                    ThemNode(ref root.left, x);
                else if (root.Info < x)
                    ThemNode(ref root.right, x);
            }
            public void Taocay()
            {
                Console.WriteLine("Cho biết số nút trong cây:");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i <= n; i++)
                {
                    Console.Write("Nhập giá trị Node thu " + i + ":");
                    int x = int.Parse(Console.ReadLine());
                    ThemNode(ref Root, x);
                }


            }
            public TNode TiemKiem(TNode root, int x)
            {
                TNode ketqua = null;
                if (root != null)
                {
                    if (root.Info == x)
                        ketqua = root;
                    else if (x < root.Info)
                        ketqua = TiemKiem(root.left, x);
                    else
                        ketqua = TiemKiem(root.right, x);
                }
                return ketqua;

            }
            static void Main(string[] args)
            {
                Console.OutputEncoding=Encoding.UTF8;
                string chon = "y";

                while (chon.ToLower() != "n")
                {
                    TimkiemCayNhiPhan tkcnp = new TimkiemCayNhiPhan();
                    tkcnp.Taocay();
                    Console.WriteLine("Ket qua duyet cay:");

                    Console.Write("\n NLR:");
                    tkcnp.NLR(tkcnp.Root);

                    Console.Write("\n LNR:");
                    tkcnp.LNR(tkcnp.Root);

                    Console.Write("\n LRN:");
                    tkcnp.LRN(tkcnp.Root);

                    Console.WriteLine("\nGiá trị nút cần tìm:");
                    int x = int.Parse(Console.ReadLine());
                    TNode ketqua = tkcnp.TiemKiem(tkcnp.Root, x);
                    if (ketqua == null)
                    {
                        Console.WriteLine($"{x} khong xuat hien trong cay");
                    }
                    else
                    {
                        Console.WriteLine($"{x} co xuat hien trong cay");
                    }

                    Console.Write("\n Tiếp tục (y/n)? ");
                    chon = Console.ReadLine();
                }
            }
        }
    }
}
