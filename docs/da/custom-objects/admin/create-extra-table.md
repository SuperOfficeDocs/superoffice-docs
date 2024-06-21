---
uid: help-da-extra-table-create
title: Tilføj ekstra tabeller
description: Tilføj ekstra tabeller
author: Bergfrid Dias
date: 01.25.2024
version: 10
keywords: ekstratabel, systemdesign
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Tilføj ekstra tabeller

Du kan oprette ekstratabeller i SuperOffice for at registrere forskellige typer af data. Når du har oprettet tabellen og [oprettet ekstra felter][1] i den, kan du åbne tabellen for at føje indhold til den.

## Trin

1. [!include[Gå til tabeller](includes/goto-tables.md)]

1. Klik på **Ny tabel**.

    ![Opret ekstra tabel -screenshot][img1]

1. I skærmen **Egenskaber for tabel**, indtast data om den nye tabel.

    * Indtast et *navn* der skal bruges som ledeteksten.
    * Indtast en *databasetabel* der begynder med **y_** for at identificere tabellen i skemaet.
    * Valgfrit sæt andre egenskaber. Se detaljer om felterne nedenfor.

    > [!NOTE]
    > Nogle tabelleegenskaber kan ikke indstilles, før du har tilføjet felter.

1. Klik på **OK** for at gemme den nye tabel (kører `create table y_mynewtable ...`).

1. [Tilføj felter til din nye tabel][1].

1. Valgfrit, juster tabelegenskaber som sorteringsrækkefølge. (Klik på tabelnavnet i listen for at redigere.)

1. Klik på **Genstart NetServer**. Hvis Travel er aktiveret, vil du også se en besked om, at en ny Travel-database skal genereres.

Du kan nu åbne tabellen i brugergrænsefladen for at tilføje indhold til det **eller** befolke det via API'erne.

## Felter

| Felt | Beskrivelse |
|---|---|
| Mappe | Hvis du vil anbringe tabellen i en eksisterende mappe, skal du vælge en mappe på listen. |
| Navn | Tabellens navn. |
| Databasetabel | Navnet på databasetabellen. Kan kun angives ved oprettelse og kan ikke ændres. Tabelnavnet må indeholde understregninger, bogstaverne a til z eller kun tal, og navnet skal starte med "y_". Et indlysende navn er bedst, fordi det gør det nemmere at se, hvad databasen indeholder. |
| Overskrift for søgning | Dette er den overskrift, der bruges i søgeskærmbilledet for denne tabel. |
| Overskrift for visning af datapost | Dette er den overskrift, der bruges, når du viser en datapost i denne tabel. |
| Overskrift for ny post | Dette er den overskrift, der bruges, når du opretter en ny datapost i denne tabel. |
| Overskrift for redigering af datapost | Dette er den overskrift, der bruges, når du viser en datapost i denne tabel. |
| Sorteringsrækkefølge | Den kolonne, tabellen er sorteret efter. Hvis du markerer **Faldende**, sorteres værdierne i faldende rækkefølge. For numeriske værdier betyder det, at den højeste værdi vises øverst i tabellen. Tabellen skal indeholde felter, før du kan vælge noget her. |
| Visningsfelt | Hvis data fra denne tabel skal vises i en anden tabel (en relation), skal du her vælge, hvilket felt der skal vises i den anden tabel. Tabellen skal indeholde felter, før du kan vælge noget her. |
| Overordnet felt | Dette felt bruges i forbindelse med hierarkisk organiserede tabeller. |
| Fuldt navn |  Hvis dette er en hierarkisk organiseret tabel, kan dette felt angive et felt, der automatisk opdateres med postens fuldstændige navn baseret på navnefeltet for denne post og alle overordnede poster. |
| Skjul id-felt | Hvis denne valgmulighed er markeret, vil id-feltet ikke være synligt ved visning af tabeller eller underposter. |
| Skjul tabellen | Hvis afkrydsningsfeltet er markeret, vil tabellen ikke være synlig fra **Systemdesign** > **Tabeller**. |

## Vise tabel i webpanel

SuperOffice kan du oprette webpaneler, der kan indeholde tabelinformation. Hvis du vil angive de relevante adgangsrettigheder, skal brugeren tilhøre en rolle, der har de funktionelle rettigheder **Visning af tabeller** og **Rediger tabeller**.

<!-- Referenced links -->
[1]: create-extra-field.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/custom-objects/create-extra-tables-and-fields.png
