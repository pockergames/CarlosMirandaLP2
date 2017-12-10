#include <stdio.h>

int valorInicial;
int AlreadyInscreased;
void reflexo(int n)
{

	if(n == 0)
	{
		while(n < valorInicial)
		{
			n++;
			printf("%d\n", n);
			AlreadyInscreased = 1;
		}
	}
	
	if(n != 0 && AlreadyInscreased == false)	
	{
		n--;
		printf("%d\n", n);
		reflexo(n);
		
	}
}

int main (void)
{	
	
	scanf("%d", &valorInicial);
	reflexo(valorInicial);
	return 0;
}
