using System;
class PR{static void Maain(){int t=int.Parse(Console.ReadLine());int[]l=new int[t];int[]c=new int[4];int r=0;for(int i=0;i<t;i++){l[i]=int.Parse(Console.ReadLine());c[l[i]]++;}for(int i=c[1];i<t;i++){if(l[i]==1){int k=0;for(int j=0;j<c[1];j++){if(l[j]==2){k=j;break;}else k=j;}int a=l[i];l[i]=l[k];l[k]=a;r++;}}for(int i=c[1]+c[2];i<t;i++)if(l[i]==2)r++;Console.WriteLine(r);}}
