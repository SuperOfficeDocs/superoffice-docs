---
uid: help-de-product-fields-configure
title: Felder im Dialogfeld Produkt hinzufügen/bearbeiten konfigurieren
description: Erfahren Sie, wie Sie steuern, welche Felder im Dialogfeld Produkt hinzufügen/bearbeiten angezeigt werden und wie sie sich verhalten.
keywords: Produktdialog konfigurieren, Dialog Produkt hinzufügen/bearbeiten, Produkt konfigurieren, Produktdialog, Produktfeld, Produkt, Angebot
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
topic: howto
license: salespremium
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Felder im Dialogfeld Produkt hinzufügen/bearbeiten konfigurieren

Verwenden Sie das Dialogfeld **Produkt konfigurieren**, um zu steuern, welche Felder angezeigt werden, wenn Benutzer ein Produkt in einem Angebot hinzufügen oder bearbeiten. Sie können Felder ein- oder ausblenden, Bezeichnungen ändern, QuickInfos definieren sowie Felder als bearbeitbar und/oder obligatorisch festlegen.

Diese Einstellungen gelten global für alle ERP-Verbindungen des Quote Connectors und betreffen zwei Dialoge:

* **Dialogfeld Produkt hinzufügen/bearbeiten (Benutzer):** Wird angezeigt, wenn Benutzer ein Produkt zu einer Angebotszeile hinzufügen.
* **Dialogfeld Produkt hinzufügen/bearbeiten (Admin):** Wird auf der Registerkarte **SuperOffice-Produkte** verwendet, wenn Administratoren Produkte zu einer Preisliste hinzufügen.

## Schritte

1. Gehen Sie in Einstellungen und Verwaltung auf <i class="ph ph-barcode" aria-label="Barcode icon"></i> **Angebot/Synchronisierung**.

1. Wechseln Sie zur Registerkarte **Einstellungen**.

1. Klicken Sie auf **Produkt konfigurieren**.

    ![Dialog Produkt konfigurieren -screenshot][img1]

1. Wählen Sie im Dialogfeld die Sprache, die Sie konfigurieren möchten. Sie können Bezeichnungen und QuickInfos sprachspezifisch anpassen.

1. Für jedes Feld in der Liste:

    * **Feld anzeigen:** Steuert die Sichtbarkeit im Dialogfeld **Produkt hinzufügen/bearbeiten** für Angebote. Felder werden in Einstellungen und Verwaltung immer angezeigt. Einige Felder sind ausgegraut und können nicht ausgeblendet werden.

        Verwenden Sie **Alle aktivieren** oder **Alle deaktivieren**, um die Sichtbarkeit schnell zu ändern.

    * **Bezeichnung:** Geben Sie einen benutzerfreundlichen Namen für das Feld ein. Lassen Sie das Feld leer, um die Standardbezeichnung zu verwenden.
    * **QuickInfo:** Fügen Sie einen kurzen Hilfetext hinzu, der angezeigt wird, wenn Benutzer den Mauszeiger über das Feld bewegen. Verwenden Sie die Bildlaufleiste, wenn der Text lang ist.
    * **Bearbeitung möglich:** Ermöglicht Benutzern, den Wert zu ändern.
    * **Obligatorisch:** Erfordert, dass Benutzer das Feld in der Angebotszeile ausfüllen. Aktiviert automatisch **Bearbeitung möglich**.

        Sie können die Einstellungen für Bearbeitung möglich und Obligatorisch pro Produkt überschreiben. Für systemgesteuerte Felder sind diese Optionen jedoch sowohl im Dialogfeld **Produkt konfigurieren** als auch im Dialogfeld **Produkt hinzufügen/bearbeiten** deaktiviert.

    * **Reihenfolge:** Verwenden Sie die Pfeile <i class="ph ph-arrow-circle-up" aria-hidden="true"></i> <i class="ph ph-arrow-circle-down" aria-hidden="true"></i>, um die Reihenfolge der Felder im Dialogfeld zu ändern.

        Die Reihenfolge wirkt sich auf beide Dialoge aus. Einige Felder haben jedoch eine feste Position im Dialogfeld **Produkt hinzufügen/bearbeiten** für Angebote und können nicht verschoben werden.

1. Klicken Sie auf **OK**, um Ihre Änderungen zu speichern.

1. Wiederholen Sie diesen Vorgang bei Bedarf für weitere Sprachen.

## Tipps

* Es müssen nicht alle Felder angezeigt werden. Sie können Felder ausblenden, die Benutzer nicht ausfüllen müssen, wie z.B. Lieferantencode.
* Verwenden Sie klare und beschreibende Bezeichnungen und QuickInfos für zusätzliche Felder.
* Änderungen an den Bezeichnungen werden nach der nächsten Anmeldung wirksam.

## Verwandte Inhalte

* [Produkt zu einer Preisliste hinzufügen][1]
* [Produkt in einem Angebot hinzufügen/bearbeiten][2]

<!-- Referenced links -->
[1]: price-list-and-products.md
[2]: ../../learn/quote/create.md#add-products

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/configure-product-dialog.png
