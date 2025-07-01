---
uid: help-de-status-screen
title: Statusbildschirm
description: Statusbildschirm
author: SuperOffice RnD
date: 06.29.2022
keywords: Einstellungen für den Windows-Client
content_type: concept
language: de
client: win
deployment: onsite
---

# Ansicht Status

In der Ansicht **Status** sind aktualisierte Informationen zum System enthalten. Die Ansicht **Status** ist in die folgenden Hauptbereiche unterteilt:

## Datenbank

Zeigt den bei der Installation festgelegten Datenbankbesitzer, die Seriennummer und den Datenbanktyp an. Außerdem wird angezeigt, ob es eine zentrale DB oder eine Satelliten-Datenbank ist. Sie können das nächste Ablaufdatum (Datum, an dem die Lizenz erneuert werden muss) und den Namen des derzeit angemeldeten Benutzers sehen.

**Tabellenadministrator: Lokaler Datenbankbenutzer**: Geben Sie den Namen und das Passwort des Datenbankbenutzers an (es muss kein SuperOffice CRM-Benutzer sein), der automatisch vom System zum Erstellen und Löschen von Datenbanktabellen verwendet wird. Dieser Benutzer benötigt keine weiteren Rechte.

> [!NOTE]
> Bei Oracle-Datenbanken muss die Benutzer-ID mit der ID des Tabelleneigentümers und der als Präfix in **SuperOffice.ini** verwendeten ID übereinstimmen.

## Statistik

Zeigt an, wie viele Benutzer gerade angemeldet sind, wann der letzte Prototyp erzeugt wurde und wie viele aktive Travel-Benutzer zurzeit vorhanden sind.
