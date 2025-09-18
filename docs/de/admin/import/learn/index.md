---
uid: help-de-import
title: Import
description: Import
author: SuperOffice RnD
date: 02.22.2023
keywords: Importieren
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Personen und Produktdaten importieren

Eine leere CRM-Datenbank hilft Ihnen nicht bei der Verwaltung Ihrer Personen. Wenn Sie all Ihre Kundendaten mit unserer Importfunktion auf einmal importieren, können Sie schnell mit der Verwaltung Ihrer Kundenbeziehungen in SuperOffice CRM ausführen.

Verwenden Sie den Windows-Client? Siehe [Einstellungen für den Windows-Client][7].

[!include[Back up database before import](includes/caution-backup-before-import.md)]

In der Ansicht **Import** können Sie Firmen, Personen und Produkte in SuperOffice importieren. Sie können sowohl neue Firmen/Personen als auch bereits vorhandene Firmen/Personen mit aktualisierten Daten importieren.

> [!NOTE]
> Für jeden Import wird in SuperOffice CRM eine Selektion erstellt. Dies ermöglicht es Ihnen, die importierten Firmen/Personen weiter zu bearbeiten oder diese zu löschen.

## Quellen

Die Importfunktion unterstützt das Importieren von Daten aus den folgenden Quellen:

* [Excel][1]. Unter Verwendung des Excel-Formats können Sie Firmen, Personen und [Produkte][5] aus anderen Anwendungen und Formaten importieren.
* [Outlook][2]. Importiert Firmen und Personen aus Microsoft Outlook.
* [Gmail][3]. Importiert Firmen und Personen aus Google Gmail.
* [ERP][4]. Importiert Akteure (Kunden, Lieferanten und Einzelpersonen) aus einem ERP-System.

> [][7]
> Um andere Daten wie Projekte, Verkäufer, Währungen, Postleitzahlen und gesetzliche Feiertage importieren zu können, müssen Sie die Funktion **Importieren** in den Einstellungen für den Windows-Client verwenden.

## In leere SuperOffice-Datenbank importieren

* Importieren Sie alle Firmen- und Personendaten. Stellen Sie sicher, dass alle Spalten im Import mit den richtigen SuperOffice-Feldern verknüpft sind, und legen Sie die richtigen [Importeinstellungen][6] fest, um alle notwendigen Daten in den Import einzubinden.

* Nur Firmen importieren: Wenn Sie nur Firmen ohne Personen importieren möchten, gehen Sie zu [Importeinstellungen][6] und wählen Sie die Option **Keine – Person nicht importieren** im Listenfeld **Treffer duplizieren** unter **Person** aus.

* Nur Personen importieren: Wenn Sie nur Personen ohne Firmen importieren möchten, gehen Sie zu [Importeinstellungen][6] und wählen Sie die Option **Personen ohne Firma importieren** im Listenfeld **Wenn kein Firmenname** unter **Person** aus.

## Alte Daten in SuperOffice aktualisieren

Falls SuperOffice veraltete Informationen enthält und Sie die betreffenden Felder mit den richtigen Informationen zum Beispiel aus Excel aktualisieren möchten, sollten Sie die Aktion **Ersetzen – vorhandenes überschreiben** beim Importieren durchführen lassen. In leere SuperOffice-Felder werden ebenfalls neue Informationen eingetragen.

## Zusätzliche Informationen importieren

Wenn Ihnen viele Informationen über Kunden und Personen in SuperOffice fehlen, verwenden Sie beim Importieren von Firmen und Personen die Aktion **Zusammenführen - leere Felder aktualisieren**. Dies aktualisiert nur leere Felder , ohne die vorhandenen Informationen zu überschreiben.

<!-- Referenced links -->
[1]: import-from-excel.md
[2]: import-from-outlook.md
[3]: import-from-gmail.md
[4]: import-from-erp.md
[5]: import-products-from-excel.md
[6]: configure-import-settings.md
[7]: https://help.superoffice.com/docs/10.3/en/onsite/win-client/learn/import/index.html

<!-- Referenced images -->
