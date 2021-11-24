
_InitTimer2:

;tesECG.c,8 :: 		void InitTimer2(){
;tesECG.c,9 :: 		T2CON         = 0x8000;
	MOV	#32768, W0
	MOV	WREG, T2CON
;tesECG.c,10 :: 		T2IE_bit      = 1;
	BSET	T2IE_bit, BitPos(T2IE_bit+0)
;tesECG.c,11 :: 		T2IF_bit      = 0;
	BCLR	T2IF_bit, BitPos(T2IF_bit+0)
;tesECG.c,12 :: 		IPC0          = IPC0 | 0x1000;
	MOV	#4096, W1
	MOV	#lo_addr(IPC0), W0
	IOR	W1, [W0], [W0]
;tesECG.c,13 :: 		PR2           = 14746;
	MOV	#14746, W0
	MOV	WREG, PR2
;tesECG.c,14 :: 		}
L_end_InitTimer2:
	RETURN
; end of _InitTimer2

_Timer2Interrupt:
	LNK	#18
	PUSH	52
	PUSH	RCOUNT
	PUSH	W0
	MOV	#2, W0
	REPEAT	#12
	PUSH	[W0++]

;tesECG.c,16 :: 		void Timer2Interrupt() iv IVT_ADDR_T2INTERRUPT{
;tesECG.c,19 :: 		dummy = 0x0fff;
	PUSH	W10
	MOV	#4095, W0
	MOV	W0, _dummy
;tesECG.c,20 :: 		sprintf(result,"%1.2f",dummy);
	MOV	#4095, W0
	PUSH	W0
	MOV	#lo_addr(?lstr_1_tesECG), W0
	PUSH	W0
	MOV	#lo_addr(_result), W0
	PUSH	W0
	CALL	_sprintf
	SUB	#6, W15
;tesECG.c,21 :: 		UART1_WRITE_Text(result); Delay_us(1);
	MOV	#lo_addr(_result), W10
	CALL	_UART1_Write_Text
	MOV	#5, W7
L_Timer2Interrupt1:
	DEC	W7
	BRA NZ	L_Timer2Interrupt1
;tesECG.c,23 :: 		dt = ADC1_Read(12);
	MOV	#12, W10
	CALL	_ADC1_Read
	MOV	W0, _dt
;tesECG.c,24 :: 		teg[i] = (float) (dt * 5)/4095;
	MOV	_i, W1
	SL	W1, #2, W2
	MOV	#lo_addr(_teg), W1
	ADD	W1, W2, W1
	MOV	W1, [W14+0]
	MOV	#5, W1
	MUL.UU	W0, W1, W0
	CLR	W1
	CALL	__Long2Float
	MOV	#61440, W2
	MOV	#17791, W3
	CALL	__Div_FP
	MOV	[W14+0], W2
	MOV.D	W0, [W2]
;tesECG.c,26 :: 		y[i] = bb0*teg[i] + bb1*teg[i-1] + bb2*teg[i-2] + bb3*teg[i-3] + bb4*teg[i-4]
	MOV	_i, W0
	SL	W0, #2, W1
	MOV	#lo_addr(_y), W0
	ADD	W0, W1, W0
	MOV	W0, [W14+16]
	MOV	#lo_addr(_teg), W0
	ADD	W0, W1, W2
	MOV.D	[W2], W0
	MOV	_bb0, W2
	MOV	_bb0+2, W3
	CALL	__Mul_FP
	MOV	W0, [W14+0]
	MOV	W1, [W14+2]
	MOV	_i, W0
	DEC	W0
	SL	W0, #2, W1
	MOV	W1, [W14+14]
	MOV	#lo_addr(_teg), W0
	ADD	W0, W1, W2
	MOV.D	[W2], W0
	MOV	_bb1, W2
	MOV	_bb1+2, W3
	CALL	__Mul_FP
	MOV	[W14+0], W2
	MOV	[W14+2], W3
	CALL	__AddSub_FP
	MOV	W0, [W14+0]
	MOV	W1, [W14+2]
	MOV	_i, W0
	DEC2	W0
	SL	W0, #2, W1
	MOV	W1, [W14+12]
	MOV	#lo_addr(_teg), W0
	ADD	W0, W1, W2
	MOV.D	[W2], W0
	MOV	_bb2, W2
	MOV	_bb2+2, W3
	CALL	__Mul_FP
	MOV	[W14+0], W2
	MOV	[W14+2], W3
	CALL	__AddSub_FP
	MOV	W0, [W14+0]
	MOV	W1, [W14+2]
	MOV	_i, W0
	SUB	W0, #3, W0
	SL	W0, #2, W1
	MOV	W1, [W14+10]
	MOV	#lo_addr(_teg), W0
	ADD	W0, W1, W2
	MOV.D	[W2], W0
	MOV	_bb3, W2
	MOV	_bb3+2, W3
	CALL	__Mul_FP
	MOV	[W14+0], W2
	MOV	[W14+2], W3
	CALL	__AddSub_FP
	MOV	W0, [W14+0]
	MOV	W1, [W14+2]
	MOV	_i, W0
	SUB	W0, #4, W0
	SL	W0, #2, W1
	MOV	W1, [W14+8]
	MOV	#lo_addr(_teg), W0
	ADD	W0, W1, W2
	MOV.D	[W2], W0
	MOV	_bb4, W2
	MOV	_bb4+2, W3
	CALL	__Mul_FP
	MOV	[W14+0], W2
	MOV	[W14+2], W3
	CALL	__AddSub_FP
	MOV	W0, [W14+4]
	MOV	W1, [W14+6]
;tesECG.c,27 :: 		- aa1*y[i-1] - aa2*y[i-2] - aa3*y[i-3] - aa4*y[i-4];
	MOV	#lo_addr(_y), W1
	MOV	[W14+14], W0
	ADD	W1, W0, W2
	MOV.D	[W2], W0
	MOV	_aa1, W2
	MOV	_aa1+2, W3
	CALL	__Mul_FP
	MOV	W0, [W14+0]
	MOV	W1, [W14+2]
	MOV	[W14+4], W0
	MOV	[W14+6], W1
	PUSH.D	W2
	MOV	[W14+0], W2
	MOV	[W14+2], W3
	CALL	__Sub_FP
	POP.D	W2
	MOV	W0, [W14+4]
	MOV	W1, [W14+6]
	MOV	#lo_addr(_y), W1
	MOV	[W14+12], W0
	ADD	W1, W0, W2
	MOV.D	[W2], W0
	MOV	_aa2, W2
	MOV	_aa2+2, W3
	CALL	__Mul_FP
	MOV	W0, [W14+0]
	MOV	W1, [W14+2]
	MOV	[W14+4], W0
	MOV	[W14+6], W1
	PUSH.D	W2
	MOV	[W14+0], W2
	MOV	[W14+2], W3
	CALL	__Sub_FP
	POP.D	W2
	MOV	W0, [W14+4]
	MOV	W1, [W14+6]
	MOV	#lo_addr(_y), W1
	MOV	[W14+10], W0
	ADD	W1, W0, W2
	MOV.D	[W2], W0
	MOV	_aa3, W2
	MOV	_aa3+2, W3
	CALL	__Mul_FP
	MOV	W0, [W14+0]
	MOV	W1, [W14+2]
	MOV	[W14+4], W0
	MOV	[W14+6], W1
	PUSH.D	W2
	MOV	[W14+0], W2
	MOV	[W14+2], W3
	CALL	__Sub_FP
	POP.D	W2
	MOV	W0, [W14+4]
	MOV	W1, [W14+6]
	MOV	#lo_addr(_y), W1
	MOV	[W14+8], W0
	ADD	W1, W0, W2
	MOV.D	[W2], W0
	MOV	_aa4, W2
	MOV	_aa4+2, W3
	CALL	__Mul_FP
	MOV	W0, [W14+0]
	MOV	W1, [W14+2]
	MOV	[W14+4], W0
	MOV	[W14+6], W1
	PUSH.D	W2
	MOV	[W14+0], W2
	MOV	[W14+2], W3
	CALL	__Sub_FP
	POP.D	W2
	MOV	[W14+16], W2
	MOV.D	W0, [W2]
;tesECG.c,28 :: 		sprintf(result,"%2.4f",y[i]);
	MOV	_i, W0
	SL	W0, #2, W1
	MOV	#lo_addr(_y), W0
	ADD	W0, W1, W0
	PUSH	[W0++]
	PUSH	[W0--]
	MOV	#lo_addr(?lstr_2_tesECG), W0
	PUSH	W0
	MOV	#lo_addr(_result), W0
	PUSH	W0
	CALL	_sprintf
	SUB	#8, W15
;tesECG.c,29 :: 		UART1_WRITE('A');
	MOV	#65, W10
	CALL	_UART1_Write
;tesECG.c,30 :: 		UART1_WRITE_Text(result); Delay_us(1);
	MOV	#lo_addr(_result), W10
	CALL	_UART1_Write_Text
	MOV	#5, W7
L_Timer2Interrupt3:
	DEC	W7
	BRA NZ	L_Timer2Interrupt3
;tesECG.c,35 :: 		UART1_WRITE('\r');
	MOV	#13, W10
	CALL	_UART1_Write
;tesECG.c,36 :: 		UART1_WRITE('\n'); Delay_us(1);
	MOV	#10, W10
	CALL	_UART1_Write
	MOV	#5, W7
L_Timer2Interrupt5:
	DEC	W7
	BRA NZ	L_Timer2Interrupt5
;tesECG.c,38 :: 		i++;
	MOV	#1, W1
	MOV	#lo_addr(_i), W0
	ADD	W1, [W0], [W0]
;tesECG.c,39 :: 		if (i=100) i=0;
	MOV	#100, W0
	MOV	W0, _i
	CLR	W0
	MOV	W0, _i
;tesECG.c,42 :: 		T2IF_bit         = 0;
	BCLR	T2IF_bit, BitPos(T2IF_bit+0)
;tesECG.c,44 :: 		}
L_end_Timer2Interrupt:
	POP	W10
	MOV	#26, W0
	REPEAT	#12
	POP	[W0--]
	POP	W0
	POP	RCOUNT
	POP	52
	ULNK
	RETFIE
; end of _Timer2Interrupt

_UART_RX:
	PUSH	52
	PUSH	RCOUNT
	PUSH	W0
	MOV	#2, W0
	REPEAT	#12
	PUSH	[W0++]

;tesECG.c,46 :: 		void UART_RX() iv IVT_ADDR_U1RXINTERRUPT{
;tesECG.c,49 :: 		tmp = UART1_Read();
	PUSH	W10
	CALL	_UART1_Read
	MOV	#lo_addr(_tmp), W1
	MOV.B	W0, [W1]
;tesECG.c,51 :: 		if((tmp == 'n')||(tmp == 'N'))
	MOV.B	#110, W1
	CP.B	W0, W1
	BRA NZ	L__UART_RX56
	GOTO	L__UART_RX42
L__UART_RX56:
	MOV	#lo_addr(_tmp), W0
	MOV.B	[W0], W1
	MOV.B	#78, W0
	CP.B	W1, W0
	BRA NZ	L__UART_RX57
	GOTO	L__UART_RX41
L__UART_RX57:
	GOTO	L_UART_RX11
L__UART_RX42:
L__UART_RX41:
;tesECG.c,54 :: 		bb0=1; bb1=0; bb2=0; bb3=0; bb4=0;
	MOV	#0, W0
	MOV	#16256, W1
	MOV	W0, _bb0
	MOV	W1, _bb0+2
	CLR	W0
	CLR	W1
	MOV	W0, _bb1
	MOV	W1, _bb1+2
	CLR	W0
	CLR	W1
	MOV	W0, _bb2
	MOV	W1, _bb2+2
	CLR	W0
	CLR	W1
	MOV	W0, _bb3
	MOV	W1, _bb3+2
	CLR	W0
	CLR	W1
	MOV	W0, _bb4
	MOV	W1, _bb4+2
;tesECG.c,55 :: 		aa1=0; aa2=0; aa3=0; aa4=0;
	CLR	W0
	CLR	W1
	MOV	W0, _aa1
	MOV	W1, _aa1+2
	CLR	W0
	CLR	W1
	MOV	W0, _aa2
	MOV	W1, _aa2+2
	CLR	W0
	CLR	W1
	MOV	W0, _aa3
	MOV	W1, _aa3+2
	CLR	W0
	CLR	W1
	MOV	W0, _aa4
	MOV	W1, _aa4+2
;tesECG.c,56 :: 		T2IE_bit = 1; i=0;
	BSET	T2IE_bit, BitPos(T2IE_bit+0)
	CLR	W0
	MOV	W0, _i
;tesECG.c,57 :: 		}
L_UART_RX11:
;tesECG.c,59 :: 		if((tmp == 'l')||(tmp == 'L'))
	MOV	#lo_addr(_tmp), W0
	MOV.B	[W0], W1
	MOV.B	#108, W0
	CP.B	W1, W0
	BRA NZ	L__UART_RX58
	GOTO	L__UART_RX44
L__UART_RX58:
	MOV	#lo_addr(_tmp), W0
	MOV.B	[W0], W1
	MOV.B	#76, W0
	CP.B	W1, W0
	BRA NZ	L__UART_RX59
	GOTO	L__UART_RX43
L__UART_RX59:
	GOTO	L_UART_RX14
L__UART_RX44:
L__UART_RX43:
;tesECG.c,62 :: 		bb0=1; bb1=0; bb2=0; bb3=0; bb4=0;
	MOV	#0, W0
	MOV	#16256, W1
	MOV	W0, _bb0
	MOV	W1, _bb0+2
	CLR	W0
	CLR	W1
	MOV	W0, _bb1
	MOV	W1, _bb1+2
	CLR	W0
	CLR	W1
	MOV	W0, _bb2
	MOV	W1, _bb2+2
	CLR	W0
	CLR	W1
	MOV	W0, _bb3
	MOV	W1, _bb3+2
	CLR	W0
	CLR	W1
	MOV	W0, _bb4
	MOV	W1, _bb4+2
;tesECG.c,63 :: 		aa1=1; aa2=1; aa3=0; aa4=0;
	MOV	#0, W0
	MOV	#16256, W1
	MOV	W0, _aa1
	MOV	W1, _aa1+2
	MOV	#0, W0
	MOV	#16256, W1
	MOV	W0, _aa2
	MOV	W1, _aa2+2
	CLR	W0
	CLR	W1
	MOV	W0, _aa3
	MOV	W1, _aa3+2
	CLR	W0
	CLR	W1
	MOV	W0, _aa4
	MOV	W1, _aa4+2
;tesECG.c,64 :: 		T2IE_bit = 1; i=0;
	BSET	T2IE_bit, BitPos(T2IE_bit+0)
	CLR	W0
	MOV	W0, _i
;tesECG.c,65 :: 		}
L_UART_RX14:
;tesECG.c,67 :: 		if((tmp == 'h')||(tmp == 'H'))
	MOV	#lo_addr(_tmp), W0
	MOV.B	[W0], W1
	MOV.B	#104, W0
	CP.B	W1, W0
	BRA NZ	L__UART_RX60
	GOTO	L__UART_RX46
L__UART_RX60:
	MOV	#lo_addr(_tmp), W0
	MOV.B	[W0], W1
	MOV.B	#72, W0
	CP.B	W1, W0
	BRA NZ	L__UART_RX61
	GOTO	L__UART_RX45
L__UART_RX61:
	GOTO	L_UART_RX17
L__UART_RX46:
L__UART_RX45:
;tesECG.c,69 :: 		UART1_Write_Text("High Pass Filter");
	MOV	#lo_addr(?lstr3_tesECG), W10
	CALL	_UART1_Write_Text
;tesECG.c,72 :: 		T2IE_bit = 1; i=0;
	BSET	T2IE_bit, BitPos(T2IE_bit+0)
	CLR	W0
	MOV	W0, _i
;tesECG.c,73 :: 		}
L_UART_RX17:
;tesECG.c,75 :: 		if((tmp == 'b')||(tmp == 'B'))
	MOV	#lo_addr(_tmp), W0
	MOV.B	[W0], W1
	MOV.B	#98, W0
	CP.B	W1, W0
	BRA NZ	L__UART_RX62
	GOTO	L__UART_RX48
L__UART_RX62:
	MOV	#lo_addr(_tmp), W0
	MOV.B	[W0], W1
	MOV.B	#66, W0
	CP.B	W1, W0
	BRA NZ	L__UART_RX63
	GOTO	L__UART_RX47
L__UART_RX63:
	GOTO	L_UART_RX20
L__UART_RX48:
L__UART_RX47:
;tesECG.c,77 :: 		UART1_Write_Text("Band Pass Filter");
	MOV	#lo_addr(?lstr4_tesECG), W10
	CALL	_UART1_Write_Text
;tesECG.c,80 :: 		T2IE_bit = 1; i=0;
	BSET	T2IE_bit, BitPos(T2IE_bit+0)
	CLR	W0
	MOV	W0, _i
;tesECG.c,81 :: 		}
L_UART_RX20:
;tesECG.c,83 :: 		if((tmp == 's')||(tmp == 's'))
	MOV	#lo_addr(_tmp), W0
	MOV.B	[W0], W1
	MOV.B	#115, W0
	CP.B	W1, W0
	BRA NZ	L__UART_RX64
	GOTO	L__UART_RX50
L__UART_RX64:
	MOV	#lo_addr(_tmp), W0
	MOV.B	[W0], W1
	MOV.B	#115, W0
	CP.B	W1, W0
	BRA NZ	L__UART_RX65
	GOTO	L__UART_RX49
L__UART_RX65:
	GOTO	L_UART_RX23
L__UART_RX50:
L__UART_RX49:
;tesECG.c,85 :: 		UART1_Write_Text("Band Stop Filter");
	MOV	#lo_addr(?lstr5_tesECG), W10
	CALL	_UART1_Write_Text
;tesECG.c,88 :: 		T2IE_bit = 1; i=0;
	BSET	T2IE_bit, BitPos(T2IE_bit+0)
	CLR	W0
	MOV	W0, _i
;tesECG.c,89 :: 		}
L_UART_RX23:
;tesECG.c,91 :: 		if((tmp == 'x')||(tmp == 'X'))
	MOV	#lo_addr(_tmp), W0
	MOV.B	[W0], W1
	MOV.B	#120, W0
	CP.B	W1, W0
	BRA NZ	L__UART_RX66
	GOTO	L__UART_RX52
L__UART_RX66:
	MOV	#lo_addr(_tmp), W0
	MOV.B	[W0], W1
	MOV.B	#88, W0
	CP.B	W1, W0
	BRA NZ	L__UART_RX67
	GOTO	L__UART_RX51
L__UART_RX67:
	GOTO	L_UART_RX26
L__UART_RX52:
L__UART_RX51:
;tesECG.c,96 :: 		T2IE_bit = 0; i=0;
	BCLR	T2IE_bit, BitPos(T2IE_bit+0)
	CLR	W0
	MOV	W0, _i
;tesECG.c,97 :: 		}
L_UART_RX26:
;tesECG.c,100 :: 		U1RXIF_bit = 0;
	BCLR	U1RXIF_bit, BitPos(U1RXIF_bit+0)
;tesECG.c,101 :: 		}
L_end_UART_RX:
	POP	W10
	MOV	#26, W0
	REPEAT	#12
	POP	[W0--]
	POP	W0
	POP	RCOUNT
	POP	52
	RETFIE
; end of _UART_RX

_main:
	MOV	#2048, W15
	MOV	#6142, W0
	MOV	WREG, 32
	MOV	#1, W0
	MOV	WREG, 52
	MOV	#4, W0
	IOR	68

;tesECG.c,103 :: 		void main() {
;tesECG.c,104 :: 		ADC1_Init(); Delay_ms(100);
	PUSH	W10
	PUSH	W11
	PUSH	W12
	PUSH	W13
	CALL	_ADC1_Init
	MOV	#8, W8
	MOV	#32769, W7
L_main27:
	DEC	W7
	BRA NZ	L_main27
	DEC	W8
	BRA NZ	L_main27
	NOP
;tesECG.c,105 :: 		UART1_Init_Advanced(115200,_UART_8BIT_ODDPARITY,_UART_TWO_STOPBITS); Delay_ms(100);
	MOV	#1, W13
	MOV	#4, W12
	MOV	#49664, W10
	MOV	#1, W11
	CALL	_UART1_Init_Advanced
	MOV	#8, W8
	MOV	#32769, W7
L_main29:
	DEC	W7
	BRA NZ	L_main29
	DEC	W8
	BRA NZ	L_main29
	NOP
;tesECG.c,106 :: 		U1Modebits.ALTIO = 1; Delay_ms(100);
	BSET	U1MODEbits, #10
	MOV	#8, W8
	MOV	#32769, W7
L_main31:
	DEC	W7
	BRA NZ	L_main31
	DEC	W8
	BRA NZ	L_main31
	NOP
;tesECG.c,107 :: 		InitTimer2(); Delay_ms(100);
	CALL	_InitTimer2
	MOV	#8, W8
	MOV	#32769, W7
L_main33:
	DEC	W7
	BRA NZ	L_main33
	DEC	W8
	BRA NZ	L_main33
	NOP
;tesECG.c,108 :: 		U1RXIF_bit = 0;
	BCLR	U1RXIF_bit, BitPos(U1RXIF_bit+0)
;tesECG.c,109 :: 		U1RXIE_bit = 1;
	BSET	U1RXIE_bit, BitPos(U1RXIE_bit+0)
;tesECG.c,110 :: 		}
L_end_main:
	POP	W13
	POP	W12
	POP	W11
	POP	W10
L__main_end_loop:
	BRA	L__main_end_loop
; end of _main
