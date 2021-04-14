int led = 13;
byte incomingByte;

void setup()
{
  pinMode(led, OUTPUT);
  Serial.begin(9600);
}

void loop()
{
  if (Serial.available() > 0) 
  {
    incomingByte = Serial.read();

    switch (incomingByte)
    {
      case '1':
        GoOnStep("transmitter", "forward");
        Serial.print("en");
        break;
      case '2':
        GoOnStep("transmitter", "back");
        Serial.print("en");
        break;
      case '3':
        GoOnStep("receiver", "forward");
        Serial.print("en");
        break;
      case '4':
        GoOnStep("receiver", "back");
        Serial.print("en");
        break;
      case '0':
        GoOnSector("transmitter", "forward");
        Serial.print("en");
        break;
      case '9':
        GoOnSector("transmitter", "back");
        Serial.print("en");
        break;
      case '8':
        GoOnSector("receiver", "forward");
        Serial.print("en");
        break;
      case '7':
        GoOnSector("receiver", "back");
        Serial.print("en");
        break;
    }
  }
}

void GoOnStep(const char* Motor, const char* Direction)
{
  if (Motor > 0)
  {
    if (Motor == "transmitter")
    {
      if (Direction == "forward")
        {
          test(1);
        } else if (Direction == "back")
        {
          test(1);
        }
    } else if (Motor == "receiver")
    {
      if (Direction == "forward")
        {
          test(1);
        } else if (Direction == "back")
        {
          test(1);
        }
    }
  }
}

void GoOnSector(const char* Motor, const char* Direction)
{
  if (Motor > 0)
  {
    if (Motor == "transmitter")
    {
      if (Direction == "forward")
        {
          test(1);
        } else if (Direction == "back")
        {
          test(1);
        }
    } else if (Motor == "receiver")
    {
      if (Direction == "forward")
        {
          test(1);
        } else if (Direction == "back")
        {
          test(1);
        }
    }
  }
}

void test(int count)
{
  int i = 1;
  while (i <= count)
  {
    delay(1000);
    digitalWrite(led, HIGH);
    delay(1000);
    digitalWrite(led, LOW);
    i++;
  }
}
