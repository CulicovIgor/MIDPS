//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
#include "dos.h"
#include <stdio.h>
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
struct date d;
struct time t;
int y,yprev,x = 0;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button3Click(TObject *Sender)
{
Close();
}
//---------------------------------------------------------------------------


void __fastcall TForm1::Button1Click(TObject *Sender)
{
x = 0;
Timer2->Enabled = true;
Button1->Enabled = false;
Button2->Enabled = true;
Form1->Repaint();
for (int i = 0; i < 201; i+=10){
PaintBox1->Canvas->MoveTo(i,0);
PaintBox1->Canvas->LineTo(i,201);
}
for (int i = 0; i < 201; i+=10){
PaintBox1->Canvas->MoveTo(0,i);
PaintBox1->Canvas->LineTo(201,i);
}
PaintBox1->Canvas->MoveTo(0,100);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button2Click(TObject *Sender)
{
Timer2->Enabled = false;
Button1->Enabled = true;
Button2->Enabled = false;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Timer1Timer(TObject *Sender)
{
char buf[20];
getdate(&d);
gettime(&t);
sprintf(buf,"%02d-%02d-%4d   %02d:%02d:%02d",d.da_day,d.da_mon,d.da_year,
t.ti_hour,t.ti_min,t.ti_sec);
Edit1->Text=(AnsiString)buf;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Timer2Timer(TObject *Sender)
{
randomize();
yprev = y;
y = random(51)+1;
x+=1;
if(x >= 201){
Form1->Repaint();
for (int i = 0; i < 201; i+=10){
PaintBox1->Canvas->MoveTo(i,0);
PaintBox1->Canvas->LineTo(i,201);
}
for (int i = 0; i < 201; i+=10){
PaintBox1->Canvas->MoveTo(0,i);
PaintBox1->Canvas->LineTo(201,i);
}
PaintBox1->Canvas->MoveTo(0,yprev);
x=0;
}
PaintBox1->Canvas->Pen->Color = clRed;
PaintBox1->Canvas->LineTo(x,y+50);
PaintBox1->Canvas->Pen->Color = clBlack;
Panel1->Height = 50+y;
Panel2->Top = Panel1->Top + Panel1->Height;
Panel2->Height = 200 - Panel1->Height;
}
//---------------------------------------------------------------------------


