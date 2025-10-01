---
uid: help-no-mass-delete
title: Masseslette poster (permanent)
description: I tråd med GDPR-kravene må du ha hjemmel for å lagre dataene til alle personene dine. Og når du ikke lenger har hjemmel for å gjøre det, må du fjerne dataene deres fra alle systemene dine.
keywords: Masseslett, slette personopplysninger
author: Bergfrid Dias
date: 03.21.2025
version: 10.5.3
content_type: howto
category: privacy
audience: person
audience_tooltip: SuperOffice CRM
language: no
redirect_from: /no/search-options/selection/learn/howto/mass-delete
---

# Masseslette poster (permanent)

I tråd med GDPR-kravene må du ha hjemmel for å lagre dataene til alle personene dine. Og når du ikke lenger har hjemmel for å gjøre det, må du fjerne dataene deres fra alle systemene dine.

Dette betyr at du ikke har lov til å lagre en persons informasjon for alltid. Som firma må du tenke på og kunne rettferdiggjøre – hvor lenge du vil beholde personopplysninger før du sletter eller gjennomgår dataene du lagrer.

Hvis du vil slette flere poster (personer, firmaer, salg, prosjekter og så videre), kan du opprette et utvalg av disse postene og slette dem i én operasjon.

> [!NOTE]
> Denne oppgaven er bare tilgjengelig for brukere med administratortilgang. Det er også en oppgave du bør tenke nøye på før du utfører, fordi den sletter alle valgte poster permanent, både fra utvalgskjermbildet og fra SuperOffice-databasen.

## Bestemme hvilke og når personopplysninger må slettes

Hvor lenge du kan beholde data avhenger av en rekke ting som er spesifikke for ditt firma og er blant de tingene du definerer som en del av personvernstrategien din.

Du kan for eksempel bestemme at du kan rettferdiggjøre lagring av personopplysninger om potensielle kunder i tre år, og personopplysningene til tapte kunder i fem år, eller noe lignende.

Kanskje du bestemmer at lagringstiden for personopplysninger vil være lenger for personer som samtykket til å motta markedsføringsinformasjon og for tapte kunder som fortsetter å stille supportspørsmål til firmaet.

Alle disse betingelsene og vilkårene må du tydeliggjøre og definere som en del av GDPR-strategien din. Det anbefales å søke juridisk rådgivning i slike saker for å sikre overholdelse.

Når du har fastslått hvilke regler som gjelder for firmaet ditt, kan du bruke utvalgsfunksjonaliteten og [SAINT-funksjonen][2] i SuperOffice CRM til å finne personene som skal slettes, og deretter masseslette alle personer du ikke vil beholde i systemet lenger.

## Finne personer som bør slettes eller gjennomgås med Utvalg

Utvalg er et verktøy for å finne data i CRM-databasen som passer til et bestemt sett med kriterier.

Hvis du sletter alle personer i en bestemt kundekategori, og som du ikke har vært i kontakt med i en viss periode, kan du holde databasen oppdatert.

Du kan for eksempel opprette utvalg av alle personer som er definert som:

* Potensielle kunder
* Registrert før en bestemt dato
* Som ikke har eksplisitte samtykker dokumentert
* Som ikke har hatt noen interaksjon med firmaet ditt i en gitt periode

Du kan søke etter og finne personer som oppfyller flere kriterier, eller du kan opprette flere utvalg og deretter søke etter dataene som er felles eller forskjellige, ved å opprette et kombinasjonsutvalg.

Utvalg er et veldig fleksibelt og kraftig verktøy, når du vet hvordan du bruker det.

## Bruk SuperOffice SAINT til å gå gjennom kontaktpersonene dine

Du kan også bruke SAINT som hjelp for å identifisere mulige personer som må slettes.

SAINT står for "SAles INTelligence" og fungerer ved å legge til noen smarte algoritmer til CRM-dataene dine.

Sagt på en enkel måte overvåker SuperOffice SAINT dataene du har lagret i CRM-løsningen, og varsler deg om ulike statuser eller handlingssaker du har definert som viktige. Dette kan være alt fra handlinger som ennå ikke har skjedd på et gitt tidspunkt, til verdier som er oppfylt eller ikke oppfylt, og som du ønsker å bli varslet om, slik at du kan utføre nødvendige handlinger.

SAINT kan også brukes til å overvåke kontaktinformasjon. Dette betyr at du for eksempel kan bruke SAINT til å identifisere personer du ikke har hatt kontakt med i det hele tatt i en gitt periode. Da får du en liste over personer som du kanskje vil fjerne fra CRM-databasen eller behandle på en bestemt måte, basert på firmaets GDPR-policyer.

SAINT-kriteriene finnes under **Tellere (SAINT)** i [kriterielisten][9] på **Finn**-skjermen.

Hvis SAINT er helt nytt for deg, kan det være nyttig å bruke en SuperOffice CRM-ekspert til å hjelpe deg med å komme i gang. Din lokale SuperOffice-kontakt kan hjelpe deg med dette.

## Masseredigering av personer

Når du har [opprettet et utvalg][8] med personer som må oppdateres, kan du raskt endre opplysningene deres i bulk.

1. Åpne ønsket utvalg og gå til fanen **Firma/person**.
1. Klikk på **Oppgave**-knappen (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) og velg **Masseredigering**.
1. Velg feltet du vil oppdatere (for eksempel hjemmel eller kategori).
1. Utfør endringene og bekreft.

> [!TIP]
> [Masseredigering][5] hjelper deg med å holde databasen konsekvent og i samsvar med bedriftens retningslinjer.

## Massesletting av personer og firmaer

For å overholde GDPR må du slette personopplysninger når du ikke lenger har et gyldig rettslig grunnlag for å lagre dem.

> [!CAUTION]
> Bare administratorer kan utføre denne handlingen. **Slettede poster kan ikke gjenopprettes.**

### Trinn

1. Åpne ønsket utvalg og gå til fanen **Firma/person**.
1. Hvis du kun vil slette spesifikke personer, markerer du dem i fanen Firma/person.
1. Klikk på **Oppgave**-knappen (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) og velg **Slett alle personer** eller **Slett alle firmaer og personer**.
1. Bekreft slettingen når du blir bedt om det.

<!-- Referenced links -->
[9]: ../../../search-options/learn/search-criteria.md
[8]: ../../../search-options/selection/learn/create.md
[5]: ../../../learn/basics/bulk-update.md
[2]: https://community.superoffice.com/no/learning/best-practices-tips/standard-crm/saint-proactive-customer-follow-up/
