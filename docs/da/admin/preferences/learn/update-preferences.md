---
uid: help-da-preferences-manage
title: Arbejde med præferencer
description: Sådan tilføjes, redigeres og slettes præferenceindstillinger.
author: Bergfrid Dias
date: 03.21.2023
keywords: præference, indstilling
topic: howto
language: da
---

# Arbejde med præferencer

## Gå til den præference, du vil opdatere

1. [!include[Open preferences](includes/open-preferences.md)]
2. Vælg den ønskede præferencegruppe på rullemenuen øverst.
3. Marker den ønskede præference på listen **Præferencer**.

    I feltet **Aktive indstillinger** vises de indstillinger, der allerede er defineret for denne præference. Hvis feltet er tomt, kan det skyldes, at du ikke har markeret visning af alle niveauer.

> [!TIP]
> Brug feltet for **fritekstsøgning** øverst i skærmbilledet for at finde den præference, du vil ændre. Søgeresultaterne vises i listen nedenunder.

## Tilføjelse af præferenceindstillinger

1. Gå til den præference, du vil tilføje en ny indstilling for.

1. Klik på **Tilføj** nederst i vinduet.

1. I dialogboksen **Indstilling** under **Denne indstilling gælder for** skal du vælge, [hvilket niveau][2] indstillingen skal gælde for – hele systemet, én database, én brugergruppe eller en enkelt bruger.

    > [!NOTE]
    > Hvis et eller flere alternativer er deaktiveret, kan du ikke vælge denne indstilling for dem.

1. Vælg navnet på den ønskede database, gruppe eller bruger i overensstemmelse med, hvad du valgte ovenfor.

    > [!NOTE]
    > Hvis du har valgt **System**, udfyldes feltet **Mål** automatisk, da der kun er ét system.

1. Navnet på feltet under **Værdi** varierer afhængigt af, hvilken præference der gælder. Her angiver du værdien for indstillingen ved at indtaste en værdi i feltet, vælge fra en foruddefineret liste eller markere et afkrydsningsfelt eller lignende afhængigt af, hvilken præferencetype det drejer sig om.

1. Hvis du har valgt et højere niveau end det lavest mulige under **Denne indstilling gælder for**, kan du markere **Fjern indstillinger på lavere niveau** nederst i dialogboksen, hvis du vil fjerne indstillingerne på alle lavere niveauer. Denne nye indstilling vil da tilsidesætte de indstillinger, der er angivet for lavere niveauer.

1. Klik på **Gem**. Indstillingen bliver tilgængelig for brugerne, næste gang de logger på SuperOffice.

> [!NOTE]
> Præferencer med aktive individuelle indstillinger vises med fed skrift på præferencelisten.

## <a id="edit"></a>Redigering af præferenceindstilling

1. Gå til den præference, du vil opdatere.

1. Dobbeltklik på den indstilling, du vil ændre.

1. Opdater felterne efter behov.

1. Klik på **Gem**. Indstillingen bliver tilgængelig for brugerne, næste gang de logger på SuperOffice.

    > [!NOTE]
    > Hvis du ikke vil gemme ændringerne alligevel, kan du klikke på **Afbryd**.

## <a id="personal"></a>Tillad brugerindstillinger

1. Gå til den indstilling, du vil gøre tilgængelig, i menuen **Personlige indstillinger**.

1. Markér **Tillad brugerindstillinger**. Præferencen vises derefter i dialogboksen **Præferencer**, og hver person kan redigere indstillingerne til eget brug.

> [!NOTE]
> Indstillinger på brugerniveau er ikke tilgængelige for alle præferencer.

## Sletning af præferenceindstilling

1. Gå til den præference, du vil slette en ny indstilling for.

1. Marker en eller flere indstillinger, som du ønsker at slette, og klik på **Slet** nederst i vinduet. Alle de markerede indstillinger slettes fra listen.

<!-- Referenced links -->
[2]: index.md#levels

<!-- Referenced images -->
