---
uid: help-da-company-merge
title: Slå firmaer sammen
description: Hold din kundedatabase ren og effektiv ved at slå sammen dublerede firmaer eller kombinere poster, når et firma opkøber et andet.
keywords: flet firmaer, administrer firmaer, flet identiske personer, firma
author: Bergfrid Dias
date: 03.07.2025
version: 10.5.2
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Slå firmaer sammen

[!include[Requirement](../../learn/includes/note-req-manage-entities.md)]

For at holde din kundedatabase ren og effektiv kan du slå sammen dublerede firmaer eller kombinere poster, når et firma opkøber et andet. Personer, aktiviteter, fakturaer, registrerede domæner og andre detaljer flyttes eller flettes, og kildefirmaet slettes.

## Trin

1. Klik på **Opgave**-knappen (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) i øverste højre hjørne af firmakortet.
    Vælg **Vedligehold firmaer** > **Slå firmaer sammen** i menuen.
    Dialogboksen **Slå firmaer sammen** vises, med kildefirmaet angivet under **Fra**.

2. Under **Til firma** skal du søge efter og vælge det firma, som kildefirmaet skal flettes med. Hvis du vil bytte om på **Fra**- og **Til**-firmaer, skal du klikke på pilknappen <i class="ph ph-arrows-left-right" aria-hidden="true"></i>.

    > [!CAUTION]
    > Sørg for at vælge det korrekte firma i både **Fra**- og **Til**-felterne, før du fortsætter.

3. Under **Detaljeoplysninger om firma og personer** kan du vælge en eller begge af følgende indstillinger:

    * **Læg identiske personer sammen:** Personer med præcis samme fornavn, mellemnavn og efternavn flettes.
    * **Erstat tomme felter med værdier fra kildefirmaet:** Tomme felter i målfirmaet opdateres med data fra kildefirmaet.

4. Klik på **Slå sammen**. Følgende sker:

    * Personer (og relaterede sager) flyttes eller flettes.
    * Aktiviteter flyttes.
    * Projektmedlemskab og medlemskab i statiske udvalg følger målfirmaet.
    * Tomme felter opdateres, hvis du har valgt **Erstat tomme felter...**.
    * Kildefirmaet slettes.

![Dialogboksen Slå firmaer sammen med felter til valg af kilde- og målfirma, indstillinger for fletning af identiske personer, erstatning af tomme felter og en oversigt over de handlinger, der udføres. -screenshot][img4]

> [!TIP]
> Du kan også flette firmaer i dynamiske og statiske udvalg.

## Relateret indhold

* [Flet personer][2]

<!-- Referenced links -->
[2]: ../../contact/learn/merge-contacts.md

<!-- Referenced images -->
[img4]: ../../../media/loc/en/company/merge-companies.png
