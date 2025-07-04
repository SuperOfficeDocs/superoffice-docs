---
uid: help-de-erp-add-connection
title: Sync Connector und ERP-Verbindung hinzufügen
description: Erfahren Sie, wie Sie eine Sync-App installieren, einen Sync Connector hinzufügen und ERP-Verbindungen erstellen, um die Synchronisation zwischen SuperOffice CRM und einem ERP-System zu ermöglichen.
keywords: ERP-Synchronisation einrichten, Sync Connector hinzufügen, ERP-Verbindung hinzufügen, ERP-Verbindung testen, ERP-Verbindung, Connector, Synchronisation, ERP
author: Bergfrid Dias
date: 03.31.2025
version: 10.5
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Einstellungen und Verwaltung
language: de
redirect_from:
  - /de/quote/learn/admin/sync/sync-add-erp-connection
  - /de/quote/learn/admin/sync/sync-connector-add
---

# Sync Connector und ERP-Verbindung hinzufügen

[!include[Requirement](../../learn/includes/req-expander-services.md)]

Um Daten zwischen SuperOffice CRM und einem ERP-System zu synchronisieren, müssen Sie zunächst eine Sync-App installieren. Danach konfigurieren Sie in **Einstellungen und Verwaltung** einen Sync Connector und eine oder mehrere ERP-Verbindungen.

## 1. Sync-App installieren

Bevor Sie einen Sync Connector hinzufügen können, benötigen Sie eine passende Sync-App für Ihr ERP-System.

1. Prüfen Sie im [SuperOffice App Store][7], ob eine Standard-Sync-App für Ihr ERP-System verfügbar ist.

    Falls keine Standard-App vorhanden ist oder Sie eine angepasste Lösung benötigen, können Sie eine [von einem SuperOffice-Partner][8] oder Ihrem internen Team entwickeln lassen.

1. Befolgen Sie die Anweisungen des App-Anbieters zur Installation und Registrierung des Connectors.

## <a id="connector"></a>2. Sync Connector hinzufügen

1. In **Einstellungen und Verwaltung** wählen Sie im Navigator <i class="ph ph-barcode" aria-label="Barcode icon"></i> **Angebot/Sync**.

1. Öffnen Sie die Registerkarte **Sync**.

1. Klicken Sie unter der Liste **Sync Connectors** auf **Hinzufügen**.

1. Geben Sie den Namen und die Connector-URL ein.

1. Klicken Sie auf **OK**.

Der Sync Connector wird der Liste hinzugefügt.

![Sync-Registerkarte mit einem Sync Connector in Einstellungen und Verwaltung -screenshot][img1]

## <a id="connection"></a>3. ERP-Verbindung hinzufügen

1. Klicken Sie in der Registerkarte **Sync** unter der Liste **ERP-Verbindungen** auf **Hinzufügen**.

    Das Dialogfeld **Neue ERP-Verbindung definieren** wird geöffnet.

    ![Dialog Neue ERP-Verbindung definieren mit Beispieldaten -screenshot][img2]

1. Geben Sie einen Namen für die ERP-Verbindung ein.

1. Wählen Sie aus der Liste den gewünschten Sync Connector aus.

1. Definieren Sie den **Umfang**:

    * **Jeder**: Alle Benutzer haben Zugriff auf diese ERP-Verbindung.
    * **Spezifische Benutzer + Gruppen**: Nur ausgewählte Benutzer und Gruppen erhalten Zugriff. Klicken Sie auf den Link, um den Umfangsauswahldialog zu öffnen.

        ![Dialog Unfang konfigurieren mit Benutzergruppenauswahl -screenshot][img3]

1. Füllen Sie die **Konfigurationsfelder** aus. Diese hängen vom gewählten Connector ab und können Authentifizierung, Dateipfade, Zahlenformate oder andere technische Werte enthalten.

1. Optional: Geben Sie eine Beschreibung ein, die den Zweck der Verbindung verdeutlicht.

1. Klicken Sie auf **ERP-Verbindung testen**.

    Wenn der Test fehlschlägt, überprüfen Sie die Connector-URL und Konfigurationsfelder. Sie müssen das Problem beheben, bevor Sie fortfahren können.

1. Klicken Sie auf **OK**, um die Verbindung zu speichern. Die neue ERP-Verbindung wird in der Liste angezeigt.

    Wenn die Schaltfläche **OK** ausgegraut ist, bedeutet das, dass entweder der Test nicht erfolgreich war oder Pflichtfelder fehlen.

> [!NOTE]
> Bevor die ERP-Verbindung verwendet werden kann, müssen Sie die Synchronisationseinstellungen konfigurieren und die Verbindung aktivieren. Siehe [ERP-Verbindung konfigurieren][1].

## Nächste Schritte

* [Feldzuweisung und Listen konfigurieren][1]
* [Standardwerte definieren][3]
* [Reihenfolge der ERP-Felder festlegen][4], die im ERP-Register in SuperOffice CRM angezeigt werden
* [Synchronisierungspriorität festlegen][5]
* [Daten aus dem ERP-System importieren][6]

<!-- Referenced links -->
[1]: configure.md
[3]: configure.md#defaults
[4]: configure.md#rank
[5]: configure.md#priority
[6]: ../../admin/import/learn/import-from-erp.md
[7]: https://online.superoffice.com/appstore/app/search?phrase=sync
[8]: ../../developer-portal/custom-app/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/erp/sync-connectors-list.png
[img2]: ../../../media/loc/en/erp/define-erp-connection.png
[img3]: ../../../media/loc/en/erp/configure-scope.png
