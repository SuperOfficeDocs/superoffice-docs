---
uid: help-no-edit-email-signature
title: Redigere signaturer
description: Hvordan redigere e-postsignaturer og signaturer i saker
keywords: E-postsignatur, Signatur i sak, signatur
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Redigere signaturer

Standardsignaturmalene inneholder variabler som blir erstattet med data fra SuperOffice. Dette sikrer at signaturene dine alltid er oppdaterte med korrekt informasjon.

* **E-postsignatur:** Malen inneholder variabler for ditt navn, firma, adresse, telefonnummer, e-postadresse, nettsted osv. [fra kontaktkortet ditt][3].

* **Signatur i sak:** Malen inneholder variabler for ditt navn, firma, e-postadresse osv., spesifikke for [svarmaler][2].

> [!NOTE]
> Du kan ikke kombinere disse to settene med variabler. I tillegg kan ikke personlige signaturer overstyres av administratorer.

## Trinn

1. Klikk på **Personlige innstillinger**-knappen (<i class="ph ph-user-circle" aria-hidden="true"></i>) i toppraden.

1. Velg **Rediger personlig signatur**.

1. I dialogboksen velger du enten fanen **E-postsignatur** eller **Signatur i sak**.

1. Rediger teksten og legg til ekstra innhold.

    * Klikk på **[v]** i verktøylinjen for å legge til variabler, eller se lenkene ovenfor for en fullstendig liste over tilgjengelige variabler.

    * Legg til bilder og lenker ved hjelp av knappene i verktøylinjen. Du kan også dra og slippe lenker og bilder. Velg **Sett inn kobling** for å legge til lenker til relevante ressurser eller sosiale medier.

    ![Rediger personlig signatur -screenshot][img1]

1. Klikk på **Lagre** når du er ferdig.

1. Valgfritt: Test signaturen ved å sende en e-post til deg selv (for e-postsignaturer) eller opprette en ny sak (for saksignaturer). Sjekk at all informasjon vises riktig, og at lenker og bilder fungerer som de skal.

## Eksempel

Dette er et eksempel på en signatur som kan brukes av alle i firmaet ditt.

**Mal:**

```text
Med vennlig hilsen,
{auth}
{atit}
{onam}
Adresse: {opad}, {ozip} {ocit}
Telefon: {audp}
Mobiltelefon: {aupc}
{auem}
{owww}
```

**Resultat:**

```text
Vennlig hilsen
Kari Nordmann
Salgssjef
SuperShop
Adresse: Storgata 12, 0655 Oslo
Phone: 22334455
Mobiltelefon: 99887766
kn@supershop.com
supershop.com
```

## Aktuelle emner

* [Endre standard e-postklient i SuperOffice][1]

<!-- Referenced links -->
[1]: ../../email/learn/change-default-mail-client.md
[2]: ../../request/reply-templates/learn/template-variables.md
[3]: ../../document/templates/variables/for-selected-contact.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/learn/getstarted-preferences-email-signature.png
