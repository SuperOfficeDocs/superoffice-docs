---
uid: help-de-search-freetext
title: Volltextsuche
description: Volltextsuche
author: SuperOffice RnD
date: 05.25.2023
keywords: Volltext, Suchen
content_type: howto
language: de
---

# Volltextsuche

Das Textfeld weiter oben rechts in SuperOffice CRM dient zur Volltextsuche. In diesem Feld können Sie jeden von Benutzern in die Datenbank von SuperOffice CRM eingegebenen Text wie etwa Firmennamen, Abteilungen, Informationen zu Kontakte und Folgeaufgaben suchen.

![Volltextsuche -screenshot][img1]

> [!NOTE]
> Wenn die Felder für die Volltextsuche nicht in der oberen rechten Ecke sichtbar ist, wurde diese Option in Einstellungen und Verwaltung nicht aktiviert.

## Schritte

1. Geben Sie den Text ein, den Sie suchen möchten (mindestens drei Buchstaben).

2. Drücken Sie die **EINGABETASTE**, um die Suche zu starten.

3. Die Ansicht **Suchergebnisse** wird geöffnet, in dem alle im Suchtext enthaltenen Daten in Registerkarten gruppiert angezeigt werden.

    * Klicken Sie auf die Registerkarte, um die Liste mit den Suchergebnissen anzuzeigen.
    * Sie können einen Eintrag in der Trefferliste öffnen, indem Sie auf diesen doppelklicken.

> [!TIP]
> Sie können Datensätze in der [Seitenleiste][1] in der Vorschau anzeigen. Klicken Sie auf die Liste oben in der Seitenleiste und wählen **Vorschau**. Klicken Sie in den Suchergebnissen auf einen Datensatz, um eine Vorschau anzuzeigen.

## Suchbeispiele

* Wenn Sie nach "office" suchen, wird auch SuperOffice zurückgegeben.
* Bei einem falsch geschriebenen Wort erhalten Sie Vorschläge. Bei der Suche nach "ofice" (Tippfehler) wird ebenfalls "SuperOffice" zurückgegeben. Dies ist auch sehr nützlich, wenn Sie sich nur zum Teil an die zu suchende Firma oder Person erinnern.
* Die Suche nach "123" ergibt auch den Treffer "SAP 123", weil Zahlen ebenfalls indiziert sind.
* Die Suche nach "IBM" ergibt auch den Treffer "I.B.M.", weil bei der Indexierung auch Anführungszeichen, Punkte und ähnliche Zeichen im Index entfernt werden.

## Einschränkungen und ignorierte Wörter

Sie können im Dialogfeld **Dokument** nach Text suchen, aber nicht den tatsächlichen Inhalt von Dokumenten durchsuchen. Es wird immer zuerst nach Text im Feld **Unser Zeichen** des Dialogfelds **Dokument** gesucht.

Bestimmte Wörter werden bei der Volltextsuche ignoriert. Diese wurden in Einstellungen und Verwaltung definiert.

<!-- markdownlint-disable-next-line MD013 -->
## Warum erhalte ich keine Treffer für ein Suchwort, von dem ich weiß, dass es in der Datenbank enthalten ist?

Falls für ein Suchwort in der SuperOffice-Datenbank keine Treffer zurückgegeben werden, kann dies daran liegen, dass Sie den Index für die Volltextsuche in Einstellungen und Verwaltung noch nicht generiert haben.

## Verwandte Themen

* [Suchansicht verwenden][2]
* [Schnellsuche][3]
* [Verlaufsliste][4]

<!-- Referenced links -->
[1]: ../../learn/getting-started/main-screen/side-panel.md
[2]: find-screen.md
[3]: index.md#fastsearcher
[4]: ../../learn/basics/history.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/search-options/freetext-search-box.png
