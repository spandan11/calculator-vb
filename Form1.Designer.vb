<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnback = New Button()
        txtDisplay = New TextBox()
        btnclear = New Button()
        btndivide = New Button()
        btnmultiply = New Button()
        btn9 = New Button()
        btn8 = New Button()
        btn7 = New Button()
        btnplus = New Button()
        btn6 = New Button()
        btn5 = New Button()
        btn4 = New Button()
        btnminus = New Button()
        btn3 = New Button()
        btn2 = New Button()
        btn1 = New Button()
        BtnEquals = New Button()
        btndot = New Button()
        btn0 = New Button()
        btn00 = New Button()
        SuspendLayout()
        ' 
        ' btnback
        ' 
        btnback.BackColor = Color.Orange
        btnback.FlatAppearance.BorderColor = Color.Orange
        btnback.FlatStyle = FlatStyle.Flat
        btnback.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point)
        btnback.ForeColor = SystemColors.ControlLightLight
        btnback.Location = New Point(21, 110)
        btnback.Name = "btnback"
        btnback.Size = New Size(121, 66)
        btnback.TabIndex = 0
        btnback.Text = "⌫"
        btnback.UseVisualStyleBackColor = False
        ' 
        ' txtDisplay
        ' 
        txtDisplay.BackColor = SystemColors.InactiveCaptionText
        txtDisplay.Font = New Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtDisplay.ForeColor = SystemColors.ControlLightLight
        txtDisplay.Location = New Point(21, 31)
        txtDisplay.Name = "txtDisplay"
        txtDisplay.Size = New Size(398, 50)
        txtDisplay.TabIndex = 2
        txtDisplay.TextAlign = HorizontalAlignment.Right
        ' 
        ' btnclear
        ' 
        btnclear.BackColor = Color.Orange
        btnclear.FlatAppearance.BorderColor = Color.Orange
        btnclear.FlatStyle = FlatStyle.Flat
        btnclear.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point)
        btnclear.ForeColor = SystemColors.ControlLightLight
        btnclear.Location = New Point(179, 110)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(131, 66)
        btnclear.TabIndex = 3
        btnclear.Text = "CE"
        btnclear.UseVisualStyleBackColor = False
        ' 
        ' btndivide
        ' 
        btndivide.BackColor = Color.Orange
        btndivide.FlatAppearance.BorderColor = Color.Orange
        btndivide.FlatStyle = FlatStyle.Flat
        btndivide.Font = New Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        btndivide.ForeColor = SystemColors.ControlLightLight
        btndivide.Location = New Point(340, 110)
        btndivide.Name = "btndivide"
        btndivide.Size = New Size(79, 66)
        btndivide.TabIndex = 5
        btndivide.Text = "/"
        btndivide.UseVisualStyleBackColor = False
        ' 
        ' btnmultiply
        ' 
        btnmultiply.BackColor = Color.Orange
        btnmultiply.FlatAppearance.BorderColor = Color.Orange
        btnmultiply.FlatStyle = FlatStyle.Flat
        btnmultiply.Font = New Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnmultiply.ForeColor = SystemColors.ControlLightLight
        btnmultiply.Location = New Point(340, 204)
        btnmultiply.Name = "btnmultiply"
        btnmultiply.Size = New Size(79, 66)
        btnmultiply.TabIndex = 9
        btnmultiply.Text = "*"
        btnmultiply.UseVisualStyleBackColor = False
        ' 
        ' btn9
        ' 
        btn9.BackColor = SystemColors.AppWorkspace
        btn9.FlatAppearance.BorderColor = SystemColors.AppWorkspace
        btn9.FlatStyle = FlatStyle.Flat
        btn9.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point)
        btn9.ForeColor = SystemColors.ControlLightLight
        btn9.Location = New Point(231, 204)
        btn9.Name = "btn9"
        btn9.Size = New Size(79, 66)
        btn9.TabIndex = 8
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = False
        ' 
        ' btn8
        ' 
        btn8.BackColor = SystemColors.AppWorkspace
        btn8.FlatAppearance.BorderColor = SystemColors.AppWorkspace
        btn8.FlatStyle = FlatStyle.Flat
        btn8.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point)
        btn8.ForeColor = SystemColors.ControlLightLight
        btn8.Location = New Point(125, 204)
        btn8.Name = "btn8"
        btn8.Size = New Size(79, 66)
        btn8.TabIndex = 7
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = False
        ' 
        ' btn7
        ' 
        btn7.BackColor = SystemColors.AppWorkspace
        btn7.FlatAppearance.BorderColor = SystemColors.AppWorkspace
        btn7.FlatStyle = FlatStyle.Flat
        btn7.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point)
        btn7.ForeColor = SystemColors.ControlLightLight
        btn7.Location = New Point(21, 204)
        btn7.Name = "btn7"
        btn7.Size = New Size(79, 66)
        btn7.TabIndex = 6
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = False
        ' 
        ' btnplus
        ' 
        btnplus.BackColor = Color.Orange
        btnplus.FlatAppearance.BorderColor = Color.Orange
        btnplus.FlatStyle = FlatStyle.Flat
        btnplus.Font = New Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnplus.ForeColor = SystemColors.ControlLightLight
        btnplus.Location = New Point(340, 296)
        btnplus.Name = "btnplus"
        btnplus.Size = New Size(79, 66)
        btnplus.TabIndex = 13
        btnplus.Text = "+"
        btnplus.UseVisualStyleBackColor = False
        ' 
        ' btn6
        ' 
        btn6.BackColor = SystemColors.AppWorkspace
        btn6.FlatAppearance.BorderColor = SystemColors.AppWorkspace
        btn6.FlatStyle = FlatStyle.Flat
        btn6.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point)
        btn6.ForeColor = SystemColors.ControlLightLight
        btn6.Location = New Point(231, 296)
        btn6.Name = "btn6"
        btn6.Size = New Size(79, 66)
        btn6.TabIndex = 12
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = False
        ' 
        ' btn5
        ' 
        btn5.BackColor = SystemColors.AppWorkspace
        btn5.FlatAppearance.BorderColor = SystemColors.AppWorkspace
        btn5.FlatStyle = FlatStyle.Flat
        btn5.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point)
        btn5.ForeColor = SystemColors.ControlLightLight
        btn5.Location = New Point(125, 296)
        btn5.Name = "btn5"
        btn5.Size = New Size(79, 66)
        btn5.TabIndex = 11
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = False
        ' 
        ' btn4
        ' 
        btn4.BackColor = SystemColors.AppWorkspace
        btn4.FlatAppearance.BorderColor = SystemColors.AppWorkspace
        btn4.FlatStyle = FlatStyle.Flat
        btn4.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point)
        btn4.ForeColor = SystemColors.ControlLightLight
        btn4.Location = New Point(21, 296)
        btn4.Name = "btn4"
        btn4.Size = New Size(79, 66)
        btn4.TabIndex = 10
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = False
        ' 
        ' btnminus
        ' 
        btnminus.BackColor = Color.Orange
        btnminus.FlatAppearance.BorderColor = Color.Orange
        btnminus.FlatStyle = FlatStyle.Flat
        btnminus.Font = New Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnminus.ForeColor = SystemColors.ControlLightLight
        btnminus.Location = New Point(340, 390)
        btnminus.Name = "btnminus"
        btnminus.Size = New Size(79, 66)
        btnminus.TabIndex = 17
        btnminus.Text = "-"
        btnminus.UseVisualStyleBackColor = False
        ' 
        ' btn3
        ' 
        btn3.BackColor = SystemColors.AppWorkspace
        btn3.FlatAppearance.BorderColor = SystemColors.AppWorkspace
        btn3.FlatStyle = FlatStyle.Flat
        btn3.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point)
        btn3.ForeColor = SystemColors.ControlLightLight
        btn3.Location = New Point(231, 390)
        btn3.Name = "btn3"
        btn3.Size = New Size(79, 66)
        btn3.TabIndex = 16
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = False
        ' 
        ' btn2
        ' 
        btn2.BackColor = SystemColors.AppWorkspace
        btn2.FlatAppearance.BorderColor = SystemColors.AppWorkspace
        btn2.FlatStyle = FlatStyle.Flat
        btn2.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point)
        btn2.ForeColor = SystemColors.ControlLightLight
        btn2.Location = New Point(125, 390)
        btn2.Name = "btn2"
        btn2.Size = New Size(79, 66)
        btn2.TabIndex = 15
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = False
        ' 
        ' btn1
        ' 
        btn1.BackColor = SystemColors.AppWorkspace
        btn1.FlatAppearance.BorderColor = SystemColors.AppWorkspace
        btn1.FlatStyle = FlatStyle.Flat
        btn1.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point)
        btn1.ForeColor = SystemColors.ControlLightLight
        btn1.Location = New Point(21, 390)
        btn1.Name = "btn1"
        btn1.Size = New Size(79, 66)
        btn1.TabIndex = 14
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = False
        ' 
        ' BtnEquals
        ' 
        BtnEquals.BackColor = Color.Orange
        BtnEquals.FlatAppearance.BorderColor = Color.Orange
        BtnEquals.FlatStyle = FlatStyle.Flat
        BtnEquals.Font = New Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        BtnEquals.ForeColor = SystemColors.ControlLightLight
        BtnEquals.Location = New Point(340, 481)
        BtnEquals.Name = "BtnEquals"
        BtnEquals.Size = New Size(79, 66)
        BtnEquals.TabIndex = 21
        BtnEquals.Text = "="
        BtnEquals.UseVisualStyleBackColor = False
        ' 
        ' btndot
        ' 
        btndot.BackColor = SystemColors.AppWorkspace
        btndot.FlatAppearance.BorderColor = SystemColors.AppWorkspace
        btndot.FlatStyle = FlatStyle.Flat
        btndot.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point)
        btndot.ForeColor = SystemColors.ControlLightLight
        btndot.Location = New Point(231, 481)
        btndot.Name = "btndot"
        btndot.Size = New Size(79, 66)
        btndot.TabIndex = 20
        btndot.Text = "."
        btndot.UseVisualStyleBackColor = False
        ' 
        ' btn0
        ' 
        btn0.BackColor = SystemColors.AppWorkspace
        btn0.FlatAppearance.BorderColor = SystemColors.AppWorkspace
        btn0.FlatStyle = FlatStyle.Flat
        btn0.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point)
        btn0.ForeColor = SystemColors.ControlLightLight
        btn0.Location = New Point(125, 481)
        btn0.Name = "btn0"
        btn0.Size = New Size(79, 66)
        btn0.TabIndex = 19
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = False
        ' 
        ' btn00
        ' 
        btn00.BackColor = SystemColors.AppWorkspace
        btn00.FlatAppearance.BorderColor = SystemColors.AppWorkspace
        btn00.FlatStyle = FlatStyle.Flat
        btn00.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point)
        btn00.ForeColor = SystemColors.ControlLightLight
        btn00.Location = New Point(21, 481)
        btn00.Name = "btn00"
        btn00.Size = New Size(79, 66)
        btn00.TabIndex = 18
        btn00.Text = "00"
        btn00.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(442, 566)
        Controls.Add(BtnEquals)
        Controls.Add(btndot)
        Controls.Add(btn0)
        Controls.Add(btn00)
        Controls.Add(btnminus)
        Controls.Add(btn3)
        Controls.Add(btn2)
        Controls.Add(btn1)
        Controls.Add(btnplus)
        Controls.Add(btn6)
        Controls.Add(btn5)
        Controls.Add(btn4)
        Controls.Add(btnmultiply)
        Controls.Add(btn9)
        Controls.Add(btn8)
        Controls.Add(btn7)
        Controls.Add(btndivide)
        Controls.Add(btnclear)
        Controls.Add(txtDisplay)
        Controls.Add(btnback)
        ForeColor = SystemColors.ControlLightLight
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnback As Button
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents btnclear As Button
    Friend WithEvents btndivide As Button
    Friend WithEvents btnmultiply As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btnplus As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btnminus As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents BtnEquals As Button
    Friend WithEvents btndot As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btn00 As Button
End Class
