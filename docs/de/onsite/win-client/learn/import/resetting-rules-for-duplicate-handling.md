---
uid: help-de-resetting-rules-for-duplicate-handling
title: Regeln zur Duplikathandhabung zurücksetzen
description: Regeln zur Duplikathandhabung zurücksetzen
author: SuperOffice RnD
date: 06.29.2022
keywords: Einstellungen für den Windows-Client
content_type: howto
language: de
client: win
envir: onsite
---

# Regeln zur Duplikathandhabung zurücksetzen

1. [!include[How to open import](includes/open-import.md)]

2. Führen Sie einen der folgenden Schritte aus:

    * Klicken Sie auf ![Symbol][img1] neben dem Feld **Importbeschreibung laden** und wählen Sie im geöffneten Dialogfeld eine Importbeschreibungsdatei aus. Die Importdatei und alle zuvor vorgenommenen Einstellungen werden automatisch eingefügt.

    * [!include[Select file](includes/step-select-file.md)]

        Legen Sie dann die [Feldzuordnung][1] fest. Der Inhalt der Spalte **Tabelle** unter **Schlüsselfelder** basiert auf der festgelegten Feldzuordnung.

3. Schließen Sie eine der folgenden Schritte aus:

    * Eine einzelne Regel entfernen:

        1. Wählen Sie unter **Schlüsselfelder** die gewünschte Zeile aus.
        2. Klicken Sie auf die Schaltfläche **Zurücksetzen**. Die Spalte **Schlüssel** der ausgewählten Zeile enthält dann keinen Wert mehr und die Spalte **Aktion** wird in **Überspringen** geändert.

    * Alle Regeln entfernen:

        1. Klicken Sie unter **Schlüsselfelder** auf die Schaltfläche **Alle zurücksetzen**. Die Spalte **Schlüssel** aller Zeilen enthält dann keinen Wert mehr und die Spalte **Aktion** wird für jede Zeile in **Überspringen** geändert.

> [!NOTE]
> Sie können nur dann Daten importieren, ohne für alle Datentypen Regeln zur Duplikathandhabung festzulegen, wenn Sie im Dialogfeld **Schlüsselfelder** unter **Tun Sie Folgendes** die Option **Trotzdem einfügen** gewählt haben. Das heißt, wenn Sie Regeln zurückgesetzt haben, müssen Sie vor dem Starten des Importvorgangs neue Regeln eingeben.

## Was möchten Sie jetzt tun?

* [Regeln zur Duplikathandhabung aktualisieren][2]

<!-- Referenced links -->
[1]: field-mapping.md
[2]: updating-rules-for-duplicate-handling.md

<!-- Referenced images -->
[img1]: ../../../../../../common/icons/nav-admin-import-active.png
