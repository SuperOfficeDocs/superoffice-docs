---
uid: help-de-follow-up-create
title: "Folgeaufgaben hinzufügen"
description: "Folgeaufgaben hinzufügen oder kopieren"
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: Kalender, Folgeaufgabe, Anruf, Telefon, Besprechung
so.topic: howto
language: de
---

# Folgeaufgaben hinzufügen

Durch das Erstellen von Folgeaufgaben und das Planen aller Besprechungen und Aktivitäten in Ihrem SuperOffice-Kalender haben Sie immer einen vollständigen Überblick über das Geschehen, können einen solide Kommunikationsverlauf aufbauen und Ihre Kollegen auf dem Laufenden halten.

## Schritte

Sie haben viele Möglichkeiten, eine Folgeaufgaben zu erstellen. Diese Methode funktioniert von überall in SuperOffice CRM und für alle Arten von Folgeaufgaben.

1. Klicken Sie auf **Neu** auf der oberen Leiste und wählen Sie **Besprechung/Termin**, **Folgeaufgab/Anruf** oder **Zu erledigen/Aufgabe** aus.

2. [Geben Sie die erforderlichen Informationen in das Feld ein.](#fields)

    Einige Informationen werden automatisch basierend auf dem Kontext eingefügt, zum Beispiel das heutige Datum.

3. Klicken Sie auf die Schaltfläche **Aufgabe**.

**Andere Möglichkeiten:**

| Ausgangspunkt | Besprechung (Termin) | Folgeaufgabe (Anruf) | Zu erledigen (Aufgabe) |
|---|---|---|---|
| Bereichsregisterkarte Aktivitäten | x | x | x |
| Schaltfläche Aufgabe in der Personenkarte | x | x | |
| Kalender | x | | |

### <a id="fields" />Wie Informationen eingegeben werden

> [!NOTE]
> Viele Felder haben eine Liste von vordefinierten Werten, aus denen Sie wählen können. Klicken Sie auf den Pfeil ![Symbol][img4], um die Liste zu erweitern. Wählen Sie dann einen Wert für dieses Feld. Alternativ können Sie im Feld mit der Eingabe beginnen, um nach einem bestimmten Wert zu suchen, wie zum Beispiel einem Firmennamen.

Wenn Ihre SuperOffice [Zeitzonen][9] aktiviert hat, können Sie auswählen, in welcher Zeitzone die Folgeaufgabe erstellt werden soll. Die Zeitzonen werden nach Ländern angezeigt, und Sie können sowohl nach Land als auch direkt nach Stadt im Zeitzonenfeld suchen.

Wenn Sie **Ganztägig** aktivieren, wird die Zeit der Folgeaufgabe auf den als [Standard-Arbeitstag][8] festgelegten Zeitraum eingestellt (Voreinstellung für **Startzeit ganztägig** und **Endzeit ganztägig**).

<!-- markdownlint-disable MD051 -->
#### [Klassisch](#tab/fields-old)

![Termin-Dialogfeld -screenshot][img6]

* Wählen Sie den Typ der Folgeaufgabe aus.

* Optional können Sie ein Unternehmen und/oder einen Kontakt auswählen, auf den sich die Folgeaufgabe bezieht.

* Optional können Sie ein Projekt und/oder einen Verkauf auswählen, um es mit der Folgeaufgabe zu verknüpfen. Sie können jedes Projekt/Verkauf auswählen, unabhängig davon, welches Unternehmen Sie zuvor ausgewählt haben.

* Geben Sie Zeit und Datum an. Das Feld **Dauer** wird automatisch angepasst.

    Wenn die neue Folgeaufgabe mit einer bestehenden Folgeaufgabe überlappt, wird ein Ausrufezeichen ![Symbol][img2] neben den Start- und Stoppfeldern als Erinnerung angezeigt (Sie können die Folgeaufgabe dennoch hinzufügen). Ein Vorschlag für den ersten verfügbaren Zeitpunkt wird angezeigt. Klicken Sie auf die vorgeschlagene Zeit rechts von **Zuerst verfügbar**, um stattdessen diese Zeit auszuwählen.

    Wenn Sie eine neue Aufgabe erstellen, wird keine Zeit in den Feldern **Start** und **Fällig** angezeigt. Das heutige Datum wird automatisch eingefügt, Sie können es jedoch auf das erforderliche Datum ändern. Das Datum gibt den Termin für die Aufgabe an.

* Optional können Sie die Adresse auswählen oder eingeben, an der die Folgeaufgabe stattfinden wird.

* Wählen Sie den Tab **Beschreibung**, um eine Beschreibung der Folgeaufgabe hinzuzufügen (maximal 2048 Zeichen).
* Wählen Sie den Tab **Details**, um [Wiederholung][4], Priorität, [Alarm][3], Eigentümer und "als anzeigen" festzulegen.
* Wählen Sie den Tab **Teilnehmer**, um [Teilnehmer hinzuzufügen][5].

> [!TIP]
> Klicken Sie auf ![Symbol][img5], um ein [Videotreffen][2] einzurichten.

#### [Neu (ab Version 10.2.11 Pilot)](#tab/fields-new)

![Folgeaufgabesdialog -screenshot][img7]

* Geben Sie einen Titel ein.

* Klicken Sie auf den farbigen Ball und wählen Sie einen Folgeaufgabestyp aus.

* Optional können Sie ein Unternehmen oder einen Kontakt auswählen, auf den sich die Folgeaufgabe bezieht. Wenn Sie sie und andere zu Ihrem Meeting einladen möchten, klicken Sie auf **Einladen**.

  * [Teilnehmer hinzufügen][5].
  * Optional, fügen Sie Räume, Standorte oder Ressourcen hinzu.
  * Optional, fügen Sie eine Adresse hinzu.

    ![Erweiterter Folgeaufgabesdialog -screenshot][img8]

* Geben Sie Zeit und Datum an. Klicken Sie auf **Mehr anzeigen**, um [Wiederholung][4], "ganztägig", "beschäftigt/frei" und Zeitzoneneinstellungen vorzunehmen. Klicken Sie auf das Glockensymbol in der Kopfzeile, um [den Alarm einzustellen][3].

* Optional, wählen Sie ein Projekt und/oder Verkauf aus, um es mit der Folgeaufgabe zu verknüpfen. Sie können jedes Projekt/Verkauf auswählen, unabhängig davon, welches Unternehmen Sie zuvor ausgewählt haben.

* Wählen Sie den Tab **Agenda**, um zusätzliche Informationen hinzuzufügen, wie z.B. eine Agenda, eine Beschreibung der Folgeaufgabe, Dateien, Bilder und Links. Verwenden Sie die Schaltflächen in der Fußzeile, um Rich-Text-Formatierung und Inhalt hinzuzufügen.

    > [!TIP]
    > Wenn Sie den Zugriff auf Mitarbeiter beschränken möchten, platzieren Sie diesen Inhalt im Tab **Interne Notizen**. Alles, was hier hinzugefügt wird, wird nicht an externe Teilnehmer gesendet. Klicken Sie auf das Uhrsymbol, um einen Zeitstempel hinzuzufügen. Ein Punkt auf dem Tab zeigt an, dass jemand eine Notiz hinzugefügt hat.

***
<!-- markdownlint-restore -->

## Folgeaufgaben in der Bereichsregisterkarte Aktivitäten erstellen

* Klicken Sie auf den Bereichsregisterkarten auf die Schaltfläche **Hinzufügen**.

* Oder, doppelklicken Sie hierfür auf eine leere Zeile unter der letzten Aktivität in der Liste. Wenn unten in der Aktivitätenliste keine leere Zeile angezeigt wird, können Sie die Liste wie folgt erweitern: Platzieren Sie den Mauszeiger zwischen den Bereichsregisterkarten und der Karte darüber. Der Zeiger wird nun als Doppelpfeil angezeigt. Klicken Sie auf die Linie, und ziehen Sie sie bei gedrückter Maustaste nach oben, bis am unteren Rand der Aktivitätenliste weitere leere Zeilen angezeigt werden.

> [!NOTE]
> Sobald Sie einer Folgeaufgabe, die Sie innerhalb der Aktivitätenliste erstellen, eine Uhrzeit oder eine Dauer zuweisen, wird die Folgeaufgabe im Kalender eingetragen.

## Folgeaufgaben erstellen mit der Schaltfläche Aufgabe

1. Klicken Sie auf das ![Symbol][img3] der Schaltfläche **Aufgabe** in der Personenkarte.

    * Um eine Besprechung zu erstellen, wählen Sie **Besprechung anfordern**.

    * Um einen Anruf zu erfassen, wählen Sie **Anrufen**.

1. Geben Sie die erforderlichen Informationen in das Feld ein und klicken Sie auf **Speichern**.

## Einen Besprechung von der Ansicht Kalender erstellen

* **Um eine Zeit auszuwählen:** Klicken Sie auf den Zeitpunkt für den Beginn der Folgeaufgabe, und halten Sie die Maustaste gedrückt, während Sie die Maus auf die gewünschte Endzeit für die Aufgabe ziehen. Während der Definition des Zeitraums wird ein blauer Bereich angezeigt, bevor sich die Folgeaufgaben öffnen.

* **Um die Standarddauer zu verwenden:** Doppelklicken Sie auf einen Zeitraum im Kalender. Oder, klicken Sie mit der rechten Maustaste auf eine Uhrzeit im Kalender und wählen Sie **Neu**.

> [!NOTE]
> Wenn Sie die Besprechung von der Registerkarte **Ansicht** erstellen, können Sie wählen, ob Teilnehmern automatisch mit den Mitgliedern der Ansicht befüllt werden soll. Wenn Sie diese Option einstellen möchten, gehen Sie zum ![Symbol][img1] **Persönliche Einstellungen** > **Einstellungen** > **Funktionen** und stellen Sie die Einstellung **Teilnehmer aus Gruppenansicht** auf **Ja**. Klicken Sie auf **Speichern**.

### <a id="associate" />Besprechung für einen Mitarbeiter erstellen

Sie können den Kalender anderer Benutzer oder einer verfügbaren Ressource öffnen, ihre Verfügbarkeit zu überprüfen oder Folgeaufgaben für sie zu erstellen.

1. Klicken Sie in der Ansicht Kalender auf die Registerkarte Anzeigen.

2. Klicken Sie der Liste der Kalendereigentümer und wahlen Sie den Kalender der betreffenden Person aus.

3. Führen Sie mithilfe der Maus die Option Neuen Besprechung erstellen in diesem Kalender aus.

4. In dialogfeld **Folgeaufgabe**, [geben Sie die erforderlichen Informationen in das Feld ein](#fields).

5. Führen Sie die Option [Einzubeziehende Teilnehmer auswählen][5] aus, wenn sie nicht bereits automatisch einbezogen wurden.

6. Klicken Sie auf die Schaltfläche **Speichern**. Die Besprechung wird im Kalender der ausgewählten Person angezeigt.

## <a id="copy" />Folgeaufgabe in den Kalender kopieren

Sie können auch eine neue Folgeaufgabe erstellen, indem Sie eine vorhandene Folgeaufgabe in den Kalender zu einem anderen Zeitpunkt oder Tag kopieren.

1. Öffnen Sie den Kalender und suchen Sie die Folgeaufgabe, die Sie kopieren möchten.

2. Wenn die Folgeaufgabe abgeschlossen ist, klicken Sie mit der rechten Maustaste darauf und wählen Sie **Abgeschlossen**, um die Bearbeitung zu aktivieren. (Denken Sie daran, den Status nach dem Kopieren zurückzusetzen.)

3. Halten Sie die **STRG**-Taste gedrückt, während Sie die Folgeaufgabe an eine andere Zeit ziehen und ablegen.

## Zugehörige Inhalte

* [Termin][1]
* [Aktivitäten][7]
* [Videokonferenz vom SuperOffice-Kalender erstellen][2]

<!-- Referenced links -->
[1]: follow-ups.md
[2]: video-meetings.md
[3]: set-alarm.md
[4]: recurrence/index.md
[5]: invitation/add-participant.md
[7]: ../../learn/basics/activity.md
[8]: ../../learn/getting-started/preferences.md
[9]: ../../globalization-and-localization/learn/time-zones.md

<!-- Referenced images -->
[img1]: ../../../media/icons/personal-settings-small.png
[img3]: ../../../media/icons/btn-menu.png
[img2]: ../../../../common/icons/warning-red.png
[img4]: ../../../../common/icons/dropdown-icon.png
[img5]: ../../../../common/icons/videocall-off.png
[img6]: ../../../media/loc/en/diary/appointment-new.png
[img7]: ../../../media/loc/en/diary/follow-up-dialog.png
[img8]: ../../../media/loc/en/diary/follow-up-attendees.png
