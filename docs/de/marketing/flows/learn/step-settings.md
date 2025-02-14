---
uid: help-de-flow-step-settings
title: Schrittoptionen
description: Übersicht über die Optionen für die verschiedenen Flow-Schritte.
keywords: Marketing, Flow, Schritt, Feld, Option
author: Bergfrid Dias
date: 09.17.2024
version: 10.3.9
topic: howto
language: de
audience: person
audience_tooltip: SuperOffice Marketing
---

# Schrittoptionen

> [!NOTE]
> Viele Felder bieten eine Liste vordefinierter Werte, aus denen Sie wählen können. Klicken Sie auf <i class="ph ph-caret-down" aria-label="Chevron"></i>, um die Liste zu erweitern, oder beginnen Sie mit der Eingabe im Feld, um nach einem bestimmten Wert zu suchen.

## Zu Selektion und/oder Projekt hinzufügen

| Einstellung | Beschreibung |
|---|---|
| Person zu statischer Selektion hinzufügen | Fügt den Teilnehmer zur angegebenen statischen Selektion hinzu. |
| Person als Projektmitglied hinzufügen | Fügt den Teilnehmer als Mitglied des angegebenen Projekts hinzu. |

## Folgeaufgabe erstellen

| Einstellung | Beschreibung |
|---|---|
| Titel | Eine beschreibende Bezeichnung für die Folgeaufgabe. Weitere Details finden sich in der Agenda. |
| Typ | Eine vordefinierte Liste von Aktivitäten wie Besprechung und Telefonkonferenz. Die verfügbaren Felder hängen vom ausgewählten Folgeaufgabe-Typ ab. |
| Projekt | Das mit der Folgeaufgabe verknüpfte Projekt. |
| Datum | Der Start- oder Fälligkeitsdatum des Folgeaufgaben.<br />**Aufgabendatum:** Eine Aufgabe in der Checkliste des Benutzers<br />**Meetingdatum:** Eine Folgeaufgabe im Kalender. Optionen sind "Erstes verfügbares" oder "Erstes verfügbares nach x Tagen/Arbeitstagen/Wochen". |
| Zuweisen zu | Der Besitzer des Folgeaufgabe: der "unser Kontakt" des Teilnehmers oder "unser Servicemitarbeiter" oder ein bestimmter benannter Mitarbeiter. |
| Agenda | Weitere Details zur Folgeaufgabe, wie Agenda, Beschreibung, Dateien, Bilder und Links. Optionen zur Formatierung von Rich-Text stehen zur Verfügung. |

## Anfrage erstellen

| Einstellung | Beschreibung |
|---|---|
| Titel | Ein beschreibender Name für die Anfrage. |
| Anfragetyp | Zielt auf eine Reihe von Attributen ab, die für einen bestimmten Prozess benötigt werden. Beeinflusst verfügbare Status und Prioritäten. |
| Status | Zeigt die Phase des Anfragenmanagements an (offen oder geschlossen). |
| Kategorie | Ein Satz von Regeln, die definieren, wie Anfragen verarbeitet werden. |
| Priorität | Spiegelt die Wichtigkeit der Anfrage wider. |
| Eigentümer | Die Person, der die Anfrage zugewiesen werden soll. |
| Nachricht | Der Inhalt der Anfrage. Optionen zur Formatierung von Rich-Text und Vorlagenvariablen für Person und das Firma des Persons stehen zur Verfügung. |

## Verkauf erstellen

| Einstellung | Beschreibung |
|---|---|
| Titel | Ein beschreibender Name des Verkaufs. Details finden sich in der Beschreibung. |
| Verkaufstyp | Informationen zum Verkaufsprozess. Beeinflusst Standard-Verkaufsstufe und geschätztes Verkaufsdatum. Einige Verkaufstypen sind mit einem [Verkaufsleitfaden][14] verknüpft. |
| Stufe | Die aktuelle Phase des Verkaufs (offen, verloren, verkauft). |
| Betrag | Erwarteter Betrag für den Umsatz. |
| Beschreibung | Eine detailliertere Beschreibung des Verkaufs. |
| Projekt | Das mit dem Verkauf verknüpfte Projekt. |
| Datum | Das geschätzte Verkaufsdatum. Optionen sind "Geschätzt nach Verkaufstyp" oder "Nach x Tagen/Arbeitstagen/Wochen". |
| Eigerntümer | Die Person, die für den Verkauf verantwortlich ist. Der "unser Kontakt" des Teilnehmers oder "unser Servicemitarbeiter" oder ein bestimmter benannter Mitarbeiter. |

## Flow schließen

Die Flusskontrollschritte **Aufteilen** und **Auf Aktion warten** (und auch SMS senden) haben eine Option **Flow beenden**, um Teilnehmer, die eine Bedingung nicht erfüllen, aus dem Flow zu ziehen. Wenn ausgewählt, kann der ausgeschiedene Person in einen anderen Flow verschoben und/oder einer Selektion hinzugefügt werden.

| Einstellung | Beschreibung |
|---|---|
| Teilnehmer nach dem Beenden zu einem anderen Flow hinzufügen | Der ausgeschiedene Person wird als Teilnehmer für den angegebenen Flow vorgeschlagen. Filter bestimmen, ob sie diesen Flow starten oder nicht. |
| Teilnehmer nach dem Beenden zur statischen Selektion hinzufügen | Der ausgeschiedene Person wird Mitglied der angegebenen Selektion. Sie können eine neue Selektion über die Schritt-Einstellungen erstellen. |

## Abschließen

Teilnehmer, die den Abschlussschritt erreichen, haben das Ende des Flows erreicht. Der Teilnehmer hat den Flow entweder mit dem Status = abgeschlossen oder mit Erfolg abgeschlossen. Es erfolgen keine weiteren Aktionen für einen Teilnehmer in diesem Flow, wenn der Schritt erreicht wird.

| Einstellung | Beschreibung |
|---|-|
| Zu einem anderen Flow hinzufügen, wenn ein Erfolgskriterium erfüllt ist | Mit Erfolg abgeschlossen |
| Zu einem anderen Flow hinzufügen, wenn kein Erfolgskriterium erfüllt ist | Abgeschlossen |

## Per E-Mail benachrichtigen

| Einstellung | Beschreibung |
|---|---|
| An | Der Empfänger - "unser Kontakt", "unser Servicekontakt" oder eine spezifische E-Mail-Adresse. |
| Betreff | Text für das Betreff-Feld der E-Mail. |
| Text | Geben Sie die Nachricht ein. |

Sie können den Betreff mit Kontaktvariablen personalisieren (gleich wie Zusammenführungstags innerhalb des E-Mail-Editors).

## Per SMS benachrichtigen

| Einstellung | Beschreibung |
|---|---|
| An | Der Empfänger – "unser Kontakt", "unser Servicekontakt" oder spezifische Kontakte. |
| Von | Standardmäßig auf Flow-Einstellung "SMS-Sender" festgelegt. |
| Text | Geben Sie den SMS-Text ein. Sie können die Nachricht mit Kontaktvariablen personalisieren (gleich wie Zusammenführungstags innerhalb des E-Mail-Editors). |

## E-Mail senden

| Einstellung | Beschreibung |
|---|---|
| Neue E-Mail für diesen Schritt erstellen | Öffnet den E-Mail-Assistenten. |
| Bestehende E-Mail für diesen Schritt auswählen | Siehe [Inhalt hinzufügen][1]. |
| Betreff | Text für das Betrefffeld der E-Mail. Sie können den Betreff mit Kontaktvariablen personalisieren (gleich wie Zusammenführungstags innerhalb des E-Mail-Editors). |
| Anhang | Maximal 25 MB insgesamt. |

## SMS senden

| Einstellung | Beschreibung |
|---|---|
| Von | Standardmäßig auf Flow-Einstellung "SMS-Sender" festgelegt. |
| Text | Geben Sie den SMS-Text ein. Sie können die Nachricht mit Kontaktvariablen personalisieren (gleich wie Zusammenführungstags innerhalb des E-Mail-Editors). |
| Flow verlassen, wenn kein Mobiltelefon registriert ist | Bestimmt, was passieren soll, wenn der Person die SMS nicht empfangen kann. Wenn true, können Sie sie nach dem Verlassen einem anderen Flow oder einer statischen Selektion hinzufügen. |

## Aufteilen

| Einstellung | Beschreibung |
|---|---|
| Funktion | Eine kurze beschreibende Bezeichnung. |
| Aufteilen aufgehend von | Die Daten/Verhaltensweisen zur Unterscheidung. |
| Name des Zweigs| Ein beschreibender Name des Zweigs, der anzeigt, welche Teilnehmer sich in welchem Zweig bewegen. |
| Alle anderen | Der Zweig für die Behandlung von Teilnehmern, die die Bedingungen eines der anderen Zweige nicht erfüllen. |
| Flow schliessen | Bestimmt, ob Teilnehmer, die sich im "alle anderen"-Zweig befinden, den Flow verlassen sollen. Wenn true, können Sie sie nach dem Verlassen einem anderen Flow oder einer statischen Selektion hinzufügen. Wenn false , können Sie diesem Zweig weitere Schritte hinzufügen. Die verbleibenden Felder zur Spezifizierung der Zweigeinstellungen hängen davon ab, worauf die Aufteilung basiert. |

## Trigger

| Einstellung | Beschreibung |
|---|---|
| Eine Person kann diesen Flow nur einmal starten | Ob ein Person erneut in diesen Flow aufgenommen werden kann. |
| Filter | Eine Reihe von Kriterien, die erfüllt sein müssen, damit ein vorgeschlagener Person in den Flow aufgenommen werden kann. Wird nur einmal überprüft. |
| Ausschlussliste | Eine statische Selektion von Personen, die nicht dem Flow hinzugefügt werden oder den Flow verlassen werden, wenn sie bereits teilnehmen. |

## Person aktualisieren

Funktioniert ähnlich wie [Massenabgleich][10].

## Wartezeit

| Einstellung | Beschreibung |
|---|---|
| Anzahl der Tage/Stunden nach dem vorherigen Schritt | Die **Dauer** der Pause. Warten Sie eine bestimmte Zeit. |
| Bis zum bestimmten Datum/Zeitpunkt | Das **Ende** der Pause. Warten Sie bis zu einem bestimmten Datum. |

## Warten auf Aktion

| Einstellung | Beschreibung |
|---|---|
| Maximale Wartezeit | Wie lange auf eine Aktion gewartet werden soll (ein Timeout). Standard: 7 Tage. |
| Flow verlassen, wenn innerhalb der maximalen Wartezeit keine Aktionen erfolgen | Teilnehmer, die nicht reagieren, verlassen den Flow mit dem Status "Abbruch". Wenn true, können Sie sie nach dem Verlassen einem anderen Flow oder einer statischen Selektion hinzufügen. |

## Verwandte Inhalte

* [Informationen zu Aktivitäten][11]

<!-- Referenced links -->
[1]: content.md
[10]: ../../../learn/basics/bulk-update.md
[11]: ../../../learn/basics/activity.md
[14]: ../../../sale/learn/sales-guides.md
