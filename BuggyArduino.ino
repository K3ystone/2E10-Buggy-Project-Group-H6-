#include <SoftwareSerial.h>

volatile int ir_interrupt;
const int irPin = 2;
 
void setup() 
{ 
 pinMode(irPin, INPUT); 
 attachInterrupt(0, LEDISR, RISING); 
 Serial.begin(9600); 
Serial.print("+++"); 
delay(1100); // Guard time 
Serial.println("ATID 3332, CH C, CN"); 
} 
/*
void setup()
{

}
 */
void loop() 
{ 
 if(ir_interrupt==1) 
 { 
 
 int duration=pulseIn(irPin, HIGH); 
 int gantry=gantry_Detection(duration); 
 
 ir_interrupt=0; 
 } 
 Serial.println("Hello world!");
 


 
} 
 
int gantry_Detection(int d) 
{ 
 if (d > 500 && d < 1500 ) 
 { 
 return 1; 
 } 
 // this just checks for gantry 1 
} 
 
void LEDISR() 
{ 
 ir_interrupt=1; 
}






/*
#define ledPin 3

volatile int ir_interupt;
const int  irPin = 2;
 



test(true);

void loop()
{
  
  
}

while(state==true){

}

for(int i = 0; i<5; i++){
}
if (state==true){
}
else if(state==false){
}
else{
}


attachInterupt(0,LEDISR,RISING); //0 pin 2; 1 pin 3
*/ 
