---
uid: help-da-import-create-excel
title: Oprettelse af en importfil
description: I denne guide lærer du, hvordan du opretter en importfil ved hjælp af Excel-skabelonen.
author: Bergfrid Dias
date: 02.22.2023
keywords: importer, Excel, firma, contact, produkt, regneark
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Oprettelse af en importfil

For at gøre det nemmere for dig at importere personer har vi oprettet en importskabelon, som du kan downloade og bruge til at importere. I dette Excel-regneark har vi oprettet de grundlæggende datafelter i kolonner, og alt du skal gøre er at kopiere dine persondetaljer til de rigtige celler.

## Virksomheder og kontaktpersoner

Excel-regnearket skal som minimum indeholde kolonner med:

* Firmanavne
* Personnavne (fornavn og efternavn)

> [!TIP]
> Kontroller, at dataene er opdaterede. Er postadresser og telefonnumre f.eks. korrekte?

**Forhåndsvisning af en importfil (Excel):**

![Brug af en importfil er den bedste måde at importere alle dine personer til SuperOffice CRM -screenshot][img2]

[Download importskabelonen for firmaer og personer][1] [Excel spreadsheet]

## Produkter

Excel-regnearket skal som minimum indeholde kolonner med:

* Produktkode
* Produktnavn
* Listepris

Du kan f.eks. medtage disse kolonner med data: I sortiment, produktkode, navn, beskrivelse, produktkategori, enhed, listepris, mindstepris for enhed, kostpris, produktnavn.

> [!TIP]
> Få vist forklaringer og tip ved at holde markøren over kolonneoverskrifter.
>
> Sørg for at tilføje en unik produktkode for hver række som en dubletnøgle.

**Forhåndsvisning af en importfil (Excel):**

![Brug af en importfil er den bedste måde at importere alle dine produkter til SuperOffice CRM -screenshot][img5]

[Download importskabelonen for produkter][2] [Excel spreadsheet]

## Tips

* Nogle af felterne i SuperOffice CRM er **obligatoriske**. Når du importerer firmaer og kontakter, skal du sørge for at medtage kolonnerne Kategori, Firma og Person-/firmanummer i importfilen. Når du importerer produktoplysninger, skal du tilføje Produktkode, Listepris og Navn.

* Hvis du vil importere flere personer fra et firma, skal du tilføje én række for hver kontaktperson og føje det samme firmanavn til alle rækkerne.

* Husk, at kvaliteten af de data, du importerer, bestemmer kvaliteten af dine CRM-data. Vi anbefaler, at du gennemgår dine data og renser importfilen, før du starter. Importer med enorme mængder data kan være noget af en øvelse at rense, hvis der går noget galt.

> [!NOTE]
> Ved større og komplekse importer anbefaler vi altid at benytte en af vores dygtige konsulenter for at sikre, at kvaliteten af de data, du importerer til SuperOffice CRM, er i top.

## Relateret

* [Valg af indstillinger for importen][3]
* [Importer af kontakter til SuperOffice CRM][4]
* [Importer af produkter til en prisliste][5]

<!-- Referenced links -->
[1]: ../../../../assets/downloads/import-template-for-contacts.xlsx
[2]: ../../../../assets/downloads/import-template-products.xlsx
[3]: configure-import-settings.md
[4]: import-from-excel.md
[5]: import-products-from-excel.md

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/admin/import-with-excel.jpg
[img5]: ../../../../media/loc/en/admin/preview-of-an-import-file.png
