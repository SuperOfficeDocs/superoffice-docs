---
uid: help-no-search-criteria
title: Bruke søkekriterier
description: Bruke søkekriterier
author: Bergfrid Dias
date: 03.28.2023
keywords: søk, kriterier, finn
topic: howto
language: no
---

# Bruk søkekriterier

Du bruker søkekriterier for å definere hva du leter etter, for eksempel "firmaer med adresse i Danmark". Søkekriterier brukes flere steder i SuperOffice CRM, for eksempel i **Finn**-skjermbildet og ved oppretting av utvalg. Men uansett hva du skal bruke kriteriene til, jobber du med dem på samme måte.

Overalt der du kan legge inn søkekriterier, finner du en liste over kriterier som inneholder de valgte søkekriteriene.

Vanlige søk hjelper deg å komme i gang og opprette ditt eget søk etter CRM-data. Når du har valgt et vanlig søk, kan du legge til og redigere søkekriteriene. Og når du har opprettet et nyttig søk som du vil bruke igjen, kan du lagre det som et utvalg.

Se denne videoen for å lære hvordan du gjør et vanlig søk og endrer det ved å legge til nye søkekriterier, eller følg den trinn-for-trinn-veiledningen nedenfor:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/gx-vXm-b_7g]

(videolengde – 3:01)

## Legg til søkekriterier

1. Gå til kriterielisten.
    * Klikk på **Finn** i toppraden. Kriterielisten finnes i fanen **Kriterier**.
    * Du kan også gå til ønsket utvalg og velge fanen **Kriterier**.

2. Klikk på **Legg til**-knappen.
    Det legges til en ny linje i kriterielisten, og det vises en liste med felt å velge mellom.

3. Velg feltet du vil søke etter informasjon i. Du kan også [angi starten på navnet][2] i ønsket felt. Det finnes ulike typer felt:

    * [Tekst](#text)
    * [Ja/Nei](#yes-no)
    * [Dato](#date)
    * [Tall](#number)
    * [Liste](#list)
    * [Status](#status)
    * [Teller](#counter)

4. Velg verdier for søkekriteriene i de ulike feltene på linjen.

5. Klikk på **Legg til** for å legge til en ny linje, eller klikk på **Eller** for å legge til et nytt sett med kriterier.

## Felttyper

### <a id="text"></a>Tekstfelt

Hvis feltet du søker i, er et tekstfelt (for eksempel et navn), søkes det etter tekst eller tall du skriver inn. En liste med følgende alternativer vises:

[!include[Search criteria](includes/list-search-criteria.md)]

Velg ett av disse alternativene, og skriv deretter inn søkekriterier i tekstfeltet til høyre.

### <a id="yes-no"></a>Ja/Nei-felt

Hvis feltet du søker i er et Ja/nei-felt, for eksempel feltet **Ingen utsendelser** i skjermbildet Firma, vises to alternativknapper. Du kan velge mellom **Ja** og **Nei**.

### <a id="date"></a>Datofelt

Hvis feltet du søker i er et datofelt, for eksempel feltet **Dato** i dialogboksen **Dokument** vises en liste med følgende alternativer:

[!include[Search criteria](includes/list-date-criteria.md)]

Velg ønsket alternativ. Avhengig av hva du velger, fylles feltet automatisk ut med en dato eller et datointervall, eller du kan skrive inn ønsket dato. Du kan også velge en dato i kalenderen som vises når du klikker på <i class="ph ph-caret-down" aria-label="Chevron"></i>.

### <a id="number"></a>Tallfelt

Hvis feltet du søker i inneholder en numerisk verdi, for eksempel feltet **Beløp** i skjermbildet Salg, vises en liste med følgende alternativer:

[!include[Search criteria](includes/table-number-criteria.md)]

Velg ønsket alternativ, og skriv inn ønsket tallverdi i tekstfeltet til høyre.

### <a id="list"></a>Listefelt

Hvis feltet du søker i er et felt som inneholder lister, for eksempel feltet **Bransje** i skjermbildet Firma, vises en liste med alternativene **Er en av** og **Er ikke en av**. For for firma- og personinterresser er valgene **Er lik**, **Er en av**, and **Ingen av**.

1. Klikk på feltet **Velg elementer** for å vise en liste over verdier.
1. Hvis listen er lang, kan du skrive inn tekst i **Søkevilkår** for å søke etter verdier.
1. Klikk utenfor listen for å lukke den.

### <a id="status"></a>Statusfelt

Hvis feltet du søker i er et statusfelt, velger du ønsket status.

Statusene opprettes og vedlikeholdes i Innstillinger og vedlikehold. Statusfelt er bare aktuelle hvis du har kjøpt lisens for og aktivert statusovervåking.

### <a id="counter"></a>Tellerfelt

[Tellere][3] kan for eksempel være antall salg i en periode eller datoen for det siste fullførte salget.

Tellerfelt finner du under **Tellere (SAINT)** i listen med kriterier.

1. Til høyre for feltene kan du klikke koblingene for å angi flere vilkår for tellerne. De tilgjengelige alternativene avhenger av typen oppføring og teller du jobber med.

    * **Saint-type**: Her kan du velge aktivitetstypen du vil søke etter.
    * **Status**: Her kan du velge statusen til oppføringen du vil søke etter.
    * **Retning**: Her kan du velge om aktiviteten er innkommende eller utgående.
    * **Beløpsklasse**: Her velger du beløpsklassen til salget.
    * **Hensikt**: Her kan du velge hensikten for aktiviteten.

1. Avhengig av hva du valgte ovenfor, vises en liste for et datofelt eller et tallfelt. Disse listeboksene fungerer som beskrevet ovenfor. Velg ønsket alternativ, og skriv inn ønsket tallverdi eller dato i tekstfeltet.

Tellerne opprettes og vedlikeholdes i Innstillinger og vedlikehold. Tellerfelt er bare relevante hvis du har kjøpt lisens for og aktivert statusovervåking.

## Arbeide med søkekriterier

Listen over kriterier inneholder et sett med standardkriterier som du kan redigere eller fjerne etter behov.

Når du åpner skjermbildet **Finn**, inneholder den standard søkekriterier eller søkekriteriene du anga forrige gang du brukte dialogboksen. Hvis du vil bruke andre søkekriterier enn de som vises, har du følgende alternativer:

| Oppgave | Handling |
|---|---|
| Flytte søkekriterier | Klikk <i class="ph ph-equals" aria-label="="></i> og dra linjen. |
| Endre et søkekriterium | Klikk på det og velg et annet kriterium fra listen som vises. |
| Deaktivere ett eller flere søkekriterier | La verdifeltet stå tomt. |
| Deaktivere alle søkekriteriene | Click **Clear all**. |
| Slette et søkekriterium | Klikk <i class="ph ph-x-circle" aria-label="X"></i>. |
| Tilbakestille listen | Klikk **Tilbakestill til standard**. |

> [!NOTE]
> Å flytte kriterier har ingen praktisk effekt på søket, men gjør det mulig for deg å ordne kriteriene i den rekkefølgen du foretrekker. Hvis noen av kriteriene ikke brukes, men du fortsatt ønsker å beholde dem, kan du flytte inaktive kriterier til bunnen av listen.
>
> Et deaktivert søkekriterium blir stående på listen over kriterier og kan enkelt aktiveres igjen.

## Hva vil du gjøre nå?

* [Bruke Finn-skjermbildet][1]

<!-- Referenced links -->
[1]: find-screen.md
[2]: in-navigator.md
[3]: ../../saint/learn/index.md
