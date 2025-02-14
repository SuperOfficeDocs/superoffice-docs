---
uid: help-de-follow-up-edit
title: Folgeaufgabe bearbeiten
description: So öffnen, bearbeiten oder löschen Sie eine Folgeaufgabe. Ändern Sie die Endzeit einer Folgeaufgabe im Kalender. Einladung bearbeiten oder löschen. Wiederkehrende Folgeaufgabe bearbeiten.
keywords: Folgeaufgabe bearbeiten, Folgeaufgabe aktualisieren, Meeting verlängern, Meeting verkürzen, nur diese Instanz ändern, Folgeaufgabe löschen, Meeting absagen, Kalender, Folgeaufgabe, Termin, Meeting, Aufgabe, To-do, Anruf, Einladung
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
topic: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Folgeaufgabe bearbeiten

[!include[Note](includes/note-edit-followup.md)]

Wenn Sie die Zeit, das Datum oder den Ort einer Folgeaufgabe ändern – oder eine Einladung löschen, die Sie erstellt und gesendet haben – erhalten die eingeladenen Teilnehmer eine Benachrichtigung darüber.

## Schritte

1. Öffnen Sie eine vorhandene Folgeaufgabe, indem Sie darauf doppelklicken:

    * In der Bereichsregisterkarte **Aktivitäten** in der Ansicht Firma, Person, Kalender, Projekt oder Verkauf.
    * Oder, auf den verschiedenen Registerkarten in der Kalenderansicht.

2. [Nehmen Sie die gewünschten Änderungen im Dialogfeld vor.][3]

    [!include[Recurrence](includes/note-repetition.md)]

3. Klicken Sie auf **Speichern**.

> [!NOTE]
> Sie können erledigte Folgeaufgaben erst bearbeiten, wenn Sie den Status **Abgeschlossen** deaktiviert haben.

## <a id="change-end"></a>Endzeitpunkt für eine Folgeaufgabe im Kalender ändern

In der Kalenderansicht können Sie die Endzeit einer Folgeaufgabe ändern, ohne sie zu öffnen:

1. Klicken Sie auf die Folgeaufgabe in der **Tag**-, **Woche**- oder **Übersicht**-Registerkarte.

1. Bewegen Sie den Mauszeiger über den unteren Rand der Folgeaufgabe. Der Zeiger ändert sich in einen Doppelpfeil.

1. Klicken und halten Sie die Maustaste, dann ziehen Sie den unteren Rand nach oben oder unten, um die Dauer der Folgeaufgabe anzupassen. Die aktualisierte Endzeit wird während des Ziehens angezeigt.

1. Lassen Sie die Maustaste los, um die Änderung zu übernehmen.

> [!NOTE]
> Sie können die Zeit auch ändern, indem Sie die Folgeaufgabe öffnen und die Felder **Start**, **Ende**, **Fällig** oder **Dauer** anpassen.

## <a id="repeat"></a>Regelmäßige Folgeaufgabe bearbeiten

Änderungen funktionieren genauso wie bei regulären Folgeaufgaben, aber wenn Sie eine Änderung vornehmen, wird das Dialogfeld **Regelmäßige Folgeaufgabe** angezeigt.

![Dialogfeld Regelmäßige Folgeaufgabe -screenshot][img1]

* Wenn Sie **Nur diese Instanz ändern** wählen, wirkt sich die Änderung nur auf diese einzelne Folgeaufgabe aus.

* Wenn Sie **Alle zukünftigen Instanzen einschließlich dieser ändern** wählen, gilt die Änderung für diese und alle zukünftigen Wiederholungen der Folgeaufgabe.

Sie können nur das Startdatum der Folgeaufgabe ändern, wenn Sie die Wiederholungsdetails anzeigen. Um die Uhrzeit zu ändern, klicken Sie auf **OK** oder **Abbrechen**, um zu den Folgeaufgabendetails zurückzukehren.

Wenn Sie die Regel mitten in einer Serie ändern, wird eine neue Regel erstellt, und die alte Regel wird an dem Punkt gestoppt, an dem die Änderung vorgenommen wurde.

Wenn Sie die Startzeit für eine einzelne Instanz ändern, bleibt die Regel unberührt. Die Folgeaufgabe wird als Ausnahme behandelt. Sie können die Ausnahme aufheben, indem Sie sie wieder an die ursprüngliche Serie angleichen.

[!include[Caution](includes/caution-do-not-change-recurring-date.md)]

## <a id="delete"></a>Folgeaufgabe aus dem Kalender löschen

* Wenn Sie eine Folgeaufgabe löschen, zu der Sie eingeladen sind, wird die Folgeaufgabe nur aus Ihrem Kalender entfernt.
* Wenn Sie eine Einladung löschen, deren Eigentümer Sie sind, wird diese Folgeaufgabe auch aus den Kalendern der eingeladenen Teilnehmer entfernt.

1. Wählen Sie die gewünschte Folgeaufgabe aus.
1. Klicken Sie mit der rechten Maustaste und wählen Sie **Löschen**.
1. Wählen Sie **Ja**, um die Löschung zu bestätigen, oder **Nein**, um die Folgeaufgabe beizubehalten.

[!include[Deleting items](../../learn/includes/tip-deletion.md)]

## Verwandte Inhalte

* [Status Abgeschlossen für eine Aktivität ändern][2]
* [Regelmäßige Folgeaufgabe stoppen][5]
* [Link zu Dokument, Verkauf, Projekt oder Webseite hinzufügen][6]

<!-- Referenced links -->
[2]: change-completed-status.md
[3]: create-follow-up.md#fields
[5]: recurrence/stop.md
[6]: ../../learn/basics/links.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/diary/change-repeating-fo.png
