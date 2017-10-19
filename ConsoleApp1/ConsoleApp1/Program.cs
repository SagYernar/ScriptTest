using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string answers = "asdasdasdasdasdasdasdasdasd";

            List<User> users = new List<User>()
            {
                new User()
                {
                    Name = "1",
                    Answers = "asdasdasdasdasdasdasdasdasd"
                },
                new User()
                {
                    Name = "2",
                    Answers = "asdasdasdasdasdasdasdasdasd"
                },
                new User()
                {
                    Name = "3",
                    Answers = "asdasdasdasdasdasdasdasdasd"
                },
                new User()
                {
                    Name = "4",
                    Answers = "asdasdasdasdasdasdasdasdasd"
                },
            };


            foreach(User user in users)
            {
                for (int i = 0; i < 25; i++)
                {
                    if (user.Answers[i] == answers[i])
                    {
                        user.Result[i] = true;
                    }
                }

                if(user.Answers[1] != answers[1] || user.Answers[5] != answers[5])
                {
                    user.Result[1] = false;
                    user.Result[5] = false;
                }

                //Обработать разбаловку
                if (user.Result[1] == true) { user.Grade++; }
                if (user.Result[5] == true) { user.Grade+=3; }
                
                //Добавить обработку под оценку
                Console.WriteLine("{0} - {1}", user.Name, (user.Grade/35.0)*100 );
            }
            
            Console.ReadLine();
        }
    }
}
