int size = 50000; //예시
bool[] check = Enumerable.Repeat(true, size + 1).ToArray();
check[0] = check[1] = false;

for (int i = 2; i * i <= size; i++)
{
    if (check[i])
        for (int j = i * i; j <= size; j += i)
        {
            check[j] = false;
        }
}
//빠른속도로 소수만있는 배열 생성 
//true가 소수임 
