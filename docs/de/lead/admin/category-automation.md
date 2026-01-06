---
uid: help-de-lead-category-automation
title: Lead-Kategorisierung automatisieren
description: Konfigurieren Sie automatische Kategorie-Updates, wenn sich der Verkaufsstatus ändert oder der Lead-Status aktualisiert wird, um manuelle Arbeit zu reduzieren und die Datengenauigkeit zu erhalten.
keywords: Lead-Management, Kategorie-Automatisierung, Workflow, Lead-Kategorisierung, automatisches Kategorie-Update
author: digitaldiina
date: 01.13.2026
version: 11.8
content_type: howto
category: sale
topic: lead
license: salespremium
audience: settings
audience_tooltip: Einstellungen und Verwaltung
index: true
language: de
---

# Lead-Kategorisierung automatisieren

[!include[Must be admin](../../learn/includes/req-admin.md)]

Die Automatisierung von Firmen-Kategorie-Updates hilft, manuelle Arbeit zu reduzieren und stellt sicher, dass Ihre Daten genau bleiben. Wenn sich der Status eines Verkaufs ändert oder ein Lead-Status aktualisiert wird, kann die zugehörige Firma automatisch mit der richtigen Kategorie aktualisiert werden.

Sie können die Automatisierung so konfigurieren, dass sie vollautomatisch läuft oder den Benutzer auffordert, die Änderung zu bestätigen, bevor sie angewendet wird.

## Voraussetzungen

* Sie müssen über Administratorrechte verfügen, um auf **Einstellungen und Verwaltung** zugreifen zu können.
* Die aktuelle Kategorie der Firma muss zur Gruppe **Potenzieller Kunde** gehören, um für automatische Updates berechtigt zu sein. Siehe [Firmenkategorie und Kategoriegruppe][1].
* Für Lead-Status-basierte Automatisierung muss **Lead-Status** für die aktuelle Kategorie der Firma aktiviert sein.

## Kategorie-Automatisierungsregeln konfigurieren

Sie können eine oder alle der folgenden Automatisierungsregeln aktivieren:

| Automatisierungsregel | Beschreibung |
|---|---|
| Kategorie aktualisieren, wenn ein Verkauf gewonnen wurde | Aktualisiert automatisch die Firmenkategorie, wenn ein Verkauf als **Gewonnen** markiert wird. |
| Kategorie aktualisieren, wenn ein Verkauf verloren wurde | Aktualisiert automatisch die Firmenkategorie, wenn ein Verkauf als **Verloren** markiert wird. |
| Kategorie aktualisieren, wenn ein Verkauf bei der Firma registriert wird | Aktualisiert automatisch die Firmenkategorie, wenn ein neuer Verkauf erstellt und mit der Firma verknüpft wird. |
| Kategorie aktualisieren, wenn ein Lead-Status gesetzt wird auf | Aktualisiert automatisch die Firmenkategorie, wenn der Lead-Status eines Kontakts auf einen bestimmten Wert geändert wird, z. B. *Qualifiziert* oder *Disqualifiziert*. Erfordert, dass der Lead-Status für die Kategorie aktiviert ist. |

### Schritte

1. Öffnen Sie **Einstellungen und Verwaltung**.

1. Wählen Sie im Navigator <i class="ph ph-arrows-left-right" aria-hidden="true"></i> **Workflow**.

1. Wählen Sie die Registerkarte **Lead-Kategorisierung**. Dieser Bildschirm zeigt Automatisierungsoptionen.

    ![Admin-Workflow - Registerkarte Lead-Kategorisierung mit Automatisierungs-Schaltern -screenshot][img1]

1. Aktivieren Sie den Schalter für die Regel, die Sie aktivieren möchten.

1. Wenn Sie einen Schalter aktivieren, werden zusätzliche Optionen angezeigt:

    * **Kategorie festlegen auf:** Wählen Sie die Zielkategorie aus der Liste. Dies ist die Kategorie, auf die die Firma aktualisiert wird, wenn die Bedingung erfüllt ist.

        Sie können jede Kategorie auswählen, unabhängig von ihrer Kategoriegruppe.

    * **Benutzerbestätigung vor Aktualisierung anfordern:** Aktivieren Sie dieses Kontrollkästchen, wenn der Benutzer die Kategorieänderung bestätigen soll, bevor sie angewendet wird.

        Lassen Sie es deaktiviert für vollautomatische Updates.

1. Wiederholen Sie dies für alle anderen Regeln, die Sie aktivieren möchten.

1. Klicken Sie auf **Speichern**, um Ihre Änderungen zu übernehmen, oder auf **Abbrechen**, um sie zu verwerfen.

> [!NOTE]
> Die Schaltfläche **Speichern** ist aktiviert erst nachdem Sie eine Kategorie im Feld **Kategorie festlegen auf** für alle aktivierten Schalter ausgewählt haben.

## Wann Benutzerbestätigung verwendet werden sollte

Entscheiden Sie basierend auf Ihren Geschäftsanforderungen, ob Kategorie-Updates automatisch sein sollten oder eine Benutzerbestätigung erfordern:

* **Vollautomatisch:** Am besten für einfache Lead-zu-Kunde-Workflows, bei denen Kategorieänderungen vorhersehbar und konsistent sind. Zum Beispiel automatisches Verschieben eines Leads in die Kategorie *Kunde*, wenn ein Verkauf als gewonnen markiert wird.

* **Benutzerbestätigung:** Empfohlen, wenn Kategorieänderungen Urteilsvermögen erfordern oder mehrere Kategorien zutreffen können. Wenn Sie beispielsweise mit mehreren Kundenstufen (VIP, A, B, C) arbeiten, stellt die Benutzeraufforderung sicher, dass die richtige Kategorie ausgewählt wird.

Wenn **Benutzerbestätigung vor Aktualisierung anfordern** aktiviert ist, sieht der Benutzer einen Dialog, der die Kategorieänderung vorschlägt. Er kann den Vorschlag annehmen oder vor dem Speichern eine andere Kategorie auswählen.

## Beispiel: Lead-zu-Kunde-Übergang automatisieren

Ein häufiger Anwendungsfall besteht darin, einen Lead automatisch auf eine Kundenkategorie zu aktualisieren, wenn ein Verkauf gewonnen wird:

1. Aktivieren Sie **Kategorie aktualisieren, wenn ein Verkauf gewonnen wurde**.

1. Setzen Sie **Kategorie festlegen auf** = *Kunde*.

1. Lassen Sie **Benutzerbestätigung vor Aktualisierung anfordern** deaktiviert für vollständige Automatisierung.

1. Klicken Sie auf **Speichern**.

Wenn jetzt ein Verkauf, der mit einer Firma in der Gruppe *Potenzieller Kunde* verknüpft ist, als gewonnen markiert wird, ändert sich die Firmenkategorie automatisch auf *Kunde*.

## Verwandte Inhalte

* [Firmenkategorie und Kategoriegruppe][1]
* [Übersicht über Lead-Management][3]
* [Lead-Status verwalten][2]
* [Verkauf aktualisieren][4]
* [Verkaufshandbücher][5]

<!-- Referenced links -->
[1]: add-company-category.md
[2]: add-lead-status.md
[3]: ../learn/index.md
[4]: ../../sale/learn/update.md
[5]: ../../sale/learn/sales-guides.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/admin/admin-workflow-lead-categorization.png
