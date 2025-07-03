---
uid: help-sv-select-image-for-status
title: Välj bild för status
description: Välj bild för status
keywords: SAINT, statusövervakning
author: SuperOffice RnD
date: 02.22.2023
version: 9
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
redirect_from: /sv/sale/saint/learn/admin/select-image-for-status
---

# Välja bild för status

[!include[Requirement](../includes/note-saint-req.md)]

Du kan välja en bild som ska visas i SuperOffice CRM på ett företagskort, kontaktkort eller projektkort som uppfyller kriterierna för en viss status. Bilderna visas som vattenstämplar, för att inte dölja kortets innehåll.

Att lägga till en bild är en bra idé, eftersom det väcker uppmärksamhet och uppmanar dig att vidta åtgärder varje gång du stöter på ett företag (kontakt eller projekt) som har denna specifika status. Använd en bild som symboliskt illustrerar vilken typ av åtgärd du behöver vidta.

## Är det ett krav att ha en bild?

Nej. Om du bara vill använda statusövervakning för att söka efter och skapa urval av företag, kontakter eller projekt som uppfyller statuskriterierna, behöver du inte tilldela en bild till statusarna.

## Vilken typ av bilder kan jag använda?

Bilden du väljer ska på ett bildligt sätt representera den status den står för. Statusbilden för ett projekt som har varit inaktivt under lång tid kan till exempel vara ett spindelnät.

[!include[File type and size](../../learn/includes/image-type-and-size.md)]

Bilderna används som vattenstämplar för företagskort, kontaktkort eller projektkort i SuperOffice CRM. Transparensen är 40 procent, så att bilden inte skymmer texten. Du bör ändå använda bilder med relativt ljusa färger.

## Välja en bild för statusen

1. [!include[Open SAINT](includes/open-saint-select-tab.md)]

1. Välj önskad status i statuslistan till vänster på skärmen.

1. Markera **Visualisera** (till höger på skärmen) för att visa statusbilden för företag, kontakter eller projekt som uppfyller statuskriterierna för denna status. Om **Visualisera** inte är markerad, visas inte statusbilder för den här statusen i SuperOffice CRM. Detta kan vara relevant om du bara vill använda en status för att söka i SuperOffice CRM (se nedan).

1. Klicka på **Ändra bild**.

1. Välj bild. Gör något av följande:

    * Klicka på en av bilderna som visas under **Bilder** (till höger).

        Bilder visas bara om de finns i databasen.

    * Klicka på **Lägg till**, klicka på **Överför fil**, bläddra fram till bilden du vill ha och klicka på **Öppna**. Ange en beskrivning av bilden. Klicka på **Spara**.

1. Stäng dialogrutan genom att klicka på **OK**. Bilden läggs till i databasen och visas i fältet till höger.

## Använda status för sökning

I SuperOffice CRM har du möjlighet att söka efter företag, kontakter eller projekt med hjälp av statusar som du definierar i Inställningar och underhåll. Du kan till exempel söka efter företag med en viss status och lägga till dem i ett urval.

Om du bara vill använda statusar för sökning kan du avmarkera **Visualisera**, så att statusbilden inte visas på företagskortet, kontaktkortet eller projektkortet.

## Relaterat innehåll

* [Välja typ av standardhändelse för status][1]
* [Ange statuskriterier][2]
* [Ange periodlängd][3]
* [Administrera statusövervakning][4]

<!-- Referenced links -->
[1]: select-default-follow-up-type-for-status.md
[2]: select-status-criteria.md
[3]: select-period-length.md
[4]: manage-status-monitors.md

<!-- Referenced images -->
