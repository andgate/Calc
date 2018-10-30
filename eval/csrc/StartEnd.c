#include <stdlib.h>
#include <stdio.h>
#include "HsFFI.h"

void HsStart(void){
  int argc = 2;
  char *argv[] = { "+RTS", "-A32m", NULL };
  char **pargv = argv;

  printf("hello");

  // Initialize Haskell runtime
  hs_init(&argc, &pargv);
}

void HsEnd(void){
  hs_exit();
}
