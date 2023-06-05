---
uid: help-no-editor
title: Dra og slipp editor
description: Dra og slipp editor
author: SuperOffice RnD
so.date: 02.20.2023
keywords: markedsføring, redigeringsprogram, malvariabel, flettefelt
so.topic: concept
language: no
---

# Dra og slipp editor

![Dra og slipp editor -screenshot][img1]

I trinnet **Innhold** kan du redigere utseendet til og innholdet i meldingen.

* Du kan [sette inn tekst og bilder][1] (og annet innhold) i kolonnene og radene i meldingen.

* Du kan definere format/utseende (for eksempel skrifttype og -størrelse, farger og marger) på globalt nivå (hele meldingen) eller etter individuelle seksjoner.

* Du kan enkelt dra og slippe innhold fra sidepanelet (menyer, knapper, SoMe-koblinger, HTML-innhold, samt topp- og bunntekstblokker).

SuperOffice Markedsføring leveres med mange [ferdige meldingsmaler][9], og du kan enkelt flytte innhold rundt for å få det utseendet du ønsker. For å spare tid, kan du lagre ofte brukt innhold som blokker.

> [!TIP]
> Vi anbefaler normalt en maksimal bredde på 600 piksler for utsendelser. Du kan også velge hvordan utsendelsen vil se ut, for eksempel på smarttelefoner ved å klikke på **Mobil** (![icon][img4]) i menyen i nedre venstre hjørne. Se også [Tilpasse meldingen for visning på mobile enheter][3].

## Redigere kolonner og blokker/seksjoner

Når du klikker på en seksjon (for eksempel kolonne, innholdsboks, rad), vises knapper med redigeringsalternativer. Sidepanelet viser alle redigeringsalternativene for den valgte seksjonen.

En blå ramme vises rundt det valgte elementet, slik at du alltid vet hvilken del av meldingen du redigerer.

Hvis du klikker på tekstinnhold, vises en verktøylinje for tekstredigering.

Den globale menyen vises alltid nederst til venstre i innholdsområdet.

## Redigere tekst og bilder

[Rediger tekst][5], [sett inn bilder][6] og legg til annet innhold ved å klikke på et område i meldingen. Bruk verktøylinjen for tekstredigering og sidepanelet til å redigere det valgte området.

## Sett inn nytt innhold

I sidepanelet kan du dra og slippe elementer fra **Innhold**-seksjonen til meldingen. Du kan også klikke på **+** over eller under en rad for å sette inn en ny rad.

## Flytte, kopiere og slette innhold

Du kan velge en seksjon og bruke knappene til å flytte ( ![icon][img6] ), duplikere ( ![icon][img8] ) og slette ( ![icon][img7] ) den.

## Redigere format og utseende

Utseendet og egenskapene til meldingen (for eksempel skrifttype og -størrelse, farger og marger) kan defineres på globalt nivå (hele meldingen) eller etter seksjon (som beskrevet ovenfor).

Hvis du vil redigere meldingen på globalt nivå, velger du **Brødtekst** (![icon][img12]) i sidepanelet.

> [!TIP]
> Bruk standard skrifttyper for best lesbarhet med hvilken som helst e-postklient eller nettleser.

## Menyoversikt

Nedenfor er en oversikt over de ulike funksjonene i trinnet **Innhold**.

### Sidepanel

Sidepanelet inneholder følgende hovedområder:

[!include[Mailing - sections in the side panel](includes/mailing-side-panel.md)]

Se også [Legg til innhold][1].

### Global meny

Fra den globale menyen kan du forhåndsvise, angre eller gjenta handlinger og se hvordan meldingen ser ut på skrivebordet eller mobilenheten. Denne menyen vises alltid nederst til venstre i innholdsområdet.

| Icon | Navn | Funksjon |
|:-:|---|---|
| ![icon][img11] | Angre/gjøre om | Angrer den siste handlingen eller utfører en angret handling på nytt. |
| ![icon][img2] | Forhåndsvis | Åpner en forhåndsvisning av meldingen på en stasjonær eller mobil skjerm. |
| ![icon][img3], ![icon][img4] | Bytt visning for stasjonære eller mobile enheter | Brukes til å se hvordan utseendet er på en datamaskin eller smarttelefon. |

### Pop-up-meny

Når du klikker på en seksjon i en melding får du tilgang til ulike funksjoner for seksjonen.

| Icon | Navn | Funksjon |
|:-:|---|---|
| ![icon][img5] | Legg til rad | Legger til en rad under eller over den merkede seksjonen. |
| ![icon][img6] | Flytt | Klikk og dra for å flytte seksjonen. |
| ![icon][img7] | Slett | Sletter seksjonen. |
| ![icon][img8] | Dupliser | Oppretter en kopi av seksjonen. |
| ![icon][img9] | Lagre blokk | Lagrer den merkede seksjonen som en blokk. Lar deg gjenbruke innhold (som topp- og bunntekster) på tvers av meldinger. |

## <a id="variables" />Malvariabler

Hvis du vil gi meldingen et mer personlig preg, kan du bruke plassholdere til å sette inn kundespesifikk informasjon, som for eksempel kundens fornavn. På denne måten kan du tilpasse innholdet for hver enkelt kunde.

Disse plassholderne kalles **malvariabler** i det gamle redigeringsprogrammet og **slår sammen koder** i redigeringsprogrammet for dra og slipp.

[!include[Note](includes/note-imported-recipients.md)]

Det finnes ulike typer flettefelt:

* Flettefelt som er koblet til personer. For eksempel, **[[customer.name]]** sett inn personens fulle navn.
* Flettefelt som er koblet til firmaer. For eksempel, **[[company.name]]** setter inn navnet på firmaet personen tilhører.

### Eksempel

I stedet for denne teksten:

"Kjære kunde. Vil du vite mer om hvordan produktet vårt kan hjelpe firmaet ditt med å skaffe nye kunder? Kontakt oss på SuperShop».

Du kan sende denne:

«Kjære Jonas. Vil du vite mer om hvordan produktet vårt kan hjelpe Bilbutikken AS med å skaffe nye kunder? Ring Kari Nordmann på SuperShop."

Teksten du skriver inn vil se slik ut:

«Kjære **[[customer.firstname]]**. Vil du vite mer om hvordan produktet vårt kan bidra til **[[company.name]]** å vinne nye kunder? Ring **[[company.ourSalesContact.name]]** på SuperShop».

## To forskjellige redigeringsprogrammer

Bruker du det nye Dra og slipp-redigeringsprogrammet eller den forrige versjonen ?

Tidlig i 2021 la SuperOffice til et nytt redigeringsprogram for meldinger («Dra og slipp-redigeringsprogrammet») for å erstatte det gamle («Redigeringsprogrammet»). Redigeringsprogrammet for meldinger brukes når du oppretter e-postutsendelser og skjemasvar. Det gamle redigeringsprogrammet for meldinger vil fortsatt være tilgjengelig for redigering av meldinger og maler som er opprettet i den gamle versjonen. Alle nye utsendelser og maler bruker det nye meldingsredigeringsprogrammet.

### Redigeringsprogram (gammelt)

![Redigeringsprogram (gammelt) -screenshot][img13]

## Hva vil du gjøre nå?

* [Legg til innhold][1]
* [Redigere innhold][5]
* [Inkludere koblinger du vil spore][8]
* [Bruke flettefelt i meldinger][7]
* [Sette inn bilder i meldingen][6]
* [Les om det gamle redigeringsprogrammet][2]

<!-- Referenced links -->
[1]: add-content.md
[3]: customize-for-mobile.md
[5]: edit-paragraph.md
[6]: insert-images-in-message.md
[7]: add-merge-tag.md
[8]: ../tracked-links/learn/add-tracked-link-to-msg.md
[9]: work-with-messages-and-templates.md
[2]: https://help.superoffice.com/Documentation/Help/EN/CRM/UserHelp/index.htm#t=Mailing%2FHelptopics%2Foldeditor%2FStep_3__Content_-_Formatted_e-mail.htm

<!-- Referenced images -->
[img1]: media/edit-template.png
[img2]: ../../../media/icons/marketing-and-forms/preview.png
[img3]: ../../../media/icons/marketing-and-forms/desktop.png
[img4]: ../../../media/icons/marketing-and-forms/mobile-2.png
[img5]: ../../../media/icons/marketing-and-forms/add-row.png
[img6]: ../../../media/icons/marketing-and-forms/move-2.png
[img7]: ../../../media/icons/marketing-and-forms/cancel.png
[img8]: ../../../media/icons/marketing-and-forms/copy.jpg
[img9]: ../../../media/icons/marketing-and-forms/save-block.png
[img11]: ../../../media/icons/marketing-and-forms/undo-redo.png
[img12]: ../../../media/icons/marketing-and-forms/side-panel-body-small.png
[img13]: media/template-edit-overview-old.png
