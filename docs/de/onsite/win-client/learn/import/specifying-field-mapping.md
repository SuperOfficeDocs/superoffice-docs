---
uid: help-de-specifying-field-mapping
title: Feldzuordnung festlegen
description: Feldzuordnung festlegen
author: SuperOffice RnD
date: 06.29.2022
keywords: Einstellungen für den Windows-Client
content_type: howto
language: de
client: win
deployment: onsite
---

# Feldzuordnung festlegen

1. [!include[How to open import](includes/open-import.md)]

1. [!include[Select file](includes/step-select-file.md)]

1. Der Inhalt des ersten Datensatzes in der Importdatei wird unter **Feldzuordnung** in der Spalte **Feld in Datei** angezeigt. Wählen Sie ein Feld aus, das Sie in die Datenbank importieren möchten.

1. Klicken Sie unter **Feldzuordnung** auf die Schaltfläche **Zuordnung**.

    > [!NOTE]
    > Sie können auch auf das zu importierende Feld doppelklicken.

1. Der Name des aktuellen Feldes in der Importdatei wird im Dialogfeld **Feldzuordnung** in **Feld in Importdatei** angezeigt. Wählen Sie im Listenfeld **Tabelle wählen** den Datentyp aus, den Sie in die SuperOffice-Datenbank importieren möchten (zum Beispiel Firmen).

1. Die verfügbaren Felder für den unter **Tabelle wählen** ausgewählten Datentyp werden in der Tabelle **Name** angezeigt, mit Ausnahme der Felder, die bereits zugeordnet wurden. Wählen Sie ein Feld für die Zuordnung aus.

1. Klicken Sie auf **OK**. Die Informationen unter **Feldzuordnung** in der Ansicht **Import** werden aktualisiert.

    [!include[Save mapping](includes/tip-save-mapping.md)]

1. Wiederholen Sie diese Schritte, um weitere Felder zuzuordnen. Sie können eine Reihe verschiedener Datentypen importieren. Denken Sie daran, dass Felder, die keinem Datensatz in der SuperOffice-Datenbank zugeordnet sind, nicht importiert werden.

> [!NOTE]
> Wenn Sie im Feld **Importbeschreibung laden** eine Importbeschreibungsdatei festgelegt haben, sind unter **Feldzuordnung** möglicherweise bereits Informationen in der Spalte **Feld in SuperOffice CRM** eingetragen. Ändern Sie bei Bedarf die Feldzuordnung, indem Sie die [Feldzuordnung löschen][1] und anschließend eine neue Feldzuordnung eingeben.

<!-- Referenced links -->
[1]: deleting-field-mapping.md

<!-- Referenced images -->
