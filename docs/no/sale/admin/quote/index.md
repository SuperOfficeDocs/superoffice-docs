---
uid: help-no-quote-admin
title: Administrer tilbud og ordrekonfigurasjon
description: Lær hvordan tilbud, quote connectors og ERP-integrasjon fungerer i SuperOffice CRM, og hvordan du konfigurerer dem i Tilbud/Sync-bildet.
keywords: quote connector, ERP-kobling, tilbudsinnstillinger, prisliste, produkt, Tilbud/Sync, ERP-oppsett, quote connector-innstillinger, salgsoppsett, tilbud, sync
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: concept
license: salespremium
audience: settings
audience_tooltip: Settings and maintenance
language: no
redirect_from:
  - /no/quote/learn/admin/index
  - /no/quote/learn/admin/quotesync-tab-erp-connections
  - /no/quote/learn/admin/quotesync-tab-settings
index: true
---

# Administrer tilbud og ordrekonfigurasjon

**Tilbud/Sync**-bildet i Innstillinger og vedlikehold er der du konfigurerer alt som trengs for å aktivere tilbud og ordrebehandling i SuperOffice CRM.

> [!NOTE]
> Denne funksjonen krever brukerplanen **Sales Premium**.

## Produkter og prislister

Hvert tilbud i SuperOffice inneholder ett eller flere produkter, og hvert produkt må tilhøre en **prisliste**.

Det finnes to måter å administrere produkter og priser i SuperOffice CRM:

* **Manuelt**, ved bruk av det innebygde produktregisteret i SuperOffice, også kalt **SuperOffice Standalone connector**.

* **Automatisk**, ved å hente produktdata fra et eksternt **ERP-system**.

## Quote connectors og ERP-koblinger

For å hente produktdata og beregne priser bruker SuperOffice **quote connectors** og **ERP-koblinger**.

En **quote connector** er et programtillegg (webtjeneste eller DLL) som håndterer integrasjonen. Den kommuniserer med et spesifikt ERP- eller produktsystem og utfører oppgaver som:

* Henter produkt- og prisdata
* Validerer rabatter
* Beregner totalsummer og mva
* Sender aksepterte tilbud som ordrer

En **quote connector fungerer ikke alene** før den er konfigurert. For å aktivere den må du opprette en **ERP-kobling**, som kombinerer connectoren med:

* Tilgangskontroll (hvem kan bruke den)
* Autentiserings- eller endepunktinnstillinger
* Atferdsregler som avrunding, varsler og godkjenningslogikk

Tenk på det slik: **ERP-kobling = quote connector + konfigurasjon**

Du kan konfigurere flere ERP-koblinger for samme connector. For eksempel hvis organisasjonen din bruker forskjellige innstillinger for ulike markeder eller brukergrupper.

> [!TIP]
> Alle ERP-koblinger administreres på fanen **ERP-koblinger** i **Tilbud/Sync**-bildet.

### SuperOffice Standalone connector

Dette er standardoppsettet når ingen ERP-system er koblet til. Det passer for enklere behov eller når produktdata ikke håndteres andre steder. Alle produktdata lagres og administreres direkte i SuperOffice:

* [Definer prislister og legg til produkter manuelt][2]
* Bruk den innebygde kalkulasjonsmotoren
* Støtter ikke automatisk ordreinnsending

> [!NOTE]
> Det kreves likevel en ERP-kobling, men den er lokal til SuperOffice og kobler ikke til et eksternt system.

### ERP-basert tilbudshåndtering

Når SuperOffice er integrert med et ERP-system, henter quote connector produkt- og prisdata direkte fra ERP:

* Produkter hentes i sanntid (ikke lagret i SuperOffice)
* Priser og rabatter følger ERP-reglene
* Aksepterte tilbud kan automatisk generere ordrer i ERP

## <a id="tabs"></a>Faner i Tilbud/Sync-bildet

Tilbud/Sync-bildet inneholder fire faner for å konfigurere tilbud, produkter og ERP-integrasjon.

### ERP-koblinger

Brukes til å administrere ERP-koblinger for tilbud.

* Viser alle tilgjengelige quote connectors (lastes automatisk inn etter installasjon). Hold musepekeren over en rad for å vise detaljert informasjon.
* Viser aktive ERP-koblinger.
* Dobbeltklikk en kobling for å redigere innstillinger som synlighet, atferd og valideringsregler.
* Velg en ERP-kobling i listen, og klikk **Test ERP-koblingen** for å kontrollere at koblingen fungerer.

> [!TIP]
> Se [Sette opp ERP-kobling][1] for trinnvise instruksjoner.

### SuperOffice-produkter

Brukes til å administrere [prislister og produkter][2] som lagres i SuperOffice (når du bruker Standalone connectoren). Disse lagres i SuperOffice-databasen, ikke i et ERP-system.

Du kan:

* Legge til, redigere og slette prislister.
* Legge til eller fjerne produkter i hver liste. Dobbeltklikk et produkt for å redigere det.
* Konfigurere produktdetaljer som kostpris, mva og fortjeneste.
* Velge et miniatyrbilde som vises i tilbudsbildet.

### Innstillinger

Brukes til å konfigurere globale tilbudsinnstillinger og [produktbildets layout][3].

* **Bruk rabatt på totalsum:** Aktiverer et valgfritt felt for å legge til rabatt på hele tilbudsbeløpet (prosent eller beløp). To rabattfelt vises da nederst på fanen **Produkter** i dialogboksen **Rediger tilbud**.

    > [!NOTE]
    > Totalrabatten legges på i tillegg til eventuelle rabatter på produktene.

* **Standardtekst for oppfølging:** Angi standard påminnelsestekst for oppfølging som opprettes når tilbud sendes.

* **Åpne salgstyper:** Åpner listen **Salg - Type, Faser, Tilbud**, der regler for tilbud defineres. Hvert salg i SuperOffice må ha en [salgstype][5], og mange standardegenskaper for et tilbud kommer fra salgstypen. Dette gjelder f.eks. bruk av alternativer, tilbudsmaler, tilbudets gyldighet og krav til godkjenning.

Under **Produktfelt** kan du kontrollere hvilke felt som vises når brukere legger til eller redigerer produkter.

### Sync

Brukes til å [legge til Sync Connectors og konfigurere ERP-koblinger][4] for synkronisering av firmaer, personer og prosjekter. Denne fanen er bare relevant hvis du planlegger å synkronisere CRM-data med ERP-aktører.

## Relatert innhold

* [Sette opp ERP-kobling][1]
* [Legge til prislister og produkter][2]
* [Tilpasse tilbudsbildet][3]
* [Administrere ERP-synkronisering][4]

<!-- Referenced links -->
[1]: set-up-quote-connector.md
[2]: price-list-and-products.md
[3]: configure-product-fields.md
[4]: ../../../erp/admin/index.md
[5]: ../sale-type.md
