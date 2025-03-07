---
uid: help-da-sale-stage-add
title: Tilføjelse af en salgsfase
description: Lær, hvordan du opretter en ny salgsfase i SuperOffice CRM. Definer sandsynligheder og tilknyt faser til salgstyper for at strukturere salgsprocesser effektivt.
keywords: tilføj salgsfase, ny salgsfase, Salg – Fase-liste, salgsfase, fase, salg
author: SuperOffice RnD
date: 03.07.2025
version: 10.5
topic: howto
license: salesessentials
audience: settings
audience_tooltip: Indstillinger og vedligeholdelse
language: da
---

# Salgsfase

[!include[Kræver administratorrettigheder](../../learn/includes/req-admin.md)]

Feltet **Fase** på salgskortet angiver, hvor et salg befinder sig i salgsprocessen, f.eks. **Åben**, **Solgt** eller **Tabt**. Disse faser er foruddefinerede i listen **Salg – Fase**, som kan administreres i **Indstillinger og vedligeholdelse** under **Lister**.

Faser kan tilknyttes [salgstyper][1] for at angive, hvilke faser der er tilgængelige for hver type. Hvis der ikke er defineret en salgsguide, forbliver feltet **Fase** synligt i salget, så brugerne kan se og opdatere den aktuelle salgsfase.

## Tilføj en salgsfase

1. Vælg <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lister** i Navigator.

1. Vælg **Salg – Fase** fra rullemenuen. Fanen **Forekomster** viser alle eksisterende faser.

1. Klik på **Tilføj** for at åbne dialogboksen **Rediger listeforekomst**.

1. I feltet **Navn** skal du indtaste navnet på den nye fase. *(Obligatorisk)*

    Dette navn vil blive vist i feltet **Fase** i skærmbilledet Salg.

1. I feltet **Sandsynlighed** skal du angive sandsynligheden for, at et salg bliver succesfuldt i denne fase, som en procentdel.

    Denne procent vil blive vist ved siden af fasen i skærmbilledet Salg.

1. *(Valgfrit)* Tilføj en beskrivelse i feltet **Beskrivelse** for at forklare fasens formål.

1. Klik på **Gem** for at anvende dine ændringer, eller klik på **Annuller** for at fortryde dem.

## Rediger eller slet en salgsfase

1. Følg trin 1–2 i **Tilføj en salgsfase** for at få adgang til listen **Salg – Fase**.

1. For at redigere:
   1. Dobbeltklik på den ønskede fase for at åbne dialogboksen **Rediger listeforekomst**.
   1. Opdater felterne efter behov, og klik på **Gem**.

1. For at slette:
   1. Vælg fasen på listen, og klik på **Slet**.

    > [!CAUTION]
    > Sletning af en fase fjerner den fra alle tilknyttede salgstyper og salgsguider. Sørg for, at den ikke er i aktiv brug, før du fortsætter.

## Gendan en slettet salgsfase

Hvis en salgsfase er blevet slettet, kan du gendanne den fra listen **Salg – Fase**. Bemærk dog, at gendannelse ikke automatisk genopretter eventuelle links mellem den gendannede fase og tilknyttede salgstyper eller salgsguider. Disse forbindelser skal genskabes manuelt.

Trinene er de samme som ved [gendannelse af en slettet salgstype][2].

## Relateret indhold

* [Tilføj eller opdater salgstyper][1]
* [Opret en salgsguide][3]
* [Rediger en salgsguide][4]
* [Spor salgsudvikling][5]

<!-- Referenced links -->
[1]: sale-type.md
[2]: sale-type.md#restore
[3]: create-sales-guide.md
[4]: edit-sales-guide.md
[5]: ../learn/sales-guides.md#change-stage
