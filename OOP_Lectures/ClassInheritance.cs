    public class BaseClass
    {
    public string? BaseClassName { get; set; }
    }
    public class Class1: BaseClass
    {
        public string? Class1InheritsfromBaseClass { get; set; }
    }

    public class Class2 : Class1
    {
        public int Class2InheritsfromClass1 { get; set; }
    }
    public class Class3 : Class2
    {
        public string? Class3InheritsfromClass2 { get; set; }
    }