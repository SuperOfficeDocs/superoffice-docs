---
uid: help-de-erp-update-connection
title: ERP-Verbindung bearbeiten
description: Erfahren Sie, wie Sie den Namen, Geltungsbereich oder die Konfiguration einer bestehenden ERP-Verbindung in SuperOffice CRM ändern.
keywords: ERP-Verbindung bearbeiten, ERP-Einstellungen ändern, Sync Connector, ERP-Konfiguration, SuperOffice Sync
author: Bergfrid Dias
date: 03.31.2025
version: 10.5
topic: howto
license: development-tools
audience: settings
audience_tooltip: Einstellungen und Verwaltung
language: de
---

# ERP-Verbindung bearbeiten

Sie können den Namen, den Geltungsbereich oder die Konfigurationswerte einer bestehenden ERP-Verbindung bearbeiten.

> [!NOTE]
> Wenn die Verbindung aktiv ist (Häkchen in der Spalte **Aktiv**), müssen Sie sie vorübergehend deaktivieren, um die Konfigurationswerte ändern zu können. Denken Sie daran, die Verbindung nach der Konfiguration wieder zu aktivieren.

## Schritte

1. Im **Einstellungen und Verwaltung**, wählen Sie im Navigator <i class="ph ph-barcode" aria-label="Barcode icon"></i> **Angebot/Sync**, und wechseln Sie zur Registerkarte **Sync**.

1. Wählen Sie die ERP-Verbindung aus und klicken Sie auf **ERP-Verbindung konfigurieren**.

1. Ändern Sie den Namen oder den Geltungsbereich nach Bedarf.

1. Zum Aktualisieren der connector-spezifischen Konfigurationsfelder:

    1. Deaktivieren Sie das Kontrollkästchen **Aktiv**.
    1. Aktualisieren Sie die Felder nach Bedarf.
    1. Aktivieren Sie **Aktiv**.
    1. Klicken Sie auf **ERP-Verbindung testen** und beheben Sie eventuelle Fehler.

1. Klicken Sie auf **OK**, um die Änderungen zu speichern und den Dialog zu schließen.

1. Wenn Sie Feldzuweisungen, Standardwerte oder Listenverknüpfungen anpassen möchten, nutzen Sie die Schaltflächen unten links im Dialog. Ausführliche Anleitungen finden Sie unter [ERP-Verbindung konfigurieren][1].

## Fehlerbehebung

### ERP-Verbindung kann nicht gespeichert werden

Wenn die Schaltfläche **OK** beim Hinzufügen oder Bearbeiten einer Verbindung deaktiviert ist:

* Stellen Sie sicher, dass der Verbindungstest erfolgreich war.
* Prüfen Sie, ob alle Pflichtfelder ausgefüllt sind.
* Überprüfen Sie, ob alle erforderlichen Einstellungen (wie z. B. Umfang) vorgenommen wurden.

## Verwandte Inhalte

* [Einen Sync Connector und eine ERP-Verbindung hinzufügen][2]
* [Firmen, Personen und Projekte mit ERP-Akteuren verknüpfen][3]

<!-- Referenced links -->
[1]: configure.md
[2]: add-connection.md
[3]: ../learn/connect.md
