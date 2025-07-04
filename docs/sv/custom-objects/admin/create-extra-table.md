---
uid: help-sv-extra-table-create
title: Lägg till extratabell
description: Lägg till extratabell
author: Bergfrid Dias
date: 01.29.2024
version: 10
keywords: extratabell
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
redirect_from: /sv/custom-objects/learn/extra-table/create
index: true
---

# Lägg till extratabell

Du kan skapa extratabeller i SuperOffice för att registrera olika typer av data. När du har skapat tabellen och [skapat extrafält i den][1] kan du öppna tabellen för att lägga till innehåll i den.

## Steg

1. [!include[Gå tilt tabeller](includes/goto-tables.md)]

1. Klicka på **Ny tabell**.

    ![Skapa extra tabell -screenshot][img1]

1. I skärmen **Egenskaper för tabell**, ange data om den nya tabellen.

    * Ange ett *namn* som ska användas som etiketten.
    * Ange en *databastabell* som börjar med **y_** för att identifiera det i schemat.
    * Valfritt ställ in andra egenskaper. Se detaljer om fälten nedan.

    > [!NOTE]
    > Vissa tabelleegenskaper kan inte ställas in förrän du har lagt till fält.

1. Klicka på **OK** för att spara den nya tabellen (detta kör `create table y_mynewtable ...`).

1. [Lägg till fält i din nya tabell][1].

1. Valfritt, justera tabellegenskaper som sorteringsordning. (Klicka på tabellnamnet i listan för att gå in i redigeringsläge.)

1. Klicka på **Starta om NetServer**. Om Travel är aktiverat kommer du också att se ett meddelande om att en ny Travel-databas måste skapas.

Du kan nu öppna tabellen i användargränssnittet för att lägga till innehåll i den **eller** befolka den via API:erna.

## Fält

| Fält | Beskrivning |
|---|---|
| Mapp | Om du vill placera tabellen i en befintlig väljer du en mapp i listan. |
| Namn | Tabellens namn. |
| Databastabell | Databastabellens namn. Kan endast anges när tabellen skapas och kan inte ändras. Tabellnamnet får bara innehålla understreck, bokstäverna a–z eller siffror, och namnet måste börja med "y_". Ett logiskt namn är bäst eftersom det då blir enklare att se vad databasen innehåller. |
| Rubrik för sökning | Används i sökfönstret för tabellen. |
| Rubrik för visning av post | Används när du visar en post i den här tabellen. |
| Rubrik för ny post | Används när du skapar en ny post i den här tabellen. |
| Rubrik för redigering av post | Används när du redigerar en post i den här tabellen. |
| Sorteringsordning | Kolumnen som tabellen sorteras efter. Om du markerar **Fallande** sorteras värdena i fallande ordning. För numeriska värden betyder det att det högsta värdet visas överst i tabellen. Tabellen måste innehålla fält innan du kan välja något här. |
| Visningsfält | Om data från tabellen ska visas i en annan tabell (en relation) måste du välja vilket fält som ska visas i den andra tabellen. Tabellen måste innehålla fält innan du kan välja något här. |
| Överordnat fält | Detta fält används i samband med hierarkiskt organiserade tabeller. |
| Fullständigt namn |  Om detta är en hierarkiskt organiserad tabell kan detta fält ange ett fält som automatiskt uppdateras med postens fullständiga namn baserat på namnfältet för posten och alla överordnade poster. |
| Dölj ID-fält | Om du markerar detta alternativ visas inte ID-fältet när posterna i tabellen visas. |
| Dölj tabellen | Om du markerar det här alternativet är tabellen inte synlig från **Systemdesign** > **Tabeller**. |

## Visa tabell i webbpanel

I SuperOffice CRM kan du skapa webbpaneler som kan innehålla tabellinformation. Om du vill ange relevanta åtkomstbehörighet,måste användaren tillhöra en roll som har funktionsrättigheterna **Lista tabeller** och **Redigera tabeller**.

<!-- Referenced links -->
[1]: create-extra-field.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/custom-objects/create-extra-tables-and-fields.png
