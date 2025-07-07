---
uid: help-de-extra-field
title: Zusatzfeld
description: Zusatzfeld
keywords: Zusatzfeld
author: Bergfrid Dias
date: 06.11.2024
version: 10.3.7
content_type: concept
audience: user
audience_tooltip: SuperOffice CRM
language: de
---

# Zusatzfeld

[!include[License requirement](../../includes/req-dev-tools.md)]

Ein *Zusatzfeld* ist ein Feld, das Sie einer vorhandenen SuperOffice-Datenbanktabelle hinzufügen. Sie können die folgenden Entitäten erweitern:

* Kategorie
* Unternehmen
* Kontakt
* FAQ-Kategorie und Eintrag
* Nachricht
* Anfrage
* Benutzer
* Ihre [Zusatztabellen][6]

> [!NOTE]
> Zusatzfelder in Unternehmen oder Kontakt sind nicht dasselbe wie benutzerdefinierte Felder in diesen Entitäten!

Zusatzfelder werden in **Einstellungen und Verwaltung**, im **Tabellen**-Ansicht verwaltet.

## <a id="field-types"></a>Feldtypen

* Boolescher Wert (ja/nein)
* Integer
* Gleitkommazahl
* Kurzer text
* Langer text
* Datum
* Datum und Uhrzeit
* Uhrzeit
* Zeitraum
* Anlage
* Dynamischer Link

Darüber hinaus hat jede Entität einen Beziehungstyp. Zum Beispiel die *Beziehung zu Person*.

Im Gegensatz zu benutzerdefinierten Feldern werden Zusatzfelder als tatsächliche Felder zu den Datenbanktabellen hinzugefügt. Es gibt keine vordefinierten Slots, die Sie berücksichtigen müssen, und im Wesentlichen keine Einschränkungen.

### <a id="relation"></a>Beziehungen (Fremdschlüssel, FK)

Datenbanktabellen sind mit *Fremdschlüssel* (FK) verbunden. Diese sind Feldtypen, die auf *Beziehung* anfangen.

* Beziehung zu Person
* Beziehung zu Firma
* Beziehung zu Benutzer
* Beziehung zu Anfrage
* Beziehung zu Kategorie
* Beziehung zu Priorität
* Beziehung zu FAQ
* Beziehung zu Verkaufs
* Beziehung zu Projekt
* Beziehung zu Termin
* Beziehung zu Zusatztabelle

#### Im Pilot verfügbar ab Version 10.3.4

Wenn ein Zusatzfeld so eingestellt ist, dass es Ein-zu-viele-Beziehungen anzeigt, fügt das System automatisch eine Bereichsregisterkarte in den zugehörigen Standardentitäten hinzu. Dies ist nicht dasselbe wie der **Beziehungen**-Reiter auf den Firmen- und Personbildschirmen.

![Bereichsregisterkarte mit zusätzlicher Feldrelation -screenshot][img1]

#### Im Pilot verfügbar ab Version 10.3.7

Um die Details der Elemente in dieser Liste anzuzeigen, ohne jedes einzelne Objekt öffnen zu müssen:

1. Gehen Sie zum Seitenbereich und wählen Sie die **Vorschau**-Ansicht.
2. Klicken Sie auf ein Element im relationsbasierten Bereichsregisterkarte. Der Seitenbereich zeigt eine Vorschau des ausgewählten Objekts an. In der Vorschau können Sie:

    * Auf eine Standardentität klicken, um zu ihr zu wechseln.
    * Auf ein Zusatzobjekt klicken, um ein Dialogfeld zu öffnen, in dem Sie zusätzliche Informationen anzeigen oder bearbeiten können.

![Vorschau zusätzliche Feldrelation -screenshot][img2]

## Verwendung

Zusatzfelder können beispielsweise als Suchkriterien und Spalten im Verkauf in SuperOffice CRM verwendet werden.

## Verwandte Themen

* [Zusatzfelder auf der Detailregisterkarte anzeigen][1]
* [Zusatzfelder hinzufügen][2]

<!-- Referenced links -->
[1]: ../admin/show-extra-field-on-request-details.md
[2]: ../admin/create-extra-field.md
[6]: extra-table.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/automation/section-tab-for-relation.png
[img2]: ../../../media/loc/en/automation/preview-custom-object-from-side-panel.png
