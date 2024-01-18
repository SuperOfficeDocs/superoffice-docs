---
uid: help-de-udef-move
title: Felder verschieben
description: Felder verschieben
author: SuperOffice RnD
so.date: 06.29.2022
keywords: udef, benutzerdefiniertes Feld
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: de
---

# Felder platzieren

> [!NOTE]
> Die SuperOffice Version 10 (veröffentlicht im Oktober 2021) führte den [Ansichtsdesigner][1] mit anpassbaren Anzeigenlayouts für bestimmte Benutzergruppen ein. Bei benutzerdefinierten, mit dem Ansichtsdesigner erstellten Ansichtslayouts werden die unten beschriebenen Einstellungen möglicherweise überschreiben.

Wenn Sie neue Felder hinzufügen, werden diese standardmäßig untereinander platziert. Jedes Feld besteht aus einer Bezeichnung mit einem Datenfeld auf der rechten Seite. Sie können entscheiden, an welcher Stelle des Rasters diese Felder platziert werden sollen.

## Wie kann ich Felder auswählen?

* Wählen Sie ein Feld im Raster aus, indem Sie darauf klicken.
* Wählen Sie mehrere Felder im Raster durch Klicken und Ziehen aus.
* Klicken Sie auf ein Feld in der Liste **Felder**, um sowohl das Bezeichnungs- als auch das Datenfeld im Raster auszuwählen.

## Wie kann ich Felder verschieben?

* Ziehen Sie das Feld mit gedrückter Maustaste. Die Felder werden automatisch an das Raster angepasst.
* Klicken Sie auf ein Feld und verwenden Sie die Pfeiltasten auf der Tastatur.
* Klicken Sie auf ein Feld und verwenden Sie die Pfeiltasten in der rechten unteren Ecke (![Symbol][img2] ![Symbol][img1] ![Symbol][img4] ![Symbol][img3]).
* Doppelklicken Sie auf ein Feld und legen Sie die Positionswerte **X** und **Y** im Dialogfeld **Felder** fest.

## Wie lege ich die Position fest?

1. In den Feldern rechts neben **Bezeichnung** können Sie Folgendes festlegen:

    **X**: Die horizontale Position der Bezeichnung. Je größer die Zahl ist, desto weiter rechts wird das Feld platziert.

    **Y**: Die vertikale Position der Bezeichnung. Je größer die Zahl ist, desto weiter unten wird das Feld platziert.

2. In den Feldern rechts neben **Daten** können Sie Folgendes festlegen:

    **X**: Die horizontale Position des Datenfelds. Je größer die Zahl ist, desto weiter rechts wird das Feld platziert.

    **Y**: Die vertikale Position des Datenfelds. Je größer die Zahl ist, desto weiter unten wird das Feld platziert.

## Wie kann ich Felder rechts-/linksbündig ausrichten?

Wählen Sie die Felder aus, die Sie anpassen möchten, und klicken Sie unter dem Raster auf linksbündig (![Symbol][img6]) oder rechtsbündig (![Symbol][img5]).

## Wie kann ich die Breite von Feldern ändern?

1. Doppelklicken Sie in der Liste bzw. im Raster **Felder** auf das entsprechende Feld.
2. Im Feld rechts neben **Bezeichnung** können Sie die Breite des Bezeichnungsfeldes festlegen.
3. Im Feld rechts neben **Daten** können Sie die Breite des Datenfeldes festlegen.

## TAB-Reihenfolge der Felder auf der Registerkarte Mehr bearbeiten

Die TAB-Reihenfolge ist die Reihenfolge, in der Sie sich durch Betätigen der TAB-Taste zwischen den verschiedenen Feldern verschieben. Sie können die TAB-Reihenfolge ändern, um die logische Reihenfolge widerzuspiegeln, in der die Benutzer normalerweise Daten in Felder eingeben.

Die TAB-Reihenfolge wird in der Liste **Name** an der linken Seite der Anzeige angezeigt. Diese Reihenfolge ist nicht identisch mit den physischen Positionen der Felder, die im Vorschaufeld oben rechts angezeigt werden.

**Schritte:**

1. [!include[Go to fields and select tab](includes/goto-fields.md)]

1. Wählen Sie das gewünschten Feld in der Liste aus.

1. Klicken Sie auf einen der Pfeile unter der Liste, um das Feld entweder nach oben (![Symbol][img1]) oder nach unten (![Symbol][img2]) zu verschieben.

1. Klicken Sie auf **Veröffentlichen**, wenn Sie möchten, dass die Änderungen für SuperOffice CRM-Benutzer verfügbar sind.

## Seite 1-Felder auswählen

> [!NOTE]
> Diese Funktion ist nicht verfügbar, wenn Ihre Organisation benutzerdefinierte Anzeigenlayouts verwendet.

Unter den benutzerdefinierten Feldern, die in den Registerkarten **Mehr** in SuperOffice CRM angezeigt werden, können *Sie drei* auswählen, die als Felder auf Seite 1 fungieren (so genannt, weil sie auf der "ersten Seite" in ihren jeweiligen Ansichten angezeigt werden).

## Wo kann ich Seite 1-Felder anzeigen?

[!include[List](includes/list-page-1-field-locations.md)]

## Benutzerdefiniertes Feld auf der ersten Seite anzeigen

1. [!include[Go to fields and select tab](includes/goto-fields.md)]

1. Aktivieren Sie **Unterschiedliche Felder auf Seite 1 für unterschiedliche Benutzergruppen zulassen** am unteren Rand der Registerkarte, um unterschiedliche Felder für Seite 1 für verschiedene Benutzergruppen anzugeben. Wenn diese Option nicht aktiviert ist, werden die von Ihnen festgelegten Felder für alle Benutzergruppen verwendet.

1. Wählen Sie in der Liste der Benutzergruppen oben die gewünschte Benutzergruppe aus (wenn Sie im vorherigen Schritt die Option **Unterschiedliche Felder auf Seite 1 für unterschiedliche Benutzergruppen zulassen** aktiviert haben).

1. Wählen Sie im Listenfeld **Feld 1** das Feld aus, das an oberster Position angezeigt werden soll. Wählen Sie in den Listenfeldern **Feld 2** und **Feld 3** die nachfolgend anzuzeigenden Felder aus.

1. Klicken Sie auf **Speichern**, um Ihre Änderungen nur in Einstellungen und Verwaltung zu speichern, oder klicken Sie auf **Veröffentlichen**, um die Änderungen für SuperOffice CRM-Benutzer verfügbar zu machen.

## Benutzergruppen und Felder auf Seite 1

Wenn Sie in der Liste **Benutzergruppe** einen Namen ausgewählt haben, werden die verfügbaren Seite 1-Felder für die relevante Benutzergruppe unter **Feld 1**, **2** und **3** angezeigt.

> [!NOTE]
> Benutzergruppen werden auf der Anzeige **Listen** definiert und auf der Anzeige Benutzer wird die Gruppe, zu der ein Benutzer gehört, festgelegt.

Wenn Sie in der Liste Benutzergruppen **(alle Benutzergruppen)** auswählen, ein oder mehrere Felder auswählen und das Setup speichern, gilt die gleiche Selektion von Feldern für alle **Benutzergruppen** in SuperOffice CRM. Wenn Sie anschließend eine bestimmte Benutzergruppe auswählen, können Sie die vorhandene Feldeinstellung nur für diese Gruppe überschreiben, indem Sie eine andere Einstellung verwenden. Wenn Sie in einem Feld nichts ausfüllen, bleibt es leer – weil die Überschreibung unabhängig von ihrem Inhalt für alle drei Felder gilt.

> [!NOTE]
> Sie müssen eine Überschreibung für eine einzelne Benutzergruppe veröffentlichen, *nachdem* Sie ein Setup für alle Benutzergruppen festgelegt haben. Andernfalls wird es nicht wirksam.

<!-- Referenced links -->
[1]: ../../../ui/screen-designer/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/arrow-right.png
[img2]: ../../../../media/icons/arrow-left.png
[img3]: ../../../../media/icons/arrow-up.png
[img4]: ../../../../media/icons/arrow-down.png
[img5]: ../../../../media/icons/admin/align-left.png
[img6]: ../../../../media/icons/admin/align-right.png
