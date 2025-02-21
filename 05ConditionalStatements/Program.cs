// 1. if문
if (true)
{
    Console.WriteLine("Always");
}

if (1 == 1)
{
    Console.WriteLine("1 is equal to 1");
}

if (1 == 2)
{
    Console.WriteLine("1 is not equal to 2");
}

// 2. else문

int a = 1;
int b = 2;

if (a == b)
{
    Console.WriteLine("a와 b는 같다");
}
else
{
    Console.WriteLine("a와 b는 다르다");
}

// 3. else-if문
if (a == b)
{
    Console.WriteLine("a와 b는 같다");
}
else if (b == 2 && a == 1)
{
    Console.WriteLine("a는 1, b는 2다");
}
else if (a < 1)
{
    Console.WriteLine("a는 1보다 작다");
}
else
{
    Console.WriteLine("a와 b는 다르다");
}

// 입력 값 사용
Console.WriteLine("숫자를 입력하세요.");
string? input = Console.ReadLine(); // Console.ReadLine()는 항상 문자열을 반환하기 때문에 string 타입을 사용

Console.WriteLine("입력한 숫자는 " + input + " 입니다.");
int number = int.Parse(input ?? "0"); // 입력 값이 string이므로 비교를 위해 int형으로 변환하고 null 값 처리를 위해 ?? null 병합연산자 사용

// 삼항연산자 사용
string text = number % 2 == 0 ? "짝수" : "홀수";

if (number % 2 == 0)
{

    Console.WriteLine("입력한 숫자는 " + text + " 입니다.");
}
else
{
    Console.WriteLine("입력한 숫자는 " + text + " 입니다.");
}

Console.WriteLine("입력한 숫자는 " + number + " 입니다.");

// 4. switch 문
string grade = "B+";

switch (grade)
{
    case "A":
        Console.WriteLine("우수한 성적입니다.");
        break;
    // case "B+": // case 문을 중첩해서 사용하면 || 연산처럼 사용 가능
    // case "B":
    case string g when g == "B" || g == "B+": // when 키워드도 사용 가능
        Console.WriteLine("좋은 성적입니다.");
        break;
    case "C":
        Console.WriteLine("보통 성적입니다.");
        break;
    default:
        Console.WriteLine("잘 모르겠습니다.");
        break;
}

// 4-1 switch 표현식
string message = grade switch
{ 
    "A" => "우수한 성적입니다.",
    string g when g == "B" || g == "B+" => "좋은 성적입니다.",
    "C" => "보통 성적입니다.",
    _ => "잘 모르겠습니다."
};
Console.WriteLine(message);

Console.ReadKey();