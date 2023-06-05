---
uid: help-no-search-criteria
title: Bruke søkekriterier
description: Bruke søkekriterier
author: Bergfrid Dias
so.date: 03.28.2023
keywords: søk, kriterier, finn
so.topic: howto
language: no
---

# Bruk søkekriterier

Du bruker søkekriterier for å definere hva du leter etter, for eksempel "firmaer med adresse i Danmark". Søkekriterier brukes flere steder i SuperOffice CRM, for eksempel i **Finn**-skjermbildet og ved oppretting av utvalg. Men uansett hva du skal bruke kriteriene til, jobber du med dem på samme måte.

Overalt der du kan legge inn søkekriterier, finner du en liste over kriterier som inneholder de valgte søkekriteriene.

Vanlige søk hjelper deg å komme i gang og opprette ditt eget søk etter CRM-data. Når du har valgt et vanlig søk, kan du legge til og redigere søkekriteriene. Og når du har opprettet et nyttig søk som du vil bruke igjen, kan du lagre det som et utvalg.

Se denne videoen for å lære hvordan du gjør et vanlig søk og endrer det ved å legge til nye søkekriterier, eller følg den trinn-for-trinn-veiledningen nedenfor (videolengde – 3:01):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/gx-vXm-b_7g]

## Legg til søkekriterier

1. Gå til kriterielisten.
    * Klikk på **Finn** i toppraden. Kriterielisten finnes i fanen **Kriterier**.
    * Du kan også gå til ønsket utvalg og velge fanen **Kriterier**.

2. Klikk på **Legg til**-knappen.
    Det legges til en ny linje i kriterielisten, og det vises en liste med felt å velge mellom.

3. Velg feltet du vil søke etter informasjon i. Du kan også [angi starten på navnet][2] i ønsket felt. Det finnes ulike typer felt:

    * Tekst
    * Ja/Nei
    * Dato
    * Tall
    * Liste
    * Status
    * Teller

4. Velg verdier for søkekriteriene i de ulike feltene på linjen.

5. Klikk på **Legg til** for å legge til en ny linje, eller klikk på **Eller** for å legge til et nytt sett med kriterier.

### Felttyper

#### Tekstfelt

Hvis feltet du søker i, er et tekstfelt (for eksempel et navn), søkes det etter tekst eller tall du skriver inn. En liste med følgende alternativer vises:

[!include[Search criteria](../../learn/includes/list-search-criteria.md)]

Velg ett av disse alternativene, og skriv deretter inn søkekriterier i tekstfeltet til høyre.

#### Ja/Nei-felt

Hvis feltet du søker i er et Ja/nei-felt, for eksempel feltet **Ingen utsendelser** i skjermbildet Firma, vises to alternativknapper. Du kan velge mellom **Ja** og **Nei**.

#### Datofelt

Hvis feltet du søker i er et datofelt, for eksempel feltet **Dato** i dialogboksen **Dokument** vises en liste med følgende alternativer:

[!include[Search criteria](../../learn/includes/list-date-criteria.md)]

Velg ønsket alternativ. Avhengig av hva du velger, fylles feltet automatisk ut med en dato eller et datointervall, eller du kan skrive inn ønsket dato. Du kan også velge en dato i kalenderen som vises når du klikker på pilknapp-![ikonet][img1].

#### Tallfelt

Hvis feltet du søker i inneholder en numerisk verdi, for eksempel feltet **Beløp** i skjermbildet Salg, vises en liste med følgende alternativer:

[!include[Search criteria](../../learn/includes/table-number-criteria.md)]

Velg ønsket alternativ, og skriv inn ønsket tallverdi i tekstfeltet til høyre.

#### Listefelt

Hvis feltet du søker i er et felt som inneholder lister, for eksempel feltet **Bransje** i skjermbildet Firma, vises en liste med alternativene **Er en av** og **Er ikke en av**.

Klikk på feltet **Velg elementer** for å vise en liste over verdier.

Hvis listen er lang, kan du skrive inn tekst i **Søkevilkår** for å søke etter verdier.

Klikk utenfor listen for å lukke den.

#### Statusfelt

Hvis feltet du søker i er et statusfelt, velger du ønsket status.

Statusene opprettes og vedlikeholdes i Innstillinger og vedlikehold.

Statusfelt er bare aktuelle hvis du har kjøpt lisens for og aktivert statusovervåking.

#### Tellerfelt

[Tellere][3] kan for eksempel være antall salg i en periode eller datoen for det siste fullførte salget.

Tellerfelt finner du under **Tellere (SAINT)** i listen med kriterier.

Tellerne opprettes og vedlikeholdes i Innstillinger og vedlikehold.

Tellerfelt er bare relevante hvis du har kjøpt lisens for og aktivert statusovervåking.

Til høyre for feltene kan du klikke koblingene for å angi flere vilkår for tellerne. De tilgjengelige alternativene avhenger av typen oppføring og teller du jobber med.

* **Saint-type**: Her kan du velge aktivitetstypen du vil søke etter.
* **Status**: Her kan du velge statusen til oppføringen du vil søke etter.
* **Retning**: Her kan du velge om aktiviteten er innkommende eller utgående.
* **Beløpsklasse**: Her velger du beløpsklassen til salget.
* **Hensikt**: Her kan du velge hensikten for aktiviteten.

Avhengig av hva du valgte ovenfor, vises en liste for et datofelt eller et tallfelt. Disse listeboksene fungerer som beskrevet ovenfor. Velg ønsket alternativ, og skriv inn ønsket tallverdi eller dato i tekstfeltet.

## Endre søkekriterier

Hvis du vil endre et søkekriterium, klikker du på det og velger et annet kriterium fra listen som vises.

## Flytt søkekriterier

Hvis du vil flytte kriterier (en linje), klikk og dra ![ikonet][img2].

## Slett søkekriterier

Hvis du vil slette et søkekriterium, klikk på ![ikon][img3].

## Aktivere eller deaktivere søkekriterier

Når du åpner skjermbildet **Finn**, inneholder den standard søkekriterier eller søkekriteriene du anga forrige gang du brukte dialogboksen. Hvis du vil bruke andre søkekriterier enn de som vises, har du følgende alternativer:

* Du kan slette dem ved å klikke på ![ikon][img3]
* Du kan deaktivere ett eller flere søkekriterier ved å la verdifeltet stå tomt. Et deaktivert søkekriterium blir stående på listen over kriterier og kan enkelt aktiveres igjen.
* Du kan deaktivere alle søkekriteriene ved å klikke **Fjern alle**.

## Flytt søkekriterier opp eller ned

Hvis du vil flytte kriterier, klikk og dra ![ikon][img2]. Dette har ingen praktisk effekt på søket, men gjør det mulig for deg å ordne kriteriene i den rekkefølgen du foretrekker. Hvis noen av kriteriene ikke brukes, men du fortsatt ønsker å beholde dem, kan du flytte inaktive kriterier til bunnen av listen.

## Tilbakestill til standard søkekriterier

Listen over kriterier inneholder et sett med standardkriterier som du kan redigere eller fjerne etter behov. Hvis du vil tilbakestille listen over kriterier standardvilkåret, klikker du **Tilbakestill til standard**.

## Hva vil du gjøre nå?

* [Bruke Finn-skjermbildet][1]

<!-- Referenced links -->
[1]: find-screen.md
[2]: using-fastsearcher.md
[3]: ../../sale/saint/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../common/icons/dropdown-icon.png
[img2]: ../../../media/icons/criteria-move.png
[img3]: ../../../../common/icons/delete-circle-red.png
