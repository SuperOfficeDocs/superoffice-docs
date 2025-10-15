---
uid: help-da-import
title: Import
description: Import
keywords: importer
author: SuperOffice Product and Engineering
date: 02.22.2023
version: 10.5
content_type: concept
category: Settings and maintenance
topic: Import
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /da/admin/import/learn/index
language: da
---

# Import af kontakter og produktdata

En tom CRM-database hjælper dig ikke med at administrere dine personer. Ved at importere dine kundedata på én gang ved hjælp af vores importfunktion kan du hurtigt komme i gang med at administrere dine kunderelationer i SuperOffice CRM.

Bruger du Windows-klienten? Se [Indstillinger for Windows-klient][7].

[!include[Back up database before import](includes/caution-backup-before-import.md)]

I skærmbilledet **Import** kan du importere firmaer, personer og produkter til SuperOffice. Du kan importere både nye firmaer/personer og eksisterende firmaer/personer med opdaterede data.

> [!NOTE]
> For hver import oprettes der et udvalg i SuperOffice CRM. Dermed kan du behandle de importerede firmaer/personer yderligere eller slette dem.

## Kilder

Import-funktionen understøtter import fra følgende kilder:

* [Excel][1]. Via Excel-formatet kan du importere firmaer, personer og [produkter][5] fra andre programmer og formater.
* [Outlook][2]. Import af firmaer og personer fra Microsoft Outlook.
* [Gmail][3]. Import af firmaer og personer fra Google Gmail.
* [ERP][4]. Importer aktører (kunder, leverandører og personer) fra et ERP-system.

> [!NOTE]
> Hvis du vil importere andre data, for eksempel projekter, salg, valutaer, postnumre og mærkedage, skal du bruge funktionen [Import][7] under Indstillinger i Windows-klienten.

## Import til tom SuperOffice-database

* Import af alle firma- og persondata. Sørg for at koble alle kolonner i importen til det rigtige SuperOffice-felt, og angiv rigtige [Importindstillinger][6] for at få alle nødvendige data fra importkilden med.

* Kun import af firmaer: Hvis du kun vil importere firmaer uden personer, går du til [Importindstillinger][6] og vælger **Ingen - importér ikke person** i rullemenuen **Dobbelt resultat** under **Person**.

* Importer kun personer: Hvis du kun vil importere personer uden firmaer, skal du gå til [Importindstillinger][6] og vælge indstillingen **Importér personer uden firma** på rullelisten **Hvis firmanavn er tomt** under **Person**.

## Opdatering af gamle data i SuperOffice

Hvis SuperOffice indeholder forældede oplysninger, og du vil opdatere disse felter med korrekte oplysninger fra f.eks.eksempel Excel, skal du bruge handlingen **Erstat – overskriv eksisterende**, når du importerer. Eventuelle tomme SuperOffice-felter bliver også opdateret med nye oplysninger.

## Import af tillægsoplysninger

Hvis du mangler en masse information om kunder og personer i SuperOffice, skal du bruge handlingen **Flet tomme**, når du importerer virksomheder og personer. Dette opdaterer kun tomme felter uden at overskrive de eksisterende oplysninger.

<!-- Referenced links -->
[1]: from-excel.md
[2]: from-outlook.md
[3]: from-gmail.md
[4]: from-erp.md
[5]: products-from-excel.md
[6]: settings.md
[7]: https://help.superoffice.com/docs/10.3/en/onsite/win-client/learn/import/index.html

<!-- Referenced images -->
