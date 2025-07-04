---
uid: help-de-selection
title: Selektion
description: Selektion
keywords: Selektion
author: Bergfrid Dias
date: 03.21.2025
version: 10.5.3
content_type: concept
audience: person
audience_tooltip: SuperOffice CRM
language: de
redirect_from:
  - /de/search-options/selection/learn/combined-selections
  - /de/search-options/selection/learn/dynamic-selections
  - /de/search-options/selection/learn/static-selections
  - /de/search-options/selection/learn/screen/index
---

# Selektion

Sie können Selektionen von Datensätzen/Daten erstellen, mit denen Sie häufig arbeiten. Wenn Sie außerdem über eine Lizenz für den Verkaufsangebotzugriff verfügen, können Sie auch Selektionen von Produkten erstellen.

> [!TIP]
> Sie können aus Selektionen Diagramme erstellen und auch Kampagnen mithilfe von Selektionen erstellen.

Alle Selektionen enthalten einen Überblick von Firmen und Personen, die mit den Datensätzen in der entsprechenden Selektion verknüpft sind. Firmen und Personen, die zum Beispiel mit den Verkäufen in einer Verkaufsselektion verknüpft sind.

## <a id="types"></a>Typen

SuperOffice CRM verfügt über drei verschiedene Selektionstypen:

* **Statische Selektion:** Enthält nur Mitglieder, die manuell hinzugefügt wurden.
* **Dynamische Selektion:** Wird automatisch mit Mitgliedern aktualisiert, die den Selektionskriterien entsprechen.
* **Kombinierte Selektion:** Eine Kombination aus zwei vorhandenen Selektionen.

### Statische Selektionen

Eine statische Selektion enthält nur Mitglieder, die Sie manuell oder durch eine Suche hinzugefügt haben, im Gegensatz zu einer dynamischen Selektion. Sobald Sie eine statische Selektion erstellt und Mitglieder hinzugefügt haben, bleibt diese unverändert, bis Sie manuell Mitglieder hinzufügen oder entfernen.

Verwenden Sie eine statische Selektion, wenn Sie jederzeit vollständige Kontrolle über deren Mitglieder behalten möchten. Sie können [Mitglieder manuell hinzufügen und entfernen][7], entweder einzeln oder durch eine Suche.

**Beispiel:** Eine handverlesene Liste von VIP-Kunden für eine personalisierte Marketingkampagne.

### Dynamische Selektionen

Eine dynamische Selektion funktioniert wie eine gespeicherte Suche, die jedes Mal ausgeführt wird, wenn Sie die Selektion aufrufen. Jedes Mal, wenn Sie Datensätze zu SuperOffice CRM hinzufügen, die die Suchkriterien einer dynamischen Selektion erfüllen, wird diese automatisch mit den neuen Mitgliedern aktualisiert – im Gegensatz zu einer statischen Selektion.

Verwenden Sie eine dynamische Selektion, wenn Sie eine stets aktuelle Liste von Firmen, Personen, Verkäufen, Projekten, Dokumenten, Folgeaufgaben, Anfragen oder Produkten benötigen, die bestimmten Kriterien entsprechen.

**Beispiel:** Eine Echtzeit-Liste aller offenen Verkaufschancen im aktuellen Quartal, die automatisch aktualisiert wird, wenn neue Deals erstellt werden.

### Kombinierte Selektionen

Eine kombinierte Selektion ist eine Kombination aus zwei vorhandenen Selektionen (statisch oder dynamisch). Sie kann Datensätze enthalten, die beiden Selektionen gemeinsam sind, sich unterscheiden, nur in einer der Selektionen vorhanden sind oder alle Datensätze aus beiden Selektionen umfassen.

**Beispiel:** Eine gefilterte Liste aller Kunden, die ein bestimmtes Produkt gekauft haben und gleichzeitig eine offene Support-Anfrage haben, um die Priorisierung von Folgeaufgaben zu erleichtern.

Nach der [Erstellung einer kombinierten Selektion][4] können Sie diese in eine statische Selektion umwandeln.

## <a id="tabs"></a>Registerkarten in der Ansicht Selektion

| Registerkarte | Beschreibung |
|---|---|
| Mitgliederliste | Zeigt die Liste der Datensätze in der Selektion an. |
| Firma/Person | Zeigt Firmen und Personen, die mit den Selektionsmitgliedern verknüpft sind. Wenn die Selektion Firmen oder Personen enthält, ist dies die einzige Registerkarte mit Mitgliedern. |
| Kriterien | Kriterien für eine dynamische Selektion anzeigen und [bearbeiten][9]. |
| Details | Allgemeine Informationen zur Selektion anzeigen und bearbeiten. |
| Diagramme | [Selektionsdaten als Diagramm anzeigen.][3] Diagramme können auch in [Dashboards][16] verwendet werden. |
| Kampagnen | Zeigt Kampagnen, die für diese Selektion archiviert wurden. [Neue Kampagne erstellen][8] für Persone in der Selektion. |

> [!TIP]
> Klicken Sie auf <i class="ph ph-gear" aria-label="Gear"></i> rechts neben den Spaltenkopfzeilen einer Selektion, um Datensätze zu gruppieren und zu filtern, Spalten hinzuzufügen oder zu entfernen und Berechnungen zu definieren. Diese Einstellungen können für die aktive Selektion gespeichert werden, indem Sie **Spalten nur für die aktuelle Selektion speichern** auswählen.

## <a id="members"></a>Selektionsmitglieder

Die erste Registerkarte zeigt die Datensätze in der Selektion an. Doppelklicken Sie auf einen Datensatz, um die Details zu öffnen und anzuzeigen.

Das Layout variiert je nach Art der Selektion. Alle Selektionen außer **Firma/Person** enthalten zwei Listen: eine für die Selektionsdaten und eine für verknüpfte Firmen und Personen.

> [!NOTE]
> Standardmäßig werden nur die ersten 100 Datensätze angezeigt. Um dies zu ändern, gehen Sie zu <i class="ph ph-user-circle" aria-hidden="true"></i> **Persönliche Einstellungen** > **Einstellungen** > **Funktionen** > **Größe der Archivseite**.

### <a id="filter"></a>Mitgliederliste filtern

1. Klicken Sie auf **Alle anzeigen** in der Fußzeile der Registerkarte, um alle Datensätze einzubeziehen.

1. Um den [Spaltenfilter][12] zu aktivieren, klicken Sie auf <i class="ph ph-gear" aria-label="Gear"></i> und wählen Sie **Filter aktivieren**. Die Filtersymbole (<i class="ph ph-funnel" aria-hidden="true"></i>) erscheinen nun in den Spalten, die gefiltert werden können.

## Schaltflächen

| Schaltfläche | Name | Beschreibung |
|---|---|---|
| <i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i> | Aufgabenmenü | Führt verschiedene Aufgaben für Selektionsmitglieder aus, wie das Senden von E-Mails, Massenbearbeitung und Export. Die verfügbaren Aufgaben hängen vom Datensatztyp im Feld **Selektion aus** ab. |
| <i class="ph ph-arrow-clockwise" aria-hidden="true"></i> | Aktualisieren | Aktualisiert die Daten in der Liste. |
| **Anzahl: Zahl** | | Zeigt die Anzahl der Mitglieder in der aktiven Selektion an. |
| <i class="ph ph-download-simple" aria-hidden="true"></i> | Exportieren | [Exportiert die Liste in eine Tabellenkalkulation.][6] |

## <a id="ex"></a>Beispiele für die Verwendung von Selektionen

Selektionen ermöglichen es Ihnen, Daten basierend auf bestimmten Kriterien zu gruppieren und zu filtern. Unten finden Sie Beispiele für verschiedene Arten von Selektionen und deren mögliche Anwendungsfälle.

### Firmen

Sie können eine dynamische Selektion erstellen, die alle Firmen der Kategorie *Lieferant* mit Standort in Deutschland enthält, wenn Sie weitere Aktivitäten in Deutschland planen.

### Personen

* Alle Personen, die in den letzten 30 Tagen erstellt wurden.
* Alle Personen, für die Sie *Weihnachtskarte* oder *Newsletter* als Interesse definiert haben.

### Verkäufe

Eine Selektion mit allen Verkäufen, die Sie im ersten Quartal abgeschlossen haben, oder mit allen Ihren Verkäufen mit dem Status **Aufgeschoben**, hilft Ihnen dabei, Trends zu erkennen und Ihre zukünftigen Vertriebsaktivitäten zu steuern.

> [!TIP]
> [Gruppieren Sie Spalten und summieren Sie Beträge][10], um Trends zu erkennen und einen klaren Überblick über Ihre Daten zu erhalten.

![Selektion der Verkäufe - Gruppierung und Summe der Beträge -screenshot][img3]

### Projekte

* Eine Selektion mit allen laufenden Projekten des Typs *Intern* hilft Ihnen dabei zu bewerten, welche Projekte abgeschlossen werden können und welche noch weiterverfolgt werden sollten.

* Alle aktiven Projekte, an denen Sie beteiligt sind.

### Dokumente

* Eine Selektion mit allen Dokumenten, die Sie im letzten Monat erstellt haben, gibt Ihnen einen Überblick darüber, welche Dokumente erstellt wurden, und hilft Ihnen, übersehene Dokumente zu identifizieren.

* Alle in SuperOffice CRM registrierten Verträge.

### Folgeaufgaben

* Eine Selektion mit allen Folgeaufgaben für einen bestimmten Kunden gibt Ihnen einen Überblick über die Beziehung zum Kunden, bevor Sie ein Verkaufsgespräch führen.

* Eine Selektion mit allen Folgeaufgaben für den aktuellen Monat zeigt Ihnen, welche Meetings geplant sind und ob Sie weitere ansetzen sollten.

### Produkte (erfordert eine Sales Premium-Lizenz)

* Eine Liste aller Kunden, die ein bestimmtes Produkt oder eine bestimmte Produktkategorie erworben haben.

* Eine Selektion aller in diesem Jahr verkauften Produkte, basierend auf Verkäufen mit Angeboten und dem Status **Verkauft**. Diese kann nach bestimmten Produktkategorien, Produktfamilien usw. gefiltert werden, je nach gewünschtem statistischen Output.

* Wenn Sie ein Produkt-Upgrade von z. B. Version 2 auf Version 3 durchführen möchten, können Sie eine Selektion aller Kunden erstellen, die Version 2 gekauft haben, und diese als Basis für eine Kampagne verwenden.

### Anfragen

* Eine Liste aller offenen Anfragen mit der Priorität **Hoch** für Ihre Abteilung (Kategorie).

* Eine Selektion aller offenen Anfragen, die seit mehr als einer Woche nicht aktualisiert wurden, hilft Ihnen dabei, die verantwortlichen Anfragenbearbeiter nachzuverfolgen.

### Selektionen

* Alle aktiven Selektionen, die Ihnen gehören.
* Alle Selektionen mit einer bestimmten Kategorie oder eines bestimmten Typs.

### Marketing und Kundenkommunikation

* Nicht verarbeitete Formularübermittlungen Ihrer Kunden.
* Ihre Chat-Gespräche.
* Chat-Gespräche Ihrer Kunden mit bestimmten Bewertungen.
* Mailings mit einer bestimmten Öffnungs- oder Klickraten.
* Mailings mit einer hohen Rate an unzustellbaren Nachrichten.

## Verwandte Inhalte

* [Datensatz als Favoriten hinzufügen][11]
* [Selektionen erstellen][2]
* [Selektionen bearbeiten oder löschen][5]
* [Aufgaben in der Ansicht Selektion ausführen][1]
* [Selektionen als Diagramme anzeigen][3]

<!-- Referenced links -->
[1]: howto/index.md
[3]: howto/display-as-charts.md
[6]: howto/export.md
[8]: howto/create-mailings.md
[2]: create.md
[4]: combine.md
[5]: update.md
[7]: add-remove-members-static.md
[9]: ../../learn/search-criteria.md
[11]: ../../../learn/basics/fav.md
[10]: ../../../learn/section-tabs/configure-columns.md#calculate
[12]: ../../../learn/section-tabs/filter.md
[16]: ../../../dashboard/learn/create.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/sale/selection-sales-column-calculation-grouping.png
