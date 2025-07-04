---
uid: help-de-request-type
title: Anfragetyp
description: Anfragetyp
keywords: Anfragetyp, Anfragetypliste, Typ, Anfrage
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
content_type: concept
license: servicepremium
audience: settings
audience_tooltip: Einstellungen und Verwaltung
language: de
redirect_from: /de/request/learn/type/index
index: true
---

# Anfragetyp

Alle Anfragen, die in SuperOffice registriert sind, haben einen Typ. Der Standardtyp ist **Request**. Um Anfragetypen anzuzeigen, hinzuzufügen, zu aktualisieren oder zu löschen, wechseln Sie zu **Einstellungen und Verwaltung**.

> [!NOTE]
> Diese Funktion erfordert einen Service Premium-Benutzerplan (zum Erstellen und Aktualisieren von Anfragetypen) sowie eine Development Tools-Lizenz, um Ansichts-Layouts basierend auf Anfragetypen im **Screen Designer** zu definieren.

## Warum Anfragetypen verwenden?

Der Hauptvorteil von Anfragetypen ist eine effizientere Bearbeitung von Anfragen. Ein spezifischer Anfragetyp kann Attribute enthalten, die für einen bestimmten Prozess erforderlich sind.

## Beispiel

Das Finanzteam nutzt Anfragen zur Verwaltung eingehender Rechnungsansprüche und benötigt die **Rechnungsnummer** als festgelegtes Feld. Das Vertriebsteam hingegen nutzt Anfragen zur Bearbeitung eingehender **Leads**. Da eine Rechnungsnummer für einen Lead nicht relevant ist, sollte dieses Feld für den Vertrieb vollständig ausgeblendet werden.

## Wo finde ich die Anfragetypen?

* In **Einstellungen und Verwaltung** wählen Sie im Navigator **Anfragen** und dann den Tab **Anfragetypen**.

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
