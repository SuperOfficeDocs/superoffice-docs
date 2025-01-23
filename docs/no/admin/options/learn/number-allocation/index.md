---
uid: help-no-number-allocation
title: Nummertildeling
description: Nummertildeling
author: Bergfrid Dias
date: 03.24.2023
keywords: tall, teller
topic: concept
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Nummertildeling

En teller fungerer slik at verdien i feltet øker med 1 for hver gang det registreres noe i feltet. Det kan for eksempel bety at det første firmaet du registrerer i databasen, får verdien 10001 i feltet **Nummer**, mens det nittende firmaet får verdien **10019**.

Tellere kan gjelde for følgende felt:

* **Nummer**-feltene i Firma-bildet, Prosjekt-bildet, Salg-bildet og Person-bildet.

* **Vår ref**-feltet i Dokument-skjermen, hvis det er definert for den aktuelle malen.

* Det kan også brukes tellere fra tredjepartsleverandører.

I den øverste delen av fanen **Nummertildeling** er det en tabell som viser de definerte tellerne.

## Kolonner

| Kolonner | Beskrivelse |
|---|---|
| [Icon] | Viser hvor telleren brukes, for eksempel <i class="ph ph-buildings" aria-label="Company icon"></i> for Firma-skjermen. |
| Teller | Viser navnet på telleren, for eksempel **Firmanummer**, som gjelder for **Nummer**-feltet i Firma-bildet. |
| Neste | Viser neste verdi for telleren. |
| Tildel | Angir om funksjonen for automatisk teller brukes, slik at systemet angir verdier for deg. |
| Unik | Angir om tellerverdiene må være unike. Nyttig når brukere tildeler verdier selv. |
| Kun lesbart | Angir om brukere kan skrive inn verdier i selve tellerfeltene. |
| Tillat tomt | Angir om et tomt tellerfelt er en tillatt verdi. Nyttig når tellerverdiene må være unike. Hvis det er merket av for **Tillat tomt**, betyr det at kravet om unike verdier ikke gjelder tomme felt. |
| Sist brukt | Viser når tellerfeltet sist ble brukt. |
| Av - Bruker-ID | Viser hvem som sist brukte tellerfeltet. |
| Av - Personbilde | Viser et miniatyrbilde av brukeren som sist brukte tellerfeltet. |

## Resultater av nummertildeling

Tabellen nedenfor viser hvilke konsekvenser ulike kombinasjoner av verdiene **Tildel** (T), **Unik** (U), **Kun lesbar** (L) og **Tillat tomt** (B) har i praksis:

| T | U | L | Tt | Resultat |
|:-:|:-:|:-:|:-:|---|
| | | | | Brukerne kan legge inn hva de vil. |
| x | | | | Det tildeles et nummer, som brukeren kan endre. |
| x | x | | | Det tildeles et nummer, som brukeren kan endre til en unik verdi. Databasen kan bare ha ett tomt felt. |
| x | x | x | | Det tildeles et nummer, som brukeren ikke kan endre. |
| x | x | x | x | Det tildeles et nummer, som brukeren ikke kan endre. |
| x | x | | x | Det tildeles et nummer, som brukeren kan endre til en unik verdi eller fjerne. Databasen kan ha flere tomme felt. |
| x | | x | | Det tildeles et nummer, som brukeren ikke kan endre. Hvis noen eksterne prosesser endrer nummeret, kontrolleres ikke unikhet. |
| | x | | | Det tildeles ikke noe nummer. Brukeren kan angi et nummer selv, men det må være unikt. Databasen kan bare ha ett tomt felt. |
| | x | | x | Det tildeles ikke noe nummer. Brukeren kan angi et nummer selv, men det må være unikt. Databasen kan ha flere tomme felt. |
| | | x | x | Det tildeles ikke noe nummer, og brukeren kan heller ikke angi et nummer selv. Nyttig ved bruk av tellere fra tredjepartsleverandører. |
| | | x | | Det tildeles ikke noe nummer, og brukeren kan heller ikke angi et nummer selv. Databasen kan bare ha ett tomt felt. (Anbefales ikke.) |

## Hva vil du gjøre nå?

* [Angi nummertildeling][2]
* [Angi standardverdier for nye dokumentmaler][3]

<!-- Referenced links -->
[2]: configure.md
[3]: document-template-defaults.md
