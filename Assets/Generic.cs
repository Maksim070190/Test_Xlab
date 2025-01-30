using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class Generic : MonoBehaviour
{
    // Start is called before the first frame update
    public class Myclass
    {
        public int i;
        public int j;
    }
    public struct Mystruct
    {
        public string name;
        public int age;
    }

    public class MyList<Titem, T2, T3>
    {
        private Titem[] array = new Titem[4];

        public int count { get; }

        public void Push(int i)
        {

        }
        public void Insert(int index, int item)
        {

        }

        public void Remove(int item) { }

        public void Clear() { }

        public void Indexof(int item)
        {
            return;
        }
        public void RemoveAt(int index) { }
    }
    public void Test<T>(ref T i) where T : class
    {

    }
    void Start()
    {
        var mc = new Myclass();
        var ms = new Mystruct();
        var ms2 = new Mystruct();
        ms = ms2;
        int i = 10;

        List<MyClass> standartlist = new List<Myclass>();

        Test<int>(ref i);
        MyList<Myclass, uint, float> myList = new MyList<Myclass, uint, float>();
            
    }

}*/

public class Generic : MonoBehaviour
{
    // Start is called before the first frame update
    public class MyClass
    {
        public int i;
        public int j;
    }
    public struct MyStruct
    {
        public string name;
        public int age;
    }
     public class MyList<Titem>
    {
        private Titem[] array = new Titem[4];

        public int count { get; }

        public void Push(Titem i)
        {

        }
        public void Insert(int index, Titem item)
        {

        }

        public void Remove(Titem item) { }

        public void Clear() { }

        public void Indexof(Titem item)
        {
            return;
        }
        public void RemoveAt(int index) { }
    }
    public void Test<T>(ref T i)
    {

    }
    void Start()
    {
        var mc = new MyClass();
        var ms = new MyStruct();
        var ms2 = new MyStruct();
        ms = ms2;
        int i = 10;

        List<MyClass> standartList = new List<MyClass>();

        Test<int>(ref i);
        MyList<MyClass> myList = new MyList<MyClass>();
        myList.Push(new MyClass());

            
    }

}
