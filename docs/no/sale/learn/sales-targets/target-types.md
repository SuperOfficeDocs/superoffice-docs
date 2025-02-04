---
uid: help-no-sales-target-types
title: Sette opp en salgsmåltype med undertyper
description: "Å holde seg oppdatert på salgsmålene dine kan være stressende. Men hvis du definerer parametere og dimensjoner for salgsmålene dine, blir det mye enklere å administrere målene."
author: SuperOffice RnD
date: 02.16.2023
keywords: salg
topic: howto
language: no
---

# Sette opp en salgsmåltype med undertyper

Å holde seg oppdatert på salgsmålene dine kan være stressende. Men hvis du definerer parametere og dimensjoner for salgsmålene dine, blir det mye enklere å administrere målene.

Du kan legge til nye måltyper (dimensjoner) i tillegg til standard måltype **Alle salg – beløp**.

> [!NOTE]
> Du trenger Sales Premium-lisens og Sales Targets Unlimited-lisens for å legge til mer enn én brukergruppe og måltype. Hvis du bare har Sales Premium-lisens, kan du legge til én gruppe for måltypen Alle salg – beløp.

Du må ha den funksjonelle rettigheten Måladministrator for rollen din for å kunne legge til, redigere og fjerne måltyper.

## Angi måltype

For å definere parameterne og dimensjonene må du først angi en måltype.

Du kan angi en måltype for både brukere og grupper, samt angi andre målparametere: Måltype, Måleenhet, Separate salgsmål. Du kan også bestemme om den bare skal være tilgjengelig på firma- og gruppenivå (og ikke på brukernivå).

![Oversikt over de ulike måltypene og undertypene for et salgsmål -screenshot][img1]

## Legg til ny måltype

1. Klikk på **Legg til ny måltype**. Du kan også klikke på <i class="ph ph-gear" aria-label="Gear"></i> (**Konfigurer mål**) på fanen for å redigere en eksisterende måltype.

2. Klikk på **Måltype** for å velge måltypen (dimensjonen) du vil bruke.

3. Klikk på **Måleenhet** for å velge den aktuelle enheten. De tilgjengelige enhetene vil avhenge av den valgte måltypen. Hvis du valgte **Kategori** som måltype, kan du for eksempel velge å måle etter beløp eller antall (antall salg i en kategori).

4. I den neste listen kan du velge bestemte elementer i måltypen du har valgt. Hvis du ikke velger noen, vil alle bli inkludert. Eksempel: Hvis du valgte **Kategori** som måltype, kan du velge firmakategoriene du vil opprette mål for.

5. Velg **Tilgjengelig kun på firma- og gruppenivå** hvis denne måltypen ikke bør være tilgjengelig på brukernivå, bare for gruppe-/teamnivå og firmanivå.

6. Klikk på **Lagre**. Den nye måltypen legges til som en fane. Du kan nå legge til mål som beskrevet ovenfor.

> [!NOTE]
> Måltype og måleenhet kan ikke endres i en eksisterende måltype. Du kan alternativt opprette en ny måltype med de nødvendige innstillingene, og deretter slette den gamle.

### Måltyper (parametere)

* Alle salg
* Salgstype
* Salg kilde
* Salg kreditert
* Salg konkurrent
* Firma kategori
* Firma bransje
* Firma land

Du kan også angi mål for alle dine egne brukerdefinerte felt som inneholder lister. For at det ikke skal være mulig å opprette duplikater, er det ikke mulig å velge en valgt måltype på nytt.

### Måleenhet

Du kan måle et salg på forskjellige måter. Velg din foretrukne enhet avhengig av hvilke enheter firmaet ditt bruker.

* Beløp
* Antall
* Fortjeneste

### Separate salgsmål – undertyper (dimensjoner)

Hvilke undertyper som er tilgjengelige, avhenger av hvilken måltype som er valgt. For eksempel:

* Hvis måltypen er satt til Salgstype, viser undertypene av mål listen for salgstyper som er definert av firmaet ditt.
* Hvis måltypen er satt til Kilde, viser undertypene av mål listen for salgskilder som er definert av firmaet ditt.

Nederst i dialogboksen finner du avmerkingsboksen Tilgjengelig kun på firma- og gruppenivå. Når du merker av i denne avmerkingsboksen, blir måltypen bare lagt til på firma- og gruppenivå, og de forskjellige brukerne vises ikke i mållisten.

> [!NOTE]
> Når du har lagret det nye målet, kan du fortsatt gå til Innstillinger og endre listen Separate salgsmål og avmerkingsboksen for Tilgjengelig kun på firma- og gruppenivå. Vær oppmerksom på at hvis du velger Tilgjengelig kun på firma- og gruppenivå etter at du har lagt til numre på brukernivå, får du en advarsel om at brukernumrene vil bli slettet når målet lagres.

Når den nye måltypen er lagret, er det på tide å [legge til grupper og brukere i salgsmålet][3].

![Du finner knappen Legg til grupper og brukere i oversikten over salgsmål -screenshot][img2]

## Filtrere måltyper

Når det gjelder måltypene med listen over undertyper av mål, kan du klikke på Filter-knappen og filtrere på de forskjellige listeelementene.

![Klikk på filterknappen for å filtrere på målundertype -screenshot][img3]

## Fjerne måltyper

For å slette en måltype klikker du på Målinnstillinger og deretter på Slett-knappen. Husk at sletting av en måltype er en ikke-reversibel handling, og at alle data for måltypen slettes for tidligere, inneværende og fremtidige år. Standard måltype Alle salg – beløp er ikke mulig å slette.

## Aktuelle emner

* [Bruke salgsmål i figurer på dashbordet][2]

<!-- Referenced links -->
[2]: ../../../dashboard/learn/show-sales-targets.md
[3]: create.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/user-targets-new-target-type.png
[img2]: ../../../../media/loc/en/sale/user-targets-add-groups-users.png
[img3]: ../../../../media/loc/en/sale/user-targets-filter-type.png
