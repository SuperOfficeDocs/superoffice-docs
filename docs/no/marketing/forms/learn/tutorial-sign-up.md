---
uid: help-no-forms-sign-up
title: Veiledning - hvordan opprette skjema for påmelding til nyhetsbrev
description: Denne veiledningen forklarer hvordan du oppretter et påmeldingsskjema i SuperOffice Marketing.
keywords: skjema, dobbel opt-in, påmelding, nyhetsbrev
author: Bergfrid Dias
date: 03.06.2024
version: 10
topic: tutorial
language: no
audience: person
audience_tooltip: SuperOffice Marketing
---

# Veiledning - hvordan opprette skjema for påmelding til nyhetsbrev

La oss se på et annet egendefinert skjemaer som kan være relevante for firmaet ditt.

## Hva vi skal gjøre

I denne veiledningen vil vi opprette et skjema for kunder som ønsker å melde seg på ett eller flere nyhetsbrev. Registreringsprosessen vil også inkludere dobbel opt-in for å eliminere feilaktige eller falske abonnementer.

Eksempelet dekker ikke alle felt og alternativer, men du finner omfattende instruksjoner i [Opprette et nytt skjema][1].

## Start her

1. I SuperOffice, [opprett et statisk utvalg][7] av firmaer/personer som heter "nyhetsbrevabonnenter (skjema)". Vi vil bruke dette utvalget senere i veiledningen.

1. Gå til **Markedsføring** og velg **Skjemaer**-fanen.

1. Klikk på **Skjema**-knappen under **Opprett nytt** på høyre side av skjermen.

1. I dialogboksen **Rediger skjema**, skriv inn "nyhetsbrevregistrering" i feltet **Skjemanavn**.

1. Velg **Egenskaper**, angi en beskrivelse, og fyll ut relevante alternativer/felt. IKKE aktiver noen alternativer under **Deaktiver skjema automatisk.**

1. Klikk **Bruk nå** for å lagre skjemaet og fortsette redigeringen.

## Felt

1. Velg **Felt** fra venstremenyen.

1. Velg feltet **Kontakt - Navn**, og klikk på den røde X-en for å fjerne dette feltet.

1. Klikk på <i class="ph ph-plus" aria-label="Add"></i> og legg til følgende felt:

    * For- og etternavn

    * **Person - E-post** (gjør dette feltet obligatorisk)

    * **Person - abonnement**
        * Velg ett eller flere nyhetsbrev som skal være tilgjengelige.
        * Angi feltet som **Obligatorisk**.
        * Endre feltnavnet til "Velg abonnementer".

1. Velg **OK**-feltet, endre navnet til "Send", og rediger skrift/bakgrunnsfarge og plassering.

1. Rediger navn på de andre feltene etter behov. **Tips**: Fjern "Person -".

1. Klikk ![icon][img2] øverst i et felt, og dra det til ønsket plassering i skjemaet. Feltene bør ha en logisk rekkefølge.

1. Klikk **Bruk nå** for å lagre skjemaet og fortsette redigeringen.

![Angi egenskaper for nytt påmeldingsskjema -screenshot][img7]

## Stil

1. Velg **Stil** fra venstremenyen for å definere utseendet til skjemaet. Redigerer oppsettet, fargene, størrelsen og skrifttypene i skjemaet. Vurder å involvere dine webdesignkolleger.

1. Klikk **Bruk nå** for å lagre skjemaet og fortsette redigeringen.

![Stil for nytt påmeldingsskjema -screenshot][img8]

## Dobbel opt-in

[!include[Show toolbar](includes/tip-show-toolbar-open-editor.md)]

1. Velg **Dobbel opt-in** fra venstremenyen.

1. Klikk på **Aktiver dobbel opt-in**.

1. I fanen **Melding** skriver du inn teksten som skal vises etter at skjemaet er sendt. Denne meldingen skal informere kunden om at de vil motta en e-postbekreftelse.

    <details><summary>Eksempel</summary>

    Vi vil nå sende en e-post til adressen du registrerte i skjemaet vårt.

    Klikk på koblingen i e-posten for å bekrefte e-postadressen din og aktivere abonnement(ene) dine.

    Med vennlig hilsen,

    SuperShop
    </details>

1. I **E-post**-fanen oppretter du e-postbekreftelsen som sendes til personene som sender skjemaet.

    <details><summary>Eksempel</summary>

    Hei og takk for din interesse for våre nyhetsbrev

    Klikk på lenken nedenfor for å bekrefte e-postadressen din og starte abonnementet.

    Klikk her for å bekrefte e-postadressen din

    Med vennlig hilsen,

    SuperShop-teamet
    </details>

1. Klikk **Sett inn, bekreftelseskobling** (<i class="ph ph-arrow-square-out" aria-hidden="true"></i>) fra verktøylinjen. Bekreftelseskoblingen settes inn i brødteksten.

1. Klikk på bekreftelseskoblingen, og velg **Rediger kobling** (<i class="ph ph-pencil-simple" aria-hidden="true"></i>), endre deretter koblingsteksten til "Klikk her for å bekrefte e-postadressen din". Koblingen er gyldig i 30 minutter som standard.

1. Klikk **Bruk nå** for å lagre skjemaet og fortsette redigeringen.

![Legg til dobbel opt-in i nytt påmeldingsskjema -screenshot][img9]

## Landingssider

1. Velg **Takkeside**.

1. Velg **Vis denne meldingen** og skriv inn "Takk for at du abonnerer". Dette vises etter at kunden har bekreftet e-postadressen sin.

1. Velg **Side for inaktivt skjema**.

1. Velg **Videresend til eksternt websted** og skriv inn en URL. Hvis en kunde får tilgang til skjemaet etter at det er merket som inaktivt, blir de sendt til denne siden.

1. Klikk **Bruk nå** for å lagre skjemaet og fortsette redigeringen.

## Skjemahandlinger

1. Velg **Handlinger** fra venstremenyen for angi hvilke handlinger som skal utføres når skjemaet behandles.

1. Ikke velg **Opprett sak**. Abonnementene vil aktiveres automatisk, slik at ingen handling kreves av kundestøtteteamet.

1. Velg **Manuelt – hvis innsender er ukjent. Automatisk – hvis innsender er kjent**: Hvis e-postadressen som er oppgitt i skjemaet, samsvarer med en e-postadresse i SuperOffice, behandles skjemainnsendingen automatisk. Hvis ikke, behandles den manuelt.

1. **Legg til person i utvalg**: Velg det merkede området du opprettet i trinn 1. Bruk dette valget til å holde orden på kontakter som er lagt til via dette skjemaet.

1. **Legg til interesse for person**: Velg interessen som heter **Nyhetsbrev**. Denne interessen blir lagt til personer som sender dette skjemaet.

1. **E-postsvar**: Velg eller [lag et skjemasvar][2] som du vil sende til personer når skjemaet deres behandles. Denne e-posten kan for eksempel informere kunden om firmaets personvernpolicy og kan også inneholde en kobling for å [administrere abonnementer][6].

![Definer skjemahandlinger -screenshot][img6]

## Lagre og aktiver

1. Klikk på **Lagre**. Skjemaet lagres og vinduet **Rediger skjema** lukkes.

1. Sett skjemaet til **Aktiv** ![icon][img4] i overskriften.

1. Gå til fanen **Publiser**.

1. Kopier direktekoblingen og/eller JavaScript inn i et nyhetsbrev, en nettside eller et kundesenter for å publisere det til kundene eller prospektene dine.

1. Åpne koblingen til skjemaet, fyll ut skjema og kontroller at alt fungerer som det skal.

> [!TIP]
> Du kan også være interessert i vår veiledning for [kontakt-meg skjema][7].

<!-- Referenced links -->
[1]: create.md
[2]: ../../mailing/learn/create/tutorial-form-mailing.yml
[6]: ../../recipients/learn/manage-email-subscriptions.md
[7]: ../../../search-options/selection/learn/create/tutorial.yml

<!-- Referenced images -->
[img2]: ../../../../media/icons/marketing-and-forms/move-field.png
[img4]: ../../../../media/icons/marketing-and-forms/form-active.png
[img6]: ../../../../media/loc/en/marketing/sign-up-form-actions.png
[img7]: ../../../../media/loc/en/marketing/sign-up-form-fields.png
[img8]: ../../../../media/loc/en/marketing/sign-up-form-style.png
[img9]: ../../../../media/loc/en/marketing/sign-up-form-double-opt-in.png
