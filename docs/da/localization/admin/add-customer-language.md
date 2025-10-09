---
uid: help-da-customer-language-add
title: Tilføj kundesprog
description: Få mere at vide om i denne guide, hvordan du konfigurerer kundesprog.
keywords: kundesprog, tilføje sprog, nyt kundesprog, sprogkode
author: digitaldiina
date: 10.09.2025
version: 11.5
content_type: howto
category: localization
topic: language
audience: settings
audience_tooltip: Settings and maintenance
redirect_from: /da/admin/options/learn/custlang/update
language: da
index: true
---

# Tilføj kundesprog

I skærmbilledet **Kundesprog** er der en liste over de installerede [kundesprog][2]. Fra dette skærmbillede kan du konfigurere kundesprog, så det bliver nemt at kommunikere med kunder på forskellige sprog.

For eksempel:

* Du kan have forskellige sprogversioner af SuperOffice Customer Centre, FAQ'er og svarskabeloner.
* Du kan angive et sprog for en person, så personen automatisk modtager svarskabeloner på dette sprog.
* [Sager til brugersupport kan kategoriseres][1] i flere grupper, som kan henvise til nærmere definerede afdelinger og sprog.

Du kan med det samme tilføje seks forskellige sprog. Hvis det sprog, du ønsker at bruge, ikke er tilgængeligt, bedes du kontakte os. Vores konsulenter kan hjælpe dig med at tilføje de ekstra sprog, du har brug for.

## Trin

1. Gå til Indstillinger og vedligeholdelse og vælg <i class="ph ph-sliders-horizontal" aria-hidden="true"></i> **Indstillinger**.

2. Vælg fanen **Kundesprog**.

3. Klik på knappen **Nyt kundesprog**. Du kommer til skærmbilledet **Egenskaber for kundesprog**.

    ![Du kan konfigurere et nyt sprog i dialogboksen Egenskaber for kundesprog -screenshot][img1]

4. Angiv i feltet **Navn** navnet på det sprog, der skal bruges som etiket i felter til valg af sprog.

5. I feltet **Sprogkode** skal du angive en kort kode for det relevante sprog (eller tilsvarende). Normalt anvendes de internationale forkortelser med to bogstaver (f.eks. DE, DK, EN, NL, NO og SE). Se en komplet liste sidst på denne side.

6. I feltet **Virtuelt domæne** skal du indtaste den domæneadresse, der giver adgang til SuperOffice Customer Centre for det aktuelle sprog, for eksempel germany.liberty.com. Sådanne domæner skal være konfigureret på forhånd.

7. I feltet **E-maildomæner** skal du indtaste en liste med e-maildomæner (adskilt af komma), f.eks. således: no, se, co.uk. Hvis en ny person registreres automatisk (ved import af e-mail), og personen har en e-mail-adresse, der indeholder et af disse domæner, angives det tilhørende sprog automatisk for personen.

8. I feltet **FAQ-mappe** skal du vælge, hvilken FAQ-mappe der skal være den øverste mappe i FAQ-hierarkiet for besøgende fra SuperOffice Customer Centre på det aktuelle sprog. FAQ-hierarkiet kan med andre ord inddeles i flere sproglige dele og derefter filtreres efter sprog. Det giver bedre søgeresultater, og brugeren får kun vist FAQ'er på det relevante sprog.

9. Marker **Brug som standard**, hvis du ønsker, at dette skal være standardsproget. Det vil sige, at dette sprog vil blive anvendt, hvis ingen af de andre kundesprog stemmer overens med kriterierne, hvis der ikke er defineret noget sprog for en kunde.

10. Klik på **OK**. Kundesproget oprettes, og du får mulighed for at oprette [eksterne kategorier][1].

    > [!TIP]
    > Det er muligt at bruge kundesprog til andet end sprog, hvis du for eksempel kun har aktiviteter i ét land. Én mulighed er at oprette forskellige afdelinger, branchesektioner eller fagområder, f.eks. Byggeri, Badeværelser, Indendørsindretning og Haver. Derefter kan SuperOffice Customer Centre, FAQ-hierarkiet og svarskabelonerne afspejle den sektor, der er relevant for bestemte kunder. Forkortelsen, der bruges for afdelingen, skal afspejle mappenavnet mappen\\skabeloner. For eksempel: Byggeri = BY.

## Sprogkoder

| Sprog | Kode |
|---|:-:|
| Kinesisk (forenklet) | CN |
| Tjekkisk | CZ |
| Dansk | DA (ikke DK) |
| Hollandsk | NL |
| Engelsk | EN |
| Finsk | FI |
| Fransk | FR |
| Tysk | DE |
| Tysk (Schweiz) | CH |
| Italiensk | It |
| Koreansk | KO |
| Norsk | NO |
| Polsk | PL |
| Portugisisk (Brasilien) | BR |
| Russisk | RU |
| Spansk | ES |
| Svensk | SE (ikke SV) |
| Ukrainsk | UK |
| Vietnamesisk | VI |

## Relateret indhold

* [Sådan vælger SuperOffice kundesprog til nye personer][2]

<!-- Referenced links -->
[1]: ../../request/admin/category/external-categories.md
[2]: ../learn/customer-languages.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/admin/customer-centre-language.png
