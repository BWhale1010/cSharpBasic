// 문자열

using System.Runtime.InteropServices;
using System.Text;

string greeting = "Hello, World";
string emptyString = ""; // 빈 문자열
string nullString = "null"; // null 문자열 -> 참조 타입이라 null 할당 가능
//int i = null; -> 값 타입이라서 null할당이 불가능 

// 문자열 연결
string firstName = "John";
string lastName = "Doe";
string fullName = firstName + " " + lastName;  // "John Doe"

// 문자열 불변성
String original = "Hello";
original = original + "World"; // 문자열이 수정되는 것이 아니라 새로운 문자열이 생성되는 것

// 문자열 보간 (String Interploation)
string name = "Alice";
int age = 30;

string message = $"Name: {name}, Age: {age}"; // 문자열 내에 변수 값을 포함하여 사용, $ 기호로 시작

Console.WriteLine(message);

// 문자열 형식화(String Formatting)
string formatted = string.Format("Name: {0}, Age: {1}", name, age);

Console.WriteLine(formatted);

// 문자열의 길이
Console.WriteLine(formatted.Length); // 20

// 부분 문자열 추출 (Substring)
string text = "Hello World!";
Console.WriteLine(text.Substring(2,3)); // llo

// 문자열 포함 여부 확인 (Contains)
Console.WriteLine(text.Contains("World")); // True, 대소문자 구분
Console.WriteLine(text.Contains("world", StringComparison.OrdinalIgnoreCase)); // StringComparison.OrdinalIgnoreCase 옵션을 사용하면 대소문자 무시

// 문자열 비교(Equals)
Console.WriteLine(text.Equals("Hello World!")); // True, 대소문자 구분
Console.WriteLine(text.Equals("hello world!", StringComparison.OrdinalIgnoreCase)); // StringComparison.OrdinalIgnoreCase 옵션을 사용하면 대소문자 무시

// 대소문자 변환 (ToUpper, ToLower)
Console.WriteLine(text.ToUpper()); // 대문자 변환
Console.WriteLine(text.ToLower()); // 소문자 변환

// 공백제거 (Trim, TrimStart, TrimEnd)
string withSpaces = "  Hello  ";
string trimmed = withSpaces.Trim();  // "Hello"

string withChars = "***Hello***";
string trimmedChars = withChars.Trim('*');  // "Hello"

string withLeadingSpaces = "  Hello  ";
string trimmedStart = withLeadingSpaces.TrimStart();  // "Hello  "

string withLeadingChars = "***Hello***";
string trimmedStartChars = withLeadingChars.TrimStart('*');  // "Hello***"

string withTrailingSpaces = "  Hello  ";
string trimmedEnd = withTrailingSpaces.TrimEnd();  // "  Hello"

string withTrailingChars = "***Hello***";
string trimmedEndChars = withTrailingChars.TrimEnd('*');  // "***Hello"

string mixedChars = "-*_Hello_*--";
string trimmedMixed = mixedChars.Trim('-', '*', '_');  // "Hello"
string trimmedMixedStart = mixedChars.TrimStart('-', '*', '_');  // "Hello_*--"
string trimmedMixedEnd = mixedChars.TrimEnd('-', '*', '_');  // "-*_Hello"

// 문자열 분할(Split)
string colors = "Red,Green,Blue";
string[] colorArray = colors.Split(','); // ["Red, Green, Blue"]

foreach (string color in colorArray)
{
    Console.WriteLine(color);
}

// 문자열 결합 (Join)
string joinedColors = string.Join("|", colorArray); // "Red | Green | Blue"
Console.WriteLine(joinedColors);

// 이스케이프 시퀀스
string path = "C:\\Users\\John";      // C:\Users\John
string quote = "He said, \"Hello!\""; // He said, "Hello!"

// 문자열의 가변 버전 (StringBulider)
StringBuilder sb = new StringBuilder();
sb.Append("Hello");
sb.Append(", ");
sb.Append("World!");
string result = sb.ToString();  // "Hello, World!"

Console.WriteLine(result);

// StringBulider는 문자열을 새로 생성하지 않고 문자열을 붙일 수 있어 효율적

Console.ReadKey();