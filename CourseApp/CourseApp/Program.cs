using CourseApp.Controllers;
using DomainLayer.Models;
using ServiceLayer.Helpers.Extensions;


// Mellim gece saat 2 den seher saat 6 ya kimi yazmisam bunu Sagird emeyine gore bir 5-10 bal artirarsiniz :)


ConsoleColor.White.WriteConsole("Please choose one of these operations: Student operations: Create - 1 , GetAll - 2 , Search - 3" +
    "Teacher operations: Create - 4 , GetAll - 5");
StudentController studentController = new StudentController();
TeacherController teacherController = new TeacherController();

bool IsFinished = false;

while (!IsFinished)
{
    Operation: string operation = Console.ReadLine();

    int operationNum;

    bool isTrueOperation = int.TryParse(operation, out operationNum);

    if (isTrueOperation) 
    {
        Start:

        switch (operationNum)
        {
            case 1:
                studentController.Create();
                break;

            case 2:
                studentController.GetAll();
                break;

            case 3:
                studentController.Search();
                break;

            case 4:
                teacherController.Create();
                break;

            case 5:
                teacherController.GetAll();
                break;

            case 6:

                break;

            default:
                ConsoleColor.Red.WriteConsole("That was not correct! Try Again!");
                goto Start;
                
        }
    }
    else
    {
        ConsoleColor.Red.WriteConsole("Choose Correct operation!:");
        goto Operation;
    }
} 