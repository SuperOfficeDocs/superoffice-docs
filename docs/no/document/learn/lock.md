---
uid: help-no-document-lock
title: Sjekke inn/ut dokumenter
description: Sjekke inn/ut dokumenter
keywords: dokument
author: Bergfrid Dias
date: 10.29.2024
version: 10.3.11
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Sjekke inn/ut dokumenter

I SuperOffice CRM er det mange som oppretter, redigerer og leser dokumenter til enhver tid. Hvis flere brukere redigerer samme dokument samtidig, risikerer de å overskrive hverandres data. For å unngå at dette skjer, vil SuperOffice CRM låse et dokument når det redigeres av en bruker. Andre brukere kan fortsatt åpne dokumentet, men bare i lesemodus. (Hvis organisasjonen bruker et dokumentbibliotek som SharePoint, kan flere personer redigere et dokument samtidig.)

## Redigeringsmodus og lesemodus

* Redigeringsmodus: Dokumentet åpnes for redigering. Dokumentet kan ikke redigeres av andre brukere før du lagrer og lukker det, noe som gjør at dokumentet automatisk sjekkes inn.

    Hvis du ikke vil at et dokument skal sjekkes inn automatisk når du lagrer og lukker det, kan du aktivere alternativet **Foreslå innsjekking når redigeringen er fullført** under **Preferanser** i SuperOffice WebTools.

* Lesemodus: Dokumentet åpnes for lesing. Hvis du gjør endringer i dokumentet, lagres de ikke. Hvis du vil [lagre dokumentet sammen med endringene][1], må du opprette et nytt dokument i SuperOffice CRM og laste opp filen sammen med endringene.

Som standard åpnes et dokument i redigeringsmodus. Hvis du foretrekker å velge lesemodus eller redigeringsmodus når du åpner et dokument, går du til ![icon][img2] **Personlige innstillinger** > **Preferanser** > **Funksjoner** og setter **Spør om redigering eller lesing** til **Ja**.

## Hvordan vet jeg når et dokument er sjekket ut?

<!-- markdownlint-disable MD051 -->
### [Ny (fra version 10.3.11)](#tab/lock-new)

I dialogboksen **Dokument** viser et utsjekket dokument en banner som viser hvem som redigerer det.

![icon][img5] **Du** redigerer dette dokumentet.

![icon][img5] Du kan ikke redigere dette dokumentet fordi det er låst av **NN**.

### [Klassisk (onsite)](#tab/lock-old)

I dialogboksen **Dokument** har et utsjekket dokument ett av følgende ikoner:

![icon][img3] Dokumentet er for øyeblikket sjekket ut for redigering av deg.

![icon][img4] Dokumentet er for øyeblikket sjekket ut for redigering av en annen bruker.

Hold musepekeren over et ikon for å vise informasjon om hvem som sjekket ut dokumentet.

Hvis du prøver å åpne et utsjekket dokument, vises en dialogboks med informasjon om hvem som sjekket ut dokumentet. Du kan bare åpne dokumentet i lesemodus.

***
<!-- markdownlint-restore -->

## Sjekke ut et dokument for redigering

Åpne et dokument, og velg å [redigere dokumentet][1]. Dokumentet er sjekket ut for redigering av deg. Andre brukere kan bare åpne dokumentet i lesemodus.

## Sjekke inn et dokument etter redigering

I de fleste tilfeller kan du [lagre og lukke dokumentet][1] i programmet, og dokumentet sjekkes inn automatisk.

## Avbryte en utsjekking (gå tilbake til lagret versjon)

Du trenger spesielle privilegier for å få tilgang til dette alternativet. Du trenger også skrivetilgang til dokumentet.

> [!CAUTION]
> Hvis en annen bruker har sjekket ut et dokument, må du alltid kontakte denne brukeren før du utfører denne prosedyren. Ellers er det en risiko for at du overskriver noen andres endringer, eller at den andre brukeren overskriver endringene når de sjekker inn dokumentet
>
> Det beste alternativet kan være å lage en kopi av dokumentet og redigere kopien.

Hvis du eller noen andre har sjekket ut et dokument og vil redigere dokumentet, kan du avbryte utsjekkingen:

1. Høyreklikk på dokumentet og velg **Dokument**.
2. I skjermbildet Dokument klikker du på **Oppgave** og velger **Hent lagret versjon**.

<!-- Referenced links -->
[1]: edit.md

<!-- Referenced images -->
[img2]: ../../../media/icons/personal-settings-small.png
[img3]: ../../../media/icons/document-lock-editing.png
[img4]: ../../../media/icons/document-lock-locked.png
[img5]: ../../../../common/icons/ops.png
