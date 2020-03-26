Imports FontAwesome.Sharp

Public Class Form2
    'Campos
    Private currentBtn As IconButton
    Private LeftBorderBtn As Panel
    Private currentChildForm As Form
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        LeftBorderBtn = New Panel()
        LeftBorderBtn.Size = New Size(7, 45)
        PanelMenu.Controls.Add(LeftBorderBtn)
    End Sub
    'Metodos
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button'
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border'
            LeftBorderBtn.BackColor = customColor
            LeftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            LeftBorderBtn.Visible = True
            LeftBorderBtn.BringToFront()
            'current Form icon'
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(187, 191, 195)
            currentBtn.ForeColor = Color.Black
            currentBtn.IconColor = Color.Black
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        'Open only form'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblFormTitle.Text = childForm.Text
    End Sub


    Private Sub BtnOC_Click(sender As Object, e As EventArgs) Handles BtnOC.Click
        ActivateButton(sender, Color.FromArgb(170, 210, 238))
        OpenChildForm(New FormInOC)
    End Sub

    Private Sub BtnProd_Click(sender As Object, e As EventArgs) Handles BtnProd.Click
        ActivateButton(sender, Color.FromArgb(170, 210, 238))
    End Sub

    Private Sub BtnVtas_Click(sender As Object, e As EventArgs) Handles BtnVtas.Click
        ActivateButton(sender, Color.FromArgb(170, 210, 238))
    End Sub

    Private Sub BtnOpr_Click(sender As Object, e As EventArgs) Handles BtnOpr.Click
        ActivateButton(sender, Color.FromArgb(170, 210, 238))
    End Sub

    Private Sub BtnServ_Click(sender As Object, e As EventArgs) Handles BtnServ.Click
        ActivateButton(sender, Color.FromArgb(170, 210, 238))
    End Sub

    Private Sub BtnLogis_Click(sender As Object, e As EventArgs) Handles BtnLogis.Click
        ActivateButton(sender, Color.FromArgb(170, 210, 238))
    End Sub

    Private Sub BtnAdm_Click(sender As Object, e As EventArgs) Handles BtnAdm.Click
        ActivateButton(sender, Color.FromArgb(170, 210, 238))
    End Sub

    Private Sub BtnEmpl_Click(sender As Object, e As EventArgs) Handles BtnEmpl.Click
        ActivateButton(sender, Color.FromArgb(170, 210, 238))
    End Sub

    Private Sub ImgHome_Click(sender As Object, e As EventArgs) Handles ImgHome.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub
End Class