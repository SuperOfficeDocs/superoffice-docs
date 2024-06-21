---
uid: help-da-importing-files
title: Import af data
description: Import af data
author: SuperOffice RnD
date: 06.29.2022
keywords: Indstillinger for Windows-klient
topic: help
language: da
client: win
envir: onsite
---

# Importér en datafil til SuperOffice-databasen

Når du har sikkerhedskopieret databasefilen, fundet den rigtige datafil og placeret den i en mappe, hvor du nemt kan finde den igen (se [Importrutiner][1]), kan du starte selve importen.

> [!NOTE]
> Nogle programmer "låser" filer, de åbner, så andre programmer ikke kan få adgang til dem. Før du begynder importen, skal du kontrollere, at hverken importbeskrivelsesfilen eller datafilen er åbne i noget andet program (f.eks. Excel).

**Trin:**

<!-- markdownlint-disable-file MD029 -->
1. [!include[How to open import](includes/open-import.md)]

[!include[Import description](includes/step-import-description.md)]
<!-- Include covers steps 2-3. Next line MUST be 4. -->

4. Når du har valgt en importbeskrivelse, og importfilen er fundet, udfyldes de andre felter automatisk. Du kan også vælge at [redigere detaljerne i importbeskrivelsen][3].

5. Det kan være nyttigt at kontrollere, at indholdet af felterne stemmer overns med de felter, du har valgt. Indholdet af den første post i den datafil, du importerer, vises i kolonnen **Felt i fil** under **Felttilknytning**, mens kolonnen **Felt i SuperOffice CRM** viser, hvilke felter i SuperOffice-databasen disse data importeres til. Klik på knappen **Næste** et par gange for også at kontrollere indholdet af nogle af de efterfølgende poster.

    > [!NOTE]
    > Hvis felterne ikke vises som obligatoriske, skal du enten ændre [felttilknytningen][4] eller foretage de nødvendige ændringer i importfilen.

6. Klik på **Start** for at starte importen. Statuslinjen vises nederst på skærmbilledet.

> [!NOTE]
> Den tid, det tager at importere data fra importfilen til SuperOffice-databasen, afhænger af databasens størrelse og dataforbindelsen (langsom eller hurtig forbindelse til databaseserveren). Du kan dog til enhver tid annullere importen ved at klikke på knappen **Stop** til højre for statusindikatoren.

<!-- Referenced links -->
[1]: import-routines.md
[3]: editing-import-descriptions.md
[4]: field-mapping.md

<!-- Referenced images -->
