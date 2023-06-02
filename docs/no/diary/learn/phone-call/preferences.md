---
uid: help-no-phone-preferences
title: Telefonpreferanser
description: Telefonpreferanser
author: SuperOffice RnD
so.date: 06.29.2022
keywords: dagbok, oppfølging, telefon, samtale, ringe
so.topic: howto
language: no
---

# Telefonpreferanser

Det er mulig å ringe ut fra SuperOffice CRM på en av følgende måter:

* Klikk på et telefonnummer i Firma-bildet
* Klikk på ![ikon][img1] i en dialogboks.
* Høyreklikk på en person i et detaljkort , og velg deretter **Ring *navn***.
* [Ring personer][1].

Telefonpreferanser håndteres ulikt i Windows- og Web-klientene. Du kan lære mer om telefonpreferanser for Windows og Web nedenfor.

## Tekniske krav

For å bruke telefonfunksjonene i SuperOffice må du kanskje installere programvaren TAPI.

### Foreslåtte leverandører

* Standard telefonprogramvare fra Windows
* Panasonic TSP
* PBX Dial

## Preferanser

Hvis IP-telefon, Skype eller FaceTime er installert, kan du ringe fra SuperOffice CRM. Preferansen for **telefonforbindelsesformat** må være satt riktig, enten under **Preferanser** > **Standardverdier** eller i Innstillinger og vedlikehold. I Innstillinger og vedlikehold kan telefonpreferansene stilles inn for enkeltbrukere, brukergrupper eller hele systemet.

### Tilgjengelige parametere

**IP-telefon**: tel:%p (standardverdi)
**Skype**: callto:%p
**FaceTime**: facetime:%p

Det er også mulig å bruke [malvariabler][2] i telefonparameterne.

<!-- Referenced links -->
[1]: dial.md
[2]: ../../../document/learn/template-variables.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/phone.png
