---
uid: help-no-forms-contact-me
title: Veiledning - hvordan opprette et Kontakt meg skjema
description: Denne veiledningen forklarer hvordan du oppretter et Kontakt meg skjema i SuperOffice Marketing.
keywords: skjema, kontakt meg
author: Bergfrid Dias
date: 02.29.2024
version: 10
topic: tutorial
language: no
audience: person
audience_tooltip: SuperOffice Marketing
---

# Hvordan opprette et Kontakt meg skjema

Legg inn et "kontakt meg"-skjema på firmaets nettsider for å tilby en enkel kommunikasjonskanal for eksisterende eller potensielle kunder. Bruk dette skjemaet til å generere supportsaker eller opprette kundeemner for salgsteamet.

## Hva vi skal gjøre

Denne veiledningen vil forklare hvordan du oppretter et skjema for kunder som ønsker å komme i kontakt med en kunderepresentant. Skjemainnsendingen vil utløse en ny sak for kundestøtteavdelingen.

Eksempelet dekker ikke alle felt og alternativer, men du finner omfattende instruksjoner i [Opprette et nytt skjema][1].

## Start her

1. Åpne SuperOffice Markedsføring og gå til **Skjemaer**-fanen.

1. Klikk på **Skjema**-knappen under **Opprett nytt** på høyre side av skjermen.

1. I dialogboksen **Rediger skjema**, skriv inn "kontakt meg (kundestøtte)" i feltet **Skjemanavn**.

1. Velg **Egenskaper**, angi en beskrivelse, og fyll ut relevante alternativer/felt. IKKE aktiver noen alternativer under **Deaktiver skjema automatisk.**

1. Klikk **Bruk nå** for å lagre skjemaet og fortsette redigeringen.

![Angi egenskaper for nytt kontakt-meg skjema -screenshot][img5]

## Felt

1. Velg **Felt** fra venstremenyen.

1. Velg feltet **Kontakt - Navn**, og klikk på den røde X-en for å fjerne dette feltet.

1. Klikk på <i class="ph ph-plus" aria-label="Add"></i> og legg til følgende felt:

    * For- og etternavn.

    * **Vis elementer** > **Tekstblokk**: Skriv inn teksten under "hvordan kan vi kontakte deg?" med fet skrift.

    * **Kontakt – Mobil**: Skriv inn et eksempel på et riktig formatert telefonnummer for landet ditt (ta med landskoden) i feltet **Plassholder** (eksempel: +47 99 88 77 66).

    * **Person - E-post**

    * **Skjemaelementer** > **Tekstområde**: Endre navnet på feltet til "Kommentar (valgfritt)" og skriv "Hvordan kan vi hjelpe deg i dag?" i **plassholder**-feltet .

    [!include[Show toolbar](includes/tip-show-toolbar-open-editor.md)]

1. Velg **OK**-feltet, endre navnet til "Send", og rediger skrift/bakgrunnsfarge og plassering.

1. Rediger navn på de andre feltene etter behov. **Tips**: Fjern "Person -".

1. Klikk ![icon][img2] øverst i et felt, og dra det til ønsket plassering i skjemaet. Feltene bør ha en logisk rekkefølge.

1. Klikk **Bruk nå** for å lagre skjemaet og fortsette redigeringen.

![Legg til felt i nytt kontakt-meg skjema -screenshot][img6]

## Stil

1. Velg **Stil** fra venstremenyen for å definere utseendet til skjemaet. Redigerer oppsettet, fargene, størrelsen og skrifttypene i skjemaet. Vurder å involvere dine webdesignkolleger.

1. Klikk **Bruk nå** for å lagre skjemaet og fortsette redigeringen.

## Landingssider

1. Velg **Takkeside**.

1. Velg **Vis denne meldingen** og skriv inn "Takk for at du kontakter oss. Vi tar snart kontakt.". Dette vises etter at kunden har sendt skjemaet.

1. Velg **Side for inaktivt skjema**.

1. Velg **Videresend til eksternt websted** og skriv inn en URL. Hvis en kunde får tilgang til skjemaet etter at det er merket som inaktivt, blir de sendt til denne siden.

1. Klikk **Bruk nå** for å lagre skjemaet og fortsette redigeringen.

## Skjemahandlinger

1. Velg **Handlinger** fra venstremenyen for angi hvilke handlinger som skal utføres når skjemaet behandles.

1. Velg **Opprett sak** og gjør følgende:
    1. Angi en beskrivende tittel for sakene som skal opprettes fra dette skjemaet.
    2. Velg relevant kategori for saken, som for eksempel "Kundestøtte" eller en underkategori kalt "Skjemainnsendinger".
    3. Sett saksprioritet til **Middels**.

1. Velg **Manuelt – hvis innsender er ukjent. Automatisk – hvis innsender er kjent**: Hvis e-postadressen som er oppgitt i skjemaet, samsvarer med en e-postadresse i SuperOffice, behandles skjemainnsendingen automatisk. Hvis ikke, behandles den manuelt.

1. **E-postsvar**: Velg eller [lag et skjemasvar][2] som du vil sende til personer når skjemaet deres behandles. Denne e-posten kan for eksempel informere kunden om firmaets personvernpolicy og kan også inneholde en kobling for å [administrere abonnementer][6].

![Definer skjemahandlinger -screenshot][img7]

## Lagre og aktiver

1. Klikk på **Lagre**. Skjemaet lagres og vinduet **Rediger skjema** lukkes.

1. Sett skjemaet til **Aktiv** ![icon][img3] i overskriften.

1. Gå til fanen **Publiser**.

1. Kopier direktekoblingen og/eller JavaScript inn i et nyhetsbrev, en nettside eller et kundesenter for å publisere det til kundene eller prospektene dine.

1. Åpne koblingen til skjemaet, fyll ut skjemaet og kontroller at alt fungerer som det skal.

> [!TIP]
> Du kan også være interessert i vår veiledning for [nyhetsbrev påmelding][7]. La kundene dine melde seg på ett eller flere av dine nyhetsbrev.

<!-- Referenced links -->
[1]: create.md
[2]: ../../mailing/learn/create/tutorial-form-mailing.yml
[6]: ../../recipients/learn/manage-email-subscriptions.md
[7]: tutorial-sign-up.md

<!-- Referenced images -->
[img2]: ../../../../media/icons/marketing-and-forms/move-field.png
[img3]: ../../../../media/icons/marketing-and-forms/form-active.png
[img5]: ../../../../media/loc/en/marketing/contact-me-form-properties.png
[img6]: ../../../../media/loc/en/marketing/contact-me-form-fields.png
[img7]: ../../../../media/loc/en/marketing/contact-me-form-actions.png
