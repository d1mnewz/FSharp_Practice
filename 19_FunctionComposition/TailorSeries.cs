int fact (int n)
{
    int res = 1;
    for(int i = 1; i <= n; i++) 
    {
        res *= i;
    }
    return res;
}
float power (float x, int n)
{
    float res = 1;
    for(int i = 0; i < n; i++)
    {
        res *= x;
    }
    return res;
}
float exp (float x)
{
    float sum = 0;
    for(int i = 0; i < x; i++)
    {
        s+=power(x, i)/fact(i);
    }
    return sum;
}