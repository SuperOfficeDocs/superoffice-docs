---
uid: help-da-request-type-delete
title: Slet sagstype
description: Slet sagstype
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: sag, type
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: da
---

# Slet sagstype (kun pilot)

> [!NOTE]
> Du kan ikke slette den nuværende standardtype (den med et markering i **Anvend som standard** boksen).

## Forudsætninger

* Hvis den type, du vil slette, bruges som standard, skal du angive en anden sagstype som standard først. (Indtil du gør det, er **Slet**-knappen deaktiveret.)

* Opdater eventuelle [e-mail filtre][1] og [e-mail bokse][2], der bruger denne sagstype først. Du kan ikke slette en type, der er i brug.

  * **Indstillinger og vedligeholdelse** > **Sager** > **E-mail** > **Indstil egenskaber** fane
  * **Indstillinger og vedligeholdelse** > **Sager** > **E-mail** > **E-mail bokse** fane

## Trin

1. Klik på **Sager** i navigatøren og vælg fanen **Sagstyper**.

1. Klik på den påkrævede sagstype.

1. Klik på **Slet** i bunden af skærmen.

1. Hvis der er nogen sager af denne type, vælg en ny type fra **Overfør sagstype til** listen.

1. Klik på **OK** for at bekræfte. Sagstypen slettes, og alle sager flyttes til den angivne alternative type.

<!-- Referenced links -->
[1]: ../../../email/service/learn/email-filters/create-email-filter.md
[2]: ../../../email/service/learn/create-mailbox.md

<!-- Referenced images -->
