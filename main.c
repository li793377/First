#include <stdio.h>
#include <stdlib.h>
#include <string.h>
int main()
{
    int i,j,k,m,x,y,t,sub,flag;
    char a[100],b[1000];
    scanf("%d",&t);
    for(i=1;i<=t;i++)
    {
        scanf("%s\n%s\n",&*a,&*b);
        x=strlen(a);
        y=strlen(b);
        flag=0;
        for(j=y-1;j>=0;j--)
        {
            if(a[x-1]==(b[j]-32)||a[x-1]==(a[j]+32)||a[x-1]==a[j])
            {
                flag++;
                sub=j-x+1;
                m=j;


            }
            else sub=-1;

        }
        if(sub!=-1)
            printf("%d %d",flag,sub);
        else printf("%d",sub);
    }
    return 0;
}
