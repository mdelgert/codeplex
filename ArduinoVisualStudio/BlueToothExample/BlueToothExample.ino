//http://playground.arduino.cc/Learning/Tutorial01
//http://www.instructables.com/id/Arduino-AND-Bluetooth-HC-05-Connecting-easily/step3/
//http://www.instructables.com/id/Arduino-AND-Bluetooth-HC-05-Connecting-easily/step5/

// This program shown how to control arduino from PC Via Bluetooth 
// arduino>>bluetooth
// D11   >>>  Rx
// D10   >>>  Tx

// you will need arduino 1.0.1 or higher to run this sketch

//#################### Note set blue tooth VCC as 5V & ground near 13 ############################

#include <SoftwareSerial.h>// import the serial library

SoftwareSerial _blueTooth(10, 11); // RX, TX
int ledpin=13; // led on D13 will show blink on / off
int BluetoothData; // the data given from Computer

void setup() {
  // put your setup code here, to run once:
  _blueTooth.begin(9600);
  _blueTooth.println("Hello Bluetooth On please press 1 or 0 blink LED ..");
  pinMode(ledpin,OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
   if (_blueTooth.available()){
BluetoothData=_blueTooth.read();
   if(BluetoothData=='1'){   // if number 1 pressed ....
   digitalWrite(ledpin,1);
   _blueTooth.println("LED  On D13 ON ! ");
   }
  if (BluetoothData=='0'){// if number 0 pressed ....
  digitalWrite(ledpin,0);
   _blueTooth.println("LED  On D13 Off ! ");
  }
}
delay(100);// prepare for next data ...
}

