---
uid: help-de-request-type-create
title: Anfragetyp erstellen
description: Anfragetyp erstellen
keywords: Anfragetyp erstellen, neuer Anfragetyp, Anfragetyp hinzufügen, Anfragetyp, Anfragetypliste, Typ, Anfrage
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
topic: howto
license: servicepremium
audience: settings
audience_tooltip: Einstellungen und Verwaltung
language: de
---

# Anfragetyp erstellen

## Schritte

1. Wählen Sie in Einstellungen und Verwaltung im Navigator den Bereich **Anfragen** aus.

1. Wechseln Sie zur Registerkarte **Anfragetypen**.

1. Klicken Sie auf die Schaltfläche **Hinzufügen**.

    ![Einstellungen und Verwaltung, Anfragetypliste -screenshot][img1]

1. Geben Sie einen kurzen, beschreibenden **Namen** für den neuen Anfragetyp ein. Weitere Details können Sie im Feld **Beschreibung** hinzufügen.

1. Optional: Ändern Sie das Symbol, um Anfragen dieses Typs visuell von anderen Anfragen zu unterscheiden.

1. Aktivieren Sie **Als Standard verwenden**, wenn dieser Anfragetyp standardmäßig für alle neuen Anfragen verwendet werden soll.

1. Optional: Filtern Sie die Liste der verfügbaren Status und/oder Prioritäten für Anfragen dieses Typs.

    * Lassen Sie das Verfügbarkeitsfeld leer, um alle [Status][4] oder [Prioritäten][3] zuzulassen.
    * Wenn Sie einen oder mehrere Status auswählen, müssen Sie auch einen Standardstatus festlegen.
    * Wenn Sie eine oder mehrere Prioritäten auswählen, müssen Sie auch eine Standardpriorität festlegen.

    ![Einstellungen und Verwaltung, Anfragetypen Status/Priorität -screenshot][img3]

1. Optional: Wählen Sie einen Standardstatus und/oder eine Standardpriorität aus, die verwendet wird, wenn ein Agent eine Anfrage dieses Typs erstellt. (Obligatorisch, falls Verfügbarkeiten festgelegt wurden.) Diese Einstellung hat Vorrang vor anderen Präferenzen.

1. Optional: Wählen Sie eine [Antwortvorlage][5] aus, die verwendet wird, wenn ein Agent auf eine Anfrage dieses Typs antwortet.

    ![Einstellungen und Verwaltung, Anfragetyp-Einstellungen -screenshot][img2]

1. Klicken Sie auf **Speichern**. Der Anfragetyp wird erstellt.

<!-- Referenced links -->
[3]: ../priority/index.md
[4]: ../status/index.md
[5]: ../../reply-templates/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/request/add-request-type.png
[img2]: ../../../../media/loc/en/request/request-type-settings.png
[img3]: ../../../../media/loc/en/request/add-request-type-status-priority.png
