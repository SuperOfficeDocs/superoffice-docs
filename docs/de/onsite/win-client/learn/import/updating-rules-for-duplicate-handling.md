---
uid: help-de-updating-rules-for-duplicate-handling
title: Regeln zur Duplikathandhabung aktualisieren
description: Regeln zur Duplikathandhabung aktualisieren
author: SuperOffice RnD
date: 06.29.2022
keywords: Einstellungen für den Windows-Client
content_type: howto
language: de
client: win
envir: onsite
---

# Regeln zur Duplikathandhabung aktualisieren

Sie müssen immer Regeln zur Handhabung von Duplikaten während eines Importvorgangs festlegen.

1. [!include[How to open import](includes/open-import.md)]

2. Führen Sie einen der folgenden Schritte aus:

    * Klicken Sie auf ![Symbol][img1] neben dem Feld **Importbeschreibung laden** und wählen Sie im geöffneten Dialogfeld eine Importbeschreibungsdatei aus. Die Importdatei und alle zuvor vorgenommenen Einstellungen werden automatisch eingefügt.

    * [!include[Select file](includes/step-select-file.md)]

        Legen Sie dann die [Feldzuordnung][1] fest.

3. Der Inhalt der Spalte **Tabelle** unter **Schlüsselfelder** basiert auf der festgelegten Feldzuordnung.

4. Wählen Sie unter **Schlüsselfelder** die Zeile aus, für die Sie eine Duplikathandhabungsregel festlegen möchten.

    > [!NOTE]
    > Welche Zeilen unter **Schlüsselfelder** angezeigt werden, hängt davon ab, in welche Felder Sie importieren möchten. Dies kann nicht geändert werden und Sie müssen Duplikathandhabungsregeln für alle Zeilen festlegen.

5. Klicken Sie auf die Schaltfläche **Abgleich**. Daraufhin wird das Dialogfeld **Schlüssel bearbeiten** für den ausgewählten Datentyp angezeigt.

6. Unter **Wenn diese Felder übereinstimmen** werden alle verfügbaren Felder des ausgewählten Datentyps angezeigt, für den Sie Feldzuordnungen festgelegt haben. Überprüfen Sie, welche(s) Feld(er) einen identischen Inhalt haben müssen, damit der Datensatz als Duplikat interpretiert wird. Dies wird als Importschlüssel bezeichnet.

7. Wählen Sie unter **Tun Sie Folgendes** die Aktion aus, die ausgeführt wird, wenn während des Imports Duplikate entdeckt werden.

    * **Abgleich für bestehende**: Die Werte in der Importdatei überschreiben die Werte in der Datenbank. Wählen Sie diese Option, wenn Sie der Meinung sind, dass die Informationen in der Importdatei auf neuerem Stand sind als die in der Datenbank.
    * **Abgleich nur für leere Felder**: Die neuen Datensätze werden hinzugefügt und nur die leeren Felder für vorhandene Datensätze aktualisiert. Wählen Sie diese Option, wenn Sie der Meinung sind, dass die Informationen in der Datenbank auf neuerem Stand sind als die in der Importdatei.
    * **Überspringen**: Die neuen Datensätze werden hinzugefügt, die bereits in der Datenbank vorhandenen Datensätze werden beibehalten.

    > [!NOTE]
    > Dies ist die Standardoption zum Zurücksetzen der Datenbank, so dass unerwünschte Datensätze nicht mit negativen Folgen importiert werden.

    * **Trotzdem einfügen**: Alle Felder in der Importdatei werden importiert und es wird nicht geprüft, ob sie bereits vorhanden sind. Dies ist besonders dann wichtig, wenn Sie in eine leere Datenbank importieren. Für diese Option müssen Sie keine Importschlüssel festlegen.

8. Klicken Sie auf **OK**.

[!include[Save mapping](includes/tip-save-mapping.md)]

## Was möchten Sie jetzt tun?

* [Regeln zur Duplikathandhabung zurücksetzen][3]

<!-- Referenced links -->
[1]: field-mapping.md
[3]: resetting-rules-for-duplicate-handling.md

<!-- Referenced images -->
[img1]: ../../../../../../common/icons/search-icon-black.png
