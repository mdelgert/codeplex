const int ledPin =  13;      
int ledState = LOW; 
int SerialData; 

void setup() {
  Serial.begin(9600);
  Serial.print("Enter 1 for on or 0 turn light off");
  pinMode(ledPin, OUTPUT);      
}

void loop()
{
  if(Serial.available())
  {
    SerialData = Serial.read();
    if (SerialData == '1')
    {
      ledState = HIGH;
    }
    if (SerialData == '0')
    {
      ledState = LOW;
    }
    digitalWrite(ledPin, ledState);
  }
}

