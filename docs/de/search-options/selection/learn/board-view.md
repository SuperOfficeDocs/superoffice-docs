---
uid: help-de-selection-board-view
title: Board-Ansicht in Selektionen verwenden
description: Selektionen mit der Board-Ansicht visualisieren – mit Gruppierung, Filtern und Drag-and-Drop-Karten
keywords: Board-Ansicht, Selektionsansicht, Selektion, Verkaufsboard, Projektboard, Anfrageboard, Kanban, gruppieren nach, Filterleiste, Verkaufsdatum-Badge, Tage in Phase, Tage seit Registrierung
author: digitaldiina
date: 12.02.2025
version: 11.7
content_type: howto
license: salespremium, servicepremium, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Board-Ansicht in Selektionen verwenden <i class="ph ph-kanban" aria-hidden="true"></i>

Die Board-Ansicht zeigt Ihre [Selektion][2] in einem spaltenbasierten Layout mit Karten an. Sie können die Selektionsmitglieder (Datensätze auf dem Board) gruppieren und filtern sowie Karten per Drag-and-Drop zwischen Gruppen verschieben.

Die Funktionalität ist für alle unterstützten Selektionstypen gleich: Sie können Karten ziehen, Aufgabenmenüs öffnen und Board-Einstellungen anpassen. Die verfügbaren Gruppierungs- und Filterfelder unterscheiden sich je nachdem, ob Sie mit Firmen, Personen, Verkäufen, Projekten oder Anfragen arbeiten.

![Board-Ansicht mit Verkäufen nach Stufe gruppiert -screenshot][img2]

## Board-Ansicht öffnen

1. Öffnen Sie eine Selektion.

1. Klicken Sie oben rechts auf das Symbol für die **Board-Ansicht** (<i class="ph ph-kanban" aria-label="Kanban board"></i>).

    ![Symbol zum Umschalten in die Board-Ansicht oben rechts in einer Selektion][img1]

1. Wenn Ihre Selektion Firmen und Personen enthält, zeigt die Board‑Ansicht immer nur einen Entitätstyp gleichzeitig an. Zum Wechseln klicken Sie auf <i class="ph ph-gear-six" aria-label="Settings"></i> und wählen im Dropdown **Entität anzeigen** entweder *Firma* oder *Person*.

## Mit Karten arbeiten

* Klicken Sie auf den Kartentitel, um den vollständigen Datensatz zu öffnen (z. B. eine Verkaufskarte).

* Bewegen Sie die Maus über einen Namen oder ein Unternehmen, um Kontaktdaten anzuzeigen.

    ![Vorschau beim Hover mit Kontaktdaten auf einer Karte -screenshot][img3]

* Ziehen Sie Karten zwischen Spalten, um das Gruppierungsfeld zu aktualisieren (z. B. Stufe oder Besitzer).
  * Wenn Untergruppen aktiviert sind, können Sie Karten auch zwischen Zeilen innerhalb jeder Spalte verschieben.

* Klicken Sie auf eine Karte, um ihre Details in der [Seitenleiste][11] anzuzeigen. (Aktivieren Sie die Vorschau, indem Sie sie aus dem Dropdown-Menü oben in der Seitenleiste auswählen).

    ![Seitenleiste mit Projektdetails -screenshot][img12]

* Um eine Karte zu bearbeiten, bewegen Sie die Maus darüber und klicken Sie auf **Bearbeiten** (<i class="ph ph-pencil" aria-hidden="true"></i>). Dies öffnet denselben Bearbeitungsdialog wie an anderer Stelle in SuperOffice CRM – ohne die Board-Ansicht zu verlassen.

  ![Cursor zeigt auf die Schaltfläche Bearbeiten auf einer Verkaufskarte -screenshot][img4]

* Für weitere Optionen bewegen Sie die Maus über die Karte, um das **Aufgabe** Menü <i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i> anzuzeigen, klicken Sie darauf und wählen Sie eine Aktion aus.

  * **Verkäufe:** Bearbeiten, Folgeaufgabe erstellen, Als verkauft/verloren markieren, Löschen
  * **Projekte:** Bearbeiten, Folgeaufgabe erstellen, Dokument erstellen, Als abgeschlossen markieren, Löschen
  * **Anfragen:** Bearbeiten, Anfrage schließen, Löschen
  * **Firma:** Bearbeiten, Folgeaufgabe erstellen, Verkauf erstellen, Zur nächten Katerorie wechslen Löschen
  * **Person:** Bearbeiten, Folgeaufgabe erstellen, Verkauf erstellen, Löschen

  ![Geöffnetes Aufgabenmenü für einen Verkauf in der Board-Ansicht mit verfügbaren Optionen -screenshot][img5]

<!-- markdownlint-disable-next-line MD013 -->
## Board-Layout anpassen <i class="ph ph-gear-six" aria-hidden="true"></i> <i class="ph ph-sliders-horizontal" aria-hidden="true"></i>

### Gruppieren und untergruppieren

So wählen Sie aus, welche Spalten angezeigt werden:

1. Klicken Sie auf das Symbol **Einstellungen** (<i class="ph ph-gear-six" aria-hidden="true"></i>).

1. Wählen Sie **Gruppieren nach**.

    ![Einstellungsbereich der Board-Ansicht für Verkaufsselektionen mit Gruppierungsoptionen -screenshot][img6]

1. Wählen Sie ein Feld, um das Spaltenlayout festzulegen.

    ![Gruppieren-nach-Menü mit verfügbaren Verkaufsfeldern wie Stufe und Besitzer -screenshot][img7]

1. Klicken Sie auf den Zurück-Pfeil (<i class="ph ph-caret-left" aria-hidden="true"></i>), um zur Einstellungsübersicht zurückzukehren.

1. Optional: Wählen Sie einen Wert für **Untergruppen nach**, um Karten in getrennte Zeilen innerhalb jeder Spalte zu organisieren.

1. Optional: Wählen Sie **Einstellungen nur für diese Selektion speichern**, um die Änderungen nur für dieses Board zu übernehmen.

1. Klicken Sie auf **Fertig**, um die Einstellungen zu übernehmen.

Beispiele für Gruppierungsfelder:

* **Verkäufe:** Stufe, Verkaufstyp, Besitzer
* **Projekte:** Status, Verantwortlicher, Typ
* **Anfragen:** Status, Anfragetyp, Priorität, Besitzer
* **Firma:** Kategorie, Verantwortlich
* **Person:** Kategorie, Verantwortlich, Lead Status

### Karten in Spalten sortieren

Verwenden Sie das Einstellungsmenü (<i class="ph ph-gear-six" aria-hidden="true"></i>), um **Sortieren nach** und **Sortierreihenfolge** festzulegen, z. B. nach Verkaufsdatum.

### Filter festlegen

1. Klicken Sie auf <i class="ph ph-sliders-horizontal" aria-label="Toggle filter toolbar"></i>, um die Filterleiste anzuzeigen.

    ![Filterleiste in einer Verkaufsselektion in der Board-Ansicht -screenshot][img9]

1. So legen Sie fest, welche Filter verfügbar sind:

    1. Klicken Sie auf <i class="ph ph-gear-six" aria-hidden="true"></i>, um die Einstellungen zu öffnen.
    1. Wählen Sie **Filterleiste** und aktivieren Sie Filter über die Kontrollkästchen.
    1. Klicken Sie auf den Zurück-Pfeil (<i class="ph ph-caret-left" aria-hidden="true"></i>), kehren Sie zur Einstellungsübersicht zurück und klicken Sie auf **Fertig**.

    ![Filtereinstellungen mit verfügbaren Verkaufsfeldern wie Stufe und Besitzer -screenshot][img8]

1. In der Leiste: Erweitern Sie einen Filter (z. B. **Besitzer**), um eine Liste anzuzeigen.

    * Aktivieren oder deaktivieren Sie Elemente, um sie ein- oder auszuschließen.
    * Wählen Sie **Löschen** unten in einem Dropdown-Menü, um diesen Filter zurückzusetzen.
    * Klicken Sie auf das **X** ganz rechts in der Filterleiste, um **alle** Filter gleichzeitig zurückzusetzen.

    ![Filterleiste, Verkaufstyp erweitert -screenshot][img10]

Beispiele für Filter:

* **Verkauf:** Verkaufsart, Eigentümer, Phase, Nächste Aktivität, Verkaufsdatum
* **Projekte:** Typ, Verantwortlich, Status, Nächster Meilenstein, Enddatum
* **Anfragen:** Anfragekategorie, Eigentümer, Status, Erstellt, Frist, Priorität
* **Firma:** Verantwortlich, Erfasstesdatum Nächste Aktivität, Kategorie, Land
* **Person:** Verantwortlich, Eigentümergruppe Erfasstesdatum Nächste Aktivität, Lead Status, Kategorie, Land

### Zusammenfassen (nur Verkäufe)

Sie können Summen für numerische Felder in der Board-Ansicht für Verkäufe anzeigen.

1. Klicken Sie auf <i class="ph ph-gear-six" aria-hidden="true"></i>, um das Einstellungsmenü zu öffnen.
2. Wählen Sie **Zusammenfassen nach**.
3. Wählen Sie ein numerisches Feld, z. B. **Betrag** oder **Gewichteter Betrag**.

Der Gesamtwert wird **neben jedem Spaltennamen** angezeigt und hilft Ihnen, die Wertverteilung über Stufen, Besitzer oder andere Gruppierungsfelder hinweg zu verfolgen.

![Board-Ansicht für Verkäufe mit zusammengefassten Beträgen neben den Spaltennamen -screenshot][img11]

### Verkaufsdatum-Badge (nur Verkäufe)

Sie können steuern, was das **graue Badge** auf jeder Verkaufskarte in der Board-Ansicht anzeigt. Dies hilft Ihnen, das Alter auf einen Blick zu verstehen – entweder wie lange ein Verkauf geöffnet war oder wie lange er sich in seiner aktuellen Phase befindet.

1. Klicken Sie auf <i class="ph ph-gear-six" aria-hidden="true"></i>, um das **Einstellungen**-Panel zu öffnen.

    ![Einstellungspanel für Verkaufs-Board mit Optionen für Gruppierung, Sortierung, Zusammenfassung, Filter, Verkaufsdatum-Badge und geschlossene Verkäufe ausblenden. -screenshot][img13]

1. Wählen Sie **Verkaufsdatum-Badge**.

1. Wählen Sie eine der folgenden Optionen:

    * **Tage in Phase:** Zeigt an, wie viele Tage der Verkauf in seiner aktuellen Phase geblieben ist.
    * **Tage seit Registrierung:** Zeigt an, wie lange her die Erstellung des Verkaufs ist.

    ![Verkaufsdatum-Badge-Einstellungsdialog mit den Optionen Tage in Phase und Tage seit Registrierung. -screenshot][img14]

Die ausgewählte Metrik erscheint als **graues Badge** auf jedem Verkauf in der Board-Ansicht. Ein **rotes Badge** wird weiterhin verwendet, um überfällige Verkäufe zu markieren.

## Anwendungsfälle

Die Board-Ansicht unterstützt verschiedene Rollen und Arbeitsweisen. Hier einige Beispiele für Vertriebsmitarbeitende, Projektmitglieder, Supportmitarbeiter und Managers:

### Vertriebsmitarbeitende

* **Visualisieren Sie offene Verkäufe** und verfolgen Sie, wo sich jede Gelegenheit im Prozess befindet.
* **Ziehen Sie eine Karte in eine andere Spalte**, um die VerkaufsStufe zu ändern.
* **Filtern Sie nach Verkaufsdatum**, um sich auf aktuelle Aufgaben zu konzentrieren.
* **Öffnen Sie das Aufgabenmenü**, um eine Folgeaufgabe zu erstellen oder einen Verkauf als verkauft/verloren zu markieren.
* **Bearbeiten Sie eine Karte schnell**, um Details wie eine neue Kontaktperson zu aktualisieren.

### Vertriebsleitende

* **Verschaffen Sie sich einen Überblick über die gesamte Pipeline** und sehen Sie die Verteilung der Verkäufe über die Stufen hinweg.
* **Fassen Sie nach Betrag zusammen**, um Prognosen zu unterstützen.
* **Filtern Sie nach Verkaufstyp**, um sich auf Neugeschäft oder bestimmte Kampagnen zu konzentrieren.
* **Gruppieren Sie nach Besitzer**, um die Auslastung pro Vertriebsperson zu prüfen und durch Drag-and-Drop auszugleichen.
* **Verwenden Sie Stufe als Gruppe und Verkaufstyp als Untergruppe**, um eine strategische Übersicht nach Kategorie und Stufe zu erhalten.

### Projektmitglieder

* **Visualisieren Sie Ihre aktiven Projekte** und verfolgen Sie den Fortschritt anhand verschiedener Stati.
* **Ziehen Sie eine Karte in eine andere Spalte**, um den Projektstatus zu aktualisieren.
* **Filtern Sie nach nächstem Meilenstein oder Enddatum**, um sich auf dringende Aufgaben zu konzentrieren.
* **Gruppieren Sie nach Verantwortlichem**, um den Projekteigentum im Team zu sehen.
* **Öffnen Sie das Aufgabenmenü**, um eine Folgeaufgabe oder ein Dokument zu erstellen oder das Projekt als abgeschlossen zu markieren.

### Projektmanager

* **Verschaffen Sie sich einen vollständigen Überblick über alle Projekte**, um den Status zu überwachen und Verzögerungen zu erkennen.
* **Fassen Sie nach Typ zusammen**, um Kundenprojekte, interne Initiativen oder Entwicklungsarbeiten zu vergleichen.
* **Filtern Sie nach Verantwortlichem**, um die Arbeitslast im Team auszugleichen.
* **Gruppieren Sie nach Status**, um den Fortschritt durch die Phasen zu sehen, oder nach Typ, um mit Geschäftsprioritäten in Einklang zu bleiben.

### Supportmitarbeiter

* **Visualisieren Sie Ihre zugewiesenen Anfragen** und verfolgen Sie sie über Stati wie neu, in Bearbeitung und geschlossen.
* **Ziehen Sie eine Karte in eine andere Spalte**, um den Anfrage-Status zu aktualisieren.
* **Filtern Sie nach Frist oder Priorität**, um dringende Fälle zuerst zu bearbeiten.
* **Gruppieren Sie nach Status**, um den Fortschritt zu verfolgen, oder nach Anfrageart, um sich auf bestimmte Kategorien zu konzentrieren.
* **Öffnen Sie das Aufgabenmenü**, um die Anfrage zu schließen.

### Supportmanager

* **Verschaffen Sie sich einen vollständigen Überblick über eingehende Anfragen**, und sehen Sie die Verteilung nach Status.
* **Fassen Sie nach Priorität zusammen**, um sicherzustellen, dass wichtige Anfragen schnell bearbeitet werden.
* **Filtern Sie nach Kategorie oder Erstellungsdatum**, um Trends bei Kundenproblemen zu analysieren.
* **Gruppieren Sie nach Besitzer**, um die Arbeitslast der Agenten zu überwachen und Anfragen bei Bedarf neu zuzuweisen.
* **Verwenden Sie Status als Gruppe und Priorität als Untergruppe**, um eine strukturierte Übersicht für Analyse und Reporting zu erhalten.

Nutzen Sie Gruppierung kreativ, um Daten effizient zu organisieren und zu nutzen.

## Fehlerbehebung und Tipps

* **Neue Verkäufe fehlen:** Klicken Sie auf <i class="ph ph-arrow-clockwise" aria-label="Refresh icon"></i>, um die Board-Ansicht neu zu laden und aktuelle Daten anzuzeigen.

* **Filterleiste ist nicht sichtbar:** Schalten Sie sie mit dem Symbol <i class="ph ph-sliders-horizontal" aria-hidden="true"></i> ein oder aus.

* **Eine Spalte ist leer:** Möglicherweise wurde deren Inhalt herausgefiltert. Prüfen Sie die aktiven Filter in der Leiste.

* **Ein Filterfeld fehlt:** Öffnen Sie **Einstellungen** (<i class="ph ph-gear-six" aria-hidden="true"></i>) > **Filterleiste** und aktivieren Sie das gewünschte Feld.

* **Sie möchten die Selektion selbst bearbeiten (nicht ein Mitglied)?** Klicken Sie auf <i class="ph ph-subtract-square" aria-label="Selection icon"></i>, um zur Selektionsansicht zurückzukehren. Bearbeiten- und Aufgaben-Schaltflächen für die Selektion sind in der Board-Ansicht nicht verfügbar.

* **Board nach Namen durchsuchen:** Verwenden Sie das Feld **Nach Titel filtern** oben, um Karten nach Namen einzugrenzen.

* **Layout pro Anwendungsfall speichern:** Wählen Sie **Einstellungen nur für diese Selektion speichern**, wenn Sie ein bestimmtes Board-Layout, Filter oder Gruppierung nur für eine Selektion beibehalten möchten.

## Verwandte Inhalte

* [Eine Selektion erstellen][1]
* [Einen Verkauf erstellen / Felder in der Verkaufskarte][12]
* [VerkaufsStufen konfigurieren][13]
* [Eine Anfrage erstellen / Anfrageeigenschaften][14]
* [Anfragestatus erstellen][15]
* [Anfragekategorie erstellen][16]
* [Ein Projekt erstellen / Felder in der Projektkarte][17]
* [Projektstatus konfigurieren][18]
* [Projekttypen konfigurieren][19]

<!-- Referenzierte Links -->
[1]: create.md
[2]: index.md
[11]: ../../../learn/getting-started/main-screen/side-panel.md
[12]: ../../../sale/learn/create.md
[13]: ../../../sale/admin/sale-stage.md
[14]: ../../../request/learn/create.md
[15]: ../../../request/admin/status/create.md
[16]: ../../../request/admin/category/create.md
[17]: ../../../project/learn/create.md
[18]: ../../../project/admin/project-status.md
[19]: ../../../project/admin/project-type.md

<!-- Referenzierte Bilder -->
[img1]: ../../../../media/loc/en/search-options/board-view-toggle.png
[img2]: ../../../../media/loc/en/search-options/board-view.png
[img3]: ../../../../media/loc/en/search-options/board-view-preview-contact-on-hover.png
[img4]: ../../../../media/loc/en/search-options/board-view-card-edit-icon.png
[img5]: ../../../../media/loc/en/search-options/board-view-card-task-menu.png
[img6]: ../../../../media/loc/en/search-options/board-view-settings.png
[img7]: ../../../../media/loc/en/search-options/board-view-settings-group-by.png
[img8]: ../../../../media/loc/en/search-options/board-view-settings-filter.png
[img9]: ../../../../media/loc/en/search-options/board-view-filter-toolbar.png
[img10]: ../../../../media/loc/en/search-options/board-view-filter-on-sale-type.png
[img11]: ../../../../media/loc/en/search-options/board-view-summarized-sale-amount-per-column.png
[img12]: ../../../../media/loc/en/search-options/selection-board-view-project-preview.png
[img13]: ../../../../media/loc/en/search-options/board-view-settings-for-sales.png
[img14]: ../../../../media/loc/en/search-options/sale-date-badge-setting.png
