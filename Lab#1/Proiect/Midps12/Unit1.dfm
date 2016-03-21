object Form1: TForm1
  Left = 263
  Top = 164
  Width = 372
  Height = 191
  Caption = 'MIDPS 1-B'
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
    Left = 64
    Top = 0
    Width = 289
    Height = 16
    Caption = 'Realizarea unui cronometru in C++ Builder'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clRed
    Font.Height = -13
    Font.Name = 'MS Sans Serif'
    Font.Style = [fsBold]
    ParentFont = False
  end
  object Label2: TLabel
    Left = 88
    Top = 56
    Width = 241
    Height = 24
    Caption = 'C++ Builder CRONOMETRU'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clRed
    Font.Height = -19
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
  end
  object Button1: TButton
    Left = 8
    Top = 48
    Width = 65
    Height = 25
    Caption = 'Start'
    TabOrder = 0
    OnClick = Button1Click
  end
  object Button2: TButton
    Left = 8
    Top = 72
    Width = 65
    Height = 25
    Caption = 'Stop'
    Enabled = False
    TabOrder = 1
    OnClick = Button2Click
  end
  object Button3: TButton
    Left = 8
    Top = 96
    Width = 65
    Height = 25
    Caption = 'Zero'
    Enabled = False
    TabOrder = 2
    OnClick = Button3Click
  end
  object Button4: TButton
    Left = 264
    Top = 120
    Width = 65
    Height = 25
    Caption = 'Exit'
    TabOrder = 3
    OnClick = Button4Click
  end
  object Edit1: TEdit
    Left = 200
    Top = 24
    Width = 113
    Height = 21
    TabOrder = 4
  end
  object Edit2: TEdit
    Left = 112
    Top = 88
    Width = 161
    Height = 21
    TabOrder = 5
    Text = '0 min 0 sec 0 zec'
  end
  object Timer1: TTimer
    OnTimer = Timer1Timer
  end
  object Timer2: TTimer
    Enabled = False
    Interval = 92
    OnTimer = Timer2Timer
    Top = 24
  end
end
