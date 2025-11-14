---
uid: help-no-specialized-lists
title: Spesialiserte lister
description: Spesialiserte lister
keywords: spesialisert liste, listen Generelt - Relasjon, listen Generelt - Land
author: digitaldiina
date: 11.12.2025
version: 11.6
content_type: reference
audience: settings
audience_tooltip: Innstillinger og vedlikehold
index: true
redirect_from:
  - /no/admin/lists/learn/specialized-lists
  - /no/admin/lists/learn/adding-items-to-relation-list
  - /no/admin/lists/learn/add-items-to-country-list
  - /no/admin/lists/learn/country
language: no
---

# Spesialiserte lister

Noen lister i Innstillinger og vedlikehold bruker dialoger med felt som er tilpasset formålet med listen. Disse kalles *spesialiserte lister*.

Fremgangsmåten for å legge til eller redigere forekomster er stort sett den samme som for vanlige og brukerdefinerte lister. For generell veiledning, se [Legge til forekomster][21].

## Tilgjengelige spesialiserte lister

* [Firma – Kategori][20]
* [Dokument – Mal][1]
* [E-post – Mal][2]
* [Oppfølging – Type][3]
* [Generelt – Land](#country)
* [Generelt – Valuta][5]
* [Generelt – Relasjon](#relation)
* [Generelt – Ressurs][7]
* [GUI – Applikasjon][8]
* [GUI – Webpanel][9]
* [Domener for utsendelser][19]
* [Personvern – Hjemmel][10]
* [Personvern – Kilde][11]
* [Prosjekt – Status][12]
* [Prosjekt – Type, status][13]
* [Salg – Beløpsklasse][14]
* [Salg – Fase][15]
* [Salg – Rolle (Interessent)][16]
* [Salg – Type, Faser, Tilbud][17]
* [Oppgave-meny][18]

## Eksempler

Disse eksemplene beskriver felt som er spesifikke for hver liste. **Navn** er alltid *obligatorisk*. Det valgfrie feltet **Beskrivelse** brukes som forklaringstekst eller verktøytips.

### <a id="country"></a>Generelt – Land

Flere steder i SuperOffice CRM kan du velge ønsket land fra en valgliste. Listen over land (og tilhørende flagg) hentes fra ISO-standardlisten over land. Denne listen er forhåndsdefinert i **Lister**-bildet i Innstillinger og vedlikehold. Du kan eventuelt endre forhåndsdefinerte land eller legge til nye.

| Felt | Beskrivelse |
|---|---|
| **Toppdomene** | Landkode som brukes i nettadresser (for eksempel *NO* for Norge eller *DE* for Tyskland). |
| **Postprefiks** | Bokstaver som brukes foran postnummeret ved internasjonal post (for eksempel *N* for Norge). |
| **Visuelt adresseformat** | Adressens visning i Firma-bildet. |
| **Adresseformat for utskrift (lokalt / intl.)** | Valgfrie formater for utskrift av adresser, basert på postregler. |
| **Ledetekst for org.nr** | Tilpasset ledetekst for feltet VAT-nummer i Firma-bildet (for eksempel *Org.nr* i stedet for *VAT No*). |
| **Valuta** | Velg en valuta fra listen [Generelt – Valuta][5]. |
| **Dette landets prefiks** | Landskode for innkommende anrop (for eksempel *47* for Norge). |
| **Internasjonalt prefiks** | Prefiks som brukes ved utgående internasjonale samtaler (vanligvis *00*). |

> [!NOTE]
> Som regel er det tilstrekkelig å velge bare **visuelt adresseformat**.
> Alle tre adresseformat-feltene kan brukes ved behov. I noen land kan det være nyttig å variere formatene avhengig av om adressen vises, skrives ut lokalt eller internasjonalt.

### <a id="relation"></a>Generelt – Relasjon

[Detaljkortet **Relasjoner**][4] i Firma- og Person-bildet viser forbindelser (relasjoner) mellom personer eller selskaper. For eksempel informasjon om eierskapsstruktur eller ansatte som har byttet selskap.

| Felt | Beskrivelse |
|---|---|
| **Navn** | Aktiv form av relasjonen. Vises i kolonnen **har relasjon** på detaljkortet **Relasjoner** (for eksempel *eier*). |
| **Passiv form** | Passiv form av relasjonen. Også vist i kolonnen **har relasjon** (for eksempel *eid av*). |
| **Dette er en relasjon mellom** | Angir hvilke entitetstyper (firma og/eller person) som gjelder på aktiv og passiv side. Disse feltene tilsvarer feltene i dialogboksen **Relasjon**. |
| **Eksempel** | Viser hvordan relasjonen vises i brukergrensesnittet. |

> [!NOTE]
> Feltene **Navn** og **Passiv form** bør beskrive [relasjonen][6] tydelig med aktiv og passiv verbform.
> For eksempel: *eier / eid av*, *ansetter / ansatt av*, *leder / ledet av*.

## Relatert innhold

* [Legge til og fjerne firma- og personrelasjoner][1]

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
