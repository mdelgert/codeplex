//http://forum.arduino.cc/index.php/topic,17198.0.html

#include <Servo.h>

Servo myservo;
int pin = 9;
int angle, signal, n, pos;


void setup()
{
  myservo.attach(pin);
  myservo.write(130);
  Serial.begin(9600); //begins serial comm at 9600 baud
  Serial.println("Enter the 3 digit angle you want the servo to move to: ");
}

void loop()
{
  if(Serial.available() >= 3)
  {
    angle = GetAngle();
    myservo.write(angle);
    Serial.print("angle = ");
    Serial.print(angle);
    Serial.print(" (" );
    Serial.print(myservo.readMicroseconds());
    Serial.println(")");
    delay(1000);
  }
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