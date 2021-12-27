using System;

namespace struct_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            dikdortgen dikdortgen = new dikdortgen();
            dikdortgen.Uzunkenar = 4;
            dikdortgen.Kısakenar = 3;
            Console.WriteLine("dikdörtgen alan hesabı: {0} ", dikdortgen.Alanhesapla());
            dikdortgen_struct Dikdortgen_Struct;
            Dikdortgen_Struct.Kısakenar = 4;
            Dikdortgen_Struct.Uzunkenar = 3;
            Console.WriteLine("dikdörtgen alan hesabı: {0} ", Dikdortgen_Struct.Alanhesapla());
        }
    }
    //normal class lar kısakenar ve uzun kenara değer vermezseniz varsayılan olarak 
    // sıfır atar ve alan hesapla cağrılabilir
    //struct ta varsayılan değer olmaz değeri atamak gerekir yoksa alan hesapla cağırılmaz
    //struct new ile yeni yapı oluşturmadan sadece isim verilerek main metot a çağrılabilir
    
    class dikdortgen
    {
        public int Kısakenar;

        public int Uzunkenar;

        public long Alanhesapla()
        {
            return this.Kısakenar * this.Uzunkenar;
        }
    }

    struct dikdortgen_struct
    {
        public int Kısakenar;
        public int Uzunkenar;
        public long Alanhesapla()
        {
            return this.Kısakenar * this.Uzunkenar;
        }
    }
}
