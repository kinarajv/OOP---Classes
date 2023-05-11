class Parent
{
	public Parent()
	{
		Console.WriteLine("Parent constructor");
	}
	public virtual void MethodA()
	{
		Console.WriteLine("Method Parent");
	}
}
class Child : Parent
{
	public Child()
	{
		Console.WriteLine("Child constructor");
	}
	public override void MethodA()
	{
		Console.WriteLine("Method Child");
	}
}
class Program
{
	static void Main()
	{
		Child child = new Child();
		Parent parent = new Parent();
		child.MethodA();
		parent.MethodA();

		Parent parent2 = child;
		parent2.MethodA();
	}
}