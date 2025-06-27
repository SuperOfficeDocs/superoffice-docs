---
uid: help-sv-specifying-field-mapping
title: Ange fälttilldelning
description: Ange fälttilldelning
author: SuperOffice RnD
date: 06.29.2022
keywords: Inställningar för Windows-klient
content_type: howto
language: sv
client: win
envir: onsite
---

# Ange fälttilldelning

1. [!include[How to open import](includes/open-import.md)]

1. [!include[Select file](includes/step-select-file.md)]

1. Innehållet i den första posten i importfilen visas i kolumnen **Fält i fil** under kolumnen **Fälttilldelning**. Markera ett fält som du vill importera till databasen.

1. Klicka på knappen **Lägg till** under **Fälttilldelning**.

    > [!NOTE]
    > Du kan också dubbelklicka på det fält som du vill importera.

1. Namnet på det aktuella fältet i importfilen visas i **Fält i importfil** i dialogrutan **Fälttilldelning**. I listrutan **Välj fält från tabell** väljer du vilken typ av data du vill importera till SuperOffice-databasen, till exempel företag.

1. I tabellen **Namn** visas alla tillgängliga fält för den datatyp som du valde i listrutan **Välj fält från tabell**, förutom de som du redan har kopplat. Välj ett fält att koppla.

1. Klicka på **OK**. Informationen under **Fälttilldelning** i fönstret **Import** uppdateras.

    [!include[Save mapping](includes/tip-save-mapping.md)]

1. Upprepa proceduren för att koppla ytterligare fält. Du kan importera flera olika datatyper. Kom ihåg att fält som inte kopplas till en post i SuperOffice-databasen inte importeras alls.

> [!NOTE]
> Om du har angett en importbeskrivningsfil i fältet **Importbeskrivningsfil**, kan det redan finnas information i kolumnen **Fält i SuperOffice CRM** under **Fälttilldelning**. Om det behövs, kan du ändra fälttilldelningen genom att [radera fälttilldelningen][1] och sedan ange en ny fälttilldelning.

<!-- Referenced links -->
[1]: deleting-field-mapping.md

<!-- Referenced images -->
