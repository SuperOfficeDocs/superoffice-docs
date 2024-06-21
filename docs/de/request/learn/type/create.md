---
uid: help-de-request-type-create
title: Anfragetyp erstellen
description: Anfragetyp erstellen
author: Bergfrid Dias
date: 02.22.2024
version: 10.3.2
keywords: Anfrage, Typ
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Anfragetyp erstellen

## Schritte

1. In Einstellungen und Vervaltung wählen Sie **Anfragen** im Navigator aus.

1. Wählen Sie den Tab **Anfragestypen** aus.

1. Klicken Sie auf die Schaltfläche **Hinzufügen**.

    ![Einstellungen und Vervaltung, Anfragestypen -screenshot][img1]

1. Geben Sie einen kurzen beschreibenden **Namen** für den neuen Anfragetyp ein. Sie können weitere Details im **Beschreibung**-Feld hinzufügen.

1. Optional ändern Sie das Symbol, um Anfragen dieses Typs visuell von anderen Anfragen zu unterscheiden.

1. Aktivieren Sie **Als Standard verwenden**, wenn Sie möchten, dass dieser Anfragetyp der Standard für alle neuen Anfragen ist.

1. Optional filtern Sie die Liste der verfügbaren Statuskaterorien und/oder Prioritäten für Anfragen dieses Typs.

    * Um jeden [Status][4] oder [Priorität][3] zuzulassen, lassen Sie das Verfügbarkeitsfeld leer.
    * Wenn Sie einen oder mehrere Statusse auswählen, müssen Sie auch einen Standard-Status wählen.
    * Wenn Sie eine oder mehrere Prioritäten auswählen, müssen Sie auch eine Standardpriorität wählen.

    ![Einstellungen und Vervaltung, Anfragestypen Status/Priorität -screenshot][img3]

1. Optional wählen Sie einen Standardstatus und/oder eine Standardpriorität aus, die verwendet werden soll, wenn ein Agent eine Anfrage dieses Typs erstellt. (Obligatorisch, wenn Sie die Verfügbarkeit festlegen.) Diese Einstellung hat Vorrang vor anderen Einstellungen.

1. Optional wählen Sie eine [Antwortvorlage][5] aus, die verwendet werden soll, wenn ein Agent auf eine Anfrage dieses Typs antwortet.

    ![Einstellungen und Vervaltung, Einstellungen für Anfragetypen -screenshot][img2]

1. Klicken Sie auf **Speichern**. Der Anfragetyp ist erstellt.

<!-- Referenced links -->
[3]: ../priority/index.md
[4]: ../status/index.md
[5]: ../../reply-templates/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/request/add-request-type.png
[img2]: ../../../../media/loc/en/request/request-type-settings.png
[img3]: ../../../../media/loc/en/request/add-request-type-status-priority.png
