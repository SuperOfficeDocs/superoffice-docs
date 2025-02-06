---
uid: help-no-request-type-delete
title: Slett sakstype
description: Slett sakstype
keywords: slett sakstype, bruk som standard, overfør sakstype til, sakstype, sak
author: Bergfrid Dias
date: 02.05.2025
version: 10.5.1
topic: howto
license: servicepremium
audience: settings
audience_tooltip: Innstillinger og vedlikehold
language: no
---

# Slett sakstype

> [!NOTE]
> Du kan ikke slette den gjeldende standardtypen (den med **Bruk som standard** avhuket).

## Forutsetninger

* Hvis sakstypen du ønsker å slette er standard, må du først angi en annen sakstype som standard. (Inntil dette er gjort, er **Slett**-knappen deaktivert.)

* Oppdater eventuelle [e-postfiltre][1] og [e-postkasser][2] som bruker denne sakstypen først. Du kan ikke slette en type som er i bruk.

  * **Innstillinger og vedlikehold** > **Saker** > **E-post** > **Angi egenskaper**-fanen.
  * **Innstillinger og vedlikehold** > **Saker** > **E-post** > **E-postkasser**-fanen.

## Trinn

1. Klikk på **Saker** i navigatoren og velg fanen **Sakstyper**.

1. Klikk på den sakstypen du vil slette.

1. Klikk på **Slett** nederst i skjermen.

1. Hvis det finnes saker av denne typen, velg en ny type fra listen **Overfør sakstype til**.

1. Klikk på **OK** for å bekrefte. Sakstypen slettes, og alle sakene flyttes til den valgte alternative typen.

<!-- Referenced links -->
[1]: ../../../email/service/learn/email-filters/create-email-filter.md
[2]: ../../../email/service/learn/create-mailbox.md
