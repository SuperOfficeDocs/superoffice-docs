---
uid: help-de-diary
title: Kalender
description: Der SuperOffice-Kalender ist das Herzstück Ihres CRM-Systems. Diese Anleitungen helfen Ihnen, sich im Kalender zurechtzufinden und effizient mit ihm zu arbeiten.
keywords: Kalender öffnen, Kalenderansicht, Aktivitäten-Registerkarte, Aufgabenliste, To-do-Liste, Folgeaufgabe, Kalender
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
topic: concept
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Kalender

Die Kalenderansicht ist das zentrale Element in SuperOffice CRM zur Verwaltung von [Folgeaufgaben][1] (Meetings, Aufgaben oder Anrufe). Sie besteht aus einem Kalender und einer Aufgabenliste, die Ihnen helfen, organisiert und produktiv zu bleiben.

![Kalenderansicht mit Wochenplan und Aufgabenliste -screenshot][img1]

Der Kalender kombiniert die folgenden Hauptkomponenten:

* **Kalender:** Zeigt Folgeaufgaben, die für bestimmte Tage und Uhrzeiten geplant sind. Ähnelt einem Terminplaner mit separaten Seiten für jeden Tag, jede Woche und jeden Monat.
* **Aufgabenliste:** Zeigt (nicht abgeschlossene) Aktivitäten ohne bestimmte Uhrzeit, wie Anrufe, Aufgaben oder geplante Verkäufe. Dient als To-do-Liste.

Durch die flexiblen Ansichten ermöglicht der Kalender eine nahtlose Zusammenarbeit und erleichtert die Planung von Tagen, Wochen oder Monaten.

## <a id="open"></a>Kalender öffnen

Klicken Sie im Navigator auf **Kalender** und wählen Sie einen Zeitraum aus der Liste oder klicken Sie auf **Heute** oder **Diese Woche**, um zum aktuellen Tag oder zur aktuellen Woche zu springen. Ihr Name wird in der oberen rechten Ecke des Kalenders angezeigt.

Folgeaufgaben werden als farbige Zeitblöcke dargestellt, die deren Typ und Dauer repräsentieren. Jeder Block enthält Details wie Firma, Typ und Agenda. Doppelklicken Sie auf eine Folgeaufgabe, um sie zu öffnen.

Die folgenden Symbole bieten visuelle Hinweise zu Details oder möglichen Aktionen:

| Symbol | Beschreibung | Weiterlesen |
|:-:|---|---|
| <i class="ph ph-arrows-clockwise" aria-label="Regelmäßige Folgeaufgabe"></i> | Dies ist eine regelmäßige Folgeaufgabe. | [Regelmäßige Folgeaufgabe planen][8] |
| <i class="ph ph-user-circle" aria-label="Mehrere Teilnehmer"></i> | Die Folgeaufgabe hat mehrere Teilnehmer. | [Teilnehmer zu einer Folgeaufgabe einladen][11] |
| <i class="ph ph-check" aria-label="Abgeschlossene Folgeaufgabe"></i> | Die Folgeaufgabe ist abgeschlossen. | [Status Abgeschlossen für eine Aktivität ändern][7] |
| <i class="ph ph-bell" aria-label="Alarm"></i> | Die Folgeaufgabe hat einen aktiven Alarm. | |
| <i class="ph ph-question" aria-label="Unbeantwortete Einladungen"></i> | Es gibt unbeantwortete Einladungen zu dieser Folgeaufgabe. | [Status von Einladungen][10] |
| <i class="ph ph-video-camera" aria-label="Videokonferenz"></i> | Diese Folgeaufgabe ist eine Videokonferenz. Rechtsklick auf die Folgeaufgabe und **An Konferenz teilnehmen** wählen. | [Mit Videokonferenzen arbeiten][6] |

Administratoren definieren die Typen und Farben von Folgeaufgaben in **Einstellungen und Verwaltung**.

## <a id="nav"></a>Im Kalender navigieren

Sie können problemlos zwischen Daten oder Zeiträumen im Kalender wechseln:

* Wählen Sie die Registerkarten **Tag**, **Woche** oder **Monat**, um den Detailgrad anzupassen. Die Kopfzeile des Kalenders zeigt den entsprechenden Zeitraum für die gewählte Karte an.

* Verwenden Sie die Schaltflächen **Zurück** und **Weiter** (<i class="ph ph-caret-circle-left" aria-hidden="true"></i><i class="ph ph-caret-circle-right" aria-hidden="true"></i>), um sich vorwärts oder rückwärts zu bewegen.

* Um schnell zu einem bestimmten Datum, einer Woche oder einem Monat zu springen:
  * Klicken Sie auf ein Datum, um die Registerkarte **Tag** zu öffnen.
  * Klicken Sie auf eine Wochennummer, um die Registerkarte **Woche** zu öffnen.
  * Klicken Sie in der Seitenleiste auf einen Monat, um die Registerkarte **Monat** für diesen Monat zu öffnen.

* Klicken Sie auf **Heute** oder **Diese Woche**, um zum aktuellen Tag oder zur aktuellen Woche zurückzukehren.

## <a id="tabs"></a>Registerkarten in der Kalenderansicht

Verwenden Sie die Registerkarten in der Kalenderansicht, um zwischen verschiedenen Perspektiven zu wechseln:

<!-- markdownlint-disable MD051 -->
### [Registerkarte Tag](#tab/day)

Die Registerkarte **Tag** zeigt einen einzelnen Tag mit stündlichen Zeitintervallen am linken Rand. Diese Ansicht eignet sich ideal für die detaillierte Planung Ihres Tages.

![Kalenderansicht, Registerkarte Tag -screenshot][img2]

Hauptfunktionen:

* Navigieren Sie einfach zu verschiedenen Daten mit der Schaltfläche **Heute** oder den Schaltflächen **Zurück** und **Weiter** (<i class="ph ph-caret-circle-left" aria-hidden="true"></i><i class="ph ph-caret-circle-right" aria-hidden="true"></i>).

* Erstellen oder verschieben Sie Folgeaufgaben, indem Sie diese per Drag-and-Drop auf der Zeitachse anpassen.

### [Registerkarte Woche](#tab/week)

Die Registerkarte **Woche** zeigt eine Woche auf einmal an, wobei die Tage als Spalten und die Stunden als Zeilen dargestellt werden.

![Kalenderansicht, Registerkarte Woche -screenshot][img3]

Hauptfunktionen:

* Öffnen Sie einen bestimmten Tag schnell, indem Sie auf die entsprechende Tagesüberschrift klicken.
* Überlappende Folgeaufgaben werden deutlich innerhalb desselben Zeitblocks angezeigt.

> [!TIP]
> Um den ersten Tag der Woche (Sonntag oder Montag) zu ändern, gehen Sie zu <i class="ph ph-user-circle" aria-hidden="true"></i> **Persönliche Einstellungen** > **Einstellungen**.

### [Registerkarte Monat](#tab/month)

Die Registerkarte **Monat** bietet eine Übersicht über alle Folgeaufgaben, die für einen bestimmten Monat geplant sind.

![Kalenderansicht, Registerkarte Monat -screenshot][img4]

Hauptfunktionen:

* Bewegen Sie den Mauszeiger über eine Folgeaufgabe, um eine QuickInfo mit zusätzlichen Details anzuzeigen.
* Klicken Sie auf ein Datum, um zur **Registerkarte Tag** für diesen Tag zu wechseln und weitere Details einzusehen.

### [Registerkarte Übersicht](#tab/view)

Die Registerkarte **Übersicht** ermöglicht das Anzeigen und Verwalten von Gruppenkalendern sowie das Überprüfen der Verfügbarkeit von Kollegen oder Ressourcen.

![Kalenderansicht, Registerkarte Übersicht -screenshot][img5]

Hauptfunktionen:

* **Gruppenansichten:** Kombinieren Sie die Kalender mehrerer Benutzer oder Ressourcen in einer einzigen Ansicht. Wählen Sie eine vordefinierte Gruppe aus der Liste (<i class="ph ph-caret-down" aria-label="Dropdown-Symbol"></i>) oder erstellen und verwalten Sie benutzerdefinierte Gruppenansichten über das **Aufgabenmenü** (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>).

* **Anzeigemodi:** Wechseln Sie zwischen der Nebeneinander-Ansicht und dem Planungsraster mit den Umschalt-Schaltflächen (<i class="ph ph-columns" aria-label="Spalten"></i>/<i class="ph ph-rows" aria-label="Zeilen"></i>) in der oberen rechten Ecke.

Detaillierte Anweisungen zur Erstellung und Verwaltung von Gruppenansichten finden Sie unter [Gruppenansicht][2].

> [!TIP]
> In einer Gruppenansicht können Sie direkt im Kalender Folgeaufgaben für andere Personen erstellen.

***
<!-- markdownlint-enable MD051 -->

Im unteren linken Bereich des Kalenders befindet sich ein Feld zur Auswahl einer [Zeitzone][20], sofern Zeitzonen aktiviert wurden.

## <a id="section-tabs"></a>Bereichsregisterkarten in der Kalenderansicht

Der untere Bereich der Kalenderansicht enthält Bereichsregisterkarten, die gemeinsam Ihre Aufgabenliste bilden. Dazu gehören:

* **Aktivitäten:** Dient als Aufgabenliste und zeigt Folgeaufgaben, die für die ausgewählte Person keine bestimmte Uhrzeit haben. Siehe [Bereichsregisterkarte Aktivitäten][12].

* **Verkäufe:** Zeigt eine Übersicht über den Verkaufsfortschritt und geplante Aktivitäten im Zusammenhang mit Verkäufen für die ausgewählte Person. Der Fokus liegt auf der Nachverfolgung des Fortschritts und der Verwaltung anstehender Aufgaben. Siehe [Bereichsregisterkarte Verkäufe][13].

Die Bereichsregisterkarten können entweder *unterhalb* des Kalenders angezeigt werden oder als fünfte Kalenderansicht – die **Aufgabenliste**-Registerkarte – je nach persönlicher Präferenz.

Wenn die Bereichsregisterkarten *unter* dem Kalender angezeigt werden (klassische Ansicht), bleiben sie unabhängig von der gewählten Kalenderansicht sichtbar. So können Sie Verkaufs- oder Folgeaufgaben im Seitenbereich effizient einsehen, während Sie im Kalender planen. Wenn die Bereichsregisterkarten *innerhalb* des Kalenders als eigene Ansicht angezeigt werden (neue Ansicht), bleibt mehr Platz für den Kalender selbst.

![Kalenderansicht mit Bereichsregisterkarten innerhalb der Aufgabenliste-Registerkarte -screenshot][img6]

## Seitenbereich im Kalender

Der [Seitenbereich][17] befindet sich auf der rechten Seite der Kalenderansicht und bietet schnellen Zugriff auf zusätzliche Werkzeuge wie den Monatskalender, Vorschauen von Folgeaufgaben oder SuperOffice Copilot.

Wenn Sie im Seitenbereich ein Datum, eine Woche oder einen Monat auswählen, wird die Kalenderansicht entsprechend aktualisiert. Ebenso wird der Seitenbereich automatisch angepasst, wenn Sie im Kalender navigieren.

## Persönliche Einstellungen

Sie können den Kalender individuell an Ihren Arbeitsstil anpassen:

1. Gehen Sie zu <i class="ph ph-user-circle" aria-hidden="true"></i> **Persönliche Einstellungen** > **Einstellungen**.

1. Wählen Sie **Standardwerte** und passen Sie folgende Einstellungen an:
    * Dauer und Typ neuer Besprechungen.
    * Titel für neue To-dos.
    * Maximale Anzahl an Folgeaufgaben, die in der **Tagesansicht** angezeigt werden.

1. Wählen Sie **Kalender** und ändern Sie:
    * Standardmäßige Alarmzeiten.
    * Start- und Endzeiten für ganztägige Ereignisse.
    * Erster Wochentag (Sonntag oder Montag).
    * Ob die To-do-Liste *unter* dem Kalender oder als eigene Registerkarte angezeigt wird.

1. Wählen Sie **Funktionen** und konfigurieren Sie:
    * Anzeige von Kalenderwochennummern.
    * Anzahl der Tage im Voraus, für die Einträge in den Bereichsregisterkarten **Aktivitäten** und **Verkäufe** angezeigt werden.
    * Markierung überfälliger Aktivitäten.

1. Wählen Sie **Visuelle Effekte** und passen Sie an:
    * Automatische Entfernung erledigter Aktivitäten.
    * QuickInfos (Tooltips).

1. Klicken Sie auf **Speichern**, um Ihre Änderungen zu übernehmen.

![Persönliche Einstellungen für den Kalender -screenshot][img7]

## Effiziente Nutzungstipps

* Greifen Sie auf den Kalender einer anderen Person oder Ressource zu, um deren Verfügbarkeit zu überprüfen oder direkt Folgeaufgaben für sie zu erstellen. Für eine kombinierte Ansicht mehrerer Kalender erstellen Sie eine [Gruppenansicht][2].

* Reduzieren Sie Ablenkungen, indem Sie den Seitenbereich und/oder den Navigator mit der Umschalttaste (<i class="ph ph-sidebar-simple" aria-hidden="true"></i>) ausblenden.

* Nutzen Sie den Kalender, um [Aktivitäten][16] anzuzeigen, zu bearbeiten und zu löschen, damit Ihr Zeitplan stets aktuell bleibt.

* Verknüpfen Sie regelmäßig Aktivitäten mit eine Person oder Firma, um eine klare Aufzeichnung der Teaminteraktionen zu gewährleisten und eine reibungslose Zusammenarbeit zu fördern.

* Verwenden Sie die fixierten Bereichsregisterkarten unterhalb des Kalenders, um Verkaufsaktivitäten oder To-dos zu verwalten und gleichzeitig den Kalender im Blick zu behalten.

* Wechseln Sie in der Registerkarte **Übersict** zwischen der Nebeneinander- und der Rasteransicht, um die für Ihre Planung passende Darstellung auszuwählen.

> [!TIP]
> Nutzen Sie das Menü **Einstellungen**, um das Layout des Kalenders anzupassen, Zeiteinstellungen zu ändern oder Funktionen wie Alarme für Folgeaufgaben zu aktivieren.

## Verwandte Inhalte

* [Folgeaufgabe erstellen oder kopieren][5]
* [Regelmäßige Folgeaufgabe planen][8]
* [Teilnehmer zu einer Folgeaufgabe einladen][10]
* [Folgeaufgabe bearbeiten oder löschen][3]
* [Endzeitpunkt einer Folgeaufgabe ändern][4]
* [Videokonferenzen beitreten][6]
* [Folgeaufgaben drucken][14]
* [Links zu Dokumenten, Verkäufen oder Webseiten hinzufügen][15]
* [API für Folgeaufgabe][50]

<!-- Referenced links -->
[1]: follow-ups.md
[2]: group-view.md
[3]: edit-follow-up.md
[4]: edit-follow-up.md#change-end
[5]: create-follow-up.md
[6]: video-meetings.md
[7]: change-completed-status.md
[8]: recurrence/create.md
[10]: invitation/index.md#status
[11]: invitation/add-attendee.md
[12]: ../../learn/section-tabs/activities-tab.md
[13]: ../../learn/section-tabs/sales-tab.md
[14]: ../../learn/basics/print.md
[15]: ../../learn/basics/links.md
[16]: ../../learn/basics/activity.md
[17]: ../../learn/getting-started/main-screen/side-panel.md
[20]: ../../globalization-and-localization/learn/time-zones.md
[50]: ../../../en/diary/reference/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/diary/diary.png
[img2]: ../../../media/loc/en/diary/day-plan.png
[img3]: ../../../media/loc/en/diary/week-plan.png
[img4]: ../../../media/loc/en/diary/month-plan.png
[img5]: ../../../media/loc/en/diary/view-tab.png
[img6]: ../../../media/loc/en/diary/activities-list.png
[img7]: ../../../media/loc/en/diary/preferences.png
