---
uid: help-no-contact-merge
title: Slå sammen personer
description: Slå sammen personer
author: SuperOffice RnD
so.date: 06.29.2022
keywords: firma
so.topic: howto
language: no
---

# Slå sammen personer

[!include[Requirement](../../learn/includes/note-req-manage-entities.md)]

Hvis én fysisk person er registrert som to forskjellige personer i SuperOffice CRM, kan du slå sammen disse personene sammen. Hvis for eksempel personen ble registrert under to forskjellige navn hos samme firma ("Matias Hansen" og "Mathias Hanssen"), eller hvis personen ble registrert hos både den gamle og den nye arbeidsgiveren.

Prosjekdeltakelse og aktiviteter blir flyttet til målpersonen, og kildepersonen kan slettes eller angis som sluttet.

1. Åpne dialogboksen **Slå sammen personer** ved å gjøre ett av følgende:
    * I Firma-bildet: Gå til detaljkortet **Personer**, velg og høyreklikk på en eller to personer du vil slå sammen, velg **Vedlikehold personer** og **Slå sammen personer**.
    * I Person-bildet: Gå til ønsket person, klikk på ![ikon][img1] **Oppgave**-knappen i personkortet, velg **Vedlikehold personer**, og velg deretter **Slå sammen personer**.

2. Hvis du bare valgte én person, velger du en annen person under **Til** (begynn å skrive for å søke etter en person). De to personene du vil slå sammen, vises nå under **Fra** og **Til**.

    > [!TIP]
    > Hvis du vil bytte **Fra**\- og **Til**-personene, klikker du på ![ikon][img2] knappen.

3. Velg ett av følgende under **Utfør på [contact/company] etter sammenslåing**:
    * **Slett...**: Hvis du velger dette alternativet, slettes kildepersonen etter sammenslåingen.
        For eksempel hvis du har registrert den samme personen to ganger under samme firma.
    * **Merke som tidligere ansatt**: Hvis du velger dette alternativet, blir personen merket som tidligere ansatt etter sammenslåingen.
        For eksempel hvis en person har byttet jobb, men du fortsatt vil at vedkommende skal være registrert under det gamle firmaet.

4. Velg ett av følgende under **Handling på alle eksisterende aktiviteter og salg**:

    [!include[Select action](../../learn/includes/select-action-on-activity.md)]

    [!include[Preview results](../../learn/includes/note-preview-results.md)]

5. Klikk på **Slå sammen**. Personene slås sammen, og prosjektdeltakelse og medlemskap i statiske utvalg flyttes.

> [!NOTE]
> Du kan ikke slå sammen personer (SuperOffice-brukere) i ditt eget firma, men du kan slå sammen en person fra et annet firma med en person fra ditt eget firma.

## Aktuelle emner

* [Slå sammen firmaer][1]

<!-- Referenced links -->
[1]: ../../company/learn/merge-companies.md

<!-- Referenced images -->
[img1]: ../../../media/icons/btn-menu.png
[img2]: ../../../../common/icons/info-ball.png
