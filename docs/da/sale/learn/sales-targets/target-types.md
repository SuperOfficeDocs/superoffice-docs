---
uid: help-da-sales-target-types
title: Opret en salgsmåltype med undertyper
description: Det kan være stressende at holde styr på dine salgsmål. Men hvis du definerer parametre og dimensioner for dine salgsmål, bliver det meget nemmere at holde styr på dine mål.
keywords: salgsmål, dimension
author: SuperOffice Product and Engineering
date: 09.17.2025
version: 10.5.2
content_type: howto
license: salespremium, Unlimited sales targets
functional_right: Targets administrator
deployment: online
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Opret en salgsmåltype med undertyper

Det kan være stressende at holde styr på dine salgsmål. Men hvis du definerer parametre og dimensioner for dine salgsmål, bliver det meget nemmere at holde styr på dine mål.

Som standard inkluderer SuperOffice én måltype: **Alle salg – Beløb**. Du kan tilføje brugerdefinerede måltyper baseret på salgsdata, firmaoplysninger eller brugerdefinerede felter.

## Krav

Du skal have den funktionelle ret **Targets administrator** for at tilføje, redigere eller slette måltyper.

> [!NOTE]
> For at tilføje måltyper har du brug for Unlimited sales targets-licensen ud over Sales Premium-licensen.

## Tilgængelige måltyper

En **måltype** definerer, hvad du vil måle. Du kan vælge mellem følgende systemdefinerede dimensioner:

* Alle salg
* Salgstype
* Salg, kilde
* Salg krediteret
* Salg, konkurrent
* Firma, kategori
* Firma, branche
* Firma, land

Du kan også bruge dine egne brugerdefinerede felter, hvis de indeholder listeværdier.

**Hver dimension kan kun bruges én gang for at forhindre dubletter.**

## Tilføj en ny måltype

1. Klik på <i class="ph ph-list" aria-label="Hovedmenu"></i> og vælg **Mål**.

1. I skærmbilledet **Mål** skal du klikke på **Tilføj ny måltype** for at definere en salgsdimension. Du kan også klikke på <i class="ph ph-gear" aria-label="Tandhjul"></i> (**Konfigurer mål**) på en eksisterende fane for at redigere den.

    ![Mål-skærmbillede med knappen Tilføj ny måltype -screenshot][img4]

1. Klik på **Måltype** for at vælge den dimension, du vil spore, såsom **Salgskilde** eller **Firmakategori**.

    ![Målindstillinger-dialog til oprettelse af en ny måltype -screenshot][img1]

1. Klik på **Måleenhed** for at vælge, hvordan resultater beregnes:

    * **Beløb:** Samlet værdi af salg
    * **Antal:** Antal salg
    * **Fortjeneste:** Fortjenstmargen

    Valgmulighederne afhænger af den valgte måltype.

1. Under **Separate mål** skal du vælge specifikke undertyper, der skal spores separat. Valgmulighederne afhænger af den valgte måltype.

    For eksempel, hvis måltypen er **Kategori**, er undertyperne dine firmakategorier.

1. Vælg afkrydsningsfeltet **Kun tilgængelig på firmaniveau og gruppeniveau**, hvis denne måltype ikke skal være tilgængelig på brugerniveau.

1. Klik på **Gem**. Måltypen tilføjes som en fane. Du kan nu [tilføje grupper og brugere til dit salgsmål][3].

## Fjern en måltype

For at slette en måltype:

1. Åbn **Målindstillinger** fra den relevante fane.
2. Klik på **Slet**.

> [!WARNING]
> Sletning af en måltype fjerner permanent alle relaterede data for alle år - tidligere, nuværende og fremtidige. Du kan ikke slette standardtypen **Alle salg – Beløb**.

## Tips og fejlfinding

* Efter at have gemt kan måltypen og måleenheden ikke ændres. For at justere disse indstillinger skal du oprette en ny måltype og slette den gamle.

* Du kan redigere listen **Separate mål** og afkrydsningsfeltet **Kun tilgængelig på firmaniveau og gruppeniveau** efter at have gemt.

    > [!NOTE]
    > Hvis du aktiverer firma/gruppe-kun tilgængelighed efter at have indtastet værdier på brugerniveau, vises en advarsel. Hvis du gemmer denne ændring, slettes målene på brugerniveau.

## Relateret indhold

* [Tilføj grupper og brugere til dit salgsmål][3]
* [Brug af salgsmål i dashboardruder][2]

<!-- Referenced links -->
[2]: ../../../dashboard/learn/show-sales-targets.md
[3]: create.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/target-settings.png
[img4]: ../../../../media/loc/en/sale/add-new-target-type-button.png
