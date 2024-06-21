---
uid: help-sv-extra-table
title: Extratabeller
description: Extratabeller
author: Bergfrid Dias
date: 01.29.2024
version: 10
keywords: extratabell
topic: howto
audience: user
audience_tooltip: SuperOffice CRM
language: sv
---

# Extratabeller

[!include[Requirement](../../learn/includes/req-expander-services.md)]

SuperOffice Development Tools-licensen ger dig möjligheten att skapa extra tabeller i databasen. Omedelbart kommer dessa tredjepartstabeller att vara tillgängliga för standard CRUD-operationer i SuperOffice Service. Du måste ställa in en webbpanel för att få tillgång till dem från Säljklienten.

**Tabeller**-skärmen är ditt verktyg för anpassning av databasschemat.

## Fönstret Tabeller

**Tabeller**-skärmen visar en lista över databastabeller. Den visar både standardtabeller (fördefinierade i systemet och utgör grunden för olika fönster) och extratabeller (tabeller du skapar själv med valfritt innehåll).

Här kan du skapa nya tabeller och fält för olika kort och dialogrutor. Endast administratörer har åtkomst till den här funktionen.

## Tabellmappar

Tabellmappar används för att organisera dina egendefinierade tabeller.

## Konventioner

> [!CAUTION]
> Välj dina databastabell- och fältnamn noggrant. De kan inte ändras senare!
>
> Ett logiskt namn är bäst eftersom det gör det lättare att se vad databasen innehåller.

Prefix säkerställer att det du skapar inte kommer i konflikt med framtida SuperOffice-tabell- och fältnamn. Det garanterar dock inte frånvaron av namnkonflikter mellan olika tredjeparter.

### Tabelnamn

* Måste börja med **y_**
* Får endast innehålla understreck, bokstäverna a till z och siffror

### Fältnamn

* Måste börja med **x_**
* Måste vara unikt inom tabellen
* Måste vara ett enda ord
* Får endast innehålla understreck, bokstäver från a till z och siffror

## Relaterat innehåll

* [Lägg till extratabeller][2]
* [Lägg till extrafält][3]
* [Användardefinierade fält][4]
* [Anpassade skärmar][1]

<!-- Referenced links -->
[1]: ../../ui/blogic/learn/index.md
[2]: ../admin/create-extra-table.md
[3]: ../admin/create-extra-field.md
[4]: ../admin/add-udef.md

<!-- Referenced images -->
