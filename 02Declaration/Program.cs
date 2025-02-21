// 1. 명시적 선언(Explicit Declaration)

// 선언 시 타입을 명시
/*
   장점 : 변수의 타입이 명확하게 드러나므로 코드의 가독성이 높아짐
   단점 : 모든 변수에 대해 타입을 명시해야 하므로 코드가 길어질 수 있음
 */

int number;
string text = "hi";
double pi = 3.14;

// 딕셔너리 사용 시 
Dictionary<string, List<Tuple<int, string>>> comlexDict = new Dictionary<string, List<Tuple<int, string>>> { };

// 2. 암시적 선언(Implicit Declaration)

// 타입을 자동으로 추론 하도록 하는 것
// 값을 반드시 초기화 해줘야 함
/* 
  장점 : 변수의 타입을 명시하지 않아도 되므로 코드가 간결
  단점 : 타입을 명확히 알기 어려워져 타입 관련 오류를 발견하기 어려울 수 있음
 */

var number2 = 10;
var text2 = "hi";
var pi2 = 3.14;

// 딕셔너리 사용 시 
var comlexDict2 = new Dictionary<string, List<Tuple<int, string>>> { };

// Linq 쿼리문에서 자주 활용
// var result = from user in users
//             where user.IsActive
//             select new { user.Id, user.Name };

Console.ReadLine();