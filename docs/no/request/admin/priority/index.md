---
uid: help-no-request-priority
title: Saksprioriteter
description: Saksprioriteter
keywords: saksprioritet, prioritet, eskalering, sak
author: Hanne Gunnarsson
date: 02.05.2025
version: 10.5.1
topic: concept
license: serviceessentials
audience: settings
audience_tooltip: Innstillinger og vedlikehold
language: no
---

# Saksprioriteter

Alle saker som registreres i SuperOffice, tilordnes en prioritet som gjenspeiler hvor viktig henvendelsen er.

Standardprioritetene som følger med systemet, er **Høy**, **Medium** og **Lav**. Du kan imidlertid både opprette nye prioriteter og redigere innstillingene for eksisterende prioriteter.

Hvilken prioritet en sak tilordnes, kan bestemmes av for eksempel:

* Personen
* Firmaet
* E-postkassen
* Et e-postfilter

Når en sak er tilordnet en prioritet, kan prioriteten brukes til å styre en eventuell eskalering av saken.

For eksempel: Du kan angi at saker som kommer fra et bestemt firma, skal ha VIP-prioritet, og at du skal varsles per e-post hvis saken ikke er blitt lest innen en bestemt tidsfrist.

## Overstyr rekkefølge

Prioriteter overstyrer hverandre i følgende rekkefølge:

1. Prioritet angitt for et e-postfilter
1. Prioritet angitt for en person
1. Prioritet angitt for et firma
1. Prioritet angitt for en e-postkasse
1. Standardprioriteter

På grunn av denne rekkefølgen vil en sak fra en person med høy prioritet få høy prioritet selv om e-postkassen personen sender til har lav prioritet.

## Eskalering

I SuperOffice kan du definere så mange prioriteter du vil. Til hver prioritet kan du definere [eskaleringsnivåer][3], slik at systemet sender henvendelsen videre i organisasjonen hvis den ikke er blitt lest eller behandlet innen en viss tid.

For eksempel kan brukerstøtte- og SLA-avtaler spesifisere at leverandøren må starte problemløsing innen to timer. Du kan da definere regler som eskalerer saken og omfordeler den til nye saksbehandlere hvis den ikke er lest eller behandlet innen dette tidsrommet. Du kan definere så mange eskaleringsnivåer du vil, og også bli varslet via SMS.

## Tilgjengelighet

Hver prioritet har en tilgjengelighetsegenskap knyttet til seg. Hvis sakens prioritet settes til **Ekstern**, vil prioriteten være synlig i SuperOffice Kundesenter.

Hvis mer enn to prioriteter er eksternt tilgjengelige, kan kunden velge hvilken prioritet som skal gjelde for saken. Dette kan føre til at saken får høyere prioritet enn nødvendig, ettersom kunden ofte vil velge den høyeste tilgjengelige prioriteten for å få raskest mulig svar. Derfor bør de høyeste prioritetene settes til **Intern**, mens **Medium** og **Lav** kan være eksternt tilgjengelige.

## Relatert innhold

* [Opprett prioritet][1]
* [Slett prioritet][2]
* [Opprett eskaleringsnivåer][3]

<!-- Refererte lenker -->
[1]: create.md
[2]: delete.md
[3]: escalation-levels.md
