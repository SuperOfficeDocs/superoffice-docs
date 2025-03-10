---
uid: help-da-project-guide-edit
title: Rediger eller deaktiver en projektguide
description: Lær, hvordan du redigerer eller deaktiverer projektguider i SuperOffice CRM. Tilpas statusser, opfølgninger og dokumenter, eller fjern guiden fra specifikke projekttyper med mulighed for genaktivering.
keywords: rediger projektguide, opdater projektguide, deaktiver projektguide, projektguide, guide, workflow, projekt
author: Bergfrid Dias
date: 03.07.2025
version: 10.5.2
topic: howto
license: salespremium, servicepremium, marketingessentials
audience: settings
audience_tooltip: Indstillinger og vedligeholdelse
language: da
---

# Rediger eller deaktiver en projektguide

[!include[Skal være administrator](../../learn/includes/req-admin.md)]

## Rediger en projektguide

1. Vælg <i class="ph ph-arrows-left-right" aria-hidden="true"></i> **Workflow** i navigatoren.
1. Vælg fanen **Projektguide**.
1. Vælg den ønskede projekttype fra listen øverst.
1. [Rediger oplysninger om projekttypen og dens statusser][3].
1. [Rediger de enkelte statusser][3].
1. Rediger opfølgninger og dokumenter ved at dobbeltklikke på dem på listerne nederst.

    * [Tilføj en opfølgning for en status][2]
    * [Tilføj et dokument til en status][1]

    Ændringerne gemmes automatisk.

## Deaktiver en projektguide

Hvis du vil fjerne en projektguide fra en [projekttype][4], skal du følge disse trin:

1. Vælg <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lister** i navigatoren.

1. Vælg **Projekt – Type, Status** fra rullemenuen. Fanen **Elementer** viser alle eksisterende projekttyper.

1. Dobbeltklik på den projekttype, der er knyttet til guiden, du vil deaktivere. Dialogboksen **Rediger listeelement** åbnes.

1. Fjern markeringen i **Denne projekttype er knyttet til en guide**.

1. (Valgfrit) Opdater andre felter efter behov.

1. Klik på **Gem** for at anvende ændringerne eller **Afbryd** for at annullere dem.

> [!NOTE]
> Hvis du senere ønsker at genbruge projektguiden, skal du blot markere denne mulighed igen. Alle tidligere tilføjede opfølgninger og dokumenter til projektguidens statusser vil automatisk blive hentet ved genaktivering. Du kan også tilføje nye opfølgninger og dokumenter eller slette dem, der ikke længere er relevante.

<!-- Referenced links -->
[1]: create-project-guide.md#add-doc-status
[2]: create-project-guide.md#add-fo-status
[3]: project-status.md
[4]: project-type.md
