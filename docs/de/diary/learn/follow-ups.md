---
uid: help-de-follow-ups
title: Folgeaufgaben
description: Folgeaufgaben - Besprechung, Aufgabe, Anruf
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: Kalender, Folgeaufgabe, Termin, Besprechung, Telefon, Anruf, Aufgabe, Zu erledigen
so.topic: concept
language: de
---

# Folgeaufgaben

Eine *Folgeaufgabe* ist die allgemeine Bezeichnung für [Besprechungen](#meeting), und [Aufgaben](#todo). Ein [Telefonanruf](#call) ist eine Mischung aus beidem. Folgeaufgaben sind eng mit der Ansicht Kalender verknüpft. Die Funktionsweise ist bei allen Folgeaufgaben in etwa identisch.

Öffnen Sie eine Folgeaufgabe, indem Sie darauf doppelklicken im Kalender oder auf die Bereichsregisterkarte **Aktivitäten**.

## Allgemeine Informationen

| Symbol | Eigenschaft | Beschreibung |
|:-:|---|---|
| ![Symbol][img9]| Besitzer | Wem die Folgeaufgabe gehört. Der ursprüngliche Ersteller oder die Person, der die Folgeaufgabe zugewiesen/delegiert wurde. |
| ![Symbol][img3]| Titel | Eine beschreibende Bezeichnung. Weitere Details werden in der Agenda erfasst. |
| (ein farbiger Punkt) | Typ | Eine vordefinierte Liste von Aktivitäten wie Meeting (extern) und Telefonat. |
| ![Symbol][img7], ![Symbol][img8] | Firma / Kontakt | Wen die Folgeaufgabe betrifft. |
| ![Symbol][img10]| Zeit und Datum | Wann die Folgeaufgabe beginnt oder ist fällig. |
| ![Symbol][img4]| Wiederholung | Ob und wie sich die Folgeaufgabe wiederholt. |
| (kein Symbol) | Verfügbarkeit | Frei/Belegt. Beeinflusst die Konfliktbehandlung. |
| ![Symbol][img2] | Alarm | Ob und wann die Person benachrichtigt werden soll. |
| ![Symbol][img5] | Verkauf | Ein mit der Folgeaufgabe verknüpfter Verkauf. |
| ![Symbol][img6] | Projekt | Ein mit der Folgeaufgabe verknüpftes Projekt. |

## Neu erstellen

Ungeachtet dessen, wo Sie sich in SuperOffice CRM befinden, können Sie eine neue Folgeaufgabe erstellen, indem Sie auf der oberen Leiste auf die Schaltfläche **Neu** klicken und **Besprechung/Termin**, **Zu erledigen/Aufgabe**, oder **Folgeaufgabe/Anruf** auswählen.

> [!NOTE]
> Folgeaufgabe, die vom Ansicht Kalender aus erstellt werden, sind standardmäßig Besprechungen. Sie können jedoch den Typ ändern, bevor Sie speichern.

## Finden Sie Ihre Folgeaufgaben

In der Ansicht Kalender werden Besprechung und Anrufe auf den Registerkarten **Tag**, **Woche**, **Monat**, und **Ansicht** sowie in den Seitenfeldern **Tag**, **Monat**, **Nächster Tag** und **Woche** angezeigt.

Die Bereichsregisterkarte **Aktivitäten** in der Ansicht Firma, Person, Verkauf, Projekt, Kalender zeigt alle Folgeaufgaben, einschließlich Zu erledigen.

## Folgeaufgabstypen

| Typ | Startzeit | Endzeit | Dauer | Fälligkeitsdatum | Angezeigt in | Beschreibung | Beispiel |
|---|:-:|:-:|:-:|:-:|---|---|---|
| Besprechung (Termin) | &#10003; | &#10003; | Berechnet | | Kalender | Aktivität mit definiertem Start- und Endzeitpunkt | Externes Treffen mit Lieferanten |
| Zu erledigen (Aufgabe) | | | | &#10003; | Aktivitäten Bereich | Nachverfolgung ohne Startzeit | Erinnerung für Aufgaben, die bis zu einer bestimmten Zeit fällig sind |
| Folgeaufgabe (Anruf) | &#10003; | | &#10003; | | Aktivitäten Bereich | Telefonanruf | Eingehender Anruf vom Kunden |

## <a id="meeting" />Besprechung (Termin)

Besprechungen sind Aktivitäten mit einem definierten Anfangs- und Endzeitpunkt. Sie werden im Kalender des Besitzers angezeigt.

Eine Besprechung kann eine einzelne Veranstaltung oder Teil einer wiederkehrenden Serie sein. Besprechungen, die eine Ressource und/oder zusätzliche Teilnehmer einbeziehen, werden als [Einladungen][5] (oder Gruppenreservierungen) bezeichnet.

Überfällige und abgeschlossene Besprechungen werden in der **Aktivitäten**-Registerkarte zusätzlich zur Kalenderansicht angezeigt.

### Übliche Szenarien

| Szenario | Ressource | 2+ Teilnehmer | Beschreibung |
|---|:-:|:-:|---|
| Eigene Zeit reserviert | | | Sie haben Zeit für die alleinige Arbeit reserviert |
| Eigene Zeit und Ressource reserviert | &#10003; | | Wie oben, plus Bedarf an Raum oder Ausrüstung |
| Besprechung mit mehreren Teilnehmern | &#10003; | &#10003; | Eine Besprechung, normalerweise auch mit einer Ressource oder einem Ort |

## <a id="todo" />Zu erledigen (Aufgabe)

Eine *Aufgabe* ist eine Folgeaufgabe ohne Startzeit. Sie hat normalerweise auch keine Dauer, aber immer eine **Frist**. Aufgaben werden typischerweise für Dinge verwendet, die Sie sich merken müssen, bis zu einem bestimmten Zeitpunkt.

Standardmäßig finden Sie Aufgaben in der To-do-Liste dem Kalender, wo sie abgehakt werden können, wenn sie erledigt sind. Wenn Sie einen Anfangs- und Endzeitpunkt für eine Aufgabe angeben, wird er für den betreffenden Tag und die betreffende Zeit im Kalender eingetragen.

## <a id="call" />Folgeaufgabe (Anruf)

Ein *Anruf* repräsentiert eine sehr spezifische Handlung - den Telefonanruf - und ist eine Mischung zwischen einem Besprechung und einer Aufgabe:

* Wenn Sie anfangs ein Telefonat planen, befindet es sich in der To-do-Liste mit einer Frist, ähnlich wie eine Aufgabe.
* Wenn Sie das Telefonat führen, wird es zeitlich festgelegt und ähnelt jetzt einem Besprechung.
  * Die Startzeit wird zur aktuellen Zeit und zum heutigen Datum.
  * Die Standarddauer beträgt 15 Minuten.

## Standarddauer

Die Standarddauer für einen Besprechung beträgt 1 Stunde und 15 Minuten für einen Anruf. Sie können diese jedoch wie gewünscht ändern.

1. Gehen Sie zu ![Symbol][img14] **Persönliche Einstellungen** und wählen Sie **Einstellungen**.
1. Wählen Sie die **Standardwerte** aus.
1. Geben Sie einen Wert für einen oder beide dieser Werte ein und klicken Sie auf **Speichern**.
    * **Dauer bei neuem Termin**
    * **Dauer bei neuem Anruf**

## Zugehörige Inhalte

* [Folgeaufgabe erstellen][2]
* [Infos über Aktivitäten][4]

<!-- Referenced links -->
[2]: create-follow-up.md
[4]: ../../learn/basics/activity.md
[5]: invitation/index.md

<!-- Referenced images -->
[img2]: ../../../../common/icons/diary-alarm.png
[img3]: ../../../../common/icons/title.png
[img4]: ../../../../common/icons/diary-recurring-transparent.png
[img5]: ../../../../common/icons/sale.png
[img6]: ../../../../common/icons/singlecolour/project.png
[img7]: ../../../../common/icons/singlecolour/contact.png
[img8]: ../../../../common/icons/person.png
[img9]: ../../../../common/icons/associate-current.png
[img10]: ../../../../common/icons/now.png
[img14]: ../../../media/icons/personal-settings-small.png
