---
uid: help-no-time-zones
title: Tidssoner
description: Tidssoner
author: SuperOffice RnD
so.date: 07.04.2022
keywords: CRM
so.topic: concept
language: no
---

# Tidssoner

SuperOffice CRM støtter oppfølginger i forskjellige tidssoner. Tidssoner er aktivert hvis det er en listeboks for å velge en tidssone nederst til venstre i dagboken (flagg og land).

> [!NOTE]
> Bruk av tidssoner må være aktivert per land i Innstillinger og vedlikehold (under **Alternativer** > **Tidssoner**). I tillegg kan du gå til **Preferanser** for å vise tidssonevelgeren og angi standard tidssone. Der finner du mer informasjon om hvordan du konfigurerer tidssoner.

## Hvordan fungerer tidssoner i SuperOffice CRM?

Tidssonefunksjonalitet kan være nyttig hvis organisasjonen din har kontorer i flere land med forskjellige tidssoner, og du må planlegge møter eller telefonkonferanser med personer i et land med en annen tidssone enn din. Oppfølgingen opprettes deretter i tidssonen for det valgte landet.

Hvis hovedkontoret ditt for eksempel befinner seg i Norge, og du skal ha et møte med personer i datterselskapene i Finland og USA, kan du sette opp et møte til norsk tid og deretter sjekke når det er i amerikansk og finsk tid. På denne måten kan du for eksempel unngå å opprette et møte som foregår midt på natten amerikansk tid. For personene du inviterer til møtet, vises møtet i den tidssonen de har angitt i sin egen SuperOffice CRM, selv om du har satt opp møtet i norsk tid.

Denne funksjonen støtter sommertid.

> [!NOTE]
> Oppfølginger du opprettet før du aktiverte tidssoner, beholdes i den tidssonen som er standard for din SuperOffice-database.

## Hvordan velger du tidssoner?

Tidssoner vises i en listeboks i [Dagbok][1] og for [oppfølginger][3]. Standard tidssone for SuperOffice-databasen vises øverst, ved hjelp av dette ikonet: ![icon][img1].

Tidssonelisten er sortert etter land. Øverst i tidssonelisten finner du navnet på valgt land med flagg.

### Søk etter land eller by

Bruk det øverste feltet med valgt land og flagg som et søkefelt. Du kan søke etter både land og byer, forutsatt at byen er inkludert i tidssonedataene. Hvis du for eksempel ikke kjenner tidssonen for Canberra, kan du søke etter Canberra og få opp den aktuelle australske tidssonen i listen.

1. Plasser musepekeren i landfeltet.
2. Skriv inn navnet på byen eller landet du vil vite tidssonen for.
3. Når du har funnet ønsket by eller land, klikker du på elementet for å aktivere ønsket tidssone.

### Søk etter tidsforskjell

Ved å søke på antall timer for å finne riktig tidssone. Hvis du for eksempel skriver inn +3, vises alle tidssoner som er tre timer etter tidssonen som er angitt i SuperOffice CRM.

> [!NOTE]
> Navn på regioner i tidssonevelgeren vil alltid være på engelsk, mens navn på land avhenger av språkinnstillingene i SuperOffice CRM. Ikke glem dette når du søker etter land og regioner.

## Nyttige tips om tidssoner

* Hvis du holder musepekeren over tidssonelisten, vises en infoboks med hjelpetekst om hvilke større byer (i det aktuelle landet) som er i tidssonen du har valgt.

* Hvis du i dagboken holder musepekeren over en oppfølging som er opprettet i en annen tidssone enn standarden for SuperOffice-databasen, vises en infoboks med informasjon om tidspunktet for oppfølging i din tidssone og i tidssonen til personen som opprettet den.

<!-- Referenced links -->
[1]: ../../diary/learn/index.md
[3]: ../../diary/learn/follow-ups.md

<!-- Referenced images -->
[img1]: ../../../media/icons/time-zone-local.png
