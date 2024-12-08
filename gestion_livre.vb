Module gestion_livre
    Public Structure livre
        Dim ISBN As Integer
        Dim Titre As String
        Dim Auteur As String
    End Structure

    Public bibliotheque(100) As livre
    Dim Nb As Integer = 0
    Function Ajouterlivre(l As livre) As Boolean
        If Nb < bibliotheque.Length Then
            bibliotheque(Nb) = l
            Return True
        Else
            Return False
        End If
    End Function

    Sub Afficherlivre(l1 As ListBox, l2 As ListBox, l3 As ListBox)
        For i As Integer = 0 To Nb - 1
            l1.Items.Add(bibliotheque(i).ISBN)
            l2.Items.Add(bibliotheque(i).Titre)
            l3.Items.Add(bibliotheque(i).Auteur)
        Next
    End Sub
    Sub afficher2_livre(Dgv_livre As DataGridView)
        For i As Integer = 0 To Nb - 1
            Dim livre As livre = bibliotheque(i)
            Dgv_livre.Rows.Add(livre.ISBN, livre.Titre, livre.Auteur)
        Next
    End Sub

End Module
