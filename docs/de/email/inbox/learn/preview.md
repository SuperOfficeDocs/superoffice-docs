---
uid: help-de-email-inbox-preview
title: E-Mail-Nachrichten anzeigen
description: So zeigen Sie E-Mails in der SuperOffice Inbox an, markieren, verschieben oder drucken sie
keywords: E-Mail öffnen, E-Mail anzeigen, Vorschau, E-Mail verschieben, als gelesen markieren, drucken, E-Mail, SuperOffice Inbox
author: Bergfrid Dias
date: 05.23.2025
version: 10.5.2
topic: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# E-Mail-Nachrichten anzeigen

Wenn Sie eine E-Mail im Posteingang auswählen, wird eine Vorschau der Nachricht auf der rechten Seite des Bildschirms angezeigt. Ein Doppelklick öffnet die Nachricht in einem separaten Fenster.

![E-Mail-Vorschau mit ausgewählter Nachricht und verfügbaren Aktionen -screenshot][img1]

## Vorschaufenster

Die Vorschau zeigt den Inhalt der ausgewählten Nachricht an, einschließlich Empfänger, Anhänge und weiterer Details.

Wenn der Absender in SuperOffice CRM erfasst ist, können Sie mit der Maus über den Namen fahren, um die [Personen-Ansicht][9] zu öffnen.

### Inline-Bilder anzeigen

So zeigen Sie eingebettete Bilder im Vorschaufenster an:

1. Klicken Sie oben auf <i class="ph ph-user-circle" aria-hidden="true"></i> und wählen Sie **E-Mail-Optionen**.
2. Wechseln Sie zur Registerkarte **Allgemein**.
3. Aktivieren Sie das Kontrollkästchen **Inline-Bilder anzeigen**.
4. Klicken Sie auf **OK**, um die Einstellung zu übernehmen.

![E-Mail-Optionen: Registerkarte Allgemein -screenshot][img2]

### Anhang öffnen

Anhänge werden unterhalb der E-Mail-Kopfzeile angezeigt, wenn eine Nachricht ausgewählt ist.

1. Klicken Sie auf das Symbol <i class="ph ph-caret-down" aria-label="Chevron"></i> neben dem Namen des Anhangs.
2. Wählen Sie **Vorschau**, um die Datei direkt im Browser zu öffnen.

    Die Anzeige kann je nach Dateityp und Browsereinstellungen variieren. PDFs werden beispielsweise oft in einem neuen Tab geöffnet.

> [!TIP]
> Sie können den Anhang auch **herunterladen**, um ihn lokal zu speichern, oder **archivieren**, um ihn als [Dokument in SuperOffice CRM zu speichern][2].

## <a id="mark-as-read"></a>E-Mails als gelesen oder ungelesen markieren

E-Mails werden **nicht automatisch als gelesen** markiert, es sei denn, Sie aktivieren diese Option.

### Automatisches Markieren aktivieren

1. Gehen Sie zu <i class="ph ph-user-circle" aria-hidden="true"></i> **Persönliche Einstellungen** > **E-Mail-Optionen** > **Allgemein**.
2. Aktivieren Sie die Option **In Vorschau als gelesen markieren**.
3. Klicken Sie auf **OK**.

### Nachrichten manuell markieren

* Eine einzelne Nachricht markieren:
    1. Wählen Sie die Nachricht aus.
    2. Klicken Sie auf <i class="ph ph-dots-three-circle-vertical" aria-label="Aufgabe"></i> und wählen Sie **Als gelesen/ungelesen markieren**.

    ![Aufgabenmenü mit Markierungs- und Verschiebeoptionen -screenshot][img3]

* Mehrere Nachrichten markieren:
    1. **Strg+Klick** (Windows) oder **Cmd+Klick** (Mac), um mehrere Nachrichten auszuwählen.
    2. Verwenden Sie im Nachrichtenbereich die Schaltflächen **Als gelesen markieren** oder **Als ungelesen markieren**.

    ![Optionen zum Verschieben, Markieren und Löschen mehrerer ausgewählter E-Mails -screenshot][img4]

## <a id="move"></a>E-Mail in Ordner verschieben

Sie können E-Mails in andere Ordner Ihres E-Mail-Kontos verschieben.

Die Ordnerliste stammt von Ihrem E-Mail-Anbieter (z. B. Outlook oder Gmail). Sie können Ordner in SuperOffice CRM nicht erstellen, umbenennen oder löschen. Verwalten Sie Ordner direkt in Ihrem E-Mail-Konto.

### Eine einzelne E-Mail verschieben

1. Wählen Sie eine Nachricht im Posteingang aus.
2. Klicken Sie auf <i class="ph ph-dots-three-circle-vertical" aria-label="Aufgabe"></i> und wählen Sie **In Ordner verschieben**.
3. Wählen Sie den Zielordner aus.

> [!CAUTION]
> Wenn ein Ordnername ausgegraut ist, ist er derzeit nicht mit Ihrem E-Mail-Konto synchronisiert.
>
> Um ihn zu aktivieren, wählen Sie den Ordner oberhalb der Nachrichtenliste aus und klicken Sie auf das Symbol **Abonnieren** (<i class="ph ph-cloud-slash" aria-label="Cloud"></i>) in der rechten unteren Ecke. So wird sichergestellt, dass die Nachricht korrekt verschoben wird.

### Mehrere E-Mails verschieben

1. Wählen Sie mehrere Nachrichten mit **Strg+Klick** (Windows) oder **Cmd+Klick** (Mac) aus.
2. Verwenden Sie im Nachrichtenbereich die Schaltfläche **In Ordner verschieben**.

## <a id="print"></a>E-Mail drucken

1. Wählen Sie eine Nachricht im Posteingang aus.
2. Klicken Sie auf <i class="ph ph-dots-three-circle-vertical" aria-label="Aufgabe"></i> und wählen Sie **Ausgewählte E-Mail drucken**.
3. Die Nachricht wird in einem Browserfenster zur Vorschau geöffnet.
4. Verwenden Sie die **Drucken**-Funktion Ihres Browsers, um die Nachricht auszudrucken.

## Verwandte Inhalte

* [Absender verwalten][1]
* [Einladungen empfangen][3]
* [Aufgabe erstellen][4]
* [Anfrage erstellen][5]

<!-- Referenced links -->
[1]: manage-senders.md
[2]: archive.md#attachment
[3]: invitations.md
[4]: create-task.md
[5]: create-request.md
[9]: ../../../contact/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/email/inbox-preview-message.png
[img2]: ../../../../media/loc/en/email/email-options-general.png
[img3]: ../../../../media/loc/en/email/inbox-message-task-menu.png
[img4]: ../../../../media/loc/en/email/inbox-multiselect-actions.png
