---
uid: help-no-flow-split
title: Flytkontroll - oppdeling
description: Flytkontroll - oppdeling
keywords: flyt, automatisering, gren, oppdeling, splitt, del opp
author: Bergfrid Dias
date: 11.19.2024
version: 10.3.12
topic: howto
audience: person
audience_tooltip: SuperOffice Marketing
language: no
---

# Flytkontroll - oppdeling

Et oppdelingstrinn sprer flytens deltakere på 2 eller flere grener basert på en eller flere betingelser. Dette lar deg bruke alternative stier, og behandle deltakere forskjellig basert på persondata eller engasjement.

Du kan differensiere basert på:

* Firma/persondata
* Skjemainnsending
* Skjemadata
* Lenkeklikk (sporet)
* Medlemskap i prosjekt
* Medlemskap i statisk utvalg

## Hvordan det fungerer

Når deltakeren kommer til delingen, blir kriteriene for grenen **helt til venstre** vurdert først. Deltakere kan bare følge én sti. Hvis det er et treff, flyttes de til neste trinn i den grenen. Deretter sjekkes betingelsen for neste gren, og så videre. Alle delinger har en gren for alle som ikke oppfyller noen av betingelsene.​

## Trinn

1. Dra **Del**-boksen fra trinnmenyen og slipp den inn i et tilgjengelig plass i flytdiagrammet.
1. Angi en beskrivende **tittel**.

    > [!TIP]
    > En beskrivende tittel og grennavn gjør flyten enklere å lese​.

1. Velg hva oppdelingen skal baseres på. Noen alternativer krever at du gir ytterligere detaljer her.
1. Gi navn til den nye grenen.
1. Angi grenspesifikke kriterier. Alternativene avhenger av hva oppdelingen er basert på.
1. Valgfritt, legg til flere grener og gjenta trinn 4-5.
1. Velg om deltakere som ikke oppfyller noen vilkår, skal avslutte flyten.
1. Fortsett å legge til trinn for hver gren.

Alle andre fortsetter:

![Markedsføringsautomatisering: del opp flyt basert på persondata -screenshot][img1]

Alle andre avslutter:

![Markedsføringsautomatisering: del opp flyt basert på persondata -screenshot][img2]

> [!NOTE]
> Du kan ikke slette grenen "alle andre".

### Oppdeling basert på persondata

Når du velger å dele deltakere basert på persondata, kan du velge fra person- og firmakriteriene som er tilgjengelige i **Finn person**.

* For hver gren, [velg verdier for kriteriene][11] i de ulike feltene på linjen (tilsvarende som i Finn-skjermen). Klikk **Legg til** for å legge til flere kriterier.

![Markedsføringsautomatisering: del opp flyt basert på firmadata -screenshot][img3]

### Oppdeling basert på lenke klikket

Når valgt, vises et felt for å spesifisere hvilken e-post som vises.

* E-post: Velg **Enhver e-post** eller en spesifikk utsendelse.
* For hver gren, velg hvilken [sporet lenke][7] deltakeren må klikke på for å komme inn i denne grenen.

![Markedsføringsautomatisering: del opp flyt basert på lenke klikket -screenshot][img4]

### Oppdeling basert på skjemainnsending (ja/nei)

Når valgt, vises et felt for å spesifisere hvilket skjema som vises.

* Skjema: Velg et spesifikt skjema.

![Markedsføringsautomatisering: del opp flyt basert på skjemainnsending -screenshot][img5]

> [!NOTE]
> Denne oppdelingen er uavhengig av hvilke skjemadata som ble sendt inn. Det er ingen grenspesifikke innstillinger. Siden dette er en ja/nei-test, kan du ikke legge til flere grener.

### Oppdeling basert på skjemadata

Denne betingelsen er en variant av innsendingsbasert oppdeling med ytterligere datakriterier som gjelder for grenen.

Når valgt, vises et felt for å spesifisere hvilket skjema som vises.

* Skjema: Velg et spesifikt skjema.
* For hver gren, velg verdier for kriteriene i de ulike feltene på linjen (tilsvarende som i Finn-skjermen). Tilgjengelige kriterier avhenger av det valgte skjemaets felt. Klikk **Legg til** for å legge til flere kriterier.

![Markedsføringsautomatisering: del opp flyt basert på skjemadata (kontakt meg) -screenshot][img6]

> [!NOTE]
> I dette scenariet betyr **alle andre** både deltakere som ikke sender inn skjema *og* innsendere som ikke oppfyller de ekstra kriteriene på noen av de andre grenene.

### Oppdeling basert på prosjektmedlemskap

* For hver gren, velg hvilket prosjekt deltakeren må være medlem av.

![Markedsføringsautomatisering: del opp flyt basert på prosjektmedlemskap -screenshot][img7]

### Oppdeling basert på statisk utvalg

Tilsvarende som for oppdeling basert på prosjektmedlemskap.

## Suksesskriterier brukt som tidlig avslutningsbetingelse

Suksesskriterier kan også brukes som en tidlig avslutningsbetingelse i flyten, noe som eliminerer behovet for forgrening. Før noen handling utføres på en deltaker i et flyttrinn, blir deltakerens status evaluert på nytt. Denne re-evalueringen tar hensyn til suksesskriteriene. Hvis en deltaker oppfyller suksesskriteriene, oppdateres statusen deres til *Fullført med suksess*, eller de fortsetter som *Aktiv* hvis de skal fullføre flyten. På avslutningstrinnet får deltakere som har oppfylt suksesskriteriene statusen *Fullført med suksess*.

<!-- Referenced links -->
[7]: ../../tracked-links/learn/index.md
[11]: ../../../search-options/learn/search-criteria.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/split-flow-contact-data-no-exit.png
[img2]: ../../../../media/loc/en/marketing/split-flow-contact-data-yes-exit.png
[img3]: ../../../../media/loc/en/marketing/split-flow-company-data-dropdown.png
[img4]: ../../../../media/loc/en/marketing/split-flow-link-clicked.png
[img5]: ../../../../media/loc/en/marketing/split-flow-form-submitted.png
[img6]: ../../../../media/loc/en/marketing/split-flow-form-data-contact-me.png
[img7]: ../../../../media/loc/en/marketing/split-flow-project-member.png
