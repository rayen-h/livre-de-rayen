<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_livre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_livre))
        txt_isbn = New Label()
        txt_titre = New Label()
        txt_auteur = New Label()
        btn_ajouter = New Button()
        btn_afficher = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        SuspendLayout()
        ' 
        ' txt_isbn
        ' 
        txt_isbn.AutoSize = True
        txt_isbn.Location = New Point(56, 63)
        txt_isbn.Name = "txt_isbn"
        txt_isbn.Size = New Size(41, 20)
        txt_isbn.TabIndex = 0
        txt_isbn.Text = "ISBN"
        ' 
        ' txt_titre
        ' 
        txt_titre.AutoSize = True
        txt_titre.Location = New Point(56, 153)
        txt_titre.Name = "txt_titre"
        txt_titre.Size = New Size(39, 20)
        txt_titre.TabIndex = 1
        txt_titre.Text = "Titre"
        ' 
        ' txt_auteur
        ' 
        txt_auteur.AutoSize = True
        txt_auteur.Location = New Point(56, 251)
        txt_auteur.Name = "txt_auteur"
        txt_auteur.Size = New Size(53, 20)
        txt_auteur.TabIndex = 2
        txt_auteur.Text = "Auteur"
        ' 
        ' btn_ajouter
        ' 
        btn_ajouter.Location = New Point(98, 340)
        btn_ajouter.Name = "btn_ajouter"
        btn_ajouter.Size = New Size(94, 29)
        btn_ajouter.TabIndex = 3
        btn_ajouter.Text = "Ajouter"
        btn_ajouter.UseVisualStyleBackColor = True
        ' 
        ' btn_afficher
        ' 
        btn_afficher.Location = New Point(263, 340)
        btn_afficher.Name = "btn_afficher"
        btn_afficher.Size = New Size(94, 29)
        btn_afficher.TabIndex = 4
        btn_afficher.Text = "Afficher"
        btn_afficher.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(126, 56)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(126, 146)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(126, 244)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 7
        ' 
        ' Frm_livre
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(btn_afficher)
        Controls.Add(btn_ajouter)
        Controls.Add(txt_auteur)
        Controls.Add(txt_titre)
        Controls.Add(txt_isbn)
        Name = "Frm_livre"
        Text = "livre"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_isbn As Label
    Friend WithEvents txt_titre As Label
    Friend WithEvents txt_auteur As Label
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents btn_afficher As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox

End Class
