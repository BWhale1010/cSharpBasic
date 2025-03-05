// 다차원 배열

// 1. 2차원 배열 선언과 초기화

// int[,] matrix = new int[2, 3]; // 2행 3열 배열
int[,] matrix = {
    { 1, 2, 3 },
    { 4, 5, 6 }
};

Console.WriteLine(matrix[1, 1]); // 5

matrix[1, 2] = 100;
Console.WriteLine(matrix[1, 2]); // 100

Console.WriteLine(matrix.GetLength(0)); // 1차원의 개수, 2
Console.WriteLine(matrix.GetLength(1)); // 2차원의 개수, 3


// 2. 다차원 배열 반복

for (int i = 0; i < matrix.GetLength(0); i++) // 행 반복
{
    for (int j = 0; j < matrix.GetLength(1); j++) // 열 반복
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

// 3. 가변 배열(Jagged Array)
// 가변 배열은 배열의 배열을 의미, 각 행의 길이가 다를 수 있음

// 가변 배열 선언 (각 배열의 크기가 다를 수 있음)
// int[][] jaggedArray = new int[3][];

// 각 행에 다른 크기의 배열을 할당
//jaggedArray[0] = new int[] { 1, 2 };
//jaggedArray[1] = new int[] { 3, 4, 5 };
//jaggedArray[2] = new int[] { 6, 7, 8, 9 };

// 가변배열 선언과 초기화 같이하는 법
int[][] jaggedArray = new int[][]
{
    new int[] { 1, 2 },
    new int[] { 3, 4, 5 },
    new int[] { 6, 7, 8, 9 }
};

// 가변배열 접근
Console.WriteLine(jaggedArray[2][2]); // 8

// 가변배열 반복
foreach (int[] array in jaggedArray)
{
    foreach (int value in array)
    {
        Console.Write(value + " ");
    }
    Console.WriteLine();
}

// 4. Array 클래스 메서드

// Array.Sort() : 배열을 오름차순으로 정렬
int[] numbers = { 5, 3, 8, 1, 2 };
Array.Sort(numbers); // 배열을 정렬, {1,2,3,5,8}

// Array.Revers() : 배열의 순서를 반대로 뒤집음
Array.Reverse(numbers); // {8,5,3,2,1}

// Array.IndexOf() : 배열에서 특정 값의 인덱스를 찾음
int index = Array.IndexOf(numbers, 3); 
Console.WriteLine(index); // 2
// 없는 값을 찾으려 하면 -1이 나옴

// Array.Resize() : 배열의 크기를 조정
Array.Resize(ref numbers, 7); // {8,5,3,2,1,0,0}


foreach (int value in numbers)
{
    Console.Write(value + " ");
}

Console.ReadKey();