using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Project
    {
        private string nameOfProject = "";
        List<Pracownik> employeesInTheProject = new List<Pracownik>();
        List<Task> listOfTasks = new List<Task>();
        int freeEmplyees = 0;
        public Project(string nameOfProject)
        {
            this.nameOfProject = nameOfProject;
        }

        public void AddAEmployeeToProject(Pracownik p1)
        {
            employeesInTheProject.Add(p1);
            freeEmplyees++;
        }
        public void AddNewTask(int id, string taskName)
        {
            Task t1 = new Task(id , taskName);
            listOfTasks.Add(t1);
        }

        public void AddFreeEmployeeToTask(int id, Pracownik p1)
        {
            if (employeesInTheProject.Contains(p1))
            {
                foreach(Task t in listOfTasks)
                {
                    if( t.ID == id)
                    {
                        t.AddAEmployeeToTask(p1);
                    }
                }
            }
        }

        public void showWhoWorkWere()
        {
            foreach(Task t in listOfTasks)
            {
                Console.Write($"Nazwa zadania : {t.TaskName}");
                t.ShowEmployeesIntask();
                Console.WriteLine();
            }
        }

        public void ShowPeopleInProject()
        {
            foreach (Pracownik t in employeesInTheProject)
            {
                Console.WriteLine( t.Name + " ");

            }
        }
        public void ShowTasks()
        {
            foreach(Task t in listOfTasks)
            {
                Console.WriteLine("ID: " + t.ID + " " + t.TaskName);
            }
        }

        
        public class Task
        {
            private int id;
            private string taskName = "";
            Pracownik assignedEmployee;
            List<Pracownik> employeesInTheTask = new List<Pracownik>();

            
            public string TaskName { get { return taskName; } }
            public int ID { get { return id; } }
            public Task(int ID ,string Taskname )
            {
                taskName = Taskname;
                this.id = ID;
            }
            public void ShowEmployeesIntask() { 
                foreach (Pracownik t in employeesInTheTask)
                {
                    Console.WriteLine(", Wykonawca -  " + t.Name + " " + t.Surname);
                }
            }
            public void AddAEmployeeToTask(Pracownik p1)
            {
                employeesInTheTask.Add(p1);
            }
        }
    }
}
