---
uid: help-sv-import-products-from-excel
title: Importera produkter från Excel
description: "I den här guiden går vi igenom hur du importerar alla dina produkter, beskrivningar och produktkoder."
author: Bergfrid Dias
so.date: 02.22.2023
keywords: importera, produkt, Excel
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: sv
---

# Importera produkter från Excel

[Import][2] är ett bra sätt att snabbt lägga in eller uppdatera prisuppgifter i en databas. Om du har ett Excel-ark med en lista över produkter kan du enkelt importera dem till SuperOffice.

## Innan du börjar

[!include[Back up database before import](includes/caution-backup-before-import.md)]

Innan du startar importen måste du [förbereda Excel-filen][1]. Checklista:

* Excel-arket måste åtminstone innehålla kolumner med Produktkod, Produktnamn och Listpris.
* Lägg in en unik produktkod för varje rad som dubblettnyckel.

## Exportera produkter från en Excel-importfil

Titta på den här filmen eller följ anvisningarna för att lära dig hur du importerar produkter till SuperOffice CRM med vår importmall (filmens längd: 4:22):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/xOTB6j2zzNo]

1. [!include[Open Import](includes/open-import.md)]

2. Klicka på **Produkter** under **Välj en importkälla**.

3. Välj den prislista du vill importera produkterna till under **Importera till prislista**.

4. Klicka på ![ikon][img1] Excel-ikonen under **Välj en importkälla**.

5. Klicka på **Överför fil** i dialogrutan **Överför fil** för att välja det Excel-kalkylblad du vill importera.

6. Bläddra till önskat Excel-kalkylblad och klicka på **Öppna**. Fältet **Filnamn** anger den valda filens position och namn.

7. Klicka på **Spara**. Data från kalkylarket visas i tabellen och importfilens namn visas längst ner.

> [!NOTE]
> Produkter från Excel importeras inte till SuperOffice-databasen än. SuperOffice läser bara in produktlistan från kalkylbladet så att du kan ange importinställningar.

## Anpassa importen

Eftersom Excel-kalkylbladet kan innehålla allt från några få till väldigt många kolumner är det viktigt att kolumnerna med de data som du vill importera är kopplade till rätt SuperOffice-fält.

> [!NOTE]
> Kalkylarket måste åtminstone innehålla de kolumner du har valt för dubblettkontroll i proceduren nedan (namn, kod eller namn + kod).

1. Lokalisera kolumnen som innehåller produkternas namn, klicka på kolumnrubriken **(Välj ingen)** och välj **Produkt: Namn**.

2. Lokalisera kolumnen som innehåller produktkoden, klicka på kolumnrubriken **(Välj ingen)** och välj **Produkt: Kod**.

3. Välj SuperOffice-fält för resten av kolumnerna tabellen. Hoppa över alla kolumner du inte vill importera.

4. [!include[Configure import settings](includes/configure-import-settings.md)]

5. Klicka på **Next**. Fönstret **Förhandsvisning** visas.

6. Granska importdata och åtgärda eventuella fel innan importen startar.

    | Ikon | Beskrivning |
    |---|---|
    | ![ikon][img2] | Data i den här raden innehåller ett problem. Se förklaringstexten i tabellens sidhuvud. |
    | ![ikon][img3] | Produkten finns inte sedan tidigare och kommer att läggas till. |
    | ![ikon][img4] | Produkten finns redan och kommer att uppdateras. |
    | tom | Ingen uppdatering. |

7. Avmarkera de rader som du INTE vill importera. Om Excel-kalkylbladet innehåller en rubrikrad kan du ta bort den här.

8. När du har kontrollerat att rätt data kommer att importeras klickar du på **Importera**.

## Slutför importen

När importen är klar visas en lista över de importerade produkterna. Ovanför listan finns en länk till den uppdaterade prislistan.

## Relaterat

* [Konfigurera importinställningar][3]
* [Importera från ERP][6]

<!-- Referenced links -->
[1]: create-import-file.md
[2]: index.md
[3]: configure-import-settings.md
[6]: import-from-erp.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/admin/import-excel-small.png
[img2]: ../../../../../common/icons/warning.png
[img3]: ../../../../media/icons/admin/import-preview-icon-product-new.png
[img4]: ../../../../media/icons/admin/import-preview-icon-product-changed.png
