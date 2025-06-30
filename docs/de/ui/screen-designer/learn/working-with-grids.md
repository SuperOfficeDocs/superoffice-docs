---
uid: help-de-screen-designer-grid
title: Arbeiten mit Gittern
description: So fügen Sie Raster in ein Layout ein und befüllen sie mit dem Ansichtsdesigner in Einstellungen und Verwaltung.
keywords: Ansichtsdesigner, Benutzeroberfläche, Layout, Gitter
author: Bergfrid Dias
date: 10.07.2024
version: 10
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Arbeiten mit Gittern

[!include[Anforderung](../../../../../common/includes/req-dev-tools.md)]

Wenn Sie viele Felder haben, können Sie ein Gitterelement verwenden, um sie präziser anzuordnen. Dies ist eine Alternative zur Positionierung basierend auf Sortierreihenfolge und Spalten.

Die folgenden Anweisungen setzen voraus, dass Sie bereits [das Layout bearbeiten][1].

## Gitter hinzufügen

1. Wählen Sie die Registerkarte, zu der Sie ein Gitter hinzufügen möchten.

1. Klicken Sie auf den Abschnitt **Elemente**.

1. Klicken und ziehen Sie das **Gitter**-Element in das Layout.

    ![Ansichtsdesigner, Gitterelement -screenshot][img1]

1. Klicken Sie, um das neue Gitter auszuwählen.

1. Passen Sie im Abschnitt **Einstellungen** links die Anzahl der Spalten und Zeilen an Ihre Bedürfnisse an.

    ![Ansichtsdesigner, Gittereinstellungen -screenshot][img2]

1. Wählen Sie einen Gitterstil: Linien (Standard), keine oder Kopfzeile.

## Feld zum Gitter hinzufügen

1. Gehen Sie zur Position des Gitters.

1. Halten Sie den Mauszeiger über das Gitter und klicken Sie auf den blauen Stift.

    ![Ansichtsdesigner-Gitter in den Bearbeitungsmodus wechseln -screenshot][img3]

    Dadurch wird das Gitter in den Bearbeitungsmodus versetzt, was durch ein grünes Häkchen angezeigt wird.

    ![Ansichtsdesigner-Gitter im Bearbeitungsmodus -screenshot][img4]

1. Stellen Sie sicher, dass der Abschnitt **Felder** ausgewählt ist.

1. [Ziehen Sie Felder aus der Liste][2] in eine Zelle des Gitters. Sie können auch [Beschriftungen][3], [Links und Schaltflächen][4] hinzufügen.

    > [!TIP]
    > Tabben Sie von Zelle zu Zelle für eine effiziente Eingabe.

1. Wenn Sie fertig sind, klicken Sie auf das grüne Häkchen, um das Gitter zu sperren und den normalen Bearbeitungsmodus wieder aufzunehmen.

## Gitterinhalte bearbeiten

1. Versetzen Sie das Gitter in den Bearbeitungsmodus, wie oben beschrieben.

1. Um ein Feld zu verschieben, klicken Sie auf **=** links neben dem Feld und ziehen Sie es in eine neue Zelle.

    Wenn Sie ein Feld in eine besetzte Zelle ablegen, werden die Inhalte der beiden Zellen getauscht.

1. Um ein Feld zu entfernen, halten Sie den Mauszeiger über die Zelle und klicken Sie auf das rote eingekreiste x.

## Gitteraussehen bearbeiten

1. Wählen Sie die Registerkarte, die das Gitter enthält.

1. Klicken Sie auf das Gitter in der Vorschau. Stellen Sie sicher, dass sich das Gitter selbst nicht im Bearbeitungsmodus befindet. Klicken Sie auf das grüne Häkchen, wenn Sie es sehen.

1. Passen Sie im Abschnitt **Einstellungen** die Abmessungen und den Stil des Gitters an.

> [!NOTE]
> Sie können keine bestimmten Zeilen oder Spalten entfernen, jedoch können Sie die Anzahl der Zeilen und Spalten verringern. Wenn Sie die Anzahl der Zeilen verringern, verschwindet die **letzte Zeile** zusammen mit ihren Inhalten aus der Benutzeroberfläche. Wenn Sie die Anzahl der Spalten verringern, verschwindet die **letzte Spalte**. Ordnen Sie Ihre Felder zuerst neu, um Überraschungen zu vermeiden.

## Gitter verschieben

Um ein Gitter zu verschieben, klicken Sie auf **=** links vom Gitter und ziehen Sie das Feld an eine neue Position. Dies ähnelt dem Verschieben von Feldern.

## Gitter entfernen

Wenn Sie ein Gitter entfernen, werden auch seine Inhalte (Felder usw.) entfernt.

Diese Aktion betrifft nur, was in der Benutzeroberfläche angezeigt wird, und ändert in keiner Weise die Datenbank oder Werte.

Um ein Gitter zu entfernen:

* Halten Sie den Mauszeiger über das Gitter und klicken Sie auf das rote eingekreiste x.

Um ein Gitter wiederherzustellen:

* Wenn Sie an einem Entwurf arbeiten, verwerfen Sie einfach den Entwurf, um alle Ihre Änderungen rückgängig zu machen.
* Wenn Sie das Layout nach dem Entfernen veröffentlicht haben, müssen Sie das Gitter neu erstellen.

<!-- Referenced links -->
[1]: edit-layout.md
[2]: working-with-fields.md
[3]: working-with-tabs.md#label
[4]: add-button.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/ui/new-grid.png
[img2]: ../../../../media/loc/en/ui/grid-settings.png
[img3]: ../../../../media/loc/en/ui/hover-grid.png
[img4]: ../../../../media/loc/en/ui/edit-grid.png
