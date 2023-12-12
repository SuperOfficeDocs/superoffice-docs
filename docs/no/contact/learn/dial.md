---
uid: help-no-contact-dial
title: Ringe personer
description: Ringe personer; Telefonpreferanser
author: SuperOffice RnD
so.date: 09.22.2023
keywords: dagbok, oppfølging, telefon, samtale, ringe
so.topic: howto
language: no
---

# Ringe til personer

Hvis IP-telefonløsningen er riktig konfigurert, kan du ringe til personer fra SuperOffice CRM på en av følgende måter:

* Klikk på et telefonnummer i Firma-bildet
* Klikk på ![ikon][img1] i en dialogboks.
* Høyreklikk på en person i et detaljkort , og velg deretter **Ring *navn***.
* Ring personer.

## Ringe en person fra dialogboksene Avtale, Oppgave, Samtale og Dokument

Dette kan du gjøre ved hjelp av telefonknappen i blant annet dialogboksene **Avtale**, **Oppgave**, **Telefonsamtale** og **Dokument**:

1. Åpne en avtale, en oppgave, en samtale eller et dokument.
2. Velg ønsket person i feltet **Person** i dialogboksen.
3. Klikk på knappen ved siden av feltet for person ![ikon][img1]. Det vises en liste over numrene til den aktuelle personen.
4. Velg telefonnummeret du vil ringe. Personen ringes da opp.

## Ringe fra detaljkort (til personer, utvalgsmedlemmer, interessenter og deltakere)

1. Gå til et detaljkort som inneholder personer.
2. Klikk på et telefonnummer i en kolonne som inneholder telefonnumre. Personen ringes da opp.

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
[2]: ../../document/learn/template-variables.md

<!-- Referenced images -->
[img1]: ../../../../common/icons/phone.png
