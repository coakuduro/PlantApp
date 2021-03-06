/*
  Software serial multple serial test

 Receives from the hardware serial, sends to software serial.
 Receives from software serial, sends to hardware serial.

 The circuit:
 * RX is digital pin 10 (connect to TX of other device)
 * TX is digital pin 11 (connect to RX of other device)

 Note:
 Not all pins on the Mega and Mega 2560 support change interrupts,
 so only the following can be used for RX:
 10, 11, 12, 13, 50, 51, 52, 53, 62, 63, 64, 65, 66, 67, 68, 69

 Not all pins on the Leonardo and Micro support change interrupts,
 so only the following can be used for RX:
 8, 9, 10, 11, 14 (MISO), 15 (SCK), 16 (MOSI).

 created back in the mists of time
 modified 25 May 2012
 by Tom Igoe
 based on Mikal Hart's example

  This example shows how to read and write data to and from an SD card file
  The circuit:
   SD card attached to SPI bus as follows:
 ** MOSI - pin 11
 ** MISO - pin 12
 ** CLK - pin 13
 ** CS - pin 4 (for MKRZero SD: SDCARD_SS_PIN)
 */
 #define CS_SD 4
 #define LED 5
 #define LED_SENSOR A0
 
#include <SoftwareSerial.h>
#include <DHT.h>;
#include <SPI.h>
#include <SD.h>
#include "RTClib.h"


#define DHTPIN 7     // what pin we're connected to
#define DHTTYPE DHT22   // DHT 22  (AM2302)
DHT dht(DHTPIN, DHTTYPE); //// Initialize DHT sensor for normal 16mhz Arduino
SoftwareSerial mySerial(3, 2); // RX, TX
File myFile;
RTC_DS3231 rtc;

String led_on="L_ON";
String led_off="L_OFF";
float hum;  //Stores humidity value
float temp; //Stores temperature value
bool led_status=false;
int val_limit_light=150;
char daysOfTheWeek[7][12] = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};

void setup() {
  // Open serial communications and wait for port to open:
  String command;
  pinMode(LED,OUTPUT);
  pinMode(LED_SENSOR,INPUT);
  Serial.begin(9600);
  dht.begin();
  while (!Serial) {
    ; // wait for serial port to connect. Needed for native USB port only
  }

 // set the data rate for the SoftwareSerial port
  mySerial.begin(74880);
  //mySerial.println("Hello, world?");
  Serial.flush();
  mySerial.flush();
  
  if (! rtc.begin()) {
    Serial.println("Couldn't find RTC");
    Serial.flush();
    abort();
  }
  else
    Serial.println("RTC was found");
  if (rtc.lostPower()) {
      Serial.println("RTC lost power, let's set the time!");
      // When time needs to be set on a new device, or after a power loss, the
      // following line sets the RTC to the date & time this sketch was compiled
      rtc.adjust(DateTime(F(__DATE__), F(__TIME__)));
      // This line sets the RTC with an explicit date & time, for example to set
      // January 21, 2014 at 3am you would call:
      // rtc.adjust(DateTime(2014, 1, 21, 3, 0, 0));
    }
    
   if (!SD.begin(4)) {
    Serial.println("SD card initialization failed!");
  }
  else
  Serial.println("SD card initialization done.");
  
  }
/*****************************************************************************************************************************************************************************************************************************************
***********************KOMANDE************************************
1.L_ON    PALI SVETLA
2. L_OF   GASI SVETLA
3. status   Vraca statuse temperature,vlaznosti,zasicenosti svetlom i status svetla
 


*****************************************************************************************************************************************************************************************************************************************/
void loop() { // run over and over
   String command;
  if (mySerial.available()) {
     command=mySerial.readString();
     if(command.equals(led_on))
     {
     turn_led_on();
     command="";
     }
     else if(command.equals(led_off))
     {
      turn_led_off();
     command=""; 
     }
     else if(command.equals("status"))
     {
      
      int light_value=analogRead(A0);
      hum = dht.readHumidity();
      temp= dht.readTemperature();
      mySerial.println("");
      mySerial.println("L"+ (String)light_value +';');
      //mySerial.print(light_value);
      mySerial.println("H"+ (String)hum +';');
    //  mySerial.print(hum);
       mySerial.println("T" + (String)temp +';');
    //  mySerial.print(temp);
      if(led_status)
          mySerial.println("lon");
       else
          mySerial.println("lof");


  // if the file opened okay, write to it:
  if (myFile) {
       myFile = SD.open("test.txt", FILE_WRITE);
       DateTime now = rtc.now();
        myFile.print(now.year(), DEC);
      myFile.print('/');
      myFile.print(now.month(), DEC);
      myFile.print('/');
      myFile.print(now.day(), DEC);
      myFile.print(" (");
      myFile.print(daysOfTheWeek[now.dayOfTheWeek()]);
      myFile.print(") ");
      myFile.print(now.hour(), DEC);
      myFile.print(':');
      myFile.print(now.minute(), DEC);
      myFile.print(':');
      myFile.print(now.second(), DEC);
      myFile.println();
       myFile.println("L"+ (String)light_value +';');
      //mySerial.print(light_value);
      myFile.println("H"+ (String)hum +';');
    //  mySerial.print(hum);
       myFile.println("T" + (String)temp +';');
    //  mySerial.print(temp);
      if(led_status)
          myFile.println(" lon");
       else
          myFile.println(" lof");

           myFile.println("\n\r");
    myFile.close();
    Serial.println("done.");
  } else {
    // if the file didn't open, print an error:
    Serial.println("error opening test.txt");
  }
    
     }
  }
 if(analogRead(LED_SENSOR)<150 && !led_status)  //umesto led_status moze digitalRead
 {
  turn_led_on();
  //poslati aplikaciji da se upalio led. Ili uopste ne kontrolisati odavde led vec sve iz aplikacije mozgati
  // staviti neki tajmer kad da se ugasi, posto se ovako nece ugasiti
  led_status=true;
  }

  hum = dht.readHumidity();
  temp= dht.readTemperature();
}

void turn_led_on()
{
  digitalWrite(LED,LOW);
  led_status=true;
 
}
void turn_led_off()
{
  digitalWrite(LED,HIGH);
  led_status=false;
  
}
