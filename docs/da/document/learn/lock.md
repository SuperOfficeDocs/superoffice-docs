---
uid: help-da-document-lock
title: Indtjekning/udtjekning af dokumenter
description: Indtjekning/udtjekning af dokumenter
author: SuperOffice RnD
date: 06.29.2022
keywords: dokument
topic: howto
language: da
---

# Indtjekning/udtjekning af dokumenter

I SuperOffice CRM er der mange, der opretter, redigerer og læser dokumenter på et givet tidspunkt. Hvis flere brugere redigerer det samme dokument samtidig, risikerer de at overskrive hinandens data. For at forhindre at dette sker låser SuperOffice CRM et dokument, når det er redigeres af en bruger. Andre brugere kan stadig åbne dokumentet, men kun i læsetilstand.

> [!NOTE]
> Hvis din organisation bruger et dokumentbibliotek som SharePoint, kan flere personer redigere et dokument samtidigt.

## Hvordan ved jeg, hvornår et dokument er tjekket ud?

I dialogboksen **Dokument** har et udtjekket dokument et af følgende ikoner:

![ikon][img3] Dokumentet er i øjeblikket tjekket ud til redigering af dig.

![ikon][img4] Dokumentet er i øjeblikket tjekket ud til redigering af en anden bruger.

Hold musemarkøren over et ikon for at vise oplysninger om den bruger, der har tjekket dokumentet ud.

Hvis du prøver at åbne et udtjekket dokument, vises en dialogboks med oplysninger om, hvem der har tjekket dokumentet ud. Du kan kun åbne dokumentet i læsetilstand.

## Tjek et dokument ud til redigering

Åbn et dokument og vælg at [redigere dokumentet][1]. Dokumentet er tjekket ud til redigering af dig. Andre brugere kan kun åbne dokumentet i læsetilstand.

## Tjek et dokument ind efter redigering

I de fleste tilfælde kan du [gemme og lukke dokumentet][1] i programmet, hvorefter dokumentet tjekkes ind automatisk.

## Redigeringstilstand og læsetilstand

Som standard åbnes et dokument i redigeringstilstand.

> [!NOTE]
> Hvis du foretrækker at vælge læsetilstand eller redigeringstilstand, når du åbner et dokument, skal du gå til ![ikon][img2]**Personlige indstillinger** &gt; Indstillinger**&gt;** **Funktioner** og indstille **Spørg før redigering eller læsning** til **Ja** ![.][img2]

* Redigeringstilstand: Dokumentet åbnes for redigering. Dokumentet kan ikke redigeres af andre brugere, indtil du gemmer og lukker det, hvorved dokumentet automatisk tjekkes ind.

> [!NOTE]
> Hvis du vil have et dokument tjekket ind automatisk, når du gemmer og lukker det, kan du aktivere indstillingen **Spørg om indtjekning, når redigeringen er afsluttet** i **Præferencer** i SuperOffice Web Tools.

* Læsetilstand: Dokumentet åbnes for læsning. Hvis du foretager ændringer i dokumentet, gemmes de ikke. For at [gemme dokumentet med ændringer][1] skal du oprette et nyt dokument i SuperOffice CRM og uploade filen med ændringerne.

## Afbrydelse af en udtjekning (hent gemt version)

> [!CAUTION]
> Hvis en anden bruger har tjekket et dokument ud, skal du altid kontakte brugeren, før du udfører denne procedure. Ellers er der risiko for, at du overskriver en andens ændringer, eller at den anden bruger overskriver dine ændringer, når de tjekker dokumentet ind
>
> Den bedste mulighed kan være at oprette en kopi af dokumentet og redigere kopien.

Hvis du eller en anden har tjekket et dokument ud, og du gerne vil redigere dokumentet kan du annullere udtjekningen:

1. Højreklik på dokumentet, og vælg **Dokument**.
2. På skærmbilledet Dokument skal du klikke på ![ikonet][img1] og vælge **Tilbage til gemt version**.

> [!NOTE]
Du skal have særlige rettigheder for at få adgang til dette alternativ. Du skal også have skriveadgang til dokumentet.

<!-- Referenced links -->
[1]: edit.md

<!-- Referenced images -->
[img1]: ../../../media/icons/btn-menu.png
[img2]: ../../../media/icons/personal-settings-small.png
[img3]: ../../../media/icons/document-lock-editing.png
[img4]: ../../../media/icons/document-lock-locked.png
