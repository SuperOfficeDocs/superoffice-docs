---
uid: help-de-import-routines
title: Importroutinen
description: Importroutinen
author: SuperOffice RnD
date: 06.29.2022
keywords: Einstellungen für den Windows-Client
content_type: concept
language: de
platform: win
deployment: onsite
---

# Importroutinen

Zwei wichtige Punkte sollten Sie vor dem Importieren von Daten beachten:

* Wenn Sie über eine vorhandene SuperOffice-Datenbank verfügen, in die Sie Daten importieren möchten, sollten Sie vor dem Import eine Sicherheitskopie anlegen. Wenn während des Imports ein Fehler auftritt, ist es ratsam, erneut mit der Original-Datenbankdatei zu beginnen. (Siehe [Sicherungsroutinen][8].)

* Die Datendatei, aus der Sie importieren, muss eine Textdatei sein, genauer eine Windows-gestützte [ANSI-Dateien][1]. Wenn Ihr Kundenindex also beispielsweise in Excel gespeichert ist, müssen Sie die Excel-Datei als Textdatei speichern, bevor Sie die Daten in die SuperOffice-Datenbank importieren können. Sie können das Format der Datei prüfen, indem Sie sie in Excel öffnen. Die Datei muss vom Dateityp **TXT** sein (zum Beispiel **IMPORT.TXT**) und Sie müssen wissen, in welchem Ordner sich die Datei befindet.

> [!NOTE]
> Sie können nur dann Dateien mit Feldern fester Länge in die SuperOffice Datenbank importieren, wenn Trennzeichen zwischen den Feldern stehen.

## Verwandte Themen

* [ANSI-Dateien][1]
* [Dateien importieren][2]
* [Feldzuordnung][3]
* [Erweiterte Importeinstellungen festlegen][4]
* [Duplikate][5]
* [Importbeschreibungen][6]
* [Informationen in der Datenbank aktualisieren][7]

<!-- Referenced links -->
[1]: ansi-files.md
[2]: importing-files.md
[3]: field-mapping.md
[4]: specifying-advanced-import-settings.md
[5]: duplicates-import.md
[6]: import-descriptions.md
[7]: ../update-database.md
[8]: ../backup-routines.md

<!-- Referenced images -->
