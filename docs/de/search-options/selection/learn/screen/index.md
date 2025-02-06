---
uid: help-de-selection-screen
title: Bereichsregisterkarten in der Ansicht Selektion
description: Bereichsregisterkarten in der Ansicht Selektion
keywords: Selektion
author: Bergfrid Dias
date: 09.17.2024
version: 10.3.9
topic: reference
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Die Ansicht Selektion

Die erste Registerkarte in einer Selektion enthält eine Liste der Mitglieder (Datensätze, Daten) in der aktiven Selektion. Selektionsmitglieder können Firmen oder Personen, Projekte, Verkäufe, Dokumente, Folgeaufgaben, Formularübermittlungen, Chat-Gespräche, Kampagnen oder Produkte sein.

Das Erscheinungsbild der Mitgliederliste variiert ein wenig, je nachdem, welche Elemente in der Selektion enthalten sind. Alle Selektionstypen außer **Firma/Person** verfügen über zwei Registerkarten mit Selektionsdaten.

> [!TIP]
> Wenn Sie auf einen Datensatz in der Mitgliederliste doppelklicken, wird der Datensatz angezeigt.

## Bereichsregisterkarten in der Ansicht Selektion

| Registerkarte | Beschreibung |
|---|---|
| Mitgliederliste | Enthält Selektionsdaten. |
| Firma/Person | Enthält Firmen und Personen, die mit der Mitgliederliste verknüpft sind. Beispiel: Alle Personen oder Firmen, die mit dem Vertrieb in einer Selektion verknüpft sind. Wenn die Selektion Firmen/Personen enthält, ist dies die einzige Registerkarte mit Mitgliedern. |
| Kriterien | Für eine dynamische Selektion [Kriterien bearbeiten][3] und anzeigen.. |
| Details | [Allgemeine Informationen für eine Selektion][1] anzeigen und bearbeiten. |
| Diagramme | [Selektionsdaten in einem Diagramm anzeigen.][5] Diagramme aus Selektionen können ebenfalls in [Dashboards][6] verwendet werden. |
| Kampagnen | Eine Kampagne erstellen, die an Personen in einer Selektion gesendet werden soll. [Kampagnen anzeigen](#mailing), die in dieser Selektion archiviert sind. |

> [!TIP]
> Klicken Sie auf <i class="ph ph-gear" aria-label="Gear"></i> rechts neben den Spaltenkopfzeilen in einer Selektion, um Datensätze zu gruppieren und zu filtern, Spalten hinzuzufügen/zu entfernen, und Berechnungen angeben. Diese Einstellungen können für die aktive Selektion gespeichert werden, indem Sie **Spalten nur für die aktuelle Selektion speichern** auswählen. Siehe auch [Abschnittsregisterkarten][9] für zusätzliche Funktionen.

Um zwischen Selektionen zu wechseln, klicken Sie auf die Schaltflächen Zurück/Weiter (<i class="ph ph-arrow-left" aria-hidden="true"></i><i class="ph ph-arrow-right" aria-hidden="true"></i>) weiter oben rechts in der Ansicht.

### <a id="filter"></a>Mitgliederliste filtern

> [!NOTE]
> Bevor Sie die Mitgliederliste filtern (zum Beispiel nach Verkäufen oder Folgeaufgaben), müssen Sie in der Registerkarte Fußzeile auf **Alle anzeigen** klicken. So stellen Sie sicher, dass auf der Registerkarte alle Datensätze in der Selektion angezeigt werden. Zur Optimierung der Leistung bei der Arbeit mit großen Selektionen werden üblicherweise nur die ersten 100 Datensätze in die Mitgliederliste geladen.

Um den Spaltenfilter zu aktivieren, klicken Sie auf <i class="ph ph-gear" aria-label="Gear"></i> rechts neben den Spaltenkopfzeilen und dann auf **Filter aktivieren**. Die Filterschaltfläche (<i class="ph ph-funnel" aria-hidden="true"></i>) wird jetzt in der Spalte angezeigt, die [gefiltert][8] werden kann.

### Schaltfläche Aufgabe <i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>

Verwenden Sie die Schaltfläche **Aufgabe**, um verschiedene Aufgaben für alle oder einige Mitglieder der Selektion auszuführen. Beispiele: Senden von E-Mails, Massenbearbeitung und Exportieren. Welche Aufgaben angezeigt werden, hängt vom Datensatztyp in der Selektion ab (welche Auswahl Sie im Feld **Selektion aus** getroffen haben).

### Andere Schaltflächen

* **Mitglieder entfernen**. Diese Option ist nur für statische Selektionen verfügbar. Um [bestimmte Mitglieder der Selektion zu entfernen][2], wählen Sie die entsprechenden Mitglieder aus, klicken mit der rechten Maustaste und wählen **Entfernen** aus.

* **Anzahl: Zahl**, die Anzahl der Mitglieder in der aktiven Selektion.

* **Alle anzeigen**. Wird verwendet, um alle Selektionsmitglieder anzuzeigen.

    > [!NOTE]
    > Standardmäßig zeigt die Liste nur die ersten 100 Datensätze in der Selektion. Gehen Sie zu <i class="ph ph-user-circle" aria-hidden="true"></i> **Persönliche Einstellungen** > **Einstellungen** > **Funktionen** > **Größe der Archivseite**, um diesen Wert zu ändern.

* <i class="ph ph-arrow-clockwise" aria-label="Refresh"></i>: Aktualisiert die Daten in der Liste.

### <a id="mailing"></a> Bei Selektion archivierte Kampagnen anzeigen

Verwenden Sie die Registerkarte **Kampagnen** in der Ansicht Selektion, um einen Überblick über alle Kampagnen bezüglich einer Selektion zu behalten.

Doppelklicken Sie auf eine Kampagne, um sie zu öffnen.

**Kampagne erstellen**: Klicken Sie auf [neue Kampagne erstellen][7], um für die Personen in dieser Selektion bestimmt ist.

**Exportieren**: Wird verwendet, um die Liste in eine Tabellenkalkulation zu exportieren.

## Verwandte Themen

* [Aufgaben in der Ansicht Selektion ausführen][4]
* [Filter in Bereichsregisterkarten verwenden][8]
* [Selektionen erstellen][1]

<!-- Referenced links -->
[1]: ../create/index.md
[2]: ../update/add-remove-members-static.md
[5]: ../howto/display-as-charts.md
[3]: ../../../learn/search-criteria.md
[6]: ../../../../dashboard/learn/create.md
[7]: ../../../../marketing/mailing/learn/create/index.md
[8]: ../../../../learn/section-tabs/filter.md
[9]: ../../../../learn/section-tabs/index.md
[4]: ../../../../learn/getting-started/index.md

<!-- Referenced images -->
