using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations.Process
{
    public class Operation
    {
        // "AllOperations" Metodumu public void olarak tanımlama sebebim geriye bir değer döndürmesini istemediğimden ve
        //program.cs den ulaşmak istediğim için tanımlamamı bu şekilde gerçekleştirdim.

        public void AllOperations()
        {
            // Öncelikle içinde elemanları olan bir sayı dizisi oluşturmam gerekiyor.

            // Initialize Syntax olarak atadığım 5 elemanlı bir sayı dizisi oluşturuyorum.

            // Ve aslında " double[2] array = new double[] { 1, 2, }; " şeklinde atamaktansa tekrardan
            // "new" anahtar kelimesini kullanmama gerek kalmadan programın tanıma özelliğinden yararlanıyorum.
            // Kısaltılmış versiyonunu kullanıyorum bu syntax'ta.

            // Sayı dizimde küsüratlı sayı olma olasılığına karşı double olarak tanımlama yapma kararı aldım.

            double[] array = { 1, 2.3, 3.3, 4, 5 };

            // Öncelikle elde etmek istediğim işlemlerin başlangıç değerlerini el ile 0 olarak tanımladım.

            // average, int ve multiplication değişkenlerini "double" olarak tanımlama sebebim sonucunun küsüratlı bir sonuç çıkma ihtimalinden kaynaklı.
            double sum = 0;
            double average = 0;
            // Çarpım sonucunu multiplication değişkeninde sakladığım için başlangıç değerini 0 değil 1 atamak durumundayız.
            // Çünkü 0 ın yutan eleman olmasından dolayı çarpım sonucu her zaman 0 çıkacaktır. Bundan dolayı 1 ile başlattım.
            double multiplication = 1;

            // Toplama, Ortalama ve Çarpma işlemlerini tek bir metod içerisinde for döngüsünü kullanarak hesapladım.

            // Sayı dizimin içerisindeki sayıların uzunluğu kadar dönüyorum. 

            // Ve her bir değeri toplam sonuçları için "sum" değişkeninde,
            // her bir değeri çarpım sonucunu da "multiplication" değişkenine atayıp, saklıyorum.

            // Tek bir döngü ile iki işlemi bir arada yapıyorum.

            // Bu döngüyü "while" döngüsü yerine "for" kullanarak tercih etmemdeki sebebim ise;
            // "for" döngüsünün "while" döngüsünden daha performanslı ve hızlı olmasından dolayı tercih ettim.

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                multiplication *= array[i];
            }

            // Daha sonra elimdeki "sum" değişkenini basit bir matematik problemiyle döngü dışında çözüyorum.
            average = sum / array.Length;

            // Console.Writline() Metoduyla işlemlerimin sonucunu ekrana yazıyorum.
            Console.WriteLine("Toplam: " + sum);
            Console.WriteLine("Ortalama : " + average);
            Console.WriteLine("Çarpım : " + multiplication);

            // Console.ReadKey(); metoduyla işlemlerimin sonucunu ekranda okuyorum.
            Console.ReadKey();

        }
    }
}
