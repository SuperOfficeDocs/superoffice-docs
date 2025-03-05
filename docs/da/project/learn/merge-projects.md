---
uid: help-da-project-merge
title: Slå projekter sammen
description: Sådan slår du projekter sammen i SuperOffice
keywords: projekt
author: Bergfrid Dias
date: 03.07.2025
version: 10.5.2
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Slå projekter sammen

Hvis du har to næsten ens projekter, kan du slå dem sammen, inklusive projektdeltagere og aktiviteter. Kildeprojektet vil derefter blive slettet.

## Trin

1. Gå til det projekt, du vil slå sammen med et andet projekt. Se [Brug skærmbilledet Søg][1].

1. Klik på **Opgave**-knappen (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) i øverste højre hjørne af projektkortet, og vælg **Slå projekter sammen**.

    > [!NOTE]
    > Hvis valget **Slå projekter sammen** er nedtonet, har du ikke de nødvendige brugerrettigheder til at udføre handlingen.

1. I dialogboksen **Slå projekter sammen**:

    * Under **Til** vælger du det projekt, du vil slå sammen med det aktuelle projekt. Begynd at skrive for at søge efter et projekt.
    * Hvis du vil bytte om på **Fra**- og **Til**-projekterne, skal du klikke på pileknappen (<i class="ph ph-arrows-left-right" aria-hidden="true"></i>).

    > [!CAUTION]
    > Sørg for, at du vælger de korrekte projekter i felterne **Fra** og **Til**, før du fortsætter. **Sammenlægning kan ikke fortrydes**.

1. (Valgfrit) Vælg **Overskriv tomme felter med data fra [kildeprojekt]** for at opdatere tomme felter i målprojektet med data fra kildeprojektet.

1. Klik på **Slå sammen**. Følgende sker:
    * Projektdeltagere flyttes eller slås sammen.
    * Alle aktiviteter flyttes.
    * Eventuelle tilknyttede salg flyttes.
    * Detaljer slås sammen (hvis angivet).
    * Hvis kildeprojektet er tilknyttet en projektguide, og målprojektet har en anden eller ingen projektguide, fjernes projektguiden fra kildeprojektet.
    * Kildeprojektet slettes.

![Dialogboksen Slå projekter sammen -screenshot][img2]

## Relateret indhold

* [Rediger projekter][3]
* [Slå firmaer sammen][2]

<!-- Referenced links -->
[1]: ../../search-options/learn/find-screen.md
[2]: ../../company/learn/merge-companies.md
[3]: edit.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/project/merge-projects.png
