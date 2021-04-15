using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this was just me practicing C# nothing here works
public class LevelGenerator : MonoBehaviour
{
    private string easy_map = "";
    public const int BLOCK_COUNT_X = 5;
    public const int BLOCK_COUNT_Y = 2;
    public GameObject ting;

    public class Person
    {
        public string Name;
        public int Age;
        public bool HasPet;

        public void Greeting()
        {
            Debug.Log("Greetings, my name is " + Name + " and my age is " + Age);
        }
        //public int Calc(int x, int y)
        //{
        //    int number = x + y;
        //    Debug.Log("Greetings");
        //    return number;
        //}
        public int[] block_array = new int[BLOCK_COUNT_X * BLOCK_COUNT_Y];
        public Sprite newsprite = Resources.Load<Sprite>("Sprites/dirt");
        //Debug.Log("newspirte parent?: " + newsprite.transform.Parent)
    }

        
    // Start is called before the first frame update
    void Start()
    {
        easy_map += "2222222222222222";  ///-1
        easy_map += "1111111111111111";  ///-2
        easy_map += "3333333333333333";  ///-3
        easy_map += "1111111111111111";  ///-4
        easy_map += "4444444444444444";  ///-5
        easy_map += "1111111111111111";  ///-6
        easy_map += "5555555555555555";  ///-7
        easy_map += "1111111111111111";  ///-8
        easy_map += "6666666666666666";  ///-9
        easy_map += "0000000000000000";  ///-10
        easy_map += "0000000000000000";  ///-11
        easy_map += "0000000000000000";  ///-12
        easy_map += "0000000000000000";  ///-13
        easy_map += "0000000000000000";  ///-14
        easy_map += "0000000000000000";  ///-15
        easy_map += "0000000000000000";  ///-16

        //Load Sprite From The Resources Folder and use
        //var sp = Resources.Load("SpriteFolder/abc") as Sprite;
        ting = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        generator();
        //Debug.Log("Greetings, my name is ");
    }

    void generator()
    {
        Person person = new Person();

        person.Name = "John";
        person.Age = 28;
        person.HasPet = true;
        //person.newsprite.SetParent(ting);
        //block_array[BLOCK_COUNT_X * BLOCK_COUNT_Y];
        //person.Greeting();

        for (int i = 0; i < BLOCK_COUNT_X; i++)
        {
            for (int j = 0; j < BLOCK_COUNT_Y; j++)
            {
            //     person.block_array[j * BLOCK_COUNT_X + i].getSprite()->setPosition(
            //window.getSize().x / 2.f -
            //  (person.block_array[j * BLOCK_COUNT_X + i].getWidth() * BLOCK_COUNT_X) /
            //    2.f +
            //  person.block_array[j * BLOCK_COUNT_X + i].getWidth() * i,
            //person.block_array[j * BLOCK_COUNT_X + i].getHeight() * j);
            Debug.Log("for loop running " + person.block_array[j * BLOCK_COUNT_X + i] + " " + person.newsprite.name);
            
            //myobject.transform.SetParent(ParentB)
            //person.newsprite
            }
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Person person = new Person();

    //        person.Name = "John";
    //        person.Age = 28;
    //        person.HasPet = true;

    //        person.Greeting();
    //    }
    //}
}
