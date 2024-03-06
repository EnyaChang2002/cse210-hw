using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2001;
        job1._endYear = 2003;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Engineer";
        job2._startYear = 2000;
        job2._endYear = 2001;

        Resume resume1 = new Resume();
        resume1._name = "Joseph";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();
    }
}