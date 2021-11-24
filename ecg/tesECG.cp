#line 1 "C:/TKE/MikroE/tesECG.c"
unsigned int dt,i,dummy;
float teg[200],y[200],bb0,bb1,bb2,bb3,bb4,aa1,aa2,aa3,aa4;
char result[15],tmp;




void InitTimer2(){
 T2CON = 0x8000;
 T2IE_bit = 1;
 T2IF_bit = 0;
 IPC0 = IPC0 | 0x1000;
 PR2 = 14746;
}

void Timer2Interrupt() iv IVT_ADDR_T2INTERRUPT{
 if(T2IF)
 {
 dummy = 0x0fff;
 sprintf(result,"%1.2f",dummy);
 UART1_WRITE_Text(result); Delay_us(1);

 dt = ADC1_Read(12);
 teg[i] = (float) (dt * 5)/4095;

 y[i] = bb0*teg[i] + bb1*teg[i-1] + bb2*teg[i-2] + bb3*teg[i-3] + bb4*teg[i-4]
 - aa1*y[i-1] - aa2*y[i-2] - aa3*y[i-3] - aa4*y[i-4];
 sprintf(result,"%2.4f",y[i]);
 UART1_WRITE('A');
 UART1_WRITE_Text(result); Delay_us(1);




 UART1_WRITE('\r');
 UART1_WRITE('\n'); Delay_us(1);

 i++;
 if (i=100) i=0;
 }

 T2IF_bit = 0;

}

void UART_RX() iv IVT_ADDR_U1RXINTERRUPT{
 if(U1RXIF)
 {
 tmp = UART1_Read();

 if((tmp == 'n')||(tmp == 'N'))
 {

 bb0=1; bb1=0; bb2=0; bb3=0; bb4=0;
 aa1=0; aa2=0; aa3=0; aa4=0;
 T2IE_bit = 1; i=0;
 }

 if((tmp == 'l')||(tmp == 'L'))
 {

 bb0=1; bb1=0; bb2=0; bb3=0; bb4=0;
 aa1=1; aa2=1; aa3=0; aa4=0;
 T2IE_bit = 1; i=0;
 }

 if((tmp == 'h')||(tmp == 'H'))
 {
 UART1_Write_Text("High Pass Filter");


 T2IE_bit = 1; i=0;
 }

 if((tmp == 'b')||(tmp == 'B'))
 {
 UART1_Write_Text("Band Pass Filter");


 T2IE_bit = 1; i=0;
 }

 if((tmp == 's')||(tmp == 's'))
 {
 UART1_Write_Text("Band Stop Filter");


 T2IE_bit = 1; i=0;
 }

 if((tmp == 'x')||(tmp == 'X'))
 {



 T2IE_bit = 0; i=0;
 }
 }

 U1RXIF_bit = 0;
}

void main() {
 ADC1_Init(); Delay_ms(100);
 UART1_Init_Advanced(115200,_UART_8BIT_ODDPARITY,_UART_TWO_STOPBITS); Delay_ms(100);
 U1Modebits.ALTIO = 1; Delay_ms(100);
 InitTimer2(); Delay_ms(100);
 U1RXIF_bit = 0;
 U1RXIE_bit = 1;
}
