using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDuplicateCase.Process
{
    public class NumberArray
    {
        // FindDuplicate adında bir void türünden metot oluşturuyorum.Girdiğim sayıları dizi şeklinde parametre olarak alabilmesi için "int[] array"
        // parametresini veriyorum.
        public void FindDuplicate(int[] array)
        {
            // "repeat" değişkeni adında Liste şeklinde "int" tipinde bir liste oluşturuyorum ki dizi içerisindeki tekrar eden sayıları sakladığım bir Liste oluşturmuş olayım.
            List<int> repeat = new List<int>();

            // parametre olarak girilen değerleri "array" adını verdiğim değişkenimle alıyorum ve 
            // bu sayı dizisini for döngüsü ile dönüyorum.

            // Dizimin ilk değerini i değişkeni ile tanımlıyorum. Ve dizimin diğer elemanlarıyla if yapısı ile eşitlik olup olmadığını, aynı sayıdan tekrar eden sayıları
            // yakalamaya çalışıyorum.

            for (int i = 0; i < array.Length; i++)
            {
                // 2. for döngüsü seçilen i adındaki dizi değerinin diğer dizi elemanlarıyla kontrolünü sağladığım yer. Buna da j adında değişkenle tanımlıyorum.
                for (int j = i + 1; j < array.Length; j++)
                {
                    // Eğer seçilen i dizi değeri ile kontrolünü sağladığım j adındaki diğer dizi elemanları arasında eşitlik kontrolü sağlanıyor.
                    // Ve Contains metoduyla da dizi parametre olarak aldığım "array[i]" değerinin repeat adındaki liste içerisinde olup olmadığını kontrol eder.
                    // Contains metodu, Bool türünde yani "true" veya "false" olarak dönüş yaptığından dolayı if şartıma bunu da ekledim ki eğer sayı dizisi içerisinde
                    //aynı sayıdan birden fazla kez tekrar edildiği takdirde hepsini repeat dizimde saklamak istemiyorum.
                    // Tekrar eden sayıların Sadece bir temsilcisini almak istiyorum.
                    
                    // Bu yüzden sayılar eşitse ve repeat dizimde yoksa bunu repeat dizime eklemesini istiyorum.
                    if (array[i] == array[j] && !repeat.Contains(array[i]))
                    {
                        // Ve burada eklemesini yapıyorum.
                        repeat.Add(array[i]);

                    }
                }
            }

            // foreach döngüsü ile Liste olarak oluşturduğum repeat listemin içerisindeki elemanları dönüyorum.
            foreach (var item in repeat)
            {
                // Ekranıma yazdrma işlemini gerçekleştiriyorum.
                Console.WriteLine(item);
            }
        }
    }
}
