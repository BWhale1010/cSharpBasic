// 1. 값 타입(Value Type)

/* 1) 정수형 타입
 
    byte: 8비트 부호 없는 정수 (0 ~ 255)
    sbyte: 8비트 부호 있는 정수 (-128 ~ 127)
    short: 16비트 부호 있는 정수 (-32,768 ~ 32,767)
    ushort: 16비트 부호 없는 정수 (0 ~ 65,535)
    int: 32비트 부호 있는 정수 (-2^31 ~ 2^31-1)
    uint: 32비트 부호 없는 정수 (0 ~ 2^32-1)
    long: 64비트 부호 있는 정수 (-2^63 ~ 2^63-1)
    ulong: 64비트 부호 없는 정수 (0 ~ 2^64-1)
 */

byte age = 255;
// 8비트 : ㅁㅁㅁㅁㅁㅁㅁㅁ -> 2^8 = 256(0~255)

sbyte temperature = -128;
// 8비트 : ㅁㅁㅁㅁㅁㅁㅁㅁ -> 2^7 = 128(-128~127)
// 맨 앞의 비트는 부호(+,-)를 사용하기 때문에 2^7

Console.WriteLine("age : " + age);
Console.WriteLine("temperature : " + temperature);

/* 2) 부동 소수점 타입

    float: 32비트 부동소수점
    double: 64비트 부동소수점
 */

float f = 1.1f;
float f2 = 1.2f;

// 프로그래밍이 실행될 때 고정된 값을 할당하는 것을 리터럴이라 하는데
// 리터럴 접미사로 f를 써줘야 이 값이 float 타입이라는 것을 알 수 있게 됨

double d = 1.11;
double d2 = 1.21;
// 소수 타입의 기본 타입은 double이라 접미사로 d를 안 붙여도 됨

Console.WriteLine(f + f2); // 2.3(x) -> 2.300002
// 부동소수는 소수점을 연산하기 위해 2진수를 사용하게 됨
// 1.1을 2진수로 표현하면 1.000110011001100110011... 이 됨
// 2진수로는 일부 소수들의 연산이 어렵기 때문에 근사치의 값이 소수점으로 나타남
// -> 작은 오차가 있지만, 연산 속도가 빠름

Console.WriteLine(d + d2); // 2.32(x) -> 2.3200000000003
// float보다는 double이 정확도가 높음

// 일반적으로는 float와 double을 사용 (그래프 등에 쓰임)


/* 3) 고정 소수점 타입
  
    decimal: 128비트 고정소수점 (주로 금융 관련 계산에 사용) 
 */

decimal m = 1.1m;
decimal m2 = 1.2m;
// decimal은 접미사로 m을 붙여줘야 함
// decimal 은 정수부와 소수부를 각각 2진수로 표현해서 붙어 넣는 형식 -> 소수도 정확히 표현 가능

Console.WriteLine(m + m2); // 2.3(o)
// 계산이 정확하여 금융에서 많이 쓰임

/* 4) 기타 기본 타입

    bool: 논리형(true 또는 false)
    char: 16비트 유니코드 문자
    enum: 열거형(상수들의 집합)
    struct: 사용자 정의 값 타입(구조체)
    DateTime: 날짜 또는 시간
 */

// 4-1) bool 
bool isTrue = false;
Console.WriteLine("isTrue : " + isTrue);

// 4-2) char
char character = 'a';
char[] chars = { 'i', 's', 'T', 'r', 'u', 'e' };
string str = new string(chars);

Console.WriteLine(str + " : " + isTrue);

// 4-2-1) 유니코드
char upperA = '\u0041'; // 'A'
int upperAInt = (int)upperA; // 65
int upperBInt = upperAInt + 1; // 66
char upperB = (char)upperBInt; // 'B'

Console.WriteLine(upperA); // A
Console.WriteLine(upperAInt); // 65

Console.WriteLine(upperB); // A
Console.WriteLine(upperBInt); // 65

// 4-3) 상수
const int SUNDAY = 0;
const int MONDAY = 1;
const int TUESDAY = 2;
const int WEDNESDAY = 3;
const int THURSDAY = 4;
const int FRIDAY = 5;
const int SATURDAY = 6;

// 최상위 문 시작
Days days = Days.Sunday;

if (days == Days.Sunday)
{
    Console.WriteLine("Sunday");
}
if (days == Days.Monday)
{
    Console.WriteLine("Monday");
}

Console.ReadKey();
// 최상위 문 끝

// 문법 순서 실행문(최상위문) -> 선언문

// 4-3-1) enum 
enum Days
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
};
// 0부터 순차적으로 인덱스가 부여됨, 직접 값을 부여할 수도 있음
// 상수의 모음을 가독성을 높이기 위함
