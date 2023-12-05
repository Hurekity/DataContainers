using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Delegates.
// Тип, который хранит ссылку на метод, который хранит лист и возвращаемый тип.
// Метод можно вызвать через экземпляр делегата.
// Благодаря делегатам, методы можно передавать, как параметры, в другие методы.
// На делегатах строится обработка событий. Все обработчики событий вызываются через делегаты.
// Делегат объявлвяется при помощи Delegate.
// Через делегат можно вызывать как статические, так и не статические методы.
// Делегат - аналог указателя на функцию, но включает в себя не только ссылку на вызываем метод, а еще и объект, для которого этот метод вызывается.
// При помощи делегатов можно вызывать сразу несколько методов.
// 
namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = MyDelegate.Call(Add, 8, 3);
            Console.WriteLine(result);
            Console.WriteLine(MyDelegate.Call(Sub, 8, 3));
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
