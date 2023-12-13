---
uid: help-de-time-zones
title: Zeitzonen
description: Zeitzonen
author: SuperOffice RnD
so.date: 07.04.2022
keywords: CRM
so.topic: concept
language: de
---

# Zeitzonen

SuperOffice CRM unterstützt Folgeaufgaben in unterschiedlichen Zeitzonen. Die Zeitzonenfunktion ist aktiviert, wenn im Kalender links unten ein Listenfeld für die Auswahl einer Zeitzone enthalten ist (Flagge und Land).

> [!NOTE]
> Die Verwendung von Zeitzonen muss in Einstellungen und Verwaltung pro Land aktiviert sein (unter **Optionen** > **Zeitzonen**). Sie können auch zu **Einstellungen** wechseln, um den Zeitzonen-Selektor anzuzeigen und die Standardzeitzone einzustellen. Dort finden Sie weitere Informationen zur Einrichtung von Zeitzonen.

## Wie werden Zeitzonen in SuperOffice CRM verwendet?

Die Zeitzonenfunktion kann nützlich sein, wenn Ihre Organisation Niederlassungen in mehreren Ländern mit unterschiedlichen Zeitzonen unterhält und Sie Besprechungen oder Telefonkonferenzen mit Personen in einem Land mit einer anderen Zeitzone anberaumen möchten. Wenn die Zeitzonenfunktion aktiviert ist, wird bei der Folgeaufgabefestlegung die Zeitzone des ausgewählten Landes verwendet.

Wenn sich Ihr Firmensitz beispielsweise in Deutschland befindet und Sie eine Besprechung mit Mitarbeitern der Niederlassungen in Finnland und den USA durchführen möchten, können Sie einen Besprechungstermin für die in Deutschland geltende Zeit festlegen und anschließend die betreffende Uhrzeit in Finnland und den USA anzeigen lassen. Auf diese Weise wird vermieden, dass Sie versehentlich eine Besprechung festlegen, der in einem anderen Land z. B. auf den späten Abend fällt. Den eingeladenen Personen wird die Besprechung unter Verwendung der Zeitzone angezeigt, die diese in ihrem eigenen SuperOffice CRM definiert haben, obwohl Sie bei der Terminfestlegung die in Deutschland gültige Zeit verwendet haben.

Die Zeitzonenfunktion berücksichtigt auch die Umstellung von Winter- und Sommerzeit.

> [!NOTE]
> Für Folgeaufgabe, die vor der Aktivierung der Zeitzonenfunktion festgelegt wurden, wird die Standardzeitzone der SuperOffice-Datenbank verwendet.

## Wie werden Zeitzonen ausgewählt?

Zeitzonen werden im [Kalender][1] in einem Listenfeld und für [Folgeaufgaben][3] angezeigt. Dabei steht die Standardzeitzone der SuperOffice-Datenbank an erster Stelle und wird durch folgendes Symbol dargestellt: ![Symbol][img1].

Die Zeitzonenliste ist nach Ländern sortiert. Ganz oben in der Liste stehen der Name des ausgewählten Landes und die zugehörige Flagge.

### Suche nach Land oder Flag

Durch Verwendung des oberen Felds (mit dem ausgewählten Land und der Flagge) als Suchfeld: Sie können nach Ländern als auch nach Städten suchen, sofern die betreffende Stadt in den Zeitzoneninformationen aufgeführt ist. Wenn Sie zum Beispiel nicht die Zeitzone für Canberra wissen, suchen Sie nach Canberra und lassen sich die entsprechende Zeitzone in der Liste anzeigen.

1. Positionieren Sie den Mauszeiger im Länderfeld.
2. Geben Sie den Namen der Stadt oder des Landes ein, deren bzw. dessen Zeitzone Sie benötigen.
3. Nachdem Sie die gewünschte Stadt oder das Land gefunden haben, klicken Sie auf das Objekt, um die erforderliche Zeitzone auszuwählen.

### Suche nach Zeitabweichung

Durch Suchen nach einer bestimmten Zeitabweichung zur Ermittlung der Zeitzone: Wenn Sie beispielsweise +3 eingeben, werden alle Zeitzonen angezeigt, die drei Stunden nach der in SuperOffice CRM angegebenen Zeitzone liegen.

> [!NOTE]
> Im Zeitzonen-Selektor werden die Namen von Regionen stets in ihrer englischen Fassung angezeigt; die Anzeige der Ländernamen ist hängt hingegen davon ab, welche Spracheinstellungen für SuperOffice CRM ausgewählt wurden. Vergessen Sie dies nicht, wenn Sie nach Ländern und Regionen suchen.

## Nützliche Tipps zu Zeitzonen

* Wenn Sie mit dem Mauszeiger auf die Zeitzonenliste zeigen, wird eine QuickInfo dazu angezeigt, welche Städte (in dem betreffenden Land) innerhalb der ausgewählten Zeitzone liegen.

* Wenn Sie mit dem Mauszeiger auf eine Folgeaufgabe zeigen, der für eine andere als die Standardzeitzone der SuperOffice-Datenbank erstellt wurde, erscheint eine QuickInfo. Sie enthält Informationen zu der Zeit der Besprechung in Ihrer eigenen Zeitzone und in der Zeitzone der Person, die die Folgeaufgabe erstellt hat.

<!-- Referenced links -->
[1]: ../../diary/learn/index.md
[3]: ../../diary/learn/follow-ups.md

<!-- Referenced images -->
[img1]: ../../../media/icons/time-zone-local.png
