---
uid: help-sv-extra-table-create
title:  Definiera extratabeller
description:  Definiera extratabeller
author: Hanne Gunnarsson
so.date: 03.29.2023
keywords: extratabell
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance

language: sv
---

# Lägg till extratabeller

Du kan skapa extratabeller i SuperOffice för att registrera olika typer av data. När du har skapat tabellen och [skapat extrafält i den][1] kan du öppna tabellen för att lägga till innehåll i den genom att gå till **Systemdesign** &gt; **Tabeller**, peka på tabellen och klicka på knappen ![ikon][img1].

> [!NOTE]
> I SuperOffice CRM kan du skapa webbpaneler som kan innehålla tabellinformation. Om du vill ange relevanta åtkomstbehörighet,måste användaren tillhöra en roll som har funktionsrättigheterna **Lista tabeller** och **Redigera tabeller**.

**Steg:**

1. Gå till fönstret **Tabeller**.

    * Under Inställningar och underhåll: Klicka på knappen **Systemdesign** ![ikon][img3] i navigatorn. Välj fliken **Tabeller**.

2. Klicka på knappen ![ikon][img4]. Skärmen **Egenskaper för tabell** visas.

3. Ange information om den nya tabellen i fönstret **Tabellegenskaper**. Mer information om fälten finns nedan.

4. Klicka på **OK** för att spara den nya tabellen.

## Fält

| Fält | Beskrivning |
|---|---|
| Mapp | Om du vill placera tabellen i en befintlig väljer du en mapp i listan. |
| Namn | Tabellens namn. |
| Databastabell   Databastabellens namn. Kan endast anges när tabellen skapas och kan inte ändras. Tabellnamnet får bara innehålla understreck, bokstäverna a–z eller siffror, och namnet måste börja med "y_". Ett logiskt namn är bäst eftersom det då blir enklare att se vad databasen innehåller. |
| Sidhuvud för sökning | Sidhuvudet används i sökfönstret för tabellen. |
| Sidhuvud för visning av post | Sidhuvudet används när du visar en post i den här tabellen. |
| Sidhuvud för ny post | Sidhuvudet används när du skapar en ny post i den här tabellen. |
| Sidhuvud för redigering av post | Sidhuvudet används när du redigerar en post i den här tabellen. |
| Sortering | Kolumnen som tabellen sorteras efter. Om du markerar **Fallande** sorteras värdena i fallande ordning. För numeriska värden betyder det att det högsta värdet visas överst i tabellen. Tabellen måste innehålla fält innan du kan välja något här. |
| Visningsfält | Om data från tabellen ska visas i en annan tabell (en relation) måste du välja vilket fält som ska visas i den andra tabellen. Tabellen måste innehålla fält innan du kan välja något här. |
| Överordnat fält | Detta fält används i samband med hierarkiskt organiserade tabeller. |
| Fullständigt namn |  Om detta är en hierarkiskt organiserad tabell kan detta fält ange ett fält som automatiskt uppdateras med postens fullständiga namn baserat på namnfältet för posten och alla överordnade poster. |
| Dölj ID-fält | Om du markerar detta alternativ visas inte ID-fältet när posterna i tabellen visas. |
| Dölj tabellen | Om du markerar det här alternativet är tabellen inte synlig från ![ikon][img3] **Systemdesign** &gt; **Tabeller**. |

## Vad vill du göra nu?

* [Definiera extrafält][1]

<!-- Referenced links -->
[1]: ../extra-field/create.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/service/new-field.png
[img3]: ../../../../../common/icons/nav-admin-systemdesign-active.png
[img4]: ../../../../media/icons/service/new-table.png
