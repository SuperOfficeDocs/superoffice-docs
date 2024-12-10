---
uid: help-de-request-priority
title: Anfrageprioritäten
description: Anfrageprioritäten
keywords: Anfrage, Priorität
author: Hanne Gunnarsson
date: 12.10.2024
topic: concept
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Anfrageprioritäten

Allen in SuperOffice Service erfassten Anfragen wird eine Priorität zugewiesen, die die Wichtigkeit der Anfrage widerspiegelt.

Standardmäßig stehen im System die Prioritäten **Hoch**, **Mittel** und **Niedrig** zur Verfügung. Sie können jedoch sowohl neue Prioritäten hinzufügen als auch die Einstellungen vorhandener Prioritäten bearbeiten.

Die Priorität, die einem Fall zugewiesen wird, kann bestimmt werden durch z. B.:

* Die Person
* Die Firma
* Das Postfach
* Ein E-Mail-Filter

Nachdem einer Anfrage eine Priorität zugewiesen wurde, kann diese zur Steuerung einer Eskalation der Anfrage verwendet werden.

Zum Beispiel: Sie können festlegen, dass die Anfragen einer bestimmten Firma eine sehr hohe Priorität erhalten sollen und dass Sie per E-Mail benachrichtigt werden sollen, wenn die Anfrage nicht innerhalb eines festgelegten Zeitraums gelesen wird.

## Reihenfolge überschreiben

Prioritäten setzen andere Prioritäten in folgender Reihenfolge außer Kraft:

1. Priorität für einen E-Mail-Filter
1. Priorität für eine Person
1. Priorität für eine Firma
1. Priorität für ein E-Mail-Postfach
1. Standardprioritäten

Wegen dieser Reihenfolge wird der Anfrage einer Person mit hoher Priorität auch dann eine hohe Priorität zugeordnet, wenn das Postfach, an das die E-Mail gesendet wird, eine niedrige Priorität hat.

## Eskalation

Sie können in SuperOffice Anfragen beliebig viele Prioritäten festlegen. Für jede Priorität können Eskalationsstufen definiert werden, sodass das System eine Anfrage innerhalb des Unternehmens weiterleitet, wenn sie nicht innerhalb eines festgelegten Zeitraums gelesen oder bearbeitet wird.

Zum Beispiel Kundensupport- und Servicelevel-Vereinbarungen (SLA), die festlegen, dass der Lieferant beispielsweise innerhalb von zwei Stunden mit der Fehlerbehebung beginnen muss. Anschließend können Sie Vorgänge festlegen, die eine Eskalation der Anfrage verursachen, welche einem neuen Bearbeiter zugewiesen wird, wenn sie nicht innerhalb des festgelegten Zeitraums gelesen oder bearbeitet wurde. Sie können beliebig viele Vorgänge definieren und sich zudem über Ihr Mobiltelefon benachrichtigen lassen.

## Zugänglichkeit

Jeder Priorität ist eine Eigenschaft bezüglich der Verfügbarkeit zugewiesen. Wenn die Priorität der Anfrage auf **Extern** gesetzt ist, ist sie über das SuperOffice Kundenzentrum zugänglich.

Wenn mehr als zwei Prioritäten extern verfügbar sind, kann der Kunde auswählen, welche Priorität für seine Anfrage gelten soll. Deshalb kann es vorkommen, dass Kunden ihren Anfragen eine unnötig hohe Priorität zugewiesen haben, weil der Kunde so schnell wie möglich eine Antwort erhalten möchte und häufig die höchste Prioritätsstufe auswählen wird. Aus diesem Grund sollte die höchste Prioritätsstufe auf **Intern** gesetzt werden und die Stufen **Mittel** und **Niedrig** extern verfügbar sein.

## Was möchten Sie als Nächstes tun?

* [Priorität erstellen][1]
* [Prioritäten löschen][2]
* [Eskalationsstufen erstellen][3]

<!-- Referenced links -->
[1]: create.md
[2]: delete.md
[3]: escalation-levels.md

<!-- Referenced images -->
