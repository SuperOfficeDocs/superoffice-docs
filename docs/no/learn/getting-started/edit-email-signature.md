---
uid: help-no-edit-email-signature
title: Redigere signaturer
description: Redigere e-postsignatur eller signatur i sak.
keywords: e-post, signatur
author: Bergfrid Dias
date: 06.11.2024
version: 10.2.8
topic: howto
language: no
audience: person
audience_tooltip: SuperOffice CRM
---

# Redigere signaturer

De standard signaturmalene inneholder malvariabler som erstattes med data fra SuperOffice, slik at signaturene dine alltid oppdateres med riktig informasjon.

* **E-postsignatur:**: Malen inneholder variabler for ditt navn, firma, adresse, telefonnumre, e-postadresse, nettsted, og så videre [fra ditt personkort][3].

* **Signatur i sak:** Malen inneholder variabler for ditt navn, firma, e-postadresse, og så videre spesifikk for [svarmaler][2].

> [!NOTE]
> Du kan ikke blande disse to settene med malvariabler.

## Trinn

1. Klikk på **Personlige innstillinger**-knappen i toppraden.

2. Velg **Rediger personlig signatur**.

3. I dialogboksen, velg enten **E-postsignatur**-fanen eller **signatur i sak**-fanen.

4. Klikk ![ikon][img2] for å åpne verktøylinjen for tekstredigering. Her har du ulike alternativer for å redigere tekst og legge til ekstra innhold.

    ![Rediger personlig signatur -screenshot][img1]

    * Klikk ![ikon][img3] på verktøylinjen for å legge til variabler, eller gå til de ovenforlenkede referansene for den komplette listen over tilgjengelige variabler.

    * Legg til bilder og lenker ved hjelp av knappene på verktøylinjen. Du kan også dra og slippe lenker og bilder. Velg **Sett inn kobling** for å legge til lenker til relevante ressurser eller sosiale medier.

5. Klikk **Lagre** når du er ferdig.

6. Valgfritt: Test signaturen ved å sende en e-post til deg selv (for e-postsignaturer) eller ved å opprette en ny sak (for behandlingssignaturer). Sjekk at all informasjon vises riktig, og at lenkene fungerer og bildene vises som de skal.

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
[3]: ../../../en/document/templates/variables/for-selected-contact.md

<!-- Referenced images -->
[img2]: ../../../../common/icons/editor-toolbar-icon.png
[img3]: ../../../media/icons/sign-editor-variables.png
[img1]: ../../../media/loc/en/learn/getstarted-preferences-email-signature.png
