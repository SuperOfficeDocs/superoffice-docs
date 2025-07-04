---
uid: help-sv-document-template-create
title: Skapa ett malldokument
description: Skapa ett malldokument
keywords: dokumentmall, dokument, mall
author: Bergfrid Dias, Terje Nøstdahl, samuelholmstroem
date: 02.25.2025
version: 10.5.2
content_type: howto
language: sv
redirect_from: /sv/admin/lists/learn/creating-template-document
---

# Skapa ett malldokument

För att alla i företaget ska använda samma dokument kan du skapa och lägga till egna dokumentmallar för olika filtyper. Använd de tillgängliga mallvariablerna för att anpassa och automatisera inmatningen av kunduppgifter i dina dokument.

Du skapar en mall som ett dokument i en applikation som är kopplad till SuperOffice CRM, till exempel ett ordbehandlingsprogram. Om du skapar mallen i Word måste du spara den som ett vanligt dokument (med filtypen **DOC** eller **DOCX**), inte som en mall (med filtypen **DOT** eller **DOTX**).

Du kan också skapa mallar i HTML-format och redigera dem med SuperOffices redigeringsverktyg för HTML-filer.

> [!TIP]
> Om du vill lägga till nya mallar kan du enkelt kopiera en befintlig dokumentmallfil och redigera den så att den passar dina behov.

## Steg

1. Starta den applikation du ska använda.
2. Skapa ett nytt dokument.
3. Lägg in de [mallvariabler][1] du vill använda i mallen, till exempel variabler för namn, adress och telefonnummer.
4. Spara malldokumentet på en plats där du enkelt hittar den.

När du har definierat en mall och sparat den i mallmappen måste du [koppla mallen till SuperOffice CRM][2] för att kunna skapa dokument från den.

## Lägg till merge fields till offertmallen

Fält på offertlinjen som inte är aktiverade kommer att ha tomma värden för sina taggar – även om du lägger till data manuellt i databasen. För att använda alla taggar, gå till offertinställningarna i Inställningar och underhåll och aktivera alla fält.

För att infoga fält i din mall kan du använda en av följande metoder:

### Metod 1: Använd Fältdialogen

1. Placera markören där du vill infoga fältet.

1. Klicka på **Infoga** > **Snabbdelar** > **Fält**.

    ![Snabbdelar -screenshot][img1]

1. I listan **Fältnamn**, skriv "merge" för att markera **MergeField**.

1. I **Fältegenskaper**, skriv ditt [fältnamn][3] (utan «»):

    ![Fältegenskaper i Microsoft Word -screenshot][img2]

1. Klicka på **OK** och fältet kommer att infogas i ditt dokument:

    ![Infoga MERGEFIELD -screenshot][img3]

### Metod 2: Kopiera och klistra in befintliga fält (snabbast)

1. **Kopiera** ett befintligt fält från mallen. Se till att du kopierar hela fältet, inklusive «».

1. **Klistra** in fältet i din mall där det behövs.

1. Högerklicka på det inklistrade fältet och välj **Redigera fält**.

1. I rutan **Fältnamn** under **Fältegenskaper**, skriv eller klistra in det nya fältnamnet (utan «»).

1. Klicka på **OK**.

## Beräkningar

Du kan utföra beräkningar med merge fields.

### Nettopris per enhet

För att visa priset per enhet efter rabatter kan du lägga till ett merge field som detta:

```text
{= {MERGEFIELD line/totalPrice} / {MERGEFIELD line/quantity}}
```

**Steg:**

1. Tryck Ctrl + F9 för att lägga till ett nytt merge field. Du kommer att se två klamrar { }.

1. Inuti klamrarna:

    1. Lägg till "= " och tryck Ctrl + F9 igen.
    1. Lägg till "MERGEFIELD line/totalPrice" i en ny uppsättning klamrar.
    1. Skriv "/" och tryck sedan Ctrl + F9.
    1. Lägg till "MERGEFIELD line/quantity" i den sista uppsättningen klamrar.

1. Nu ska du ha ett fält som ser ut så här: {= {MERGEFIELD line/totalPrice} / {MERGEFIELD line/quantity}}

## Relaterat innehåll

* [Hur man arbetar med fält i Aspose Words][9]
* [Offertmallar och merge fields][4]
* [Referens för merge fields][3]
* [Referens för mallvariabler][6]

<!-- Referenced links -->
[1]: template-variables.md
[4]: quote-templates.md
[2]: ../admin/link-template.md
[3]: ../merge-fields/index.md
[6]: ../variables/for-quote-line.md
[9]: https://docs.aspose.com/words/net/fields-overview/

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/document/word-insert-quick-parts.png
[img2]: ../../../../media/loc/en/document/word-field-dialog.png
[img3]: ../../../../media/loc/en/document/6764-11541.jpg
