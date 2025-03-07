---
uid: help-da-request-type-delete
title: Slet sagstype
description: Slet en sagstype i SuperOffice. Læs hvordan du ændrer standardtype og håndterer overførsel af sager ved sletning.
keywords: slet sagstype, anvend som standard, overfør sagstype til, sagstype, sag
author: Bergfrid Dias
date: 03.07.2025
version: 10.5.2
topic: howto
license: servicepremium
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Slet sagstype

> [!NOTE]
> Du kan ikke slette den nuværende standardtype (den med et flueben i **Anvend som standard**-boksen).

## Forudsætninger

* Hvis den type, du vil slette, er angivet som standard, skal du først angive en anden sagstype som standard. (Indtil dette er gjort, er **Slet**-knappen deaktiveret.)

* Opdater eventuelle [e-mailfiltre][1] og [e-mailbokse][2], der bruger denne sagstype. Du kan ikke slette en type, der er i brug.

  * **Indstillinger og vedligeholdelse** > **Sager** > **E-mail** > **Indstil egenskaber**-fanen
  * **Indstillinger og vedligeholdelse** > **Sager** > **E-mail** > **E-mailbokse**-fanen

## Trin

1. Klik på **Sager** i navigatoren og vælg fanen **Sagstyper**.

1. Klik på den ønskede sagstype.

1. Klik på **Slet** nederst på skærmen.

1. Hvis der findes sager af denne type, skal du vælge en ny type fra listen **Overfør sagstype til**.

1. Klik på **OK** for at bekræfte. Sagstypen slettes, og alle sager flyttes til den angivne alternative type.

<!-- Referenced links -->
[1]: ../../../email/service/learn/email-filters/create-email-filter.md
[2]: ../../../email/service/learn/create-mailbox.md
