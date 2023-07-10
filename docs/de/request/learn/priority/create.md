---
uid: help-de-request-priority-create
title: Priorität erstellen
description: Priorität erstellen
author: Hanne Gunnarsson
so.date: 07.03.2023
keywords: Anfrage, Priorität
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance

language: de
---

# Antwortpriorität erstellen

Standardmäßig stehen im System die Prioritäten **Hoch**, **Mittel** und **Niedrig** zur Verfügung. Sie können jedoch sowohl neue Prioritäten hinzufügen als auch die Einstellungen vorhandener Prioritäten bearbeiten.

[!include[Restricted access](../../../learn/includes/note-insufficient-rights.md)]

**Schritte:**

1. Gehen Sie unter Einstellungen und Verwaltung im Navigator auf die Schaltfläche **Anfragen** und wählen Sie die Registerkarte **Prioritäten** aus.

1. Klicken Sie auf die Schaltfläche **Hinzufügen**.

1. Geben Sie einen aussagekräftigen Namen in das Feld **Name der Priorität** ein.

1. Geben Sie auf der Registerkarte **Eigenschaften** folgende Informationen ein:

    * Extern
    * Als Standard verwenden
    * Termin
    * Gelöscht

    Für weitere Details über jedes Feld siehe [Einstellungen der Priorität](#priority-settings).

1. Legen Sie unter **Zeitrahmen** den Zeitraum für die Verarbeitung der Anfrage fest.

    * Legen Sie für jeden Wochentag Zeitintervalle fest.

    * Geben Sie optional die auszuschließenden Tage in das Feld **Sonn- und Feiertage (Tag/Monat)** ein. Wählen Sie **Einschließlich Jahr** aus, um das Jahr in diese Datumsangaben einzubeziehen.

1. Legen Sie auf der Registerkarte **Eskalationsereignisse** fest, was geschehen soll, wenn bestimmte Ereignisse in Bezug auf die Anfrage eintreten. Optionen:

    * Anfrage von Eigentümer gelesen
    * Benutzer geändert (manuell)
    * Neue Informationen
    * Anfrage bearbeitet
    * Priorität geändert

        > [!NOTE]
        > Wenn Sie **Fortsetzen** auswählen, wird die Anfrage auf derselben Stufe in der Eskalationssequenz fortgesetzt, auf der sie vor der Änderung stand. Bei einer Änderung werden also nicht die Zeiten, sondern nur die Stufen verwendet.

    * Neue Anfrage
    * Anfragen gemäß Zeitrahmen eskalieren

    Für weitere Details über diese Option siehe [Einstellungen der Priorität](#escalation-options).

1. Klicken Sie auf **Speichern**. Die Priorität wird erstellt. Sie können jetzt zum Beispiel [Eskalationsstufen mit dieser Priorität verknüpfen][1].

## Prioritätseinstellungen

| Einstellung | Beschreibung |
|---|---|
| Name | Ein aussagekräftiger Namen für die Priorität. |
| Gelöscht | Ist die Priorität aktiv (normal) oder gelöscht (nicht verfügbar).|
| Extern | Wenn Sie diese Option aktivieren, ist die Priorität vom SuperOffice Kundenzentrum verfügbar. |
| Als Standard verwenden | Wenn Sie diese Option aktivieren, wird diese Priorität standardmäßig verwendet. |
| Termin | Die Bearbeitungsfrist für Anfragen mit dieser Priorität. Dieser Wert wird basierend auf dem Zeitrahmen für die Priorität berechnet und für jede Anfrage gespeichert. Das Ergebnis legt fest, wann der Zeitrahmen für die Anfrage abläuft. |
| Zeitrahmen | Zeitintervalle für jeden Wochentag, der für die Anfragenverarbeitung gilt. |
| Sonn- und Feiertage (Tag/Monat) | Tage, die aus dem Zeitrahmen ausgeschlossen werden sollen. In der Regel handelt es sich dabei um Feiertage, an denen Anfragen nicht eskaliert werden sollen. Die Tage werden im Format Tag/Monat aufgelistet und durch Komma voneinander getrennt. Geben Sie z. B. Folgendes ein, um den 25\. und 26. Dezember auszuschließen: 25/12, 26/12. Sie können Daten auch über das Datumsfeld unten hinzufügen. |
| Einschließlich Jahr | Wenn Sie diese Option wählen, wird das Jahr bei den Feiertagsterminen einbezogen. |
| Anfragen gemäß Zeitrahmen eskalieren | Wenn diese Option aktiviert ist, werden Anfragen mit dieser Priorität nur während des definierten Zeitrahmens der Priorität eskaliert. Außerhalb der auf der Registerkarte **Zeitrahmen** festgelegten Zeiträume wird die Eskalation eingefroren.. |

## Eskalationsoptionen

| Option | Beschreibung |
|---|---|
| Anfrage von Eigentümer gelesen | Wenn diese Option aktiviert ist, werden die im Listenfeld auf der rechten Seite festgelegten Aktionen durchgeführt, wenn eine Anfrage vom Eigentümer gelesen wurde. In allen Listenfeldern auf dieser Registerkarte können Sie zwischen folgenden Aktionen wählen: **Anhalten**, **Fortsetzen** und **Neu starten**. |
| Benutzer geändert (manuell) | Wenn diese Option aktiviert ist, werden die im Listenfeld auf der rechten Seite festgelegten Aktionen durchgeführt, wenn der Eigentümer einer Anfrage manuell geändert wird. |
| Neue Informationen | Wenn diese Option aktiviert ist, werden die im Listenfeld auf der rechten Seite festgelegten Aktionen durchgeführt, wenn neue Informationen zu einer Anfrage eingehen. Es kann zum Beispiel eine neue Mitteilung des Kunden oder Benutzers zu der Anfrage sein. |
| Anfrage bearbeitet | Wenn diese Option aktiviert ist, werden die im Listenfeld auf der rechten Seite festgelegten Aktionen durchgeführt, wenn die Bearbeitung einer Anfrage abgeschlossen ist. |
| Priorität geändert | Wenn diese Option aktiviert ist, werden die im Listenfeld auf der rechten Seite festgelegten Aktionen durchgeführt, wenn die Priorität einer Anfrage geändert wird. |
| Neue Anfrage | Wenn diese Option aktiviert ist, werden die im Listenfeld auf der rechten Seite festgelegten Aktionen durchgeführt, wenn eine neue Anfrage mit dieser Priorität im System eingeht. |

<!-- Referenced links -->
[1]: escalation-levels.md

<!-- Referenced images -->
