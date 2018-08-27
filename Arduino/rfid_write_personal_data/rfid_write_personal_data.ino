#include <Keypad.h>
#include <Wire.h>
#include <LiquidCrystal_I2C.h>
#include <SPI.h>
#include <MFRC522.h>

#define RST_PIN         9
#define SS_PIN          10
String ID;
String READLN;
String WAIT = "0";

MFRC522 mfrc522(SS_PIN, RST_PIN);

LiquidCrystal_I2C lcd( 0x27, 16, 2);

const byte ROWS = 4;
const byte COLS = 4;

char hexaKeys[ROWS][COLS] = {
  {'1', '2', '3', 'A'},
  {'4', '5', '6', 'B'},
  {'7', '8', '9', 'C'},
  {'*', '0', '#', 'D'}
};

byte rowPins[ROWS] = {8, 7, 6, 5};
byte colPins[COLS] = {4, 3, 2, 1};

Keypad customKeypad = Keypad(makeKeymap(hexaKeys), rowPins, colPins, ROWS, COLS);


void setup() {
  Serial.begin(9600);
  SPI.begin();
  mfrc522.PCD_Init();
  lcd.init();
  lcd.backlight();
  lcd.setCursor(0, 0);
}

void loop() {
  READLN = " ";
  WAIT = " ";
  ID = " ";
  READLN = Serial.readString();

  if ( READLN == "CARD")
  {
    readcard();
  }

  else if (READLN == "PIN")
  {
    PIN();
  }


}

void readcard()
{
  MFRC522::MIFARE_Key key;
  for (byte i = 0; i < 6; i++) key.keyByte[i] = 0xFF;

  if ( ! mfrc522.PICC_IsNewCardPresent()) {
    return;
  }

  if ( ! mfrc522.PICC_ReadCardSerial()) {
    return;
  }
  for (byte i = 0; i < mfrc522.uid.size; i++) {
    Serial.print(mfrc522.uid.uidByte[i] < 0x10 ? " 0" : " ");
    Serial.print(mfrc522.uid.uidByte[i], HEX);
    ID = mfrc522.uid.uidByte[i], HEX;
  }
  Serial.println();
  delay(500);

  if (ID != NULL)
  {
    return true;
  }
  else
  {
    return false;
  }
}

void PIN()
{
  lcd.print("Card detekted");
  while (WAIT.substring(0) != "#")
  {
    char customKey = customKeypad.getKey();

    if (customKey)
    {
      lcd.print(customKey);
      Serial.print(customKey);
      if (customKey == '#')
      {
        WAIT = customKey;
        Serial.println("");
        return true;
        //loop();
      }
      else
      {
        PIN();
        //return;
        //loop();
      }
    }
  }
}

