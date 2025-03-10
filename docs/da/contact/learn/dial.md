---
uid: help-da-contact-dial
title: Ring til personer
description: Sådan ringer du til personer i SuperOffice CRM.
keywords: dagbog, opfølgning, telefon, ring til, ring op, telefonegenskaber
author: Bergfrid Dias
date: 03.07.2025
version: 10.5.2
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Ring til personer

Hvis din IP-telefoniløsning er konfigureret korrekt, kan du ringe til en person direkte fra SuperOffice CRM på en af følgende måder:

* Klik på et telefonnummer i skærmbilledet **Firma**.
* Klik på <i class="ph ph-phone" aria-label="Telefonikon"></i> i en dialogboks.
* Højreklik på en person i et detaljekort, og vælg **Ring *navn***.
* Foretag opkald til personer.

## Ring til en person fra dialogboksene Opfølgning og Dokument

Dette kan du gøre ved hjælp af telefonknappen i blandt andet dialogboksene **Opfølgning** og **Dokument**:

1. Åbn en opfølgning eller et dokument.
2. Vælg den ønskede person i feltet **Person** i dialogboksen.
3. Klik på opkaldsknappen ved siden af personfeltet. Der vises en liste over numrene til den valgte person.
4. Vælg det telefonnummer, du vil ringe til. Personen ringes op.

## Ring fra detaljekort (til personer, udvalgsmedlemmer, interessenter og deltagere)

1. Gå til et detaljekort, som indeholder personer.
2. Klik på et telefonnummer i en kolonne, der indeholder telefonnumre. Personen ringes op.

## Tekniske krav

Hvis du vil bruge telefonfunktionerne i SuperOffice, skal du muligvis installere TAPI-software.

### Anbefalede leverandører

* Standard-telefonsoftware fra Windows
* Panasonic TSP
* PBX Dial

## Præferencer

Hvis IP-telefon, Skype eller FaceTime er installeret, kan du foretage opkald fra SuperOffice CRM. Præferencen **Telefonforbindelsesformat** skal være korrekt indstillet, enten under **Præferencer** > **Standardværdier** eller i Indstillinger og vedligeholdelse. I Indstillinger og vedligeholdelse kan telefonpræferencer indstilles for individuelle brugere, brugergrupper eller hele systemet.

### Tilgængelige parametre

* **IP-telefon**: `tel:%p` (standardværdi)
* **Skype**: `callto:%p`
* **FaceTime**: `facetime:%p`

Det er også muligt at anvende [skabelonvariabler][2] i telefonparametrene.

<!-- Referenced links -->
[2]: ../../document/templates/learn/template-variables.md
