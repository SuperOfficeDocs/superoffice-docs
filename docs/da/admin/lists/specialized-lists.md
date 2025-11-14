---
uid: help-da-specialized-lists
title: Specialiserede lister
description: Specialiserede lister
keywords: specialiseret liste, Generelt – Relation, Generelt – Land
author: digitaldiina
date: 11.12.2025
version: 11.6
content_type: reference
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from:
  - /da/admin/lists/learn/specialized-lists
  - /da/admin/lists/learn/adding-items-to-relation-list
  - /da/admin/lists/learn/add-items-to-country-list
  - /da/admin/lists/learn/country
language: da
---

# Specialiserede lister

Nogle lister i Indstillinger og vedligeholdelse bruger dialoger med felter, der er tilpasset formålet med listen. Disse kaldes *specialiserede lister*.

Fremgangsmåden for at tilføje eller redigere forekomster er stort set den samme som for almindelige og brugerdefinerede lister. Se [Tilføj forekomster][21] for generelle instruktioner.

## Tilgængelige specialiserede lister

* [Firma – Kategori][20]
* [Dokument – Skabelon][1]
* [E-mail – Skabelon][2]
* [Opfølgning – Type][3]
* [Generelt – Land](#country)
* [Generelt – Valuta][5]
* [Generelt – Relation](#relation)
* [Generelt – Ressource][7]
* [GUI – Applikation][8]
* [GUI – Webpanel][9]
* [Udsendelsesdomæner][19]
* [Personbeskyttelse – Retsgrundlag][10]
* [Personbeskyttelse – Kilde][11]
* [Projekt – Status][12]
* [Projekt – Type, status][13]
* [Salg – Beløbsklasse][14]
* [Salg – Fase][15]
* [Salg – Rolle (Interessent)][16]
* [Salg – Type, Faser, Tilbud][17]
* [Opgavemenuen][18]

## Eksempler

Disse eksempler beskriver felter, der er specifikke for hver liste. **Navn** er altid *obligatorisk*. Det valgfrie felt **Beskrivelse** bruges som forklaringstekst eller værktøjstip.

### <a id="country"></a>Generelt – Land-liste

Flere steder i SuperOffice CRM kan du vælge et ønsket land fra en valgliste. Listen over lande (og deres flag) hentes fra ISO-standardlisten. Landene er foruddefineret i skærmbilledet **Lister** i Indstillinger og vedligeholdelse. Du kan redigere disse eller tilføje nye.

| Felt | Beskrivelse |
|---|---|
| **Domænenavn** | To-bogstavers landekode, der bruges i internetadresser (for eksempel *NO* for Norge eller *DE* for Tyskland). |
| **Postpræfiks** | Bogstaver, der bruges foran postnummeret ved international post (for eksempel *N* for Norge). |
| **Visuelt adresseformat** | Formatet som vises i Firma-skærmen. |
| **Udskrevet adresseformat (lokalt / intl)** | Valgfrie formater til udskrevne breve, afhængigt af postregler. |
| **Ledetekst for firmanr.** | Tilpasset etiket til SE-nr.-feltet i Firma-skærmen (for eksempel *Org. nr.* i stedet for *SE-nr.*). |
| **Valuta** | Vælg en valuta fra listen [Generelt – Valuta][5]. |
| **Dette lands præfiks** | Landekode for opkald til landet (for eksempel *47* for Norge). |
| **Internationalt præfiks** | Præfiks til internationale opkald (typisk *00*). |

> [!NOTE]
> Som hovedregel er det tilstrækkeligt kun at vælge **visuelt adresseformat**.
> Alle tre adressefelter kan anvendes efter behov – især for lande med forskellige krav til visning og udskrivning.

### <a id="relation"></a>Generelt – Relation-liste

[Detaljekortet **Relationer**][4] i Firma- og Person-visningen viser relationer mellem personer eller virksomheder. For eksempel ejerstruktur eller tidligere ansættelser.

| Felt | Beskrivelse |
|---|---|
| **Navn** | Aktiv form af relationen. Vises i kolonnen **har relationer** på detaljekortet **Relationer** (for eksempel *ejer*). |
| **Passiv form** | Passiv form af relationen. Vises også i kolonnen **har relationer** (for eksempel *ejes af*). |
| **Dette er en relation mellem** | Angiver hvilke entitetstyper (firma og/eller person), der gælder på aktiv og passiv side. Felterne svarer til dem i dialogboksen **Relation**. |
| **Eksempel** | Viser hvordan relationen fremstår i praksis. |

> [!NOTE]
> Felterne **Navn** og **Passiv form** skal beskrive [relationen][6] klart med aktiv og passiv verbalform.
> Eksempler: *ejer / ejes af*, *ansætter / ansættes af*, *leder / ledes af*.

## Relateret indhold

* [Tilføj og slet firma- og personrelationer][1]

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
