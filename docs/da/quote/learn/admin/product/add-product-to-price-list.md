---
uid: help-da-product-add-to-price-list
title: Føj produkt til prisliste
description: Sådan føjer du et produkt til prisliste
author: SuperOffice RnD
date: 02.23.2023
keywords: produkt, prisliste
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Føj produkt til en prisliste

Når du har tilføjet din prisliste til SuperOffice Quote, vil du udfylde den med dine produkter, så dine sælgere kan bruge dem, når de opretter et nyt salgsforslag.

Når dine produkter og produktoplysningerne er tilføjet, kan dine sælgere bruge de samme prisoplysninger og følge de rabatretningslinjer, du har oprettet.

![Du kan tilføje så mange produkter og tjenester til din prisliste, som du har brug for -screenshot][img2]

## Trin

I dialogboksen **Tilføj/rediger produkt** skal du indtaste alle oplysninger om et produkt herunder et billede.

1. [!include[Go to products](../includes/goto-products.md)]

1. Vælg den prisliste, du vil føje produkter til, på **listen Prisliste** .

    [Hvordan tilføjer jeg en prisliste?][1]

1. Klik på **Tilf‹j** nederst på fanen. Dialogboksen **Tilføj/rediger produkt** vises.

1. Indtast oplysninger om produktet, og tilføj et billede som beskrevet nedenfor.

1. Markér **Medtag i prisliste** for at gøre produktet tilgængeligt på prislisten. Du bør ikke gøre dette, før du har indtastet alle de nødvendige oplysninger om produktet.

1. Klik på **Gem + ny** for at gemme dette produkt og tilføje et nyt produkt.
    Klik på **Gem** for at gemme og lukke dialogboksen.
    Produktet føjes til prislisten.

> [!NOTE]
> Du kan også [importere produkter fra et regneark][5].

## Tilføj billede

Se [Tilføj et produktbillede][2].

## Til beskrivelse

I feltet til venstre kan du indtaste en kort beskrivelse af produktet.

## Tilføj produktinformation

På listen til højre kan du tilføje produktinformation. Dette kan omfatte:

* Tekstfelt: Her indtaster du tekst og tal, såsom et produktnavn, produktkode og momsoplysninger.

* Talfelt: Her indtaster du et tal, såsom kostpris, minimumspris og antal.

* Lister: Her vælger du alternativer fra listen såsom enheder, produkttype og produktgruppe. Du kan føje flere alternativer til disse lister på skærmbilledet **Lister** [Føj elementer til en liste][4].

* Lister med søgemuligheder: Her kan du vælge fra listen over seneste poster, indtaste tekst for at starte en søgning eller klikke på søgeknap (<i class="ph ph-magnifying-glass" aria-hidden="true"></i>) for at starte en avanceret søgning.

### Sådan ændrer du navn og rækkefølge og gør felter redigerbare og/eller obligatoriske

I dialogboksen [Konfigurer produkt][3] definerer du rækkefølgen og navnet på det felt, der vises her, og om de kan redigeres eller er obligatoriske.

Du kan tilsidesætte de redigerbare og obligatoriske indstillinger ved at markere **Tilsidesæt standardsikkerhed** nederst i dialogboksen **Tilføj/rediger produkt** . Ændringerne gælder kun for dette ene produkt.

### Vises alle disse felter i SuperOffice CRM?

[!include[Why set all fields when creating product](../includes/quote-config-product.md)]

Du kan finde ud af, hvilke felter der vises, ved at gå til fanen **Indstillinger** og klikke på **Konfigurer produkt** (se [Konfigurer produkter][3]).

<!-- Referenced links -->
[1]: add-price-list.md
[2]: select-product-image.md
[3]: configure.md
[4]: ../../../../admin/lists/learn/adding-items.md
[5]: ../../../../admin/import/learn/import-products-from-excel.md

<!-- Referenced images -->
[img2]: ../../../../../media/loc/en/quote/add-products-to-price-list.png
