---
uid: help-da-project-guide-tutorial
title: Projektguide vejledning
description: En trinvis vejledning i brug af projektguider i SuperOffice CRM.
keywords: projektguide, guide, workflow, projekt
author: SuperOffice RnD
date: 03.07.2025
version: 10.5.2
topic: tutorial
license: salespremium, servicepremium, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Projektguide vejledning

Husk, at dine projektguider kan være konfigureret forskelligt i Indstillinger og vedligeholdelse.

## Opret et nyt projekt og vælg en projekttype

Du registrerer et nyt projekt og vælger projekttypen **Konference**, som er tilknyttet en projektguide. Projektguiden indeholder følgende statusser, opfølgninger og dokumenter:

| Status | Opfølgninger | Dokumenter |
|---|---|---|
| Planlagt | Planlægningsmøde (Møde internt) | Konferenceprogram (Notat) |
| Igangværende | Opret liste over projektdeltagere (Opfølgning) | Konference (Møde eksternt) |
| Afslutning | Evalueringsmøde (Møde internt) | Evalueringsrapport (Notat) |

## Statussen Planlagt

1. Du har aftalt en mødetid og vil oprette opfølgningen **Planlægningsmøde** i dagbogen og invitere deltagere.

    1. I projektguiden klikker du på **Opret** ved siden af **Planlægningsmøde**.
        Dialogboksen **Opfølgning** åbnes med **Møde internt** valgt som type, og projektets navn er forudfyldt.
    1. Udfyld oplysningerne og [inviter deltagere][1].
    1. Klik på **Gem**.

1. På mødet planlægger du konferencens program og vil gemme det i et notat.

    1. Klik på **Opret** ved siden af **Konferenceprogram**.
        Dialogboksen **Dokument** åbnes med **Notat** som valgt dokumenttype og projektets navn forudfyldt.
    1. Udfyld de nødvendige felter.
    1. Klik på **Opret** for at gemme notatet.

1. Når mødet er gennemført, og konferenceprogrammet er klar, skal du angive dette i projektguiden og gå videre til næste projektstatus.

    I projektguiden markerer du afkrydsningsfeltet ved siden af opfølgningen **Planlægningsmøde**.

    > [!TIP]
    > Du kan også gøre dette fra aktivitetslisten i dagbogen eller firmaskærmbilledet.

    1. Dialogboksen **Projektguide - flyt projektet til næste status** åbnes.
    1. I denne dialogboks bliver du spurgt, om du vil flytte projektet til næste status, som er **Er i gang**.
    1. Klik på **Ja** for at flytte projektet til næste status.

    > [!NOTE]
    > Dialogboksen **Projektguide - flyt projektet til næste status** åbnes, fordi det er defineret for projekttypen i Indstillinger og vedligeholdelse.

## Statussen Igangværende

1. Alle opfølgninger og dokumenter i **Planlagt** er gennemført, og du har flyttet projektet videre. Opfølgninger og dokumenter for denne nye status vises nu i **Projektguide**-detaljekortet.

    > [!NOTE]
    > Dialogboksen for automatisk statusændring vises kun, hvis denne funktion er aktiveret i Indstillinger og vedligeholdelse. Ellers skal du [skifte status manuelt][2].

1. På planlægningsmødet blev det aftalt, at en kollega skal oprette en liste over deltagere. Du vil oprette en opgave til dem.

    1. Klik på **Opret** ved siden af **Opret liste over projektdeltagere**.
        Dialogboksen **Overfør opgaven til en projektdeltager** åbnes.

    1. Vælg den relevante medarbejder fra projektteamet, og klik på **OK**.

    1. Udfyld de nødvendige oplysninger og klik på **Gem**. (På fanen **Detaljer** kan du se, at din kollega allerede er angivet som ejer af opgaven.)

    1. Opfølgningen vises nu i din kollegas dagbog. Når listen er færdig, markerer de opgaven som **Udført**.

    > [!NOTE]
    > Dialogboksen **Overfør opgaven til en projektdeltager** åbnes, fordi det er defineret i Indstillinger og vedligeholdelse.

1. Nu vil du sende en invitation til konferencen.

    Klik på **Opret** ved siden af **Konferenceinvitation**, og [opret dokumentet][3].

1. Til sidst afholder du selve konferencen og opretter en opfølgning til dette.

    1. Klik på **Opret** ved siden af **Konference**.
       Dialogboksen **Opfølgning** åbnes med **Møde eksternt** som valgt type.
    2. Udfyld oplysningerne og inviter deltagerne.
    3. Klik på **Gem**.

## Statussen Afslutning

1. Når konferencen er afholdt, og alle aktiviteter i **Igangværende**-status er afsluttet, skifter du til **Afslutning**.

    * Klik på **Ja** i **Projektguide - flyt projektet til næste status**-dialogen.
    * Eller klik på **Rediger** (<i class="ph ph-pencil-simple" aria-hidden="true"></i>) i projektkortet, vælg **Afslutning** i **Status**-feltet, og klik på **Gem**.

1. Du vil afholde et evalueringsmøde for at opsummere konferencen.

    1. Klik på **Opret** ved siden af **Evalueringsmøde**.
    1. Udfyld oplysningerne og gem opfølgningen.
    1. Når mødet er afsluttet, markerer du det som udført.

1. Endelig vil du lave en evalueringsrapport.

    Klik på **Opret** ved siden af **Evalueringsrapport**, og opret dokumentet.

Når alle opfølgninger og dokumenter for projektet er færdige, kan du markere projektet som afsluttet.

<!-- Referenced links -->
[1]: ../../diary/learn/invitation/add-attendee.md
[2]: project-guides.md#change-status
[3]: ../../document/learn/edit.md
