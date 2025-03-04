---
uid: help-da-extra-table
title: Ekstra tabeller
description: Ekstra tabeller
keywords: ekstra tabel, brugerdefinerede objekter
author: Bergfrid Dias
date: 08.27.2024
version: 10.3.8
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Ekstra tabeller

[!include[Requirement](../../learn/includes/req-expander-services.md)]

SuperOffice Development Tools-licensen giver dig mulighed for at oprette ekstra tabeller (brugerdefinerede objekter) i databasen.

**Tabeller**-skærmen er dit værktøj til tilpasning af databaseskemaet.

## Sådan får du adgang

<!-- markdownlint-disable MD051 -->
### [Klassisk](#tab/extra-table-old)

Ekstra tabeller er straks tilgængelige til standard CRUD-operationer i SuperOffice Service. Du skal opsætte et webpanel for at få adgang til dem fra Salgsklienten.

### [Ny (fra version 10.3.4 pilot)](#tab/extra-table-new)

Ikke længere begrænset til SuperOffice Service, kan du nemt udforske og vedligeholde data i ekstra tabeller fra SuperOffice CRM.

#### Byg dashboards ved hjælp af brugerdefinerede objekter

![Dashboard med brugerdefinerede objekter -screenshot][img1]

#### Find og udvælgelse

**Brugerdefineret objekt som søgekriterium for firma, person, salg, projekt, sag, aktivitet:**

![Brugerdefineret objekt som søgekriterium -screenshot][img2]

**Opret udvælgelse af brugerdefinerede objekter (10.3.7):**

![Find-skærm med brugerdefinerede objekter -screenshot][img3]

![Udvælgelse af brugerdefinerede objekter -screenshot][img4]

#### Vedligeholdelse af data (10.3.7)

**Åbn oversigt over brugerdefinerede objekter:**

![Oversigt over brugerdefinerede objekter -screenshot][img5]

**Søg:**

![Oversigt over brugerdefinerede objekter, søgning -screenshot][img6]

**Forhåndsvisning:**

![Oversigt over brugerdefinerede objekter, forhåndsvisning -screenshot][img7]

**Tilføj/fjern elementer:**

Når du ser resultaterne for et bestemt element i oversigten over **Brugerdefinerede objekter**, klik på knappen **Opgave**, og vælg **Ny** eller **Slet**.

**Forudfyld felter ved indlæsning af brugerdefineret objekt (10.3.8):**

Den nye [SalesLoadCustomObject][6] trigger kaldes, før en brugerdefineret objekt-skærm indlæses. Brug den til at angive standardværdier i felter og definere forretningsregler.

***
<!-- markdownlint-restore -->

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

## Relateret indhold

* [Tilføj ekstra tabeller][2]
* [Tilføj ekstra felter][3]
* [Brugerdefinerede felter][4]
* [Custom screens][1]
* [Tilføj trigger][5]

<!-- Referenced links -->
[1]: ../../ui/blogic/learn/index.md
[2]: ../admin/create-extra-table.md
[3]: ../admin/create-extra-field.md
[4]: ../admin/add-udef.md
[5]: ../../../en/automation/trigger/create-trigger-script.md
[6]: ../../../en/automation/trigger/reference/CRMScript.Event.Trigger.yml#CRMScript_Event_Trigger_SalesLoadCustomObject

<!-- Referenced images -->
[img1]: ../../../media/loc/en/automation/custom-object-dashboard.png
[img2]: ../../../media/loc/en/automation/find-custom-object-relation.png
[img3]: ../../../media/loc/en/automation/find-screen-with-custom-objects.png
[img4]: ../../../media/loc/en/automation/custom-object-selection.png
[img5]: ../../../media/loc/en/automation/go-to-custom-objects.png
[img6]: ../../../media/loc/en/automation/search-inventory.png
[img7]: ../../../media/loc/en/automation/preview-inventory-results.png

<!-- Referenced images -->
