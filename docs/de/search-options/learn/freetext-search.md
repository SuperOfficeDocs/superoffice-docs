---
uid: help-de-search-freetext
title: Volltextsuche
description: Volltextsuche
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Volltext, Suchen
so.topic: howto
language: de
---

# Volltextsuche

> [!NOTE]
> Wenn die Felder für die Volltextsuche nicht in der oberen rechten Ecke sichtbar ist, wurde diese Option in Einstellungen und Verwaltung nicht aktiviert.

Das Textfeld weiter oben rechts in SuperOffice CRM dient zur Volltextsuche.

In diesem Feld können Sie jeden von Benutzern in die Datenbank von SuperOffice CRM eingegebenen Text wie etwa Firmennamen, Abteilungen, Informationen zu Kontakte und Folgeaufgaben suchen. Sie können im Dialogfeld **Dokument** nach Text suchen, aber nicht den tatsächlichen Inhalt von Dokumenten durchsuchen.

![Volltextsuche -screenshot][img1]

> [!NOTE]
> Bestimmte Wörter werden bei der Volltextsuche ignoriert. [!include[SM](../../learn/includes/are-defined-sm.md)]

## Volltextsuche über das Textfeld

1. Geben Sie den Text ein, den Sie suchen möchten (mindestens drei Buchstaben).
2. Drücken Sie die **EINGABETASTE**, um die Suche zu starten.
    > [!NOTE]
    > Es wird immer zuerst nach Text im Feld **Unser Zeichen** des Dialogfelds **Dokument** gesucht.
3. Die Ansicht **Suchergebnisse** wird geöffnet, in dem alle im Suchtext enthaltenen Daten in Registerkarten gruppiert angezeigt werden. Klicken Sie auf die Registerkarte, um die Liste mit den Suchergebnissen anzuzeigen.

Sie können einen Eintrag in der Trefferliste öffnen, indem Sie auf diesen doppelklicken.

Sie können Datensätze in der[Seitenleiste][1] in der Vorschau anzeigen. Klicken Sie auf die Liste oben in der Seitenleiste und wählen **Vorschau**. Klicken Sie in den Suchergebnissen auf einen Datensatz, um eine Vorschau anzuzeigen.

## Warum erhalte ich keine Treffer für ein Suchwort, von dem ich weiß, dass es in der Datenbank enthalten ist?

Falls für ein Suchwort in der SuperOffice-Datenbank keine Treffer zurückgegeben werden, kann dies daran liegen, dass Sie den Index für die Volltextsuche in Einstellungen und Verwaltung noch nicht generiert haben.

[!include[Examples of searches](includes/freetext-search-examples.md)]

## Verwandte Themen

* [Suchansicht verwenden][2]
* [Schnellsuche][3]
* [Verlaufsliste][4]

<!-- Referenced links -->
[1]: ../../learn/getting-started/main-screen/side-panel.md
[2]: find-screen.md
[3]: using-fastsearcher.md
[4]: using-history-list.md

<!-- Referenced images -->
[img1]: media/freetext.bmp
