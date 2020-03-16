<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbt_FechaFin = New System.Windows.Forms.RadioButton()
        Me.rbt_FechaAct = New System.Windows.Forms.RadioButton()
        Me.btn_Calcular = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_ValorCuo = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbt_ReglaAme = New System.Windows.Forms.RadioButton()
        Me.rbt_ReglaCom = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbt_InteresComp = New System.Windows.Forms.RadioButton()
        Me.rbt_InteresSim = New System.Windows.Forms.RadioButton()
        Me.txt_Capital = New System.Windows.Forms.TextBox()
        Me.txt_Tiempo = New System.Windows.Forms.TextBox()
        Me.txt_Interes = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbt_FechaFin)
        Me.GroupBox1.Controls.Add(Me.rbt_FechaAct)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 63)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fecha Focal:"
        '
        'rbt_FechaFin
        '
        Me.rbt_FechaFin.AutoSize = True
        Me.rbt_FechaFin.Location = New System.Drawing.Point(130, 28)
        Me.rbt_FechaFin.Name = "rbt_FechaFin"
        Me.rbt_FechaFin.Size = New System.Drawing.Size(80, 17)
        Me.rbt_FechaFin.TabIndex = 1
        Me.rbt_FechaFin.TabStop = True
        Me.rbt_FechaFin.Text = "Fecha Final"
        Me.rbt_FechaFin.UseVisualStyleBackColor = True
        '
        'rbt_FechaAct
        '
        Me.rbt_FechaAct.AutoSize = True
        Me.rbt_FechaAct.Location = New System.Drawing.Point(6, 28)
        Me.rbt_FechaAct.Name = "rbt_FechaAct"
        Me.rbt_FechaAct.Size = New System.Drawing.Size(88, 17)
        Me.rbt_FechaAct.TabIndex = 0
        Me.rbt_FechaAct.TabStop = True
        Me.rbt_FechaAct.Text = "Fecha Actual"
        Me.rbt_FechaAct.UseVisualStyleBackColor = True
        '
        'btn_Calcular
        '
        Me.btn_Calcular.Location = New System.Drawing.Point(257, 231)
        Me.btn_Calcular.Name = "btn_Calcular"
        Me.btn_Calcular.Size = New System.Drawing.Size(75, 23)
        Me.btn_Calcular.TabIndex = 25
        Me.btn_Calcular.Text = "Calcular"
        Me.btn_Calcular.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(186, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Valor Cuota:"
        '
        'lbl_ValorCuo
        '
        Me.lbl_ValorCuo.AutoSize = True
        Me.lbl_ValorCuo.Location = New System.Drawing.Point(282, 195)
        Me.lbl_ValorCuo.Name = "lbl_ValorCuo"
        Me.lbl_ValorCuo.Size = New System.Drawing.Size(0, 13)
        Me.lbl_ValorCuo.TabIndex = 29
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbt_ReglaAme)
        Me.GroupBox2.Controls.Add(Me.rbt_ReglaCom)
        Me.GroupBox2.Location = New System.Drawing.Point(279, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(271, 63)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Regla:"
        '
        'rbt_ReglaAme
        '
        Me.rbt_ReglaAme.AutoSize = True
        Me.rbt_ReglaAme.Location = New System.Drawing.Point(139, 20)
        Me.rbt_ReglaAme.Name = "rbt_ReglaAme"
        Me.rbt_ReglaAme.Size = New System.Drawing.Size(106, 17)
        Me.rbt_ReglaAme.TabIndex = 1
        Me.rbt_ReglaAme.TabStop = True
        Me.rbt_ReglaAme.Text = "Regla Americana"
        Me.rbt_ReglaAme.UseVisualStyleBackColor = True
        '
        'rbt_ReglaCom
        '
        Me.rbt_ReglaCom.AutoSize = True
        Me.rbt_ReglaCom.Location = New System.Drawing.Point(7, 20)
        Me.rbt_ReglaCom.Name = "rbt_ReglaCom"
        Me.rbt_ReglaCom.Size = New System.Drawing.Size(102, 17)
        Me.rbt_ReglaCom.TabIndex = 0
        Me.rbt_ReglaCom.TabStop = True
        Me.rbt_ReglaCom.Text = "Regla Comercial"
        Me.rbt_ReglaCom.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbt_InteresComp)
        Me.GroupBox3.Controls.Add(Me.rbt_InteresSim)
        Me.GroupBox3.Location = New System.Drawing.Point(279, 104)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(271, 63)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo de Interes"
        '
        'rbt_InteresComp
        '
        Me.rbt_InteresComp.AutoSize = True
        Me.rbt_InteresComp.Location = New System.Drawing.Point(139, 26)
        Me.rbt_InteresComp.Name = "rbt_InteresComp"
        Me.rbt_InteresComp.Size = New System.Drawing.Size(78, 17)
        Me.rbt_InteresComp.TabIndex = 1
        Me.rbt_InteresComp.TabStop = True
        Me.rbt_InteresComp.Text = "Compuesto"
        Me.rbt_InteresComp.UseVisualStyleBackColor = True
        '
        'rbt_InteresSim
        '
        Me.rbt_InteresSim.AutoSize = True
        Me.rbt_InteresSim.Location = New System.Drawing.Point(6, 26)
        Me.rbt_InteresSim.Name = "rbt_InteresSim"
        Me.rbt_InteresSim.Size = New System.Drawing.Size(56, 17)
        Me.rbt_InteresSim.TabIndex = 0
        Me.rbt_InteresSim.TabStop = True
        Me.rbt_InteresSim.Text = "Simple"
        Me.rbt_InteresSim.UseVisualStyleBackColor = True
        '
        'txt_Capital
        '
        Me.txt_Capital.Location = New System.Drawing.Point(85, 17)
        Me.txt_Capital.Name = "txt_Capital"
        Me.txt_Capital.Size = New System.Drawing.Size(160, 20)
        Me.txt_Capital.TabIndex = 32
        '
        'txt_Tiempo
        '
        Me.txt_Tiempo.Location = New System.Drawing.Point(85, 43)
        Me.txt_Tiempo.Name = "txt_Tiempo"
        Me.txt_Tiempo.Size = New System.Drawing.Size(160, 20)
        Me.txt_Tiempo.TabIndex = 33
        '
        'txt_Interes
        '
        Me.txt_Interes.Location = New System.Drawing.Point(85, 75)
        Me.txt_Interes.Name = "txt_Interes"
        Me.txt_Interes.Size = New System.Drawing.Size(160, 20)
        Me.txt_Interes.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Capital:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Tiempo (M):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Interes (M):"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 273)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_Interes)
        Me.Controls.Add(Me.txt_Tiempo)
        Me.Controls.Add(Me.txt_Capital)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lbl_ValorCuo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_Calcular)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Ecuaciones Equivalentes Y Pagos Parciales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbt_FechaFin As RadioButton
    Friend WithEvents rbt_FechaAct As RadioButton
    Friend WithEvents btn_Calcular As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_ValorCuo As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbt_ReglaAme As RadioButton
    Friend WithEvents rbt_ReglaCom As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rbt_InteresComp As RadioButton
    Friend WithEvents rbt_InteresSim As RadioButton
    Friend WithEvents txt_Capital As TextBox
    Friend WithEvents txt_Tiempo As TextBox
    Friend WithEvents txt_Interes As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
End Class
