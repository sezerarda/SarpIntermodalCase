using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingLongWordCase.Process
{
    public class LongWord
    {

        // Bu case'de, LongWord classımda 2 farklı metot tanımlıyorum.
        // Bu soruyu daha ilkel "primitive" kod bloğuyla yapmayı tecih ettim. Özel fonksiyonları kullanmadım. 
        public void FindLongWord()
        {

            // "GetFromTextFile()" metotum ile okuduğum .txt belgesinin içeriğini txtFile adındaki değişkenime atamasını yapıyorum. 
            string txtFile = GetFromTextFile();

            string maxLengthWord = "";

            string word = "";


            // maximum uzunluktaki kelimeleri bir Liste içerisinde "maxLengthWords" değişkenine atama yapıyorum.
            // "maxLengthWords" adında List<string> ten instance alıyorum ve yeni bir liste oluşturyorum.
            List<string> maxLengthWords = new List<string>();


            // txtFile'ımı uzunluğu kadar for döngüsü ile dönüyorum.
            for (int i = 0; i <= txtFile.Length; i++)
            {
                // "ternanary operator" kullanarak if şartı oluşturuyorum boşluk kontrolünü sağlıyorum.
                // txtFile'ımı char olarak kontrol ediyorum.
                char ch = (i< txtFile.Length) ? txtFile[i] : ' ';

                // if şartıyla elime aldığım char harf karakterlerini "word" değişkenine atamasını yapıyorum ve saklıyorum.
                if (char.IsLetter(ch))
                {
                    word += ch;
                }
                // "char.IsPunctuation()" noktalama işaretleri veya boşluk şartını oluşturuyorum.
                else if (char.IsPunctuation(ch) || ch == ' ')
                {
                    // "word" değişkenimdeki kelimeleri "maxLengthWords" adındaki yeni değişkenime atayıp kelimelerin uzunluklarını kıyasladığım döngü yapısına geçiyorum.
                    //  maxLengthWords değişkenim en başta boş olduğu için ilk kelimeyi ekleme işlemini bu if yapısında yapıyorum.
                    if (maxLengthWords.Count == 0)
                    {
                        maxLengthWords.Add(word);
                    }
                    else
                    // ilk kelimeden sonra maxLengthWords değişkenim 0 olmayacağı için else ile uzunluk karşılaştırması yapıyorum.
                    {
                        // Uzunluk kıyaslaması için bir if-else şartı oluşturmam gerekiyor.

                        // En başta tanımladığım maxLengthWords değişkenini liste şeklinde oluşturmamdan kaynaklı dizi şeklinde kıyaslamasını yapıyorum.
                        // Yeni kelimem eğer maxLengthWords dizisi içerisindeki kelimelerden daha uzunsa dizimin içerisini clear metodu ile sıfırlıyorum ve
                        //maxLengthWords Listeme yeni gelen "word" değişkenindeki kelimenin atamasını yapıyorum.
                        if (word.Length > maxLengthWords[0].Length)
                        {
                            maxLengthWords.Clear();
                            maxLengthWords.Add(word);
                        }
                        // Bir metin belgesinde sadece 1 tane en uzun kelime olmayabilir. Eş uzunluklarda 1'den fazla en uzun kelimeye sahip olma ihtimalinden dolayı
                        // bütün bu eş uzunluktaki kelimeleri "maxLengthWords" listemde saklıyorum ki hepsini gösterebileyim.
                        else if (word.Length == maxLengthWords[0].Length)
                        {
                            maxLengthWords.Add(word);

                        }
                    }

                    // Bir kelime tamamlandığında, kelimeleri sakladığım "word" değişkenimin içerisini null yapıyorum ki
                    // boşluk veya özel karakterden sonra gelen "word" değişkenimde bir sonraki kelimeyi saklayabileyim.
                    word = "";

                }
            }

            // .txt belgesi okuma işlemi tamamlandıktan sonra elimde olan "maxLengthWords" adındaki listemde en uzun kelimeler bulunacak.
            // Bu yüzden "foreach" döngüsü ile içerisindeki bütün kelimeleri dönüyorum ve Console.WritLine(); ile ekranıma yazdırma işlemini gerçekleştiriyorum.
            foreach (var item in maxLengthWords)
            {
                Console.WriteLine(item);
            }

        }

        // "GetFromTextFile" metodum sadece .txt dosyası içerisindekileri okuyup geri döndürmesini istediğim bir metot.
        // Bu metoda dışarıdan ulaşılıp, bir değişiklik yapılmasını istemediğimden dolayı private olarak tanımladım.
        // Ve bana string tipinde bir değer döndürmesini istediğim için dönüş tipini "string" olarak tanımladım.
        private string GetFromTextFile()
        {
            // system.IO kütüphanesini kullanarak Directory sınıfıyla .txt belgemin yoluna ulaşıyorum.

            string b = Directory.GetCurrentDirectory();

            // Soruda "verilen bir metin dosyası" dendiği için File class'yla bir dosya oluşturmuyorum. data.txt dosyasını el ile oluşturuyorum.
            // File classıyla sadece "ReadAllText" metodunu kullanarak okuma işlemini yapıyorum. "ReadAllText" metotunun içerisine "GetCurrentDirectory()"
            // metodundan gelen yolu giriyorum ve direkt olarak return diyerek okunan .txt belgesini döndürüyorum.

            return File.ReadAllText("../../../data.txt");
        }
    }
}
