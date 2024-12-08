Public Class Frm_livre
    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Dim l As livre
        l.ISBN = txt_isbn.Text
        l.Titre = txt_titre.Text
        l.Auteur = txt_auteur.Text

        If Ajouterlivre(l) Then
            MessageBox.Show("ajout de livre avec succes")
        Else
            MessageBox.Show("le tableau bilbliotheque est saturé")
        End If
    End Sub

    Private Sub btn_afficher_Click(sender As Object, e As EventArgs) Handles btn_afficher.Click
        liste_des_livre.Show()

    End Sub


End Class
