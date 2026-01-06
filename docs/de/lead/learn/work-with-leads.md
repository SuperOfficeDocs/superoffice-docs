---
uid: help-de-work-with-leads
title: Mit Leads in SuperOffice arbeiten
description: Erfahren Sie, wie Sie Leads in SuperOffice CRM anzeigen, aktualisieren und nachverfolgen.
keywords: lead
author: digitaldiina
date: 01.13.2026
version: 11.8
content_type: howto
category: sale
topic: lead
license: salesessentials
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Mit Leads in SuperOffice arbeiten

Leads stehen für Personen, die Interesse gezeigt haben, aber noch nicht Teil eines aktiven Verkaufsprozesses sind. SuperOffice unterstützt Sie dabei, zu verfolgen, an welchem Punkt der Qualifizierung sich jeder Lead befindet und wann die richtige Folgeaktivität fällig ist.

Diese Seite zeigt, wie Sie Leadinformationen im Alltag anzeigen, aktualisieren und nutzen.

## Leadinformationen auf einer Person anzeigen

> [!NOTE]
> Das Feld **Lead-Status** wird nur angezeigt, wenn das Firma einer Kategorie in der Gruppe **Potenzieller Kunde** zugeordnet ist und **Lead-Status aktivieren** ausgewählt wurde.

1. Öffnen Sie eine Person.

1. Überprüfen Sie das Feld **Kategorie**, um zu sehen, ob die Person einer potenziellen Kundengruppe angehört.

1. Wenn der Lead-Status für die Firmenkategorie aktiviert ist, erscheint das Feld **Lead-Status** direkt unter dem Feld **Kategorie**.

1. Fahren Sie mit der Maus über den Statuswert, um die Beschreibung anzuzeigen.

    ![Lead-Status auf dem Person-Bildschirm, mit Tooltip zur Beschreibung des ausgewählten Status. -screenshot][img1]

## Lead-Status aktualisieren

1. Klicken Sie auf <i class="ph ph-pencil-simple" aria-label="Edit"></i> oben rechts auf der Personenkarte.

1. Wählen Sie das Dropdown **Lead-Status**.

1. Wählen Sie den Status aus, der den aktuellen Stand des Leads am besten widerspiegelt.

    * **Kontaktaufnahme:** Sie versuchen, den Lead zu erreichen.
    * **Qualifiziert:** Der Lead passt gut und zeigt Interesse.
    * **Disqualifiziert:** Der Lead ist nicht relevant.
    * **Erneut bearbeiten:** Zu einem späteren Zeitpunkt erneut nachfassen.

1. Klicken Sie **Speichern**, um Ihre Änderungen zu übernehmen.

## Leads im Bereichsregisterkarte „Personen“ anzeigen

1. Öffnen Sie ein Firma und öffnen Sie das [**Personen**-Bereichsregisterkarte][7].

1. Wählen Sie <i class="ph ph-gear" aria-label="Settings (cogwheel)"></i>, um die Spalten anzupassen.

1. Fügen Sie **Kategorie**, **Kategoriengruppe** und **Lead-Status** hinzu.

1. Optional können Sie die Liste [filtern oder gruppieren][8], um bestimmte Stadien hervorzuheben.

    ![Hinzufügen der Spalten Kategorie und Kategoriengruppe in der Personen-Registerkarte. -screenshot][img2]

## Selektionen erstellen

Sie können Kategorien und Lead-Status verwenden, um Personen und Firmen in SuperOffice CRM zu finden und zu segmentieren.

Im **Suchen**-Bildschirm können Sie Kriterien wie diese hinzufügen:

* **Person** > **Lead-Status** – Ist einer von / Ist keiner von.
* **Firma** > **Kategoriengruppe** – Ist eine von / Ist keine von.
    Verwenden Sie dies für Fragen wie "Liste alle meine potenziellen Kunden" oder "Liste alle meine Kunden" (anstelle vieler einzelner Kategorien).
* **Firma** > **Lead** oder **Person** > **Lead** basierend auf [UTM-Daten][5] (erfordert Marketing Premium).

![Filtern von Personen nach Lead-Status und Kategoriengruppe im Suchkriterienbereich. -screenshot][img3]

Sie können Ihre Suchergebnisse als **Selektion** speichern, um diese später für zielgerichtetes Marketing oder Berichte zu nutzen.

![Leadinformationen in Suchergebnissen, einschließlich Kategorie, Lead-Status und Quelle. -screenshot][img4]

Dynamische Selektionen von Firmen oder Personen können außerdem in der [Board-Ansicht][6] geöffnet werden, um den Fortschritt visuell darzustellen. Jede Spalte entspricht einem Lead-Status.

![Leads nach Status in der Board-Ansicht, gruppiert nach Stadien wie Offen, Kontaktaufnahme, Disqualifiziert, Erneut bearbeiten und Qualifiziert. -screenshot][img5]

## Tipps und Fehlerbehebung

* **Ich sehe das Feld Lead-Status nicht.**

    Der Lead-Status wird nur auf Personen angezeigt und nur, wenn die Firma zur Gruppe **Potenzieller Kunde** gehört.

* **Ich kann Lead oder Marketingqualifiziertes Lead nicht als Kategorie auswählen.**

    Diese Kategorien sind nur in neuen Datenbanken enthalten.

* **Das Lead-Status-Feld ist verschwunden, nachdem ich die Firmenkategorie geändert habe.**

    Der Lead-Status wird verborgen, wenn die Firma aus der Gruppe **Potenzieller Kunde** entfernt wird. Der Wert bleibt in der Datenbank erhalten, ist durchsuchbar, aber nicht bearbeitbar.

* **Unterschiedliche Personen derselben Firma zeigen unterschiedliche Lead-Status an.**

    Der Lead-Status wird auf Personenebene gespeichert.

* **Eine Person erhält immer Lead-Status = Offen, wenn sie in eine potenzielle Kundenkategorie verschoben wird.**

    Das ist erwartetes Verhalten. Neue Leads beginnen immer mit *Offen*.

* **Ich kann die Kategorie einer Person nicht ändern.**

    Personen erben die Kategorie von ihrer Firma. Um sie zu ändern, aktualisieren Sie die Kategorie auf dem Firmenbild.

## Verwandte Inhalte

* [Übersicht Lead-Management][1]
* [Dashboards zur Überwachung von Leads verwenden][4]
* [Personeninformationen in großer Menge aktualisieren][9]
* [Lead-Kategorisierung automatisieren][10]

<!-- Referenced links -->
[1]: index.md
[4]: ../../dashboard/learn/show-leads.md
[5]: ../../marketing/utm/learn/index.md
[6]: ../../search-options/selection/learn/board-view.md
[7]: ../../learn/section-tabs/contacts-tab.md
[8]: ../../learn/section-tabs/filter.md
[9]: ../../learn/basics/bulk-update.md
[10]: ../admin/category-automation.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/lead/contact-card-open-lead.png
[img2]: ../../../media/loc/en/lead/contact-section-tab-with-lead-info.png
[img3]: ../../../media/loc/en/lead/find-leads.png
[img4]: ../../../media/loc/en/lead/save-leads-as-selection.png
[img5]: ../../../media/loc/en/lead/filtered-lead-board.png
