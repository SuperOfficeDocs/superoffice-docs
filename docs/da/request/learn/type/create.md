---
uid: help-da-request-type-create
title: Tilføj sagstype
description: Tilføj sagstype
author: Bergfrid Dias
date: 02.22.2024
version: 10.3.2
keywords: sag, type
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Tilføj sagstype

## Trin

1. I Indstillinger og vedligeholdelse, vælg **Sager** i navigatøren.

1. Vælg fanen **Sagstyper**.

1. Klik på **Tilføj**-knappen.

    ![Indstillinger og vedligeholdelse, Sager -screenshot][img1]

1. Indtast en kort beskrivende **Navn** for den nye sagstype. Du kan tilføje flere detaljer i **Beskrivelse**-feltet.

1. Valgfrit, ændr ikonet for visuelt at adskille sager af denne type fra andre sager.

1. Marker **Anvend som standard**, hvis du vil have, at denne sagstype skal være standarden for alle nye sager.

1. Valgfrit, filtrer listen over tilgængelige statusser og/eller prioriteter for sager af denne type.

    * For at tillade enhver [status][4] eller [prioritet][3], lad tilgængelighedsfeltet være tomt.
    * Hvis du vælger en eller flere statusser, skal du også vælge en standardstatus.
    * Hvis du vælger en eller flere prioriteter, skal du også vælge en standardprioritet.

    ![Indstillinger og vedligeholdelse, Sager status/prioritet -screenshot][img3]

1. Valgfrit, vælg en standardstatus og/eller prioritet til brug, når en agent opretter en sag af denne type. (Obligatorisk, hvis du indstiller tilgængelighed.) Denne indstilling har forrang frem for andre præferencer.

1. Valgfrit, vælg en [svarskabelon][5] til brug, når en agent svarer på en sag af denne type.

    ![Indstillinger og vedligeholdelse, Indstillinger for sagstype -screenshot][img2]

1. Klik på **Gem**. Sagstypen er oprettet.

<!-- Referenced links -->
[3]: ../priority/index.md
[4]: ../status/index.md
[5]: ../../reply-templates/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/request/add-request-type.png
[img2]: ../../../../media/loc/en/request/request-type-settings.png
[img3]: ../../../../media/loc/en/request/add-request-type-status-priority.png
