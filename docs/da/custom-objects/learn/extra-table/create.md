---
uid: help-da-extra-table-create
title:  Definere ekstratabeller
description:  Definere ekstratabeller
author: Hanne Gunnarsson
so.date: 03.29.2023
keywords: ekstratabel
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: da
---

# Tilføj ekstra tabeller

Du kan oprette ekstratabeller i SuperOffice for at registrere forskellige typer af data. Når du har oprettet tabellen og [oprettet ekstra felter][1] i den, kan du åbne tabellen for at føje indhold til den ved at gå til **Systemdesign** > **Tabeller**, pege på tabellen og klikke på knappen ![ikon][img1].

> [!NOTE]
> SuperOffice kan du oprette webpaneler, der kan indeholde tabelinformation. Hvis du vil angive de relevante adgangsrettigheder, skal brugeren tilhøre en rolle, der har de funktionelle rettigheder **Visning af tabeller** og **Rediger tabeller**.

**Trin:**

1. Gå til skærmbilledet **Tabeller** .

    * I Indstillinger og vedligeholdelse: Klik på ![ikon][img3] knappen **Systemdesign** i navigatoren. Vælg derefter fanen **Tabeller** .

2. Klik på knappen ![ikon][img4]. Skærmbilledet **Egenskaber for tabel** vises.

3. Indtast data om den nye tabel i skærmbilledet **Egenskaber for tabel**. Se detaljer om felterne nedenfor.

4. Klik på **OK** for at gemme den nye tabel.

## Felter

| Felt | Beskrivelse |
|---|---|
| Mappe | Hvis du vil anbringe tabellen i en eksisterende mappe, skal du vælge en mappe på listen. |
| Navn | Tabellens navn. |
| Databasetabel Navnet på databasetabellen. Kan kun angives ved oprettelse og kan ikke ændres. Tabelnavnet må indeholde understregninger, bogstaverne a til z eller kun tal, og navnet skal starte med "y_". Et indlysende navn er bedst, fordi det gør det nemmere at se, hvad databasen indeholder. |
| Overskrift for søgning | Dette er den overskrift, der bruges i søgeskærmbilledet for denne tabel. |
| Overskrift for visning af datapost | Dette er den overskrift, der bruges, når du viser en datapost i denne tabel. |
| Overskrift for ny post | Dette er den overskrift, der bruges, når du opretter en ny datapost i denne tabel. |
| Overskrift for redigering af datapost | Dette er den overskrift, der bruges, når du viser en datapost i denne tabel. |
| Sorteringsrækkefølge | Den kolonne, tabellen er sorteret efter. Hvis du markerer **Faldende**, sorteres værdierne i faldende rækkefølge. For numeriske værdier betyder det, at den højeste værdi vises øverst i tabellen. Tabellen skal indeholde felter, før du kan vælge noget her. |
| Visningsfelt | Hvis data fra denne tabel skal vises i en anden tabel (en relation), skal du her vælge, hvilket felt der skal vises i den anden tabel. Tabellen skal indeholde felter, før du kan vælge noget her. |
| Overordnet felt | Dette felt bruges i forbindelse med hierarkisk organiserede tabeller. |
| Fuldt navn |  Hvis dette er en hierarkisk organiseret tabel, kan dette felt angive et felt, der automatisk opdateres med postens fuldstændige navn baseret på navnefeltet for denne post og alle overordnede poster. |
| Skjul id-felt | Hvis denne valgmulighed er markeret, vil id-feltet ikke være synligt ved visning af tabeller eller underposter. |
| Skjul tabellen | Hvis afkrydsningsfeltet er markeret, vil tabellen ikke være synlig fra ![ikonet][img3] **Systemdesign** > **Tabeller**. |

## Hvad vil du foretage dig nu?

* [Definere ekstrafelter][1]

<!-- Referenced links -->
[1]: ../extra-field/create.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/service/new-field.png
[img3]: ../../../../../common/icons/nav-admin-systemdesign-active.png
[img4]: ../../../../media/icons/service/new-table.png
