---
uid: help-de-udef-edit
title: Benutzerdefinierte Felder bearbeiten
description: Benutzerdefinierte Felder bearbeiten
keywords: udef, benutzerdefiniertes Feld
author: Bergfrid Dias
date: 01.30.2024
version: 10
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Benutzerdefinierte Felder bearbeiten

1. [!include[Zu Feldern gehen und Tab auswählen](includes/goto-fields.md)]

1. Doppelklicken Sie in der Liste **Felder** auf das gewünschte Feld.

1. Nehmen Sie die gewünschten Änderungen in den einzelnen Feldern vor. (Siehe Liste der [Feld-Eigenschaften][1]).

    Das Listenfeld **Typ** enthält nur die Optionen, die Sie ändern können. Das heißt, hier können vorhandene Daten konvertiert werden, um sie an den neuen Feldtyp anzupassen.

1. Klicken Sie auf **Speichern**.

1. Klicken Sie auf **Veröffentlichen**, um die Änderungen für SuperOffice-Benutzer verfügbar zu machen.

> [!NOTE]
> Sie müssen die Änderungen für benutzerdefinierte Felder veröffentlichen, bevor Sie [Seite-1-Felder definieren][2] für die verschiedenen Benutzergruppen und speichern (nicht veröffentlichen).

## Feldtyp konvertieren

Nicht alle Konvertierungen sind möglich, weil verschiedene Arten von benutzerdefinierten Feldwerten in verschiedenen Tabellen in der Datenbank gespeichert sind und unterschiedliche Basistypen verwenden.

| Feldtyp | Zahl | Dezimal | Kurzer Text | Langer Text | Datum | Unbegrenztes Datum | Checkbox | Liste |
|:--|:-:|:-:|:-:|:-:|:-:|:-:|:-:|:-:|
| Zahl | x | x | x | | | | | |
| Dezimal | x | x | x | | | | | |
| Kurzer Text | x | | x | | | | | |
| Langer Text | | | | x | | | | |
| Datum | | | x | | x | x | | |
| Unbegrenztes Datum | | | x | | | x | | |
| Checkbox | | | x | | | | x | |
| Liste | | | x | | | | | x |

**So lesen Sie die Tabelle:**

Die Feldtypen in der linken Spalte sind kompatibel mit den Typen, die mit einem x markiert sind. Zum Beispiel kann eine Zahl in eine Dezimalzahl und einen kurzen Text umgewandelt werden. (Und es ist offensichtlich mit sich selbst kompatibel.)

<!-- Referenced links -->
[1]: add-udef.md#properties
[2]: edit-udef-layout.md#page-1

<!-- Referenced images -->
