---
uid: help-sv-screen-designer-fields
title: Arbeta med fält
description: Hur du lägger till, flyttar och tar bort fält i en layout med hjälp av Skärmdesignern i Inställningar och underhåll.
keywords: lägg till fält, nytt fält, flytta fält, ta bort fält, dölj fält, redigera layout, fältinställningar
author: Bergfrid Dias
date: 10.09.2025
version: 10
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: screen designer
language: sv
index: true
redirect_from: /sv/customization/screen-designer/working-with-fields
---

# Arbeta med fält

[!include[Krav](../../../includes/req-dev-tools.md)]

Etiketter och fält representerar det väsentliga innehållet på en skärm. Oavsett om du skapar en ny layout eller redigerar en befintlig, börjar du med att klicka på **Redigera layout**. [Visa mig de detaljerade stegen.][1] När du är klar, **spara eller publicera** layouten.

> [!TIP]
> Du kanske vill [lägga till eller ta bort flikar][2] innan du finjusterar fälten.

![Skärmdesigner, företagskort, standard fältlayout -screenshot][img1]

Listan över fält på en skärm innehåller alla standardfält i SuperOffice för det området samt alla anpassade fält (både användardefinierade och extra).

## <a id="add"></a>Lägg till fält

Vilket fält som helst kan visas på flera platser om det är relevant.

1. Välj fliken där du vill lägga till fältet.

1. Se till att avsnittet **Fält** är valt.

1. Hitta det önskade fältet i **Fält**-listan.

    > [!TIP]
    > Använd filterfunktionen för att hitta specifika fält.

1. Dra fältet från listan till ett område med streckade linjer i den valda fliken.

    ![Rutor med streckade linjer -screenshot][img6]

    För att göra ett fält synligt på alla flikar, placera fältet i sidhuvudet eller sidfoten på huvudkortet.

## <a id="settings"></a>Redigera fältinställningar

Redigera fältformat (till exempel teckenstorlek) för att förbättra synligheten.

1. Välj fliken som innehåller fältet.

1. Klicka på fältet i förhandsgranskningen.

1. I avsnittet **Inställningar**, redigera fältformatet. De tillgängliga inställningarna beror på valt fälttyp.

    * Välj **Fet** eller *Kursiv* för att ändra teckenstilen
    * Växla mellan vänster- och högerjusterade värden
    * Välj mellan liten, normal och stor teckenstorlek

För exempel på formatering, se skärmbilden i avsnittet om [lägga till en rubrik eller avdelare][3].

## <a id="move"></a>Flytta fält

Lägg till eller flytta viktiga anpassade fält till huvudfliken (den vänstra fliken) för enkel åtkomst. Flytta mindre viktiga fält till sekundära flikar som ett alternativ till att ta bort dem.

**Steg:**

1. Välj fliken som innehåller fältet.

1. Klicka på **=** till vänster om fältets etikett och dra fältet till en ny position.

    > [!TIP]
    > För att flytta ett fält till en annan flik, dra det till den nya fliken, vänta tills förhandsgranskningen uppdateras och släpp sedan fältet i ett område med streckade linjer på den nya fliken.

## <a id="delete"></a>Ta bort (göm) fält

För att minska röran, göm fält som aldrig används. Borttagna fält påverkar endast vad som visas i användargränssnittet och ändrar inte databasen eller tabellvärden.

* För att ta bort ett fält, håll pekaren över ett fält och klicka på det röda omringade x.

* För att återställa fältet, [lägg bara till fältet på nytt](#add).

> [!NOTE]
> Obligatoriska fält kan inte tas bort. Du kan dock flytta ett obligatoriskt fält till en annan flik.

## Relaterat innehåll

* [Ändra antalet kolumner i en flik][4]
* [Lägga till etiketter och avdelare][3]
* [Lägga till länkar och knappar][5]

<!-- Referenced links -->
[1]: edit-layout.md
[2]: working-with-tabs.md
[3]: working-with-tabs.md#label
[4]: working-with-tabs.md#columns
[5]: add-button.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/customization/edit-card-layout-fields.png
[img6]: ../../../../media/loc/en/customization/screendesigner-field-place.png
