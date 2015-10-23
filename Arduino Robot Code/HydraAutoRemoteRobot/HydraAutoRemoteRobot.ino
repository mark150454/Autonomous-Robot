#define motorB 12
#define brakeB 9
#define motorA 13
#define brakeA 8
#define motorAPWM 11
#define motorBPWM 3
#define trigPin A5
#define echoPin A4

int motorASpeed = 120;
int motorBSpeed = 120;
String rxString;
bool isAutonomous = true;
unsigned long duration;
double distance;

void setup() {
  Serial.begin(9600); 

  pinMode(trigPin, OUTPUT);
  pinMode(echoPin, INPUT);
  
  pinMode(motorA, OUTPUT); //Initiates Motor Channel A pin
  pinMode(brakeA, OUTPUT); //Initiates Brake Channel A pin

  //Setup Channel B
  pinMode(motorB, OUTPUT); //Initiates Motor Channel B pin
  pinMode(brakeB, OUTPUT); //Initiates Brake Channel B pin 
}
void loop(){
  if(isAutonomous)
  {
    rxString = Serial.readString();  
    if(rxString.equals("manual"))
    {
      isAutonomous = false;
    }
    digitalWrite(trigPin, LOW); //Telling the sensor to send out an ultrasonic pulse and wait for the echo
    delayMicroseconds(2);
    digitalWrite(trigPin, HIGH);
    delayMicroseconds(10);
    digitalWrite(trigPin, LOW);
    duration = pulseIn(echoPin, HIGH);
    distance = (duration/2) / 29.1;
    
    if (distance < 30)  //If sensor is closer than 30cm to an object
    {
      RobotBrake();
  
      delay(2000);
  
      RobotTurnLeft();
  
      delay(1000);  
  
      RobotBrake();
    }
    else  //If the sensor does not detect an object in front of it
    {
       RobotDriveForward();
    }
  }
  else
  {
    manualControl();
  }
}

void manualControl() {
  while (!Serial.available());   // stay here so long as COM port is empty   
  rxString = Serial.readString();        // read next available string
  if( rxString == "8" )
  {
    RobotDriveForward();  // if it's a 0 (zero) tun LED off
  }
  else if( rxString == "2" )
  {
    RobotDriveReverse(); // if it's a 1 (one) turn LED on
  }
  else if(rxString == "4")
  {
    RobotTurnLeft();
  }
  else if(rxString == "6")
  {
    RobotTurnRight();
  }
  else if(rxString == "5")
  {
    RobotBrake();
  }
  else if(rxString == "0")
  {    
    double distance = RobotHead1Sense();

    Serial.print(distance);
  }
  else if (rxString == "1")
  {
    double robotSpeed;
    
    robotSpeed = CalculateRobotSpeed();

    Serial.print(robotSpeed);
  }
  else if (rxString.startsWith("9"))
  {
    Serial.print(rxString);
    rxString.remove(0,1);

    motorASpeed = rxString.toInt();
  }
  else if (rxString.startsWith("7"))
  {
    Serial.print(rxString);
    rxString.remove(0,1);

    motorBSpeed = rxString.toInt();
  }
  else if (rxString == "manual")
  {
    isAutonomous = false;
  }
  else if (rxString == "auto")
  {
    isAutonomous = true;
  }
}

//Functions//

void RobotDriveForward()
{
    //Motor A forward at the specified speed
    digitalWrite(motorA, HIGH); //Establishes forward direction of Channel A
    digitalWrite(brakeA, LOW); //Disengage the brake for Channel A
    analogWrite(motorAPWM, motorASpeed); //Spins the motor on Channel A at the designated speed
  
    //Motor B forward at the specified speed
    digitalWrite(motorB, HIGH);
    digitalWrite(brakeB, LOW);
    analogWrite(motorBPWM, motorBSpeed);
}

void RobotTurnLeft()
{
    digitalWrite(brakeB, LOW);
    digitalWrite(motorB, HIGH);
    analogWrite(motorBPWM, motorBSpeed);
}

void RobotTurnRight()
{
    digitalWrite(brakeA, LOW);
    digitalWrite(motorA, HIGH);
    analogWrite(motorAPWM, motorASpeed);
}

void RobotDriveReverse()
{
    digitalWrite(brakeA, LOW);
    digitalWrite(brakeB, LOW);
    digitalWrite(motorA, LOW);
    digitalWrite(motorB, LOW);
    analogWrite(motorAPWM, motorASpeed);
    analogWrite(motorBPWM, motorBSpeed);
}

void RobotBrake()
{
    digitalWrite(brakeA, HIGH); //Engages the brakes for the motors
    digitalWrite(brakeB, HIGH);
}

double RobotHead1Sense()
{
  long duration;
  double distance;
  
  digitalWrite(trigPin, LOW); //Telling the sensor to send out an ultrasonic pulse and wait for the echo
  delayMicroseconds(2);
  digitalWrite(trigPin, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin, LOW);
  duration = pulseIn(echoPin, HIGH);
  distance = (duration/2) / 29.1;

  return distance;
}

double CalculateRobotSpeed()
{
  double firstDist;
  double secondDist;
  double robotSpeed;
  
  firstDist = RobotHead1Sense();
  RobotDriveForward();
  delay(1000);
  RobotBrake();
  secondDist = RobotHead1Sense();
  robotSpeed = (firstDist - secondDist) / 1;

  return robotSpeed;
}

