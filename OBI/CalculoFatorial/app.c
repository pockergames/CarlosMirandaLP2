#include <stdio.h>

int fat(int n)
{
	int resultado = n;
	for(int i = 1; i < n; i++)
	{
		resultado *= i;
	}
	return resultado;
}
int main(void)
{
	int nro;
	scanf("%d", &nro);
	printf("%d", fat(nro));
	return 0;
}
