---
uid: help-nl-extra-table
title: Extra tabellen
description: Extra tabellen
keywords: extra tabel, Scherm Tabellen
author: Bergfrid Dias
date: 08.27.2024
version: 10.3.8
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: nl
redirect_from: /nl/custom-objects/learn/extra-table/index
---

# Extra tabellen

[!include[Requirement](../../includes/req-dev-tools.md)]

De SuperOffice Development Tools-licentie geeft je de mogelijkheid om extra tabellen in de database aan te maken.

Het **Tabellen**-scherm is jouw tool voor het aanpassen van het databaseschema.

## Toegang krijgen

<!-- markdownlint-disable MD051 -->
### [Klassiek](#tab/extra-table-old)

Tabellen van derden zijn direct beschikbaar voor standaard CRUD-operaties in SuperOffice Service. Je moet een webpaneel instellen om er vanuit de Verkoop-client toegang toe te krijgen.

### [Nieuw (vanaf versie 10.3.4 pilot)](#tab/extra-table-new)

Niet langer beperkt tot SuperOffice Service, kunt u nu eenvoudig gegevens in extra tabellen verkennen en beheren vanuit SuperOffice CRM.

#### Dashboards bouwen met aangepaste objecten

![Dashboard met aangepaste objecten -screenshot][img1]

#### Zoeken en selectie

**Aangepast object als zoekcriterium voor bedrijf, contact, verkoop, project, verzoek, activiteit:**

![Aangepast object als zoekcriterium -screenshot][img2]

**Maak een selectie van aangepaste objecten (10.3.7):**

![Zoekscherm met aangepaste objecten -screenshot][img3]

![Selectie van aangepaste objecten -screenshot][img4]

#### Gegevens beheren (10.3.7)

**Open het overzicht van aangepaste objecten:**

![Overzicht van aangepaste objecten -screenshot][img5]

**Zoeken:**

![Overzicht van aangepaste objecten, zoekopdracht -screenshot][img6]

**Voorbeeld:**

![Overzicht van aangepaste objecten, voorbeeld -screenshot][img7]

**Items toevoegen/verwijderen:**

Wanneer u de resultaten bekijkt voor een specifiek item in het overzicht **Aangepaste objecten**, klikt u op de knop **Taak** en selecteert u **Nieuw** of **Verwijderen**.

**Velden vooraf invullen bij het laden van aangepast object (10.3.8):**

De nieuwe [SalesLoadCustomObject][6] trigger wordt aangeroepen voordat een aangepast objectscherm wordt geladen. Gebruik het om standaardwaarden in te stellen in velden en bedrijfsregels te definiëren.

***
<!-- markdownlint-restore -->

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

## Gerelateerde inhoud

* [Extra tabellen toevoegen][2]
* [Extra velden toevoegen][3]
* [Door gebruiker gedefinieerde velden][4]
* [Gebruiker gedefinieerde chermen][1]
* [Triggers toevoegen][5]

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
