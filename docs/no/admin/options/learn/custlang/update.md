---
uid: help-no-languages-add
title: Arbeide med kundespråk
description: Finn ut hvordan du konfigurerer kundespråk i denne guiden.
author: SuperOffice RnD
date: 06.29.2022
keywords: språk
topic: howto
language: no
---

# Slik oppretter og redigerer du kundespråk

## Slik legger du til kundespråk

1. [!include[Go to Options](../includes/open-options.md)]

2. Velg fanen **Kundespråk** .

3. Klikk på knappen **Nytt kundespråk**. Du kommer til bildet **Egenskaper for kundespråk**.

    ![Du kan definere et nytt språk i dialogboksen Egenskaper for kundespråk -screenshot][img1]

4. I feltet **Navn** skriver du inn navnet på språket, slik at det kan brukes som ledetekst i feltene for språkvalg.

5. I feltet **Språkkode** angir du en kort kode for det aktuelle språket (eller tilsvarende). Vanligvis brukes den internasjonale forkortelsen bestående av to bokstaver (for eksempel DE, DK, EN, NL, NO og SE). Se en fullstendig liste nederst på denne siden.

6. I feltet **Virtuelt domene** skriver du inn domeneadressen som gir tilgang til SuperOffice Customer Centre for det aktuelle språket, for eksempel germany.liberty.com. Slike domener må settes opp på forhånd.

7. I feltet **E-postdomener** skriver du inn en liste med e-postdomener (med komma mellom), for eksempel slik: no, se, co.uk. Hvis en ny person registreres automatisk (ved import av e-post), og personen har en e-postadresse som inneholder et av disse domenene, angis det tilhørende språket automatisk for personen.

8. I feltet **FAQ-mappe** velger du hvilken FAQ-mappe som skal være den øverste mappen i FAQ-hierarkiet for besøkende fra SuperOffice Customer Centre på det aktuelle språket. FAQ-hierarkiet kan med andre ord deles inn i flere språkdeler, og den filtreres på språk. Dette gir bedre søkeresultat, og kun FAQer på det aktuelle språket vises for brukeren.

9. Merk av for **Bruk som standard** hvis du vil at dette skal være standardspråket. Det vil si at det er dette språket som brukes i tilfeller der ingen av de andre kundespråkene stemmer med kriteriene eller hvis det ikke er angitt språk for en kunde.

10. Klikk på **OK**. Kundespråket opprettes, og du får mulighet til å opprette [eksterne kategorier][1].

    > [!TIP]
    > Det er fullt mulig å bruke kundespråk til noe annet enn språk, hvis du for eksempel bare driver virksomhet i ett land. Ett alternativ er å opprette forskjellige avdelinger/bransjer/fagområder, for eksempel Bygg & Anlegg, Baderom, Interiør og Hage. Da kan SuperOffice Customer Centre, FAQ-hierarkiet og svarmalene gjenspeile den bransjen som er aktuell for de ulike kundene. Forkortelsen som blir brukt på avdelingen, må gjenspeile mappenavnet i mappen \\templates. For eksempel: Bygg & Anlegg = BA.

## Språkkoder

[!include[Language codes](includes/language-codes.md)]

## Hva vil du lære mer om?

* [Arbeide med eksterne kategorier][1]
* [Slik velger SuperOffice kundespråket for nye personer][2]

<!-- Referenced links -->
[1]: external-categories.md
[2]: select-language.md

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/admin/customer-centre-language.png
