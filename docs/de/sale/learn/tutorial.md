---
uid: help-de-working-with-sales-guide
title: Beispiel – Verkaufsleitfaden
description: Arbeiten mit einem Verkaufsleitfaden
keywords: Verkaufsleitfaden, Beispiel
author: SuperOffice RnD
date: 02.11.2025
version: 10.5.2
content_type: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Beispiel – Verkaufsleitfaden

Beachten Sie, dass Ihre Verkaufsleitfäden in Einstellungen und Verwaltung anders konfiguriert sein können.

## Neuen Verkauf eingeben und Verkaufstyp auswählen

Sie erfassen einen neuen Verkauf und wählen den Verkaufstyp **Verkauf an neuen Kunden**, der mit einem Verkaufsleitfaden verknüpft ist. Der Verkaufsleitfaden enthält die folgenden Stufen, Folgeaufgaben und Dokumente:

| Stufe | Folgeaufgaben | Dokumente |
|---|---|---|
| Interessephase | Kundenbesprechung (Meeting (extern)) | Besprechungsbestätigung (E-Mail) |
| Angebot | Angebotsvorbereitung (Aufgabe) | Angebot (Brief) |
| Vertragsunterzeichnung | Einberufung eines Vertragsgesprächs (Telefongespräch)<br /> Vertragsgespräch (Meeting (extern)) | Unterschriebener Vertrag |

## Die Stufe "Interessephase"

1. Sie haben einen Besprechungstermin vereinbart und möchten die **Kundenbesprechung**-Folgeaufgabe im Kalender erstellen und Teilnehmer einladen.

    1. Klicken Sie im Verkaufsleitfaden auf **Erstellen** neben der Folgeaufgabe **Kundenbesprechung**.
        Das Dialogfeld **Folgeaufgabe** wird geöffnet, in dem **Meeting (extern)** als Typ angegeben ist und der Name des Verkaufs sowie die Firma bereits vorab ausgefüllt sind.
    2. Vervollständigen Sie die Informationen und [laden Sie Teilnehmer ein][1].
    3. Klicken Sie auf **Speichern**.

2. Zur besseren Übersicht möchten Sie eine E-Mail zur Bestätigung der Uhrzeit und des Ortes des Treffens senden.

    1. Klicken Sie auf **Erstellen** neben **Besprechungsbestätigung**.
        Das Dialogfeld **Dokument** wird geöffnet, wobei **E-Mail** bereits als Dokumenttyp ausgewählt und der Firmenname sowie der Verkaufsname vorausgefüllt sind.
    2. Geben Sie die restlichen Informationen in das Dialogfeld **Dokument** ein.
    3. Klicken Sie auf **Erstellen**, um die E-Mail zu generieren und zu senden.

3. Nachdem die Besprechung stattgefunden hat, möchten Sie dies im Verkaufsleitfaden bestätigen.

    Aktivieren Sie im Verkaufsleitfaden das Kontrollkästchen neben der Folgeaufgabe **Kundenbesprechung**.

    > [!TIP]
    > Sie können dies auch aus der Aktivitätenliste in der Kalender- oder Firmenansicht tun.

## Die Stufe "Angebot"

1. Alle Folgeaufgaben und Dokumente der Stufe **Interessephase** wurden abgeschlossen, und Sie möchten zur nächsten Stufe im Verkaufsleitfaden wechseln.

    1. Klicken Sie auf <i class="ph ph-pencil-simple" aria-label="Bearbeiten"></i> auf der Hauptkarte **Verkauf**.
    2. Klicken Sie auf den Pfeil neben dem Feld **Stufe** und wählen Sie **Angebot** aus der Liste aus.
    3. Klicken Sie auf **Speichern**.
        Die Folgeaufgaben und Dokumente für diese neue Stufe werden nun in der Bereichsregisterkarte **Verkaufsleitfaden** angezeigt.

    > [!TIP]
    > Sie können auch mit der rechten Maustaste auf die Schaltfläche **Angebot** in der Bereichsregisterkarte **Verkaufsleitfaden** klicken und **Zu dieser Stufe wechseln** auswählen.

2. Sie möchten eine Aufgabe in Ihrem Kalender erstellen, um Sie daran zu erinnern, dass Sie ein Angebot vorbereiten müssen.

    1. Klicken Sie auf **Erstellen** neben der Folgeaufgabe **Angebotsvorbereitung**.
        Das Dialogfeld **Folgeaufgabe** wird geöffnet, wobei **Folgeaufgabe** bereits als Aufgabentyp ausgewählt ist.
    2. Vervollständigen Sie die Angaben.
    3. Klicken Sie auf **Speichern**.
    4. Nachdem Sie das Angebot vorbereitet haben, markieren Sie die Aktivität als **Abgeschlossen**.

3. Nun möchten Sie das Angebot für die Firma erstellen.

    Klicken Sie auf **Erstellen** neben dem Dokument **Angebot** und [erstellen Sie das Dokument][3].

## Die Stufe "Vertragsunterzeichnung"

1. Nachdem alle Folgeaufgaben und Dokumente, die Sie in der Stufe **Angebot** verwenden möchten, abgeschlossen sind, wechseln Sie zur letzten Stufe im Verkaufsleitfaden: **Vertragsunterzeichnung**.

    1. Klicken Sie auf <i class="ph ph-pencil-simple" aria-label="Bearbeiten"></i> auf der Hauptkarte **Verkauf**.
    2. Klicken Sie auf den Pfeil neben dem Feld **Stufe** und wählen Sie **Vertragsunterzeichnung** aus der Liste aus.
    3. Klicken Sie auf **Speichern**.
        Die Folgeaufgaben und Dokumente für diese Stufe werden nun in der Bereichsregisterkarte **Verkaufsleitfaden** angezeigt.

2. Sie möchten die erste Folgeaufgabe dieser Stufe erstellen und durchführen.

    1. Klicken Sie auf **Erstellen** neben **Einberufung einer Vertragsbesprechung** und erstellen Sie das Telefongespräch auf die übliche Weise.

    2. Markieren Sie nach Abschluss des Anrufs das Kontrollkästchen.

    3. Das Dialogfeld **Verkaufsleitfaden** bietet Ihnen drei Optionen:

        * Klicken Sie auf **Erstellen**, um die Folgeaufgabe **Vertragsbesprechung** zu erstellen. Dies führt Sie direkt zum Dialogfeld **Folgeaufgaben**.

        * Klicken Sie auf **Abbrechen**, wenn Sie die Folgeaufgabe später erstellen möchten. Das Dialogfeld **Verkaufsleitfaden** wird geschlossen.

        * Aktivieren Sie **Immer Folgeaufgabe erstellen? Diesen Dialog nicht mehr anzeigen**, wenn zukünftige vorgeschlagene Folgeaufgaben automatisch erstellt werden sollen.

    > [!NOTE]
    > Das Dialogfeld **Verkaufsleitfaden** wird geöffnet, weil die Option **Diese Folgeaufgabe automatisch vorschlagen** für die Folgeaufgabe **Vertragsbesprechung** in Einstellungen und Verwaltung aktiviert ist.

3. Sie möchten die **Vertragsbesprechung**-Folgeaufgabe aus dem Dialogfeld **Verkaufsleitfaden** erstellen.

    Klicken Sie auf **Erstellen** im Dialogfeld **Verkaufsleitfaden**.
    Das Dialogfeld **Folgeaufgabe** wird geöffnet, wo Sie das Meeting wie gewohnt erstellen können.

4. Anschließend möchten Sie den Vertrag für die Besprechung erstellen.

    1. Klicken Sie auf **Erstellen** neben dem Dokument **Unterschriebener Vertrag**, um den Vertrag zu erstellen.
    2. Nach der Vertragsbesprechung und der Unterzeichnung des Vertrags markieren Sie die Folgeaufgabe **Vertragsbesprechung** als abgeschlossen.

Nun können Sie die Stufe auf **Verkauft** ändern. Nachdem alle erforderlichen Folgeaufgaben und Dokumente für den Verkauf abgeschlossen wurden, können Sie den Verkaufsstatus auf **Abgeschlossen** setzen.

> [!TIP]
> Wenn der Verkauf weiterhin in der Bereichsregisterkarte **Aktivitäten** der Verkaufsansicht oder in der Bereichsregisterkarte **Verkäufe** der Kalenderansicht sichtbar bleiben soll, darf er nicht als abgeschlossen markiert werden.

## Verwandte Inhalte

* [Verkaufsleitfaden in Einstellungen und Verwaltung einrichten][4]

<!-- Referenced links -->
[1]: ../../diary/learn/invitation/add-attendee.md
[3]: ../../document/learn/edit.md
[4]: ../admin/create-sales-guide.md
