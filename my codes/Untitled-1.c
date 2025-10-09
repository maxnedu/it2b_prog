
#include <stdio.h>
#include <time.h>
#include <stdlib.h>


int main() {
    char znak;
    int cislo_uz;
    int pocet = 0;
    printf("Hadej cislo(1 - 100):");
    scanf("%d", &cislo_uz);
    
    srand(time(NULL));
    int cislo_ran = rand() % 100 + 1;
    do {
    while(cislo_uz != cislo_ran) {
        
        if(cislo_uz < cislo_ran) {
         printf("Moc nizko\n");
         pocet++;
         printf("Hadej cislo(1-100):");
         scanf("%d", &cislo_uz);
        }
      
       else if(cislo_uz > cislo_ran){
        printf("Moc vysoko\n");
        pocet++;
        printf("Hadej cislo(1-100):");
        scanf("%d", &cislo_uz);
        
        }
     
   }
   printf("Uhodl jsi! Pocet pokusu:%d\n", pocet);
   printf("Chces hrat znovu?(a/n):");
   scanf(" %c", &znak);
    } while(znak == 'a');
   
   
   
    return 0;
}