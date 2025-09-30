---
uid: help-de-forms-sign-up
title: Anleitung - Anmeldung zum Newsletter
description: In dieser Anleitung erstellen wir ein Formular für Kunden, die sich für einen oder mehrere Newsletter anmelden möchten. Der Anmeldeprozess umfasst auch doppeltes Opt-In, um fehlerhafte oder gefälschte Abonnements zu eliminieren.
keywords: Formulare, Anmeldung, Newsletter
author: Bergfrid Dias
date: 09.26.2025
version: 10.5
content_type: tutorial
category: marketing
topic: forms
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: de
---

# Anleitung - Anmeldung zum Newsletter

Schauen wir uns ein anderes benutzerdefinierte Formular an, das für Ihre Firma relevant sein könnte:

## Was wir tun sollen

In dieser Anleitung erstellen wir ein Formular für Kunden, die sich für einen oder mehrere Newsletter anmelden möchten. Der Anmeldeprozess umfasst auch doppeltes Opt-In, um fehlerhafte oder gefälschte Abonnements zu eliminieren.

Hier wird nicht auf jedes Feld und jede Option eingegangen, aber Sie finden umfassende Anweisungen unter [Ein neues Formular erstellen][1].

## Hier starten

1. In SuperOffice, [erstellen Sie eine statische Selektion][7] von Firmen/Personen mit der Bezeichnung "Newsletter-Abonnenten (Formular)". Wir verwenden diese Selektion weiter hinten in diesem Leitfaden.

1. Gehen Sie zu **SuperOffice Marketing** und wählen Sie die Registerkarte **Formulare**.

1. Klicken Sie auf die **Formular**-Schaltfläche unter **Neu erstellen** auf der rechten Seite des Bildschirms.

1. Geben Sie im Dialogfeld **Formular bearbeiten** "Anmeldung zum Newsletter" in das Feld **Formularname** ein.

1. Wählen Sie **Eigenschaften** und füllen Sie die betreffenden Optionen/Felder aus. Aktivieren Sie KEINE Optionen unter **Formular automatisch deaktivieren**.

1. Klicken Sie auf **Aktivieren**, um das Formular zu speichern und die Bearbeitung fortzusetzen.

## Felder

1. Wählen Sie **Felder** im linken Menü.

1. Wählen Sie das Feld **Person - Name** aus und klicken Sie auf das rote X, um dieses Feld zu entfernen.

1. Klicken Sie auf <i class="ph ph-plus" aria-label="Add"></i> und fügen Sie die folgenden Felder hinzu:

    * Vor- und Nachname.

    * **Person - E-Mail** (machen Sie dieses Feld obligatorisch)

    * Person - Abonnement
        * Wählen Sie einen oder mehrere Newsletter aus, die verfügbar sein sollen.
        * Stellen Sie das Feld auf **Obligatorisch** ein.
        * Ändern Sie den Namen des Feldes in "Abonnements auswählen".

1. Wählen Sie das Feld **OK**, ändern Sie den Namen in "Übermitteln" und bearbeiten Sie Vorder-/Hintergrundfarbe und Position.

1. Bearbeiten Sie nach Bedarf die Namen der anderen Felder. **Tipp**: Entfernen Sie "Person -".

1. Klicken Sie auf <i class="ph ph-dots-six" aria-label="Sechs Punkte"></i> oben in einem Feld und ziehen Sie es an die gewünschte Position auf dem Formular. Die Felder sollten eine logische Reihenfolge aufweisen.

1. Klicken Sie auf **Aktivieren**, um das Formular zu speichern und die Bearbeitung fortzusetzen.

![Formulareigenschaften der neuen Anmeldungsformulars -screenshot][img7]

## Stil

1. Wählen Sie **Stil** im linken Menü, um das Aussehen und das Gefühl des Formulars zu definieren. Bearbeiten Sie das Layout, die Farben, die Größe und die Schriftarten für das Formular. Erwägen Sie, Ihre Webdesign-Kollegen einzubeziehen.

1. Klicken Sie auf **Aktivieren**, um das Formular zu speichern und die Bearbeitung fortzusetzen.

![Stil der neuen Anmeldungsformulars -screenshot][img8]

## Doppeltes Opt-in

[!include[Show toolbar](includes/tip-show-toolbar-open-editor.md)]

1. Wählen Sie **Doppeltes Opt-in** im linken Menü.

1. Klicken Sie **Doppeltes Opt-in aktivieren**.

1. Geben Sie in der Registerkarte **Mitteilung** den Text ein, der nach Übermittlung des Formulars angezeigt wird. Diese Mitteilung soll den Kunden darüber informieren, dass er eine E-Mail-Bestätigung erhält.

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

1. Klicken Sie auf **Bestätigungs-Link einfügen** (<i class="ph ph-arrow-square-out" aria-hidden="true"></i>). Der Bestätigungs-Link wird in den Text eingefügt.

1. Klicken Sie auf den Bestätigungs-Link, wählen Sie **Link bearbeiten** (<i class="ph ph-pencil-simple" aria-hidden="true"></i>) und ändern Sie den Link-Text in "Zum Bestätigen der E-Mail-Adresse hier klicken". Der Link ist standardmäßig 30 Minuten lang gültig.

1. Klicken Sie auf **Aktivieren**, um das Formular zu speichern und die Bearbeitung fortzusetzen.

![Doppeltes Opt-in zur neuen Anmeldungsformulars hinzufügen -screenshot][img9]

## Landingpages

1. Wählen Sie **Danke-Seite**.

1. Wählen Sie **Diese Nachricht anzeigen** und geben Sie ein "Vielen Dank für das Abonnement". Diese wird angezeigt, nachdem der Kunde seine E-Mail-Adresse bestätigt hat.

1. Wählen Sie **Seite für inaktives Formular**.

1. Wählen Sie **Auf externe Website umleiten** und geben Sie ein eine URL. Wenn ein Kunde nach Inaktivierung auf das Formular zugreift, wird er auf diese Seite geschickt.

1. Klicken Sie auf **Aktivieren**, um das Formular zu speichern und die Bearbeitung fortzusetzen.

## Aktionen

1. Wählen Sie **Aktionen** im linken Menü um die Aktionen konfigurieren, die bei der Verarbeitung des Formulars ausgeführt werden sollen.

1. Wählen Sie nicht **Anfrage erstellen**. Die Abonnements werden automatisch aktiviert, sodass keine Aktion vom Supportteam erforderlich ist.

1. Wählen Sie **Manuell bei unbekanntem Übermittler. Automatisch bei bekanntem Übermittler**: Wenn die im Formular übermittelte E-Mail-Adresse mit einer E-Mail-Adresse in SuperOffice übereinstimmt, wird das übermittelte Formular automatisch verarbeitet. Andernfalls muss es manuell verarbeitet werden.

1. **Person zu Selektion hinzufügen**: Wählen Sie die in Schritt 1 erstellte Selektion. Mit dieser Selektion können Sie die über dieses Formular hinzugefügten Personen nachverfolgen.

1. **Interessen zu Person hinzufügen**: Wählen Sie das Interesse mit der Bezeichnung **Newsletter**. Dieses Interesse wird zu Personen hinzugefügt, die dieses Formular übermitteln.

1. **E-Mail-Antwort**: Wählen oder [erstellen Sie eine Formularantwort][2], die an Personen gesendet werden soll, sobald die von ihnen übermittelten Formulare verarbeitet werden. Diese E-Mail kann zum Beispiel den Kunden über die Datenschutzbestimmungen Ihrer Firma informieren und auch einen Link zur [Verwaltung von Abonnements][6] enthalten.

![Formularaktionen konfigurieren -screenshot][img6]

## Speichern und veröffentlichen

1. Klicken Sie auf **Speichern**. Das Formular wird gespeichert und die Ansicht **Formular bearbeiten** wird geschlossen.

1. Setzen Sie das Formular in der Kopfzeile auf **Aktiv** <i class="ph ph-toggle-right" aria-label="Toggle on"></i>.

1. Gehen Sie zur Registerkarte **Veröffentlichen**.

1. Kopieren Sie den direkten Link und/oder den JavaScript-Code in einen Newsletter, eine Website oder ein Kundenzentrum, um das Formular für Kunden oder Interessenten zu veröffentlichen.

1. Öffnen Sie den Link zum Formular, füllen Sie das Formular aus und überprüfen Sie, ob alles wie erwartet funktioniert.

> [!TIP]
> Sie könnten auch an unserem [Kontaktformular][7]-Anleitung interessiert sein.

<!-- Referenced links -->
[1]: create.md
[2]: ../../mailing/learn/create/tutorial-form-mailing.md
[6]: ../../recipients/learn/manage-email-subscriptions.md
[7]: ../../../search-options/selection/learn/create.md

<!-- Referenced images -->
[img6]: ../../../../media/loc/en/marketing/sign-up-form-actions.png
[img7]: ../../../../media/loc/en/marketing/sign-up-form-fields.png
[img8]: ../../../../media/loc/en/marketing/sign-up-form-style.png
[img9]: ../../../../media/loc/en/marketing/sign-up-form-double-opt-in.png
