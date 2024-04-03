namespace TestProject1
{
    using System.Diagnostics.CodeAnalysis;
    using ClassLibrary2;

    [ExcludeFromCodeCoverage]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var instance = new Class1();
            instance.GetString();
        }
    }
}