---
uid: help-no-project
title: Prosjekt
description: Denne veiledningen viser deg hvordan du oppretter og bruker prosjekter for å holde oversikt over arbeidet ditt.
author: SuperOffice RnD
so.date: 02.10.2023
keywords: prosjekt
so.topic: concept
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

## <a id="more-tab" />Fanen Mer

![Mer-fanen (Prosjekt) -screenshot][img4]

I fanen **Mer** finner du brukerdefinerte felt for prosjektet. Hvis din organisasjon har behov for å ha flere felt enn de som er standard i fanen **Prosjekt**, kan du definere i Innstillinger og vedlikehold at disse feltene skal legges inn her.

Klikk på **Rediger** for å redigere prosjektinformasjonen i fanen **Mer**.

Tre av de brukerdefinerte feltene fra fanen **Mer** kan også vises i fanen **Prosjekt**.

## Fanen Notat

[!include[About the Note tab](../../learn/includes/about-note-tab.md)]

## <a id="event-tab" />Fanen Arrangement

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

## Legge til prosjekt i favoritter

[!include[ALT](../../learn/includes/howto-add-favorite.md)]

## Skrive ut prosjektinformasjon

1. [!include[Go to project](includes/goto-project.md)]
2. Klikk på **Oppgave**-knappen og velg **Skriv ut**.
3. I vinduet som viser innholdet som skal skrives ut, klikker du **Skriv ut**.

## Hva vil du gjøre nå?

* [Opprette et prosjekt][2]
* [Redigere et prosjekt][3]
* [Slå sammen prosjekter][4]
* [Slette et prosjekt][5]
* [Sende et dokument til prosjektdeltakere][7]
* [Prosjektguide][1]

<!-- Referenced links -->
[1]: project-guide/index.md
[2]: create.md
[3]: edit.md
[4]: merge-projects.md
[5]: delete.md
[7]: project-members/create-mailing.md
[8]: project-guide/create.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/project/projects.png
[img2]: ../../../media/icons/arrow-left.png
[img3]: ../../../media/icons/arrow-right.png
[img4]: ../../../media/loc/en/project/project-more.png
[img5]: ../../../media/icons/select.png
