---
uid: help-no-import-create-excel
title: Opprette en importfil
description: I denne veiledningen lærer du hvordan du oppretter en importfil ved hjelp av Excel-malen.
author: Bergfrid Dias
date: 02.22.2023
keywords: importere, Excel, firma, person, produkt, regneark
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Opprette en importfil

For å gjøre det enklere for deg å importere personer har vi laget en importmal som du kan laste ned og bruke til å importere. I dette Excel-regnearket har vi satt opp de grunnleggende datafeltene i kolonner, og du trenger bare å kopiere persondetaljene til de riktige cellene.

## Firmaer og personer

Excel-regnearket bør som et minimum inneholde kolonner med:

* Firmanavn
* Personnavn (fornavn og etternavn)

> [!TIP]
> Kontroller at dataene er oppdaterte. Er for eksempel postadresser og telefonnumre riktige?

**Forhåndsvisning av en importfil (Excel):**

![Å bruke en importfil er den beste måten å importere alle personene dine til SuperOffice CRM på -screenshot][img2]

[Last ned importmalen for firmaer og personer][1] [Excel spreadsheet]

## Produkter

Excel-regnearket bør som et minimum inneholde kolonner med:

* Produktkode
* Produktnavn
* Listepris

Den kan for eksempel inneholde disse datakolonnene: I sortiment, produktkode, navn, beskrivelse, produktkategori, enhet, listepris, enhetsminstepris, kostnad, produktnavn.

> [!TIP]
> Hold pekeren over kolonneoverskrifter for å vise forklaringer og tips.
>
> Sørg for å legge til en unik produktkode for hver rad som en duplikatnøkkel.

**Forhåndsvisning av en importfil (Excel):**

![Å bruke en importfil er den beste måten å importere alle produktene dine til SuperOffice CRM på -screenshot][img5]

[Last ned importmalen for produkter][2] [Excel spreadsheet]

## Tips

* Noen av feltene i SuperOffice CRM er **obligatoriske**. Når du importerer firmaer og personer, må du inkludere kolonnene Kategori, Bransje og Person/firma i importfilen. Når du importerer produktinformasjon, må du legge til Produktkode, Listepris og Navn.

* Hvis du skal importere flere personer fra et firma, må du legge til én rad for hver person, og du må legge til samme firmanavn til alle radene.

* Husk at kvaliteten på dataene du importerer, bestemmer kvaliteten på CRM-dataene. Vi anbefaler at du går gjennom dataene og vasker importfilen før du begynner. Det kan være krevende å vaske importer med store datamengder hvis noe går galt.

> [!NOTE]
> For større og mer komplekse importer anbefaler vi alltid at du bruker en av våre dyktige konsulenter, slik at dataene du importerer til SuperOffice CRM, er av best mulig kvalitet.

## Relatert

* [Velge innstillinger for importen][3]
* [Importere personer til SuperOffice CRM][4]
* [Importere produkter til en prisliste][5]

<!-- Referenced links -->
[1]: ../../../../assets/downloads/import-template-for-contacts.xlsx
[2]: ../../../../assets/downloads/import-template-products.xlsx
[3]: configure-import-settings.md
[4]: import-from-excel.md
[5]: import-products-from-excel.md

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/admin/import-with-excel.jpg
[img5]: ../../../../media/loc/en/admin/preview-of-an-import-file.png
