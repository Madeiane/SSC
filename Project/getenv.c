#include <stdio.h>
#include <stdlib.h>

void main() {
    char* shell = getenv("MYSHELL");
    if (shell)
        printf("MYSHELL address: 0x%x\n", (unsigned int)shell);
}