package Exceptions_in_programmin_an_their_handling.Home_Work_2;

public class try{
// Задача 2

try{

int d=0;if(d!=0){double catchedRes1=intArray[8]/d;System.out.println("catchedRes1 = "+catchedRes1);}else{System.out.println("Деление на ноль невозможно.");}}catch(ArithmeticException e){System.out.println("Catching ArithmeticException: "+e);}catch(ArrayIndexOutOfBoundsException e){System.out.println("Catching ArrayIndexOutOfBoundsException: "+e);}}
