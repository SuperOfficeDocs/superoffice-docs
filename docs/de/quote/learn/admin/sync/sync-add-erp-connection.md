---
uid: help-de-sync-add-erp-connection
title: ERP-Verbindung hinzufügen (Sync Connector)
description: ERP-Verbindung hinzufügen (Sync Connector)
author: SuperOffice RnD
date: 06.29.2022
keywords: Angebot, Sync, Connector, ERP
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# ERP-Verbindung hinzufügen (Sync Connector)

Jeder Sync Connector muss über eine ERP-Verbindung mit Konfigurationsdaten verfügen, um den Sync Connector mit SuperOffice zu verknüpfen.

## ERP-Verbindung hinzufügen

1. Gehen Sie zur Registerkarte **Sync** in der Ansicht Angebot/Sync.

1. Klicken Sie unten in der **ERP-Verbindungen**-Liste auf **Hinzufügen**. Das Dialogfeld **Neue ERP-Verbindung definieren** erscheint.

1. Geben Sie den Namen der ERP-Verbindung in das Feld **Name** ein.

1. Wählen Sie den gewünschten **ERP Sync Connector** in der Liste aus. Diese Liste ist identisch mit den **Sync Connectors**.

1. Wählen Sie den gewünschten **Umfang** aus:

    * **Jeder**: Wählen Sie diese Option aus, wenn alle Benutzer Zugriff auf diese ERP-Verbindung haben und sie verwenden können sollen. Das bedeutet, dass sie die Preislisten verwenden können, die über diese Verbindung verfügbar sind.
    * **Spezifische Benutzer + Gruppen**: Klicken Sie auf **Es sind keine Benutzer oder Benutzergruppen ausgewählt**, um auszuwählen, welche Benutzer und/oder Benutzergruppen Zugriff auf diese ERP-Verbindung erhalten sollen.

1. Legen Sie unter **Konfigurationsfelder** die gewünschten Einstellungen fest. Der Inhalt dieser Liste variiert je nach gewähltem Sync Connector-Typ.

1. Geben Sie eine Beschreibung der ERP-Verbindung in das Feld unten in der Ansicht ein.

1. Klicken Sie auf **ERP-Verbindung testen**, um zu verifizieren, dass die Verbindung hergestellt werden kann. Wenn Sie eine Fehlermeldung erhalten, müssen Sie das Problem beheben, bevor Sie fortfahren können.

1. Klicken Sie auf **OK**. Die ERP-Verbindung wird in der Liste **ERP-Verbindungen** angezeigt.

    > [!NOTE]
    > Die Schaltfläche **OK** ist deaktiviert, bis der Test der ERP-Verbindung erfolgreich abgeschlossen wurde.

Aktivieren Sie die Spalte **Aktiv**, um die Verbindung zu aktivieren und die Registerkarte **ERP** in SuperOffice CRM anzuzeigen. Bevor Sie jedoch die ERP-Verbindung aktivieren, müssen Sie sicherstellen, dass sie richtig konfiguriert ist:

* Spezifizieren Sie die Synchronisationseinstellungen und wählen Sie aus, welche Felder im Suchfenster und in der Registerkarte **ERP** angezeigt werden sollen. Siehe [Feldzuordnung konfigurieren][1] und [Listenzuordnung konfigurieren][2].

* Sie müssen für die Felder [erforderliche Standardwerte definieren][3], die normalerweise nur einen relevanten Wert haben, damit der Benutzer keine Werte mehr in diese Felder eingeben muss.

* Die müssen die [Reihenfolge der ERP-Felder auswählen][4], die in der Registerkarte ERP in SuperOffice CRM angezeigt werden.

* Wenn Sie mehrere ERP-Verbindungen verwenden, können Sie [Prioritäten für Verbindungen][5] festlegen.

* [Daten aus dem ERP-System importieren][6]

<!-- Referenced links -->
[1]: sync-configure-field-allocation.md
[2]: sync-configure-list-mapping.md
[3]: sync-configure-default-values.md
[4]: sync-rank-fields-shown-in-erp-tab.md
[5]: sync-set-sync-priority.md
[6]: ../../../../admin/import/learn/import-from-erp.md

<!-- Referenced images -->
