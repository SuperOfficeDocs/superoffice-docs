---
uid: help-da-number-allocation-configure
title: Angivelse af nummertildeling
description: Angivelse af nummertildeling
keywords: nummerallokering, tæller, firmanummer
author: digitaldiina
date: 10.21.2025
version: 11.5
content_type: howto
category: Settings and maintenance
topic: options
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from:
  - /da/admin/options/learn/number-allocation/index
  - /da/admin/options/learn/number-allocation/configure
language: da
---

# Angivelse af nummertildeling

Den måde, en tæller fungerer på, er at øge værdien af feltet med 1, hver gang der bruges en ny forekomst af det. Hvis det første firma, du opretter i databasen, f.eks. tildeles værdien 10001 i feltet **Nummer**, tildeles det nittende firma værdien **10019**.

Tællere kan anvendes på følgende felter:

* **Nummer**-felter på skærmbilledet Firma, skærmbilledet Projekt, skærmbilledet Salg og skærmbilledet Person.
* Feltet **Vores ref.** på dialogboksen Dokument, hvis det er defineret for den relevante skabelon.
* Tællere fra tredjepartsleverandører kan også bruges.

I den øverste del af fanen **Nummertildeling** er der en tabel, der viser de definerede tællere.

## Angivelse af nummertildeling for felt

1. Gå til Indstillinger og vedligeholdelse, og vælg <i class="ph ph-sliders-horizontal" aria-hidden="true"></i> **Indstillinger**.

1. Vælg fanen **Nummertildeling**.

1. Dobbeltklik på den ønskede tæller i tabellen. Der åbnes en dialogboks for den valgte tæller.

1. Marker **Unik**, hvis du ønsker, at værdierne i feltet **Nummer** skal være unikke. Det er nyttigt, når SuperOffice CRM-brugere selv allokerer værdier.

1. Markér **Tillad tomt** for at tillade tomme tællerfelter. Det er nyttigt, når tællerværdierne skal være unikke. Hvis **Tillad tomt**er markeret, betyder det, at kravet om unikke værdier ikke gælder for tomme felter.

1. Marker **Skrivebeskyttet**, hvis du ikke ønsker, at SuperOffice CRM-brugere selv skal kunne indtaste værdier i feltet **Nummer**.

1. Marker **Tildel**, hvis du vil bruge den automatiske tællerfunktion, så systemet indsætter værdier i feltet **Nummer** for dig.

1. Feltet **Næste nummer** viser det næste nummer, der skal bruges. Du kan ændre denne værdi, hvis det er nødvendigt.

1. Klik på **Gem**.

## Kolonner

| Kolonne | Beskrivelse |
|---|---|
| [Icon] | Viser, hvor tælleren bruges, f.eks. <i class="ph ph-buildings" aria-label="Company icon"></i> for skærmbilledet Firma. |
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

## Relateret indhold

* [Angivelse af standardværdier for nye dokumentskabeloner][3]

<!-- Referenced links -->
[3]: ../../document/templates/admin/document-template-defaults.md
