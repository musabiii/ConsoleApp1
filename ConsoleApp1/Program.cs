
User musa = new User {age=11,name="musa"};
musa.sayHi();
User alby = musa with { name="alby" };
alby.sayHi();


struct User
{
    public string name;
    public int age;
    public void sayHi()
    {
        Console.WriteLine($"name:{name},age:{age}");
    }
}
