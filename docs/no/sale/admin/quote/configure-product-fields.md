---
uid: help-no-product-fields-configure
title: Konfigurer felter i Legg til/rediger produkt-dialogen
description: Lær hvordan du kontrollerer hvilke felter som vises i Legg til/rediger produkt-dialogen, og hvordan de oppfører seg.
keywords: Konfigurer produktdialog, Legg til/rediger produkt, konfigurer produkt, produktdialog, produktfelt, ledetekst, produkt, tilbud
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: salespremium
audience: settings
audience_tooltip: Settings and maintenance
language: no
redirect_from: /no/quote/learn/admin/product/configure
index: true
---

# Konfigurer felter i Legg til/rediger produkt-dialogen

Bruk dialogboksen **Konfigurer produkt** for å kontrollere hvilke felter som vises når brukere legger til eller redigerer et produkt i et tilbud. Du kan vise eller skjule felter, endre ledetekster, definere hjelpetekster og gjøre felter redigerbare og/eller obligatoriske.

Disse innstillingene gjelder globalt for alle ERP-koblinger via quote connector og påvirker to dialogbokser:

* **Legg til/rediger produkt (bruker):** Vises når brukere legger til produkter i tilbudslinjer.
* **Legg til/rediger produkt (admin):** Brukes i fanen **SuperOffice-produkter** når administratorer legger til produkter i en prisliste.

## Trinn

1. Gå til **Innstillinger og vedlikehold**, og velg <i class="ph ph-barcode" aria-label="Barcode icon"></i> **Tilbud/Sync** i navigatoren.

1. Gå til fanen **Innstillinger**.

1. Klikk på **Konfigurer produkt**.

    ![Dialogboksen Konfigurer produkt -screenshot][img1]

1. Velg språket du vil konfigurere. Du kan tilpasse ledetekster og hjelpetekster per språk.

1. For hvert felt i listen:

    * **Vis feltet:** Angi om feltet skal være synlig i **Legg til/rediger produkt**-dialogen i tilbud. Felter vises alltid i Innstillinger og vedlikehold. Enkelte felter er låst og kan ikke skjules.

        Bruk **Aktiver alle** eller **Deaktiver alle** for raskt å endre synligheten.

    * **Ledetekst:** Skriv inn et brukervennlig navn for feltet. La stå tomt for å bruke standardteksten.
    * **Hjelpetekst:** Legg til en kort hjelpetekst som vises når brukere holder musepekeren over feltet. Bruk rullefeltet om teksten er lang.
    * **Redigerbar:** Tillat at brukere kan endre verdien.
    * **Obligatorisk:** Krev at brukere fyller ut feltet i tilbudslinjen. Dette aktiverer automatisk **Redigerbar**.

        Du kan overstyre redigerbare og obligatoriske innstillinger per produkt. For systemstyrte felt er imidlertid disse innstillingene deaktivert både i dialogboksen **Konfigurer produkt** og i dialogboksen **Legg til/rediger produkt**.

    * **Rekkefølge:** Bruk opp/ned pilene <i class="ph ph-arrow-circle-up" aria-hidden="true"></i> <i class="ph ph-arrow-circle-down" aria-hidden="true"></i> for å endre feltets plassering i dialogboksen.

        Feltrekkefølgen påvirker begge dialoger, men noen felter har faste plasseringer i tilbuds og kan ikke flyttes.

1. Klikk på **OK** for å lagre endringene.

1. Gjenta eventuelt prosedyren for andre språk.

## Tips

* Du trenger ikke vise alle felt. Skjul felter som ikke skal fylles ut, for eksempel leverandørkode.
* Bruk beskrivende ledetekster og hjelpetekster for ekstrafelt.
* Endringer i ledetekster vises først etter neste innlogging.

## Relatert innhold

* [Legge til produkt i en prisliste][1]
* [Legge til/redigere produkter i tilbud][2]

<!-- Referenced links -->
[1]: price-list-and-products.md
[2]: ../../learn/quote/create.md#add-products

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/configure-product-dialog.png
