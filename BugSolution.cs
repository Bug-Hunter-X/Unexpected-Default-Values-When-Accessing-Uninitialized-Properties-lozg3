public class MyClass {
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public MyClass() {
        MyProperty = 0; // Or any other desired default value
    }

    public void MyMethod() {
        Console.WriteLine(MyProperty); // Now this will print the initialized value
    }
}