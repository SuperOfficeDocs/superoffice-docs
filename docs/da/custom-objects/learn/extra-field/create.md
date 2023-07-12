---
uid: help-da-extra-fields-create
title:  Definere ekstrafelter
description: Definere ekstrafelter
author: Hanne Gunnarsson
so.date: 03.29.2023
keywords: ekstrafelt, tilpasset felt
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: da
---

# Tilføj ekstra felter

Når du har oprettet en [ekstratabel][1], skal du konfigurere felter i tabellen, så du efterfølgende kan indlæse data i tabellen (poster). Du kan også oprette ekstrafelter i standardtabeller.

> [!TIP]
> Ekstrafelter kan for eksempel bruges som søgekriterier og kolonner i salg i SuperOffice CRM.

**Trin:**

1. Klik på ![ikon][img1] knappen **Systemdesign** i navigatoren. Vælg derefter fanen **Tabeller** .
1. Gå til den ønskede tabel, peg på tabelnavnet, og klik på knappen ![ikon][img2].
1. På skærmbilledet **Nyt ekstra felt** skal du vælge en felttype på listen **Type** .
1. Klik på **OK**. Skærmbilledet **Egenskaber** for felt vises.
1. Indtast data om det nye felt i skærmbilledet **Egenskaber for felt**. De tilgængelige egenskaber afhænger af ekstrafeltets type (angivet i trin 3).
1. Klik på **OK** for at gemme, og klik derefter på knappen**Genstart NetServer** i øverste højre hjørne.

## Egenskaber for felt

| Felt | Beskrivelse |
|---|---|
| Kan ikke være tomt | Hvis afkrydsningsfeltet er markeret, bliver dette felt obligatorisk. |
| Vælg på rulleliste | Hvis feltet er knyttet til en ekstratabel, skal du vælge denne valgmulighed for at få vist en liste over tabelværdier. |
| Vælg værdier på liste | Hvis denne valgmulighed er markeret, bliver feltet en rulleliste. Valgmulighederne i listen bliver de tekststrenge, der indtastes i tekstfeltet. Der er én linje pr. valgmulighed. |
| Indekser felt | Angiv, om feltet skal indekseres. Det er hurtigere at søge efter data i indekserede felter. |
| Databasefelt | Navnet, som kolonnen får i databasen. Navnet skal være unikt i denne tabel. Desuden skal kolonnenavnet være et enkelt ord, der kun indeholder understregninger, bogstaver fra a til z eller tal, og som starter med "x_". Kan kun specificeres, når feltet oprettes, det kan ikke ændres senere. |
| Antal decimaler | Det antal decimaler, der er tilladt i et tal. |
| Standardværdi | Standardværdien vil blive anvendt for dette felt. |
| Beskrivelse | Standardbeskrivelsen. |
| Visningsværdi | Angiv, om værdien skal vises eller ej. |
| Eksternt | Hvis denne valgmulighed er markeret, vil feltet kunne være tilgængeligt fra et kundecenter. Dette er kun relevant for standardtabeller, da ekstratabeller altid vises i kundecentre. |
| Overskrift for liste | Dette felt kan bruges til at angive en overskrift for disse poster, når de vises som "underposter" i en liste. I vores eksempel betyder dette navnet på den nye fane i skærmbilledet **Vis person**, så vi indtaster "Computere" her. |
| Skjul funktionsknapper | (relationer) Vælg denne valgmulighed for at skjule funktionen for tilføjelse af nye poster til relationstabeller. |
| Skjul feltet | Angiv, om feltet skal vises eller ej. |
| Behold HTML-koder | (tekst) Vælg denne valgmulighed for at medtage HTML-taggen i teksten. |
| Navn | Feltets navn. I vores eksempel bliver dette navnene på listen i introduktionen til dette kapitel. |
| Antal enheder | (tidsperiode) Indtast det maksimale antal enheder for den "største" valgte tidsenhed. Eksempel: Hvis du har valgt timer og minutter og indtaster "4", kan der vælges et maksimum på 4 timer, mens minutter går til 60. Tilsvarende kan der for dage og timer vælges et maksimum på 4, mens timer går til 24. |
| Tillad kun rodnode i hierarkiske rullelister | (ekstra tabelrelation) Angives, hvis kun den laveste node i et hierarki kan vælges af brugeren. |
| Stilling | Angiver dette felts placering blandt de andre felter på lister. |
| Søgeoperatør | Vælg den søgeoperator, der skal bruges til dette felt. |
| Vis i tabel | Hvis denne valgmulighed er markeret, vises dette felt som en kolonne i skærmbilleder, hvor flere poster vises i en tabel. |
| Vis én-til-mange-relationer | Hvis du har valgt felttyperne **Personrelation**, **Firmarelation** eller **Sagsrelation** og ønsker at få vist en fane, der indeholder data fra denne tabel på skærmbillederne for person, firma eller sag, kan du markere dette felt. |
| Tabel | Angiv, hvilken tabel feltet hører til. |
| Destinationstabel | Angiv, hvilken tabel der skal anvendes. |
| Tekstområde/Højde | Vælg denne indstilling for at angive højden (antallet af linjer) i tekstfeltet. |
| Type | Viser den felttype, du har valgt. |
| Opdater nulværdier nu | Marker denne valgmulighed, hvis du vil erstatte alle nulværdier (dvs. tomme felter) i databasen med standardværdien. Bemærk, at denne handling kan tage et stykke tid. |
| URL | Indtast URL'en for det dynamiske link her. |
| Anvend aktuel bruger som standardværdi | Hvis denne valgmulighed er markeret, indstilles feltets værdi pr. standard som den aktuelle bruger. I vores eksempel kunne dette være relevant for feltet "Registreret af". |
| Anvend aktuel dato/klokkeslæt som standardværdi | Hvis denne valgmulighed er markeret, indstilles feltets værdi pr. standard som den aktuelle dato/tid. I vores eksempel kunne dette være relevant for feltet "Registreret dato". |
| Brug dage/Brug timer/Brug minutter | Vælg de tidsenheder, du vil bruge i feltet tidsperiode. |
| Anvend standardværdi | Hvis denne indstilling er markeret, tildeles feltet en standardværdi, medmindre andet angives. |
| Vis i relationsvælger | Hvis den aktuelle tabel har en relation til en anden tabel (ekstra tabelrelation), skal du vælge denne indstilling for at gøre dette felt tilgængeligt som et søgefelt. Eksempel: Du har oprettet en ekstratabel kaldet "Produkter" med en ekstra tabelrelation til tabellen **Sager**. På denne måde kan du søge efter og tilføje produkter under fanen **Ekstrafelter**, når du opretter nye sager. Ved at vælge **Vis i relationsvælger** for bestemte felter i tabellen "Produkter" vil disse felter være tilgængelige som søgefelter under fanen **Ekstrafelter**. |

<!-- Referenced links -->
[1]: ../extra-table/create.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/nav-admin-systemdesign-active.png
[img2]: ../../../../media/icons/service/new-field.png
