---
uid: help-no-customer-language-add
title: Legg til kundespråk
description: Finn ut hvordan du konfigurerer kundespråk i denne guiden.
keywords: kundespråk, legge til språk, nytt kundespråk, språkkode
author: digitaldiina
date: 10.09.2025
version: 11.5
content_type: howto
category: localization
topic: language
audience: settings
audience_tooltip: Settings and maintenance
redirect_from: /no/admin/options/learn/custlang/update
language: no
index: true
---

# Legg til kundespråk

I bildet **Kundespråk** finner du en liste over de installerte [kundespråkene][2]. I dette bildet kan du konfigurere kundespråkene og gjøre det enkelt å kommunisere med kunder på forskjellige språk.

For eksempel:

* Du kan ha flere språkversjoner av SuperOffice Customer Center, FAQ-er og svarmaler.
* Du kan angi et språk for en person, slik at personen automatisk vil motta svarmaler på dette språket.
* [Saker til brukerstøtte kan kategoriseres][1] i flere grupper som kan henvise til bestemte avdelinger og språk.

Du kan i utgangspunktet legge til seks forskjellige språk. Hvis språket du vil bruke, ikke er tilgjengelig, kan du kontakte oss, så hjelper konsulentene våre deg med å legge til de ekstra språkene du trenger.

## Trinn

1. Gå til Innstillinger og vedlikehold og velg <i class="ph ph-sliders-horizontal" aria-hidden="true"></i> **Alternativer**.

2. Velg fanen **Kundespråk**.

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

| Språk | Kode |
|---|:-:|
| Kinesisk (forenklet) | CN |
| Tsjekkisk | CZ |
| Dansk | DA (ikke DK) |
| Nederlandsk | NL |
| Engelsk | EN |
| Finsk | FI |
| Fransk | FR |
| Tysk | DE |
| Tysk (Sveits) | CH |
| Italiensk | IT |
| Koreansk | KO |
| Norsk | NO |
| Polsk | PL |
| Portugisisk (Brasil) | BR |
| Russisk | RU |
| Spansk | ES |
| Svensk | SE (ikke SV) |
| Ukrainsk | Storbritannia |
| Vietnamesisk | VI |

## Relatert innhold

* [Slik velger SuperOffice kundespråket for nye personer][2]

<!-- Referenced links -->
[1]: ../../request/admin/category/external-categories.md
[2]: ../learn/customer-languages.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/admin/customer-centre-language.png
