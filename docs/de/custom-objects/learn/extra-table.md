---
uid: help-de-extra-table
title: Zusatztabellen
description: Zusatztabellen
keywords: Zusatztabelle
author: Bergfrid Dias
date: 08.27.2024
version: 10.3.8
content_type: howto
audience: user
audience_tooltip: SuperOffice CRM
language: de
redirect_from: /de/custom-objects/learn/extra-table/index
---

# Zusatztabellen

[!include[License requirement](../../includes/req-dev-tools.md)]

Die SuperOffice Development Tools-Lizenz ermöglicht es Ihnen, Zusatztabellen (Zusatzobjekten) in der Datenbank zu erstellen.

Die Ansicht Tabellen ist Ihr Werkzeug zur Anpassung des Datenbankschemas.

## So greifen Sie darauf zu

<!-- markdownlint-disable MD051 -->
### [Klassisch](#tab/extra-table-old)

Drittanbietertabellen stehen sofort für Standard-CRUD-Operationen in SuperOffice Service zur Verfügung. Sie müssen ein Webpanel einrichten, um von der Verkaufs-App darauf zugreifen zu können.

### [Neu (ab Version 10.3.4 Pilot)](#tab/extra-table-new)

Nicht mehr auf SuperOffice Service beschränkt, können Sie Daten in Zusatztabellen jetzt mühelos über SuperOffice CRM erkunden und verwalten.

#### Dashboards mit Zusatzobjekten erstellen

![Dashboard mit Zusatzobjekten -screenshot][img1]

#### Finden und Auswahl

**Zusatzobjekt als Suchkriterium für Firma, Person, Verkauf, Projekt, Anfrage, Aktivität:**

![Zusatzobjekt als Suchkriterium -screenshot][img2]

**Erstellen Sie eine Auswahl von Zusatzobjekten (10.3.7):**

![Suchbildschirm mit Zusatzobjekten -screenshot][img3]

![Auswahl von Zusatzobjekten -screenshot][img4]

#### Datenverwaltung (10.3.7)

**Übersicht über Zusatzobjekte öffnen:**

![Übersicht über Zusatzobjekte -screenshot][img5]

**Suche:**

![Übersicht über Zusatzobjekte, Suche -screenshot][img6]

**Vorschau:**

![Übersicht über Zusatzobjekte, Vorschau -screenshot][img7]

**Elemente hinzufügen/entfernen:**

Wenn Sie die Ergebnisse für ein bestimmtes Element in der Übersicht über **Zusatzobjekte** anzeigen, klicken Sie auf die Schaltfläche **Aufgabe** und wählen **Neu** oder **Löschen**.

**Felder automatisch ausfüllen, wenn Zusatzobjekte geladen wird (10.3.8):**

Der neue [SalesLoadCustomObject][6] Auslöser wird aufgerufen, bevor ein Bildschirm für Zusatzobjekte geladen wird. Verwenden Sie ihn, um Standardwerte in Feldern festzulegen und Geschäftsregeln zu definieren.

***
<!-- markdownlint-restore -->

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
* [Auslöser hinzufügen][5]

<!-- Referenced links -->
[1]: ../../ui/blogic/learn/index.md
[2]: ../admin/create-extra-table.md
[3]: ../admin/create-extra-field.md
[4]: ../admin/add-udef.md
[5]: https://docs.superoffice.com/en/automation/trigger/create-trigger-script.html
[6]: https://docs.superoffice.com/en/automation/trigger/reference/CRMScript.Event.Trigger.html#CRMScript_Event_Trigger_SalesLoadCustomObject

<!-- Referenced images -->
[img1]: ../../../media/loc/en/automation/custom-object-dashboard.png
[img2]: ../../../media/loc/en/automation/find-custom-object-relation.png
[img3]: ../../../media/loc/en/automation/find-screen-with-custom-objects.png
[img4]: ../../../media/loc/en/automation/custom-object-selection.png
[img5]: ../../../media/loc/en/automation/go-to-custom-objects.png
[img6]: ../../../media/loc/en/automation/search-inventory.png
[img7]: ../../../media/loc/en/automation/preview-inventory-results.png

<!-- Referenced images -->
