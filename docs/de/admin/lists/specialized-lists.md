---
uid: help-de-specialized-lists
title: Speziallisten
description: Speziallisten
keywords: spezialliste, Allgemein - Beziehung, Allgemein - Land
author: digitaldiina
date: 10.29.2025
version: 10.5
content_type: reference
audience: settings
audience_tooltip: Einstellungen und Verwaltung
index: true
redirect_from:
  - /de/admin/lists/learn/specialized-lists
  - /de/admin/lists/learn/adding-items-to-relation-list
  - /de/admin/lists/learn/add-items-to-country-list
  - /de/admin/lists/learn/country
language: de
---

# Speziallisten

Einige Listen in **Einstellungen und Verwaltung** verwenden Dialoge mit speziell angepassten Feldern. Diese werden als *Speziallisten* bezeichnet.

Die Schritte zum Hinzufügen oder Bearbeiten von Objekten sind weitgehend identisch mit normalen und benutzerdefinierten Listen. Eine allgemeine Anleitung finden Sie unter [Objekte hinzufügen][21].

## Verfügbare Speziallisten

* [Dokument - Vorlage][1]
* [E-Mail - Vorlage][2]
* [Folgeaufgabe - Typ][3]
* [Allgemein - Land](#country)
* [Allgemein - Währung][5]
* [Allgemein - Beziehung](#relation)
* [Allgemein - Ressource][7]
* [GUI - Anwendung][8]
* [GUI - Web-Bildschirm][9]
* [Kampagnen-Domänen][19]
* [Datenschutz - Rechtsgrundlage][10]
* [Datenschutz - Nachweis][11]
* [Projekt - Status][12]
* [Projekt - Typ, Stufen][13]
* [Verkauf - Betragsklasse][14]
* [Verkauf - Stufe][15]
* [Verkauf - Beteiligtenrolle][16]
* [Verkauf - Typ, Stufen, Angebot][17]
* [Aufgabenmenü][18]

## Beispiele

Diese Beispiele beschreiben Felder, die für jede Liste spezifisch sind. **Name** ist immer *obligatorisch*. Das optionale Feld **Beschreibung** dient als Erläuterung oder Tooltip.

### <a id="country"></a>Allgemein - Land‑Liste

An mehreren Stellen in SuperOffice CRM können Sie ein Land aus einer Liste auswählen. Die Länder (und Flaggen) basieren auf der ISO‑Standardliste und sind in der Ansicht **Listen** vordefiniert. Sie können sie bearbeiten oder neue hinzufügen.

| Feld | Beschreibung |
|---|---|
| **Domäne der obersten Ebene** | Zwei‑Buchstaben‑Code für Internetadressen (z. B. *NO* für Norwegen oder *DE* für Deutschland). |
| **Präfix** | Buchstaben, die vor der Postleitzahl bei internationaler Post verwendet werden (z. B. *D* für Deutschland). |
| **Visuelles Adressformat** | Format für die Anzeige im Firmenbild. |
| **Adressformat für Ausdruck (lokal / intl.)** | Optionale Formate je nach Versand im In‑ oder Ausland. |
| **Feldbezeichnung Organisationsnummer** | Benutzerdefinierte Beschriftung für die Unternehmensnummer im Firmenbild (z. B. *Handelsregister‑Nr.* statt *USt‑IdNr.*). |
| **Währung** | Auswahl aus der Liste [Allgemein - Währung][5]. |
| **Vorwahl dieses Landes** | Ländervorwahl für eingehende Anrufe (z. B. *49* für Deutschland). |
| **Internationale Vorwahl** | Vorwahl für internationale ausgehende Anrufe (i. d. R. *00*). |

> [!NOTE]
> In der Regel genügt es, nur das **visuelle Adressformat** festzulegen.
> Bei manchen Ländern ist für lokale und internationale Briefe eine unterschiedliche Druckdarstellung sinnvoll.

### <a id="relation"></a>Allgemein - Beziehung‑Liste

Die [Detailkarte **Beziehungen**][4] im Firmen‑ oder Persontbild zeigt bestehende Verbindungen zwischen Personen oder Firmen, z. B. Eigentümerstrukturen oder frühere Beschäftigungen.

| Feld | Beschreibung |
|---|---|
| **Name** | Aktive Verbform der Beziehung. Wird in der Spalte **hat Beziehungen** im Firmen‑ oder Persontbild angezeigt (z. B. *besitzt*). |
| **Passive Form** | Passive Verbform der Beziehung (z. B. *im Besitz von*). |
| **Dies ist eine Beziehung zwischen** | Legt fest, ob Aktiv‑ und Passivseite eine Firma und/oder eine Person sind. Entspricht der **Beziehung**‑Dialogbox. |
| **Beispiel** | Zeigt eine Vorschau, wie die Beziehung im UI dargestellt wird. |

> [!NOTE]
> Verwenden Sie aktive und passive Verben für eine klare Beschreibung der [Beziehung][6].
> Beispiele: *besitzt / im Besitz von*, *stellt ein / angestellt von*, *leitet / geleitet von*.

## Zugehörige Inhalte

* [Firmen‑ und Kontaktbeziehungen hinzufügen und löschen][1]

<!-- Referenced links -->
[1]: ../../document/templates/learn/index.md
[2]: ../../email/admin/add-email-template.md
[3]: ../../diary/admin/add-follow-up-type.md
[5]: ../../sale/admin/add-currency.md
[4]: ../../learn/section-tabs/relations-tab.md
[6]: ../../learn/basics/relations.md
[7]: ../../diary/admin/add-resource.md
[8]: ../../customization/admin/other-applications.md
[9]: ../../customization/web-panels/admin/add-web-panel.md
[10]: ../../security/privacy/admin/add-legal-base.md
[11]: ../../security/privacy/admin/add-source.md
[12]: ../../project/admin/project-status.md
[13]: ../../project/admin/project-type.md
[14]: ../../saint/admin/sale-amount-class.md
[15]: ../../sale/admin/sale-stage.md
[16]: ../../sale/learn/stakeholders/index.md#role
[17]: ../../sale/admin/sale-type.md
[18]: ../../customization/admin/add-items-to-task-menu.md
[19]: ../../marketing/mailing/admin/add-domain.md
[21]: adding-items.md
