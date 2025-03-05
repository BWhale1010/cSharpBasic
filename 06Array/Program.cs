/* 배열(Array)
    동일한 데이터 타입의 여러 값을 하나의 변수로 관리할 수 있는 자료 구조
 */

// 선언
//int[] numbers = new int[5];         // [0, 0, 0, 0, 0]
//string[] fruits = new string[5];    // [null, null, null, null, null]

// 배열 선언 시 선언 데이터 타입의 기본값이 들어감, int는 0 / string은 null
// 배열은 인덱스를 사용하여 각 값에 접근 가능, 인덱스는 0번 부터 시작

// 초기화
int[] numbers = { 10, 20, 30, 40, 50 };         
string[] fruits = ["사과", "바나나", "레몬" ]; // ["사과", "바나나", "레몬" ] => 컬렉션 표현식 C#9.0 부터 사용가능

// 요소 접근
numbers[2] = 100; // 2번 인덱스에 100 할당
Console.WriteLine(numbers[2]); // 100

// C# 8.0 ^ 연산자
Console.WriteLine(fruits[fruits.Length - 1]); // Length 속성을 사용하면 배열의 크기를 알 수 있음, 3-1이라서 2번 인데스의 값 레몬을 출력
Console.WriteLine(fruits[^1]); // 레몬, 배열 뒤에서 1번째 것을 가져옴

// 배열의 크기보다 큰 인덱스를 사용하면 IndexOutRangeException 오류가 발생됨

Console.ReadKey();