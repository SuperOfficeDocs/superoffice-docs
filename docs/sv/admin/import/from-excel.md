---
uid: help-sv-import-from-excel
title: Importera från Excel
description: I den här guiden går vi igenom hur du importerar alla dina prospekt och kunder och deras kontakter.
keywords: importera, Excel, kalkylark
author: digitaldiina
date: 02.22.2023
version: 10.5
content_type: howto
category: Settings and maintenance
topic: Import
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /sv/admin/import/learn/import-from-excel
language: sv
---

# Importera från Excel

Du kan [importera alla kunddata][2] på en gång med hjälp av Excel, Outlook, Gmail eller din ERP Synchronizer i SuperOffice CRM.

Excel-arket kan till exempel innehålla:

* En lista över leads/prospekt som du vill lägga in i SuperOffice.

    > [!TIP]
    > Lägg till en kolumn med exempelvis texten "prospekt" för alla kontakter så att de enkelt kan kopplas till rätt kategori i SuperOffice CRM.

* En företags-/kontaktlista med "rensade" data (data som har exporterats och kvalitetskontrollerats och ska importeras på nytt).

* Företag och kontakter från andra program och format, till exempel ekonomisystem, andra CRM-klienter, e-postklienter (andra än Gmail och Outlook) och Windows-installationer av SuperOffice CRM.

## Innan du börjar

[!include[Back up database before import](includes/caution-backup-before-import.md)]

Innan du startar importen måste du [förbereda Excel-filen][1]. Checklista:

* Excel-kalkylbladet bör åtminstone innehålla kolumner med företagsnamn och kontaktnamn (förnamn och efternamn).

* Kontrollera att uppgifterna är aktuella. Stämmer postadresser och telefonnummer, till exempel?

## Importera företag/kontakter från en Excel-fil

Titta på den här filmen eller följ anvisningarna nedan för att lära dig hur du importerar dina kontakter till SuperOffice CRM med vår importmall (filmens längd: 4:02):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/dVkCfpOkNl8]

### Steg

1. [!include[Open Import](includes/open-import.md)]

2. Kontrollera att **Kontakter** har markerats under **Välj en importkälla** och klicka sedan på ![ikon][img1] Excel-ikonen.

3. Klicka på **Överför fil** i dialogrutan **Överför fil** för att välja det Excel-kalkylblad du vill importera.

4. Bläddra till önskat Excel-kalkylblad och klicka på **Öppna**. Data från kalkylbladet visas i tabellen.

> [!NOTE]
> Företag/kontakter från Excel importeras inte till SuperOffice-databasen än. SuperOffice läser bara in företags-/kontaktlistan från kalkylbladet så att du kan ange importinställningar.

## Anpassa importen

Eftersom Excel-kalkylbladet kan innehålla allt från några få till väldigt många kolumner är det viktigt att kolumnerna med de data som du vill importera är kopplade till rätt SuperOffice-fält.

> [!NOTE]
> Om Excel-arket hade en rubrikrad högst upp visas den också i listan. Du kan ta bort den när du förhandsvisar data i nästa steg.

1. Lokalisera kolumnen som innehåller namnet på företagen, klicka på kolumnrubriken **(Välj ingen)** och välj **Företag: Namn**.

1. Lokalisera kolumnerna som innehåller förnamn och efternamn på kontakter, klicka på kolumnrubriken **(Välj ingen)** och välj **Kontakt: Förnamn** och **Kontakt: Efternamn**. Om det bara finns en kolumn med både förnamn och efternamn väljer du **Kontakt: Fullständigt namn**.

1. Välj SuperOffice-fält för resten av kolumnerna tabellen. Hoppa över alla kolumner du inte vill importera.

1. [!include[Configure import settings](includes/configure-import-settings.md)]

1. [!include[Enter concent comment](includes/step-concent-comment.md)]

[!include[Preview import](includes/step-preview-import.md)]

1. Avmarkera de rader som du INTE vill importera. Om Excel-kalkylbladet innehåller en rubrikrad kan du ta bort den här.

1. Kontrollera att du nu har de data som du vill importera och klicka sedan på **Importera**.

### Felsökning

[!include[Contacts without icons](includes/troubleshoot-import.md)]

**Jag kommer inte vidare!**

Du måste koppla alla de obligatoriska SuperOffice-fälten till varsin kolumn för att kunna gå vidare. De obligatoriska fälten visas ovanför tabellen. Om du har angett att kontakter utan företag ska läggas till som nytt företag är bara SuperOffice-fältet **Företag: Namn** obligatoriskt.

## Slutför importen

[!include[Step: complete the import](includes/import-complete.md)]

## Relaterat innehåll

* [Konfigurera importinställningar][3]
* [Importera från Outlook][4]
* [Importera från Gmail][5]
* [Importera från ERP][6]

<!-- Referenced links -->
[1]: create-spreadsheet.md
[2]: index.md
[3]: settings.md
[4]: from-outlook.md
[5]: from-gmail.md
[6]: from-erp.md

<!-- Referenced images -->
[img1]: ../../../media/icons/admin/import-excel-small.png
