---
uid: help-de-duplicates-import
title: Duplikate importieren
description: Duplikate importieren
author: SuperOffice RnD
date: 06.29.2022
keywords: Einstellungen für den Windows-Client
content_type: concept
language: de
client: win
envir: onsite
---

# Duplikate

Ein Duplikat liegt vor, wenn derselbe Datensatz sowohl in der Importdatei als auch in der Datenbank vorhanden ist. Sie müssen immer Regeln zur Handhabung von Duplikaten während eines Imports in einer [Importbeschreibung][1] angeben. Diese Regeln werden dann beim Speichern in die Importbeschreibung aufgenommen. Dies gilt für alle Datentypen. Unter **Schlüsselfelder** finden Sie folgende Spalten:

* **Tabelle**: Zeigt an, für welchen Datentyp diese Duplikathandhabungsregel gilt. Der Inhalt dieser Spalte hängt von den Einstellungen der Spalte **Feld in SuperOffice CRM** unter **Feldzuordnung** ab.
* **Schlüssel**: Zeigt einen Importschlüssel an, welche Kriterien erfüllt sein müssen, damit ein Datensatz als Duplikat erkannt wird.
* **Aktion**: Zeigt an, was passiert, wenn ein Duplikat registriert wird.

## Was möchten Sie jetzt tun?

* [Regeln zur Duplikathandhabung aktualisieren][2]
* [Regeln zur Duplikathandhabung zurücksetzen][3]

<!-- Referenced links -->
[1]: import-descriptions.md
[2]: updating-rules-for-duplicate-handling.md
[3]: resetting-rules-for-duplicate-handling.md

<!-- Referenced images -->
