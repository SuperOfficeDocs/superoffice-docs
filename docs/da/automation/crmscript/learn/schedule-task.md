---
uid: help-da-automation-schedule-task
title:  Planlagte opgaver
description: Planlagte opgaver
author: SuperOffice RnD
date: 06.29.2022
keywords: makro, script, plan
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Planlagte opgaver

På fanen **Planlagte opgaver** kan du angive, at et script eller en makro skal udføres på bestemte tidspunkter.

> [!TIP]
> Tidskrævende opgaver bør planlægges på tidspunkter, hvor færre personer bruger SuperOffice.

Klik på en opgave på listen for at redigere dens egenskaber, f.eks. hvornår den sidst blev udført, udførelsestid og sendte/modtagne elementer.

## Opret en ny planlagt opgave

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Klik på **CRMScript**, og vælg fanen **Planlagte opgaver** .

1. Klik på **Ny opgave**.

1. Vælg, hvor ofte opgaven skal udføres, på listen **Frekvens**. **Kør efter en anden tidsplan** kan bruges til at starte en opgave, efter at en opgave er fuldført. Du kan bruge denne valgmulighed til at sammenkæde opgaver.

1. Klik på **OK**.

1. Udfyld de følgende felter i fanen **Egenskaber**:
    * **Navn**: Angiv et navn for opgaven.
    * **ejScript/CRMScript**: Vælg scriptet eller makroen, der skal bruges i opgaven.

1. Klik på **Anvend**, og gå til fanen **Tidsplan** .

1. Vælg **Start nu** for at udføre opgaven næste gang, systemet kontrollerer for planlagte opgaver (normalt inden for 1 minut).

1. Vælg **Deaktiver**, hvis opgaven skal være inaktiv i øjeblikket.

1. Rediger tidsplanen. De tilgængelige felter afhænger af den valgte frekvens:

    * **Aldrig**: Opgaven udføres ikke, medmindre du vælger **Start nu**.
    * **Minutinterval**: Opgaven udføres ved det valgte interval (i minutter). Sørg for, at intervallet er længere end den tid, det tager at udføre opgaven.
    * **Timeinterval**: Opgaven udføres en gang i timen, X minutter over timen.
    * **Ugeinterval**: Opgaven udføres ugentligt. Angiv på hvilket tidspunkt og på hvilke(n) dag(e) opgaven skal udføres.
    * **Månedsinterval**: Opgaven kører månedligt. Angiv på hvilket tidspunkt, hvilken dag i måneden, og i hvilke(n) måned(er).
    * **Efter**: Opgaven udføres på den angivne dato og klokkeslæt.
    * **Kør efter tidsplan**: Opgaven udføres, når den planlagte opgave er fuldført. Du kan bruge denne valgmulighed til at sammenkæde opgaver.

1. Angiv **Låsetid i minutter** for at forhindre flere opgaver fra samme tidsplan i at køre på samme tid. Du skal indstille denne værdi højere end den forventede udførelsestid for opgaven. Hvis din opgave tager længere tid end angivet her, anses den for at være mislykket, og en ny opgave fra samme tidsplan får tilladelse til at blive udført.

1. Indstil **Minutter til genstart efter fejl**. Denne indstilling angiver tidsrummet, før en mislykket opgave (en opgave der er gået ned) udføres igen.

1. Klik på **OK**. Opgaven føjes til listen, og du kan se status og klokkeslæt for næste udførelse af opgaven.

## Relateret indhold

* [Bedste praksis for CRMScript][1]

<!-- Referenced links -->
[1]: ../../../../en/automation/crmscript/code-quality/best-practices.md
