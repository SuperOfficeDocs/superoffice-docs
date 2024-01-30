---
uid: help-nl-extra-table
title: Extra tabellen
description: Extra tabellen
keywords: extra tabel, Scherm Tabellen
author: Bergfrid Dias
so.date: 01.30.2024
so.version: 10
so.topic: howto
so.audience: user
so.audience.tooltip: SuperOffice CRM
language: nl
---

# Extra tabellen

[!include[Requirement](../../../learn/includes/req-expander-services.md)]

De SuperOffice Development Tools-licentie geeft je de mogelijkheid om extra tabellen in de database aan te maken. Direct zullen deze tabellen van derden beschikbaar zijn voor standaard CRUD-bewerkingen in SuperOffice Service. Je moet een webpaneel instellen om er vanuit de Verkoop-client toegang toe te krijgen.

Het **Tabellen**-scherm is jouw tool voor het aanpassen van het databaseschema.

## Scherm Tabellen

Het **Tabellen**-scherm toont een lijst met databasetabellen. Het toont zowel standaardtabellen (vooraf gedefinieerd in het systeem en vormt de basis van verschillende schermen) als extra tabellen (tabellen die je zelf maakt met optionele inhoud).

Hier kun je nieuwe tabellen en velden maken voor verschillende schermen en dialogen. Alleen beheerders hebben toegang tot deze functionaliteit.

## Tabelmap

Tabelmappen worden gebruikt voor het ordenen van uw aangepaste tabellen.

## Conventies

> [!CAUTION]
> Kies uw databasetabel- en veldnamen zorgvuldig. Ze kunnen later niet worden gewijzigd!
>
> Een logische naam is het beste omdat het gemakkelijker maakt om te zien wat de database bevat.

Prefixen zorgen ervoor dat wat u maakt niet in conflict komt met toekomstige SuperOffice-tabel- en veldnamen. Het garandeert echter niet het ontbreken van namenconflicten tussen verschillende derde partijen.

### Tabelnamen

* Moet beginnen met **y_**
* Mag alleen underscores, de letters a tot z en cijfers bevatten

### Veldnamen

* Moet beginnen met **x_**
* Moet uniek zijn binnen de tabel
* Moet een enkel woord zijn
* Mag alleen underscores, letters van a tot z en cijfers bevatten

## Verwante onderwerpen

* [Extra tabellen toevoegen][2]
* [Extra velden toevoegen][3]
* [Door gebruiker gedefinieerde velden][4]
* [Gebruiker gedefinieerde chermen][1]

<!-- Referenced links -->
[1]: ../../ui/blogic/learn/index.md
[2]: ../admin/create-extra-table.md
[3]: ../admin/create-extra-field.md
[4]: ../admin/add-udef.md

<!-- Referenced images -->
