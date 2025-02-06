---
uid: help-no-send-privacy-confirmation-email
title: Send e-postbekreftelse for personvern
description: Send e-postbekreftelse for personvern
author: SuperOffice RnD
date: 02.21.2023
keywords: GDPR, samtykke, e-post, personvern
topic: howto
language: no
---

# Send e-postbekreftelse for personvern

I den nye GDPR-verdenen har enkeltpersoner "rett til å bli informert". Det betyr at de har rett til å vite enten på forhånd eller innen 30 dager etter at deres informasjon er samlet inn. GDPR stipulerer at enkeltpersoner har rett til å bli informert (a) om at en organisasjon har til hensikt å lagre deres personopplysninger og (b) hva organisasjonen har tenkt å bruke opplysningene til.

## Innhente samtykke på forhånd gjennom skjemaer

Ved å bruke integrerte skjemaer som finnes i CRM-løsningen din, kan du samle inn en persons samtykke samtidig som de fyller ut et webskjema og gir deg personopplysningene sine. Dette samtykket dokumenteres automatisk i SuperOffice CRM ved hjelp av funksjonen Samtykkehåndtering.

Denne videoen viser deg hvordan du oppretter et grunnleggende webskjema og legger det til på websiden din (videolengde - 7:49):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/18m6Dx1t9wI]

## Send automatiske e-postbekreftelser

Med SuperOffice CRM kan du sende en e-post med personvernbekreftelse automatisk til personer som er registrert i databasen din. E-posten sendes automatisk til en person første gang de registreres i SuperOffice, uten at du trenger å gjøre noe.

Dette er både en høflig måte å følge opp din første kontakt med en kunde på, og det gir kunden en enkel måte å informere deg på hvis de har spørsmål eller innvendinger mot at du lagrer informasjonen deres.

Du kan konfigurere systemet til å også inkludere en kobling som vil lede til en personlig abonnementsside. I denne koblingen kan personene dine velge hva slags kommunikasjon de vil motta.

## Slik sender du en e-postbekreftelse for personvern på nytt

Fra skjermbildet Person kan du sende e-postbekreftelsen for personvern til en kontakt eller sende den på nytt.

[!include[Go to Contact screen](../../../learn/includes/goto-contact.md)]

1. Klikk på <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> > **Send e-postbekreftelse om personvern**.

    ![Send en e-postbekreftelse for å informere personene om informasjonen som lagres i CRM-databasen -screenshot][img2]

1. I dialogboksen som åpnes fyller du ut følgende felt:
    * **Send til**: Bruk standard e-postadresse eller velg en annen adresse.
    * **Bruk mal**: Velg en e-postmal.
    * **Språk**: Bruk standardspråket eller velg et av de tilgjengelige språkene.
    * **Emne**: Hvis det er relevant, redigerer du standardemnet for e-posten.

1. Klikk på **Send**.

E-postbekreftelsen sendes til personen. E-posten arkiveres i detaljkortet **Aktiviteter**.

## Hva inneholder denne e-posten?

E-postbekreftelsen for personvern informerer vanligvis personen om følgende:

* Informasjonen deres ble lagret i SuperOffice
* Hvilken type informasjon ble lagret
* Hva opplysningene brukes til (formål)
* At de når som helst kan trekke tilbake samtykket
* At informasjonen er sikker og ikke blir delt

E-posten kan også inneholde en kobling til et kundesenter der personen kan administrere abonnementer og samtykke. Koblingen er gyldig i 21 dager som standard.

## Beslektet

* [Rediger e-postbekreftelsen for personvern i Innstillinger og vedlikehold][1]

<!-- Referenced links -->
[1]: edit-privacy-confirmation-email.md

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/security/confirmation-email.png
