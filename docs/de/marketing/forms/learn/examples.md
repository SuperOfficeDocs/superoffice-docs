---
uid: help-de-forms-examples
title: Erstellen von Formularen (Beispiele)
description: Erstellen von Formularen (Beispiele)
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Formulare
so.topic: concept
language: de
---

# Erstellen von Formularen (Beispiele)

Schauen wir uns zwei benutzerdefinierte Formulare an, die für Ihre Firma relevant sein könnten:

* [Anmeldung zum Newsletter](#newsletter-sign-up): Lassen Sie Ihre Kunden sich für einen oder mehrere Ihrer Newsletter anmelden.
* [Kontaktieren](#contact-me): Mit einem "Kontaktieren"-Formular können Sie einen weiteren Kommunikationskanal für Ihre Kunden oder Interessenten öffnen. Mit diesem Formular können Sie Supportanfragen oder Leads für Ihr Vertriebsteam generieren.

In diesem Beispiel wird nicht auf jedes Feld und jede Option eingegangen, aber Sie finden umfassende Anweisungen unter [Ein neues Formular erstellen][1].

## Was bedeutet doppeltes Opt-in?

Bei doppeltem Opt-in müssen die Kunden ihre E-Mail-Adresse verifizieren, indem sie zusätzlich zur Übermittlung des Formulars auf den Link in einer Bestätigungs-E-Mail klicken.

Mit dieser Option statten Sie das Formular mit einem zusätzlichen Sicherheitsmerkmal aus. Wenn Sie diese Option aktivieren, muss die Person, die das Formular übermittelt, zusätzlich ihre E-Mail-Adresse bestätigen. Zu diesem Zweck erhält die betreffende Person eine E-Mail, sobald sie das Formular übermittelt. Die E-Mail enthält einen Link, auf den die betreffende Person klicken muss, um die Richtigkeit der E-Mail-Adresse zu bestätigen.
Der Link ist standardmäßig 30 Minuten lang gültig.

## <a id="newsletter-sign-up" />Anmeldung zum Newsletter

Mit diesem Formular können sich Ihre Kunden für einen oder mehrere Newsletter anmelden. Der Anmeldeprozess umfasst auch doppeltes Opt-In, um fehlerhafte oder gefälschte Abonnements zu eliminieren.

1. Öffnen Sie SuperOffice CRM und erstellen Sie eine statische Selektion von Firmen/Personen mit der Bezeichnung "Newsletter-Abonnenten (Formular)". Wir verwenden diese Selektion weiter hinten in diesem Leitfaden.

1. Öffnen Sie SuperOffice Marketing und gehen Sie zur Registerkarte **Formulare**.

1. Wählen Sie unter **Neu erstellen** auf der rechten Seite der Ansicht die Option **Formular**. Daraufhin wird die Ansicht **Formular bearbeiten** angezeigt.

1. Geben Sie "Anmeldung zum Newsletter" in das Feld **Formularname** ein.

1. Füllen Sie die betreffenden Optionen/Felder in der Kategorie **Eigenschaften** aus. Aktivieren Sie KEINE Optionen unter **Formular automatisch deaktivieren**.

1. Klicken Sie auf **Aktivieren**, um das Formular zu speichern und die Bearbeitung fortzusetzen.

1. Klicken Sie in der Kategorie **Felder** auf ![Symbol][img1] und fügen Sie die folgenden Felder hinzu:

    * Vor- und Nachname (entfernen Sie das Feld **Person - Name**)
    * **Person - E-Mail** (machen Sie dieses Feld obligatorisch)
    * Person - Abonnement
        * Wählen Sie einen oder mehrere Newsletter aus, die verfügbar sein sollen.
        * Stellen Sie das Feld auf **Obligatorisch** ein.
        * Ändern Sie den Namen des Feldes in "Abonnements auswählen".

1. Wählen Sie das Feld **OK**, ändern Sie den Namen in "Übermitteln" und bearbeiten Sie Vorder-/Hintergrundfarbe und Position.

1. Bearbeiten Sie nach Bedarf die Namen der anderen Felder. **Tipp**: Entfernen Sie "Person -".

1. Klicken Sie auf ![Symbol][img2] oben in einem Feld und ziehen Sie es an die gewünschte Position auf dem Formular. Die Felder sollten eine logische Reihenfolge aufweisen.

1. Klicken Sie auf **Aktivieren**, um das Formular zu speichern und die Bearbeitung fortzusetzen.

1. In der Kategorie **Stil** können Sie das Layout, die Farben, die Größe und die Schriftarten für das Formular bearbeiten. Erwägen Sie, Ihre Webdesign-Kollegen einzubeziehen.

1. Klicken Sie auf **Aktivieren**, um das Formular zu speichern und die Bearbeitung fortzusetzen.

1. Wählen Sie in der Kategorie **Doppeltes Opt-in** die Option **Doppeltes Opt-in aktivieren**.

1. Geben Sie in der Registerkarte **Mitteilung** den Text ein, der nach Übermittlung des Formulars angezeigt wird. Diese Mitteilung soll den Kunden darüber informieren, dass er eine E-Mail-Bestätigung erhält. Klicken Sie auf **Symbolleiste ein-/ausblenden** ![Symbol][img3], um Formatierungsoptionen für den Text anzuzeigen.

    <details><summary>Beispiel</summary>

    Wir senden jetzt eine E-Mail an die Adresse, die Sie in unserem Formular registriert haben.

    Klicken Sie auf den Link in der E-Mail, um Ihre E-Mail-Adresse zu bestätigen und Ihr(e) Abonnement(s) zu aktivieren.

    Mit freundlichen Grüßen

    SuperShop
    </details>

1. Erstellen Sie auf der Registerkarte **E-Mail** die Bestätigungs-E-Mail, die den Personen zugesendet wird, die das Formular übermitteln.

    <details><summary>Beispiel</summary>

    Hallo und vielen Dank für Ihr Interesse an unseren Newslettern.

    Klicken Sie bitte auf den folgenden Link, um Ihre E-Mail-Adresse zu bestätigen und das Abonnement zu aktivieren.

    Klicken Sie hier, um Ihre E-Mail-Adresse zu bestätigen

    Mit freundlichen Grüßen

    Ihr SuperShop-Team
    </details>

1. Klicken Sie auf **Symbolleiste ein-/ausblenden** ![Symbol][img3] und dann auf **Bestätigungs-Link einfügen** ![Symbol][img4]. Der Bestätigungs-Link wird in den Text eingefügt.

1. Klicken Sie auf den Bestätigungs-Link, wählen Sie **Link bearbeiten** ![Symbol][img5] und ändern Sie den Link-Text in "Zum Bestätigen der E-Mail-Adresse hier klicken". Der Link ist standardmäßig 30 Minuten lang gültig.

1. Klicken Sie auf **Aktivieren**, um das Formular zu speichern und die Bearbeitung fortzusetzen.

1. In der Kategorie **Danke-Seite** können Sie den Kunden auf eine Webseite weiterleiten oder eine Nachricht anzeigen (z. B.: "Vielen Dank für das Abonnement"). Diese wird angezeigt, nachdem der Kunde seine E-Mail-Adresse bestätigt hat.

1. Klicken Sie auf **Aktivieren**, um das Formular zu speichern und die Bearbeitung fortzusetzen.

1. Geben Sie in der Kategorie **Seite für inaktives Formular** eine URL oder eine Nachricht ein. Dies ist wichtig, wenn ein Kunde auf das Formular zugreift, nachdem es auf inaktiv eingestellt wurde.

1. Klicken Sie auf **Aktivieren**, um das Formular zu speichern und die Bearbeitung fortzusetzen.

1. In der Kategorie **Aktionen** müssen Sie die Aktionen konfigurieren, die bei der Verarbeitung des Formulars ausgeführt werden sollen:

    * Wählen Sie nicht **Anfrage erstellen**. Die Abonnements werden automatisch aktiviert, sodass keine Aktion vom Supportteam erforderlich ist.

    * Wählen Sie **Manuell bei unbekanntem Übermittler. Automatisch bei bekanntem Übermittler**: Wenn die im Formular übermittelte E-Mail-Adresse mit einer E-Mail-Adresse in SuperOffice übereinstimmt, wird das übermittelte Formular automatisch verarbeitet. Andernfalls muss es manuell verarbeitet werden.

    * **Person zu Selektion hinzufügen**: Wählen Sie die in Schritt 1 erstellte Selektion. Mit dieser Selektion können Sie die über dieses Formular hinzugefügten Personen nachverfolgen.

    * **Interessen zu Person hinzufügen**: Wählen Sie das Interesse mit der Bezeichnung **Newsletter**. Dieses Interesse wird zu Personen hinzugefügt, die dieses Formular übermitteln.

    * **E-Mail-Antwort**: Wählen oder [erstellen Sie eine Formularantwort][2], die an Personen gesendet werden soll, sobald die von ihnen übermittelten Formulare verarbeitet werden. Diese E-Mail kann zum Beispiel den Kunden über die Datenschutzbestimmungen Ihrer Firma informieren und auch einen Link zur [Verwaltung von Abonnements][6] enthalten.

1. Klicken Sie auf **Speichern**. Das Formular wird gespeichert und die Ansicht **Formular bearbeiten** wird geschlossen.

1. Setzen Sie das Formular in der Kopfzeile auf **Aktiv** ![Symbol][img6].

1. Gehen Sie zur Registerkarte **Veröffentlichen**.

1. Kopieren Sie den direkten Link und/oder den JavaScript-Code in einen Newsletter, eine Website oder ein Kundenzentrum, um das Formular für Kunden oder Interessenten zu veröffentlichen.

1. Öffnen Sie den Link zum Formular, füllen Sie das Formular aus und überprüfen Sie, ob alles wie erwartet funktioniert.

## <a id="contact-me" />Kontakt

Stellen Sie ein "Kontaktieren"-Formular auf die Webseiten Ihrer Firma, um einen einfachen Kommunikationskanal für bestehende oder potenzielle Kunden bereitzustellen.

In diesem Beispiel wird erläutert, wie Sie ein kurzes Formular für Kunden erstellen können, die sich an einen Supportmitarbeiter wenden wollen. Die Formularübermittlung löst eine neue Anfrage für Ihre Supportabteilung aus.

1. Öffnen Sie SuperOffice Marketing und gehen Sie zur Registerkarte **Formulare**.

1. Wählen Sie unter **Neu erstellen** auf der rechten Seite der Ansicht die Option **Formular**. Daraufhin wird die Ansicht **Formular bearbeiten** angezeigt.

1. Geben Sie "Kontaktieren (Support)" in das Feld **Formularname** ein.

1. Füllen Sie die betreffenden Optionen/Felder in der Kategorie **Eigenschaften** aus. Aktivieren Sie KEINE Optionen unter **Formular automatisch deaktivieren**.

1. Klicken Sie in der Kategorie **Felder** auf ![Symbol][img1] und fügen Sie die folgenden Felder hinzu:

    * Vor- und Nachname. Entfernen Sie das Feld **Person - Name**.
    * **Ansichtselemente** > **Textblock**: Geben Sie "Wie können wir Sie kontaktieren?" in Fettdruck ein.
    * **Person - Mobiltelefon**: Geben Sie in das Feld **Platzhalter** ein Beispiel für eine korrekt formatierte Telefonnummer für Ihr Land (einschließlich Ländervorwahl) ein (Beispiel: +49 999 88 777).
    * **Person - Email**
    * **Formularelemente** > **Textbereich**: Ändern Sie den Namen des Feldes in "Kommentar (optional)" und geben Sie "Wie können wir Ihnen weiterhelfen?" in das Feld **Platzhalter** ein.

1. Wählen Sie das Feld **OK**, ändern Sie den Namen in "Übermitteln" und bearbeiten Sie Vorder-/Hintergrundfarbe und Position.

1. Bearbeiten Sie nach Bedarf die Namen der anderen Felder. **Tipp**: Entfernen Sie "Person -".

1. Klicken Sie auf ![Symbol][img2] oben in einem Feld und ziehen Sie es an die gewünschte Position auf dem Formular. Die Felder sollten eine logische Reihenfolge aufweisen.

1. Klicken Sie auf **Aktivieren**, um das Formular zu speichern und die Bearbeitung fortzusetzen.

1. In der Kategorie **Stil** können Sie das Layout, die Farben, die Größe und die Schriftarten für das Formular bearbeiten. Erwägen Sie, Ihre Webdesign-Kollegen einzubeziehen.

1. Klicken Sie auf **Aktivieren**, um das Formular zu speichern und die Bearbeitung fortzusetzen.

1. Optional: Um das doppelte Opt-in aktivieren, müssen Sie auch das Feld **E-Mail** auf **Obligatorisch** setzen.

1. In der Kategorie **Danke-Seite** können Sie den Kunden auf eine Webseite weiterleiten oder eine Nachricht anzeigen (z. B.: "Vielen Dank, dass Sie uns kontaktiert haben. Wir melden uns in Kürze bei Ihnen."). Diese wird angezeigt, nachdem der Kunde das Formular übermittelt hat.

1. Geben Sie in der Kategorie **Seite für inaktives Formular** eine URL oder eine Nachricht ein. Dies ist wichtig, wenn ein Kunde auf das Formular zugreift, nachdem es auf inaktiv markiert wurde.

1. In der Kategorie **Aktionen** müssen Sie die Aktionen konfigurieren, die bei der Verarbeitung des Formulars ausgeführt werden sollen:

    * Wählen Sie **Anfrage erstellen** und gehen Sie folgendermaßen vor:
        1. Geben Sie einen aussagekräftigen Titel für die Anfragen ein, die mit diesem Formular erzeugt werden.
        2. Wählen Sie die betreffende Anfragekategorie, beispielsweise "Support" oder eine Unterkategorie namens "Formularübermittlungen".
        3. Setzen Sie die Anfragepriorität auf **Mittel**.

    * Wählen Sie **Manuell bei unbekanntem Übermittler. Automatisch bei bekanntem Übermittler**: Wenn die im Formular übermittelte E-Mail-Adresse mit einer E-Mail-Adresse in SuperOffice übereinstimmt, wird das übermittelte Formular automatisch verarbeitet. Andernfalls muss es manuell verarbeitet werden.

    * **E-Mail-Antwort**: Wählen oder [erstellen Sie eine Formularantwort][2], die an Personen gesendet werden soll, sobald die von ihnen übermittelten Formulare verarbeitet werden. Diese E-Mail kann zum Beispiel den Kunden über die Datenschutzbestimmungen Ihrer Firma informieren und auch einen Link zur [Verwaltung von Abonnements][6] enthalten.

1. Klicken Sie auf **Speichern**. Das Formular wird gespeichert und die Ansicht **Formular bearbeiten** wird geschlossen.

1. Setzen Sie das Formular in der Kopfzeile auf **Aktiv** ![Symbol][img6].

1. Gehen Sie zur Registerkarte **Veröffentlichen**.

1. Kopieren Sie den direkten Link und/oder den JavaScript-Code in einen Newsletter, eine Website oder ein Kundenzentrum, um das Formular für Kunden oder Interessenten zu veröffentlichen.

1. Öffnen Sie den Link zum Formular, füllen Sie das Formular aus und überprüfen Sie, ob alles wie erwartet funktioniert.

## Was geschieht jetzt?

* [Formularübermittlungen][3]
* [Formularübermittlungen überwachen und Statistiken anzeigen][4]
* [Formularübermittlungen verarbeiten][5]

<!-- Referenced links -->
[1]: create.md
[2]: ../../mailing/learn/create/tutorial-form-mailing.yml
[3]: submissions/index.md
[4]: submissions/track.md
[5]: submissions/process.md
[6]: ../../recipients/learn/manage-email-subscriptions.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/marketing-and-forms/add-field.png
[img2]: ../../../../media/icons/marketing-and-forms/move-field.png
[img3]: ../../../../media/icons/marketing-and-forms/toolbar-show-hide.png
[img4]: ../../../../../common/icons/new-window-icon.png
[img5]: ../../../../../common/icons/edit-black.png
[img6]: ../../../../media/icons/marketing-and-forms/form-active.png
