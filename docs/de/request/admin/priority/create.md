---
uid: help-de-request-priority-create
title: Priorität erstellen
description: Priorität erstellen
keywords: Anfragepriorität erstellen, Anfragepriorität hinzufügen, neue Anfragepriorität, Anfragepriorität, Prioritäten-Registerkarte, Eskalationsereignisse, Eskalationskette, Eskalationssequenz, Anfrage, Priorität
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
topic: howto
license: serviceessentials
audience: settings
audience_tooltip: Einstellungen und Verwaltung
language: de
---

# Priorität erstellen

Standardmäßig enthält das System die Prioritäten **Hoch**, **Mittel** und **Niedrig**. Sie können jedoch sowohl neue Prioritäten hinzufügen als auch die Einstellungen vorhandener Prioritäten bearbeiten.

[!include[Restricted access](../../../learn/includes/note-insufficient-rights.md)]

## Schritte

1. In Einstellungen und Verwaltung, klicken Sie auf **Anfragen** im Navigator und wählen Sie die Registerkarte **Prioritäten**.

1. Klicken Sie auf die Schaltfläche **Hinzufügen**.

1. Geben Sie einen aussagekräftigen Namen im Feld **Name der Priorität** ein.

1. Geben Sie auf der Registerkarte **Eigenschaften** folgende Informationen ein:

    * **Extern**
    * **Als Standard verwenden**
    * **Frist**
    * **Gelöscht**

    Details zu den einzelnen Feldern finden Sie unter [Prioritätseinstellungen](#priority-settings).

1. Legen Sie unter **Zeitrahmen** den Zeitraum für die Anfragenbearbeitung fest.

    * Definieren Sie Zeitintervalle für jeden Wochentag.

    * Optional können Sie auszuschließende Tage im Feld **Sonn- und Feiertage (Tag/Monat)** angeben. Aktivieren Sie **Einschließlich Jahr**, um das Jahr in diese Daten einzubeziehen.

1. Legen Sie in der Registerkarte **Eskalationsereignisse** fest, wie die Eskalationssequenz auf verschiedene Ereignisse in der Anfrage reagiert. Optionen:

    * Anfrage vom Eigentümer gelesen
    * Benutzer geändert (manuell)
    * Neue Informationen
    * Anfrage geschlossen
    * Priorität geändert

        > [!NOTE]
        > Wenn Sie **Fortsetzen** auswählen, bleibt die Anfrage auf derselben Stufe der Eskalationssequenz wie zuvor. Die Zeiten werden bei einer Änderung nicht berücksichtigt, sondern nur die Stufen.

    * Neue Anfrage
    * Anfragen gemäß Zeitrahmen eskalieren

    Details zu den einzelnen Optionen finden Sie unter [Eskalationsoptionen](#escalation-options).

1. Klicken Sie auf **Speichern**. Die Priorität wird erstellt. Sie können nun beispielsweise [Eskalationsstufen mit dieser Priorität verknüpfen][1].

## <a id="priority-settings"></a>Prioritätseinstellungen

| Einstellung | Beschreibung |
|---|---|
| Name | Ein aussagekräftiger Name für die Priorität. |
| Gelöscht | Gibt an, ob die Priorität aktiv (normal) oder gelöscht (nicht verfügbar) ist. |
| Extern | Falls aktiviert, ist die Priorität im SuperOffice Kundenzentrum sichtbar. |
| Als Standard verwenden | Falls aktiviert, wird diese Priorität als Standardpriorität verwendet. |
| Frist | Die Bearbeitungsfrist für Anfragen mit dieser Priorität. Dieser Wert wird anhand des definierten Zeitrahmens berechnet und für jede Anfrage gespeichert. |
| Zeitrahmen | Zeitintervalle für jeden Wochentag, die für die Anfragenbearbeitung gelten. |
| Sonn- und Feiertage (Tag/Monat) | Tage, die aus dem Zeitrahmen ausgeschlossen werden sollen. Diese werden im Format Tag/Monat angegeben, z. B. **25/12, 26/12** für den 25. und 26. Dezember. |
| Einschließlich Jahr | Falls aktiviert, wird das Jahr in den Feiertagsterminen berücksichtigt. |
| Anfragen gemäß Zeitrahmen eskalieren | Falls aktiviert, werden Anfragen mit dieser Priorität nur während des definierten Zeitrahmens eskaliert. Außerhalb der festgelegten Zeiträume wird die Eskalation "eingefroren". |

## <a id="escalation-options"></a>Eskalationsoptionen

| Option | Beschreibung |
|---|---|
| Anfrage vom Eigentümer gelesen | Falls aktiviert, wird die Eskalationskette gemäß der Auswahl in der rechten Liste gesteuert, wenn der Eigentümer die Anfrage liest. In allen Listenfeldern auf dieser Registerkarte können Sie zwischen **Anhalten**, **Fortsetzen** und **Neu starten** wählen. |
| Benutzer geändert (manuell) | Falls aktiviert, wird die Eskalationskette gemäß der Auswahl in der rechten Liste gesteuert, wenn der Eigentümer einer Anfrage manuell geändert wird. |
| Neue Informationen | Falls aktiviert, wird die Eskalationskette gemäß der Auswahl in der rechten Liste gesteuert, wenn neue Informationen zur Anfrage hinzugefügt werden (z. B. eine neue Nachricht durch den Kunden oder Benutzer). |
| Anfrage bearbeitet | Falls aktiviert, wird die Eskalationskette gemäß der Auswahl in der rechten Liste gesteuert, wenn die Anfrage abgeschlossen wird. |
| Priorität geändert | Falls aktiviert, wird die Eskalationskette gemäß der Auswahl in der rechten Liste gesteuert, wenn die Priorität der Anfrage geändert wird. |
| Neue Anfrage | Falls aktiviert, wird die Eskalationskette gemäß der Auswahl in der rechten Liste gesteuert, wenn eine neue Anfrage mit dieser Priorität im System eingeht. |

<!-- Referenced links -->
[1]: escalation-levels.md
