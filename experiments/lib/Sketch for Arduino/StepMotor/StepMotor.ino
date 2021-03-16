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
        break;
      case '2':
        GoOnStep("transmitter", "back");
        break;
      case '3':
        GoOnStep("receiver", "forward");
        break;
      case '4':
        GoOnStep("receiver", "back");
        break;
      case '0':
        GoOnSector("transmitter", "forward");
        break;
      case '9':
        GoOnSector("transmitter", "back");
        break;
      case '8':
        GoOnSector("receiver", "forward");
        break;
      case '7':
        GoOnSector("receiver", "back");
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
          test(2);
        }
    } else if (Motor == "receiver")
    {
      if (Direction == "forward")
        {
          test(3);
        } else if (Direction == "back")
        {
          test(4);
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
          test(5);
        } else if (Direction == "back")
        {
          test(6);
        }
    } else if (Motor == "receiver")
    {
      if (Direction == "forward")
        {
          test(7);
        } else if (Direction == "back")
        {
          test(8);
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
