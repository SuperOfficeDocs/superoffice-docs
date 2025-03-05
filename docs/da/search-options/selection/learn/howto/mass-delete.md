---
uid: help-da-mass-delete
title: Masseslet poster (permanent)
description: I overensstemmelse med GDPR-kravene skal du have et retsgrundlag for at gemme data fra alle dine personer. Og når du ikke længere har et retsgrundlag for at gøre det, skal du fjerne deres data fra alle dine systemer.
author: Bergfrid Dias
date: 02.15.2023
keywords: selection, GDPR
topic: howto
language: da
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

SAINT kan også bruges til at overvåge information om personer.

Det betyder, at du for eksempel kan bruge SAINT til at identificere personer, som du slet ikke har haft kontakt med i en given periode. Dette giver dig en liste over personer, som du måske vil fjerne fra din CRM-database eller behandle på en bestemt måde baseret på dit firmas GDPR-politikker.

Her er mere information om, [hvordan du opretter et SAINT-udvalg][3].

Hvis du er helt ny i SAINT, kan det være nyttigt at bruge en SuperOffice CRM-ekspert til at hjælpe dig med at komme i gang. Din lokale SuperOffice-person kan hjælpe dig med dette.

## Masseopdatering eller sletning af personer

Efter at du har oprettet en liste over alle de personer, der enten skal opdateres eller slettes, er det tid til faktisk at udføre de ønskede ændringer.

Hvis du vil masseopdatere, for eksempel retsgrundlag eller lignende, skal du vælge [masseredigering][5] under fanen **Opgave** i dit udvalg.

For at masseslette kontakter fra et udvalg kan du vælge funktionen **Slet personer** via knappen **Opgave** i nederste højre hjørne af hovedskærmbilledet.

![Fra knappen Opgave på skærmbilledet for Udvalg kan du masseslette firmaer og personer -screenshot][img2]

[!include[Open Selections](../includes/goto-selections.md)]

1. Gå til et udvalg. Brug for eksempel skærmbilledet [Find][1].

1. Hvis du kun vil slette nogle af udvalgsmedlemmerne, skal du vælge dem på listen over medlemmer.

1. Klik på knappen **Opgave** og vælge **Slet alle**.

    ![På udvalget skal du klikke på knappen Opgave og vælge en af de ønskede Slet-funktioner -screenshot][img1]

1. Når du bliver spurgt, om du vil slette posterne, skal du klikke på **Ja**.

1. Når du bliver spurgt, om du er sikker på, at du vil slette posterne fra databasen, skal du klikke på **Ja**.

[!include[Note about restore](../../../../learn/includes/note-restore.md)]

## Hvad hvis du sletter personer ved et uheld?

Det kan nogle gange være vanskeligt at slette personer. Hvis en person eller et firma slettes ved en fejl, kan du fortryde det ved hjælp af [Papirkurv][4].

Selv om en slettet person eller et firma straks skjules for alle brugere, er de stadig tilgængelige i op til 14 dage i papirkurven, hvorfra du kan gendanne et firma eller en person, der blev slettet ved en fejltagelse.

Papirkurven findes i menuen Præferencer. Du kan se alle de personer, du har slettet, men også alle de personer, der blev slettet af andre brugere.

![Du kan gendanne elementer, du har slettet, ved at åbne papirkurven i menuen Personlige indstillinger -screenshot][img3]

<!-- Referenced links -->
[1]: ../../../learn/find-screen.md
[2]: https://community.superoffice.com/no/learning/best-practices-tips/standard-crm/saint-proactive-customer-follow-up/
[3]: ../dynamic-selections.md#saint
[4]: ../../../../learn/basics/deleting-elements.md#restore
[5]: bulk-update.md

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/search-options/company-selection-task-delete.png
[img2]: ../../../../../media/loc/en/search-options/company-selection-task-delete.png
[img3]: ../../../../../media/loc/en/search-options/recycle-bin-personal-settings.png
