---
uid: help-de-sync-configure-list-mapping
title: Listenzuordnung konfigurieren
description: Listenzuordnung konfigurieren
author: Bergfrid Dias
so.date: 03.29.2023
keywords: Angebot, Sync, Connector, ERP, Zuordnung
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: de
---

# Listenzuordnung konfigurieren

Wenn Daten zwischen SuperOffice und ERP-Systemen synchronisiert werden, müssen Sie festlegen, welches SuperOffice-Feld zu welchem ERP-Feld gehört.

> [!NOTE]
> Wenn Sie eine ERP-Verbindung bearbeiten, müssen Sie diese zuerst deaktivieren.

1. [!include[Go to sync](../includes/goto-sync.md)]

1. Wählen Sie die ERP-Verbindung aus und klicken Sie unten auf die Schaltfläche **Listenzuordnung**.

1. Wählen Sie eine Liste aus. Die verfügbaren Feldobjekte werden rechts vom Dialogfeld angezeigt.

    Wenn keine Listen angezeigt werden, müssen Sie die [Feldzuordnung konfigurieren][1].

1. Wählen Sie für jedes ERP-Objekt das entsprechende CRM-Objekt aus.

    > [!NOTE]
    > Die Zuordnung erfolgt „eins-zu-eins“. Sie können dasselbe CRM-Objekt nicht zweimal zuordnen. Doppelt zugeordnete Listenobjekte werden ROT angezeigt. Wenn ein ERP-Listenobjekt ohne Zuordnung bleiben soll, wählen Sie **(Keine Selektion)**.

1. Gehen Sie zum Zuordnen von Listenobjekten der nächsten Liste wie in Schritt 4 und 5 erläutert vor.

1. Aktivieren Sie die Option **Aktiv** für die ERP-Verbindung, die Sie bearbeitet haben.

<!-- Referenced links -->
[1]: sync-configure-field-allocation.md

<!-- Referenced images -->
