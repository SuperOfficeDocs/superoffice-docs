---
uid: help-da-contact-merge
title: Flette kontaktpersoner
description: Flette kontaktpersoner
author: SuperOffice RnD
so.date: 06.29.2022
keywords: firma
so.topic: howto
language: da
---

# Flette kontaktpersoner

[!include[Requirement](../../learn/includes/note-req-manage-entities.md)]

Hvis en fysisk person er registreret som to forskellige personer i SuperOffice CRM, kan du flette disse personer. For eksempel, hvis personen var registreret under to forskellige navne i samme virksomhed ("Jonathan Clark" og "Jonathon Clarke"), eller hvis personen var registreret hos både deres gamle og nye arbejdsgiver.

Projektmedlemskab og aktiviteter bliver flyttet til målpersonen, og kildepersonen kan slettes eller angives som fratrådt.

1. Åbn dialogboksen **Flet kontakter** ved at benytte en af følgende fremgangsmåder:
    * I skærmbilledet Firma: Gå til detaljekortet **Personer**, vælg og højreklik på en eller to personer, som du vil lægge sammen, vælg **Vedligehold personer** og **Slå personer sammen**.
    * I skærmbilledet Person: Gå til den ønskede person, klik på ![ikon][img1] knappen **Opgave** på personkortet og vælge **Administrer personer** og **Flet personer**.

2. Hvis du kun har valgt én person, skal du vælge en person under **Til** (begynd at skrive for at søge efter en person). De to personer, du vil lægge sammen, vises nu under **Fra** og **Til**.

    > [!TIP]
    > Hvis du vil bytte om på **Fra-** og **Til-**personer, skal du klikke på knappen ![ikon][img2].

3. Vælg en af følgende under **Handling på \[contact/company\] efter sammenlægning**:
    * **Slet**: Hvis du vælger dette alternativ, slettes kildepersonen efter sammenlægningen.
        Dette kan være aktuelt, hvis en person er registreret to gange på samme firma.
    * **Marker som tidligere ansat**: Hvis du vælger denne indstilling, bliver personen markeret som tidligere ansat efter sammenlægningen.
        Dette kan være aktuelt, hvis en person har skiftet job, men fremover skal være registreret på det gamle firma.

4. Vælg et af følgende **Handling på alle eksisterende aktiviteter og salg**:

    [!include[Select action](../../learn/includes/select-action-on-activity.md)]

    [!include[Preview results](../../learn/includes/note-preview-results.md)]

5. Klik på **Slå sammen**. Personerne lægges sammen, og projektmedlemskab og medlemskab i statiske udvalg flyttes.

> [!NOTE]
> Du kan ikke sammenlægge personer (SuperOffice-brugere) i dit eget firma, men du kan lægge en person fra et andet firma sammen med en person fra dit eget firma.

## Relaterede emner

* [Flet kontakter][1]

<!-- Referenced links -->
[1]: ../../company/learn/merge-companies.md

<!-- Referenced images -->
[img1]: ../../../media/icons/btn-menu.png
[img2]: ../../../../common/icons/info-ball.png
