<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtOp1 = New System.Windows.Forms.TextBox()
        Me.txtOp2 = New System.Windows.Forms.TextBox()
        Me.txtOp3 = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.BtnFun141 = New System.Windows.Forms.Button()
        Me.BtnFun142 = New System.Windows.Forms.Button()
        Me.BtnFun143 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtOp1
        '
        Me.txtOp1.Location = New System.Drawing.Point(109, 32)
        Me.txtOp1.Name = "txtOp1"
        Me.txtOp1.Size = New System.Drawing.Size(155, 22)
        Me.txtOp1.TabIndex = 0
        Me.txtOp1.Text = "0"
        '
        'txtOp2
        '
        Me.txtOp2.Location = New System.Drawing.Point(109, 80)
        Me.txtOp2.Name = "txtOp2"
        Me.txtOp2.Size = New System.Drawing.Size(155, 22)
        Me.txtOp2.TabIndex = 1
        Me.txtOp2.Text = "0"
        '
        'txtOp3
        '
        Me.txtOp3.Location = New System.Drawing.Point(109, 133)
        Me.txtOp3.Name = "txtOp3"
        Me.txtOp3.Size = New System.Drawing.Size(155, 22)
        Me.txtOp3.TabIndex = 2
        Me.txtOp3.Text = "0"
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(109, 189)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(155, 22)
        Me.txtResult.TabIndex = 3
        '
        'BtnFun141
        '
        Me.BtnFun141.Location = New System.Drawing.Point(323, 61)
        Me.BtnFun141.Name = "BtnFun141"
        Me.BtnFun141.Size = New System.Drawing.Size(179, 23)
        Me.BtnFun141.TabIndex = 4
        Me.BtnFun141.Text = "Fun141 Late Binding"
        Me.BtnFun141.UseVisualStyleBackColor = True
        '
        'BtnFun142
        '
        Me.BtnFun142.Location = New System.Drawing.Point(323, 113)
        Me.BtnFun142.Name = "BtnFun142"
        Me.BtnFun142.Size = New System.Drawing.Size(179, 23)
        Me.BtnFun142.TabIndex = 5
        Me.BtnFun142.Text = "Fun142 Prog ID"
        Me.BtnFun142.UseVisualStyleBackColor = True
        '
        'BtnFun143
        '
        Me.BtnFun143.Location = New System.Drawing.Point(323, 163)
        Me.BtnFun143.Name = "BtnFun143"
        Me.BtnFun143.Size = New System.Drawing.Size(179, 23)
        Me.BtnFun143.TabIndex = 6
        Me.BtnFun143.Text = "Fun143 VTBL"
        Me.BtnFun143.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Arg1: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Arg2: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Arg3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Result"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 277)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnFun143)
        Me.Controls.Add(Me.BtnFun142)
        Me.Controls.Add(Me.BtnFun141)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtOp3)
        Me.Controls.Add(Me.txtOp2)
        Me.Controls.Add(Me.txtOp1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOp1 As TextBox
    Friend WithEvents txtOp2 As TextBox
    Friend WithEvents txtOp3 As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents BtnFun141 As Button
    Friend WithEvents BtnFun142 As Button
    Friend WithEvents BtnFun143 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
