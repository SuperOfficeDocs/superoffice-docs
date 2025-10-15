---
uid: help-sv-import
title: Import
description: Import
keywords: importera
author: SuperOffice Product and Engineering
date: 02.22.2023
version: 10.5
content_type: concept
category: Settings and maintenance
topic: Import
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /sv/admin/import/learn/index
language: sv
---

# Importera kontakter och produktdata

En tom CRM-databas hjälper dig inte att hantera dina kontakter. Genom att importera alla dina kunddata på en gång med vår importfunktion kan du snabbt börja administrera dina kundrelationer i SuperOffice CRM.

Använder du Windows-klienten? Se [Inställningar för Windows-klient][7].

[!include[Back up database before import](includes/caution-backup-before-import.md)]

I fönstret **Import** kan du importera företag, kontakter och produkter till SuperOffice. Du kan importera både nya företag/kontakter och befintliga företag/kontakter med uppdaterade data.

> [!NOTE]
> För varje import skapas ett urval i SuperOffice CRM. Därmed kan du bearbeta de importerade företagen/kontakterna ytterligare, eller ta bort dem.

## Källor

Importfunktionen stöder import från följande källor:

* [Excel][1]. Via Excel-formatet kan du importera företag, kontakter och [produkter][5] från andra applikationer och format.
* [Outlook][2]. Importera företag och kontakter från Microsoft Outlook.
* [Gmail][3]. Importera företag och kontakter från Google Gmail.
* [ERP][4]. Importerar aktörer (kunder, leverantörer och kontakter) från ett ERP-system.

> [!NOTE]
> Om du vill importera andra data, till exempel projekt, försäljningar, valutor, postnummer och röda dagar, måste du använda [importfunktionen][7] under Inställningar för Windows-klient.

## Importera till tom SuperOffice-databas

* Importera alla företags- och kontaktdata. Se till att alla kolumner i importen kopplas till rätt SuperOffice-fält och välj rätt [Importinställningar][6] så att du får med alla nödvändiga data från importkällan.

* Importera endast företag: Om du bara vill importera företag utan kontakter går du till [Importinställningar][6] och väljer alternativet **Ingen - importera inte kontakt** i listrutan **Dubblett** under **Kontakt**.

* Importera endast kontakter: Om du bara vill importera kontakter utan företag går du till [Importinställningar][6] och väljer alternativet **Importera kontakter utan företag** i listrutan **Om företagsnamn** är tomt under **Kontakt**.

## Uppdatera gamla uppgifter i SuperOffice

Om SuperOffice innehåller föråldrad information och du vill uppdatera dessa fält med korrekt information från exempelvis Excel, väljer du åtgärden **Ersätt - skriv över befintlig** när du importerar. Eventuella tomma SuperOffice-fält uppdateras också med ny information.

## Importera tilläggsinformation

Om du saknar mycket information om kunder och kontakter i SuperOffice kan du använda åtgärden **Slå ihop - uppdatera tomma fält** när du importerar företag och kontakter. Då uppdateras endast tomma fält utan att de befintliga uppgifterna skrivs över.

<!-- Referenced links -->
[1]: from-excel.md
[2]: from-outlook.md
[3]: from-gmail.md
[4]: from-erp.md
[5]: products-from-excel.md
[6]: settings.md
[7]: https://help.superoffice.com/docs/10.3/en/onsite/win-client/learn/import/index.html

<!-- Referenced images -->
