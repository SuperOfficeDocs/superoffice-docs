---
uid: help-da-number-allocation
title: Nummerallokering
description: Nummerallokering
author: Bergfrid Dias
so.date: 03.24.2023
keywords: nummer, tæller
so.topic: concept
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: da
---

# Nummerallokering

Den måde, en tæller fungerer på, er at øge værdien af feltet med 1, hver gang der bruges en ny forekomst af det. Hvis det første firma, du opretter i databasen, f.eks. tildeles værdien 10001 i feltet **Nummer**, tildeles det nittende firma værdien **10019**.

Tællere kan anvendes på følgende felter:

* **Nummer**-felter på skærmbilledet Firma, skærmbilledet Projekt, skærmbilledet Salg og skærmbilledet Person.

* Feltet **Vores ref.** på skærmbilledet Dokument, hvis det er defineret for den relevante skabelon.

* Tællere fra tredjepartsleverandører kan også bruges.

I den øverste del af fanen **Nummertildeling** er der en tabel, der viser de definerede tællere.

## Kolonner

| Kolonne | Beskrivelse |
|---|---|
| \[Icon\] | Viser, hvor tælleren bruges, f.eks. ![icon][img1] for skærmbilledet Firma. |
| Tæller | Viser navnet på tælleren, f.eks. **Firmanummer**, som gælder for feltet **Nummer** på skærmbilledet Firma. |
| Næste | Viser den næste værdi for tælleren. |
| Tildel | Angiver, om den automatiske tællerfunktion bruges, så systemet indtaster værdier for dig. |
| Entydig | Angiver, om tællerværdierne skal være unikke. Det er nyttigt, når brugere selv allokerer værdier. |
| Skrivebeskyttet | Angiver, om brugerne selv kan skrive værdier i tællerfelterne. |
| Tillad tomt | Angiver, om et tomt tællerfelt er en tilladt værdi. Det er nyttigt, når tællerværdierne skal være unikke. Hvis **Tillad tomt**er markeret, betyder det, at kravet om unikke værdier ikke gælder for tomme felter. |
| Sidst brugt | Viser, hvornår tællerfeltet sidst blev brugt. |
| Af – Bruger-ID | Viser, hvem der sidst brugte tællerfeltet. |
| Af – Portræt | Viser et miniaturebillede af den bruger, der sidst brugte tællerfeltet. |

## Resultater af nummertildeling

Tabellen nedenfor viser konsekvenserne af forskellige kombinationer af værdierne **Tildel** (A), **Entydig** (U), **Skrivebeskyttet** (R) og **Tillad tomt** (B) i praksis:

| A | U | R | B | Resultat |
|:-:|:-:|:-:|:-:|---|
| | | | | Brugerne kan indtaste, hvad de vil. |
| x | | | | Der tildeles et nummer, som brugeren kan ændre. |
| x | x | | | Der tildeles et nummer, som brugeren kan ændre til en entydig værdi. Databasen kan kun have ét tomt felt. |
| x | x | x | | Der tildeles et nummer, som brugeren ikke kan ændre. |
| x | x | x | x | Der tildeles et nummer, som brugeren ikke kan ændre. |
| x | x | | x | Der tildeles et nummer, som brugeren kan ændre til en entydig værdi eller fjerne. Databasen kan have ubegrænsede tomme felter. |
| x | | x | | Der tildeles et nummer, som brugeren ikke kan ændre. Hvis eksterne processer ændrer nummeret, kontrolleres der ikke for entydighed. |
| | x | | | Der tildeles ikke noget nummer. Brugeren kan angive et nummer, men det skal være entydigt. Databasen kan kun have ét tomt felt. |
| | x | | x | Der tildeles ikke noget nummer. Brugeren kan angive et nummer, men det skal være entydigt. Databasen kan have ubegrænsede tomme felter. |
| | | x | x | Der tildeles ikke noget nummer, og brugeren må heller ikke angive et nummer. Nyttigt, når der bruges tællere fra tredjepartsleverandører. |
| | | x | | Der tildeles ikke noget nummer, og brugeren må heller ikke angive et nummer. Databasen kan kun have ét tomt felt. (Ikke anbefalet.) |

## Hvad vil du foretage dig nu?

* [Angivelse af nummertildeling][2]
* [Angivelse af standardværdier for nye dokumentskabeloner][3]

<!-- Referenced links -->
[2]: configure.md
[3]: document-template-defaults.md

<!-- Referenced images -->
[img1]: ../../../../../media/icons/admin/contact.png
