---
uid: help-de-invitation-add-participant
title: Teilnehmer zu Folgeaufgaben hinzufügen
description: "Personen können auf unterschiedliche Weise zu einem Termin eingeladen werden. Diese Anleitung zeigt, wie Sie Teilnehmer zu einem Termin hinzufügen."
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: Kalender, Folgeaufgabe, Einladung, Teilnehmer
so.topic: howto
language: de
---

# Teilnehmer und Ressourcen zu Folgeaufgaben hinzufügen

Wenn Sie eine Folgeaufgabe eintragen, die weitere Personen betrifft, können Sie diese Personen als Teilnehmer an der Folgeaufgabe hinzufügen. Sie können auch ein Konferenzzimmer und Ausrüstungen des Unternehmens reservieren. Personen, die als Teilnehmer verfügbar sind, werden in Einstellungen und Verwaltung definiert.

Sehen Sie sich das Video für [Teilnehmer zu einem Termin hinzufügen][15] an.

## Schritte

> [!NOTE]
> Nur der Besitzer der Foleaufgabe kann Teilnehmer hinzufügen (und entfernen).

<!-- markdownlint-disable MD051 -->
### [Klassisch](#tab/participants)

1. [Öffnen oder erstellen Sie eine Foleaufgabe][3].

    > [!NOTE]
    > Wenn Sie die Übersicht über andere Benutzer oder Ressourcen geöffnet haben, werden sie automatisch als Teilnehmer im Tab **Teilnehmer** eingetragen. Andernfalls wählen Sie sie manuell wie unten beschrieben aus.

2. Öffnen Sie den Tab **Teilnehmer** und klicken Sie auf **Hinzufügen** unten.

3. Wählen Sie im Dialogfeld **Einladung**, aus welchem Bereich Sie die Teilnehmer einladen möchten. Zur Auswahl stehen **Mitarbeiter**, **Firma/Person**, **Projekt**, **Selektion** und **Ressource**.

4. Wählen Sie im Listenfeld direkt unter dem Feld **Auswählen aus** die Benutzergruppe, Firma, Person, Selektion, Ressource oder das Projekt, dessen Teilnehmer Sie einladen möchten. Der Inhalt dieses Listenfelds ändert sich je nach der Auswahl oben.
    * Wenn Sie in Schritt 3 **Mitarbeiter** oder **Ressource** gewählt haben, können Sie im Listenfeld **Alle** wählen, um die Mitarbeiter oder Ressourcen in allen Gruppen anzuzeigen.
    * Wenn Sie in Schritt 3 **Firma/Person**, **Projekt** oder **Selektion** ausgewählt haben, können Sie in diesem Feld nach der gewünschten Firma, der Person, dem Projekt oder der Selektion suchen.

5. Nachdem Sie die gewünschte Quelle ausgewählt haben, wird eine Liste aller für diese Quelle verfügbaren Einträge angezeigt. Wählen Sie die Benutzer oder Ressourcen aus, die in die Folgeaufgabe einbezogen werden sollen, und klicken Sie rechts von der Liste auf die Pfeilschaltfläche ![Symbol][img2]. Die Benutzer oder Ressourcen werden daraufhin im Fenster auf der rechten Seite angezeigt. Sie können Benutzer und Ressourcen auch einzeln auswählen, indem Sie darauf doppelklicken.

    > [!NOTE]
    > Wenn eine Person zum von Ihnen angegebenen Zeitpunkt belegt ist, wird deren Name rot markiert, sodass Sie leicht erkennen können, ob Sie für die Folgeaufgabe eventuell einen anderen Zeitpunkt wählen sollten. Sie können diese Person zu diesem neuen Termin einladen. Daraufhin wird deren Eintrag im Dialogfeld für Folgeaufgaben rot markiert und mit KONFLIKT gekennzeichnet.

6. Klicken Sie auf die Schaltfläche **E-Mail-Einladung**, um E-Mail-Einladungen für alle Teilnehmer in der Liste (außer Ihnen selbst) zu aktivieren. Das ![Symbol][img1] links vom Namen des Teilnehmers gibt an, dass eine E-Mail-Einladung für die Folgeaufgabe an diesen Teilnehmer gesendet wird. Klicken Sie auf das ![Symbol][img1] neben dem Namen eines Teilnehmers, um die E-Mail-Einladung für diesen Teilnehmer zu deaktivieren. Das ![Symbol][img1] wechselt zu inaktiv ![Symbol][img3] und der Teilnehmer wird nicht per E-Mail eingeladen.

    Einladungs-E-Mails, die an externe Kontakte gesendet werden, enthalten eine iCal-Datei (.ics) mit den Einladungsdaten. Wenn sie auf eine Einladung reagieren, wird der Status in SuperOffice automatisch aktualisiert. Die Folgeaufgabe wird auf der Bereichsregisterkarte **Aktivitäten** der betreffenden Firma angezeigt.

7. Klicken Sie auf **OK**, um das Dialogfeld **Einladung** zu schließen. Die ausgewählten Teilnehmer und Ressourcen werden nun in der Registerkarte **Teilnehmer** angezeigt. Sie können auf die Schaltfläche **E-Mail-Einladung** und das ![Symbol][img1] klicken, um E-Mail-Einladungen ähnlich wie im vorherigen Schritt zu aktivieren/deaktivieren.
    Wenn für eine der von Ihnen ausgewählten Personen in SuperOffice CRM keine gültige E-Mail-Adresse gespeichert ist, wechselt das ![Symbol][img1] auf der Registerkarte **Teilnehmer** zu inaktiv ![Symbol][img3].

    > [!NOTE]
    > Wenn Sie Benutzer oder Ressourcen versehentlich ausgewählt haben, wählen Sie sie in der Liste ganz rechts aus und klicken Sie auf **Löschen**, um sie zu entfernen.

8. Klicken Sie nach der Auswahl von Teilnehmern und Ressourcen auf **Speichern**, um Ihre Selektionen zu speichern, oder betätigen Sie die Schaltfläche **Abbrechen**, um das Dialogfeld ohne Speichern zu beenden.

### [Neu (ab Version 10.2.11 Pilot)](#tab/attendees)

1. [Öffnen oder erstellen Sie eine Folgeafugabe][3].

1. Klicken Sie auf die **Einladen**-Schaltfläche. Dadurch wird der Dialog erweitert.

    ![Folgeaufgabedialog, Einladen-Schaltfläche -screenshot][img14]

    ![Folgeaufgabedialog, erweitert -screenshot][img15]

1. Klicken Sie auf das Feld **Teilnehmer hinzufügen**. Wählen Sie dann eine oder mehrere Personen aus der Liste.

    * Beginnen Sie mit dem Schreiben, um nach einer Person in ganz SuperOffice zu suchen.
    * Wählen Sie eine Person aus der Verlaufsliste ![Symbol][img4] oder Ihren Favoriten ![Symbol][img5].
    * Klicken Sie ![Symbol][img6], um nach einem Kollegen zu suchen, oder ![Symbol][img7], um Personen auszuwählen, die mit einem Unternehmen verknüpft sind.
    * Sie können auch Verkaufsinteressenten ![Symbol][img8] und Projektmitglieder ![Symbol][img9] auswählen.

    ![Folgeaufgabedialog, Teilnehmer auswählen -screenshot][img17]

    > [!TIP]
    > Um jemanden einzuladen, der nicht in SuperOffice registriert ist, geben Sie bitte deren vollständige E-Mail-Adresse ein.

    Wenn ein Teilnehmer nicht verfügbar ist, wird ein Ausrufezeichen neben seinem Namen angezeigt. Wählen Sie einen der vorgeschlagenen Zeitfenster aus oder klicken Sie auf **Verfügbarkeit überprüfen**, um eine bessere Zeit zu finden.

    ![Folgeaufgabedialog, hinzugefügte Teilnehmer -screenshot][img16]

1. Optional, fügen Sie Standorte, Räume und/oder Ressourcen hinzu.

1. Optional, wählen Sie **E-Mail-Einladung an Teilnehmer senden** aus. (Dies ändert die Schaltfläche **Speichern** in **Speichern und senden** um.)

1. Klicken Sie auf **Speichern**, um alle Änderungen zu speichern.

***
<!-- markdownlint-restore -->

### <a id="availability" />Terminassistent (nur in der Pilotversion verfügbar)

Der Terminassistent ist Teil des neuen **Folgeaufgabe**-Dialogs. Der detaillierte Kalender zeigt die Verfügbarkeit jedes internen Teilnehmers (Mitarbeiter). Die oberste Reihe zeigt die akkumulierte Verfügbarkeit. Die Verfügbarkeit von externen Teilnehmern und E-Mail-Teilnehmern ist unbekannt.

![Folgeaufgabedialog, Terminassistent -screenshot][img18]

1. Im **Folgeaufabe**-Dialog klicken Sie auf **Verfügbarkeit prüfen.**

1. Klicken Sie und ziehen Sie den Zeiger nach links oder rechts, um eine Besprechungszeit auszuwählen. Zum Beispiel von 13.30 bis 15:00, wie in diesem Bildschirmfoto grün dargestellt. Verwenden Sie die Scrollleiste, um zwischen den Tagen zu wechseln.

    Alternativ können Sie das ausgewählte Datum und die Uhrzeit oben im Dialog aktualisieren.

1. Optional, fügen Sie Teilnehmer und Ressourcen hinzu oder entfernen Sie sie. Überlegen Sie, die Zeit erneut anzupassen, wenn es zu Konflikten kommt.

1. Klicken Sie auf **OK**, wenn Sie fertig sind.
1. Klicken Sie auf **Speichern**, um alle Änderungen zu speichern.

### <a id="preview" />Vorschau und Aktualisierung der Einladungs-E-Mail (nur in Pilotversion)

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

## Zugehörige Inhalte

* [Erstellen von Terminen][3]
* [An Videokonferenz teilnehmen][4]

<!-- Referenced links -->
[1]: index.md#status
[3]: ../create-follow-up.md
[4]: ../video-meetings.md
[5]: accept-decline.md
[15]: https://community.superoffice.com/globalassets/user--admin/learning/user-guide/diary--appointments/add-contact-to-appointment.mp4

<!-- Referenced images -->
[img1]: ../../../../../common/icons/pref-email.png
[img2]: ../../../../media/icons/arrow-right.png
[img3]: ../../../../media/icons/email-inactive.png
[img4]: ../../../../../common/icons/history-icon.png
[img5]: ../../../../../common/icons/favourite-icon.png
[img6]: ../../../../../common/icons/personblack.png
[img7]: ../../../../../common/icons/singlecolour/contact.png
[img8]: ../../../../../common/icons/sale.png
[img9]: ../../../../../common/icons/singlecolour/project.png
[img13]: ../../../../media/loc/en/diary/preview-invitation.png
[img14]: ../../../../media/loc/en/diary/invite.png
[img15]: ../../../../media/loc/en/diary/large-follow-up-dialog.png
[img16]: ../../../../media/loc/en/diary/attendees-added.png
[img17]: ../../../../media/loc/en/diary/follow-up-attendees.png
[img18]: ../../../../media/loc/en/diary/schedule-associate-ext-email.png
