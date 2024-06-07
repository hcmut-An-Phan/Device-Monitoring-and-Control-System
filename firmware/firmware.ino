#include <TimerOne.h>
#include "HID-Project.h"

const int led1 = 2;
const int led2 = 3;
const int led3 = 4;
const int led4 = 5;   

const int button1 = 6;
const int button2 = 7;
const int button3 = 8;
const int button4 = 9;

const int PWM = 10; // chân PWM

// Buffer to hold RawHID data.
// If host tries to send more data than this,
// it will respond with an error.
// If the data is not read until the host sends the next data
// it will also respond with an error and the data will be lost.
uint8_t rawhidData[255];

// khai báo các biến 
static uint8_t DI_value;
static int AI_0;
int dutyCycle_old = 128; // (0-100% --> 0-255)
int dutyCycle_new;
uint32_t frequency_old = 1000; // Tần số PWM (Hz)
uint32_t frequency_new;

// buffer truyền nhận dữ liệu 
uint8_t USB_tx_buffer[100];
uint8_t USB_rx_buffer[65];

void setup() 
{

  Serial.begin(115200);
  // Set the RawHID OUT report array.
  // Feature reports are also (parallel) possible, see the other example for this.
  RawHID.begin(rawhidData, sizeof(rawhidData));

  pinMode(A0, INPUT);
  pinMode(PWM, OUTPUT);
  Timer1.initialize(1000000 / frequency_old);//Khởi tạo bộ đếm thời gian với tần số PWM
  Timer1.pwm(PWM, dutyCycle_old);            // Cấu hình chân PWM với duty cycle ban đầu

  pinMode(led1, OUTPUT);
  pinMode(led2, OUTPUT);
  pinMode(led3, OUTPUT);
  pinMode(led4, OUTPUT);

  pinMode(button1, INPUT);
  pinMode(button2, INPUT);
  pinMode(button3, INPUT);
  pinMode(button4, INPUT);

}

void loop() 
{
  // đọc các chân DI 
 USB_tx_buffer[0] = !digitalRead(button1);
 USB_tx_buffer[1] = !digitalRead(button2);
 USB_tx_buffer[2] = !digitalRead(button3);
 USB_tx_buffer[3] = !digitalRead(button4);

  // đọc ADC_A0
  AI_0 = analogRead(A0);
  USB_tx_buffer[4] = AI_0 >> 24;
  USB_tx_buffer[5] = AI_0 >> 16;
  USB_tx_buffer[6] = AI_0 >>  8; 
  USB_tx_buffer[7] = AI_0 ;

  // gửi dữ liệu lên pc 
  RawHID.write(USB_tx_buffer, sizeof(USB_tx_buffer));
  delay(100);

  // Check if there is new data from the RawHID device
  auto bytesAvailable = RawHID.available();
  if (bytesAvailable)
  {
    // Mirror data via Serial
    while (bytesAvailable--) 
    {
      USB_rx_buffer[63 - bytesAvailable] = RawHID.read();
      if (bytesAvailable < 59)
      {
        digitalWrite(led1,USB_rx_buffer[0]);
        digitalWrite(led2,USB_rx_buffer[1]);
        digitalWrite(led3,USB_rx_buffer[2]);
        digitalWrite(led4,USB_rx_buffer[3]);
      
      dutyCycle_new = map(USB_rx_buffer[4], 0, 100, 0, 255);

      frequency_new = USB_rx_buffer[5] *1000;

      if( dutyCycle_new != dutyCycle_old)
      {
        dutyCycle_old = dutyCycle_new ;
        // Cập nhật duty cycle của PWM
        Timer1.setPwmDuty(PWM, dutyCycle_old);
      }

      if(  frequency_new != frequency_old)
      {
        frequency_old =  frequency_new ;
        //Cập nhật tần số PWM
        Timer1.setPeriod(1000000 / frequency_old);
      }

      delay(100);
      analogWrite(led2,  dutyCycle); // Gửi tín hiệu PWM với Duty Cycle hiện tại  
      }
    }
  }
}



