---
uid: help-sv-screen-designer-grid
title: Arbeta med rutnät
description: Hur du lägger till och fyller rutnät i en layout med hjälp av Skärmdesignern i Inställningar och underhåll.
keywords: skärmlayout, rutnät, tabelllayout
author: Bergfrid Dias
date: 10.09.2025
version: 10
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
license: development-tools
category: customization
topic: screen designer
language: sv
index: true
redirect_from: /sv/customization/screen-designer/working-with-grids
---

# Arbeta med rutnät

[!include[Krav](../../../includes/req-dev-tools.md)]

Om du har många fält kan du använda ett rutnätsobjekt för att positionera dem med större precision. Detta är ett alternativ till att positionera efter sorteringsordning och kolumner.

Instruktionerna nedan förutsätter att du redan [redigerar layouten][1].

## Lägg till ett rutnät

1. Välj fliken du vill lägga till ett rutnät i.

1. Klicka för att välja avsnittet **Objekt**.

1. Klicka och dra **Rutnät**-elementet till layouten.

    ![Skärmdesigner rutnätsobjekt -screenshot][img1]

1. Klicka för att välja det nya rutnätet.

1. Justera i avsnittet **Inställningar** till vänster antalet kolumner och rader efter behov.

    ![Skärmdesigner rutnätsinställningar -screenshot][img2]

1. Välj en rutnätsstil: linjer (standard), ingen eller rubrik.

## Lägg till fält till rutnät

1. Gå till rutnätets placering.

1. Håll pekaren över rutnätet och klicka på den blå pennan.

    ![Skärmdesigner rutnät redigeringsläge -screenshot][img3]

    Detta sätter rutnätet i redigeringsläge, markerat med en grön bock.

    ![Skärmdesigner rutnät i redigeringsläge -screenshot][img4]

1. Se till att avsnittet **Fält** är valt.

1. [Dra fält från listan][2] till en cell i rutnätet. Du kan också lägga till [etiketter][3], [länkar och knappar][4].

    > [!TIP]
    > Använd Tab för att flytta från cell till cell för effektiv inmatning.

1. När du är klar klickar du på den gröna bocken för att låsa rutnätet och återgå till normalt redigeringsläge.

## Redigera rutnätsinnehåll

1. Sätt rutnätet i redigeringsläge som beskrivet ovan.

1. För att flytta ett fält, klicka på **=** till vänster om fältet och dra det till en ny cell.

    Om du släpper ett fält i en upptagen cell, byts innehållet i de två cellerna.

1. För att ta bort ett fält, håll pekaren över cellen och klicka på det röda omringade x.

## Redigera rutnätets utseende

1. Välj fliken som innehåller rutnätet.

1. Klicka på rutnätet i förhandsgranskningen. Se till att rutnätet inte är i redigeringsläge. Klicka på den gröna bocken om du ser den.

1. Justera rutnätets dimensioner och stil i avsnittet **Inställningar**.

> [!NOTE]
> Du kan inte ta bort specifika rader eller kolumner, men du kan minska antalet rader och kolumner. När du minskar antalet rader försvinner den **sista raden** från användargränssnittet tillsammans med dess innehåll. När du minskar antalet kolumner försvinner den **sista kolumnen**. Ordna dina fält först för att undvika överraskningar.

## Flytta rutnät

För att flytta ett rutnät klickar du på **=** till vänster om rutnätet och drar fältet till en ny position. Detta liknar att flytta fält.

## Ta bort rutnät

När du tar bort ett rutnät tas även dess innehåll (fält osv.) bort.

Denna åtgärd påverkar endast vad som visas i användargränssnittet och ändrar inte databasen eller värdena på något sätt.

För att ta bort ett rutnät:

* Håll pekaren över rutnätet och klicka på det röda omringade x.

För att återställa ett rutnät:

* Om du arbetar på ett utkast, kassera helt enkelt utkastet för att ångra alla dina ändringar.
* Om du har publicerat layouten efter borttagning måste du återskapa rutnätet.

<!-- Referenced links -->
[1]: edit-layout.md
[2]: working-with-fields.md
[3]: working-with-tabs.md#label
[4]: add-button.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/customization/new-grid.png
[img2]: ../../../../media/loc/en/customization/grid-settings.png
[img3]: ../../../../media/loc/en/customization/hover-grid.png
[img4]: ../../../../media/loc/en/customization/edit-grid.png
