---
uid: help-de-dashboard-tiles
title: Arbeiten mit Kacheln
description: Erfahren Sie, wie Sie Kacheln in Ihren SuperOffice-Dashboards hinzufügen, anpassen und verwalten.
keywords: Kachel hinzufügen, Kachel bearbeiten, Kachel kopieren, Kachel duplizieren, Kachel entfernen, Kachel anpassen, Datensatz, Dashboard, Kachel
author: digitaldiina
date: 11.21.2025
version: 11.6
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: de
redirect_from:
  - /de/dashboard/learn/add-tile
  - /de/dashboard/learn/edit-tile
  - /de/dashboard/learn/remove-tile
---

# Arbeiten mit Kacheln

Erfahren Sie, wie Sie Kacheln in Ihren SuperOffice-Dashboards hinzufügen, anpassen und verwalten. Kacheln sind visuelle Zusammenfassungen auf Basis von CRM-Daten – ideal zur Verfolgung von Anfragen, Verkäufen, Aktivitäten oder Marketingergebnissen.

Sie können vordefinierte Kacheln verwenden oder eigene erstellen.

## Voraussetzung: in den Layoutmodus wechseln

Um Kacheln zu verwalten, müssen Sie zuerst in den Layoutmodus wechseln:

1. Öffnen Sie das Dashboard, das Sie anpassen möchten.

1. Klicken Sie in der Kopfzeile des Dashboards auf <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> und wählen Sie **Dashboard-Kacheln bearbeiten**.

    Das Dashboard wechselt in den Layoutmodus:
    * Die Seitenleiste **Dashboard-Kacheln bearbeiten** wird rechts angezeigt.
    * Jede Kachel zeigt ein Bearbeitungssymbol (<i class="ph ph-pencil" aria-hidden="true"></i>).
    * Sie können Kacheln hinzufügen, verschieben, in der Größe ändern oder bearbeiten.

## <a id="add"></a>Kachel hinzufügen

1. Wählen Sie in der Seitenleiste **Dashboard-Kacheln bearbeiten** den gewünschten Datentyp (z. B. Firma, Verkauf oder Anfrage) aus der Liste **Kacheln anzeigen für**.

    ![Seitenleiste Dashboard-Kacheln bearbeiten -screenshot][img1]

1. Wählen Sie eine Kachel aus dem **Bibliothek**-Tab (vordefinierte Kacheln) oder dem Tab **Selektionen** (basierend auf eigenen dynamischen Selektionen).

    * Verwenden Sie das **Suchfeld**, um Kacheln schneller zu finden.
    * Ein Symbol zeigt den Kacheltyp an – zum Beispiel Diagramm, Liste oder große Zahl.

1. Fügen Sie die Kachel dem Dashboard hinzu:
    * **Ziehen Sie die Kachel** in einen freien Bereich, oder
    * klicken Sie auf das Symbol <i class="ph ph-plus" aria-label="+"></i>, das erscheint, wenn Sie mit der Maus über den Kachelnamen fahren.

    Die Kachel wird automatisch an den verfügbaren Platz angepasst und am Layout des Dashboards ausgerichtet.

1. Ändern Sie bei Bedarf die Größe oder Position der Kachel.

1. Klicken Sie auf **Fertig**, um den Layoutmodus zu verlassen.

### Eine Kachel von Grund auf neu erstellen

1. Wählen Sie die Option **Leere Kachel** für den gewünschten Datentyp.
1. Fügen Sie die Kachel dem Dashboard hinzu.
1. Geben Sie im Dialogfeld **Kachel bearbeiten** einen aussagekräftigen Namen ein.
1. Wählen Sie den Tab **Datensatz** und [definieren Sie die Kriterien][4], um zu steuern, welche Daten angezeigt werden.

    ![Dialog Kachel bearbeiten, Tab Datensatz -screenshot][img2]

    Dieser Tab funktioniert wie der [Bildschirm Suchen][5]. Verwenden Sie ihn, um Filter wie Besitzer, Zeitraum oder Kategorie festzulegen.

1. Wechseln Sie zum Tab **Layout**, um das Erscheinungsbild der Kachel zu konfigurieren. Wählen Sie [Diagrammtyp][3], Beschriftungen, Sortierung und andere Formatierungsoptionen.

    ![Dialog Kachel bearbeiten, Tab Layout -screenshot][img3]

1. Klicken Sie auf **Speichern**, und anschließend auf **Fertig**, um den Layoutmodus zu beenden.

### <a id="selection-chart"></a>Über selektionsbasierte Kacheln

Wenn Sie eine Kachel über den Tab **Selektionen** hinzufügen, wird sie **nicht** mit der Selektion verknüpft. Stattdessen wird der aktuelle Datensatz und das Layout aus dem [Diagramm der Selektion][6] kopiert. Danach sind die Kachel und die Selektion voneinander unabhängig.

Der Tab **Selektionen** zeigt nur:

* Dynamische Selektionen
* Selektionen, die dem Typ in **Kacheln anzeigen für** entsprechen
* Selektionen mit einem gespeicherten Diagramm im Tab **Diagramm**

Wenn eine Selektion nicht angezeigt wird, prüfen Sie:

* Handelt es sich um eine statische Selektion? Nur dynamische Selektionen werden unterstützt.
* Stimmt der Datensatztyp (Firma, Verkauf usw.) mit dem ausgewählten Typ überein?
* Wurde im Tab **Diagramm** ein Diagramm gespeichert?

Nach dem Hinzufügen:

* Änderungen an den **Kriterien** oder dem **Diagramm** der Selektion wirken sich **nicht** auf die Kachel aus.
* Änderungen am **Datensatz** oder **Layout** der Kachel wirken sich **nicht** auf die Selektion aus.
* Die **Kachel bleibt nicht synchronisiert** mit der Selektion, wird aber weiterhin dynamisch basierend auf dem eigenen Datensatz aktualisiert.

Wenn Sie möchten, dass die Kachel spätere Änderungen an der Selektion widerspiegelt, müssen Sie entweder die Kachel manuell anpassen oder sie löschen und erneut aus der aktualisierten Selektion hinzufügen.

### Kachel für Web-Bildschirm hinzufügen

Verwenden Sie diese Kachel, um eine Webseite im Dashboard einzubetten:

1. Setzen Sie **Kacheln anzeigen für** auf **Sonstige**.
1. Wählen Sie im Tab **Bibliothek** die Option **Web-Bildschirm**.
1. Geben Sie die URL ein, die angezeigt werden soll.
1. Wenn die URL HTTP (nicht HTTPS) verwendet, aktivieren Sie **Unsichere Adresse zulassen**.
1. Klicken Sie auf **Speichern** und dann auf **Fertig**, um den Layout-Modus zu verlassen.

### HTML-Kachel hinzufügen

Verwenden Sie diese Kachel, um formatierten Text in Ihrem Dashboard anzuzeigen, z. B. eine Willkommensnachricht, Legende oder interne Erläuterung.

1. Setzen Sie **Kacheln anzeigen für** auf **Sonstige**.
1. Wählen Sie im Tab **Bibliothek** die Option **HTML**.
1. Klicken Sie auf **Hinzufügen**, um mindestens eine Sprache für den Inhalt auszuwählen.
1. Verwenden Sie den integrierten Editor, um den Inhalt einzugeben und zu formatieren.

    Sie können dieselben Formatierungsoptionen verwenden, die auch im Chat und in Formularen zur Verfügung stehen. Fügen Sie Inhalte in mehreren Sprachen hinzu, um sicherzustellen, dass die Kachel für alle Benutzer korrekt angezeigt wird.

1. Klicken Sie auf **Speichern** und dann auf **Fertig**, um den Layout-Modus zu verlassen.

## <a id="edit"></a>Kachel bearbeiten

1. Klicken Sie im Layout-Modus auf das Symbol **Bearbeiten** (<i class="ph ph-pencil" aria-hidden="true"></i>) auf der Kachel.
1. Passen Sie auf der Registerkarte **Datensatz** die Filter nach Bedarf an.
1. Wählen Sie auf der Registerkarte **Layout** den Diagrammtyp und die visuellen Einstellungen aus.
1. Aktualisieren Sie den Namen der Kachel, um die geänderten Daten oder das Layout widerzuspiegeln.
1. Klicken Sie auf <i class="ph ph-translate" aria-label="Translate"></i>, um eine [Übersetzung][7] für den Kacheltitel und die Beschriftungen hinzuzufügen.
1. Klicken Sie auf **Speichern**.

## <a id="copy"></a>Eine Kachel duplizieren oder kopieren

Sie können eine vorhandene Kachel wiederverwenden, indem Sie sie entweder im selben Dashboard duplizieren oder in ein anderes Dashboard kopieren. Um eine Kachel zu kopieren, benötigen Sie **Bearbeitungsrechte für das Ziel-Dashboard**.

1. Klicken Sie auf <i class="ph ph-dots-three-vertical" aria-label="Aufgabe"></i> in der Kachel und wählen Sie die Option zum Duplizieren oder Kopieren.

| Option | Funktion | Nächster Schritt | Anwendungsfall |
|---|---|---|---|
| **Kachel duplizieren** | Erstellt eine Kopie der Kachel im aktuellen Dashboard. Der Name wird angepasst (z. B. *Kachelname 2*). | Bearbeiten Sie in der Regel die duplizierte Kachel: Ändern Sie den Namen, das Dataset oder Layout. | Zeigen Sie dieselben Daten in einem anderen Layout an oder ähnliche Daten mit gleichem Layout. |
| **Kachel in Dashboard kopieren** | Fügt die Kachel einem anderen Dashboard hinzu. Wählen Sie das Ziel-Dashboard aus der Liste. Wenn Sie mit der Maus über den Dashboardnamen fahren, sehen Sie eine Vorschau der enthaltenen Kacheln. | Öffnen Sie optional das Ziel-Dashboard und bearbeiten Sie die Kachel dort. | Nutzen Sie eine hilfreiche Kachel aus dem Dashboard eines Kollegen in einem eigenen Dashboard. |

**Kachel in Dashboard kopieren** ist auch außerhalb des Layoutmodus (Standard-Dashboardansicht) verfügbar.

## <a id="move"></a>Kacheln verschieben oder skalieren

Im Layoutmodus können Sie:

* **Eine Kachel über die Kopfzeile ziehen**, um sie an eine andere Position zu verschieben.
* **Eine Kachel skalieren**, indem Sie den unteren oder rechten Rand oder die Ecke unten rechts ziehen.

Die Kacheln rasten automatisch in das Rasterlayout des Dashboards ein.

Wenn Sie die Anzahl der Spalten ändern möchten, verlassen Sie den Layoutmodus und aktualisieren Sie die Dashboard-Details.

## <a id="remove"></a>Eine Kachel entfernen

Sie können Kacheln aus einem Dashboard entfernen, sofern Sie über die erforderlichen Bearbeitungsrechte verfügen.

1. Klicken Sie im Layoutmodus auf <i class="ph ph-dots-three-vertical" aria-label="Aufgabe Kachel"></i> in der Kachel.
1. Wählen Sie **Kachel entfernen**.
1. Bestätigen Sie die Löschung.

> [!CAUTION]
> Benutzerdefinierte Kacheln wie HTML, Web-Bildschirm und Kacheln aus Selektionen werden beim Entfernen dauerhaft gelöscht. Nur vordefinierte Kacheln aus der Bibliothek können später sicher erneut hinzugefügt werden.

## <a id="export"></a>Kacheln exportieren

### Kachelbericht herunterladen oder drucken

Klicken Sie im Kopfbereich einer Kachel auf <i class="ph ph-dots-three-vertical" aria-label="Aufgabe"></i>, um folgende Optionen anzuzeigen:

* **PDF-Dokument herunterladen** / **PNG-Dokument herunterladen**: Exportieren Sie die Kachel im PDF- oder PNG-Format. Die Dateien werden im **Download**-Ordner Ihres Browsers gespeichert.

    Für andere Formate (**SVG, CSV und XLS**) wählen Sie **Vollbild anzeigen** im Menü.

* **Drucken**: Öffnet die Kachel im Druckdialog.

> [!TIP]
> Um bestimmte Daten vor dem Exportieren oder Drucken auszublenden, klicken Sie auf die Datenbezeichnungen (Legende) neben oder unter der Kachel.

### ALLE Zeilen eines Datensatzes nach Excel exportieren

1. Klicken Sie auf einen Datenpunkt in der Kachel, um die zugrunde liegenden Daten anzuzeigen.

    Ein neues Fenster mit den zugehörigen Datensätzen wird geöffnet.

1. Klicken Sie unter der Liste auf <i class="ph ph-download-simple" aria-label="Download"></i> **Exportieren**.

1. Klicken Sie auf **Ja**, um zu bestätigen.

    Dieser Vorgang kann eine Weile dauern. Sie können währenddessen in SuperOffice weiterarbeiten. Sie erhalten eine Benachrichtigung, wenn der Export abgeschlossen ist.

## Tipps

* **Währungsbezeichnung ausblenden:** Um Platz zu sparen, setzen Sie **Währung** auf **Ausblenden** in der Registerkarte Layout.

* **Mit Zielwert vergleichen:** Aktivieren Sie **Mit Ziel vergleichen** auf der Registerkarte Layout, um den Fortschritt gegenüber Verkaufszielen anzuzeigen. Diese Option hängt vom Diagrammtyp und Dataset ab.

* **Kurze Zahlenformate verwenden:** Für Kacheln mit großen Zahlenwerten aktivieren Sie das Format **Kurze Zahl**, um Werte in Millionen darzustellen (z. B. *1,2 M*).

* **Große Zahlen-Kacheln:** Nutzen Sie diese für zentrale Kennzahlen wie Umsatz oder offene Anfragen. Halten Sie den Kachelnamen kurz, damit der Wert gut sichtbar ist.

* **Dauer bei Folgeaufgaben anzeigen:** Wenn Sie Kacheln für Folgeaufgaben verwenden, setzen Sie **Messung** auf **Dauer**, um die aufgewendete Zeit besser zu verfolgen.

## Fehlerbehebung

* **Ich sehe kein Bearbeitungssymbol auf der Kachel**
  * Ist das Dashboard im Layoutmodus?

* **Ich finde eine Option im Aufgabenmenü nicht**
  * Haben Sie auf die richtige Schaltfläche geklickt? (Dashboard vs. Kachel)
  * Ist das Dashboard im Layoutmodus?

* **Ich kann die Registerkarte Layout oder Felder nicht öffnen**
  * Möglicherweise fehlen Ihnen die erforderlichen funktionellen Rechte. Wenden Sie sich an Ihren Administrator.

* **Eine Selektion fehlt auf der Registerkarte Selektionen**
  * Siehe [Über Kacheln auf Basis von Selektionen](#selection-chart)

* **Ich habe versehentlich eine benutzerdefinierte Kachel gelöscht**
  * Diese Kacheln können nicht wiederhergestellt werden. Um das zu vermeiden, kopieren Sie sie vor dem Löschen in ein privates Dashboard (z. B. "Archivierte Kacheln").

## Verwandte Themen

* [Neues Dashboard hinzufügen][1]
* [Verwenden Sie Dashboards, um Ihre Vertriebspipeline zu verwalten][2]

<!-- Referenced links -->
[1]: create.md
[2]: show-sales-targets.md
[3]: index.md#charts
[4]: ../../search-options/learn/search-criteria.md
[5]: ../../search-options/learn/find-screen.md
[6]: ../../search-options/selection/learn/howto/display-as-charts.md
[7]: ../../localization/learn/translate-fields.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/dashboard/edit-dashboard-tiles-sidebar.png
[img2]: ../../../media/loc/en/dashboard/edit-tile-dataset.png
[img3]: ../../../media/loc/en/dashboard/edit-tile-layout.png
