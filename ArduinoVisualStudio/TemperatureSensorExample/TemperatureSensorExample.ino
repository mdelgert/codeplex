//http://playground.arduino.cc/Main/InternalTemperatureSensor
//http://learn.adafruit.com/tmp36-temperature-sensor/using-a-temp-sensor
////http://playground.arduino.cc/Learning/Tutorial01

#include <SoftwareSerial.h>

SoftwareSerial _blueTooth(10, 11); // RX, TX
int ledpin=13; // led on D13 will show blink on / off
int BluetoothData; // the data given from Computer

//#################### Note set blue tooth VCC as 5V & ground near 13 ############################

// D11   >>>  Rx
// D10   >>>  Tx


void setup()
{
  //Serial.begin(9600);
  //Serial.println(F("Internal Temperature Sensor"));
  
   _blueTooth.begin(9600);
   pinMode(ledpin,OUTPUT);
  
}

void loop()
{
  
  if (_blueTooth.available()){
  // Show the temperature in degrees Celcius.
  //Serial.println(GetTemp(),1);
  
  int _offSet = 7; //Had to offset tempture for acuracy 
  float temperatureF = (GetTemp() * 9.0 / 5.0) + 32.0;
  temperatureF = temperatureF - _offSet;
  
  //Serial.print(temperatureF + " degrees F"); 
  //Serial.println(" degrees F");
   
   _blueTooth.println(temperatureF); _blueTooth.println(" degrees F");
   
  delay(1000);
  }
}

double GetTemp(void)
{
  unsigned int wADC;
  double t;

  // The internal temperature has to be used
  // with the internal reference of 1.1V.
  // Channel 8 can not be selected with
  // the analogRead function yet.

  // Set the internal reference and mux.
  ADMUX = (_BV(REFS1) | _BV(REFS0) | _BV(MUX3));
  ADCSRA |= _BV(ADEN);  // enable the ADC

  delay(20);            // wait for voltages to become stable.

  ADCSRA |= _BV(ADSC);  // Start the ADC

  // Detect end-of-conversion
  while (bit_is_set(ADCSRA,ADSC));

  // Reading register "ADCW" takes care of how to read ADCL and ADCH.
  wADC = ADCW;

  // The offset of 324.31 could be wrong. It is just an indication.
  t = (wADC - 324.31 ) / 1.22;

  // The returned temperature is in degrees Celcius.
  return (t);
}

