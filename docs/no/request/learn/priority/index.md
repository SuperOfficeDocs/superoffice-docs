---
uid: help-no-request-priority
title: Saksprioriteter
description: Saksprioriteter
keywords: sak, prioritet
author: Hanne Gunnarsson
date: 12.10.2024
topic: concept
audience: settings
audience_tooltip: Settings and maintenance

language: no
---

# Saksprioriteter

Alle saker som registreres i SuperOffice, tilordnes en prioritet som gjenspeiler hvor viktig henvendelsen er.

Standardprioritetene som følger med systemet, er **Høy**, **Medium** og **Lav**. Du kan imidlertid både opprette nye prioriteter og redigere innstillingene for eksisterende prioriteter.

Hvilken prioritet en sak tilordnes, kan styres av for eksempel:

* Personen
* Firmaet
* E-postkassen
* Et e-postfilter

Når en sak er tilordnet en prioritet, kan prioriteten brukes til å styre en eventuell eskalering av saken.

For eksempel: Du kan angi at saker som kommer fra et bestemt firma, skal ha VIP-prioritet, og at du skal varsles per e-post hvis ikke saken er blitt lest innen en bestemt tidsfrist.

## Overstyr rekkefølge

Prioriteter overstyrer hverandre i følgende rekkefølge:

1. Prioritet som er angitt for et e-postfilter
1. Prioritet som er angitt for person
1. Prioritet som er angitt for firma
1. Prioritet som er angitt for e-postkasse
1. Standardprioriteter

På grunn av denne rekkefølgen får en henvendelse fra en person med høy prioritet høy prioritet selv om e-postkassen vedkommende sender til, har lav prioritet.

## Eskalering

I SuperOffice Saker kan du definere så mange prioriteter du vil. Til hver prioritet kan du definere eskaleringsnivåer, slik at systemet sender henvendelsen videre i organisasjonen hvis den ikke er blitt lest eller behandlet innen en viss tid.

For eksempel angir brukerstøtte- og SLA-avtaler at leverandøren skal starte problemløsing innen 2 timer. Du kan da definere operasjoner som gjør at saken eskaleres og fordeles til nye saksbehandlere hvis den ikke er blitt lest eller behandlet innen dette tidsrommet. Du kan definere så mange operasjoner du vil, og også bli varslet via mobiltelefon.

## Tilgjengelighet

Hver prioritet har egenskapen tilgjengelighet knyttet til seg. Hvis sakens prioritet settes til **Ekstern**, vil prioriteten være tilgjengelig via SuperOffice Kundesenter.

Hvis mer enn to prioriteter er tilgjengelige eksternt, kan kunden velge hvilken prioritet som skal gjelde for saken. Dette kan føre til at saken får høyere prioritet enn det som er nødvendig, ettersom kunden ønsker å få svar så fort som mulig og dermed velger den høyeste prioriteten som er tilgjengelig. De høyeste prioritetene bør derfor settes til **Intern**, mens **Medium** og **Lav** kan gjøres tilgjengelig eksternt.

## Hva vil du gjøre nå?

* [Opprett prioritet][1]
* [Slette prioriteter][2]
* [Opprette eskaleringsnivåer][3]

<!-- Referenced links -->
[1]: create.md
[2]: delete.md
[3]: escalation-levels.md

<!-- Referenced images -->
