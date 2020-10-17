
namespace Constructor
{
    class Person
    {
        public string name;
        public int age;

        const int unknown = -1;
        const string defaultName = "名無しさん";

        //public Person()
        //{
        //    this.name = "taro";
        //    this.age = 100000;
        //}

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age > 0 ? age: unknown;
        }

        public Person(string name): this(name, unknown)
        {

        }


        // コンストラクター初期化子。別のコンストラクターを呼び出すことができる
        public Person(): this(null,unknown)
        {

        }
    }
}
