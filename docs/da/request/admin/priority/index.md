---
uid: help-da-request-priority
title: Sagsprioriteter
description: Sagsprioriteter i SuperOffice bruges til at angive vigtigheden af en sag og styre eventuelle eskaleringer.
keywords: sag, prioritet
author: Hanne Gunnarsson
date: 03.07.2025
version: 10.5.2
topic: howto
license: serviceessentials
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Sagsprioriteter

Alle sager registreret i SuperOffice tildeles en prioritet, der afspejler sagens vigtighed.

Standardprioriteterne, der følger med systemet, er **Høj**, **Middel** og **Lav**. Du kan imidlertid både oprette nye prioriteter og redigere indstillingerne for eksisterende prioriteter.

Prioriteten, der tildeles til en sag, kan for eksempel bestemmes ud fra:

* Personen
* Firmaet
* E-mail-kontoen
* Et e-mail-filter

Efter at en sag har fået tildelt en prioritet, kan prioriteten anvendes til at styre alle eskaleringer af sagen.

For eksempel: Du kan angive, at sager fra et bestemt firma skal have VIP-prioritet, og at du skal modtage en underretning pr. e-mail, hvis sagen ikke er blevet læst inden for en angivet tidsfrist.

## Tilsidesæt rækkefølge

Prioriteter tilsidesætter andre prioriteter i denne rækkefølge:

1. Prioritet angivet for et e-mail-filter
1. Prioritet angivet for en person
1. Prioritet angivet for et firma
1. Prioritet angivet for et e-mail-felt
1. Standardprioriteter

På grund af denne rækkefølge vil en sag fra en person med høj prioritet få høj prioritet, selvom den e-mail-konto, som vedkommende sender til, har lav prioritet.

## Eskalering

I SuperOffice Sager kan du definere så mange prioriteter, du vil. For hver prioritet kan du definere eskaleringsniveauer, så systemet sender henvendelsen videre i organisationen, hvis den ikke er blevet læst eller behandlet inden for en angivet tid.

For eksempel angiver brugersupport- og SLA-aftaler, at leverandøren skal starte problemløsning inden for 2 timer. Du kan så definere handlinger, som gør, at sagen eskaleres og tildeles til nye sagsbehandlere, hvis den ikke er blevet læst eller behandlet inden for denne tid. Du kan definere så mange handlinger, du vil, og også sende underretning via mobiltelefon.

## Tilgængelighed

Alle prioriteter har egenskaben Tilgængelighed knyttet til sig. Hvis sagens prioritet angives til **Eksterne**, vil prioriteten være tilgængelig via SuperOffice Kundecenter.

Hvis mere end to prioriteter er tilgængelige eksternt, kan kunden vælge, hvilken prioritet der skal anvendes for sagen. Dette kan medføre, at den aktuelle sag får højere prioritet end nødvendigt, eftersom kunden ønsker at få svar så hurtigt som muligt og sandsynligvis vælger den højeste prioritet, der er tilgængelig. De højeste prioriteter bør derfor angives til **Intern**, mens **Middel** og **Lav** gøres tilgængelige eksternt.

## Hvad ønsker du at foretage dig nu?

* [Opret prioritet][1]
* [Slet prioriteter][2]
* [Opret eskaleringsniveauer][3]

<!-- Referenced links -->
[1]: create.md
[2]: delete.md
[3]: escalation-levels.md
