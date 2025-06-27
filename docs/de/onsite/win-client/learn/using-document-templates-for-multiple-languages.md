---
uid: help-de-using-document-templates-for-multiple-languages
title: Dokumentvorlagen für mehrere Sprachen verwenden
description: Dokumentvorlagen für mehrere Sprachen verwenden
author: SuperOffice RnD
date: 06.29.2022
keywords: Einstellungen und Verwaltung
content_type: howto
language: de
---

# Dokumentvorlagen im Projekt- und Verkaufsleitfaden in mehreren Sprachen verwenden

Wenn Ihre Firma Geschäftsbereiche in verschiedenen Ländern aufweist, kann es hilfreich sein, wenn die Dokumentvorlagen in den Projekt- und Verkaufsleitfäden in verschiedenen Sprachen verfügbar sind. Zuerst müssen Sie die Dokumentvorlagen für die verschiedenen Sprachen in den richtigen Ordnern ablegen, und anschließend müssen Sie festlegen, wer die verschiedenen Sprachversionen verwenden soll.

## Dokumentvorlagen für Sprachen hinzufügen

1. Öffnen Sie den Windows Explorer und navigieren Sie zum Ordner *\\SuperOffice\\SO_Arc\\Template*.

2. Erstellen Sie einen Ordner für die Sprachen, die in der Dokumentvorlagen verfügbar sein sollen (siehe die folgende Tabelle). Zum Beispiel *\\SuperOffice\\SO_Arc\\Template\\GE*.

3. Legen Sie die Dokumentvorlagen für die verschiedenen Sprachen in den entsprechenden Sprachordnern ab. Jede Dokumentvorlage muss genau denselben Dateinamen und Dateityp aufweisen wie die Hauptvorlage. Die Hauptvorlage ist die Dokumentvorlage in der Hauptsprache, die Sie in SuperOffice verwenden. Diese finden Sie in der Liste **Dokumentvorlage** in der Ansicht **Listen** (doppelklicken Sie auf eine Dokumentvorlage in der Liste, um den Dateinamen/-typ anzuzeigen). Siehe Objekte zur Liste Dokument – Vorlage hinzufügen

> [!TIP]
> Wenn sich die Dokumentvorlage für eine bestimmte Sprache NICHT im Sprachordner befindet, wird die Dokumentvorlage in der Hauptsprache verwendet.

### Ordnername für die verschiedenen Sprachen

[!include[Sprachcodes](../../../globalization-and-localization/includes/table-legacy-language-codes.md)]

## Dokumentsprachen für Benutzer festlegen

Sie müssen nun die richtigen Dokumentsprachen für die Benutzer auswählen, die die Dokumentvorlagen in den verschiedenen Sprachen verwenden werden:

1. Öffnen Sie die Ansicht **Einstellungen**, wählen Sie **System** aus dem Listenfeld **Gruppe anzeigen** und wählen Sie **Bevorzugte Dokumentsprache**.

2. Klicken Sie unter der Liste **Aktive Einstellungen** auf **Hinzu**.

3. Wählen Sie unter **Diese Einstellung gilt für** die Option **Benutzer** aus.

    > [!TIP]
    > Wenn die Geschäftsbereiche Satelliten-Datenbanken verwenden, können Sie Dokumentsprachen für Datenbanken festlegen. Darüber hinaus können Sie auch Dokumentsprachen für Gruppen auswählen, dann muss die jeweilige Gruppe aber die Primärgruppe der Benutzer sein, für die Sie die Dokumentsprache festlegen.

4. Wählen Sie den gewünschten Benutzer in der Liste **Ziel** aus.

5. Wählen Sie die gewünschte Sprache in der Liste **Bevorzugte Dokumentsprache** aus.

6. Klicken Sie auf **Speichern**.

7. Wiederholen Sie die Schritte 2 bis 6 für jeden Benutzer, für den Sie die Dokumentsprache festlegen möchten.
