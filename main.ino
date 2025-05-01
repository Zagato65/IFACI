#include "DHT.h"

#define DHTPIN 4
#define DHTTYPE DHT11
#define BUZZER_PIN 5
#define LED_RED_PIN 12
#define POTENTIOMETER_PIN A0

DHT dht(DHTPIN, DHTTYPE);

int count = 0;
int buttonState = 0;
int temp = 0;
int potValue = 0;
int percentage = 0;
bool alarmeAtivo = false;

void setup() {
  Serial.begin(9600);
  dht.begin();
  pinMode(LED_GREEN_PIN, OUTPUT);
  pinMode(LED_RED_PIN, OUTPUT);
  pinMode(BUZZER_PIN, OUTPUT);
  pinMode(POTENTIOMETER_PIN, INPUT);
}

void loop() {
  if(Serial.available() > 0){
    buttonState = Serial.parseInt();
  }
  
  if(buttonState == 1){
    sendSensorData();
    digitalWrite(LED_RED_PIN, HIGH);
    
    if(percentage > 60 && !alarmeAtivo){
      ativarAlarme();
      alarmeAtivo = true;
    } 
    else if(percentage <= 60 && alarmeAtivo){
      desativarAlarme();
      alarmeAtivo = false;
    }
  } 
  else if(buttonState == 0) {
    digitalWrite(LED_RED_PIN, LOW);
    if(alarmeAtivo){
      desativarAlarme();
      alarmeAtivo = false;
    }
  }
  
  delay(100);
}

void sendSensorData() {
  potValue = analogRead(POTENTIOMETER_PIN);
  temp = dht.readTemperature();
  limparSerial();
  percentage = map(potValue, 0, 1023, 0, 100);
  Serial.println(String(percentage) + "," + String(temp));
}

void ativarAlarme() {
  for(int i = 0; i < 5; i++) {
    tone(BUZZER_PIN, 1000, 200);
    delay(200);
    tone(BUZZER_PIN, 1500, 200);
    delay(200);
  }
  noTone(BUZZER_PIN);
}

void desativarAlarme() {
  noTone(BUZZER_PIN);
}

void limparSerial() {
  while (Serial.available()) {
    Serial.read();
  }
}
