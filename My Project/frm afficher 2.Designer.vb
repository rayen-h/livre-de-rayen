<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_afficher2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_afficher2))
        dgv_livre = New DataGridView()
        ISBN = New DataGridViewTextBoxColumn()
        TITRE = New DataGridViewTextBoxColumn()
        AUTEUR = New DataGridViewTextBoxColumn()
        CType(dgv_livre, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgv_livre
        ' 
        dgv_livre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_livre.Columns.AddRange(New DataGridViewColumn() {ISBN, TITRE, AUTEUR})
        dgv_livre.Location = New Point(153, 82)
        dgv_livre.Name = "dgv_livre"
        dgv_livre.RowHeadersWidth = 51
        dgv_livre.Size = New Size(441, 188)
        dgv_livre.TabIndex = 0
        ' 
        ' ISBN
        ' 
        ISBN.HeaderText = "ISBN"
        ISBN.MinimumWidth = 6
        ISBN.Name = "ISBN"
        ISBN.Width = 125
        ' 
        ' TITRE
        ' 
        TITRE.HeaderText = "TITRE"
        TITRE.MinimumWidth = 6
        TITRE.Name = "TITRE"
        TITRE.Width = 125
        ' 
        ' AUTEUR
        ' 
        AUTEUR.HeaderText = "AUTEUR"
        AUTEUR.MinimumWidth = 6
        AUTEUR.Name = "AUTEUR"
        AUTEUR.Width = 125
        ' 
        ' frm_afficher2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(dgv_livre)
        Name = "frm_afficher2"
        Text = "frm_afficher_2"
        CType(dgv_livre, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgv_livre As DataGridView
    Friend WithEvents ISBN As DataGridViewTextBoxColumn
    Friend WithEvents TITRE As DataGridViewTextBoxColumn
    Friend WithEvents AUTEUR As DataGridViewTextBoxColumn
End Class
