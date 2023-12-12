---
uid: help-no-request-type-create
title: Legg til sakstype
description: Legg til sakstype
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: sak, type
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: no
---

# Legg til sakstype (kun i pilot)

## Trinn

1. I Innstillinger og vedlikehold, velg **Saker** i navigatøren.

1. Velg fanen **Saksstyper**.

1. Klikk på **Legg til**-knappen.

    ![Innstillinger og vedlikehold, Saksstyper -screenshot][img1]

1. Skriv inn en kort beskrivende **Navn** for den nye sakstypen. Du kan legge til flere detaljer i **Beskrivelse**-feltet.

1. Valgfritt, endre ikonet for å visuelt skille saker av denne typen fra andre saker.

1. Merk av for **Bruk som standard** hvis du vil at denne sakstypen skal være standarden for alle nye saker.

1. Valgfritt, filtrer listen over tilgjengelige statuser og/eller prioriteter for saker av denne typen.

    * For å tillate hvilken som helst [status][4] eller [prioritet][3], la tilgjengelighetsfeltet være tomt.
    * Hvis du velger en eller flere statuser, må du også velge en standard status.
    * Hvis du velger en eller flere prioriteter, må du også velge en standard prioritet.

1. Valgfritt, velg en standardstatus og/eller prioritet for bruk når en agent oppretter en sak av denne typen. (Obligatorisk hvis du angir tilgjengelighet.) Denne innstillingen går foran andre preferanser.

1. Valgfritt, velg en [svarmal][5] for å bruke når en agent svarer på en sak av denne typen.

    ![Innstillinger og vedlikehold, Innstillinger for sakstype -screenshot][img2]

1. Klikk på **Lagre**. sakstypen er opprettet.

<!-- Referenced links -->
[3]: ../priority/index.md
[4]: ../status/index.md
[5]: ../../reply-templates/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/request/add-request-type.png
[img2]: ../../../../media/loc/en/request/request-type-settings.png
