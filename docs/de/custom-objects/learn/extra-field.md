---
uid: help-de-extra-field
title: Zusatzfeld
description: Zusatzfeld
keywords: ekstrafelt, tilpasset felt, Service
author: Bergfrid Dias
so.date: 01.30.2024
so.version: 10
so.topic: concept
so.audience: user
so.audience.tooltip: SuperOffice CRM
language: de
---

# Zusatzfeld

[!include[License requirement](../../../../common/includes/req-dev-tools.md)]

Ein *Zusatzfeld* ist ein benutzerdefiniertes Feld, das Sie einer vorhandenen SuperOffice-Datenbanktabelle hinzufügen. Sie können die folgenden Entitäten erweitern:

* Kategorie
* Unternehmen
* Kontakt
* FAQ-Kategorie und Eintrag
* Nachricht
* Anfrage
* Benutzer
* Ihre [benutzerdefinierten Tabellen][6]

> [!NOTE]
> Zusatzfelder in Unternehmen oder Kontakt sind nicht dasselbe wie benutzerdefinierte Felder in diesen Entitäten!

Zusatzfelder werden in **Einstellungen und Wartung**, im **Tabellen**-Bildschirm verwaltet.

## <a id="field-types" />Feldtypen

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

### Beziehungen (Fremdschlüssel, FK)

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

## Verwendung

Zusatzfelder können beispielsweise als Suchkriterien und Spalten im Verkauf in SuperOffice CRM verwendet werden.

## Verwandter Inhalt

* [Zusatzfelder auf der Detailregisterkarte anzeigen][1]
* [Zusatzfelder hinzufügen][2]

<!-- Referenced links -->
[1]: ../admin/show-extra-field-on-request-details.md
[2]: ../admin/create-extra-field.md
[6]: extra-table.md
