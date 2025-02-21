// 1. 비교연산자
int a = 1;
int b = 2;

Console.WriteLine("a == a : " + (a == a));
Console.WriteLine("a == b : " + (a == b));
Console.WriteLine("----");
Console.WriteLine("a != a : " + (a != a));
Console.WriteLine("a != b : " + (a != b));
Console.WriteLine("----");
Console.WriteLine("a > a : " + (a > a));
Console.WriteLine("a > b : " + (a > b));
Console.WriteLine("----");
Console.WriteLine("a < a : " + (a < a));
Console.WriteLine("a < b : " + (a < b));
Console.WriteLine("----");
Console.WriteLine("a >= a : " + (a >= a));
Console.WriteLine("a >= b : " + (a >= b));
Console.WriteLine("----");
Console.WriteLine("a <= a : " + (a <= a));
Console.WriteLine("a <= b : " + (a <= b));
Console.WriteLine("----");

string c = "hi";
string d = "hello";

Console.WriteLine(c == d);
Console.WriteLine("----");

// 2. 산술연산자
decimal e = 10;
decimal f = 20;

Console.WriteLine("e + f = " + (e + f));
Console.WriteLine("e - f = " + (e - f));
Console.WriteLine("e * f = " + (e * f));
Console.WriteLine("e / f = " + (e / f));
Console.WriteLine("e % f = " + (e % f));
Console.WriteLine("----");
Console.WriteLine($"e++ : {e++}");
Console.WriteLine($"++e : {++e}");
Console.WriteLine("----");
Console.WriteLine($"e-- : {e--}");
Console.WriteLine($"--e : {--e}");

// 3. 할당연산자
decimal g = 10;
g = g + 20;
g += 20;
g -= 10;
g *= 2;
g /= 4;
g %= 3;
Console.WriteLine("----");
Console.WriteLine(g);

// 4. 논리연산자
bool h = true;
bool i = false;
Console.WriteLine("----");
Console.WriteLine($"h && i = {h && i}");
Console.WriteLine($"h || i = {h || i}");
Console.WriteLine($"!(h && i) = {!(h && i)}");
Console.WriteLine($"!(h || i) = {!(h || i)}");

bool isTrue = true;
bool isFalse = false;

Console.WriteLine("----");
bool result = isTrue && PrintHelloWorld();
bool result2 = isTrue || PrintHelloWorld();
bool result3 = isFalse && PrintHelloWorld();
bool result4 = isFalse || PrintHelloWorld();
Console.WriteLine($"isTrue && PrintHelloWorld() = {result}");
Console.WriteLine($"isTrue || PrintHelloWorld() = {result2}");
Console.WriteLine($"isFalse && PrintHelloWorld() = {result2}");
Console.WriteLine($"isFalse || PrintHelloWorld() = {result3}");

bool PrintHelloWorld()
{
    Console.WriteLine("Hello World!");
    return true;
}

// 5. 비트연산자
int j = 192; //11000000
int k = 168; //10101000
//         AND 10000000
//          OR 11101000
//         XOR 01101000

// NOT 
//  j = 00000000 00000000 00000000 11000000 (int는 32bit)
// ~j = 11111111 11111111 11111111 00111111 => 1의 보수
// 1의 보수, 2의 보수
// 11111111 11111111 11111111 00111111
// 1의 보수 00000000 00000000 00000000 11000000
// 2의 보수 00000000 00000000 00000000 11000001 => 193
// ~j = -193

// <<
//  j = 00000000 00000000 00000000 11000000
//      00000000 00000000 00000011 00000000 => 768

// >>
//  j = 00000000 00000000 00000000 11000000
//      00000000 00000000 00000000 00110000 => 48

Console.WriteLine("----");
Console.WriteLine($"j & k = {j & k}"); // 10000000 => 128
Console.WriteLine($"j | k = {j | k}"); // 11101000 => 232
Console.WriteLine($"j ^ k = {j ^ k}"); // 01101000 => 104
Console.WriteLine($"~j = {~j}"); // -193
Console.WriteLine($"j << 2 = {j << 2}"); //768
Console.WriteLine($"j >> 2 = {j >> 2}"); //48

// 5-1. 보수 추가 설명
byte l = 5;
// l = 0000 0101
// ~l = 1111 1010

// 1111 1010 => 10진수로 변환
// 비트 마지막 자리(부호자리) 가 1이면 음수 0이면 양수
// 음수일 경우
// 1의 보수 => 0000 0101
// 2의 보수 => 0000 0101+1 => 0000 0110 => 6
// ~l = -6

Console.WriteLine("----");
Console.WriteLine($"~l = {~l}");

// 6. null 병합 연산자

// 6-1. Nullable
Nullable<int>  m = null;
int? n = null;
// null 값을 넣었다고 메모리가 초기화 되는 것은 아니고 메모리 공간은 유지하고 있지만 값이 할당되지 않았다는 것을 표시

Console.WriteLine($"m = {m}"); // m =
Console.WriteLine($"n = {n}"); // n =

Console.WriteLine($"m 값이 있는가? {m.HasValue}"); // m 값이 있는가? False

n = 5;
Console.WriteLine($"n 값이 있는가? {n.HasValue}"); // n 값이 있는가? True

int? o = null;

// 6-2. ?? 연산
int p = o ?? 3; // 왼쪽 값이 null일 경우 오른쪽 값을 반환
Console.WriteLine($"p = {p}"); // p = 3

// 6-3. ??= 연산
o ??= n; // 왼쪽 값이 null일 경우 오른쪽 값을 할당
Console.WriteLine($"o = {o}"); // o = 5

o = 3;
o ??= n; // 이 연산을 수행해도 o를 3으로 변경했기 때문에 null이 아니라서 연산이 되지 않음
Console.WriteLine($"o = {o}"); // o = 3


Console.ReadKey();