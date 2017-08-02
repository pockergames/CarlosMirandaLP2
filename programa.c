#include <stdio.h>
int main (void)
{
	int n, i, maiorD[3010], f1, f2;

	scanf("%d", &n);

	for(i = 1; i <= n; i++)
	{
		scanf("%d %d", &f1, &f2);
		for(i = 1; i <= n; i++)
		{
			if(f1 / i == f2 / i)
			{
				maiorD[i] = j;
		    }		
		}
	}
	for(i = 1; i <= n; i++)
	{	
		printf("%d\n", maiorD[i]);
	}
return 0;
}
