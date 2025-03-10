---
uid: help-da-project-status
title: Projektstatus
description: Lær, hvordan du tilføjer en ny projektstatus i SuperOffice CRM. Opret og administrer foruddefinerede statusser for at spore projektfaser og effektivisere arbejdsprocesser.
keywords: tilføj projektstatus, projektstatus, projekt, listen Projekt - Status
author: Bergfrid Dias
date: 03.07.2025
version: 10.5.2
topic: howto
license: salespremium, servicepremium, marketingessentials
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Projektstatus

[!include[Must be admin](../../learn/includes/req-admin.md)]

Feltet **Status** i projektkortet hjælper med at kategorisere og spore et projekts fremgang. Disse statusser er foruddefineret i listen **Projekt - Status**, som du kan administrere i **Indstillinger og vedligeholdelse** under **Lister**.

Statusser kan knyttes til [projekttyper][1], hvilket angiver, hvilke statusser der er tilgængelige for hver type. Hvis der ikke er defineret en projektguide, er feltet **Status** stadig synligt på projektet, så brugere kan se og opdatere projektets nuværende status.

## Tilføj en status

1. Vælg <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lister** i navigatoren.

1. Vælg **Projekt - Status** fra dropdown-menuen. Fanen **Elementer** viser alle eksisterende statusser.

1. Klik på **Tilføj** for at åbne dialogboksen **Rediger listeelement**.

1. Indtast navnet på den nye status i feltet **Navn**. *(Obligatorisk)*

    Dette navn vil fremgå af feltet **Status** i projektkortet.

1. *(Valgfrit)* Tilføj en beskrivelse i feltet **Beskrivelse** for at forklare statusens formål.

1. Klik på **Gem** for at anvende dine ændringer eller **Afbryd** for at fortryde dem.

## Rediger eller slet en status

1. Følg trin 1–2 i **Tilføj en status** for at få adgang til listen **Projekt - Status**.

1. For at redigere:
    1. Dobbeltklik på den ønskede status for at åbne dialogboksen **Rediger listeelement**.
    1. Opdater felterne efter behov, og klik på **Gem**.

1. For at slette:
   1. Vælg status i listen, og klik på **Slet**.

    > [!CAUTION]
    > Hvis du sletter en status, fjerner du den fra alle tilknyttede projekttyper og projektguider. Sørg for, at den ikke er i brug, før du fortsætter.

## Gendan en slettet projektstatus

Hvis en projektstatus er blevet slettet, kan du gendanne den fra listen **Projekt - Status**. Dog vil en gendannelse ikke automatisk genetablere forbindelserne mellem det gendannede element og relaterede projekttyper eller guider. Disse forbindelser skal genoprettes manuelt, hvis det er nødvendigt.

Trinnene ligner [gendannelse af en slettet projekttype][2].

## Relateret indhold

* [Tilføj eller opdater projekttyper][1]
* [Opret en projektguide][3]
* [Rediger en projektguide][4]
* [Flyt projekt til næste status][5]

<!-- Referenced links -->
[1]: project-type.md
[2]: project-type.md#restore
[3]: create-project-guide.md
[4]: edit-project-guide.md
[5]: ../learn/project-guides.md#change-status
