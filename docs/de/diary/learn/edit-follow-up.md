---
uid: help-de-follow-up-edit
title: Folgeaufgaben bearbeiten
description: Folgeaufgaben öffnen, bearbeiten, aus dem Kalender löschen; Endzeitpunkt für eine Folgeaufgabe im Kalender ändern; Einladung bearbeiten oder löschen
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: Kalender, Folgeaufgabe, Einladung, Termin, Aufgabe, Anruf, Wiederholen, Wiederkehren, Instanz
so.topic: howto
language: de
---

# Folgeaufgabe bearbeiten

[!include[Note](includes/note-edit-followup.md)]

Wenn Sie die Zeit, Datum oder Ort einer Folgeaufgabe bearbeiten - oder eine erstellte und gesendete Einladung löschen - werden die Eingeladenen mit einer Mitteilung darüber verständigt.

## Schritte

1. Öffnen Sie die gewünschte Folgeaufgabe, indem Sie darauf doppelklicken:

    * Auf die Bereichsregisterkarte **Aktivitäten** in der Ansicht Firma, Person, Verkauf, Projekt, Kalender.
    * Auf den verschiedenen Registerkarten der Ansicht Kalender.

2. [Nehmen Sie im Dialogfeld die gewünschten Änderungen vor.][3]

    [!include[Recurrence](includes/note-repetition.md)]

3. Klicken Sie auf **Speichern**.

> [!NOTE]
> Erledigte Folgeaufgaben können Sie nur bearbeiten, wenn Sie den Status **Erledigt** deaktivieren.

## <a id="change-end" />Endzeitpunkt für eine Folgeaufgabe im Kalender ändern

Sie können die Endzeitpunkt einer Folgeaufgabe in der Ansicht Kalender ändern, ohne die Aufgabe vorher zu öffnen:

1. Klicken Sie auf der Registerkarte **Tag**, **Woche** oder **Übersicht** auf die Folgeaufgabe.

2. Zeigen Sie mit dem Mauszeiger auf die untere Linie der Folgeaufgabe. Der Zeiger wird nun als Doppelpfeil angezeigt.

3. Klicken Sie auf die Linie und halten Sie die Maustaste gedrückt, während Sie die blaue Linie nach oben oder unten ziehen, um die Zeit für die Folgeaufgabe zu erhöhen oder reduzieren. Sie können die Endzeit für die Folgeaufgabe oben im blauen Bereich sehen.

4. Lassen Sie die Maustaste los. Die Zeit für die Folgeaufgabe ist nun ändert.

> [!NOTE]
> Sie können auch das Zeitfenster ändern, indem Sie die Folgeaufgabe öffnen und die Felder **Start**, **Ende**, **Fällig** oder **Dauer** ändern.

## <a id="repeat" />Regelmäßige Folgeaufgabe bearbeiten

Änderungen werden auf dieselbe Weise ausgeführt wie Folgeaufgaben bearbeiten. Wenn Sie die Änderungen vornehmen, wird das Dialogfeld **Regelmäßige Folgeaufgaben**.

![Repeating follow-up dialog -screenshot][img1]

* Wenn Sie **Nur diese Instanz ändern** wählen, wirkt sich die Änderung nur auf diese Instanz der Folgeaufgabe aus.

* Wenn Sie **Alle zukünftigen Instanzen einschließlich dieser ändern** wählen, gelten die Änderungen auch für alle Wiederholungen dieser Folgeaufgabe.

Sie können nur das Startdatum für die Folgeaufgabe ändern, wenn Sie die Wiederholungsdetails anzeigen. Um die Uhrzeit zu ändern, klicken Sie auf **OK** oder **Abbrechen**, um zu den Details der Nachverfolgung zurückzukehren.

Wenn Sie sich entscheiden, die Regel mitten in einer Serie von Besprechungen zu ändern, wird eine neue Regel erstellt, und die alte Regel wird an dem Punkt gestoppt, an dem die Änderung erfolgt.

Wenn Sie die Startzeit für ein einzelnes Besprechung ändern, bleibt die Regel unberührt. Der Besprechungen wird als Ausnahme von der Regel behandelt. Die Ausnahme kann wieder in Übereinstimmung mit den anderen Besprechungen gebracht werden.

[!include[Caution](includes/caution-do-not-change-recurring-date.md)]

## <a id="delete" />Folgeaufgabe aus dem Kalender löschen

* Wenn Sie eine Folgeaufgabe löschen, zu der Sie eingeladen sind, wird die Folgeaufgabe nur aus Ihrem Kalender entfernt.
* Wenn Sie eine Einladung, deren Eigentümer Sie sind, von Ihrem Kalender löschen, verschwindet diese Folgeaufgabe auch aus den Kalendern der Eingeladenen.

1. Wählen Sie die gewünschte Folgeaufgabe aus.
2. Klicken Sie mit der rechten Maustaste, und wählen Sie **Löschen**.
3. Bestätigen oder brechen Sie den Löschvorgang im Dialogfeld Bestätigung ab.

[!include[Deleting items](../../learn/includes/tip-deletion.md)]

## Verwandte Themen

* [Status Abgeschlossen für eine Aktivität ändern][2]
* [Regelmäßige Folgeaufgaben stoppen][5]

<!-- Referenced links -->
[2]: change-completed-status.md
[3]: create-follow-up.md#fields
[5]: recurrence/stop.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/diary/change-repeating-fo.png
