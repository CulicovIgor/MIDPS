object Form1: TForm1
  Left = 349
  Top = 167
  Width = 341
  Height = 202
  Caption = 'MIDPS 1- A'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 56
    Top = 24
    Width = 251
    Height = 20
    Caption = 'Incrementare decrementare contor.'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clRed
    Font.Height = -16
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
  end
  object Label2: TLabel
    Left = 160
    Top = 56
    Width = 3
    Height = 13
  end
  object Button1: TButton
    Left = 48
    Top = 64
    Width = 73
    Height = 25
    Caption = 'Up'
    TabOrder = 0
    OnClick = Button1Click
  end
  object Button2: TButton
    Left = 48
    Top = 104
    Width = 73
    Height = 25
    Caption = 'Down'
    TabOrder = 1
    OnClick = Button2Click
  end
  object Edit1: TEdit
    Left = 184
    Top = 88
    Width = 65
    Height = 21
    TabOrder = 2
  end
  object Button3: TButton
    Left = 232
    Top = 128
    Width = 81
    Height = 25
    Caption = 'Exit'
    TabOrder = 3
    OnClick = Button3Click
  end
end
