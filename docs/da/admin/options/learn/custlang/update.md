---
uid: help-da-languages-add
title: Arbejde med kundesprog
description: Få mere at vide om i denne guide, hvordan du konfigurerer kundesprog.
author: SuperOffice RnD
date: 06.29.2022
keywords: sprog
topic: howto
language: da
---

# Sådan oprettes og redigeres kundesprog

## Sådan tilføjer du kundesprog

1. [!include[Go to Options](../includes/open-options.md)]

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

[!include[Language codes](includes/language-codes.md)]

## Hvad ønsker du at få mere at vide om?

* [Arbejde med eksterne kategorier][1]
* [Sådan vælger SuperOffice kundesprog til nye personer][2]

<!-- Referenced links -->
[1]: external-categories.md
[2]: select-language.md

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/admin/customer-centre-language.png
