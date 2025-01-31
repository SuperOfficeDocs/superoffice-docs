---
uid: help-no-project-guide-edit
title: Rediger eller deaktiver prosjektguide
description: Lær hvordan du redigerer pg deaktiverer prosjektguider i SuperOffice CRM. Endre statuser, oppfølginger og dokumenter, eller fjern guider for spesifikke prosjekttyper med mulighet for reaktivering.
keywords: redigere prosjektguide, oppdatere prosjektguide, deaktivere prosjektguide, prosjektguide, guide, arbeidsflyt, prosjekt
author: Bergfrid Dias
date: 01.31.2025
version: 10.5
topic: howto
license: salespremium, servicepremium, marketingessentials
audience: settings
audience_tooltip: Innstillinger og vedlikehold
language: no
---

# Rediger eller deaktiver prosjektguide

[!include[Må være administrator](../../learn/includes/req-admin.md)]

## Rediger en prosjektguide

1. Velg <i class="ph ph-arrows-left-right" aria-hidden="true"></i> **Arbeidsflyt** i navigatoren.
1. Gå til fanen **Prosjektguide**.
1. Velg ønsket prosjekttype fra listen øverst.
1. [Rediger informasjon om prosjekttypen og tilhørende statuser][3].
1. [Rediger de enkelte statusene][3].
1. Rediger oppfølginger og dokumenter ved å dobbeltklikke på dem i listene nederst.

    * [Legg til en oppfølging for en status][2]
    * [Legg til et dokument for en status][1]

    Endringene lagres automatisk.

## Deaktiver en prosjektguide

For å fjerne en prosjektguide fra en [prosjekttype][4], gjør følgende:

1. Velg <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lister** i navigatoren.

1. Velg **Prosjekt - Type, status** fra menyen. Fanen **Elementer** viser alle eksisterende prosjekttyper.

1. Dobbeltklikk på prosjekttypen som er knyttet til guiden du vil deaktivere. Dialogboksen **Rediger listeelement** åpnes.

1. Fjern merkingen for **Denne prosjekttypen er tilknyttet en guide**.

1. (Valgfritt) Oppdater andre felter ved behov.

1. Klikk **Lagre** for å bekrefte endringene eller **Avbryt** for å forkaste dem.

> [!NOTE]
> Hvis du senere vil bruke prosjektguiden igjen, kan du merke av for dette alternativet på nytt. Eventuelle oppfølginger og dokumenter som tidligere var lagt til i prosjektguidens statuser, blir automatisk hentet inn igjen ved reaktivering. Du kan også legge til nye oppfølginger og dokumenter eller fjerne de som ikke lenger er relevante.

<!-- Refererte lenker -->
[1]: create-project-guide.md#add-doc-status
[2]: create-project-guide.md#add-fo-status
[3]: project-status.md
[4]: project-type.md
