---
uid: help-no-service-screen-properties
title: Egenskaper for bilde
description: Egenskaper for bilde
author: SuperOffice RnD
date: 06.29.2022
keywords: bilde
topic: reference
language: no
---

# Egenskaper for bilde

Her kan du redigere egenskapene for et bilde. Du kan opprette et skript for å forhåndsberegne variabler, enten basert på CGI-variabler som bildet henter via en URL, eller på en skjemapost i gjeldende bilde eller et annet bilde.

## Egenskaper

* **Mappe:** Hvis du har organisert skjermbildene i en mappestruktur, klikker du på <i class="ph ph-caret-down" aria-label="Chevron"></i> og velger en mappe.
* **Navn**: Et beskrivende navn på bildet.
* **ID-streng**: En streng som identifiserer dette bildet unikt, slik at det kan henvises i URLene.
* **Autentiseringsnøkkel**: Det er mulig å kjøre et egendefinert bilde uten å være logget inn som bruker. For å gjøre dette må du legge til en autentiseringsnøkkel.
* **Gi advarsel ved navigering**: Vis advarsel når brukeren navigerer bort fra en side som inneholder data som ikke er lagret.
* **Bruk autolagring**: Aktiver [funksjonen for automatisk lagring][1].

## Skript

* **Innlastingsskript (før setFromCgi)**: Dette skriptet kjøres før bildeelementene får tildelt verdiene sine
* **Innlastingsskript (etter setFromCgi)**: Dette skriptet kjøres etter at bildeelementene får tildelt verdiene sine
* **Innlastingsskript (kjørt etter alt annet)**: Dette skriptet kjøres på slutten, etter at kode og skript for eventuelle knapper er blitt kjørt.
* **Skjult variabel**: Variablene som defineres her, lagres når bildet sendes inn, slik at neste bilde har tilgang til dem.

<!-- Referenced links -->
[1]: ../../../request/learn/create.md
