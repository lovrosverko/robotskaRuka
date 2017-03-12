#include <Servo.h>

int ledPin = 13;
int servoPin1 = 2;
int servoPin2 = 3;
int servoPin3 = 4;
int servoPin4 = 5;

// početne pozicije
int startPos1 = 100;
int startPos2 = 160;
int startPos3 = 70;
int startPos4 = 95;

int stopPos1;
int stopPos2;
int stopPos3;
int stopPos4;


// struktura naredbe
byte inputByte[11];

Servo servo1;
Servo servo2;
Servo servo3;
Servo servo4;

int i1;
int i2;
int i3;
int i4;

void moveServo() {
  move1();
  move2();
  move3();
  move4();
}

void move1() {
  if (startPos1 < stopPos1)
  {
    for (i1 = startPos1; i1 < stopPos1; i1++)
    {
      servo1.write(i1);
      delay(25);
    }

  }
  else
  {
    for (i1 = startPos1; i1 > stopPos1; i1--)
    {
      servo1.write(i1);
      delay(25);
    }
  }
  startPos1 = i1;
}

void move2()
{

  if (startPos2 < stopPos2)
  {
    for (i2 = startPos2; i2 < stopPos2; i2++)
    {
      servo2.write(i2);
      delay(25);
    }

  }
  else
  {
    for (i2 = startPos2; i2 > stopPos2; i2--)
    {
      servo2.write(i2);
      delay(25);
    }
  }
  startPos2 = i2;
}

void move3()
{

  if (startPos3 < stopPos3)
  {
    for (i3 = startPos3; i3 < stopPos3; i3++)
    {
      servo3.write(i3);
      delay(25);
    }

  }
  else
  {
    for (i3 = startPos3; i3 > stopPos3; i3--)
    {
      servo3.write(i3);
      delay(25);
    }
  }
  startPos3 = i3;
}

void move4()
{



  if (startPos4 < stopPos4)
  {
    for (i4 = startPos4; i4 < stopPos4; i4++)
    {
      servo4.write(i4);
      delay(25);
    }

  }
  else
  {
    for (i4 = startPos4; i4 > stopPos4; i4--)
    {
      servo4.write(i4);
      delay(25);
    }
  }
  startPos4 = i4;
}

void setup() {

  pinMode(ledPin, OUTPUT);
  Serial.begin(9600);

  pinMode (servoPin1, OUTPUT);
  servo1.attach (servoPin1);
  servo1.write(startPos1);

  pinMode (servoPin2, OUTPUT);
  servo2.attach (servoPin2);
  servo2.write(startPos2);

  pinMode (servoPin3, OUTPUT);
  servo3.attach (servoPin3);
  servo3.write(startPos3);

  pinMode (servoPin4, OUTPUT);
  servo4.attach (servoPin4);
  servo4.write(startPos4);

  // Start signal
  for (int a = 250; a > 50; a -= 50)
  {
    digitalWrite(ledPin, HIGH);
    delay(a);
    digitalWrite(ledPin, LOW);
    delay(a);
  }
  for (int a2 = 50; a2 > 10; a2 -= 5)
  {
    digitalWrite(ledPin, HIGH);
    delay(a2);
    digitalWrite(ledPin, LOW);
    delay(a2);
  }

}

void loop() {


  if (Serial.available() == 11)
  {
    // poruka
    inputByte[0] = Serial.read();
    delay(10);
    inputByte[1] = Serial.read();
    delay(10);
    inputByte[2] = Serial.read();
    delay(10);
    inputByte[3] = Serial.read();
    delay(10);
    inputByte[4] = Serial.read();
    delay(10);
    inputByte[5] = Serial.read();
    delay(10);
    inputByte[6] = Serial.read();
    delay(10);
    inputByte[7] = Serial.read();
    delay(10);
    inputByte[8] = Serial.read();
    delay(10);
    inputByte[9] = Serial.read();
    delay(10);
    inputByte[10] = Serial.read();
    delay(10);
  }

  if (inputByte[0] == 16)
  {

    // provjera naredbe
    switch (inputByte[1])
    {
      case 121:
        {
          switch (inputByte[2])
          {
            case 1:
              {
                stopPos1 = inputByte[3];
                stopPos2 = inputByte[5];
                stopPos3 = inputByte[7];
                stopPos4 = inputByte[9];
                moveServo();
                Serial.print("Pozicija");
                break;
              }
            case 2:
              {
                stopPos1 = inputByte[3];
                stopPos2 = inputByte[5];
                stopPos3 = inputByte[7];
                stopPos4 = inputByte[9];
                moveServo();
                Serial.print("Pozicija");
                
                break;
              }
            case 3:
              {
                stopPos1 = inputByte[3];
                stopPos2 = inputByte[5];
                stopPos3 = inputByte[7];
                stopPos4 = inputByte[9];
                moveServo();
                Serial.print("Pozicija");
                break;
              }
            case 4:
              {
                stopPos1 = inputByte[3];
                stopPos2 = inputByte[5];
                stopPos3 = inputByte[7];
                stopPos4 = inputByte[9];
                moveServo();
                Serial.print("Pozicija");
                break;
              }
            case 5:
              {
                stopPos1 = inputByte[3];
                stopPos2 = inputByte[5];
                stopPos3 = inputByte[7];
                stopPos4 = inputByte[9];
                moveServo();
                Serial.print("Pozicija");
                break;
              }
          }
          break;

        }
      case 127:
        {
          switch (inputByte[2])
          {
            case 1:
              {
                stopPos1 = inputByte[3];
                move1();
                break;
              }
            case 2:
              {
                stopPos2 = inputByte[3];
                move2();
                break;
              }
            case 3:
              {
                stopPos3 = inputByte[3];
                move3();
                break;
              }
            case 4:
              {
                stopPos4 = inputByte[3];
                move4();
                break;
              }
            case 6:
              {
                // inputByte[3] šalje HIGH (255) ili LOW (!255) naredbu
                if (inputByte[3] == 255)
                {
                  digitalWrite(ledPin, HIGH);
                  break;
                }
                else
                {
                  digitalWrite(ledPin, LOW);
                  break;
                }
                break;
              }
              break;
          }
          break;
        }
      case 128:
        { //Potvrda nazočnosti
          Serial.println("Arduino je ovdje!");
          delay(10);
          break;
        }
        break;
    }
  }
}


