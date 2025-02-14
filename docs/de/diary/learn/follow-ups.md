---
uid: help-de-follow-ups
title: Folgeaufgaben
description: Folgeaufgaben – Besprechung, Aufgabe, Anruf
keywords: Folgeaufgabe, Termin, Besprechung, Aufgabe, Zu erledigen, To-do, Telefon, Anruf, Teilnehmer, Kalender
author: Bergfrid Dias
date: 02.1.2025
version: 10.5.2
topic: concept
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Folgeaufgaben

Eine *Folgeaufgabe* ist die allgemeine Bezeichnung für [Besprechungen](#meeting) und [Aufgaben](#todo). Ein [Telefonanruf](#call) ist eine Mischung aus beiden. Diese Aktivitäten sind eng mit der Kalenderansicht verknüpft und funktionieren weitgehend gleich.

Öffnen Sie eine bestehende Folgeaufgabe, indem Sie sie im Kalender oder in der Bereichsregisterkarte **Aktivitäten** doppelklicken.

## Allgemeine Informationen

| Symbol | Eigenschaft | Beschreibung |
|:-:|---|---|
| <i class="ph ph-user" aria-label="Benutzer"></i> | Besitzer | Wem die Folgeaufgabe gehört. Der ursprüngliche Ersteller oder die Person, der die Folgeaufgabe zugewiesen/delegiert wurde. |
| <i class="ph ph-text-align-left" aria-label="Titel"></i> | Titel | Eine beschreibende Bezeichnung. Weitere Details werden in der Agenda erfasst. |
| (ein farbiger Punkt) | Typ | Eine vordefinierte Liste von Aktivitäten wie Besprechung (extern) und Telefonanruf. |
| <i class="ph ph-buildings" aria-label="Firma"></i>, <i class="ph ph-user-circle" aria-label="Person"></i> | Firma / Person | Wen die Folgeaufgabe betrifft. |
| <i class="ph ph-clock" aria-label="Uhr"></i> | Zeit und Datum | Wann die Folgeaufgabe beginnt oder fällig ist. |
| <i class="ph ph-arrows-clockwise" aria-label="Wiederholung"></i> | Wiederholung | Ob und wie sich die Folgeaufgabe wiederholt. |
| (kein Symbol) | Verfügbarkeit | Frei/Belegt. Beeinflusst die Konfliktbehandlung. |
| <i class="ph ph-bell" aria-label="Alarm"></i> | Alarm | Ob und wann die Person benachrichtigt werden soll. |
| <i class="ph ph-currency-circle-dollar" aria-label="Verkauf"></i> | Verkauf | Ein mit der Folgeaufgabe verknüpfter Verkauf. |
| <i class="ph ph-clipboard-text" aria-label="Projekt"></i> | Projekt | Ein mit der Folgeaufgabe verknüpftes Projekt. |
| <i class="ph ph-users" aria-label="Teilnehmer"></i> | Teilnehmer | Personen, die an der Folgeaufgabe teilnehmen. |
| <i class="ph ph-chair" aria-label="Ressource"></i> | Ressource | Besprechungsräume, Orte oder benötigte Ressourcen. |
| <i class="ph ph-map-pin" aria-label="Ort"></i> | Ort | Der Ort oder die Adresse, an der die Besprechung stattfindet. |

## Neu erstellen

Unabhängig davon, wo Sie sich in SuperOffice CRM befinden, können Sie eine Folgeaufgabe erstellen, indem Sie auf **Neu** in der oberen Leiste klicken und dann **Besprechung**, **Zu erledigen** oder **Folgeaufgabe** auswählen.

> [!NOTE]
> Folgeaufgaben, die in der Kalenderansicht erstellt werden, sind standardmäßig Besprechungen. Sie können den Typ jedoch vor dem Speichern ändern.

## Folgeaufgaben finden

In der Kalenderansicht erscheinen Besprechungen und Anrufe auf den Registerkarten **Tag**, **Woche**, **Monat** und **Übersicht** sowie in den Seitenfeldern **Tag**, **Monat**, **Nächster Tag** und **Woche**.

Die Bereichsregisterkarte **Aktivitäten** (in den Ansichten Firma, Person, Verkauf, Projekt und Kalender) zeigt alle Folgeaufgaben, einschließlich Aufgaben.

## Folgeaufgabentypen

| Typ | Startzeit | Endzeit | Dauer | Fälligkeitsdatum | Angezeigt in | Beschreibung | Beispiel |
|---|:-:|:-:|:-:|:-:|---|---|---|
| Besprechung | &#10003; | &#10003; | Berechnet | | Kalender | Aktivität mit definiertem Start- und Endzeitpunkt | Externes Treffen mit Lieferanten |
| Aufgabe (Zu erledigen) | | | | &#10003; | Aktivitäten-Registerkarte | Folgeaufgabe ohne Startzeit | Erinnerung für Aufgaben, die zu einer bestimmten Zeit fällig sind |
| Telefonanruf | &#10003; | | &#10003; | | Aktivitäten-Registerkarte | Telefonanruf | Eingehender Anruf von einem Kunden |

## <a id="meeting"></a>Besprechung

Besprechungen sind Aktivitäten mit einem definierten Anfangs- und Endzeitpunkt. Sie werden im Kalender des Besitzers angezeigt.

Eine Besprechung kann eine einzelne Veranstaltung oder Teil einer wiederkehrenden Serie sein. Besprechungen, die eine Ressource und/oder zusätzliche Teilnehmer umfassen, werden als [Einladungen][5] bezeichnet.

Überfällige und abgeschlossene Besprechungen werden zusätzlich in der Bereichsregisterkarte **Aktivitäten** angezeigt.

### Übliche Szenarien

| Szenario | Ressource | 2+ Teilnehmer | Beschreibung |
|---|:-:|:-:|---|
| Eigene Zeit reserviert | | | Zeit für die alleinige Arbeit reserviert |
| Eigene Zeit und Ressource reserviert | &#10003; | | Wie oben, plus Bedarf an Raum oder Ausrüstung |
| Besprechung mit mehreren Teilnehmern | &#10003; | &#10003; | Eine Besprechung, häufig auch mit einer Ressource oder einem Ort |

## <a id="todo"></a>Aufgabe (Zu erledigen)

Eine *Aufgabe* ist eine Folgeaufgabe ohne Startzeit. Sie hat normalerweise keine Dauer, aber immer eine **Fälligkeit**. Aufgaben werden verwendet, um Dinge zu notieren, die bis zu einem bestimmten Zeitpunkt erledigt sein müssen.

Standardmäßig erscheinen Aufgaben in der Aufgabenliste des Kalenders, wo sie abgehakt werden können, wenn sie erledigt sind. Wenn Sie eine Start- und Endzeit angeben, wird die Aufgabe an diesem Tag und zur angegebenen Uhrzeit im Kalender eingetragen.

## <a id="call"></a>Telefonanruf

Ein *Anruf* ist eine spezielle Form der Folgeaufgabe und eine Mischung aus Besprechung und Aufgabe:

* Wenn Sie ein Telefonat planen, erscheint es in der Aufgabenliste mit einer Frist, ähnlich wie eine Aufgabe.
* Wenn Sie den Anruf tätigen, wird er zeitlich festgelegt und ähnelt dann einer Besprechung.
  * Die Startzeit entspricht dem aktuellen Zeitpunkt und dem heutigen Datum.
  * Die Standarddauer beträgt 15 Minuten.

## Standarddauer

Die Standarddauer beträgt 1 Stunde für eine Besprechung und 15 Minuten für einen Anruf. Sie können die Standardwerte ändern:

1. Gehen Sie zu <i class="ph ph-user-circle" aria-hidden="true"></i> **Persönliche Einstellungen** und wählen Sie **Einstellungen**.
1. Wählen Sie **Standardwerte**.
1. Geben Sie eine neue Dauer für eine oder beide der folgenden Optionen ein und klicken Sie auf **Speichern**:
    * **Dauer für neue Besprechungen**
    * **Dauer für neue Anrufe**

## <a id="more-tab"></a>Die Registerkarte Mehr

Die [Registerkarte Mehr][12] enthält benutzerdefinierte Felder für die Folgeaufgabe.

## Verwandte Inhalte

* [Folgeaufgabe erstellen][2]
* [Mehr über Aktivitäten erfahren][4]

<!-- Referenced links -->
[2]: create-follow-up.md
[4]: ../../learn/basics/activity.md
[5]: invitation/index.md
[12]: ../../custom-objects/learn/more-tab.md
