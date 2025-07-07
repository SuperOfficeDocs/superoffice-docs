---
uid: help-sv-extra-table
title: Extratabeller
description: Extratabeller
keywords: extratabell
author: Bergfrid Dias
date: 08.27.2024
version: 10.3.8
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: sv
redirect_from: /sv/custom-objects/learn/extra-table/index
---

# Extratabeller

[!include[Requirement](../../includes/req-dev-tools.md)]

SuperOffice Development Tools-licensen ger dig möjligheten att skapa extra tabeller i databasen.

**Tabeller**-skärmen är ditt verktyg för anpassning av databasschemat.

## Så här får du åtkomst

<!-- markdownlint-disable MD051 -->
### [Klassisk](#tab/extra-table-old)

Tredjepartstabeller är direkt tillgängliga för standard CRUD-operationer i SuperOffice Service. Du måste ställa in en webbpanel för att få tillgång till dem från Säljklienten.

### [Ny (från version 10.3.4 pilot)](#tab/extra-table-new)

Inte längre begränsad till SuperOffice Service kan du nu enkelt utforska och hantera data i extra tabeller från SuperOffice CRM.

#### Bygg dashboards med anpassade objekt

![Dashboards med anpassade objekt -screenshot][img1]

#### Sök och urval

**Anpassat objekt som sökkriterium för företag, kontakt, försäljning, projekt, ärende, aktivitet:**

![Anpassat objekt som sökkriterium -screenshot][img2]

**Skapa urval av anpassade objekt (10.3.7):**

![Sökskärm med anpassade objekt -screenshot][img3]

![Urval av anpassade objekt -screenshot][img4]

#### Hantera data (10.3.7)

**Öppna översikt över anpassade objekt:**

![Översikt över anpassade objekt -screenshot][img5]

**Sök:**

![Översikt över anpassade objekt, sök -screenshot][img6]

**Förhandsvisning:**

![Översikt över anpassade objekt, förhandsvisning -screenshot][img7]

**Lägg till/ta bort objekt:**

När du visar resultaten för ett specifikt objekt i översikten **Anpassade objekt**, klicka på knappen **Uppgift** och välj **Ny** eller **Ta bort**.

**Förifyll fält när anpassat objekt laddas (10.3.8):**

Den nya [SalesLoadCustomObject][6]-triggern kallas innan en skärm med anpassat objekt laddas. Använd den för att ange standardvärden i fält och definiera affärsregler.

***
<!-- markdownlint-restore -->

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
* [Lägg till utlösare][5]

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
