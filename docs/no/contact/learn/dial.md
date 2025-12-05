---
uid: help-no-contact-dial
title: Ringe personer
description: Ringe personer; Telefonpreferanser
keywords: dagbok, oppfølging, telefon, samtale, ringe
author: digitaldiina
date: 12.05.2025
version: 11
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Ringe til personer

Hvis IP-telefonløsningen er riktig konfigurert, kan du ringe til personer fra SuperOffice CRM på en av følgende måter:

* Klikk på et telefonnummer i Firma-bildet
* Klikk på <i class="ph ph-phone" aria-label="Phone icon"></i> i en dialogboks.
* Høyreklikk på en person i et detaljkort , og velg deretter **Ring *navn***.
* Ring personer.

## Ringe en person fra dialogboksene Avtale, Oppgave, Samtale og Dokument

Dette kan du gjøre ved hjelp av telefonknappen i blant annet dialogboksene **Avtale**, **Oppgave**, **Telefonsamtale** og **Dokument**:

1. Åpne en avtale, en oppgave, en samtale eller et dokument.
2. Velg ønsket person i feltet **Person** i dialogboksen.
3. Klikk på ringe-knappen ved siden av feltet for person. Det vises en liste over numrene til den aktuelle personen.
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

* **IP-telefon**: `tel:%p` (standardverdi)
* **Skype**: `callto:%p`
* **FaceTime**: `facetime:%p`

Det er også mulig å bruke [malvariabler][2] i telefonparameterne.

### Teknisk merknad for ISV-er

ISV-er kan bruke preferansen **Telefonforbindelsesformat** til å definere en egendefinert anropsprotokoll i stedet for standardverdien `tel:%p`. Du kan for eksempel sette verdien til `domycall:%p` for å videresende anropsforespørsler til en lokal lytterapplikasjon.

For å aktivere dette må klientmaskinen registrere en protokollbehandler i Windows-registeret:

```sh
Computer\HKEY_CLASSES_ROOT\domycall\shell\open\command
```

Registeroppføringen må peke til den kjørbare filen som behandler den innkommende anropsforespørselen. Argumentet `%1` inneholder telefonnummeret som SuperOffice CRM sender gjennom den egendefinerte protokollen.

<!-- Referenced links -->
[2]: ../../document/templates/learn/template-variables.md
