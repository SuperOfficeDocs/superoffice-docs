---
uid: help-da-contact-merge
title: Slå personer sammen
description: Sådan slår du dublerede personer sammen i SuperOffice CRM for at samle aktiviteter, salg og projektmedlemskaber.
keywords: slå personer sammen, vedligehold personer, kontaktperson
author: Bergfrid Dias
date: 03.07.2025
version: 10.5.2
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Slå personer sammen

[!include[Requirement](../../learn/includes/note-req-manage-entities.md)]

Hvis den samme person er registreret under forskellige navne eller firmaer i SuperOffice CRM (for eksempel "Jonathan Clark" og "Jonathon Clarke"), kan du slå deres poster sammen for at samle aktiviteter, salg og projektmedlemskaber.

> [!NOTE]
> Du kan ikke slå personer (SuperOffice-brugere) i dit eget firma sammen. Du kan dog slå en person fra et andet firma sammen med en person i dit eget firma.

## Trin

1. Åbn dialogboksen **Slå personer sammen**:

    * I **skærmbilledet Person**: Gå til den ønskede person, klik på **Opgave**-knappen (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>), og vælg **Vedligehold personer** > **Slå personer sammen**.

    * I **skærmbilledet Firma**: Gå til detaljekortet **Personer**, vælg en eller to personer, højreklik, og vælg **Vedligehold personer** > **Slå personer sammen**.

2. Hvis du kun har valgt én person, skal du vælge en anden person under **Til**. Begynd at skrive for at søge efter en person. Hvis du vil bytte om på **Fra**- og **Til**-personer, skal du klikke på pilknappen <i class="ph ph-arrows-left-right" aria-hidden="true"></i>.

3. Under **Handling på \[person/firma\] efter sammenlægning**, vælg en af følgende:

    * **Slet \[kildeperson\]:** Sletter kildepersonen efter sammenlægningen (bruges ved dubletter).
    * **Marker som tidligere ansat:** Markerer kildepersonen som tidligere ansat (bruges hvis personen har skiftet job).

4. Under **Handling på alle eksisterende aktiviteter og salg**, vælg en mulighed:

    [!include[Select action](../../learn/includes/select-action-on-activity.md)]

5. Klik på **Slå sammen**. Følgende sker:

    * Alle oplysninger samles i én post.
    * Aktiviteter og salg forbliver knyttet til målpersonen, eller de flyttes afhængigt af din valgte handling.
    * Projektmedlemskab og medlemskab i statiske udvalg følger målpersonen.
    * Den valgte handling (slet eller marker som tidligere ansat) anvendes på kildepersonen.

![Dialogboksen Slå personer sammen viser muligheder for at håndtere dublerede personer, aktiviteter og efterfølgende handlinger. -screenshot][img4]

## Relateret indhold

* [Slå firmaer sammen][1]
* [Gendan slettede firmaer og personer][2]

<!-- Referenced links -->
[1]: ../../company/learn/merge-companies.md
[2]: ../../learn/basics/deleting-elements.md#restore

<!-- Referenced images -->
[img4]: ../../../media/loc/en/contact/merge-contacts.png
