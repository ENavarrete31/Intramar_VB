<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInOC
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabCtrl = New System.Windows.Forms.TabControl()
        Me.Informacion = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DTPCorrect = New System.Windows.Forms.DateTimePicker()
        Me.CmBoxCadena = New System.Windows.Forms.ComboBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.OCErr = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DTPErr = New System.Windows.Forms.DateTimePicker()
        Me.CmBoxCadErr = New System.Windows.Forms.ComboBox()
        Me.BtnBuscErr = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnRpcs = New System.Windows.Forms.Button()
        Me.CheckBx = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCtrl.SuspendLayout()
        Me.Informacion.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.OCErr.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(800, 450)
        Me.DataGridView1.TabIndex = 0
        '
        'TabCtrl
        '
        Me.TabCtrl.Controls.Add(Me.Informacion)
        Me.TabCtrl.Controls.Add(Me.OCErr)
        Me.TabCtrl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabCtrl.Font = New System.Drawing.Font("OCR A Extended", 8.25!)
        Me.TabCtrl.Location = New System.Drawing.Point(0, 0)
        Me.TabCtrl.Name = "TabCtrl"
        Me.TabCtrl.SelectedIndex = 0
        Me.TabCtrl.Size = New System.Drawing.Size(800, 450)
        Me.TabCtrl.TabIndex = 1
        '
        'Informacion
        '
        Me.Informacion.Controls.Add(Me.Panel2)
        Me.Informacion.Controls.Add(Me.Panel1)
        Me.Informacion.Location = New System.Drawing.Point(4, 21)
        Me.Informacion.Name = "Informacion"
        Me.Informacion.Padding = New System.Windows.Forms.Padding(3)
        Me.Informacion.Size = New System.Drawing.Size(792, 425)
        Me.Informacion.TabIndex = 0
        Me.Informacion.Text = "Procesadas"
        Me.Informacion.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridView2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(786, 214)
        Me.Panel2.TabIndex = 1
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(786, 214)
        Me.DataGridView2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DTPCorrect)
        Me.Panel1.Controls.Add(Me.CmBoxCadena)
        Me.Panel1.Controls.Add(Me.BtnBuscar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(786, 53)
        Me.Panel1.TabIndex = 0
        '
        'DTPCorrect
        '
        Me.DTPCorrect.CustomFormat = "yyyy-MM-dd"
        Me.DTPCorrect.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPCorrect.Location = New System.Drawing.Point(198, 15)
        Me.DTPCorrect.Name = "DTPCorrect"
        Me.DTPCorrect.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DTPCorrect.Size = New System.Drawing.Size(200, 19)
        Me.DTPCorrect.TabIndex = 2
        Me.DTPCorrect.Value = New Date(2020, 3, 11, 16, 21, 0, 0)
        '
        'CmBoxCadena
        '
        Me.CmBoxCadena.FormattingEnabled = True
        Me.CmBoxCadena.Location = New System.Drawing.Point(21, 15)
        Me.CmBoxCadena.Name = "CmBoxCadena"
        Me.CmBoxCadena.Size = New System.Drawing.Size(161, 20)
        Me.CmBoxCadena.TabIndex = 1
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(404, 13)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(105, 23)
        Me.BtnBuscar.TabIndex = 0
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'OCErr
        '
        Me.OCErr.Controls.Add(Me.Panel4)
        Me.OCErr.Controls.Add(Me.Panel3)
        Me.OCErr.Controls.Add(Me.BtnDelete)
        Me.OCErr.Controls.Add(Me.BtnRpcs)
        Me.OCErr.Location = New System.Drawing.Point(4, 21)
        Me.OCErr.Name = "OCErr"
        Me.OCErr.Padding = New System.Windows.Forms.Padding(3)
        Me.OCErr.Size = New System.Drawing.Size(792, 425)
        Me.OCErr.TabIndex = 1
        Me.OCErr.Text = "Error"
        Me.OCErr.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.DataGridView3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 54)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(786, 213)
        Me.Panel4.TabIndex = 4
        '
        'DataGridView3
        '
        Me.DataGridView3.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CheckBx})
        Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView3.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(786, 213)
        Me.DataGridView3.TabIndex = 0
        Me.DataGridView3.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DTPErr)
        Me.Panel3.Controls.Add(Me.CmBoxCadErr)
        Me.Panel3.Controls.Add(Me.BtnBuscErr)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(786, 51)
        Me.Panel3.TabIndex = 3
        '
        'DTPErr
        '
        Me.DTPErr.CustomFormat = "yyyy-MM-dd"
        Me.DTPErr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPErr.Location = New System.Drawing.Point(195, 15)
        Me.DTPErr.Name = "DTPErr"
        Me.DTPErr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DTPErr.Size = New System.Drawing.Size(200, 19)
        Me.DTPErr.TabIndex = 4
        Me.DTPErr.Value = New Date(2020, 3, 11, 16, 21, 0, 0)
        '
        'CmBoxCadErr
        '
        Me.CmBoxCadErr.FormattingEnabled = True
        Me.CmBoxCadErr.Location = New System.Drawing.Point(19, 14)
        Me.CmBoxCadErr.Name = "CmBoxCadErr"
        Me.CmBoxCadErr.Size = New System.Drawing.Size(161, 20)
        Me.CmBoxCadErr.TabIndex = 3
        '
        'BtnBuscErr
        '
        Me.BtnBuscErr.Location = New System.Drawing.Point(401, 14)
        Me.BtnBuscErr.Name = "BtnBuscErr"
        Me.BtnBuscErr.Size = New System.Drawing.Size(105, 23)
        Me.BtnBuscErr.TabIndex = 2
        Me.BtnBuscErr.Text = "Buscar"
        Me.BtnBuscErr.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(8, 319)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(100, 31)
        Me.BtnDelete.TabIndex = 2
        Me.BtnDelete.Text = "Eliminar"
        Me.BtnDelete.UseVisualStyleBackColor = True
        Me.BtnDelete.Visible = False
        '
        'BtnRpcs
        '
        Me.BtnRpcs.Location = New System.Drawing.Point(8, 284)
        Me.BtnRpcs.Name = "BtnRpcs"
        Me.BtnRpcs.Size = New System.Drawing.Size(100, 29)
        Me.BtnRpcs.TabIndex = 1
        Me.BtnRpcs.Text = "Reprocesar"
        Me.BtnRpcs.UseVisualStyleBackColor = True
        Me.BtnRpcs.Visible = False
        '
        'CheckBx
        '
        Me.CheckBx.HeaderText = "Selección"
        Me.CheckBx.Name = "CheckBx"
        '
        'FormInOC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabCtrl)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FormInOC"
        Me.Text = "Ingreso OC"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCtrl.ResumeLayout(False)
        Me.Informacion.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.OCErr.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TabCtrl As TabControl
    Friend WithEvents Informacion As TabPage
    Friend WithEvents OCErr As TabPage
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnRpcs As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CmBoxCadena As ComboBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CmBoxCadErr As ComboBox
    Friend WithEvents BtnBuscErr As Button
    Friend WithEvents DTPCorrect As DateTimePicker
    Friend WithEvents DTPErr As DateTimePicker
    Friend WithEvents CheckBx As DataGridViewCheckBoxColumn
End Class
