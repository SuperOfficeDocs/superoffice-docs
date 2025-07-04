---
uid: help-de-request-status-create
title: Anfragestatus erstellen
description: Anfragestatus erstellen
keywords: Anfragestatus erstellen, Anfragestatus hinzufügen, neuer Anfragestatus, Anfragestatus, interner Status, Warteschlangenstatus, Zeitnachverfolgung, Anfrage, Status
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
content_type: howto
license: serviceessentials
audience: settings
audience_tooltip: Einstellungen und Verwaltung
language: de
redirect_from: /de/request/learn/status/create
index: true
---

# Anfragestatus erstellen

## Schritte

1. Klicken Sie im Navigator auf **Anfragen**.

1. Wählen Sie die Registerkarte **Anfragestatus**.

1. Klicken Sie auf die Schaltfläche **Hinzufügen**.

1. Geben Sie im Feld **Name** einen aussagekräftigen Namen für den Anfragestatus ein.

1. Wählen Sie im Listenfeld **Interner Status** den internen Status aus, mit dem Sie Ihren benutzerdefinierten Anfragestatus verknüpfen möchten.

1. Aktivieren Sie **Standard**, wenn dieser Anfragestatus der Standardstatus für den zugehörigen internen Status sein soll.

1. Aktivieren Sie **Warteschlangenstatus**, wenn Anfragen mit diesem Status in die Warteschlange gestellt werden sollen.

1. Aktivieren Sie **Neue Anfrage bei Kundenantwort erstellen**, um zu verhindern, dass alte Anfragen wieder geöffnet werden, weil ein Kunde auf eine alte Nachricht antwortet. Dies kann beispielsweise für Status wie **Bearbeitet** und **Gelöscht** relevant sein.

1. Wählen Sie in der Liste **Zeit nachverfolgen als**, wie die Zeitnutzung erfasst werden soll:

    * In Warteschlange und Verarbeitung ausstehend
    * In interner Entscheidungsphase
    * In externer Entscheidungsphase

1. Klicken Sie auf **Speichern**. Der Anfragestatus wird erstellt.

1. Falls erforderlich, passen Sie die Position des Status mit den Pfeiltasten unterhalb der Statusliste an. Die Reihenfolge hier bestimmt die Platzierung im **Status**-Listenfeld beim Erstellen einer neuen Anfrage. Platzieren Sie die am häufigsten verwendeten Status oben.

## Zugehörige Inhalte

* [So richten Sie "Nächste Anfrage in der Warteschlange abrufen" ein][1]

<!-- Referenced links -->
[1]: ../next-in-queue.md
