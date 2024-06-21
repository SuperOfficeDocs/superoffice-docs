---
uid: help-no-import
title: Import
description: Import
author: SuperOffice RnD
date: 02.22.2023
keywords: importere
topic: concept
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Importer personer og produktdata

En tom CRM-database hjelper deg ikke med å administrere personene dine. Ved å importere kundedataene dine på én gang ved hjelp av importfunksjonen vår, kan du raskt begynne å administrere kunderelasjonene dine i SuperOffice CRM.

Bruker du Windows-klienten? Se [Innstillinger for Windows-klient][7].

[!include[Back up database before import](includes/caution-backup-before-import.md)]

I **Import**-bildet kan du importere firmaer, personer og produkter til SuperOffice. Du kan importere både nye firmaer/personer og eksisterende firmaer/personer med oppdaterte data.

> [!NOTE]
> For hver import blir det opprettet et utvalg i SuperOffice CRM. Dermed kan du behandle de importerte firmaene/personene ytterligere, eller slette dem.

## Kilder

Import-funksjonen støtter import fra følgende kilder:

* [Excel][1]. Via Excel-formatet kan du importere firmaer, personer og [produkter][5] fra andre applikasjoner og formater.
* [Outlook][2]. Importere firmaer og personer fra Microsoft Outlook.
* [Gmail][3]. Importere firmaer og personer fra Google Gmail.
* [ERP][4]. Importer aktører (kunder, leverandører og personer) fra et ERP-system.

> [!NOTE]
> Hvis du vil importere andre data, for eksempel prosjekter, salg, valutaer, postnummer og røde dager, må du bruke [Import][7]-funksjonen i Innstillinger i Windows-klient.

## Importere til tom SuperOffice-database

* Importere alle firma- og persondata. Sørg for å koble alle kolonner i importen til riktig SuperOffice-felt, og angi riktige [Importinnstillinger][6] for å få med alle nødvendige data fra importkilden.

* Importere kun firmaer: Hvis du vil importere kun firmaer uten personer, går du til [Importinnstillinger][6] og velger alternativet **Ingen - ikke importer person** i listeboksen **Duplikate treff** under **Person**.

* Importere kun personer: Hvis du vil importere kun personer uten firma, går du til [Importinnstillinger][6] og velger alternativet **Importer personer uten firma** i listeboksen **Hvis firmanavn er tomt** under **Person**.

## Oppdatere gamle data i SuperOffice

Hvis SuperOffice inneholder utdatert informasjon, og du vil oppdatere disse feltene med korrekt informasjon fra for eksempel Excel, bruker du handlingen **Erstatt - overskriv eksisterende** når du importerer. Eventuelle tomme SuperOffice-felt blir også oppdatert med ny informasjon.

## Importere tilleggsinformasjon

Hvis du mangler mye informasjon om kunder og personer i SuperOffice, bruker du handlingen **Flett - oppdater tomme felt** når du importerer firmaer og personer. Dette oppdaterer bare tomme felt uten å overskrive eksisterende informasjon.

<!-- Referenced links -->
[1]: import-from-excel.md
[2]: import-from-outlook.md
[3]: import-from-gmail.md
[4]: import-from-erp.md
[5]: import-products-from-excel.md
[6]: configure-import-settings.md
[7]: ../../../onsite/win-client/learn/import/index.md

<!-- Referenced images -->
