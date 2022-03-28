using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    class Write
    {
        public void dosyayaYaz(string difSecim,string shapeSecim)
        {
            string dosya_yolu = @"D:\AhmetReact\c#\WindowsFormsApp1\WindowsFormsApp1\deneme.txt";
            //İşlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosya varsa açılacağını yoksa oluşturulacağını belirtir,
            //3.parametre dosyaya erişimin veri yazmak için olacağını gösterir.
            StreamWriter sw = new StreamWriter(fs);
            //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.
            sw.WriteLine(difSecim);
            sw.WriteLine(shapeSecim);
           
            //Dosyaya ekleyeceğimiz iki satırlık yazıyı WriteLine() metodu ile yazacağız.
            sw.Flush();
            //Veriyi tampon bölgeden dosyaya aktardık.
            sw.Close();
            fs.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.
        }
        public void Custom(string row, string colm, string shapeSecim)
        {
            string dosya_yolu = @"D:\AhmetReact\c#\WindowsFormsApp1\WindowsFormsApp1\deneme.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(row);
            sw.WriteLine(colm);
            sw.WriteLine(shapeSecim);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        public void NotCustom(string difSecim, string shapeSecim,string adet)
        {
            string dosya_yolu = @"D:\AhmetReact\c#\WindowsFormsApp1\WindowsFormsApp1\deneme.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(difSecim);
            sw.WriteLine(shapeSecim);
            sw.WriteLine(adet);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

     



    }
}
