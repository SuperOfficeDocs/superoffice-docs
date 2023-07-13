---
uid: help-de-request-next-in-queue
title: Nächste Anfrage in der Warteschlange anzeigen
description: Nächste Anfrage in der Warteschlange anzeigen
author: Hanne Gunnarsson
so.date: 03.29.2023
keywords: Anfrage
so.topic: howto
so.audience: person
so.audience.tooltip: SuperOffice Service
language: de
---

# So richten Sie „Nächste Anfrage in der Warteschlange anzeigen“ ein

In SuperOffice werden Anfragen normalerweise gemäß einer Zuordnungsmethode den Benutzern zugeordnet. Eine weitere Möglichkeit, Anfragen einzelnen Bearbeitern zuzuordnen, besteht darin, neue Anfragen in **Anfragen** > **Nicht zugeordnete Anfragen** zu stellen. Die Bearbeiter müssen die Anfragen dann manuell akzeptieren.

Es kann aber auch ein intelligentes Warteschlangensystem für die Verarbeitung neuer Anfragen eingerichtet werden. Bearbeiter können dann unter **Anfragen** auf **Nächste Anfrage in der Warteschlange anzeigen** klicken, um die nächste Anfrage in der Warteschlange zu akzeptieren. Anfragen in der Warteschlange werden je nach [Kategorie][2] gefiltert, damit Benutzern nur Anfragen zugeordnet werden, die Kategorien angehören, bei denen sie Mitglied sind.

## Wie werden Anfragen in der Warteschlange priorisiert?

Die Reihenfolge der Anfragen in der Warteschlange wird durch die Bearbeitungsfrist für jede einzelne Anfrage bestimmt. Die Anfragen mit den nächstgelegenen Fristen kommen zuerst in der Warteschlange. Die Bearbeitungsfrist wird gemäß Prioritäten berechnet, die für Person, Firma, Postfach, E-Mail-Filter und Standardpriorität definiert wurden.

Hierdurch wird sichergestellt, dass Anfragen in einer logischen und gerechten Reihenfolge priorisiert werden.

> [!NOTE]
> Es ist auch möglich, eine Kombination von Warteschlangensystem und Zuordnungsmethode zu verwenden. Anfragen können zum Beispiel in die Warteschlange gestellt oder Benutzern zugewiesen werden, je nach dem, welcher Kategorie die Anfragen angehören.

## Welche Anfragen können von der Warteschlange aus abgefragt werden?

Die folgenden Faktoren entscheiden darüber, welche Anfragen ein Bearbeiter aus der Warteschlange abrufen kann:

* Die Anfragen müssen einen Anfragestatus mit aktiviertem **Warteschlangenstatus** aufweisen.
* Die Anfragen müssen eine Kategorie aufweisen, in der der Bearbeiter Mitglied ist.
* Der Eigentümer der Anfrage muss **Nicht zugeordnet** sein.

## Neuen Anfragestatus „in Warteschlange“ erstellen

Zuerst werden wir einen neuen Anfragestatus erstellen: **In Warteschlange**. Neuen Anfragen sollte automatisch dieser Anfragestatus zugewiesen werden.

1. [!include[Go to](../../learn/includes/goto-sm.md)]

1. Wählen Sie **Anfragen** > **Anfragestatus** aus.

1. Klicken Sie auf die Schaltfläche **Hinzufügen**.

1. Geben Sie in das Feld **Name** einen aussagekräftigen Namen für den Anfragestatus ein. Zum Beispiel „In Warteschlange“.

1. Wählen Sie im Listenfeld **Interner Status** **Offen**.

1. Aktivieren Sie die Option **Standard**, sodass allen neuen Anfragen (aktiven Anfragen) standardmäßig dieser Status zugewiesen wird.

1. Aktivieren Sie **Warteschlangenstatus**. Die Benutzer können jetzt Anfragen mit diesem Status aus der Warteschlange zu erhalten.

    > [!NOTE]
    > Dies bedeutet nicht, dass diese Anfragen aus der Warteschlange abgerufen werden MÜSSEN. Mithilfe von Kategorien wird entschieden, welche Anfragen in die Warteschlange gestellt und welche Anfragen entsprechend der Zuordnungsmethode für die Kategorie verteilt werden.

1. Sie müssen **Neue Anfrage bei Kundenantwort erstellen** nicht aktivieren.

1. Wählen Sie in der Liste **Zeit nachverfolgen als** **In Warteschlange**.

1. Klicken Sie auf **Speichern**.

Der neue Anfragestatus wird in der Liste angezeigt und die Spalten **Standard** und **Warteschlangenstatus** sind mit einem Häkchen markiert.

## Verwenden Sie Kategorien, um Anfragen in die Warteschlange zu stellen

Jetzt müssen Sie sicherstellen, dass Sie ein Mitglied der Kategorie oder Kategorien sind, die Sie verwalten werden. Zudem muss angegeben werden, dass Anfragen, die diesen Kategorien angehören, nicht entsprechend der Zuordnungsmethode zugeordnet werden sollen.

> [!NOTE]
> Mitgliedschaft in Kategorien kann auch auf Gruppenebene definiert werden. In Einstellungen und Verwaltung (**Benutzer** > **Benutzergruppen**) können Sie Kategorien für die unterschiedlichen Benutzergruppen angeben.

**Schritte:**

1. [!include[Go to](../../learn/includes/goto-sm.md)]

1. Wählen Sie **Anfragen** > **Kategorien** aus.

1. Klicken Sie auf den Namen der gewünschten Kategorie. Sie gelangen zur Ansicht **Eigenschaften der Kategorie**.

1. Wählen Sie die Registerkarte **Mitglieder** aus.

1. Wählen Sie sich selbst in der Liste **Benutzer** und klicken Sie auf ![Symbol][img1], um sich selbst als Mitglied der Kategorie hinzuzufügen.

1. Fügen Sie ggf. andere Benutzer als Mitglieder dieser Kategorie hinzu.

1. Wählen Sie die Registerkarte **Zuordnungsmethode** und wählen Sie **Keine Zuordnung**. Jetzt werden Anfragen in dieser Kategorie nicht Benutzern entsprechend der Zuordnungsmethode zugeordnet.

1. Klicken Sie auf **Speichern**.

Wiederholen Sie diesen Vorgang bei Bedarf für andere Kategorien, die verfügbar sein sollten, um aus der Warteschlange abgefragt zu werden. Kategorien, die einer Zuordnungsmethode folgen, wird ein Benutzer zugeordnet, und sie werden daher nicht in die Warteschlange gestellt.

<!-- markdownlint-disable-next-line MD013 -->
## Definieren Sie einen neuen Status für Anfragen, die aus der Warteschlange abgefragt werden

Wenn Sie eine Anfrage aus der Warteschlange abgefragt haben, muss der Status von **In Warteschlange** zu **Offen** (oder einem anderen aktiven Status, der bedeutet, dass die Anfrage bearbeitet wird) wechseln. Dies geschieht normalerweise automatisch.

## Stellen Sie sicher, dass die Warteschlange funktioniert

Erstellen Sie eine neue Anfrage, stellen Sie **Eigentümer** auf **Nicht zugeordnet**, wählen Sie die Kategorie, bei der Sie Mitglied sind und stellen Sie **Status** auf **In Warteschlange**. Klicken Sie dann versuchsweise auf **Anfragen** > **Nächste Anfrage in der Warteschlange anzeigen**.

<!-- Referenced links -->
[2]: category/index.md

<!-- Referenced images -->
[img1]: ../../../media/icons/btn-add.png
