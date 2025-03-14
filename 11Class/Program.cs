public class Person
{
    // 필드
    private string name; // 외부에서 직접 접근 불가
    private int age;

    // 접근제한자 : public, protect, internal, private

    // 프로퍼티(속성)
    public string Name
    {
        get { return name; }
        private set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0)
                age = value;
        }
    }

    // 생성자
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // 메서드
    public void Introduce()
    {
        Console.WriteLine($"안녕하세요, 저는 {name}이고, 나이는 {age}살입니다.");
    }

    static void Main(String[] args)
    {
        Person person = new Person("paul", 30);

        person.Introduce();
    }

}

