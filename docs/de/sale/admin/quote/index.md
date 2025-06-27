---
uid: help-de-quote-admin
title: Angebot und Auftrag einrichten
description: Erfahren Sie, wie Angebote, Quote Connectors und ERP-Integration in SuperOffice CRM funktionieren und wie Sie diese in der Ansicht Angebot/Sync konfigurieren.
keywords: quote connector, ERP-Verbindung, Angebotseinstellungen, Preisliste, Produkt, Angebot/Sync, ERP-Einrichtung, quote connector-Einstellungen, Angebotsintegration, Vertriebskonfiguration, Angebot, Sync
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: concept
license: salespremium
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Angebot und Auftrag einrichten

In der Ansicht **Angebot/Sync** unter Einstellungen und Verwaltung konfigurieren Sie alles, was Sie für die Angebots- und Auftragserstellung in SuperOffice CRM benötigen.

> [!NOTE]
> Diese Funktion erfordert die Benutzerlizenz **Sales Premium**.

## Produkte und Preislisten

Jedes Angebot in SuperOffice enthält ein oder mehrere Produkte, und jedes Produkt muss zu einer **Preisliste** gehören.

Es gibt zwei Möglichkeiten, Produkte und Preise in SuperOffice CRM zu verwalten:

* **Manuell**, mit dem integrierten SuperOffice-Produktregister (auch **SuperOffice Standalone Connector** genannt).

* **Automatisch**, durch Abrufen von Produktdaten aus einem externen **ERP-System**.

## Quote Connectors und ERP-Verbindungen

Zum Abrufen von Produktdaten und zur Preisberechnung verwendet SuperOffice **Quote Connectors** und **ERP-Verbindungen**.

Ein **Quote Connector** ist ein Plugin (Webdienst oder DLL), das die Integration übernimmt. Es kommuniziert mit einem bestimmten ERP- oder Produktsystem und übernimmt Aufgaben wie:

* Abruf von Produkt- und Preisdaten
* Validierung von Rabatten
* Berechnung von Gesamtbeträgen und Mehrwertsteuer
* Übermittlung von bestätigten Angeboten als Auftrag

Ein **Quote Connector ist ohne Konfiguration nicht funktionsfähig**. Um ihn zu aktivieren, müssen Sie eine **ERP-Verbindung** einrichten, die Folgendes kombiniert:

* Zugriffssteuerung (wer darf sie verwenden)
* Authentifizierungs- oder Endpunkt-Einstellungen
* Verhaltensregeln wie Rundung, Warnungen und Genehmigungslogik

Merksatz: **ERP-Verbindung = Quote Connector + Konfiguration**

Sie können mehrere ERP-Verbindungen für denselben Connector einrichten, zum Beispiel für unterschiedliche Länder oder Benutzergruppen.

> [!TIP]
> Alle ERP-Verbindungen werden auf der Registerkarte **ERP-Verbindungen** in der Ansicht **Angebot/Sync** verwaltet.

### SuperOffice Standalone Connector

Dies ist die Standardkonfiguration, wenn kein ERP-System angebunden ist. Ideal bei einfachen Anforderungen oder wenn Produktdaten nicht extern gepflegt werden. Alle Daten werden in SuperOffice gespeichert:

* [Preislisten definieren und Produkte manuell hinzufügen][2]
* Nutzung der integrierten Berechnungslogik
* Keine automatische Auftragsübertragung möglich

> [!NOTE]
> Eine ERP-Verbindung wird dennoch benötigt, sie ist jedoch lokal in SuperOffice und nicht mit einem externen System verbunden.

### ERP-gestütztes Angebotswesen

Bei Integration mit einem ERP-System ruft der Quote Connector Produkt- und Preisdaten direkt aus dem ERP ab:

* Produkte werden in Echtzeit geladen (nicht in SuperOffice gespeichert)
* Preise und Rabatte folgen den ERP-Regeln
* Bestätigte Angebote können automatisch als ERP-Auftrag übermittelt werden

## <a id="tabs"></a>Registerkarten in der Ansicht Angebot/Sync

Die Ansicht Angebot/Sync enthält vier Registerkarten zur Konfiguration von Angebotserstellung, Produkten und ERP-Integration.

### ERP-Verbindungen

Zur Verwaltung von ERP-Verbindungen für Quote Connectors.

* Zeigt alle verfügbaren Quote Connectors (automatisch geladen nach Installation). Zeigen Sie mit der Maus auf eine Zeile, um weitere Details anzuzeigen.
* Zeigt aktive ERP-Verbindungen.
* Doppelklick auf eine Verbindung öffnet die Einstellungen (Umfang, Verhalten, Validierung).
* Markieren Sie eine ERP-Verbindung und klicken Sie auf **ERP-Verbindung testen**, um die Verbindung zu prüfen.

> [!TIP]
> Schritt-für-Schritt-Anleitung unter [ERP-Verbindung einrichten][1].

### SuperOffice-Produkte

Zur Verwaltung der [Preislisten und Produkte][2], die in SuperOffice gespeichert sind (bei Verwendung des Standalone Connectors). Diese werden **nicht** im ERP gespeichert.

Sie können:

* Preislisten hinzufügen, bearbeiten oder löschen.
* Produkte zur Liste hinzufügen oder entfernen. Doppelklick zum Bearbeiten.
* Produktdetails wie Preis, MwSt. und Marge konfigurieren.
* Ein Produktbild zur Anzeige im Angebotsdialog auswählen.

### Einstellungen

Globale Optionen für Angebote und die [Produktdialoganzeige][3] konfigurieren.

* **Rabatt auf Gesamtwert anwenden:** Aktiviert ein Feld für Rabatte auf das Gesamtangebot (Prozent oder Betrag). Zwei Rabattfelder erscheinen unten auf der Registerkarte **Produkte** im Dialog **Angebot bearbeiten**.

    > [!NOTE]
    > Dieser Rabatt wird zusätzlich zu einzelnen Produkt-Rabatten berechnet.

* **Standardtext für Folgeaufgabe:** Text für automatische Folgeaufgaben beim Senden eines Angebots.

* **Verkaufstypen öffnen:** Öffnet die Liste **Verkauf – Typ, Stufen, Angebot**. Jeder Verkauf benötigt einen [Verkaufstyp][5]. Viele Eigenschaften, wie Angebotsvorlage, Gültigkeit und Genehmigungspflicht, werden darüber gesteuert.

Unter **Produktfelder** können Sie konfigurieren, welche Felder im Angebotsdialog angezeigt werden.

### Synchronisierung

Zum [Hinzufügen von Sync Connectors und ERP-Verbindungen][4] für den Datenabgleich von Firmen, Personen und Projekten. Diese Registerkarte ist nur bei ERP-Synchronisierung relevant.

## Verwandte Inhalte

* [ERP-Verbindung einrichten][1]
* [Produkte und Preislisten hinzufügen][2]
* [Produktdialog anpassen][3]
* [ERP-Synchronisierung verwalten][4]

<!-- Referenzierte Links -->
[1]: set-up-quote-connector.md
[2]: price-list-and-products.md
[3]: configure-product-fields.md
[4]: ../../../erp/admin/index.md
[5]: ../sale-type.md
