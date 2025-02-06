---
uid: help-no-contact-merge
title: Slå sammen personer
description: Lær hvordan du slår sammen dubletter i SuperOffice CRM for å samle aktiviteter, salg og prosjektmedlemskap. Inkluderer en trinn-for-trinn-guide til bruk av dialogen Slå sammen personer.
keywords: slå sammen personer, administrer personer, vedlikehold personer, dublet, tidligere ansatt, person
author: Bergfrid Dias
date: 01.27.2025
version: 10.5
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Slå sammen personer

[!include[Requirement](../../learn/includes/note-req-manage-entities.md)]

Hvis samme person er registrert under forskjellige navn eller firmaer i SuperOffice CRM (for eksempel, "Matias Hansen" og "Mathias Hanssen"), kan du slå sammen kontaktene deres for å samle aktiviteter, salg og prosjektmedlemskap.

> [!NOTE]
> Du kan ikke slå sammen personer (SuperOffice-brukere) i ditt eget firma, men du kan slå sammen en person fra et annet firma med en person i ditt eget firma.

## Trinn

1. Åpne dialogboksen **Slå sammen personer**:

    * I **Person-bildet**: Gå til den ønskede personen, klikk på <i class="ph ph-dots-three-circle-vertical" aria-label="Oppgave"></i>, og velg **Vedlikehold personer** > **Slå sammen personer** fra menyen.

    * I **Firma-bildet**: Gå til detaljkortet **Personer**, velg én eller to personer, høyreklikk, og velg **Vedlikehold personer** > **Slå sammen personer**.

2. Hvis du kun har valgt én person, velg en annen person under **Til**. Begynn å skrive for å søke etter personen. For å bytte mellom **Fra**- og **Til**-personene, klikk på <i class="ph ph-arrows-left-right" aria-label="dobbelpilen"></i>.

3. Under **Utfør på \[person/firma\] etter sammenslåing**, velg ett av følgende alternativer:

    * **Slett \[kildeperson\]:** Sletter kildepersonen etter sammenslåing (nyttig ved dubletter).
    * **Merk som tidligere ansatt:** Markerer kildepersonen som tidligere ansatt (nyttig ved jobbskifte).

4. Under **Handling på alle eksisterende aktiviteter og salg**, velg ett alternativ:

    [!include[Select action](../../learn/includes/select-action-on-activity.md)]

5. Klikk på **Slå sammen**. Følgende skjer:

    * Alle detaljer blir slått sammen.
    * Aktiviteter og salg forblir knyttet til målpersonen, eller de flyttes basert på valget ditt.
    * Prosjektdeltakelse og medlemskap i statiske utvalg følger målpersonen.
    * Den valgte handlingen (slett eller marker som tidligere ansatt) brukes på kildepersonen.

![Dialogboksen Slå sammen personer med alternativer for å håndtere dubletter -screenshot][img1]

## Relatert innhold

* [Slå sammen firmaer][1]
* [Gjenopprett slettede firmaer og personer][2]

<!-- Referenced links -->
[1]: ../../company/learn/merge-companies.md
[2]: ../../learn/basics/deleting-elements.md#restore

<!-- Referenced images -->
[img1]: ../../../media/loc/en/contact/merge-contacts.png
