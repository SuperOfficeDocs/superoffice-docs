---
uid: help-da-extra-table
title:  Ekstra tabeller
description:  Ekstra tabeller
author: Bergfrid Dias
so.date: 01.26.2024
so.version: 10
keywords: ekstra tabel
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: da
---

# Ekstra tabeller

[!include[Requirement](../../../learn/includes/req-expander-services.md)]

SuperOffice Development Tools-licensen giver dig mulighed for at oprette ekstra tabeller i databasen. Øjeblikkeligt vil disse tredjepartstabeller være tilgængelige for standard CRUD-operationer i SuperOffice Service. Du skal opsætte en webpanel for at få adgang til dem fra Salgsklienten.

**Tabeller**-skærmen er dit værktøj til tilpasning af databaseskemaet.

## Tabeller-skærm

Skærmbilledet **Tabeller** viser en liste over databasetabeller. Den viser både standardtabeller (foruddefineret i systemet og danner grundlaget for forskellige skærme) og ekstratabeller (tabeller, du opretter selv med valgfrit indhold).

Her kan du oprette nye tabeller og felter til forskellige skærme og dialogbokse. Kun administratorer har adgang til denne funktionalitet.

### Tabelmapper

Tabelmapper anvendes til at organisere brugerdefinerede tabeller.

## Konventioner

> [!CAUTION]
> Vælg dine databasetabel- og feltnavne omhyggeligt. De kan ikke ændres senere!
>
> Et logisk navn er bedst, fordi det gør det nemmere at se, hvad databasen indeholder.

Præfikser sikrer, at det du opretter, ikke konflikter med fremtidige SuperOffice-tabel- og feltnavne. Det garanterer dog ikke fraværet af navnekonflikter mellem forskellige tredjeparter.

### Tabelnavne

* Skal starte med **y_**
* Må kun indeholde understreger, bogstaverne a til z og tal

### Feltnavne

* Skal starte med **x_**
* Skal være unik inden for tabellen
* Skal være et enkelt ord
* Må kun indeholde understreger, bogstaver fra a til z og tal

## Relaterede emner

* [Tilføj ekstra tabeller][2]
* [Tilføj ekstra felter][3]
* [Brugerdefinerede felter][4]
* [Custom screens][1]

<!-- Referenced links -->
[1]: ../../ui/blogic/learn/index.md
[2]: ../admin/create-extra-table.md
[3]: ../admin/create-extra-field.md
[4]: ../admin/add-udef.md

<!-- Referenced images -->
