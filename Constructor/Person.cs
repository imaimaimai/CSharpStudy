
namespace Constructor
{
    class Person
    {
        public string name;
        public int age;

        public Person()
        {
            this.name = "taro";
            this.age = 100000;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
