---
uid: help-da-request-close
title: Luk en sag
description: Sådan lukker du en eller flere sager i SuperOffice.
keywords: luk sag, indstil status lukket, lukket, masseopdatering, sag
author: Bergfrid Dias
date: 03.07.2025
version: 10.5.2
topic: howto
license: serviceessentials
audience: person
audience_tooltip: SuperOffice Service
language: da
---

# Luk sager

At lukke en sag betyder at ændre dens [status][5] til *Lukket*.

## Luk en enkelt sag

Efter at have [besvaret sagen][3], skal du vælge **Lukket** i feltet **Status** i egenskabspanelet.

## Luk flere sager med masseopdatering

Du kan hurtigt lukke flere sager ved at indstille feltet **Status** til *Lukket* i **Masseopdatering**-dialogen.

1. Åbn listen over sager, du vil opdatere. Du kan bruge:
    * En **gemt udvælgelse** i Udvælgelsesskærmen.
    * Søgeresultater fra skærmbilledet **Find sager**.
    * **Detaljekortet Sager** (på et firma eller en person).

1. Åbn **Masseopdatering**-dialogen:
    * **Udvælgelser:** Klik på <i class="ph ph-dots-three-circle-vertical" aria-label="Opgaveknap"></i> og vælg **Masseopdatering**.
    * **Find sager:** Vælg sagerne, klik på <i class="ph ph-list" aria-hidden="true"></i> **Opgave**-knappen i nederste venstre hjørne, og vælg **Masseopdatering**.
    * **Detaljekortet Sager:** Vælg sagerne, højreklik og vælg **Masseopdatering**.

1. I **Masseopdatering**-dialogen:
    * I kolonnen **Felt**, skriv eller vælg **Status**.
    * I kolonnen **Handling**, vælg **Vælg én**.
    * I kolonnen **Ny værdi**, vælg **Lukket**.
    * Sørg for, at kun afkrydsningsfeltet ved **Status** er markeret.

    ![Masseopdatering af sager -screenshot][img1]

    Du kan eventuelt opdatere andre felter, men vær forsigtig.

1. Klik på **Opdater**.

1. Gennemgå oversigten i **Bekræft**-dialogen. Den viser de felter, der skal opdateres, og antallet af berørte sager.

    ![Bekræft masseopdatering -screenshot][img2]

1. Klik på **Ja** for at anvende ændringerne. De valgte sager lukkes nu.

    > [!CAUTION]
    > Når en opdatering er anvendt, kan den ikke fortrydes. Du kan dog stoppe opdateringen, mens den er i gang. Eventuelle poster, der endnu ikke er opdateret, forbliver uændrede.

## Relateret indhold

* [Opdater flere poster (masseopdatering)][1]
* [Opret en udvælgelse][6]
* [Detaljekortet Sager][2]
* [Find sager][4]

<!-- Referenced links -->
[1]: ../../learn/basics/bulk-update.md
[2]: ../../learn/section-tabs/requests-tab.md
[3]: reply.md
[4]: find.md
[5]: ../admin/status/index.md
[6]: ../../search-options/selection/learn/create/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/request/bulk-update-requests.png
[img2]: ../../../media/loc/en/request/bulk-update-confirm.png
