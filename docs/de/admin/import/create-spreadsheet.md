---
uid: help-de-import-create-excel
title: Importdatei erstellen
description: "In dieser Anleitung lernen Sie, wie Sie mit der Excel-Vorlage eine Importdatei erstellen."
keywords: Importieren, Excel, Firma, Person, Produkt, Tabellenkalkulation
author: digitaldiina
date: 02.22.2023
version: 10.5
content_type: howto
category: Settings and maintenance
topic: Import
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /de/admin/import/learn/create-import-file
language: de
---

# Importdatei erstellen

Um das Importieren von Personen zu erleichtern, haben wir eine Importvorlage erstellt, die Sie herunterladen und zum Importieren verwenden können. In dieser Excel-Tabellenkalkulation haben wir die wichtigsten Datenfelder in Spalten festgelegt, und Sie müssen nur noch Ihre Personendetails in die richtigen Zellen kopieren.

## Firmen und Kontaktpersonen

Die Excel-Tabellenkalkulation sollte zumindest Spalten mit folgenden Daten enthalten:

* Namen der Firma
* Namen der Person (Vor- und Nachname)

> [!TIP]
> Überprüfen Sie, ob die Daten auf dem neuesten Stand sind. Sind zum Beispiel Postadressen und Telefonnummern korrekt?

**Vorschau einer Importdatei (Excel):**

![Die Verwendung einer Importdatei ist der beste Weg, um alle Personen in SuperOffice CRM zu importieren -screenshot][img2]

[Laden Sie die Importvorlage für Firmen und Personen herunter][1] [Excel spreadsheet]

## Produkte

Die Excel-Tabellenkalkulation sollte zumindest Spalten mit folgenden Daten enthalten:

* Produktcode
* Produktname
* Listenpreis

Sie kann zum Beispiel folgende Daten spalten enthalten: Im Sortiment, Produktnummer, Name, Beschreibung, Produktkategorie, Einheit, Listenpreis, Einheitsmindestpreis, Kosten, Produktname.

> [!TIP]
> Zeigen Sie Erklärungen und Tipps an, indem Sie den Mauszeiger über die Spaltenüberschriften ziehen.
>
> Stellen Sie sicher, dass sie für jede Reihe eine einmalige Produktnummer als publizierten Schlüsselwert hinzufügen.

**Vorschau einer Importdatei (Excel):**

![Die Verwendung einer Importdatei ist der beste Weg, um alle Ihre Produkte in SuperOffice CRM zu importieren -screenshot][img5]

[Laden Sie die Importvorlage für Produkte herunter][2] [Excel spreadsheet]

## Tipps

* Einige der Felder in SuperOffice CRM sind **obligatorisch**. Stellen Sie beim Import von Firmen und Personen sicher, dass Sie die Spalten Kategorie, Branche und Personen-/Firmennummer in Ihre Importdatei aufnehmen. Fügen Sie den Produktcode, den Listenpreis und den Namen hinzu, wenn Sie die Produktinformation importieren.

* Wenn Sie mehrere Personen aus einer Firma importieren möchten, müssen Sie für Person eine Zeile hinzufügen und für alle Zeilen denselben Firmennamen hinzufügen.

* Beachten Sie, dass die Qualität der importierten Daten die Qualität Ihrer CRM-Daten bestimmt. Wir empfehlen Ihnen, Ihre Daten durchzugehen und die Importdatei zu bereinigen, bevor Sie beginnen. Importe mit riesigen Datenmengen können ziemlich schwierig zu bereinigen sein, wenn etwas schief geht.

> [!NOTE]
> Für größere und komplexe Importe empfehlen wir immer, einen unserer erfahrenen Berater hinzuzuziehen, um sicherzustellen, dass die Qualität der in SuperOffice CRM importierten Daten optimal ist.

## Verwandte Inhalte

* [Auswahl der Einstellungen für Ihren Import][3]
* [Import von Personen in SuperOffice CRM][4]
* [Import von Produkten in eine Preisliste][5]

<!-- Referenced links -->
[1]: ../../../assets/downloads/import-template-for-contacts.xlsx
[2]: ../../../assets/downloads/import-template-products.xlsx
[3]: settings.md
[4]: from-excel.md
[5]: products-from-excel.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/admin/import-with-excel.jpg
[img5]: ../../../media/loc/en/admin/preview-of-an-import-file.png
