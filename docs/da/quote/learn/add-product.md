---
uid: help-da-quote-add-products
title: Tilføj produkter, der skal med i tilbuddet
description: Tilføj produkter, der skal med i tilbuddet
author: SuperOffice RnD
date: 07.04.2022
keywords: tilbud
topic: howto
language: da
---

# Tilføj produkter

I dialogboksen **Tilføj/rediger produkt** kan du tilføje et produkt og angive antal, rabatter og andre produktoplysninger.

## Tilføj et produkt

1. Åbn et tilbud, og klik på **Tilføj** nederst på fanen **Produkter** (eller et alternativ, du har oprettet).

1. Dobbeltklik på et produkt i tilbuddet.

1. Hvis du vil søge i en bestemt prisliste, kan du vælge den på listen ud for feltet **Produktsøgning** .

1. Begynd at skrive navnet på produktet eller produktkoden i feltet **Produktsøgning** . Resultatlisten opdateres automatisk. Du kan søge på hele eller dele af både produktnavnet og produktkoden.

    > [!TIP]
    > Hvis avanceret søgning understøttes, kan du klikke på <i class="ph ph-magnifying-glass" aria-label="Search icon"></i> i feltet **Produktsøgning** for at søge efter og [tilføje flere produkter samtidigt](#add-multiple).

1. Klik på det ønskede produkt på listen. Dialogboksen opdateres med produktinformation.

1. Rediger produktantal, rabat og samlet pris, hvis det er nødvendigt. Se detaljer nedenfor.

1. Læs og rediger eventuelle produktoplysninger under fanerne **Beskrivelse** og **Detaljer** .

1. Klik på **Gem + ny** for at gemme dette produkt og tilføje et nyt produkt
    eller
    Klik på **Gem** for at gemme og vende tilbage til tilbuddet.

## <a id="add-multiple"></a>Tilføjelse af flere produkter i et tilbud

1. Klik på **Tilføj** nederst på fanen **Produkter** i dialogboksen **Rediger tilbud for**.

2. Begynd at skrive et produktnavn i feltet **Produktsøgning** for at søge efter et produkt. Klik på <i class="ph ph-magnifying-glass" aria-label="Search icon"></i> for at søge efter produkter ved hjælp af mange forskellige kriterier, for eksempel efter sortiment produktgrupper/kategorier, navn, varekoder osv. Søgningen omfatter alle aktive prislister med den aktuelle valuta.

3. Når du har fundet de produkter, du vil tilføje tilbuddet, markerer du dem (**Ctrl+klik**), og klikker på **OK**. Produkterne vises på fanen **Produkter** (eller på fanen for det alternativ, du har oprettet).

4. Dobbeltklik på et produkt for at ændre mængde, rabatter osv.

## Rediger antal, rabatter og priser for et produkt

I området til venstre for dialogboksen **Tilføj/rediger produkt**, vises produktnavnet /koden, og her kan du indtaste et antal og eventuelle rabatter for det valgte produkt.

> [!TIP]
> Du kan få vist flere oplysninger om de forskellige felter (feltnavn, redigerbart felt og beregninger) ved at holde musemarkøren over dem.

* Tal vist med sort kan redigeres.
* Det samlede beløb og rabatterne opdateres, når du redigerer de forskellige felter.
* En rabat kan angives enten som en procentsats, et rabatbeløb eller et samlet beløb.
  * Det rabatfelt, du redigerede, vises *understreget*.
  * De andre felter opdateres, så de svarer til den rabat, du har defineret.
  * Hold musemarkøren over et rabatfelt for at få vist eventuelle systemrabatter (f.eks. mængderabatter, der tilføjes automatisk).
* Hvis du har angivet rabatter, der ikke er tilladt af systemet, vises en advarsel eller en anden meddelelse.

## Fanen Billede

Et billede af produktet vises her, hvis dette er defineret i Indstillinger og vedligeholdelse.

## Fanen Beskrivelse

Detaljerede produktoplysninger vises her, hvis dette er defineret i Indstillinger og vedligeholdelse.

## Fanen Detaljer

Detaljerede prisberegninger vises her. Indholdet på denne fane er defineret i Indstillinger og vedligeholdelse.

## <a id="warning"></a>Advarsler og hvordan man håndterer dem

Under Indstillinger og vedligeholdelse kan der defineres forskellige regler for, hvad der er tilladt og ikke tilladt, når du føjer produkter til et tilbud. Afhængigt af hvordan disse regler er defineret, vises der muligvis forskellige ikoner/advarsler, når du føjer produkter til et tilbud. I nogle tilfælde skal tilbuddet [godkendes inden afsendelse][1].

> [!NOTE]
> Produkter føjes til og gemmes i et tilbud, selvom der vises advarsler og andre meddelelser, men du kan ikke sende tilbuddet, så længe det indeholder fejl og advarsler. Du skal enten rette fejlen eller få tilbuddet godkendt.

[!include[Table showing quote icons](includes/table-quote-icons.md)]

### Hvor vises disse advarsler og meddelelser?

* I dialogboksen **Tilføj/rediger produkt**
* I dialogboksen **Rediger tilbud**
* På produktlinjer under detaljekortet **Tilbud** og fanen **Produkter** (og alternativer) i et tilbud

### Hvad forårsager disse advarsler og meddelelser?

Advarsler og meddelelser kan f.eks. skyldes:

* Produkter, der ikke er omfattet af sortimentet
* Inaktive prislister
* Produktprisen er under minimumsprisen eller kostprisen
* Samlet pris er nul eller negativ
* Den samlede rabat er for høj
* Den samlede indtjening er for lav

<!-- Referenced links -->
[1]: approve.md
