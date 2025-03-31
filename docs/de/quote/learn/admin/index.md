---
uid: help-de-quote-admin
title: Angebot/Sync
description: "SuperOffice-Angebot hilft Ihnen, Angebote und Aufträge während des gesamten Auftragslebenszyklus zu erstellen, zu prüfen und zu verwalten."
author: SuperOffice RnD
date: 12.13.2023
keywords: Angebot, Sync, Verkauf
topic: concept
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Angebot/Synchronisierung

SuperOffice-Angebot hilft Ihnen, Angebote und Aufträge während des gesamten Auftragslebenszyklus zu erstellen, zu prüfen und zu verwalten. Es hilft Ihnen, Ihren Kunden schneller neue oder aktualisierte Angebote zu unterbreiten und den Übergang von einem Lead zu einem abgeschlossenen Geschäft zu beschleunigen.

> [!NOTE]
> Diese Funktion erfordert einen Sales Premium-Benutzervertrag und die Lizenz für Developer Tools.

Helfen Sie Ihren Kollegen mithilfe eines automatisierten Angebotssystems, ihre Angebote schneller zu senden und unnötige Fehler zu vermeiden. Sparen Sie Zeit, indem Sie Ihr Angebot mit nur einem Klick auf eine Schaltfläche in eine Auftragsbestätigung umwandeln.

![Die Anzeige Angebot in Verkäufe zeigt einen Angebot für John Smith an -screenshot][img1]

Für Sie und Ihre Kollegen ist es sehr einfach, die Produkte für ein Angebot von der Preisliste auszuwählen. Sie können verschiedene Versionen Ihres Angebots an Ihre Kunden senden und automatisch eine Folgeaufgaben-Aktivität erfassen. Es ist auch wichtig, eine gute Angebotsdokumentvorlage einzurichten, damit Ihre Kunden auch Informationen über Produkte und Preise erhalten, die in Ihrem Angebot hinzugefügt werden.

## Ansicht

In der Ansicht **Angebot/Sync** können Sie Verbindungen und Einstellungen für ERP-Systeme verwalten, die mit SuperOffice CRM verknüpft sind. Hier können Sie außerdem Preislisten und Produkte aus der SuperOffice-Datenbank bearbeiten.

* [ERP-Verbindungen][1] – Hier können Sie Quote Connectors und ERP-Verbindungen konfigurieren und hinzufügen.
* [SuperOffice-Produkte][2] – Hier können Sie Preislisten und Produkte bearbeiten, die in SuperOffice gespeichert sind.
* [Einstellungen][3] – Hier können Sie die Einstellungen für Angebote anpassen und die Felder konfigurieren, die für Produkte angezeigt werden.
* [Synchronisierung][4] – Hier können Sie Sync Connectors und zugehörige ERP-Verbindungen konfigurieren.

## Was sind Quote/Sync Connectors und ERP-Verbindungen?

* Jeder Quote Connector oder Sync Connector ist eine DLL-Datei/ein Web-Service, der/die die Kommunikation zwischen SuperOffice und einem ERP-System verwaltet.
* Quote Connectors werden verwendet, um Angebotspreise zu kalkulieren und Auftragsdetails an das ERP-System zu senden, wenn der Kunde das Angebot annimmt.
* Sync Connectors werden verwendet, um SuperOffice und das ERP-System miteinander zu integrieren, sodass Firmen in SuperOffice mit Kunden und Lieferanten im ERP-System verknüpft/synchronisiert werden können. Dasselbe gilt für Personen und Projekte.
* Eine ERP-Verbindung besteht aus einem Quote Connector oder einem Sync Connector und Konfigurationsdaten (wie beispielsweise Client-Daten (wenn das ERP-System von mehreren Firmen verwendet wird) und Authentifizierungsdaten für das ERP-System).

## Zugehörige Inhalte

* [Preislisten anpassen][5]
* [Produktfelder konfigurieren][6]
* [Produkte zur Preisliste hinzufügen][7]
* [Produktbild hinzufügen][8]

<!-- Referenced links -->
[1]: quotesync-tab-erp-connections.md
[2]: product/index.md
[3]: product/configure.md
[4]: ../../../erp/admin/index.md
[5]: product/add-price-list.md
[6]: product/configure.md
[7]: product/add-product-to-price-list.md
[8]: product/select-product-image.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/quote/quote-management.png
