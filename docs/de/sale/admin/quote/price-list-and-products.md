---
uid: help-de-price-list-and-products
title: Preislisten und Produkte verwalten
description: Lernen Sie, wie Sie Preislisten und Produkte im SuperOffice-Produktregister erstellen und verwalten, um sie in Angeboten zu verwenden.
keywords: Preisliste, Produkt hinzufügen, Produkt konfigurieren, Produktbild, Produkt deaktivieren, Produkt, Angebot
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Einstellungen und Verwaltung
language: de
redirect_from:
  - /de/quote/learn/admin/product/add-price-list
  - /de/quote/learn/admin/product/add-product-to-price-list
  - /de/quote/learn/admin/product/index
  - /de/quote/learn/admin/product/quote-delete-deactivate-price-list-or-product
  - /de/quote/learn/admin/product/select-product-image
index: true
---

# Preislisten und Produkte verwalten

In der Registerkarte **SuperOffice-Produkte** im Bildschirm **Angebot/Sync** definieren Sie Preislisten und fügen Produkte hinzu, damit sie in SuperOffice CRM für Angebote verfügbar sind. Diese Konfiguration gilt, wenn der **SuperOffice Standalone-Connector** verwendet wird (keine ERP-Integration).

![Sie können alle Ihre Preislisten in der Registerkarte SuperOffice-Produkte hinzufügen und bearbeiten -screenshot][img2]

Verwenden Sie mehrere Preislisten, um saisonale Preise, Kampagnen oder unterschiedliche Kundensegmente zu unterstützen. Setzen Sie eine begrenzte Gültigkeit, um zu steuern, wann jede Liste verfügbar ist. Fügen Sie Produkte zu Ihren Preislisten hinzu, damit Verkäufer diese mit den korrekten Preisen und Rabattregeln in Angeboten verwenden können.

## Preisliste hinzufügen

1. Wählen Sie in Einstellungen und Verwaltung <i class="ph ph-barcode" aria-label="Barcode icon"></i> **Angebot/Sync** im Navigator.

1. Wechseln Sie zur Registerkarte **SuperOffice-Produkte**.

1. Klicken Sie oben auf **Hinzufügen**. Das Dialogfeld **Preisliste hinzufügen/bearbeiten** wird geöffnet.

1. Füllen Sie die folgenden Felder aus:

    * **Name der Preisliste:** Geben Sie einen aussagekräftigen Namen ein, um die Preisliste leichter von anderen zu unterscheiden.
    * **Beschreibung:** (Optional) Geben Sie eine kurze Beschreibung ein.
    * **Aktiv:** Aktivieren Sie diese Option, um die Preisliste für die Angebotserstellung verfügbar zu machen. Sie sollten die Preisliste erst aktivieren, wenn sie vollständig vorbereitet ist.
    * **Begrenzte Gültigkeit:** (Optional) Aktivieren Sie diese Option und setzen Sie einen Zeitraum, wenn die Liste nur für einen bestimmten Zeitraum verfügbar sein soll. Sie können ein Start- und ein Enddatum *ODER* nur ein Enddatum wählen.

    > [!NOTE]
    > Sie können Währung und Gültigkeit nach der Erstellung der Preisliste nicht mehr ändern. Um mehrere Währungen zu aktivieren, gehen Sie zu **Einstellungen** > **System** > **Unterschiedliche Währungen zulassen**.

1. Wählen Sie eine der folgenden Optionen:

    * **Leere Preisliste hinzufügen:** Beginnen Sie von Grund auf neu.
    * **Bestehende Preisliste kopieren:** Duplizieren Sie eine vorhandene Preisliste.
      * **Preise aus Originalpreisliste in &lt;Währung&gt; umrechnen:** Wählen Sie diese Option, um die bestehenden Preise der Preisliste zu verwenden. Bei einer Preisliste mit abweichender Währung werden die Preise automatisch konvertiert.
      * **Preise auf null &lt;Währung&gt; setzen:** Wählen Sie diese Option, wenn Sie die Preise nicht übernehmen möchten. Sie müssen dann alle Preise manuell eingeben.

1. Klicken Sie auf **OK**.

## <a id="add-product"></a>Produkte zu einer Preisliste hinzufügen

1. Wählen Sie in der Registerkarte **SuperOffice-Produkte** eine Preisliste aus.

1. Klicken Sie unten auf **Hinzufügen**. Das Dialogfeld **Produkt hinzufügen/bearbeiten** wird geöffnet.

1. Geben Sie die Produktdetails ein. Sie können konfigurieren:

    * Textfelder (Name, Code, Mehrwertsteuer usw.)
    * Zahlenfelder (Kosten, Mindestpreis, Menge)
    * Dropdown-Listen (Einheiten, Produktgruppe, Produkttyp)
    * Durchsuchbare Listen (für Lieferanten oder verwandte Artikel): Sie können aus der Liste der zuletzt verwendeten Einträge wählen, Text eingeben, um eine Suche zu starten, oder auf die Suchschaltfläche (<i class="ph ph-magnifying-glass" aria-hidden="true"></i>) klicken, um eine erweiterte Suche zu starten.

1. (Optional) Klicken Sie auf **Bild ändern**, um ein Produktbild hinzuzufügen.

1. (Optional) Geben Sie eine Beschreibung im Textbereich unten links ein.

1. (Optional) Aktivieren Sie **Standardsicherheit überschreiben**, um die Felder-Sicherheit speziell für dieses Produkt anzupassen.

1. Aktivieren Sie **In Preisliste einbeziehen**, um das Produkt zu aktivieren. Sie sollten dies erst tun, wenn alle erforderlichen Produktinformationen eingegeben wurden.

1. Klicken Sie auf **Speichern** oder **Speichern + neu**, um weitere Produkte hinzuzufügen.

> [!TIP]
> Sie können weitere List-Alternativen in der Ansicht **Listen** hinzufügen.
>
> Sie können [Produkte aus einer Excel-Tabelle importieren][5], anstatt sie manuell einzeln hinzuzufügen.

## <a id="image"></a>Produktbild hinzufügen oder ändern

Fügen Sie hochwertige Produktbilder zu Ihren Angeboten hinzu, um Ihren Kunden die richtigen Produkte visuell zu präsentieren.

1. Wählen Sie eine Preisliste aus und doppelklicken Sie auf ein Produkt.

1. Klicken Sie auf **Bild ändern** unten im Vorschaubereich im Dialogfeld **Produkt hinzufügen/bearbeiten**.

1. Wählen Sie im Dialogfeld **Bild auswählen** ein Bild aus der Datenbank aus. Nur verfügbare Bilder werden angezeigt.

1. Klicken Sie auf **OK**, um das Bild dem Produkt hinzuzufügen.

![Sie können jedem Produkt, das Sie einer Preisliste hinzufügen, ein Bild hinzufügen -screenshot][img1]

[!include[Dateityp und -größe](../../../learn/includes/image-type-and-size.md)]

## <a id="deactivate"></a>Produkte oder Preislisten deaktivieren

Wir empfehlen, **Produkte und Preislisten zu deaktivieren**, anstatt sie zu löschen. So bleiben Angebotsverläufe erhalten und Fehler werden vermieden. Deaktivierte Produkte und Preislisten stehen für neue Angebote nicht zur Verfügung, bleiben jedoch in bestehenden Angeboten erhalten.

### Preisliste deaktivieren

1. Wählen Sie eine Preisliste aus und klicken Sie auf **Bearbeiten**.
2. Führen Sie eine der folgenden Aktionen aus:
    * Deaktivieren Sie **Aktiv**.
    * Aktivieren Sie **Eingeschränkte Gültigkeit** und legen Sie ein abgelaufenes **Gültig bis**-Datum fest.
3. Klicken Sie auf **OK**.

### Produkt deaktivieren

1. Wählen Sie die Preisliste, die das Produkt enthält.
2. Deaktivieren Sie das Kontrollkästchen neben dem Produkt, das Sie deaktivieren möchten.

## <a id="export"></a>Preisliste exportieren

1. Wählen Sie auf der Registerkarte **SuperOffice-Produkte** eine Preisliste aus.
2. Klicken Sie unten auf <i class="ph ph-download-simple" aria-hidden="true"></i> **Exportieren**.

Sie können ausgewählte Produkte oder die gesamte Liste exportieren.

> [!TIP]
> Stellen Sie sicher, dass Sie [sichtbare Spalten anpassen][4], bevor Sie exportieren.

### Exportieren nicht verfügbar?

Überprüfen Sie, ob der Benutzer die erforderlichen [Zugriffsrechte][7] hat und dass die Export-[Einstellung][8] aktiviert ist.

## Verwandte Inhalte

* [Felder im Dialogfeld Produkt hinzufügen/bearbeiten konfigurieren][3]
* [Produkte aus Excel importieren][5]
* [ERP-Verbindung einrichten][1]

<!-- Referenced links -->
[1]: set-up-quote-connector.md
[3]: configure-product-fields.md
[4]: ../../../learn/section-tabs/configure-columns.md
[5]: ../../../admin/import/products-from-excel.md
[7]: ../../../admin/user-management/role/index.md
[8]: ../../../admin/preferences/learn/index.md

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/sale/add-products-to-price-list.png
[img1]: ../../../../media/loc/en/sale/add-edit-product.png
