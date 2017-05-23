
//http://forum.arduino.cc/index.php/topic,17198.0.html

#include <Servo.h>
#include <SoftwareSerial.h>

Servo _doorServo;
int _angleOpen = 130;
int _angleClose = 50;

int _servoPin = 9;
int angle, signal, n, pos;

SoftwareSerial _blueTooth(10, 11); // RX, TX
int ledpin1 = 6; // led on D6 will show blink on / off
int ledpin2 = 7; // led on D7 will show blink on / off
int BluetoothData; // the data given from Computer

void setup()
{
	_blueTooth.begin(9600);
	_blueTooth.println("Enter 1 open 0 close door.");
	pinMode(ledpin1,OUTPUT);
	pinMode(ledpin2,OUTPUT);
	_doorServo.attach(_servoPin);
	_doorServo.write(_angleOpen);
	digitalWrite(ledpin1,1);
}

void loop()
{  

	// put your main code here, to run repeatedly:
	if (_blueTooth.available()){
		BluetoothData=_blueTooth.read();
		if(BluetoothData=='1'){   // if number 1 pressed ....
			DoorOpen();
			_blueTooth.println("Door open.");
		}
		if (BluetoothData=='0'){// if number 0 pressed ....
			DoorClose();
			_blueTooth.println("Door close.");
		}
	}

	delay(100);// prepare for next data ...

} 

void DoorOpen()
{
	digitalWrite(ledpin1,1);
	digitalWrite(ledpin2,0);
	_doorServo.write(_angleOpen);
}

void DoorClose()
{
	digitalWrite(ledpin1,0);
	digitalWrite(ledpin2,1);
	_doorServo.write(_angleClose);
}

// get three digits from serial
// ToDo - check for non-digits
int GetAngle()
{
	pos = 0;
	for(n = 0; n < 3; n++)  
	{
		char ch = Serial.read();
		pos =  (pos * 10) + ch - '0' ;
	}
	Serial.print("\nYou input: ");
	Serial.println(pos);
	return (pos);
}
