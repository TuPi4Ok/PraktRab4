int n = 3, c, S;
int[,] a ={ {7,2,3 }, 
            {5,-3,2 }, 
            {10,-11,5 } };
int[] b = {15,
           15,
           36};



for(int k = 0; k < n; k++)
{
    for (int i = k+1; i < n; i++)
    {
        c = a[i, k] / a[k, k];
        a[i, k] = 0;
        for (int j = k+1; j < n; j++)
        {
            a[i, j] = a[i,j] - a[k, j]*c;
        }

        b[i] = b[i] - b[k] * c;
    }
}

int[] x = new int [n];
x[n-1] = b[n-1] / a[n-1,n-1];
for(int i = n-2; i >=0; i--)
{
    S = 0;
    for(int j = i+2; j < n; j++)
    {
        S = S + a[i, j] * x[j];
    }
    x[i] = (b[i] - S) / a[i,i];
}

for(int i = 0; i < n; i++)
{
    Console.WriteLine(x[i]);
}