---
uid: help-da-sales-guide-edit
title: Rediger eller deaktiver en salgsguide
description: Lær, hvordan du redigerer en salgsguide i SuperOffice CRM, opdaterer faser og aktiviteter, eller deaktiverer en guide fra en salgstype.
keywords: rediger salgsguide, opdater salgsguide, deaktiver salgsguide, salgsguide, guide, workflow, salg
author: Bergfrid Dias
date: 03.07.2025
version: 10.5.2
topic: howto
license: salespremium
audience: settings
audience_tooltip: Indstillinger og vedligeholdelse
language: da
---

# Rediger eller deaktiver en salgsguide

[!include[Kræver administratorrettigheder](../../learn/includes/req-admin.md)]

## Rediger en salgsguide

1. Vælg <i class="ph ph-arrows-left-right" aria-hidden="true"></i> **Workflow** i Navigator.
1. Vælg fanen **Salgsguide**.
1. Vælg den ønskede salgstype fra rullemenuen **Salgstype**.
1. Klik på **Rediger**.
1. [Rediger de individuelle faser][3].
1. Rediger opfølgninger og dokumenter ved at dobbeltklikke på dem på listerne nederst.

   * [Tilføj en opfølgning til en fase][1]
   * [Tilføj et dokument til en fase][2]

   Ændringerne gemmes automatisk.

## Deaktiver en salgsguide

Hvis du vil fjerne en salgsguide fra en [salgstype][5], skal du følge disse trin:

1. Vælg <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lister** i Navigator.
1. Vælg **Salg - Salgstype (for faser)** fra rullemenuen. Fanen **Forekomster** viser alle eksisterende salgstyper.
1. Dobbeltklik på den salgstype, der er knyttet til guiden, du vil deaktivere. Dialogboksen **Rediger listeforekomst** åbnes.
1. Fjern markeringen i **Denne salgstype er tilknyttet en guide**.
1. *(Valgfrit)* Opdater andre felter efter behov.
1. Klik på **Gem** for at anvende ændringerne, eller klik på **Afbryd** for at fortryde dem.

> [!NOTE]
> Hvis du senere vil genbruge salgsguiden, skal du blot markere indstillingen igen. Alle opfølgninger og dokumenter, der tidligere er tilføjet til salgsguidens faser, hentes automatisk ved genaktivering. Du kan også tilføje nye opfølgninger og dokumenter eller fjerne dem, der ikke længere er relevante.

<!-- Referenced links -->
[1]: create-sales-guide.md#add-fo-stage
[2]: create-sales-guide.md#add-doc-stage
[3]: sale-stage.md
[5]: sale-type.md
