---
uid: help-sv-import-create-excel
title: Skapa en importfil
description: I den här guiden förklarar vi hur du skapar en importfil med hjälp av Excel-mallen.
author: Bergfrid Dias
date: 02.22.2023
keywords: importera, Excel, företag, contact, produkt, kalkylark
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
---

# Skapa en importfil

För att du lättare ska kunna importera kontakter har vi skapat en importmall som du kan ladda ner och använda för importer. I det här Excel-arket har vi lagt in de grundläggande datafälten i kolumner. Det enda du behöver göra är att kopiera din kontaktinformation till rätt celler.

## Företag och kontaktpersoner

Excel-arket måste åtminstone innehålla följande kolumner:

* Företagsnamn
* Kontaktpersonernas namn (för- och efternamn)

> [!TIP]
> Kontrollera att uppgifterna är aktuella. Stämmer postadresser och telefonnummer, till exempel?

**Förhandsgranska en importfil (Excel):**

![Bästa sättet att importera alla dina kontakter till SuperOffice CRM är att använda en importfil -screenshot][img2]

[Ladda ner importmallen för företag och kontakter][1] [Excel spreadsheet]

## Produkter

Excel-arket måste åtminstone innehålla följande kolumner:

* Produktkod
* Produktnamn
* Listpris

Du kan exempelvis lägga in följande datakolumner: I sortiment, produktkod, namn, beskrivning, produktkategori, enhet, listpris, enhetens minimipris, kostnadspris och produktnamn

> [!TIP]
> Visa förklaringar och tips genom att hålla muspekaren över kolumnrubrikerna.
>
> Lägg in en unik produktkod för varje rad som dubblettnyckel.

**Förhandsgranska en importfil (Excel):**

![Bästa sättet att importera alla dina produkter till SuperOffice CRM är att använda en importfil -screenshot][img5]

[Ladda ner importmallen för produkter][2] [Excel spreadsheet]

## Tips

* Vissa fält i SuperOffice CRM är **obligatoriska**. När du importerar företag och kontakter måste du inkludera kolumnerna Kategori, Bransch och Kontaktens/företagets nummer i importfilen. När du importerar produktinformation måste du lägga in Produktkod, Listpris och Namn.

* Om du vill importera flera kontakter från ett företag måste du lägga till en rad för varje kontaktperson och lägga in samma företagsnamn på alla rader.

* Tänk på att kvaliteten på de data du importerar avgör kvaliteten på dina CRM-data. Vi rekommenderar att du går igenom dina uppgifter och rensar importfilen innan du börjar. Importer av stora mängder data kan ta väldigt lång tid att städa upp om det blir fel.

> [!NOTE]
> Vid större och mer komplexa importer rekommenderar vi att du anlitar någon av våra duktiga konsulter för att säkerställa att de data du importerar till SuperOffice CRM är så korrekta som möjligt.

## Relaterat

* [Välja inställningar för din import][3]
* [Import kontakter till SuperOffice CRM][4]
* [Importera produkter till en prislista][5]

<!-- Referenced links -->
[1]: ../../../../assets/downloads/import-template-for-contacts.xlsx
[2]: ../../../../assets/downloads/import-template-products.xlsx
[3]: configure-import-settings.md
[4]: import-from-excel.md
[5]: import-products-from-excel.md

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/admin/import-with-excel.jpg
[img5]: ../../../../media/loc/en/admin/preview-of-an-import-file.png
