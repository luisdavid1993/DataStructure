using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeBinary tree = new TreeBinary();
            NodoBinary raiz = tree.Insertar(37, null);
            //tree.Insertar(2, raiz);
            //tree.Insertar(8, raiz);
            //tree.Insertar(1, raiz);
            //tree.Insertar(4, raiz);
            //tree.Insertar(3, raiz);
            //tree.Insertar(5, raiz);
            //tree.Insertar(7, raiz);
            //tree.Insertar(11, raiz);
            //tree.Insertar(9, raiz);
            //tree.Insertar(0, raiz);
            //tree.Insertar(-1, raiz);
            //tree.Insertar(10, raiz);
            //tree.Insertar(12, raiz);
            //tree.Insertar(14, raiz);





            //tree.Insertar(23, raiz); tree.Insertar(108, raiz); tree.Insertar(59, raiz); tree.Insertar(86, raiz); tree.Insertar(64, raiz); tree.Insertar(94, raiz); tree.Insertar(14, raiz); tree.Insertar(105, raiz); tree.Insertar(17, raiz); tree.Insertar(111, raiz); tree.Insertar(65, raiz); tree.Insertar(55, raiz); tree.Insertar(31, raiz); tree.Insertar(79, raiz); tree.Insertar(97, raiz); tree.Insertar(78, raiz); tree.Insertar(25, raiz); tree.Insertar(50, raiz); tree.Insertar(22, raiz); tree.Insertar(66, raiz); tree.Insertar(46, raiz); tree.Insertar(104, raiz); tree.Insertar(98, raiz); tree.Insertar(81, raiz); tree.Insertar(90, raiz); tree.Insertar(68, raiz); tree.Insertar(40, raiz); tree.Insertar(103, raiz); tree.Insertar(77, raiz); tree.Insertar(74, raiz); tree.Insertar(18, raiz); tree.Insertar(69, raiz); tree.Insertar(82, raiz); tree.Insertar(41, raiz); tree.Insertar(4, raiz);
            //tree.Insertar(48, raiz); tree.Insertar(83, raiz); tree.Insertar(67, raiz); tree.Insertar(6, raiz); tree.Insertar(2, raiz); tree.Insertar(95, raiz); tree.Insertar(54, raiz); tree.Insertar(100, raiz); tree.Insertar(99, raiz); tree.Insertar(84, raiz); tree.Insertar(34, raiz); tree.Insertar(88, raiz); tree.Insertar(27, raiz); tree.Insertar(72, raiz); tree.Insertar(32, raiz); tree.Insertar(62, raiz); tree.Insertar(9, raiz); tree.Insertar(56, raiz); tree.Insertar(109, raiz); tree.Insertar(115, raiz); tree.Insertar(33, raiz); tree.Insertar(15, raiz); tree.Insertar(91, raiz); tree.Insertar(29, raiz); tree.Insertar(85, raiz); tree.Insertar(114, raiz); tree.Insertar(112, raiz); tree.Insertar(20, raiz); tree.Insertar(26, raiz); tree.Insertar(30, raiz); tree.Insertar(93, raiz); tree.Insertar(96, raiz); tree.Insertar(87, raiz); tree.Insertar(42, raiz); tree.Insertar(38, raiz); tree.Insertar(60, raiz); tree.Insertar(7, raiz);
            //tree.Insertar(73, raiz); tree.Insertar(35, raiz); tree.Insertar(12, raiz); tree.Insertar(10, raiz); tree.Insertar(57, raiz); tree.Insertar(80, raiz); tree.Insertar(13, raiz); tree.Insertar(52, raiz); tree.Insertar(44, raiz); tree.Insertar(16, raiz); tree.Insertar(70, raiz); tree.Insertar(8, raiz); tree.Insertar(39, raiz); tree.Insertar(107, raiz); tree.Insertar(106, raiz); tree.Insertar(63, raiz); tree.Insertar(24, raiz); tree.Insertar(92, raiz); tree.Insertar(45, raiz); tree.Insertar(75, raiz); tree.Insertar(116, raiz); tree.Insertar(5, raiz); tree.Insertar(61, raiz); tree.Insertar(49, raiz); tree.Insertar(101, raiz); tree.Insertar(71, raiz); tree.Insertar(11, raiz); tree.Insertar(53, raiz); tree.Insertar(43, raiz); tree.Insertar(102, raiz); tree.Insertar(110, raiz); tree.Insertar(1, raiz); tree.Insertar(58, raiz); tree.Insertar(36, raiz); tree.Insertar(28, raiz); tree.Insertar(76, raiz);
            //tree.Insertar(47, raiz); tree.Insertar(113, raiz); tree.Insertar(21, raiz); tree.Insertar(89, raiz); tree.Insertar(51, raiz); tree.Insertar(19, raiz); tree.Insertar(3, raiz);

            tree.Insertar(38, raiz);
            tree.Insertar(10, raiz);
            tree.Insertar(11, raiz);
            tree.Insertar(12, raiz);
            tree.Insertar(13, raiz);
            //tree.Insertar(3, raiz);
            //tree.Insertar(4, raiz);


            //  tree.BorrarNodo(8, raiz);
            NodoBinary nodoBinary = tree.Buscar(4, raiz);
            int longitud = tree.height(raiz);
            var nodoBinaries = tree.TopView(raiz);
            Console.ReadLine();

            Console.WriteLine("Menor del árbol = " + tree.EncuentraMinimo(raiz).Dato);
            Console.WriteLine("Mayor del árbol = " + tree.EncontrarMaximo(raiz).Dato);

            Console.ReadLine();

            tree.TransversaInorder(raiz);
            Console.ReadLine();




            NodoBinary padre = tree.BuscarPadre(10, raiz);
            Console.WriteLine(string.Format("Padre de {0} = {1}", 10, padre.Dato));


            //BinaryTreeTopView binaryTreeTopView = new BinaryTreeTopView();
            //Node root = binaryTreeTopView.Insertar(37, null);
            //binaryTreeTopView.Insertar(38, root);
            //binaryTreeTopView.Insertar(10, root);
            //binaryTreeTopView.Insertar(11, root);
            //binaryTreeTopView.Insertar(12, root);
            //binaryTreeTopView.Insertar(13, root);
            //binaryTreeTopView.TopView(root);


            Console.ReadLine();
        }
    }
}
