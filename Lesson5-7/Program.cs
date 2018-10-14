using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lesson5_7
{
    class Program
    {
        static void Main(string[] args)
        {
           // ListTExample();
         //   NeighborExample();
            DictionaryExample();
        }

        class Song
        {
            public string lyrics;
        }
        class Neighbor
        {
            public string FullName;
            public int FlatNumber;
            public string PhoneNumber;
        }

        static void ArrayListExample()
        {
            ArrayList poem = new ArrayList();
            for (int i = 0; i < 3; i++)
            {
                Song song = new Song();
                song.lyrics = Console.ReadLine();

                poem.Add(song);
            }
            poem.Sort();
            poem.RemoveAt(poem.Count - 1);
            Object[] MyArray = poem.ToArray();
            Console.WriteLine("***********");
            foreach (Song myOb in MyArray)
                Console.WriteLine(myOb.lyrics);
            Console.ReadLine();
        }

        static void ListTExample()
        {
            List<Song> poem = new List<Song>();
            for (int i = 0; i < 5; i++)
            {
                Song song = new Song();
                song.lyrics = Console.ReadLine();

                poem.Add(song);
            }

            poem.RemoveAt(poem.Count - 1);
            Object[] MyArray = poem.ToArray();
            Console.WriteLine("***********");
            foreach (Song myOb in MyArray)
                Console.WriteLine(myOb.lyrics);
            Console.ReadLine();
        }
        public enum Names {Abama=1, Bush, Tramp, Klinton, Reigan};
        static void NeighborExample()
        {            
            List<Neighbor> floorNeibors = new List<Neighbor>();
            Names i;
            for (i = Names.Abama; i <= Names.Reigan; i++)
            {
                Neighbor neighbor = new Neighbor();
                neighbor.FullName = i.ToString();
                neighbor.FlatNumber = (int)i;
                neighbor.PhoneNumber = "+375(29)" + ((int)i).ToString();
                floorNeibors.Add(neighbor);
            }
            Console.WriteLine("Input flat number");
            int findFlatNumber;
            if (Int32.TryParse(Console.ReadLine(), out  findFlatNumber))
            {
                Neighbor findedneighbor = floorNeibors.Find(item => item.FlatNumber == findFlatNumber);
                Console.WriteLine("Phone {0}, Name {1} ", findedneighbor.PhoneNumber,findedneighbor.FullName);
            }
        }


        static void DictionaryExample()
        {
            Dictionary<int,Neighbor > floorNeibors = new Dictionary<int, Neighbor>();
            Names i;
            for (i = Names.Abama; i <= Names.Reigan; i++)
            {
                Neighbor neighbor = new Neighbor();
                neighbor.FullName = i.ToString();
                neighbor.FlatNumber = (int)i;
                neighbor.PhoneNumber = "+375(29)" + ((int)i).ToString();
                floorNeibors.Add((int)i,neighbor);
            }
            Console.WriteLine("Input flat number");
            int findFlatNumber;
            if (Int32.TryParse(Console.ReadLine(), out findFlatNumber))
            {
                var finded  = floorNeibors.FirstOrDefault(item => item.Key == findFlatNumber);               
                Console.WriteLine("Phone {0}, Name {1} ", finded.Value.PhoneNumber,finded.Value.FullName);
            }
        }
    }
}
