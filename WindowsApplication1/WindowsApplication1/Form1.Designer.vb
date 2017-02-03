<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbxNum = New System.Windows.Forms.ComboBox()
        Me.lbllado1 = New System.Windows.Forms.Label()
        Me.lbllado2 = New System.Windows.Forms.Label()
        Me.txtLado = New System.Windows.Forms.TextBox()
        Me.txtLado2 = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione la figura a calcular."
        '
        'CbxNum
        '
        Me.CbxNum.FormattingEnabled = True
        Me.CbxNum.Items.AddRange(New Object() {"Cuadrado", "Rectangulo", "Triangulo", "Paralelogramo"})
        Me.CbxNum.Location = New System.Drawing.Point(147, 75)
        Me.CbxNum.Name = "CbxNum"
        Me.CbxNum.Size = New System.Drawing.Size(121, 24)
        Me.CbxNum.TabIndex = 1
        '
        'lbllado1
        '
        Me.lbllado1.AccessibleRole = System.Windows.Forms.AccessibleRole.Indicator
        Me.lbllado1.AutoSize = True
        Me.lbllado1.Location = New System.Drawing.Point(97, 134)
        Me.lbllado1.Name = "lbllado1"
        Me.lbllado1.Size = New System.Drawing.Size(51, 17)
        Me.lbllado1.TabIndex = 2
        Me.lbllado1.Text = "Label2"
        Me.lbllado1.Visible = False
        '
        'lbllado2
        '
        Me.lbllado2.AutoSize = True
        Me.lbllado2.Location = New System.Drawing.Point(262, 133)
        Me.lbllado2.Name = "lbllado2"
        Me.lbllado2.Size = New System.Drawing.Size(51, 17)
        Me.lbllado2.TabIndex = 3
        Me.lbllado2.Text = "Label2"
        Me.lbllado2.Visible = False
        '
        'txtLado
        '
        Me.txtLado.Location = New System.Drawing.Point(73, 163)
        Me.txtLado.Name = "txtLado"
        Me.txtLado.Size = New System.Drawing.Size(100, 22)
        Me.txtLado.TabIndex = 4
        Me.txtLado.Visible = False
        '
        'txtLado2
        '
        Me.txtLado2.Location = New System.Drawing.Point(245, 163)
        Me.txtLado2.Name = "txtLado2"
        Me.txtLado2.Size = New System.Drawing.Size(100, 22)
        Me.txtLado2.TabIndex = 5
        Me.txtLado2.Visible = False
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(170, 214)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 6
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(73, 273)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(279, 22)
        Me.txtResultado.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 413)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtLado2)
        Me.Controls.Add(Me.txtLado)
        Me.Controls.Add(Me.lbllado2)
        Me.Controls.Add(Me.lbllado1)
        Me.Controls.Add(Me.CbxNum)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CbxNum As ComboBox
    Friend WithEvents lbllado1 As Label
    Friend WithEvents lbllado2 As Label
    Friend WithEvents txtLado As TextBox
    Friend WithEvents txtLado2 As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtResultado As TextBox
End Class
