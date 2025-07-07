---
uid: help-de-udef-layout
title: Benutzeroberfläche anpassen
description: Benutzeroberfläche anpassen
keywords: udef, benutzerdefiniertes Feld, layout, Seite-1-Felder, anpassen, ausrichten
author: Bergfrid Dias
date: 01.30.2024
version: 10
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
index: true
---

# Benutzeroberfläche anpassen

[!include[License requirement](../../includes/req-dev-tools.md)]

SuperOffice Version 10 (veröffentlicht im Oktober 2021) führte [Ansichtsdesigner][1] ein, mit anpassbaren Ansichtlayouts für bestimmte Benutzergruppen. Jegliche benutzerdefinierten Ansichtlayouts, die den Ansichtsdesigner verwenden, können die unten beschriebenen Einstellungen außer Kraft setzen.

Wenn Sie [neue Felder hinzufügen][2], werden diese standardmäßig untereinander platziert. Jedes Feld besteht aus einem Bezeichnung mit einem Datenfeld rechts. Sie können entscheiden, wo im Raster diese Felder platziert werden sollen.

## Wo anfangen

1. [!include[Zu Feldern gehen und Tab auswählen](includes/goto-fields.md)]

**Wie man Felder auswählt:**

* Klicken Sie auf ein Feld im Raster, um es auszuwählen.
* Klicken Sie im Raster und ziehen Sie, um mehrere Felder auszuwählen.
* Klicken Sie auf ein Feld in der Liste **Felder**, um sowohl das Bezeichnungs- als auch das Datenfeld im Raster auszuwählen.

## Feld verschieben

* Ziehen Sie das Feld mit gedrückter Maustaste. Die Felder werden automatisch an das Raster angepasst.
* Klicken Sie auf ein Feld und verwenden Sie die Pfeiltasten auf der Tastatur.
* Klicken Sie auf ein Feld und verwenden Sie die Pfeiltasten unten rechts (<i class="ph ph-arrow-circle-left" aria-hidden="true"></i> <i class="ph ph-arrow-circle-right" aria-hidden="true"></i> <i class="ph ph-arrow-circle-up" aria-hidden="true"></i> <i class="ph ph-arrow-circle-down" aria-hidden="true"></i>).
* Doppelklicken Sie auf ein Feld und geben Sie Positionswerte **X** und **Y** im Dialogfeld **Felder** an.

## Position festlegen

1. Geben Sie in den Feldern rechts von **Bezeichnung** Folgendes an:

    **X**: Horizontale Position der Bezeichnung. Je höher die Zahl, desto weiter rechts.

    **Y**: Vertikale Position der Bezeichnung. Je höher die Zahl, desto weiter unten.

2. Geben Sie in den Feldern rechts von **Data** Folgendes an:

    **X**: Horizontale Position des Datenfelds. Je höher die Zahl, desto weiter rechts.

    **Y**: Vertikale Position des Datenfelds. Je höher die Zahl, desto weiter unten.

## Felder ausrichten (rechts/links)

Wählen Sie die Felder aus, die Sie anpassen möchten, und klicken Sie unter dem Raster auf links ausrichten (<i class="ph ph-text-align-left" aria-hidden="true"></i>) oder rechts ausrichten (<i class="ph ph-text-align-right" aria-hidden="true"></i>).

## Breite eines Feldes ändern

1. Doppelklicken Sie auf das relevante Feld in der Liste **Felder** oder im Raster.
2. Geben Sie die Breite der Bezeichnung im Feld rechts von **Bezeichnung** an.
3. Geben Sie die Breite des Datenfelds im Feld rechts von **Data** an

## Ändern Sie die TAB-Reihenfolge der Felder im Tab "Mehr"

Die TAB-Reihenfolge ist die Reihenfolge, in der Sie sich zwischen den verschiedenen Feldern bewegen, wenn Sie die TAB-Taste drücken. Sie können die TAB-Reihenfolge ändern, um die logische Reihenfolge widerzuspiegeln, in der Benutzer normalerweise Daten in Felder eingeben.

Die TAB-Reihenfolge wird in der Liste **Name** links auf der Ansicht angezeigt. Diese Reihenfolge ist nicht identisch mit den physischen Positionen der Felder, die rechts oben im Vorschaufeld angezeigt werden.

**Schritte:**

1. Wählen Sie das erforderliche Feld unterhalb der Liste aus.

1. Klicken Sie auf <i class="ph ph-arrow-circle-up" aria-label="Arrow up"></i> oder <i class="ph ph-arrow-circle-down" aria-label="Arrow down"></i> unterhalb der Liste, um das Feld nach oben oder nach unten zu verschieben.

1. Klicken Sie auf **Veröffentlichen**, um die Änderungen für SuperOffice CRM-Benutzer verfügbar zu machen.

## <a id="page-1"></a>Benutzerdefiniertes Feld auf der ersten Seite anzeigen

1. Aktivieren Sie **Unterschiedliche Felder auf Seite 1 für unterschiedliche Benutzergruppen zulassen** unten auf der Registerkarte, um unterschiedliche Felder für Seite 1 für verschiedene Benutzergruppen anzugeben. Wenn diese Option nicht aktiviert ist, werden die von Ihnen festgelegten Felder für alle Benutzergruppen verwendet.

1. In der Benutzergruppenliste oben wählen Sie die erforderliche Benutzergruppe aus (wenn Sie **Unterschiedliche Felder auf Seite 1 für unterschiedliche Benutzergruppen zulassen** im vorherigen Schritt aktiviert haben).

1. In der Listbox **Feld 1** wählen Sie das Feld aus, das oben angezeigt werden soll. Wählen Sie die Felder aus, die in den nächsten Positionen in den Listboxen **Feld 2** und **Feld 3** angezeigt werden sollen.

1. Klicken Sie auf **Speichern**, um Ihre Änderungen nur in "Einstellungen und Verwaltung" zu speichern, oder klicken Sie auf **Veröffentlichen**, um die Änderungen für SuperOffice CRM-Benutzer verfügbar zu machen.

### Benutzergruppen und Seite-1-Felder

Benutzergruppen werden in der Ansicht **Listen** definiert, und die Gruppe, der ein Benutzer angehört, wird in der Ansicht Benutzer definiert. Wenn Sie einen Namen in der Liste **Benutzergruppe** auswählen, werden die verfügbaren Seite-1-Felder für die ausgewählte Benutzergruppe unter **Felder 1**, **2** und **3** angezeigt.

Wenn Sie **(alle Benutzergruppen)** in der Liste **Benutzergruppe** auswählen, Felder auswählen und die Einrichtung speichern, gilt dieselbe Auswahl von Feldern für alle Benutzergruppen in SuperOffice CRM. Wenn Sie dann eine bestimmte Benutzergruppe auswählen, können Sie die vorhandene Feldkonfiguration nur für diese Gruppe überschreiben, indem Sie eine andere Spezifikation verwenden. Wenn Sie in einem Feld nichts angeben, bleibt es leer, da die Überschreibung für alle drei Felder unabhängig von ihrem Inhalt gilt.

> [!NOTE]
> Sie müssen eine Überschreibung für eine einzelne Benutzergruppe veröffentlichen, *nachdem* Sie ein Setup für alle Benutzergruppen festgelegt haben. Andernfalls wird es nicht wirksam.

<!-- Referenced links -->
[1]: ../../ui/screen-designer/learn/index.md
[2]: add-udef.md
