---
uid: help-de-lead-admin
title: Lead-Management einrichten
description: Erfahren Sie, wie Sie das Lead-Management in SuperOffice CRM aktivieren, konfigurieren und erweitern.
keywords: Lead-Management, Lead-Einrichtung, Lead-Status, potenzieller Kunde, Verkaufsprozess
author: digitaldiina
date: 11.12.2025
version: 10.6
content_type: concept
category: sale
topic: lead
license: salesessentials
audience: settings
audience_tooltip: Einstellungen und Verwaltung
index: true
language: de
---

# Lead-Management einrichten

Das Lead-Management in SuperOffice CRM hilft Ihnen, potenzielle Kunden vom ersten Kontakt über die Qualifizierung bis in den Verkaufsprozess zu verfolgen. Administratoren müssen festlegen, welche Firmenkategorien **Lead-Status** verwenden, die verfügbaren Statuswerte überprüfen und optional die Nachverfolgung mit Marketingdaten erweitern.

> [!NOTE]
> Die Standardkategorien *Lead*, *Marketingqualifiziertes Lead*, *Verkaufschance* und *Verlorene Chance* sind nur in neuen Datenbanken enthalten.
> Bestehende Kunden müssen Kategorien manuell hinzufügen oder aktualisieren, um den Lead-Status zu aktivieren.

## Schritt 1: Lead-Status für eine Firmenkategorie aktivieren

Der Lead-Status kann nur für Kategorien verwendet werden, die zur Gruppe **Potenzieller Kunde** gehören. Stellen Sie sicher, dass mindestens eine Kategorie auf diese Weise eingerichtet ist, bevor Sie das Lead-Management aktivieren.

1. Gehen Sie zu **Einstellungen und Verwaltung** > **Listen** > **Firma – Kategorie**.
1. Erstellen Sie eine neue Kategorie oder bearbeiten Sie eine vorhandene.
1. Setzen Sie **Kategoriengruppe** auf *Potenzieller Kunde*.
1. Wählen Sie **Lead-Status für diese Kategorie aktivieren**.
1. Klicken Sie **OK**, um die Änderungen zu speichern.

Weitere Informationen finden Sie unter [Firmenkategorie und Kategoriengruppe][1].

## Schritt 2: Lead-Status-Liste anpassen

Die Liste **Person – Lead-Status** definiert die Qualifizierungsstufen, die in Ihrer Organisation verwendet werden. Standardmäßig enthält SuperOffice Status wie *Offen*, *Kontaktaufnahme*, *Qualifiziert*, *Disqualifiziert* und *Erneut bearbeiten*.

1. Gehen Sie zu **Einstellungen und Verwaltung** > **Listen** > **Person – Lead-Status**.
1. Überprüfen Sie die vordefinierten Elemente.
1. Fügen Sie Status hinzu, bearbeiten oder entfernen Sie sie, um Ihren Qualifizierungsprozess anzupassen.

Detaillierte Schritte finden Sie unter [Lead-Status verwalten][2].

## Schritt 3: (Optional) Mit Marketing Premium erweitern

Wenn Sie Marketing Premium verwenden, können Sie zusätzliche Nachverfolgungs- und Automatisierungsfunktionen in Ihrem Lead-Prozess nutzen:

* **UTM-Tracking:** Erfassen Sie die Quelle neuer Leads aus Onlineformularen.
  Siehe [UTM-Daten aus Formularen verfolgen][3].
* **Lead-Nurturing-Flow:** Neue Leads automatisch an Benutzer verteilen.
  Siehe [Neue Leads verteilen][4].

## Verwandte Inhalte

* [Übersicht über das Lead-Management][5]
* [Firmenkategorie und Kategoriengruppe][1]
* [Lead-Status verwalten][2]

[1]: add-company-category.md
[2]: add-lead-status.md
[3]: ../learn/index.md
[5]: ../../marketing/utm/admin/set-up.md
[4]: ../../marketing/flows/learn/define-flow-actions.md#distribute
