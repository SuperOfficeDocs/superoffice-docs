---
uid: help-de-invitation-add-attendee
title: Teilnehmer zu Folgeaufgaben hinzufügen
description: Personen können auf unterschiedliche Weise zu einem Termin eingeladen werden. Diese Anleitung zeigt, wie Sie Teilnehmer zu einem Termin hinzufügen.
keywords: Teilnehmer einladen, Person einladen, Kollege einladen, Teilnehmer hinzufügen, Ressource hinzufügen, Kalender, Folgeaufgabe, Einladung, Teilnehmer, Besprechung
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
topic: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Teilnehmer und Ressourcen zu Folgeaufgaben hinzufügen

Wenn Sie eine Folgeaufgabe eintragen, die weitere Personen betrifft, können Sie diese Personen als Teilnehmer an der Folgeaufgabe hinzufügen. Sie können auch ein Konferenzzimmer und Ausrüstungen des Unternehmens reservieren. Personen, die als Teilnehmer verfügbar sind, werden in Einstellungen und Verwaltung definiert.

## Schritte

> [!NOTE]
> Nur der Besitzer der Foleaufgabe kann Teilnehmer hinzufügen (und entfernen).

1. [Öffnen oder erstellen Sie eine Folgeafugabe][3].

1. Klicken Sie auf die **Einladen**-Schaltfläche. Dadurch wird der Dialog erweitert.

    ![Folgeaufgabedialog, Einladen-Schaltfläche -screenshot][img14]

    ![Folgeaufgabedialog, erweitert -screenshot][img15]

1. Klicken Sie auf das Feld **Teilnehmer hinzufügen**. Wählen Sie dann eine oder mehrere Personen aus der Liste.

    * Beginnen Sie mit dem Schreiben, um nach einer Person in ganz SuperOffice zu suchen.
    * Wählen Sie eine Person aus der Verlaufsliste (<i class="ph ph-clock" aria-hidden="true"></i>) oder Ihren Favoriten (<i class="ph ph-star" aria-hidden="true"></i>).
    * Klicken Sie <i class="ph ph-users" aria-label="Group icon"></i>, um nach einem Kollegen zu suchen, oder <i class="ph ph-buildings" aria-label="Company icon"></i>, um Personen auszuwählen, die mit einem Unternehmen verknüpft sind.
    * Sie können auch Verkaufsinteressenten (<i class="ph ph-currency-circle-dollar" aria-hidden="true"></i>) und Projektmitglieder (<i class="ph ph-clipboard-text" aria-hidden="true"></i>) auswählen.

    ![Folgeaufgabedialog, Teilnehmer auswählen -screenshot][img17]

    > [!TIP]
    > Um jemanden einzuladen, der nicht in SuperOffice registriert ist, geben Sie bitte deren vollständige E-Mail-Adresse ein.

    Wenn ein Teilnehmer nicht verfügbar ist, wird ein Ausrufezeichen neben seinem Namen angezeigt. Wählen Sie einen der vorgeschlagenen Zeitfenster aus oder klicken Sie auf **Verfügbarkeit überprüfen**, um eine bessere Zeit zu finden.

    ![Folgeaufgabedialog, hinzugefügte Teilnehmer -screenshot][img16]

1. Optional, fügen Sie Standorte, Räume und/oder Ressourcen hinzu.

1. Optional, wählen Sie **E-Mail-Einladung an Teilnehmer senden** aus. (Dies ändert die Schaltfläche **Speichern** in **Speichern und senden** um.)

1. Klicken Sie auf **Speichern**, um alle Änderungen zu speichern.

### <a id="availability"></a>Terminassistent

Der Terminassistent ist Teil den **Folgeaufgabe**-Dialog. Der detaillierte Kalender zeigt die Verfügbarkeit jedes internen Teilnehmers (Mitarbeiter). Die oberste Reihe zeigt die akkumulierte Verfügbarkeit. Die Verfügbarkeit von externen Teilnehmern und E-Mail-Teilnehmern ist unbekannt.

![Folgeaufgabedialog, Terminassistent -screenshot][img18]

1. Im **Folgeaufabe**-Dialog klicken Sie auf **Verfügbarkeit prüfen.**

1. Klicken Sie und ziehen Sie den Zeiger nach links oder rechts, um eine Besprechungszeit auszuwählen. Zum Beispiel von 13.30 bis 15:00, wie in diesem Bildschirmfoto grün dargestellt. Verwenden Sie die Scrollleiste, um zwischen den Tagen zu wechseln.

    Alternativ können Sie das ausgewählte Datum und die Uhrzeit oben im Dialog aktualisieren.

1. Optional, fügen Sie Teilnehmer und Ressourcen hinzu oder entfernen Sie sie. Überlegen Sie, die Zeit erneut anzupassen, wenn es zu Konflikten kommt.

1. Klicken Sie auf **OK**, wenn Sie fertig sind.
1. Klicken Sie auf **Speichern**, um alle Änderungen zu speichern.

### <a id="preview"></a>Vorschau und Aktualisierung der Einladungs-E-Mail

Wenn Sie auf **Speichern und senden** klicken, wird eine Vorschau der E-Mail basierend auf dem Titel und der Agenda angezeigt. Alle internen Notizen, die der Folgeaufgabe hinzugefügt wurden, sind ausgeschlossen.

![Folgeaufgabedialog, Vorschau der E-Mail-Einladung -screenshot][img13]

1. Aktualisieren Sie den Betreff und den Text der E-Mail nach Bedarf. Verwenden Sie die Rich-Text-Symbolleiste am unteren Rand, um Ihre Einladung zu gestalten.

    > [!NOTE]
    > Alle Änderungen, die in der Vorschau vorgenommen werden, werden **nicht** zurück in die Folgeaufgabe gespeichert.
1. Wenn Sie bereit sind, klicken Sie auf **Senden**.

## Was passiert als nächstes

1. Wenn Sie die Folgeaufgaben speichern, [erhält die andere Person eine Benachrichtigung][5].

2. Wenn die andere Person die Einladung ablehnt, erhalten Sie eine Einladung abgelehnt-Benachrichtigung. Klicken Sie auf **Alles klar**, um dies zu bestätigen.

3. Optional können Sie eine neue geeignete Zeit finden und die Folgeaufgabe neu planen.

### Eine externe Person die Einladung akzeptiert oder abgelehnt hat

Externe Teilnehmer werden per E-Mail benachrichtigt (wenn Sie diese Alternative ausgewählt haben). Einladungs-E-Mails, die an externe Kontakte gesendet werden, enthalten eine iCal-Datei (.ics) mit den Einladungsdaten. Wenn sie auf eine Einladung reagieren, wird der [Status][1] in SuperOffice automatisch aktualisiert.

Wenn Sie eine Einladung im Namen einer anderen Person manuell akzeptieren oder ablehnen wollen, wählen Sie den Namen in der Liste aus und klicken einmal auf die Schaltfläche **Status ein-/ausblenden**, um ein grünes Häkchen einzufügen. Klicken Sie zweimal, um ein rotes Kreuz einzufügen, wenn die Einladung abgelehnt werden soll.

## Fehlerbehebung

### Warum passiert nichts, wenn ich auf E-Mail-Einladung klicke?

Falls für die ausgewählte Person keine gültige E-Mail-Adresse in SuperOffice CRM registriert wurde, hat das Klicken auf **E-Mail-Einladung** keine Wirkung.

### Warum ist die Schaltfläche E-Mail-Einladung deaktiviert?

Verwendung der SuperOffice-E-Mail: Wenn Sie die erforderlichen Informationen nicht in der Ansicht **Einloggen** eingegeben haben, die angezeigt wird, wenn Sie in SuperOffice CRM zum ersten Mal auf die Schaltfläche **Posteingang** anklicken, wird die Schaltfläche **E-Mail-Einladung** deaktiviert.

## Verwandte Inhalte

* [Erstellen von Terminen][3]
* [An Videokonferenz teilnehmen][4]

<!-- Referenced links -->
[1]: index.md#status
[3]: ../create-follow-up.md
[4]: ../video-meetings.md
[5]: accept-decline.md

<!-- Referenced images -->
[img13]: ../../../../media/loc/en/diary/preview-invitation.png
[img14]: ../../../../media/loc/en/diary/invite.png
[img15]: ../../../../media/loc/en/diary/large-follow-up-dialog.png
[img16]: ../../../../media/loc/en/diary/attendees-added.png
[img17]: ../../../../media/loc/en/diary/follow-up-attendees.png
[img18]: ../../../../media/loc/en/diary/schedule-associate-ext-email.png
