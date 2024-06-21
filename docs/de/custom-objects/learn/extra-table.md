---
uid: help-de-extra-table
title: Zusatztabellen
description: Zusatztabellen
keywords: Zusatztabelle
author: Bergfrid Dias
date: 01.30.2024
version: 10
topic: howto
audience: user
audience_tooltip: SuperOffice CRM
language: de
---

# Zusatztabellen

[!include[License requirement](../../learn/includes/req-expander-services.md)]

Die SuperOffice Development Tools-Lizenz ermöglicht es Ihnen, Zusatztabellen in der Datenbank zu erstellen. Sofort stehen diese Tabellen von Drittanbietern für Standard-CRUD-Operationen in SuperOffice Service zur Verfügung. Sie müssen ein Webpanel einrichten, um von der Verkaufs-App darauf zuzugreifen.

Die Ansicht Tabellen ist Ihr Werkzeug zur Anpassung des Datenbankschemas.

## Ansicht Tabellen

Die Ansicht Tabellen zeigt eine Liste von Datenbanktabellen an. Er zeigt sowohl Standardtabellen (im System vordefiniert und bildet die Grundlage für verschiedene Ansichten) als auch Zusatztabellen (Tabellen, die Sie selbst mit optionalen Inhalten erstellen).

Hier können Sie neue Tabellen und Felder für verschiedene Karten und Dialogfelder erstellen. Nur Administratoren haben Zugriff auf diese Funktion.

## Tabellenordners

Tabellenordner werden zum Organisieren von Zusatztabellen verwendet.

## Konventionen

> [!CAUTION]
> Wählen Sie Ihre Datenbanktabellen- und Feldnamen sorgfältig aus. Sie können später nicht geändert werden!
>
> Ein logischer Name ist am besten, da er es erleichtert zu erkennen, was die Datenbank enthält.

Präfixe stellen sicher, dass das, was Sie erstellen, nicht mit zukünftigen SuperOffice-Tabelle- und Feldnamen in Konflikt gerät. Es garantiert jedoch keine fehlenden Namenskonflikte zwischen verschiedenen Drittanbietern.

### Tabellennamen

* Muss mit **y_** beginnen
* Darf nur Unterstriche, die Buchstaben a bis z und Zahlen enthalten

### Feldnamen

* Muss mit **x_** beginnen
* Muss innerhalb der Tabelle eindeutig sein
* Muss ein einzelnes Wort sein
* Darf nur Unterstriche, Buchstaben von a bis z und Zahlen enthalten

## Verwandte Themen

* [Zusatztabellen hinzufügen][2]
* [Zusatzfelder hinzufügen][3]
* [Benutzerdefinierte Felder][4]
* [Benutzerdefinierte Anziege][1]

<!-- Referenced links -->
[1]: ../../ui/blogic/learn/index.md
[2]: ../admin/create-extra-table.md
[3]: ../admin/create-extra-field.md
[4]: ../admin/add-udef.md

<!-- Referenced images -->