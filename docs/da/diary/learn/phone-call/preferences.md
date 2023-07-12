---
uid: help-da-phone-preferences
title: Telefonegenskaber
description: Telefonegenskaber
author: SuperOffice RnD
so.date: 06.29.2022
keywords: dagbog, opfølgning, telefon, ring til, ring op
so.topic: howto
language: da
---

# Telefonegenskaber

Det er muligt at ringe ud fra SuperOffice CRM på en af følgende måder:

* Klikke på et telefonnummer i skærmbilledet Firma
* Klik på ![ikon][img1] i en dialogboks.
* Højreklikke på en person i et detaljekort og vælge**Ring*navn***.
* [Opkald til personer][1]

Telefonegenskaber håndteres forskelligt i Windows- og Webklienterne. Du kan læse mere om telefonegenskaber for Windows og Web nedenfor.

## Tekniske krav

Hvis du vil bruge telefonfunktionerne i SuperOffice, skal du måske installere softwaren TAPI.

### Anbefalede leverandører

* Standard-telefonsoftware fra Windows
* Panasonic TSP
* PBX Dial

## Præferencer

Hvis du har installeret IP-telefon, Skype eller FaceTime, kan du ringe fra SuperOffice CRM. Præferencen for **telefonforbindelsesformat** skal være indstillet korrekt, enten under **Præferencer** &gt; ** Standardværdier eller under Indstillinger og vedligeholdelse. I Indstillinger og vedligeholdelse kan telefonegenskaberne indstilles for enkelte brugere, grupper af brugere eller hele systemet.

### Tilgængelige parametre

**IP-telefon**: tel:%p (standardværdi)
**Skype**: callto:%p
**FaceTime**: facetime:%p

Det er også muligt at anvende [Skabelonvariabler][2] i telefonparametrene.

<!-- Referenced links -->
[1]: dial.md
[2]: ../../../document/learn/template-variables.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/phone.png
