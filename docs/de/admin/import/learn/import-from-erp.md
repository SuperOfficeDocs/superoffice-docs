---
uid: help-de-import-from-erp
title: aus ERP importieren
description: aus ERP importieren
keywords: import, ERP
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Aus ERP importieren

[!include[Back up database before import](includes/caution-backup-before-import.md)]

Führen Sie die nachfolgenden Schritte aus, um Akteure (Kunden, Lieferanten und Einzelpersonen) von einem ERP-System in die SuperOffice-Datenbank zu importieren.

## Wählen Sie die Akteure aus, die Sie aus dem ERP-System importieren möchten

1. [!include[Open Import](includes/open-import.md)]
2. Klicken Sie auf **ERP Sync** unter **Importquelle auswählen**. Das Dialogfeld **ERP-Verbindung auswählen** wird geöffnet.

     Wenn die Schaltfläche **ERP Sync** inaktiv ist, müssen Sie unter der Registerkarte **Angebot/Sync** > **Sync** die Synchronisierung deaktivieren.

3. In der Liste **ERP-Verbindung** müssen Sie die [Verbindung auswählen][2], die Sie für den Import nutzen möchten.
4. Wählen Sie in der Liste **Aktortyp** die zu importierenden Objekte aus. Zum Beispiel Kunden, Lieferanten Einzelpersonen.
5. Klicken Sie auf **OK**. Das Dialogfeld **ERP durchsuchen** wird angezeigt.
6. [Suchen Sie nach den zu importierenden Akteuren][1], wie alle Lieferanten in einer bestimmten Stadt.
7. Wählen Sie aus der Liste der Suchergebnisse die Zeilen aus, die Sie importieren möchten.
8. Klicken Sie auf **Import hinzufügen**. Die Akteure werden in Einstellungen und Verwaltung angezeigt.

> [!NOTE]
> Zu diesem Zeitpunkt sind die Akteure aus dem ERP-System noch nicht in die SuperOffice-Datenbank importiert worden. SuperOffice lädt lediglich die Akteure, die Sie importieren möchten, damit Sie die Import-Einstellungen festlegen können.

## Import konfigurieren

1. [!include[Configure import settings](includes/configure-import-settings.md)]

[!include[Preview import](includes/step-preview-import.md)]

1. Entfernen Sie die Häkchen neben den Zeilen, die Sie NICHT importieren möchten.

1. Klicken Sie nach der Überprüfung, ob dies wirklich die zu importierenden Daten sind, auf **Import**

## Import abschließen

Wenn der Import endet, werden zwei Listen angezeigt:

* Neue Akteure, die importiert wurden.
* Bestehende Akteure, die durch den Import aktualisiert wurden.

Über jeder Liste befindet sich ein Link zu der Selektion, die die neuen/aktualisierten Akteure beinhaltet.

> [!TIP]
> Verwenden Sie die Auswahl, wenn Sie importierte Akteure aus SuperOffice löschen möchten.

<!-- Referenced links -->
[1]: ../../../search-options/learn/search-criteria.md
[2]: ../../../erp/admin/add-connection.md

<!-- Referenced images -->
