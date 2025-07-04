---
uid: help-de-quote-connector-setup
title: ERP-Verbindung für Quote Connector einrichten
description: Erfahren Sie, wie Sie einen Quote Connector konfigurieren und ERP-Verbindungen erstellen, um die Produkt- und Preis-Integration in SuperOffice CRM zu aktivieren.
keywords: quote connector einrichten, quote connector hinzufügen, ERP-Verbindung hinzufügen, ERP-Verbindung testen, ERP-Verbindung, quote connector, connector, Angebot
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Einstellungen und Verwaltung
language: de
redirect_from: /de/quote/learn/admin/erp-connection-add
---

# ERP-Verbindung für Quote Connector einrichten

Um Angebotsfunktionen in SuperOffice CRM zu aktivieren, müssen Sie eine **ERP-Verbindung** mithilfe eines verfügbaren **Quote Connectors** erstellen. Die ERP-Verbindung bestimmt, woher Produktdaten und Preislogik stammen – entweder aus einem externen ERP-System oder aus dem integrierten Produktregister von SuperOffice.

## 1. Quote Connector-App beziehen

Bevor Sie einen Quote Connector verwenden können, müssen Sie die richtige App für Ihr ERP-System installieren.

1. Gehen Sie zum [SuperOffice App Store][4].

2. Suchen Sie nach einem Quote Connector, der Ihr ERP-System unterstützt.

    * [Quote Connector-Apps][3]
    * [Sync-Apps (optional)][2]

3. Folgen Sie den Anweisungen des Anbieters, um die App zu installieren.

4. Kontaktieren Sie gegebenenfalls den App-Anbieter, um die Konfiguration abzuschließen.

## 2. Eine ERP-Verbindung hinzufügen

Sobald der Connector verfügbar ist, müssen Sie eine ERP-Verbindung konfigurieren, um ihn zu aktivieren.

1. Öffnen Sie **Einstellungen und Verwaltung** und wählen Sie im Navigator <i class="ph ph-barcode" aria-label="Barcode icon"></i> **Angebot/Sync**.

1. Wechseln Sie zur Registerkarte **ERP-Verbindungen**.

1. Klicken Sie auf **Hinzufügen**. Das Dialogfeld **Neue ERP-Verbindung definieren** öffnet sich.

    ![Neue ERP-Verbindung definieren -screenshot][img1]

1. Füllen Sie die erforderlichen Felder aus:

    * **Name:** Interner Name der Verbindung
    * **Quote Connector:** Wählen Sie den Connector aus, den Sie verwenden möchten
    * **Umfang:** Bestimmen Sie, wer die Verbindung nutzen darf:
      * **Alle:** Zugriff für alle Benutzer
      * **Spezifische Benutzer und Gruppen:** Nur ausgewählte Benutzer und Gruppen erhalten Zugriff. Klicken Sie auf den Link, um den Umfangsauswahldialog zu öffnen.
    * **ERP-Verbindung:** (falls erforderlich) ERP-Verbindung aus der Sync-Connector-Liste auswählen
    * **Konfigurationsfelder:** Variieren je nach Connector und können Folgendes umfassen:
      * Anmeldedaten
      * Server- oder Endpunktinformationen
      * Geschäftsregeln wie Rundung, Rabattvalidierung oder Fallback-Logik

1. Optional: Geben Sie eine **Beschreibung** ein, um den Zweck der Verbindung zu erläutern.

1. Klicken Sie auf **ERP-Verbindung testen**, um die Verbindung zu überprüfen.

    > [!NOTE]
    > Der Test muss erfolgreich sein, bevor gespeichert werden kann.

1. Klicken Sie auf **OK**, um die ERP-Verbindung zu speichern.

Die neue Verbindung wird nun in der Liste angezeigt und kann für Angebote verwendet werden.

## ERP-Verbindungen löschen oder wiederherstellen

So löschen Sie eine ERP-Verbindung:

1. Wählen Sie die Verbindung in der Liste aus und klicken Sie auf **Löschen**.

So stellen Sie eine gelöschte Verbindung wieder her:

1. Aktivieren Sie die Option **Gelöscht**.
1. Wählen Sie die Verbindung aus der Liste.
1. Klicken Sie auf **Wiederherstellen**.

<!-- Referenced links -->
[2]: https://online.superoffice.com/appstore/app/search?phrase=sync
[3]: https://online.superoffice.com/appstore/app/search?phrase=quote
[4]: https://online.superoffice.com/appstore

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/quote-erp-connection.png
