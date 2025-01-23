---
uid: help-no-product-add-to-price-list
title: Legge til produkt i prislisten
description: Slik legger du til et produkt i prislisten
author: SuperOffice RnD
date: 02.23.2023
keywords: produkt, prisliste
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Legge til produkt i en prisliste

Når du har lagt til prislisten i SuperOffice Quote, vil du fylle den ut med produktene dine, slik at selgerne kan bruke dem når de oppretter et nytt tilbud.

Når produktene og produktinformasjonen er lagt til, kan selgerne bruke de samme prisopplysningene og følge rabattretningslinjene du har definert.

![Du kan legge til så mange produkter og tjenester i prislisten som du trenger -screenshot][img2]

## Trinn

I dialogboksen **Legg til / rediger produkt** legger du inn all informasjon om produktet, inkludert produktbildet.

1. [!include[Go to products](../includes/goto-products.md)]

1. I listen **Prisliste** velger du prislisten du vil legge til produkter i.

    [Hvordan legger jeg til en prisliste?][1]

1. Klikk på **Legg til** nederst i fanen. Dialogboksen **Legg til / rediger produkt** vises.

1. Skriv inn informasjon om produktet og legg til et bilde, som beskrevet nedenfor.

1. Merk av for **Inkluder i prisliste** for å gjøre produktet tilgjengelig i prislisten. Du bør ikke gjøre dette før du har lagt inn all nødvendig informasjon om produktet.

1. Klikk på **Lagre + ny** for å lagre dette produktet og legge til et produkt til.
    Klikk på **Lagre** for å lagre og lukke dialogboksen.
    Produktet legges til i prislisten.

> [!NOTE]
> Du kan også [importere produkter fra et regneark][5].

## Legge til bilde

Se [Velge produktbilde][2].

## Legge til beskrivelse

I feltet til venstre kan du angi en beskrivelse av produktet.

## Legge til produktinformasjon

I listen til høyre kan du legge til produktinformasjon. Dette kan være følgende:

* Tekstfelt: Her angir du tekst og tall, for eksempel produktnavn, produktkoder og mva-informasjon.

* Tallfelt: Her angir du tall, for eksempel kostpris, minstepris og antall.

* Lister: Her velger du alternativer fra listen, for eksempel enhet, produkttype og produktgruppe. Du kan legge til flere alternativer på disse listene i bildet **Lister** [Legge til forekomster i en liste][4].

* Lister med søkemuligheter: Her kan du velge fra lister med nylige oppføringer, skrive inn tekst for å starte et søk eller klikke på søkeknappen (<i class="ph ph-magnifying-glass" aria-hidden="true"></i>) for å starte et avansert søk.

### Slik endrer du navn og rekkefølge, og gjøre felt redigerbare og/eller obligatoriske

I dialogboksen [Konfigurer produkt][3] definerer du rekkefølgen og navnet på feltene som vises her, og om de er redigerbare eller obligatoriske.

Du kan eventuelt overstyre innstillingene for redigerbar eller obligatorisk ved å merke av for **Overstyr standard sikkerhet** nederst i dialogboksen **Legg til / rediger produkt**. Endringene vil bare gjelde for det aktuelle produktet.

### Vises alle disse feltene i SuperOffice CRM?

[!include[Why set all fields when creating product](../includes/quote-config-product.md)]

For å finne ut hvilke felt som vises, kan du gå til fanen**Innstillinger** og klikke på **Konfigurer produkt** (se [Konfigurere produkter][3]).

<!-- Referenced links -->
[1]: add-price-list.md
[2]: select-product-image.md
[3]: configure.md
[4]: ../../../../admin/lists/learn/adding-items.md
[5]: ../../../../admin/import/learn/import-products-from-excel.md

<!-- Referenced images -->
[img2]: ../../../../../media/loc/en/quote/add-products-to-price-list.png
