---
uid: help-no-project-merge
title: Slå sammen prosjekter
description: Slik slår du sammen prosjekter i SuperOffice
keywords: slå sammen prosjekter, prosjektadministrasjon, prosjekt
author: Bergfrid Dias
date: 01.30.2025
version: 10.5.1
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Slå sammen prosjekter

Hvis du har to nesten identiske prosjekter, kan du slå dem sammen, inkludert prosjektdeltakere og aktiviteter. Kildeprosjektet blir da slettet.

## Trinn

1. Gå til prosjektet du vil slå sammen med et annet. Se [Bruk Finn-bildet][1].

1. Klikk på **Oppgave**-knappen (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) øverst til høyre på prosjektkortet, og velg **Slå sammen prosjekter**.

    > [!NOTE]
    > Hvis **Slå sammen**-alternativet er nedtonet, har du ikke nødvendige brukerrettigheter for å slå sammen prosjekter.

1. I dialogboksen **Slå sammen prosjekter**:

    * Under **Til**, velg prosjektet du vil slå sammen det eksisterende prosjektet med. Begynn å skrive for å søke etter et prosjekt.
    * Klikk på pilknappen (<i class="ph ph-arrows-left-right" aria-hidden="true"></i>) for å bytte **Fra**- og **Til**-prosjektene.

    > [!CAUTION]
    > Sørg for at du velger riktige prosjekter i feltene **Fra** og **Til** før du fortsetter. **Sammenslåing kan ikke angres**.

1. (Valgfritt) Velg **Erstatt tomme felt med data fra [kildeprosjekt]** for å oppdatere tomme felt i målprosjektet med data fra kildeprosjektet.

1. Klikk **Slå sammen**. Følgende skjer:
    * Prosjektdeltakere flyttes eller slås sammen.
    * Alle aktiviteter flyttes.
    * Eventuelle tilknyttede salg flyttes.
    * Detaljer slås sammen (hvis spesifisert).
    * Hvis du slår sammen et prosjekt med en prosjektguide med et prosjekt uten eller med en annen prosjektguide, fjernes prosjektguiden fra kildeprosjektet.
    * Kildeprosjektet slettes.

![Dialogboksen Slå sammen prosjekter viser felt for valg av kilde- og målprosjekt, alternativer for å erstatte tomme felt, og en oppsummering av sammenslåingshandlingene -screenshot][img2]

## Relatert innhold

* [Redigere prosjekter][3]
* [Slå sammen firmaer][2]

<!-- Refererte lenker -->
[1]: ../../search-options/learn/find-screen.md
[2]: ../../company/learn/merge-companies.md
[3]: edit.md

<!-- Refererte bilder -->
[img2]: ../../../media/loc/en/project/merge-projects.png
