// 메소드 : 클래스나 구조체 내에 정의, 메소드를 사용하면 코드를 재사용 가능, 프로그램의 논리 구조를 명확하게 할 수 있음
using System.ComponentModel;

public class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}

// 메소드 구성요소

// 반환타입 : 메소드가 반환하는 값의 타입을 지정, 반환할 값이 없을 경우 void를 사용
public class SampleClass
{
    // 메소드 이름 : 메소드 이름은 식별자로, 메소드가 수행하는 작업을 나타내는 것이 좋음, PascalCase를 사용하여 작성
    // 매개변수(parameter) : 메소드가 작업을 수행하는데 필요한 데이터를 전달받는 변수. 여러 개의 매개변수를 가질 수 있으며, 타입과 이름을 지정
    // 접근제한자 : 메소드의 접근 범위를 지정. 주요 접근 제한자는 public, private, protected, internal, protected internal 등이 있음
    // 본문 : 메소드가 수행할 작업을 정의하는 코드 블록. 중괄호 {}로 감싸여 있음
    // 메소드 선언 : 클래스나 구조체 안에 선언
    public int Add(int a, int b) { return 0; }
    public void Display() {}

    public static void Main(String[] args)
    {        
        SampleClass sample = new SampleClass();
        // 메소드 호출 : 메소드를 사용하려면 해당 메소드를 호출. 인스턴스 메소드는 객체를 통해 호출, 정적메소드는 클래스 이름으로 호출
        // 메소드 호출 시 사용하는 값은 전달인자(Argument)라 함
        // 인스턴스 메소드
        sample.Add(1,2);

        // 정적 메소스
        Calculator.Add(1, 2);

    }

}

// 선택적 매개변수
// 메소드 호출 시 일부 매개변수를 생략할 수 있게 하는 기능으로, 기본값을 지정. 선택적 매개변수는 반드시 선택하지 않을 매개변수 뒤에 위치해야 함
public class Greeter
{
    public void Greet(string name, string greeting = "안녕하세요")
    {
        Console.WriteLine($"{greeting}, {name}님!");
    }
}

// 사용 예
public class GreeterExam
{
    public static void Main(String[] args) {
        Greeter greeter = new Greeter();
        greeter.Greet("홍길동"); // 출력: 안녕하세요, 홍길동님!
        greeter.Greet("홍길동", "반갑습니다"); // 출력: 반갑습니다, 홍길동님!
    }
}

// 가변 매개변수 : 메소드가 가변 개수의 인수를 받을 수 있도록 하는 기능으로, 매개변수 앞에 params 키워드를 사용. 매개변수는 배열 형태로 처리

public class Calculator1
{
    public int Sum(params int[] numbers)
    {
        int total = 0;
        foreach (int num in numbers)
        {
            total += num;
        }
        return total;
    }
}

public class Caculator1Exam
{
    public static void Main(String[] args)
    {
        // 사용 예
        Calculator1 calc = new Calculator1();
        int result = calc.Sum(1, 2, 3, 4, 5); // 결과: 15
    }
}

// ref 키워드 : ref 키워드는 메소드에 변수를 참조로 전달할 때 사용. 이를 통해 메소드 내에서 해당 변수의 값을 읽고 수정할 수 있음
public class RefExample
{
    public void ModifyValue(ref int number)
    {
        number += 10;
    }

    public void Execute()
    {
        int original = 5;
        Console.WriteLine($"수정 전: {original}"); // 출력: 수정 전: 5
        ModifyValue(ref original);
        Console.WriteLine($"수정 후: {original}"); // 출력: 수정 후: 15
    }
}

public class Program
{
    public static void Main()
    {
        RefExample example = new RefExample();
        example.Execute();
    }
}

// out : out 키워드는 메소드가 여러 값을 반환해야 할 때 주로 사용. 메소드가 호출될 때 변수는 초기화되지 않아도 되며, 메소드 내에서 반드시 값을 할당해야 함
public class OutExample
{
    public bool TryDivide(int dividend, int divisor, out double result)
    {
        if (divisor == 0)
        {
            result = 0;
            return false;
        }
        result = (double)dividend / divisor;
        return true;
    }

    public void Execute()
    {
        double divisionResult;
        bool success = TryDivide(10, 2, out divisionResult);
        if (success)
        {
            Console.WriteLine($"10 / 2 = {divisionResult}"); // 출력: 10 / 2 = 5
        }
        else
        {
            Console.WriteLine("나눗셈에 실패했습니다.");
        }

        success = TryDivide(10, 0, out divisionResult);
        if (success)
        {
            Console.WriteLine($"10 / 0 = {divisionResult}");
        }
        else
        {
            Console.WriteLine("나눗셈에 실패했습니다."); // 출력: 나눗셈에 실패했습니다.
        }
    }
}

public class Program1
{
    public static void Main()
    {
        OutExample example = new OutExample();
        example.Execute();
    }
}









