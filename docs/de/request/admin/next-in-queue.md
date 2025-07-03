---
uid: help-de-request-next-in-queue
title: Nächste Anfrage in der Warteschlange abrufen
description: Nächste Anfrage in der Warteschlange abrufen
keywords: nächste Anfrage in Warteschlange, Warteschlange, Kategorie, Anfrage, Zuordnungsmethode
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
content_type: howto
audience: person
audience_tooltip: SuperOffice Service
language: de
redirect_from: /de/request/learn/next-in-queue
---

# So richten Sie "Nächste Anfrage in der Warteschlange anzeigen" ein

In SuperOffice werden Anfragen normalerweise gemäß einer Zuordnungsmethode den Benutzern zugewiesen. Eine weitere Möglichkeit, Anfragen einzelnen Bearbeitern zuzuweisen, besteht darin, neue Anfragen in **Anfragen** > **Nicht zugewiesene Anfragen** zu stellen. Die Bearbeiter müssen die Anfragen dann manuell akzeptieren.

Es kann jedoch auch ein intelligentes Warteschlangensystem für die Bearbeitung neuer Anfragen eingerichtet werden. Bearbeiter können dann unter **Anfragen** auf **Nächste Anfrage in der Warteschlange anzeigen** klicken, um die nächste Anfrage in der Warteschlange zu akzeptieren. Anfragen in der Warteschlange werden nach [Kategorie][2] gefiltert, sodass Benutzer nur Anfragen erhalten, die Kategorien angehören, in denen sie Mitglied sind.

## Wie werden Anfragen in der Warteschlange priorisiert?

Die Reihenfolge der Anfragen in der Warteschlange wird durch die Bearbeitungsfrist jeder Anfrage bestimmt. Anfragen mit der kürzesten Frist erscheinen zuerst. Die Bearbeitungsfrist wird anhand der Prioritäten für Person, Firma, Postfach, E-Mail-Filter und Standardpriorität berechnet.

Dies stellt sicher, dass Anfragen in einer logischen und fairen Reihenfolge priorisiert werden.

> [!NOTE]
> Es ist auch möglich, eine Kombination aus Warteschlangensystem und Zuordnungsmethode zu nutzen. Anfragen können je nach Kategorie entweder in die Warteschlange gestellt oder Benutzern direkt zugewiesen werden.

## Welche Anfragen können aus der Warteschlange abgerufen werden?

Die folgenden Faktoren bestimmen, welche Anfragen ein Bearbeiter aus der Warteschlange abrufen kann:

* Die Anfragen müssen einen Anfragestatus mit aktiviertem **Warteschlangenstatus** aufweisen.
* Die Anfragen müssen eine Kategorie aufweisen, in der der Bearbeiter Mitglied ist.
* Der Eigentümer der Anfrage muss **Nicht zugeordnet** sein.

## Neuen Anfragestatus "In Warteschlange" erstellen

Zunächst wird ein neuer Anfragestatus erstellt: **In Warteschlange**. Neue Anfragen sollen automatisch diesem Status zugewiesen werden.

1. [!include[Gehe zu](../../learn/includes/goto-sm.md)]

1. Wählen Sie **Anfragen** > **Anfragestatus**.

1. Klicken Sie auf die Schaltfläche **Hinzufügen**.

1. Geben Sie im Feld **Name** einen aussagekräftigen Namen für den Anfragestatus ein, z. B. "In Warteschlange".

1. Wählen Sie im Listenfeld **Interner Status** die Option **Offen**.

1. Aktivieren Sie **Standard**, damit allen neuen (aktiven) Anfragen dieser Status standardmäßig zugewiesen wird.

1. Aktivieren Sie **Warteschlangenstatus**, damit Benutzer Anfragen mit diesem Status aus der Warteschlange abrufen können.

    > [!NOTE]
    > Dies bedeutet nicht, dass diese Anfragen ausschließlich über die Warteschlange bearbeitet werden müssen. Mithilfe von Kategorien wird festgelegt, welche Anfragen in die Warteschlange gelangen und welche über die Zuordnungsmethode der Kategorie verteilt werden.

1. **Neue Anfrage bei Kundenantwort erstellen** muss nicht aktiviert werden.

1. Wählen Sie in der Liste **Zeit nachverfolgen als** die Option **In Warteschlange**.

1. Klicken Sie auf **Speichern**.

Der neue Anfragestatus wird in der Liste angezeigt. Die Spalten **Standard** und **Warteschlangenstatus** sind nun markiert.

## Kategorien nutzen, um Anfragen in die Warteschlange zu stellen

Nun müssen Sie sicherstellen, dass Sie Mitglied der Kategorie oder Kategorien sind, die Sie verwalten werden. Außerdem muss angegeben werden, dass Anfragen in diesen Kategorien nicht über eine Zuordnungsmethode zugewiesen werden.

> [!NOTE]
> Mitgliedschaften in Kategorien können auch auf Gruppenebene definiert werden. In **Einstellungen und Verwaltung** (**Benutzer** > **Benutzergruppen**) können Sie Kategorien für verschiedene Benutzergruppen zuweisen.

### Schritte

1. [!include[Gehe zu](../../learn/includes/goto-sm.md)]

1. Wählen Sie **Anfragen** > **Kategorien**.

1. Klicken Sie auf den Namen der gewünschten Kategorie. Dies öffnet die **Eigenschaften der Kategorie**.

1. Wählen Sie die Registerkarte **Mitglieder**.

1. Wählen Sie sich selbst in der Liste **Benutzer** und klicken Sie auf **+**, um sich als Mitglied der Kategorie hinzuzufügen.

1. Fügen Sie ggf. weitere Benutzer als Mitglieder dieser Kategorie hinzu.

1. Wechseln Sie zur Registerkarte **Zuordnungsmethode** und wählen Sie **Keine Zuordnung**. Anfragen dieser Kategorie werden nun nicht mehr automatisch zugewiesen.

1. Klicken Sie auf **Speichern**.

Wiederholen Sie diesen Vorgang bei Bedarf für andere Kategorien, die aus der Warteschlange abrufbar sein sollen. Kategorien, die einer Zuordnungsmethode folgen, werden Benutzern direkt zugewiesen und erscheinen daher nicht in der Warteschlange.

## Neuen Status für Anfragen aus der Warteschlange festlegen

Wenn eine Anfrage aus der Warteschlange abgerufen wurde, sollte ihr Status automatisch von **In Warteschlange** zu **Offen** (oder einem anderen aktiven Status, der auf eine Bearbeitung hinweist) geändert werden.

## Funktion der Warteschlange überprüfen

Erstellen Sie eine neue Anfrage, setzen Sie den **Eigentümer** auf **Nicht zugeordnet**, wählen Sie eine Kategorie, in der Sie Mitglied sind, und setzen Sie den **Status** auf **In Warteschlange**. Klicken Sie dann auf **Anfragen** > **Nächste Anfrage in der Warteschlange anzeigen**.

<!-- Referenced links -->
[2]: category/index.md
