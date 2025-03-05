// 1. for문

//for (초기화; 조건; 증감식)
//{
//    반복 실행할 코드
//}

for (int i = 0; i<5; i++)
{
    Console.WriteLine($"반복 횟수 : {i}");
}

// 2. foreach문
//foreach (타입변수명 in 컬렉션)
//{
//    반복 실행할 코드
//}

string[] fruits = { "사과", "바나나", "체리" };
 
foreach ( string fruit in fruits)
{
    Console.WriteLine(fruit);
}

// 3. while 문
//while (조건)
//{
//    반복 실행할 코드
//}

int count = 0;
while (count < 3)
{
    Console.WriteLine($"카운트: {count}");
    count++;
}

// 4. do-while 문
//do
//{
//    반복 실행할 코드
//} while (조건);

int number = 5;
do
{
    Console.WriteLine($"번호 : {number}");
    number++;
}while (number < 5);

// 5. 반복제어문 : break와 continue

// 5-1. break
for (int i= 0; i < 10; i++)
{
    if (i == 5)
    {
        break; // 반복문 종료
    }
    Console.WriteLine(i);
}

// 5-2. continue 
for (int i = 0; i< 5; i++)
{
    if (i == 2)
    {
        continue; // 현재 반복 건너뛰기
    }
    Console.WriteLine(i);
}

// 6. 중첩 반복분
for (int i = 2; i <=9; i++)
{
    for (int j = 1; j <= 9; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}

Console.ReadKey();