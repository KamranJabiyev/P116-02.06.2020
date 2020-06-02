using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericType
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Generic type
            //MyList myList = new MyList();
            //MyList<string> myList = new MyList<string>();
            //myList.AddList("Ulvi");
            //myList.AddList("Hesen");
            //myList.AddList("Elnur");
            //myList.ShowList();

            ////MyList1 intList = new MyList1();
            //MyList<int,object> intList = new MyList<int,object>();
            //intList.AddList(1);
            //intList.AddList(2);
            //intList.AddList(3);
            //intList.ShowList();

            ////MyList2 personList = new MyList2();
            //MyList<Person,Human> personList = new MyList<Person,Human>();
            //personList.AddList(new Person("Elgun", "Quluzade"));
            //personList.AddList(new Person("Zaur", "Ferruxzade"));
            //personList.ShowList();

            //MyList<Human, object> hhhh = new MyList<Human, object>();
            //hhhh.AddList()
            //MyList<Student, Person> sss = new MyList<Student, Person>();
            //sss.AddList()
            //Write<string>("Kamran");
            //Write<int>(123);
            //Write<Person>(new Person("Hesen", "Hesenbeyli"));
            #endregion

            #region Collection - ArrayList,List,Queu,Stack,Dictionary
            #region ArrayList - qarashiq datalar saxlayir
            //ArrayList arrList = new ArrayList(10);
            //arrList[9] = "Test";
            //Console.WriteLine(arrList[9]);
            //arrList.Add("Kamran");
            //arrList.Add(5);
            //arrList.Add(true);
            //arrList.Add(new Person("Hesen", "Hesenli"));
            ////arrList.Clear();
            ////arrList.Remove(true);
            ////arrList.RemoveAt(1);
            ////arrList.RemoveAt(1);
            //foreach (var item in arrList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region List - generic
            //List<string> list = new List<string>(10);
            //list.Add("Kamran");
            //list.Add("Elgun");
            //list.Add("Elshen");
            ////list[0] = "Elgun";
            ////Console.WriteLine(list[0]);
            //list.Remove("Elgun");
            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //List<Person> list = new List<Person>();
            //list.Add(new Person(1,"Elgun", "Quluzade"));
            //list.Add(new Person(2,"Zaur", "Ferruxzade"));
            //list.Add(new Person(3, "1Zaur", "Ferruxzade"));
            ////Console.WriteLine(list.Find(p => p.Id == 1));
            //list.Remove(list.Find(p => p.Name == "Elgun"));
            //foreach (Person item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
        }

        #region Generic type
        public static void Write<T>(T item)
        {
            Console.WriteLine(item);
        }

        //public static void Write(int item)
        //{
        //    Console.WriteLine(item);
        //}

        //public static void Write(Person item)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion
    }

    #region Generic type - constraint
    //class MyList<T> where T:class
    class MyList<T,U> where T:U
    {
        private T[] _list;
        public MyList()
        {
            _list = new T[0];
        }

        public void AddList(T str)
        {
            Array.Resize(ref _list, _list.Length + 1);
            _list[_list.Length - 1] = str;
        }

        public void ShowList()
        {
            foreach (T item in _list)
            {
                Console.WriteLine(item);
            }
        }
    }

    //class Test : MyList<Person>
    //{
    //}

    //class MyList1
    //{
    //    private int[] _list;
    //    public MyList1()
    //    {
    //        _list = new int[0];
    //    }

    //    public void AddList(int str)
    //    {
    //        Array.Resize(ref _list, _list.Length + 1);
    //        _list[_list.Length - 1] = str;
    //    }

    //    public void ShowList()
    //    {
    //        foreach (int item in _list)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}

    //class MyList2
    //{
    //    private Person[] _list;
    //    public MyList2()
    //    {
    //        _list = new Person[0];
    //    }

    //    public void AddList(Person str)
    //    {
    //        Array.Resize(ref _list, _list.Length + 1);
    //        _list[_list.Length - 1] = str;
    //    }

    //    public void ShowList()
    //    {
    //        foreach (Person item in _list)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}

    class Human { }

    class Student : Person { }

    class Person:Human
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public Person()
        {
        }
        public Person(int id,string name,string lastname)
        {
            Id = id;
            Name = name;
            Lastname = lastname;
        }
        public override string ToString()
        {
            return $"{Name} {Lastname}";
        }
    }
    #endregion
}
