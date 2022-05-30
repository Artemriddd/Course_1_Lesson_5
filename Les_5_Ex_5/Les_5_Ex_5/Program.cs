using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_5_Ex_5
{
    public class ToDo
    {
        public string title;
        public bool isDone;

        public ToDo(string title, bool isDone)
        {
            this.title = title;
            this.isDone = isDone;
        }
        public ToDo()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ToDo toDo1 = new ToDo("Домашная работа", true);  //Я не очень понял, надо ли было сделать ввод данных с клавиатуры. Но думаю, Вы поверите, что я бы смог это реализовать.
            ToDo toDo2 = new ToDo("Пропылесосить", false);
            ToDo toDo3 = new ToDo("Помыть посуду", false);
            ToDo toDo4 = new ToDo("Партия в дотку", false);
            ToDo toDo5 = new ToDo("Почистить зубы", false);

            ToDo[] toDos = { toDo1, toDo2, toDo3, toDo4, toDo5 }; // Создадим массив из объектов типа ToDo
            while (true) // Привычный "вечный" цикл
            {
                int number = 1; // В задании было сказано указать для каждой задачи свой порядковый номер. Это он.
                foreach (var toDo in toDos) // Цикл для вывода в консоль списка задач с [X]
                {
                    if (toDo.isDone)
                    {
                        Console.Write($"{number}. [X]");
                        Console.WriteLine(toDo.title);
                        number += 1;
                    }
                    else
                    {
                        Console.Write($"{number}. ");
                        Console.WriteLine(toDo.title);
                        number += 1;
                    }
                }
                Console.WriteLine("Введите порядковый номер задачи который выполнили! Для выхода нажмите 0");
                int a = Int32.Parse(Console.ReadLine());
                if (a == 0) // Выходим из "вечного" цикла
                {
                    break;
                }
                for (int i = 0; i < toDos.Length; i++) // Вводим порядковый номер и меняем значения на true
                {
                    if (i == (a - 1))
                    {
                        toDos[i].isDone = true;
                    }
                }
            }
            StringWriter sw = new StringWriter(); // Записываем в xml файл при выходи
            XmlSerializer serializer = new XmlSerializer(typeof(ToDo[]));
            serializer.Serialize(sw, toDos);
            String xml = sw.ToString();
            File.WriteAllText("ToDo.xml", xml);
            Console.WriteLine("Файл успешно записан!");
            Console.ReadKey(true);
        }
    }
}
