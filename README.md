<img heigth=150px src="https://github.com/KormichKristina/Taskly/blob/master/assets/goals.png"><br>
<h2> Taskly - небольшое приложение для планирования задач, а также для осуществления желаний. В основные функции приложения входят создание задач/желаний, удаление задач/желаний, их просмотр и выполнение.</h2><br>
<h3> Скриншоты</h3>
<img src="https://github.com/KormichKristina/Taskly/blob/master/assets/Taskly1.png">
<img src="https://github.com/KormichKristina/Taskly/blob/master/assets/Taskly2.png">
<img src="https://github.com/KormichKristina/Taskly/blob/master/assets/Taskly3.png">
<h3>Как скачать Taskly</h3>
для того чтобы скачать Taskly нажмите на <a href="hhttps://drive.google.com/file/d/1bHMGQboHOtKwgydO1AJi9AbfZwH9Xq9r/view?usp=sharing">ссылку</a> и у вас откроется мой google диск. Далее скачиваете Taskly.rar (это может занять достаточно много времени).После того как вы скачали Taskly.rar, разархивируйте это приложение и затем следуя пути <b>.\Taskly\Taskly\bin\Debug\net8.0-windows\Taskly.exe</b> найдите <b>Taskly.exe</b><br><hr>

<h3>Какие технологии были использованы</h3>
Для того, чтобы у приложение был красивый внешний вид, я использовала пакет <b>Guna.UI2.WinForms</b>, которое позволяет легко и быстро улучшить внешний вид приложения. <br><br>Также в приложении был использован <b>Entity Framework Core</b> и чтобы коректно работать с базой данных SQLite, я использовала пакет <b>Microsoft.EntityFrameworkCore.SQLite</b><hr>
<h3>Небольшая документация</h3>

```c#

public abstract class Aspiration \\ абстрактный класс, который является базовым для MyTask и Wish
{
    public int Id { get; set; } \\ id в качестве первичного ключа в базе данных
    public DateOnly DateOfCreate { get; } \\ дата создания
    public int UserId { get; set; } \\ id создателя задачи/желания
    public bool IsComplete { get; set; } \\ указывает на то выполнена ли задача/желание или нет
    public string MyColor { get; set; } \\ цвет
    public string Name { get; set; } \\ название
    public string Description { get; set; } \\ описание
    public Aspiration(string name, string description,  bool isComplete = false) 
    {
        Name = name;
        Description = description;
        IsComplete = isComplete;
        DateOfCreate = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

    }

}

```

```c#
public class MyTask:Aspiration \\ класс задачи
{
    public DateTime Deadline { get; set; } \\ срок выполнения задачи
    public MyTask(string name, string description, DateTime deadline, bool isComplete = false):base(name,description,isComplete) 
    {
        Deadline = deadline;
    }
}

```

```c#
public class Wish:Aspiration \\ класс желания
{
    public string HowWillYouAchive { get; set; } \\ описание того как создатель собирается исполнить желание
    public Wish(string name,string description,string howWillYouAchive,bool isComplete=false) : base(name, description,isComplete)
    {
        HowWillYouAchive = howWillYouAchive;
    }

}
```

```c#
public class User \\ класс пользователя
{
    public int Id { get; set; } \\ id в качестве первичного ключа
    public string Name { get; set; } \\ имя
    public string Password { get; set; } \\ пароль
    public int TasksCompleted { get; set; } \\ кол-во выполненых задач
    public int WishesFulfilled { get; set; } \\ кол-во выполненых желаний
    public List<int> WishesId { get; set; } \\ список id желаний, которые есть у пользователя
    public List<int> TasksId { get; set; } \\ список id задач, которые есть у пользователя

}
```

```c#
public static class ExtensionClass \\ класс методов расширения
{

    public static Color GetColor(this string str) \\ метод расширения для получение цвета в зависимости от строки
    {
        
        switch (str)
        {
            case "Yellow":
                return Color.FromArgb(255,242,0);
            case "Orange":
                return Color.FromArgb(255,94,0);
            case "Pink":
                return Color.FromArgb(255,0,106);
            case "Violet":
                return Color.FromArgb(208,0,255);
            case "Dark blue":
                return Color.FromArgb(43,0,255);
            case "Blue":
                return Color.FromArgb(0,217,155);
            case "Mint":
                return Color.FromArgb(0,255,179);
            case "Green":
                return Color.FromArgb(47,255,0);
            case "Black":
                return Color.FromArgb(0,0,0);
            default:
                return Color.FromArgb(255,255,255);
        }
    }
    public static string GetStr(this Color color) \\ метод расширения для получения строки в зависимости от цвета
    {
        if (color== Color.FromArgb(255, 242, 0))
        {
            return "Yellow";
        }
        else if (color == Color.FromArgb(255, 94, 0))
        {
            return "Orange";
        }
        else if (color == Color.FromArgb(255, 0, 106))
        {
            return "Pink";
        }
        else if (color == Color.FromArgb(208, 0, 255))
        {
            return "Violet";
        }
        else if (color == Color.FromArgb(43, 0, 255))
        {
            return "Dark blue";
        }
        else if (color == Color.FromArgb(0, 217, 155))
        {
            return "Blue";
        }
        else if (color == Color.FromArgb(0, 255, 179))
        {
            return "Mint";
        }
        else if (color == Color.FromArgb(47, 255, 0))
        {
            return "Green";
        }
        else if (color == Color.FromArgb(0, 0, 0))
        {
            return "Black";
        }
        else 
        {
            return "White";

        }
    }

}
```

```c#
public class UserContext : DbContext \\ класс контекста для работы с базой данных
{
    public DbSet<User> Users => Set<User>(); \\ хранение пользователей в базе данных
    public DbSet<Wish> Wishes => Set<Wish>(); \\ хранение желаний в базе данных
    public DbSet<MyTask> Tasks => Set<MyTask>(); \\ хранение задач в базе данных
    public UserContext() => Database.EnsureCreated();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
         optionsBuilder.UseSqlite("Data Source=usersDb.db");
    }
}


```