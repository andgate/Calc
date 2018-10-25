@ECHO off
REM Generates source files for our grammar
java org.antlr.v4.Tool -Dlanguage=CSharp Calc/Expression.g4 -o Calc/Grammar