#include <stdio.h>
int main (void)
{
	int n, i, j, f1, f2, q;

	scanf("%d", &n);

	for(i = 1; i <= n; i++)
	{
		scanf("%d %d", &f1, &f2);
		
		q = fi / i;
		if(f1 % i == 0 && f2 % q == 0)
		{
			printf("%d\n", q);
		}
	}
return 0;
}
