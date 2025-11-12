---
uid: help-nl-specialized-lists
title: Gespecialiseerde lijsten
description: Gespecialiseerde lijsten
keywords: gespecialiseerde lijst, Algemeen - Relatie, Algemeen - Land
author: digitaldiina
date: 11.12.2025
version: 11.6
content_type: reference
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from:
  - /nl/admin/lists/learn/specialized-lists
  - /nl/admin/lists/learn/adding-items-to-relation-list
  - /nl/admin/lists/learn/add-items-to-country-list
  - /nl/admin/lists/learn/country
language: nl
---

# Gespecialiseerde lijsten

Sommige lijsten in **Instellingen en onderhoud** gebruiken dialoogvensters met velden die specifiek zijn afgestemd op het doel van de lijst. Deze worden *gespecialiseerde lijsten* genoemd.

De stappen voor het toevoegen of bewerken van items zijn grotendeels hetzelfde als voor standaard- en aangepaste lijsten. Zie [Items toevoegen][21] voor algemene instructies.

## Beschikbare gespecialiseerde lijsten

* [Bedrijf - Categorie][20]
* [Document - Sjabloon][1]
* [E-mail - Sjabloon][2]
* [Vervolgactiviteit - Type][3]
* [Algemeen - Land](#country)
* [Algemeen - Valuta][5]
* [Algemeen - Relatie](#relation)
* [Algemeen - Bron][7]
* [GUI - Toepassing][8]
* [GUI - Webpaneel][9]
* [Mailing-domeinen][19]
* [Privacy - Rechtsgrondslag][10]
* [Privacy - Bron][11]
* [Project - Status][12]
* [Project - Type, status][13]
* [Verkoop - Bedragklasse][14]
* [Verkoop - Fase][15]
* [Verkoop - Rol belanghebbende][16]
* [Verkoop - Type, Fasen, Offerte][17]
* [Taakmenu][18]

## Voorbeelden

In deze voorbeelden worden de velden beschreven die specifiek zijn voor elk lijsttype. **Naam** is altijd *verplicht*. Het optionele veld **Beschrijving** kan worden gebruikt als tooltip of toelichting.

### <a id="country"></a>Algemeen – Landenlijst

Op meerdere plaatsen in SuperOffice CRM kunt u een land selecteren uit een lijst. De landenlijst (met vlaggen) is gebaseerd op de ISO-standaard. U kunt de vooraf gedefinieerde landen bewerken of nieuwe toevoegen in het scherm **Lijsten**.

| Veld | Beschrijving |
|---|---|
| **Hoogste domeinnaam** | Landcode die wordt gebruikt in internetadressen (bijvoorbeeld *NL* voor Nederland, *DE* voor Duitsland). |
| **Postvoorvoegsel** | Letters die voor het postcodeveld worden geplaatst bij internationale adressen (bijvoorbeeld *N* voor Noorwegen). |
| **Visuele notatie adressen** | Formaat dat wordt weergegeven in het scherm Bedrijf. |
| **Notatie afgedrukte adressen (lokaal / internat.)** | Specifieke notatie voor lokale of internationale post. |
| **Veldlabel organisatienummer** | Aangepaste labeltekst voor het btw- of registratienummer (bijvoorbeeld *BTW-nr.*). |
| **Valuta** | Selecteer een valuta uit de lijst [Algemeen – Valuta][5]. |
| **Nummer van dit land** | Landnummer voor inkomende gesprekken (bijvoorbeeld *31* voor Nederland). |
| **Internat. toegangsnr.** | Nummer voor uitgaande internationale gesprekken (meestal *00*). |

> [!NOTE]
> Meestal volstaat het om alleen het **visuele adresformaat** te selecteren.
> Bij sommige landen kan het handig zijn om aparte formaten te gebruiken voor weergave, lokale en internationale post.

### <a id="relation"></a>Algemeen – Relatielijst

Het [tabblad **Relaties**][4] in het scherm Bedrijf of Persoon toont de bestaande verbindingen (relaties) tussen personen of bedrijven, zoals eigendomsstructuren of werkverleden.

| Veld | Beschrijving |
|---|---|
| **Naam** | Actieve vorm van het werkwoord. Wordt weergegeven in de kolom **heeft relaties** (bijvoorbeeld *is eigenaar van*). |
| **Passieve vorm** | Passieve vorm van het werkwoord (bijvoorbeeld *is eigendom van*). |
| **Dit is een relatie tussen** | Geeft aan of het om een bedrijf en/of persoon gaat aan actieve of passieve zijde. Komt overeen met het dialoogvenster **Relatie**. |
| **Voorbeeld** | Toont hoe de relatie eruitziet in de gebruikersinterface. |

> [!NOTE]
> Gebruik duidelijke werkwoorden in zowel actieve als passieve vorm om de [relatie][6] te beschrijven.
> Bijvoorbeeld: *beheert / wordt beheerd door*, *leidt / wordt geleid door*, *is eigenaar van / is eigendom van*.

Het sectietabblad **Relaties** in het scherm Bedrijf geeft alle bestaande verbindingen (relaties) weer tussen personen. Bijvoorbeeld: informatie over de eigendomsstructuur of over personen die voor verschillende bedrijven hebben gewerkt.

## Gerelateerde inhoud

* [Relaties tussen bedrijven en personen toevoegen en verwijderen][1]

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
[20]: ../../lead/admin/add-company-category.md
[21]: add-items.md
