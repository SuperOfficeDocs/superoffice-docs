---
uid: help-da-contact-dial
title: Opringning af kontakter
description: Opringning af kontakter og telefonegenskaber
author: SuperOffice RnD
so.date: 09.22.2023
keywords: dagbog, opfølgning, telefon, ring til, ring op
so.topic: howto
language: da
---

# Opkald til personer

Hvis IP-telefoniløsningen er konfigureret korrekt, kan du ringe til en person direkte fra SuperOffice CRM på en af følgende måder:

* Klikke på et telefonnummer i skærmbilledet Firma
* Klik på ![ikon][img1] i en dialogboks.
* Højreklikke på en person i et detaljekort og vælge**Ring*navn***.
* Opkald til personer.

## Opkald til en person fra dialogboksene Aftale, opgave, Samtale og Dokument

Dette kan du gøre ved hjælp af telefonknappen i blandt andre dialogboksene **Aftale**, **Opgave**, **Samtale** og **Dokument**:

1. Åbning af en aftale, en opgave, en samtale eller et dokument.
2. Vælg den ønskede person i feltet **Person** i dialogboksen.
3. Klik på knappen ved siden af personfeltet ![ikon][img1]. Der vises en liste over numrene til den aktuelle person.
4. Vælg det telefonnummer, du vil ringe til. Personen ringes op.

## Opkald fra detaljekort (til personer, udvalgsmedlemmer, interessenter og deltagere)

1. Gå til et detaljekort, som indeholder personer.
2. Klik på et telefonnummer i en kolonne, der indeholder telefonnumre. Personen ringes op.

## Tekniske krav

Hvis du vil bruge telefonfunktionerne i SuperOffice, skal du måske installere softwaren TAPI.

### Anbefalede leverandører

* Standard-telefonsoftware fra Windows
* Panasonic TSP
* PBX Dial

## Præferencer

Hvis du har installeret IP-telefon, Skype eller FaceTime, kan du ringe fra SuperOffice CRM. Præferencen for **telefonforbindelsesformat** skal være indstillet korrekt, enten under **Præferencer** > **Standardværdier** eller under Indstillinger og vedligeholdelse. I Indstillinger og vedligeholdelse kan telefonegenskaberne indstilles for enkelte brugere, grupper af brugere eller hele systemet.

### Tilgængelige parametre

**IP-telefon**: tel:%p (standardværdi)
**Skype**: callto:%p
**FaceTime**: facetime:%p

Det er også muligt at anvende [Skabelonvariabler][2] i telefonparametrene.

<!-- Referenced links -->
[2]: ../../document/learn/template-variables.md

<!-- Referenced images -->
[img1]: ../../../../common/icons/phone.png
