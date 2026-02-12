---
uid: help-no-section-tab-requests
title: Saksfanen
description: Lær hvordan du kan se, legge til og administrere Service-saker i SuperOffice CRM, slik at du effektivt kan spore kundeinteraksjoner på tvers av firmaer og personer.
keywords: Saksfanen, Saker-fanen, detaljkortet Saker, detaljkort, saksarkiv, sak, henvendelse, forespørsel, forespørsler
author: digitaldiina
date: 02.17.2026
version: 11.10
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: no
redirect_from:
  - /no/company/learn/screen/requests-tab
  - /no/contact/learn/screen/requests-tab
---

# Saksfanen

Detaljkortet **Saker** i SuperOffice CRM lar brukere vise og administrere [Service-saker][1] tilknyttet spesifikke enheter, for eksempel firmaer og personer. Denne veiledningen gir en samlet oversikt over hvordan du får tilgang til og håndterer saker, noe som forbedrer muligheten til å håndtere kundeinteraksjoner effektivt.

![Detaljkortet Saker i Firmaskjerman -screenshot][img1]

## Tilgjengelighet av Saksfanen

Detaljkortet **Saker** er tilgjengelig for:

| Enhet | Beskrivelse av detaljkortet |
|---|---|
| [Firma][9] | Viser alle saker tilknyttet firmaet, med muligheter for å se og administrere detaljene. |
| [Person][10] | Viser saker tilknyttet personen, noe som gir mulighet for mer personlig støtte. |

## <a id="columns"></a>Kolonneoversikt for Saksfanen

Detaljkortet **Saker** inneholder følgende kolonner for å gi nøkkelinformasjon om hver sak:

| Kolonne | Beskrivelse |
|---|---|
| Saks-ID | Unik identifikator for saken. |
| Tittel | Tittelen eller emnet for saken. |
| Opprettet | Datoen da saken ble logget. |
| Sist endret | Datoen da saken sist ble oppdatert. |
| Lukket ved | Datoen da saken ble lukket. |
| Eier | Personen som er ansvarlig for å håndtere saken. |
| Kategori | Kategori for saken. |
| Fullt navn | Fullt navn på personen som er tilknyttet saken. |
| Firma | Firmaet som er tilknyttet saken. |
| Status | Gjeldende status for saken (for eksempel Åpen, Lukket, Avventer). |
| Tagger | Tagger brukt for å kategorisere eller legge til metadata for saken. |

[!include[Conf. columns](../includes/tip-configure-columns.md)]

## Se saker i Saksfanen

1. Gå til den aktuelle skjermen, for eksempel Firma eller Person.

1. Klikk på detaljkortet **Saker** for å se alle saker tilknyttet enheten.

1. Dobbeltklikk på en sak i listen for å åpne den i et eget vindu og få tilgang til fullstendige detaljer.

### Inkluder avsluttede saker

For å inkludere lukkede saker i listen, merk av i **Avsluttet**-boksen nederst i detaljkortet. Dette gir en fullstendig oversikt over både åpne og avsluttede saker tilknyttet enheten.

## Oppretelaterteaker en sak

1. I detaljkortet **Saker**, klikk på **Legg til** for å opprette en ny sak for personen.

1. Fyll inn saksdetaljene etter behov. Feltet **Person** er forhåndsutfylt basert på personen du så på.

1. Klikk på **Lagre** for å registrere saken.

## Redigere en sak

For å redigere en sak direkte fra Saksfanen:

1. Finn og dobbeltklikk på saken du vil jobbe med.

1. I vinduet som åpnes, klikk **Rediger** (<i class="ph ph-pencil-simple" aria-hidden="true"></i>) for å begynne å oppdatere saksdetaljene.

## <a id="link"></a>Relater saker

Du kan opprette [relasjoner mellom saker][4] direkte fra detaljkortet **Saker**. Dette er nyttig for å spore tilknyttede problemer, avhengigheter eller hierarkiske relasjoner mellom saker.

1. Høyreklikk på en sak i listen.

1. Velg **Relasjoner** fra kontekstmenyen.

1. Velg relasjonstype (relatert, overordnet eller underordnet).

1. Velg en eksisterende sak å koble til, eller opprett en ny.

1. Legg eventuelt til en kommentar som beskriver relasjonen.

1. Klikk **Knytt til** for å opprette koblingen.

## Ytterligere tips

* **Sporing av saker:** Overvåk åpne saker og sørg for raske svar.

## Relatert innhold

* [Hvordan opprette en sak][2]
* [Administrere kundesaker i SuperOffice CRM][3]
* [Grupper kolonner og oppsummer beløp][5]

<!-- Referenced links -->
[1]: ../../request/learn/index.md
[2]: ../../request/learn/create.md
[3]: ../../request/learn/reply.md
[4]: ../../request/learn/request-relations.md
[5]: configure-columns.md#calculate
[9]: ../../company/learn/index.md#section-tabs
[10]: ../../contact/learn/index.md#section-tabs

<!-- Referenced images -->
[img1]: ../../../media/loc/en/company/requests-detail.png
