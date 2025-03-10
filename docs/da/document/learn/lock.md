---
uid: help-da-document-lock
title: Indtjekning/udtjekning af dokumenter
description: Indtjekning/udtjekning af dokumenter
keywords: dokument, indtjek, udtjek, tilbage til gemt version, redigeringstilstand, læsetilstand, spørg før redigering eller læsning
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
topic: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Indtjekning/udtjekning af dokumenter

I SuperOffice CRM er der mange, der opretter, redigerer og læser dokumenter på et givet tidspunkt. Hvis flere brugere redigerer det samme dokument samtidig, risikerer de at overskrive hinandens data. For at forhindre at dette sker låser SuperOffice CRM et dokument, når det er redigeres af en bruger. Andre brugere kan stadig åbne dokumentet, men kun i læsetilstand. (Hvis din organisation bruger et dokumentbibliotek som SharePoint, kan flere personer redigere et dokument samtidigt.)

## Redigeringstilstand og læsetilstand

* Redigeringstilstand: Dokumentet åbnes for redigering. Dokumentet kan ikke redigeres af andre brugere, indtil du gemmer og lukker det, hvorved dokumentet automatisk tjekkes ind.

    Hvis du vil have et dokument tjekket ind automatisk, når du gemmer og lukker det, kan du aktivere indstillingen **Spørg om indtjekning, når redigeringen er afsluttet** i **Præferencer** i SuperOffice Web Tools.

* Læsetilstand: Dokumentet åbnes for læsning. Hvis du foretager ændringer i dokumentet, gemmes de ikke. For at [gemme dokumentet med ændringer][1] skal du oprette et nyt dokument i SuperOffice CRM og uploade filen med ændringerne.

Som standard åbnes et dokument i redigeringstilstand. Hvis du foretrækker at vælge læsetilstand eller redigeringstilstand, når du åbner et dokument, skal du gå til <i class="ph ph-user-circle" aria-hidden="true"></i> **Personlige indstillinger** > **Indstillinger** > **Funktioner** og indstille **Spørg før redigering eller læsning** til **Ja**.

## Hvordan ved jeg, hvornår et dokument er tjekket ud?

I dialogboksen **Dokument** viser et udtjekket dokument en banner med information om, hvem der redigerer det.

<i class="ph ph-warning-circle" aria-label="Warning icon"></i> **Du** redigerer dette dokument.

<i class="ph ph-warning-circle" aria-label="Warning icon"></i> Du kan ikke redigere dette dokument, fordi det er låst af **NN**.

## Tjek et dokument ud til redigering

Åbn et dokument og vælg at [redigere dokumentet][1]. Dokumentet er tjekket ud til redigering af dig. Andre brugere kan kun åbne dokumentet i læsetilstand.

## Tjek et dokument ind efter redigering

I de fleste tilfælde kan du [gemme og lukke dokumentet][1] i programmet, hvorefter dokumentet tjekkes ind automatisk.

## Afbrydelse af en udtjekning (hent gemt version)

Du skal have særlige rettigheder for at få adgang til dette alternativ. Du skal også have skriveadgang til dokumentet.

> [!CAUTION]
> Hvis en anden bruger har tjekket et dokument ud, skal du altid kontakte brugeren, før du udfører denne procedure. Ellers er der risiko for, at du overskriver en andens ændringer, eller at den anden bruger overskriver dine ændringer, når de tjekker dokumentet ind
>
> Den bedste mulighed kan være at oprette en kopi af dokumentet og redigere kopien.

Hvis du eller en anden har tjekket et dokument ud, og du gerne vil redigere dokumentet kan du annullere udtjekningen:

1. Højreklik på dokumentet, og vælg **Dokument**.
2. På dialogboksen Dokument skal du klikke på <i class="ph ph-dots-three-circle-vertical" aria-label="Opgave-knappen"></i> og vælge **Tilbage til gemt version**.

<!-- Referenced links -->
[1]: edit.md
