<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_calculadora
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_calculadora = New System.Windows.Forms.Label()
        Me.lbl_Num1 = New System.Windows.Forms.Label()
        Me.lbl_num2 = New System.Windows.Forms.Label()
        Me.lbl_resultado = New System.Windows.Forms.Label()
        Me.txt_num1 = New System.Windows.Forms.TextBox()
        Me.txt_num2 = New System.Windows.Forms.TextBox()
        Me.txt_resultado = New System.Windows.Forms.TextBox()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.btn_restar = New System.Windows.Forms.Button()
        Me.btn_sumar = New System.Windows.Forms.Button()
        Me.btn_multiplicar = New System.Windows.Forms.Button()
        Me.btn_dividir = New System.Windows.Forms.Button()
        Me.txt_operador = New System.Windows.Forms.TextBox()
        Me.cbx_operador = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txt_calculadora
        '
        Me.txt_calculadora.AutoSize = True
        Me.txt_calculadora.Location = New System.Drawing.Point(192, 9)
        Me.txt_calculadora.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.txt_calculadora.Name = "txt_calculadora"
        Me.txt_calculadora.Size = New System.Drawing.Size(98, 18)
        Me.txt_calculadora.TabIndex = 0
        Me.txt_calculadora.Text = "Calculadora"
        '
        'lbl_Num1
        '
        Me.lbl_Num1.AutoSize = True
        Me.lbl_Num1.Location = New System.Drawing.Point(123, 53)
        Me.lbl_Num1.Name = "lbl_Num1"
        Me.lbl_Num1.Size = New System.Drawing.Size(52, 18)
        Me.lbl_Num1.TabIndex = 1
        Me.lbl_Num1.Text = "Num1"
        '
        'lbl_num2
        '
        Me.lbl_num2.AutoSize = True
        Me.lbl_num2.Location = New System.Drawing.Point(123, 89)
        Me.lbl_num2.Name = "lbl_num2"
        Me.lbl_num2.Size = New System.Drawing.Size(52, 18)
        Me.lbl_num2.TabIndex = 2
        Me.lbl_num2.Text = "Num2"
        '
        'lbl_resultado
        '
        Me.lbl_resultado.AutoSize = True
        Me.lbl_resultado.Location = New System.Drawing.Point(105, 121)
        Me.lbl_resultado.Name = "lbl_resultado"
        Me.lbl_resultado.Size = New System.Drawing.Size(84, 18)
        Me.lbl_resultado.TabIndex = 3
        Me.lbl_resultado.Text = "Resultado"
        '
        'txt_num1
        '
        Me.txt_num1.Location = New System.Drawing.Point(195, 53)
        Me.txt_num1.Name = "txt_num1"
        Me.txt_num1.Size = New System.Drawing.Size(198, 24)
        Me.txt_num1.TabIndex = 4
        '
        'txt_num2
        '
        Me.txt_num2.Location = New System.Drawing.Point(195, 89)
        Me.txt_num2.Name = "txt_num2"
        Me.txt_num2.Size = New System.Drawing.Size(198, 24)
        Me.txt_num2.TabIndex = 5
        '
        'txt_resultado
        '
        Me.txt_resultado.Location = New System.Drawing.Point(195, 121)
        Me.txt_resultado.Name = "txt_resultado"
        Me.txt_resultado.Size = New System.Drawing.Size(198, 24)
        Me.txt_resultado.TabIndex = 6
        '
        'btn_calcular
        '
        Me.btn_calcular.Location = New System.Drawing.Point(390, 170)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(102, 42)
        Me.btn_calcular.TabIndex = 7
        Me.btn_calcular.Text = "Calcular"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'btn_restar
        '
        Me.btn_restar.Location = New System.Drawing.Point(87, 175)
        Me.btn_restar.Name = "btn_restar"
        Me.btn_restar.Size = New System.Drawing.Size(58, 32)
        Me.btn_restar.TabIndex = 8
        Me.btn_restar.Text = "-"
        Me.btn_restar.UseVisualStyleBackColor = True
        '
        'btn_sumar
        '
        Me.btn_sumar.Location = New System.Drawing.Point(152, 175)
        Me.btn_sumar.Name = "btn_sumar"
        Me.btn_sumar.Size = New System.Drawing.Size(64, 32)
        Me.btn_sumar.TabIndex = 9
        Me.btn_sumar.Text = "+"
        Me.btn_sumar.UseVisualStyleBackColor = True
        '
        'btn_multiplicar
        '
        Me.btn_multiplicar.Location = New System.Drawing.Point(222, 175)
        Me.btn_multiplicar.Name = "btn_multiplicar"
        Me.btn_multiplicar.Size = New System.Drawing.Size(68, 32)
        Me.btn_multiplicar.TabIndex = 10
        Me.btn_multiplicar.Text = "*"
        Me.btn_multiplicar.UseVisualStyleBackColor = True
        '
        'btn_dividir
        '
        Me.btn_dividir.Location = New System.Drawing.Point(296, 175)
        Me.btn_dividir.Name = "btn_dividir"
        Me.btn_dividir.Size = New System.Drawing.Size(72, 32)
        Me.btn_dividir.TabIndex = 11
        Me.btn_dividir.Text = "/"
        Me.btn_dividir.UseVisualStyleBackColor = True
        '
        'txt_operador
        '
        Me.txt_operador.Location = New System.Drawing.Point(427, 89)
        Me.txt_operador.Name = "txt_operador"
        Me.txt_operador.Size = New System.Drawing.Size(65, 24)
        Me.txt_operador.TabIndex = 12
        '
        'cbx_operador
        '
        Me.cbx_operador.FormattingEnabled = True
        Me.cbx_operador.Items.AddRange(New Object() {"+", "-", "*", "/"})
        Me.cbx_operador.Location = New System.Drawing.Point(12, 89)
        Me.cbx_operador.Name = "cbx_operador"
        Me.cbx_operador.Size = New System.Drawing.Size(105, 26)
        Me.cbx_operador.TabIndex = 13
        '
        'frm_calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 300)
        Me.Controls.Add(Me.cbx_operador)
        Me.Controls.Add(Me.txt_operador)
        Me.Controls.Add(Me.btn_dividir)
        Me.Controls.Add(Me.btn_multiplicar)
        Me.Controls.Add(Me.btn_sumar)
        Me.Controls.Add(Me.btn_restar)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.txt_resultado)
        Me.Controls.Add(Me.txt_num2)
        Me.Controls.Add(Me.txt_num1)
        Me.Controls.Add(Me.lbl_resultado)
        Me.Controls.Add(Me.lbl_num2)
        Me.Controls.Add(Me.lbl_Num1)
        Me.Controls.Add(Me.txt_calculadora)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frm_calculadora"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_calculadora As System.Windows.Forms.Label
    Friend WithEvents lbl_Num1 As System.Windows.Forms.Label
    Friend WithEvents lbl_num2 As System.Windows.Forms.Label
    Friend WithEvents lbl_resultado As System.Windows.Forms.Label
    Friend WithEvents txt_num1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_num2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_resultado As System.Windows.Forms.TextBox
    Friend WithEvents btn_calcular As System.Windows.Forms.Button
    Friend WithEvents btn_restar As System.Windows.Forms.Button
    Friend WithEvents btn_sumar As System.Windows.Forms.Button
    Friend WithEvents btn_multiplicar As System.Windows.Forms.Button
    Friend WithEvents btn_dividir As System.Windows.Forms.Button
    Friend WithEvents txt_operador As System.Windows.Forms.TextBox
    Friend WithEvents cbx_operador As System.Windows.Forms.ComboBox

End Class
