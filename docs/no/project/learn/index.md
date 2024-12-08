---
uid: help-no-project
title: Prosjekt
description: Denne veiledningen viser deg hvordan du oppretter og bruker prosjekter for å holde oversikt over arbeidet ditt.
keywords: prosjekt
author: SuperOffice RnD
date: 10.29.2024
version: 10.3.11
topic: concept
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Prosjekt

Du kan koble en hvilken som helst aktivitet til et eksternt firma og til et prosjekt. Du kan også jobbe med en prosjektguide som tar deg gjennom hvert trinn i prosjektet, forutsatt at det er opprettet en guide for prosjekttypen du har valgt. Et prosjekt kan være rettet mot mange personer, og en person kan delta i mange prosjekter.

![Prosjekt-bildet -screenshot][img1]

Prosjekter hjelper deg med å holde arbeidet organisert og dokumentert på ett sted, slik at du og teamet ditt kan få bedre kontroll og forbedre samarbeidet.

Du kan koble alle personer, firmaer, oppfølginger, prosjektmedlemmer og til og med salgsmuligheter til ett prosjekt i SuperOffice CRM. Du kan også opprette eller laste opp dokumenter og filer til prosjektet.

All informasjonen du lagrer i prosjektet er merket med en dato og en eier, noe som gjør det enklere å sortere og filtrere informasjon ved behov.

Prosjekt-bildet inneholder informasjon om prosjektene som er registrert i SuperOffice CRM. Hvert prosjekt vises som et arkivkort som viser all informasjon om prosjektet.

Hvis du vil flytte bakover og fremover mellom prosjekter, klikker du på knappene ![ikon][img2] ![ikon][img3] forrige/neste nederst til høyre på kortene

Hvis du velger en prosjekttype som det er definert en [prosjektguide][1] for, vises fanen **Prosjektguide** på detaljkortet.

## <a id="more-tab"></a>Fanen Mer

I [fanen **Mer**][12] finner du brukerdefinerte felt for prosjektet. Tre av de brukerdefinerte feltene fra fanen **Mer** kan også vises i fanen **Prosjekt**.

## Fanen Notat

[!include[About the Note tab](../../learn/includes/about-note-tab.md)]

## <a id="event-tab"></a>Fanen Arrangement

Denne funksjonen krever egen lisens.

I fanen **Arrangement** kan du angi innstillinger for publisering av arrangementer.

| Felt | Beskrivelse |
|---|---|
| Operasjon | Her merker du av hvis det aktuelle prosjektet er et arrangement. |
| Arrangementsdato | Dette feltet viser datoen for arrangementet. Klikk på pilen for å velge dato for arrangementet. |
| Publisert (Fra dato og Til dato) | Her kan du angi et nøyaktig tidsrom når arrangementet skal vises for Audience-brukere (krever egen lisens). Klikk på pilen ved siden av datofeltene for å velge start- og sluttdato for publiseringen. Hvis du ikke angir datoer i disse feltene [publiseres prosjektet][2] før det enten blir upublisert eller slettet fra SuperOffice CRM. |
| Synlig for kategori | Merk av her hvis du vil at arrangementet kun skal være synlig for bestemte kategorier. Klikk på knappen ( ![ikon][img5] ) til høyre for feltet for å velge kategoriene som arrangementet skal være synlig for. |
| Synlig for personinteresse | Merk av her hvis du vil at arrangementet kun skal være synlig for personer med bestemte interesser. Klikk på knappen ( ![ikon][img5] ) til høyre for feltet for å velge interessene som arrangementet skal være synlig for. |
| Synlig for prosjektdeltakere | Hvis avmerket, er arrangementet kun synlig i Audience for [prosjektdeltakerne][8] som er angitt på detaljkortet **Prosjektdeltakere**. |
| Melde seg på | Merk av her hvis du vil at det skal være mulig å melde seg på arrangementet gjennom Audience. |
| Melde seg av | Merk av her hvis du vil at det skal være mulig å melde seg av arrangementet gjennom Audience. |
| Logg som aktivitet | Hvis du også merker av for **Logg som aktivitet** bak **Melde seg på** eller **Melde seg av**, opprettes det en aktivitet for deg når en Audience-bruker melder seg på eller av arrangementet. |

> [!TIP]
> Hvis du klikker på knappen ( ![ikon][img5] ) til høyre for **Bekreftelse**, kan du skrive inn en bekreftelsestekst som skal vises i en dialogboks når en Audience-bruker melder seg på eller av arrangementet. Brukeren må klikke på **Ja** eller **Nei** i denne dialogboksen for å fortsette.

## <a id="section-tabs"></a>Detaljkortene i Prosjekt-bildet

Den nedre delen av Prosjekt-bildet består av detaljkort.

* [Prosjektguide][13] (hvis det er definert en for gjeldende prosjekttype)
* [Prosjektdeltakere][6]
* [Aktiviteter][16]
* [Salg][17]
* [Saksbehandling][18]

[!include[Add more section tabs](../../learn/includes/more-tab.md)]

## Prosjektguide

Prosjektguiden som kan tilpasses dine egne unike prosjektprosesser. Du kan kartlegge alle aktiviteter, dokumenter og milepæler i et prosjekt, noe som vil gjøre det enkelt for hele teamet å spore. Prosjektguiden vil også hjelpe deg med å overvåke gjeldende prosjektstatus og spørre hva som må gjøres til enhver tid.

![En prosjektguide vil hjelpe teamet med å ha en konstant oversikt over prosjektstatusen -screenshot][img4]

Administratoren kan [legge til og tilpasse prosjektguider][8] for deg.

## Hva vil du gjøre nå?

* [Legge til prosjekt i favoritter][9]
* [Opprette et prosjekt][2]
* [Redigere et prosjekt][3]
* [Slå sammen prosjekter][4]
* [Slette et prosjekt][5]
* [Sende et dokument til prosjektdeltakere][7]
* [Prosjektguide][1]
* [Skrive ut prosjektinformasjon][11]

<!-- Referenced links -->
[1]: project-guide/index.md
[2]: create.md
[3]: edit.md
[4]: merge-projects.md
[5]: delete.md
[6]: project-members/index.md
[7]: project-members/create-mailing.md
[8]: project-guide/create.md
[9]: ../../learn/basics/fav.md
[11]: ../../learn/basics/print.md
[12]: ../../custom-objects/learn/more-tab.md
[13]: project-guide/project-guide-tab.md
[16]: ../../learn/section-tabs/activities-tab.md
[17]: ../../learn/section-tabs/sales-tab.md
[18]: ../../learn/section-tabs/requests-tab.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/project/projects.png
[img2]: ../../../media/icons/arrow-left.png
[img3]: ../../../media/icons/arrow-right.png
[img5]: ../../../media/icons/select.png
[img4]: ../../../media/loc/en/project/project-guide-create.png
