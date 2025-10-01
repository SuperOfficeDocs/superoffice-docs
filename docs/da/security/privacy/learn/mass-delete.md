---
uid: help-da-mass-delete
title: Masseslet poster (permanent)
description: I overensstemmelse med GDPR-kravene skal du have et retsgrundlag for at gemme data fra alle dine personer. Og når du ikke længere har et retsgrundlag for at gøre det, skal du fjerne deres data fra alle dine systemer.
keywords: Masseslet, slette personoplysninger
author: Bergfrid Dias
date: 03.21.2025
version: 10.5.3
content_type: howto
category: privacy
audience: person
audience_tooltip: SuperOffice CRM
language: da
redirect_from: /da/search-options/selection/learn/howto/mass-delete
---

# Masseslet poster (permanent)

I overensstemmelse med GDPR-kravene skal du have et retsgrundlag for at gemme data fra alle dine personer. Og når du ikke længere har et retsgrundlag for at gøre det, skal du fjerne deres data fra alle dine systemer.

Det betyder, at du ikke har lov til at gemme en persons oplysninger for evigt. Som firma skal du tænke over og kunne retfærdiggøre – hvor længe du vil gemme personoplysninger, før du sletter eller gennemgår de data, du gemmer.

For at slette flere poster (personer, firmaer, salg, projekter osv.) kan du oprette et udvalg med disse poster og slette dem i én arbejdsgang.

> [!NOTE]
> Denne opgave er kun tilgængelig for brugere med administratorrettigheder. Det er desuden en opgave, du bør overveje nøje, før du udfører den, fordi den sletter alle valgte poster permanent, både fra skærmbilledet Udvalg og fra SuperOffice-databasen.

## Beslutning om, hvad og hvornår personoplysninger skal slettes

Hvor længe du kan opbevare personoplysninger, afhænger af en række ting, der er specifikke for dit firma, og er blandt de ting, du definerer som en del af din privacy-strategi.

For eksempel kan du beslutte, at du kan retfærdiggøre at gemme personoplysningerne om kundeemner i tre år og personoplysningerne om tabte kunder i fem år eller noget lignende.

Måske beslutter du, at perioden for opbevaring af personoplysninger vil være længere for personer, der har givet deres samtykke til at modtage markedsføringsinformation, og for tabte kunder, der fortsætter med at henvende sig til dit firma med spørgsmål om support.

Alle disse betingelser og vilkår skal du præcisere og definere som en del af din GDPR-strategi. Det anbefales at søge rådgivning fra advokater om sådanne spørgsmål for at sikre overholdelse.

Efter at du har fastlagt de regler, der gælder for dit firma, kan du bruge funktionen Udvalg og funktionen [SAINT][2] i SuperOffice CRM til at hjælpe dig med at finde de personer, der skal slettes, og derefter masseslette alle personer, som du ikke længere vil beholde i systemet.

## Find personer, der skal slettes eller gennemgås, med Udvalg

Udvalg er et værktøj til at finde data i din CRM-database, der passer til et bestemt kriterier.

Sletning af alle personer i en bestemt kundekategori, og som du ikke har været i kontakt med i en vis periode, hjælper dig med at holde din database opdateret.

Du kan for eksempel oprette udvalg for alle personer, der defineres som:

* Kundeemner
* Registreret før en bestemt dato
* Der ikke har dokumenteret udtrykkeligt samtykke
* Der ikke har haft nogen interaktion med dit firma i en given periode

Du kan søge efter og finde personer, der opfylder mere end ét kriterium, eller du kan oprette flere udvalg og derefter søge efter de data, der er fælles eller adskiller sig, ved at oprette et kombineret udvalg.

Udvalget er et meget fleksibelt og kraftfuldt værktøj, når du har lært, hvordan du bruger det.

## Brug SuperOffice SAINT til at gennemgå dine personer

Du kan også bruge SAINT til at hjælpe dig med at identificere mulige personer, der skal slettes.

SAINT står for "SAles INTelligence" og fungerer ved, at der føjes nogle smarte algoritmer til dine CRM-data.

Kort sagt overvåger SuperOffice SAINT de data, du har gemt i din CRM-løsning, og advarer dig om forskellige statusser eller handlingsanmodninger, som du har defineret som vigtige. Dette kan være alt fra handlinger, der endnu ikke er sket på et givet tidspunkt, til værdier, som er opfyldt eller ikke opfyldt, og som du vil advares om, så du kan udføre den nødvendige handling.

SAINT kan også bruges til at overvåge information om personer. Det betyder, at du for eksempel kan bruge SAINT til at identificere personer, som du slet ikke har haft kontakt med i en given periode. Dette giver dig en liste over personer, som du måske vil fjerne fra din CRM-database eller behandle på en bestemt måde baseret på dit firmas GDPR-politikker.

SAINT-kriterierne findes under **Tællere (SAINT)** i [kriterielisten][9] i skærmbilledet **Find**.

Hvis du er helt ny i SAINT, kan det være nyttigt at bruge en SuperOffice CRM-ekspert til at hjælpe dig med at komme i gang. Din lokale SuperOffice-person kan hjælpe dig med dette.

## Masseopdatering af personer

Når du har [oprettet et udvalg][8] af personer, der skal opdateres, kan du hurtigt ændre deres oplysninger i bulk.

1. Åbn det ønskede udvalg, og gå til fanen **Firma/person**.
1. Klik på knappen **Opgave** (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) og vælg **Masseredigering**.
1. Vælg det felt, du vil opdatere (for eksempel retsgrundlag eller kategori).
1. Anvend ændringerne, og bekræft.

> [!TIP]
> [Masseredigering][5] hjælper med at holde din database konsistent og i overensstemmelse med virksomhedens politikker.

## Massesletning af personer og firmaer

For at overholde GDPR skal du slette persondata, når du ikke længere har et gyldigt retsgrundlag for at opbevare dem.

> [!CAUTION]
> Kun administratorer kan udføre denne handling. **Slettede poster kan ikke gendannes.**

### Trin

1. Åbn det ønskede udvalg, og gå til fanen **Firma/person**.
1. Hvis du kun vil slette bestemte personer, skal du markere dem i fanen Firma/person.
1. Klik på knappen **Opgave** (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) og vælg **Slet alle personer** eller **Slet alle firmaer og personer**.
1. Bekræft sletningen, når du bliver bedt om det.

<!-- Referenced links -->
[9]: ../../../search-options/learn/search-criteria.md
[8]: ../../../search-options/selection/learn/create.md
[5]: ../../../learn/basics/bulk-update.md
[2]: https://community.superoffice.com/no/learning/best-practices-tips/standard-crm/saint-proactive-customer-follow-up/
