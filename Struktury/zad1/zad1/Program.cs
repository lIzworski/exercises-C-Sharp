namespace zad1
{
    internal class Program
    {
        
        public struct TaskToDo
        {
            public string title;
            public Begining Begining;
            public End End;
            public string comment;
            public User User;

            public TaskToDo(string title, Begining begining, End end, string coment, User user)
            {
                this.title = title;
                Begining = begining;
                End = end;
                this.comment = coment;
                User = user;
            }
        }
        public struct Begining
        {
            public DateTime BeginingTime;
            public User User;

            public Begining(DateTime dateTime ,User user )
            {
                BeginingTime = dateTime;
                User = user;
            }
        }
        public struct End
        {
            public DateTime Ending;
            public User User;
            public End(DateTime dateTime, User user)
            {
                Ending = dateTime;
                User = user;
            }
        }
        public struct User
        {
            public string name;
            public bool Online;

            public User(string name, bool Online)
            {
                this.name = name;
                this.Online = Online;
            }
        }
        public class ToDo
        {
            List<TaskToDo> toDos = new List<TaskToDo>();
            public void AddNewTaskToDo(TaskToDo Tooodoo)
            {
                toDos.Add( Tooodoo );
            }
            public void BrowseTasksToDo()
            {
                int i = 0;
                Console.WriteLine();
                foreach (TaskToDo Tooodoo in toDos)
                {
                    Console.WriteLine($"ID : {i} Tytuł : {Tooodoo.title} ");
                    Console.WriteLine($"Czas rozpoczęcia  : {Tooodoo.Begining.BeginingTime} przez {Tooodoo.Begining.User.name}");
                    Console.WriteLine($"Czas zakończenia  : {Tooodoo.End.Ending} przez {Tooodoo.End.User.name}");
                    Console.WriteLine($"Komentarz : {Tooodoo.comment}, autor : {Tooodoo.User.name} status online : {Tooodoo.User.Online} ");
                    i++;
                    Console.WriteLine();
                }
            }
            public void DeleteTaskFromToDo(int ID)
            {
                toDos.RemoveAt(ID);
            }
        }
        static void Main(string[] args)
        {
            ToDo td = new ToDo();
            User Janek = new User("Jan",false);
            User Zbyszek = new User("Zbyszek", true);
            User Karol = new User("Karol",false);

            td.AddNewTaskToDo(new TaskToDo("Żwirek i Muchomorek", new Begining(DateTime.UtcNow, Janek), new End(DateTime.Now,Janek), "było cieżko, ale poszło gładko :)", Karol));
            td.AddNewTaskToDo(new TaskToDo("Strzelanie", new Begining(DateTime.UtcNow, Janek), new End(DateTime.Now, Zbyszek), "Dobrze strzelam :)", Zbyszek));
            td.AddNewTaskToDo(new TaskToDo("Worzenie", new Begining(DateTime.UtcNow, Karol), new End(DateTime.Now, Karol), "Ciezko była ale już z głowy:)", Zbyszek));
            td.AddNewTaskToDo(new TaskToDo("Odkopywanie", new Begining(DateTime.UtcNow, Zbyszek), new End(DateTime.Now, Zbyszek), "Było mineło :)", Karol));
            td.AddNewTaskToDo(new TaskToDo("zwijanie", new Begining(DateTime.UtcNow, Karol), new End(DateTime.Now,Janek), "najpierw trzeba zwiąć żeby póżniej było co palić :)", Zbyszek));
            td.AddNewTaskToDo(new TaskToDo("Podnoszenie", new Begining(DateTime.UtcNow, Janek), new End(DateTime.Now, Karol), "Następnym nie dam zjeść ostatniego posiłku :)", Janek));
            td.AddNewTaskToDo(new TaskToDo("lizanie", new Begining(DateTime.UtcNow, Zbyszek), new End(DateTime.Now, Zbyszek), "Nigdy wiecej :)", Zbyszek));
            td.AddNewTaskToDo(new TaskToDo("siedzenie", new Begining(DateTime.UtcNow, Karol), new End(DateTime.Now, Karol), "Zawsze przyjemnie :)", Karol));
            td.AddNewTaskToDo(new TaskToDo("skakanie", new Begining(DateTime.UtcNow, Zbyszek), new End(DateTime.Now, Zbyszek), "Czasem też trzeba :)", Janek));

            td.BrowseTasksToDo();

            td.DeleteTaskFromToDo(2);

            td.BrowseTasksToDo();
        }
    }
}