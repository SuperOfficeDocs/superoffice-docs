---
uid: help-da-product-fields-configure
title: Konfigurer felter i Tilføj/rediger produkt-dialogen
description: Lær, hvordan du styrer, hvilke felter der vises i Tilføj/rediger produkt-dialogen, og hvordan de fungerer.
keywords: Konfigurer produktdialog, Tilføj/rediger produkt, konfigurer produkt, produktdialog, produktfelt, ledetekst, produkt, tilbud
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: salespremium
audience: settings
audience_tooltip: Settings and maintenance
language: da
redirect_from: /da/quote/learn/admin/product/configure
index: true
---

# Konfigurer felter i Tilføj/rediger produkt-dialogen

Brug dialogboksen **Konfigurer produkt** til at styre, hvilke felter der vises, når brugere tilføjer eller redigerer et produkt i et tilbud. Du kan vise eller skjule felter, ændre ledetekster, definere værktøjstips samt gøre felter redigerbare og/eller obligatoriske.

Disse indstillinger gælder globalt for alle ERP-links via quote connector og påvirker to dialogbokse:

* **Tilføj/rediger produkt (bruger):** Vises, når brugere tilføjer et produkt til en tilbudslinje.
* **Tilføj/rediger produkt (admin):** Bruges i fanen **SuperOffice-produkter**, når administratorer tilføjer produkter til en prisliste.

## Trin

1. Gå til **Indstillinger og vedligeholdelse**, og vælg <i class="ph ph-barcode" aria-label="Barcode icon"></i> **Tilbud/Sync** i navigatoren.

1. Gå til fanen **Indstillinger**.

1. Klik på **Konfigurer produkt**.

    ![Dialogboksen Konfigurer produkt -screenshot][img1]

1. I dialogboksen vælger du det sprog, du vil konfigurere. Du kan tilpasse ledetekster og hjælpetekst for hvert sprog.

1. For hvert felt i listen:

    * **Vis felt:** Styr synligheden i **Tilføj/rediger produkt**-dialogen i tilbud. Felter vises altid i Indstillinger og vedligeholdelse. Nogle felter kan ikke skjules.

        Brug **Aktiver alle** eller **Deaktiver alle** for hurtigt at ændre synligheden.

    * **Ledetekst:** Indtast et brugervenligt navn for feltet. Lad det være tomt for at anvende standardteksten.
    * **Hjælpetekst:** Tilføj en kort hjælpetekst, der vises, når brugere holder musen over feltet. Brug rullefeltet, hvis teksten er lang.
    * **Redigerbar:** Tillad, at brugere kan ændre værdien.
    * **Obligatorisk:** Kræv, at brugere udfylder feltet i tilbudslinjen. Dette aktiverer automatisk **Redigerbar**.

        Du kan tilsidesætte redigerbare og obligatoriske indstillinger pr. produkt. For systemstyrede felter er disse indstillinger dog deaktiveret både i dialogboksen **Konfigurer produkt** og i dialogboksen **Tilføj/rediger produkt**.

    * **Rækkefølge:** Brug pil op/ned <i class="ph ph-arrow-circle-up" aria-hidden="true"></i> <i class="ph ph-arrow-circle-down" aria-hidden="true"></i> for at ændre feltets placering i dialogen.

        Rækkefølgen gælder begge dialoger, men visse felter har faste positioner i tilbudsvisningen og kan ikke flyttes.

1. Klik på **OK** for at gemme ændringerne.

1. Gentag eventuelt proceduren for flere sprog.

## Tips

* Ikke alle felter behøver at være synlige. Skjul felter som eksempelvis leverandørkode, der ikke skal udfyldes af brugere.
* Giv meningsfulde ledetekster og hjælpetekst for ekstra felter.
* Ændringer i ledetekster træder i kraft efter næste login.

## Relateret indhold

* [Føj produkt til en prisliste][1]
* [Tilføj/rediger et produkt i tilbuddet][2]

<!-- Referenced links -->
[1]: price-list-and-products.md
[2]: ../../learn/quote/create.md#add-products

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/configure-product-dialog.png
