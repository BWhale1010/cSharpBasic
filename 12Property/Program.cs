public class Person
{
    private string name; // 필드
    private int age;

    public string Name   // 속성
    {
        get { return name; }
        set { name = value; }
    }

    // 프로퍼티에서 접근 제한자 사용 
    // 속성 get, set 각각에 대해 별도로 접근 제한자를 설정 가능
    public int Age
    {
        get { return age; }
        private set { age = value; } // 읽기 전용
    }
}

// 자동 구현 속성(Auto-Inplemented Properties)
public class Person1
{
    public string Name { get; set; }
    public int Age { get; set; }
}

// 백업 필드를 사용하는 속성
// 백업 필드를 사용하면 get과 set 접근자에서 추가 로직을 구현 가능
public class Person2
{
    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
                throw new ArgumentException("나이는 음수가 될 수 없습니다.");
            age = value;
        }
    }
}

// 읽기 전용 속성 : get 접근자만 제공하고 set 접근자를 제공하지 않음
public class Person3
{
    public string Name { get; }

    public Person3(string name)
    {
        Name = name;
    }
}

// 쓰기 전용 속성 : set 접근자만 제공하고 get접근자는 제공하지 않음
public class Person4
{
    private string password;

    public string Password
    {
        set { password = value; }
    }
}

// 표현식 본문 속성 : C# 6.0부터 도입된 표현식 본문 속성은 간결한 문법을 제공합니다.
public class Person5
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // 표현식 본문 속성
    public string FullName => $"{FirstName} {LastName}";
}

