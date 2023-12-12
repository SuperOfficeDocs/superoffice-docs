---
uid: help-de-request-type
title: Anfragetypen
description: Anfragetypen
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: Anfrage, Typ
so.topic: concept
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: de
---

# Anfragetypen

Alle Anfragen, die in SuperOffice registriert sind, haben einen Typ. Der Standardtyp ist "Request". Um Anfragetypen anzuzeigen, hinzuzufügen, zu aktualisieren und zu löschen, gehen Sie zu **Einstellungen und Vervaltung**.

> [!NOTE]
> Diese Funktion erfordert einen Service Premium Benutzerplan (um Anfragestypen zu erstellen und zu aktualisieren) sowie eine Development Tools Lizenz, um Ansichtslayouts basierend auf Anfragetypen im Screen Designer zu definieren. (Nur im Pilot verfügbar.)

## Warum Anfragetypen verwenden?

Der Hauptvorteil von Anfragetypen ist effiziente Unterstützung. Ein bestimmter Anfragetyp richtet sich auf eine Reihe von Attributen, die für einen bestimmten Prozess benötigt werden.

## Beispiel

Das Finanzteam verwendet Anfragen, um eingehende Rechnungsansprüche zu verwalten, was die Sichtbarkeit der Rechnungsnummer als festgelegtes Feld erfordert. Im Gegensatz dazu verwendet das eingehende Vertriebsteam Anfragen, um eingehende Leads zu bearbeiten. In Fällen, in denen eine Anfrage einen Lead betrifft, hat die Rechnungsnummer keine Relevanz und sollte vollständig aus der Ansicht ausgeschlossen bleiben.

## Wo finde ich die Anfragetypen?

* In **Einstellungen und Vervaltung** wählen Sie **Anfragen** im Navigator und dann den Tab **Anfragetypen**.

[!include[Restricted access](../../../learn/includes/note-insufficient-rights.md)]

## Einstellungen

| Einstellung | Beschreibung |
|---|---|
| Name | Der Name des Anfragetyps. |
| Beschreibung | Erläutert den Zweck des Anfragetyps.|
| Symbol | Wird als visuelles Etikett verwendet, um den Typ anzuzeigen. Auswahl aus einem Satz vordefinierter Optionen. Standard: Ticket-Symbol.|
| Als Standard verwenden | Gibt an, ob dies der Standardtyp für neue Anfragen ist. |
| Verfügbare Statuskategorien | Eine Teilmenge von Anfragestatusen, die für diesen Typ relevant sind. Wird verwendet, um die Dropdown-Liste im Benutzeroberfläche zu filtern. Ein leeres Feld bedeutet, dass alle Statuskategorien verfügbar sind. |
| Standard-Status | Der [Status][4], der festgelegt wird, wenn ein Agent eine neue Anfrage erstellt. Hat Vorrang vor anderen Präferenzen. Erforderlich, wenn **Verfügbare Statuskategorien** festgelegt sind. |
| Verfügbare Prioritäten | Eine Teilmenge von Anfrageprioritäten, die für diesen Typ relevant sind. Wird verwendet, um die Dropdown-Liste im Benutzeroberfläche zu filtern. Ein leeres Feld bedeutet, dass alle Prioritäten verfügbar sind. |
| Standardpriorität | Die [Priorität][3], die festgelegt wird, wenn ein Agent eine neue Anfrage erstellt. Hat Vorrang vor anderen Präferenzen. Erforderlich, wenn **Verfügbare Prioritäten** festgelegt sind. |
| Antwortvorlage | Die [Antwortvorlage][5], die verwendet wird, wenn ein Agent auf eine Anfrage dieses Typs antwortet. |

## Zugehörige Inhalte

* [Anfragetyp erstellen][1]
* [Anfragetyp löschen][2]

<!-- Referenced links -->
[1]: create.md
[2]: delete.md
[3]: ../priority/index.md
[4]: ../status/index.md
[5]: ../../reply-templates/learn/index.md

<!-- Referenced images -->
