---
uid: help-sv-service-screen-definition
title: Skärmdefinition
description: Skärmdefinition
author: SuperOffice RnD
date: 06.29.2022
keywords: skärmdefinition
content_type: reference
language: sv
---

# Skärmdefinition

[!include[Requirement](../../../includes/req-dev-tools.md)]

Här visas information om den valda skärmen.

* **Redigera skärmbild**: Används för att redigera skärmen. Se [Egenskaper för skärmbild][1].

* **Redigera språk**: Används om du vill redigera skärmtexter för tillgängliga språk. Välj en språkflik och redigera befintliga texter.

* **Nytt objekt**: Används för att lägga till ett nytt objekt på skärmen. Se egenskaper för objekt nedan.

* **Nytt skript**: Används för att lägga till ett nytt skript. Här kan du ange ett skript som ska köras när användaren klickar på knappen.

* **Nytt makro**: Används för att [lägga till ett nytt makro][5].

* **Visa skärmbild**: Visar skärmen.

* **Designläge**: Visar skärmen i designläge (se nedan).

* **Listläge**: Visar alla skärmobjekt i en lista i stället för i designläge.

## Egenskaper för knappskript

* **Namn**: Namn på knappen.
* **Kontrollera fältvärden först**: Om detta alternativ är aktiverat kontrolleras innehållet i formfälten innan skriptet körs. Om ett eller flera värden är ogiltiga returneras användaren till formuläret, där felen indikeras.
* **Skript**: Här anger du det skript som ska köras för knappen.

## Egenskaper för objekt

Här kan du redigera egenskaperna för ett skärmobjekt, inkl. ett konstruktionsskript för objektet och enkla värden som är specifika för de olika typerna av objekt (som titel, namn). En sådan egenskap är brödtexten, som många objekt har, och eftersom de kan vara ganska långa har de en egen ruta.

## Designläge

I designläget kan du dubbelklicka på önskat alternativ i verktygsfältet till höger för att skapa ett objekt. Varje objekt har ett rektangulärt handtag som du kan klicka på för att visa en meny, som kan användas för att t.ex. flytta på objektet eller lägga till den objekttyp som har valts i verktygsfältet.

Många av objekten innehåller exempeldata när de infogas för att visa hur de ser ut när skärmen visas.

 Följande flikar visas:

* **Objekt**: Objekten på skärmen.
* **Knappar**: Visar en översikt över knappar kopplade till åtgärder på skärmen.

<!-- Referenced links -->
[1]: screen-properties.md
[5]: ../../../automation/crmscript/learn/create-macro.md

<!-- Referenced images -->
