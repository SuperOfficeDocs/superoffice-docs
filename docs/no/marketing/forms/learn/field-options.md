---
uid: help-no-form-field-options
title: Feltalternativer
description: Feltalternativer
keywords: skjema, felt, skjemaelement, reCAPTCHA
author: SuperOffice RnD
date: 03.07.2024
version: 10
topic: reference
language: no
audience: person
audience_tooltip: SuperOffice Marketing
---

# Feltalternativer

Dette er en oversikt over spesialalternativer i noen av de tilgjengelige feltene.

## SuperOffice-elementer

* **Overskriv:** Velg dette alternativet for å erstatte en eksisterende verdi i SuperOffice med verdien i skjemaet. Dette er aktuelt for land, tittel og hr/fr.

* **Person – samtykke**

  * **Formål:** Velg hvorfor personen må gi sitt samtykke.

  * **Vis kobling for personvernerklæring:** Velg dette alternativet for å inkludere koblingen til personvernerklæringen.

    [Personverninnstillinger][4] for GDPR er definert i Innstillinger og vedlikehold.

* **Person – abonnement:** Velg [abonnementene][3] som skal være synlige i skjemaet.

* **Firmanavn: Bruk eksisterende firma hvis funnet**.

  * Hvis dette alternativet er PÅ: Hvis en person sender inn et skjema der firmanavnet samsvarer med et firma i SuperOffice, legges personen automatisk til firmaet som en ny kontaktperson.

  * Hvis dette alternativet er AV: Både personen og firmaet legges til i SuperOffice.

  > [!NOTE]
  > Normalt er denne innstillingen AV for å unngå at "tilfeldige" personer blir lagt til firma de ikke tilhører.

## Skjemaelementer

* **Tekstfelt:** Et enkelt tekstfelt med 1 rad.

* **Tekstområde:** Et stort tekstfelt med flere rader.

* **Alternativknapper:** Et utvalgsfelt der du kan velge en av flere verdier.

  * **Loddrett:** Vis verdiene vannrett eller loddrett.

  * **Data:** Her angir du verdiene for hver alternativknapp. Skriv inn en verdi i dette feltet, og klikk på **+**. Gjenta for å legge til flere verdier.

* **Avmerkingsboks:** Et utvalgsfelt der du kan velge flere verdier.

  * **Loddrett:** Vis verdiene vannrett eller loddrett.

  * **Data:** Her angir du verdiene for hver avmerkingsboks. Skriv inn en verdi i dette feltet, og klikk på **+**. Gjenta for å legge til flere verdier.

* **Nedtrekksmeny:** Et utvalgsfelt der du kan velge en verdi fra en liste.

  * **Data:** Her legger du inn listeverdiene. Skriv inn en verdi i dette feltet, og klikk på **+**. Gjenta for å legge til flere verdier.

* **Skjult:** Et felt som ikke er synlig i det publiserte skjemaet. I feltet **Standardverdi** kan du legge inn en kode, et prosjektnavn/-nummer eller annen informasjon som skal knyttes til dette skjemaet.

* **Dato:** Et datofelt.

* **Last opp fil:** Et felt for opplasting av filer.

  * **Tillat flere filer:** Velg dette alternativet for å gjøre det mulig å laste opp flere filer.

  * **Maksimal filstørrelse (kb):** Angi en filstørrelse i kilobyte for å hindre at en stor fil lastes opp. La feltet stå tomt for å tillate alle filstørrelser.

  * **Tillatte filtyper:** Angi filtypene som kan lastes opp. Bruk formatet *jpg,gif,png,bmp* (kommadelt, ingen mellomrom). La dette feltet stå tomt for å tillate alle filtyper.

* **Vurdering:** Et felt der kundene for eksempel kan rangere tjenesten de har mottatt, ved hjelp av ulike rangeringstyper (stjerner, terninger, skala fra 1-10 og lignende).

* **Google reCAPTCHA:** [ReCAPTCHA-funksjonen][1] ("Jeg er ikke en robot"-avmerkingsboks) er en gratis Google-tjeneste som sikrer at bare virkelige brukere kan sende inn webskjemaer. Dette hindrer spam og automatiserte roboter fra å sabotere datainnsamlingen din.

## Vis elementer

* **Tekstblokk:** Angi en tekst som skal vises i skjemaet, for eksempel en kort introduksjon eller en detaljert beskrivelse.

    [!include[Show toolbar](includes/tip-show-toolbar-open-editor.md)]

* **Bilde:** Legg til et bilde i skjemaet. Klikk på koblingen for å velge et bilde, eller dra og slipp et bilde til **Bilde**-feltet. Bruk alternativknappene for **Posisjon** for å plassere bildet på skjemaet.

* **Seksjon:** Legg til en seksjon mellom feltene for å [opprette et skjema med flere sider][2]. Nyttig hvis skjemaet inneholder mange felt og du vil unngå å rulle.

<!-- Referenced links -->
[1]: recaptcha.md
[2]: create.md#multi-page
[3]: ../../recipients/learn/manage-email-subscriptions.md
[4]: ../../../security/privacy/learn/admin/add-consent-purpose.md
