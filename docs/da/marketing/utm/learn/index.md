---
uid: help-da-conversion-tracking
title: Konverteringssporing
description: Lær, hvordan konverteringssporing i SuperOffice CRM identificerer, hvilke marketingkanaler og kampagner der genererer leads.
keywords: UTM, konvertering, leadkilde, sporing
author: digitaldiina
date: 11.06.2025
version: 11.6
content_type: concept
category: marketing
topic: conversion
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
redirect_from:
  - /da/marketing/utm/index
  - /da/marketing/utm/admin/index
language: da
---

# Konverteringssporing

Markedsførere har ofte svært ved at forstå, hvilke kampagner, kanaler eller platforme der genererer de mest værdifulde leads. Uden denne viden er det svært at optimere budgettet eller dokumentere afkastet (ROI).

Konverteringssporing i SuperOffice hjælper dig med at knytte marketingaktiviteter til faktiske resultater. Den bruger **UTM-parametre** til at identificere, hvor hvert lead kommer fra, og hvordan besøgende interagerer med dit websted, før de bliver personer eller salgsmuligheder.

Ved at spore kilden til hvert lead kan du:

* Se præcist, hvor hvert lead kom fra (f.eks. LinkedIn-annonce, nyhedsbrev eller Google-søgning)
* Identificere hvilke kanaler og kampagner der genererer flest leads og aftaler
* Sammenligne kampagnepræstationer og fokusere budgettet på det, der virker

For at forstå, hvordan UTM-sporing fungerer i detaljer, se [UTM-parametre forklaret][1].

## Datapunkter, der spores i SuperOffice CRM

SuperOffice registrerer flere vigtige datapunkter, der hjælper dig med at forstå, hvordan leads bliver oprettet og konverteret.

| Datapunkt | Beskrivelse | Lagringsniveau |
|---|---|---|
| **Første kontaktpunkt** | Den allerførste kilde, medie og kampagne, der fik personen til at interagere med virksomheden. | Person |
| **Lead-oprettelse** | Den kilde, det medie og den kampagne, der førte til, at leadet faktisk blev oprettet i CRM. | Person |
| **Konvertering** | Den seneste kilde, det medie og den kampagne, der fik en eksisterende person til at indsende en ny formular. | Formularindsendelse |
| **Virksomhedskilde** | Når en ny person tilføjes, og et firmakort oprettes samtidigt, gemmes kilden på firmakortet. | Firma |

> [!NOTE]
> Første kontaktpunkt, lead-oprettelse og virksomhedskilde spores kun for nye personer og virksomheder, der ikke allerede findes i CRM.

## Sådan registreres lead-kilden

En besøgende klikker på en **LinkedIn-annonce** og lander på dit websted. Når vedkommende ankommer, gemmes *første kontaktpunktdata* – herunder kilde, medie og kampagne – i browseren. Den besøgende forlader siden uden yderligere handling.

Senere klikker den samme person på en **Facebook-annonce** og vender tilbage til webstedet. Denne gang udfylder vedkommende og **indsender en formular**. Når formularen indsendes, registrerer SuperOffice kildeoplysningerne fra URL’en.

Hvis indsendelsen opretter en ny person eller et nyt lead i SuperOffice CRM, gemmes både **første kontaktpunkt** og **lead-oprettelse** på personkortet.

```mermaid
flowchart TD
    subgraph Journey["Besøgsrejse"]
        A["<br/>&#8203;Klikker på LinkedIn-annonce<br/> "] --> B["<br/>&#8203;Besøger websted<br/> "]
        B --> C["<br/>&#8203;Forlader webstedet<br/> "]
        C --> D["<br/>&#8203;Første kontaktpunkt gemt i browseren<br/> "]
        D --> E["<br/>&#8203;Klikker på Facebook-annonce<br/> "]
        E --> F["<br/>&#8203;Besøger webstedet igen<br/> "]
        F --> G["<br/>&#8203;Indsender formular<br/> "]
    end

    subgraph CRM["CRM-behandling"]
        G --> H["<br/>&#8203;Kilde registreret<br/> "]
        H --> I["<br/>&#8203;Både første kontaktpunkt og lead-oprettelse gemt i SuperOffice<br/> "]
    end

    style Journey fill:#f5faff,stroke:#c0d9f1,stroke-width:1px
    style CRM fill:#f2fff8,stroke:#a8e0c0,stroke-width:1px
```
<!--Alt-tekst: Flow, der viser hvordan første kontaktpunkt og lead-oprettelse gemmes i SuperOffice CRM efter en formularindsendelse.-->

## Virkelige eksempler

### Brugssag 1: Identificér hvilken kanal der giver flest tilmeldinger

Du afholder et **webinar** og promoverer det via et **LinkedIn-opslag**, en **Google-annonce** og et **nyhedsbrev**.

Efter arrangementet vil du vide:

* Hvilken kanal gav flest tilmeldinger?
* Hvilke leads blev senere til salgs­muligheder?

**Rapporter i SuperOffice viser:**

* 50 % af tilmeldingerne kom fra LinkedIn.
* Leads fra nyhedsbrevet har en 30 % højere konverteringsrate.

Disse indsigter hjælper dig med at justere budget og budskab til fremtidige kampagner.

### Brugssag 2: Sammenlign resultater på tværs af partneraktiviteter

Du kører tre marketingaktiviteter med forskellige partnere:

* Et partnernyhedsbrev
* Et fælles webinar
* Et henvisningslink på partnerens websted

Du vil vide, hvilken aktivitet der genererer flest nye leads og aftaler.

| Kilde | Medium | Leads | Aftaler |
|---|---|---|---|
| Partner A | Email | 30 | 2 |
| Partner B | Webinar | 50 | 10 |
| Partner C | Henvisning | 10 | 1 |

Konverteringssporing i SuperOffice hjælper dig med at sammenligne partnerresultater og fokusere på det, der giver målbare resultater.

## Eksempel på sporingslink

Du kan tilføje UTM-parametre til alle kampagnelinks for at identificere trafikkilder.

```text
https://yourcompany.com/signup?utm_source=linkedin&utm_medium=social&utm_campaign=webinar_sept
```

Brug UTM-builderen til SuperOffice-formularer til at oprette kampagnelinks med ensartede navne.

## Relateret indhold

* [UTM-parametre forklaret][1]
* [Aktivér UTM-sporing for formularindsendelser][3] i Indstillinger og vedligeholdelse
* [UTM-builder til SuperOffice-formularer][2]
* [Lead-dashboards og rapporter][5]

[1]: parameters.md
[2]: ../../forms/learn/publish.md
[3]: ../admin/set-up.md
[5]: ../../../dashboard/learn/show-marketing.md
