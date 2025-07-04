---
uid: help-de-request-priority
title: Anfrageprioritäten
description: Anfrageprioritäten
keywords: Anfragepriorität, Priorität, Eskalation, Anfrage
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
content_type: concept
license: serviceessentials
audience: settings
audience_tooltip: Einstellungen und Verwaltung
language: de
redirect_from: /de/request/learn/priority/index
---

# Anfrageprioritäten

Allen in SuperOffice erfassten Anfragen wird eine Priorität zugewiesen, die die Wichtigkeit der Anfrage widerspiegelt.

Standardmäßig stehen im System die Prioritäten **Hoch**, **Mittel** und **Niedrig** zur Verfügung. Sie können jedoch sowohl neue Prioritäten hinzufügen als auch die Einstellungen vorhandener Prioritäten bearbeiten.

Die Priorität, die einer Anfrage zugewiesen wird, kann auf Grundlage der folgenden Faktoren bestimmt werden:

* Die Person
* Die Firma
* Das Postfach
* Ein E-Mail-Filter

Nachdem einer Anfrage eine Priorität zugewiesen wurde, kann diese zur Steuerung einer Eskalation der Anfrage verwendet werden.

Zum Beispiel: Sie können festlegen, dass die Anfragen einer bestimmten Firma eine **VIP-Priorität** erhalten und dass Sie per E-Mail benachrichtigt werden, falls die Anfrage nicht bis zu einer bestimmten Frist gelesen wurde.

## Reihenfolge der Prioritätsüberschreibung

Prioritäten setzen andere Prioritäten in folgender Reihenfolge außer Kraft:

1. Priorität für einen E-Mail-Filter
1. Priorität für eine Person
1. Priorität für eine Firma
1. Priorität für ein E-Mail-Postfach
1. Standardprioritäten

Aufgrund dieser Reihenfolge wird der Anfrage einer Person mit hoher Priorität auch dann eine hohe Priorität zugewiesen, wenn das Postfach, an das die E-Mail gesendet wird, eine niedrige Priorität hat.

## Eskalation

Sie können beliebig viele Prioritäten für Anfragen definieren. Für jede Priorität können Eskalationsstufen festgelegt werden, sodass das System eine Anfrage automatisch weiterleitet, falls sie nicht innerhalb eines bestimmten Zeitraums gelesen oder bearbeitet wurde.

Zum Beispiel können **Kundensupport- und Servicelevel-Vereinbarungen (SLA)** festlegen, dass ein Anbieter innerhalb von zwei Stunden mit der Fehlerbehebung beginnen muss. Sie können dann Regeln erstellen, die eine Eskalation der Anfrage auslösen und sie an einen anderen Bearbeiter weiterleiten, wenn sie nicht innerhalb der festgelegten Zeit bearbeitet wurde. Zusätzlich können Benachrichtigungen an Mobiltelefone gesendet werden.

## Zugänglichkeit

Jeder Priorität ist eine **Zugänglichkeitsoption** zugewiesen. Falls die Priorität einer Anfrage auf **Extern** gesetzt ist, kann sie über das **SuperOffice Kundenzentrum** ausgewählt werden.

Falls mehr als zwei Prioritäten extern verfügbar sind, kann der Kunde die gewünschte Priorität für seine Anfrage auswählen. Dadurch kann es vorkommen, dass Kunden ihren Anfragen eine unnötig hohe Priorität zuweisen, um eine schnellere Antwort zu erhalten. Um dies zu vermeiden, sollten die höchsten Prioritäten auf **Intern** gesetzt werden, während **Mittel** und **Niedrig** extern verfügbar sind.

## Verwandte Inhalte

* [Priorität erstellen][1]
* [Prioritäten löschen][2]
* [Eskalationsstufen erstellen][3]

<!-- Referenced links -->
[1]: create.md
[2]: delete.md
[3]: escalation-levels.md
