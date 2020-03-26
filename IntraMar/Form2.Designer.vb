<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.BtnEmpl = New FontAwesome.Sharp.IconButton()
        Me.BtnAdm = New FontAwesome.Sharp.IconButton()
        Me.BtnLogis = New FontAwesome.Sharp.IconButton()
        Me.BtnServ = New FontAwesome.Sharp.IconButton()
        Me.BtnOpr = New FontAwesome.Sharp.IconButton()
        Me.BtnVtas = New FontAwesome.Sharp.IconButton()
        Me.BtnProd = New FontAwesome.Sharp.IconButton()
        Me.BtnOC = New FontAwesome.Sharp.IconButton()
        Me.ImgHome = New System.Windows.Forms.PictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.PanelMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.BtnEmpl)
        Me.PanelMenu.Controls.Add(Me.BtnAdm)
        Me.PanelMenu.Controls.Add(Me.BtnLogis)
        Me.PanelMenu.Controls.Add(Me.BtnServ)
        Me.PanelMenu.Controls.Add(Me.BtnOpr)
        Me.PanelMenu.Controls.Add(Me.BtnVtas)
        Me.PanelMenu.Controls.Add(Me.BtnProd)
        Me.PanelMenu.Controls.Add(Me.BtnOC)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(190, 501)
        Me.PanelMenu.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.ImgHome)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(190, 122)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(189, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(612, 110)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblFormTitle)
        Me.Panel3.Controls.Add(Me.IconCurrentForm)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel3.Location = New System.Drawing.Point(190, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(610, 50)
        Me.Panel3.TabIndex = 1
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.Location = New System.Drawing.Point(39, 18)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(74, 17)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Inicio"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IconCurrentForm.Location = New System.Drawing.Point(4, 8)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(32, 32)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'BtnEmpl
        '
        Me.BtnEmpl.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.BtnEmpl.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnEmpl.FlatAppearance.BorderSize = 0
        Me.BtnEmpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmpl.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnEmpl.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmpl.ForeColor = System.Drawing.Color.Black
        Me.BtnEmpl.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.BtnEmpl.IconColor = System.Drawing.Color.Black
        Me.BtnEmpl.IconSize = 32
        Me.BtnEmpl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEmpl.Location = New System.Drawing.Point(0, 437)
        Me.BtnEmpl.Name = "BtnEmpl"
        Me.BtnEmpl.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BtnEmpl.Rotation = 0R
        Me.BtnEmpl.Size = New System.Drawing.Size(190, 45)
        Me.BtnEmpl.TabIndex = 9
        Me.BtnEmpl.Text = "Empleados"
        Me.BtnEmpl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEmpl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEmpl.UseVisualStyleBackColor = False
        '
        'BtnAdm
        '
        Me.BtnAdm.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAdm.FlatAppearance.BorderSize = 0
        Me.BtnAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdm.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnAdm.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdm.ForeColor = System.Drawing.Color.Black
        Me.BtnAdm.IconChar = FontAwesome.Sharp.IconChar.UserCog
        Me.BtnAdm.IconColor = System.Drawing.Color.Black
        Me.BtnAdm.IconSize = 32
        Me.BtnAdm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdm.Location = New System.Drawing.Point(0, 392)
        Me.BtnAdm.Name = "BtnAdm"
        Me.BtnAdm.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BtnAdm.Rotation = 0R
        Me.BtnAdm.Size = New System.Drawing.Size(190, 45)
        Me.BtnAdm.TabIndex = 8
        Me.BtnAdm.Text = "Administración"
        Me.BtnAdm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAdm.UseVisualStyleBackColor = True
        '
        'BtnLogis
        '
        Me.BtnLogis.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnLogis.FlatAppearance.BorderSize = 0
        Me.BtnLogis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogis.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnLogis.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogis.ForeColor = System.Drawing.Color.Black
        Me.BtnLogis.IconChar = FontAwesome.Sharp.IconChar.Pallet
        Me.BtnLogis.IconColor = System.Drawing.Color.Black
        Me.BtnLogis.IconSize = 32
        Me.BtnLogis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLogis.Location = New System.Drawing.Point(0, 347)
        Me.BtnLogis.Name = "BtnLogis"
        Me.BtnLogis.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BtnLogis.Rotation = 0R
        Me.BtnLogis.Size = New System.Drawing.Size(190, 45)
        Me.BtnLogis.TabIndex = 7
        Me.BtnLogis.Text = "Logistica"
        Me.BtnLogis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLogis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLogis.UseVisualStyleBackColor = True
        '
        'BtnServ
        '
        Me.BtnServ.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnServ.FlatAppearance.BorderSize = 0
        Me.BtnServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnServ.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnServ.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnServ.ForeColor = System.Drawing.Color.Black
        Me.BtnServ.IconChar = FontAwesome.Sharp.IconChar.Cogs
        Me.BtnServ.IconColor = System.Drawing.Color.Black
        Me.BtnServ.IconSize = 32
        Me.BtnServ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnServ.Location = New System.Drawing.Point(0, 302)
        Me.BtnServ.Name = "BtnServ"
        Me.BtnServ.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BtnServ.Rotation = 0R
        Me.BtnServ.Size = New System.Drawing.Size(190, 45)
        Me.BtnServ.TabIndex = 6
        Me.BtnServ.Text = "Servicios"
        Me.BtnServ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnServ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnServ.UseVisualStyleBackColor = True
        '
        'BtnOpr
        '
        Me.BtnOpr.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnOpr.FlatAppearance.BorderSize = 0
        Me.BtnOpr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOpr.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnOpr.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpr.ForeColor = System.Drawing.Color.Black
        Me.BtnOpr.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar
        Me.BtnOpr.IconColor = System.Drawing.Color.Black
        Me.BtnOpr.IconSize = 32
        Me.BtnOpr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOpr.Location = New System.Drawing.Point(0, 257)
        Me.BtnOpr.Name = "BtnOpr"
        Me.BtnOpr.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BtnOpr.Rotation = 0R
        Me.BtnOpr.Size = New System.Drawing.Size(190, 45)
        Me.BtnOpr.TabIndex = 5
        Me.BtnOpr.Text = "Operaciones"
        Me.BtnOpr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOpr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnOpr.UseVisualStyleBackColor = True
        '
        'BtnVtas
        '
        Me.BtnVtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnVtas.FlatAppearance.BorderSize = 0
        Me.BtnVtas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVtas.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnVtas.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVtas.ForeColor = System.Drawing.Color.Black
        Me.BtnVtas.IconChar = FontAwesome.Sharp.IconChar.ChartPie
        Me.BtnVtas.IconColor = System.Drawing.Color.Black
        Me.BtnVtas.IconSize = 32
        Me.BtnVtas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVtas.Location = New System.Drawing.Point(0, 212)
        Me.BtnVtas.Name = "BtnVtas"
        Me.BtnVtas.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BtnVtas.Rotation = 0R
        Me.BtnVtas.Size = New System.Drawing.Size(190, 45)
        Me.BtnVtas.TabIndex = 4
        Me.BtnVtas.Text = "Ventas"
        Me.BtnVtas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVtas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnVtas.UseVisualStyleBackColor = True
        '
        'BtnProd
        '
        Me.BtnProd.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnProd.FlatAppearance.BorderSize = 0
        Me.BtnProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProd.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnProd.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProd.ForeColor = System.Drawing.Color.Black
        Me.BtnProd.IconChar = FontAwesome.Sharp.IconChar.BoxOpen
        Me.BtnProd.IconColor = System.Drawing.Color.Black
        Me.BtnProd.IconSize = 32
        Me.BtnProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProd.Location = New System.Drawing.Point(0, 167)
        Me.BtnProd.Name = "BtnProd"
        Me.BtnProd.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BtnProd.Rotation = 0R
        Me.BtnProd.Size = New System.Drawing.Size(190, 45)
        Me.BtnProd.TabIndex = 3
        Me.BtnProd.Text = "Productos"
        Me.BtnProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnProd.UseVisualStyleBackColor = True
        '
        'BtnOC
        '
        Me.BtnOC.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnOC.FlatAppearance.BorderSize = 0
        Me.BtnOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOC.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnOC.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOC.ForeColor = System.Drawing.Color.Black
        Me.BtnOC.IconChar = FontAwesome.Sharp.IconChar.ClipboardList
        Me.BtnOC.IconColor = System.Drawing.Color.Black
        Me.BtnOC.IconSize = 32
        Me.BtnOC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOC.Location = New System.Drawing.Point(0, 122)
        Me.BtnOC.Name = "BtnOC"
        Me.BtnOC.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BtnOC.Rotation = 0R
        Me.BtnOC.Size = New System.Drawing.Size(190, 45)
        Me.BtnOC.TabIndex = 2
        Me.BtnOC.Text = "Ingreso OC"
        Me.BtnOC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnOC.UseVisualStyleBackColor = True
        '
        'ImgHome
        '
        Me.ImgHome.Image = Global.IntraMar.My.Resources.Resources.if_09_harry_potter_colour_sirius_black_wolf_2730322_88141
        Me.ImgHome.Location = New System.Drawing.Point(16, 12)
        Me.ImgHome.Name = "ImgHome"
        Me.ImgHome.Size = New System.Drawing.Size(153, 107)
        Me.ImgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgHome.TabIndex = 1
        Me.ImgHome.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(190, 50)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(610, 451)
        Me.PanelDesktop.TabIndex = 2
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 501)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelMenu)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "INTRAMAR"
        Me.PanelMenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ImgHome As PictureBox
    Friend WithEvents BtnOC As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnAdm As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnLogis As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnServ As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnOpr As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnVtas As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnProd As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnEmpl As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PanelDesktop As Panel
End Class
