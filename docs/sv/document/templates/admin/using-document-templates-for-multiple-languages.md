---
uid: help-sv-using-document-templates-for-multiple-languages
title: Använda dokumentmallar för flera språk
description: Använda dokumentmallar för flera språk i projekt- och säljguiderna
keywords: dokumentmall, Föredraget dokumentspråk
author: SuperOffice Product and Engineering
date: 09.17.2025
content_type: howto
audience: settings
audience_tooltip: Inställningar och underhåll
deployment: onsite
language: sv
redirect_from: /sv/onsite/win-client/learn/using-document-templates-for-multiple-languages
---

# Använda dokumentmallar på flera språk i projekt- och säljguiderna

Om ditt företag har avdelningar i flera länder, kan det vara bra att ha dokumentmallarna inom projekt- och försäljningsguiderna tillgängliga på flera språk. Först måste du placera dokumentmallarna för de olika språken i rätt mappar och sedan ange vem som ska använda de olika språkversionerna.

## Lägg till dokumentmallar för språk

1. Öppna Windows Explorer och gå till mappen *\\SuperOffice\\SO_Arc\\Template*.

2. Skapa en mapp för vart och ett av de språk som du vill ha dokumentmallar för (se följande tabell). Till exempel *\\SuperOffice\\SO_Arc\\Template\\GE*.

3. Placera dokumentmallar för de olika språken i lämpliga språkmappar. Varje dokumentmall måste ha exakt samma filnamn och filtyp som huvudmallen. Huvudmallen är dokumentmallen på det huvudspråk du använder i SuperOffice. Du hittar den i listan **Dokumentmall** i fönstret **Listor** (dubbelklicka på en dokumentmall i listan för att se filnamn/-typ). Se Lägg till poster i listan Dokument – Mall

> [!TIP]
> Om dokumentmallen för det aktuella språket INTE finns i språkmappen, används dokumentmallen på huvudspråket.

### Mappnamn för de olika språken

[!include[Språkkoder](../../../globalization-and-localization/includes/table-legacy-language-codes.md)]

## Ange dokumentspråk för användare

Du måste nu välja rätt dokumentspråk för de användare som ska använda dokumentmallarna på de olika språken:

1. Öppna fönstret **Inställningar**, välj **System** från listrutan **Visa grupp** och välj **Föredraget dokumentspråk**.

2. Klicka på **Lägg till** under listan **Aktiva inställningar**.

3. Välj **Användare** under **Den här inställningen gäller för**.

    > [!TIP]
    > Om avdelningarna använder satellitdatabaser kan du välja att ange dokumentspråk för databaser. Du kan också välja dokumentspråk för grupper, men i så fall måste gruppen i fråga vara den primära gruppen för de användare som du anger dokumentspråk för.

4. Klicka på listan **Mål** och välj önskad användare.

5. Välj önskat språk i listan **Föredraget dokumentspråk**.

6. Klicka på **Spara**.

7. Upprepa steg 2–6 för varje användare som du vill ange dokumentspråk för.
