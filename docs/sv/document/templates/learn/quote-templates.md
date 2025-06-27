---
uid: help-sv-quote-template
title: Offertermallar och merge fields
description: Offertermallar och merge fields
keywords: offert, offertmall, mall, offertdokument, offertdetalj, merge field
author: Bergfrid Dias
date: 07.31.2024
version: 10
content_type: concept
language: sv
---

# Offertermallar och merge fields

Denna guide beskriver de olika typerna av offertermallar som finns tillgängliga i SuperOffice CRM, tillsammans med instruktioner för användning av merge fields för att anpassa offerter och orderbekräftelser. Dessa mallar inkluderar huvudoffertdokumentet, offertdetaljer, orderbekräftelser och tillhörande e-postmallar.

En offert består ofta av mer än en produkt. Det är därför nödvändigt att skapa en offertdetaljmall (och en orderbekräftelsemall) där varje produkt är listad i en tabell med olika grupperingar (såsom alternativ). Användaren kommer endast att kunna redigera offertdokumentet i Word. Offertdetaljerna och orderbekräftelsen kommer att genereras som en PDF och kan inte redigeras av användaren. Alla offertermallar kan redigeras på vanligt sätt i Inställningar och underhåll.

## <a id="types"></a>Typer av offertdokumentmallar

SuperOffice erbjuder olika mallar för att generera offerter. Dessa mallar kan nås och anpassas i Inställningar och underhåll under **Listor**.

| Typ | Beskrivning | Format | Exempel |
|---|---|---|---|
| Offert | Mallar för huvudoffertdokument | .doc eller .docx | markerad i gult |
| Offertdetaljer | Mallar för offertdetaljer | .pdf | markerad i lila |
| Orderbekräftelse | Mallar för orderbekräftelser | .pdf | markerad i rosa |
| E-postmall | Mallar för offert- och orderbekräftelse e-post | | markerad i orange |

![Offert - Dokumentmall -screenshot][img1]

![Offert - E-postmall -screenshot][img2]

### Mall för offertdokument

**Offert**-mallen är en kombination av följebrev skrivet av säljaren och offertdetaljerna. Offertdokumentet genereras när du [skapar en ny offert][7] eller öppnar en befintlig offert och väljer **Klicka för att skapa offertdokument**. Dokumentet genereras i .doc eller .docx-format, vilket tillåter redigering efter skapande. Det sparas automatiskt under fliken **Aktiviteter** i försäljningsposten. Det är också tillgängligt via länken på fliken **Offert**.

### Mall för offertdetaljer

**Offertdetalj**-mallen [sammanslås automatiskt](#usage) i huvudoffertdokumentet där fältet `<<QuoteDetails>>` är placerat. För att generera offertdetaljdokumentet, klicka på **Skicka** på Offertskärmen. Detta öppnar en dialog där du kan välja önskad layout och välja vilken offertdetaljmall som ska användas. Dokumentet skapas i .pdf-format och kan inte redigeras när det väl har genererats.

![Offertdetalj layout -screenshot][img3]

### Mall för orderbekräftelse

För att generera ett **orderbekräftelsedokument**, klicka på knappen **Registrera order**. Detta öppnar en dialog där du antingen kan välja **Skicka orderbekräftelse via e-post** eller generera dokumentet direkt. Orderbekräftelsemallen väljs baserat på försäljningstypen och ställs in i Inställningar och underhåll under **Listor** > **Sale – Type, Stages, Quote**. Dokumentet skapas i .pdf-format och kan inte redigeras när det väl har genererats.

![Offert orderbekräftelse mallval -screenshot][img4]

### E-postmall för offert och orderbekräftelse

När du skickar offerter eller orderbekräftelser via e-post, kan du välja en e-postmall. För offerter, klicka på **Skicka**-knappen och välj mallen från listan **Offertformat**. För orderbekräftelser, klicka på **Registrera order**, välj **Skicka orderbekräftelse via e-post**, välj mall och språk, och klicka sedan på **OK** för att skicka.

![Offert skicka e-post -screenshot][img5]

![Offert skicka orderbekräftelse -screenshot][img6]

## Merge fields i offertermallar

**Merge fields** i SuperOffice CRM offertermallar möjliggör dynamisk insättning av detaljer som produktlinjer och alternativ. Till skillnad från [standard mallvariabler][1], följer merge fields en specifik struktur, eller hierarki, för att säkerställa korrekt dataintegration.

Du kan anpassa offert- och orderbekräftelsemallar genom att använda merge fields i Microsoft Word. Merge fields låter dig infoga specifik offertinformation i mallar, medan standard mallvariabler hämtar kunddata och andra detaljer.

### <a id="structure"></a>Struktur av merge fields

Merge fields måste följa en hierarkisk ordning: quote > alternative > group > line. Denna struktur definieras med hjälp av **TableStart** och **TableEnd** fält, som markerar början och slutet av varje tabellområde:

```text
«TableStart:quote»
  «TableStart:alternative»
    «GroupBy:productFamilyKey»«TableStart:group»
      «TableStart:line»
      «TableEnd:line»
    «TableEnd:group»
  «TableEnd:alternative»
«TableEnd:quote»
```

* quote: Den yttersta nivån, som representerar hela offerten.
* alternative: Inbäddad inom offert, använd för olika produktalternativ.
* group: Inbäddad inom alternativ, använd för att gruppera produkter (valfritt).
* line: Inbäddad inom grupp, som representerar individuella produktlinjer.

> [!NOTE]
> Varje mall måste följa inbäddningsordningen och alltid starta med den yttersta nivån (quote). Den behöver inte gå hela vägen ner, men kan inte börja med alternativ eller något annat än offert.

### <a id="usage"></a>Användning av merge fields

Offertdetaljer inkluderar detaljerad information som linjer, priser och produktnamn, vanligtvis placerad i en separat mall från offertdokumentet. Om både huvuddokumentet och offertdetaljerna används:

* Om fältet `<<QuoteDetails>>` finns i huvuddokumentet, infogas offertdetaljerna vid den platsen.
* Om fältet `<<QuoteDetails>>` inte finns, läggs offertdetaljerna till i slutet.

I båda fallen genereras en enda PDF som bifogas e-postmeddelandet.

Taggar för en viss tabell är tillgängliga från den tabellens TableStart: tagg till dess slut.

**Exempel:**

[Linjefält][2] (såsom *line/name*) kan endast placeras inom linjetabellen (`«TableStart:line» «TableEnd:line»`), medan alternativfält kan placeras inom både alternativtabellen och de underordnade tabellerna (grupp och linje).

![Offertdetaljer exempel, TableStart:line -screenshot][img7]

### Gruppning och sortering

**Gruppning:** Du kan gruppera produkter i mallen genom att använda **GroupBy** taggen, med en linje-nivå suffix, såsom `GroupBy:productFamilyKey` för att gruppera produkter efter deras familj.

* GroupBy taggen är skiftlägeskänslig och kan placeras var som helst i dokumentet. Vid körning försvinner denna tagg utan att lämna någon text.
* Endast en GroupBy tagg är tillåten per mall.

När en GroupBy tagg finns, använd **TableStart** och **TableEnd** för att markera början och slutet av grupp-relaterade sektioner. Taggen **group/groupField** kommer att innehålla värdet av gruppfältet (till exempel, produktfamilj). Sektionen mellan TableStart och TableEnd upprepas för varje unikt värde av gruppfältet.

* Du kan ha flera uppsättningar av TableStart och TableEnd sektioner. Till exempel, du kanske vill ha en sammanfattningstabell med totaler och separata tabeller för linjerna i varje grupp. I detta fall, bör sammanfattningstabellen inte inkludera en inre TableStart:line/TableEnd:line sektion.

Inom gruppen (mellan TableStart och TableEnd), kan du lägga till fält som är specifika för gruppen.

**Sortering:** Som standard är offertlinjer listade i rangordning, som sett i offertlinjearkiven. Om gruppering används, sorteras grupper alfabetiskt, och linjer inom varje grupp sorteras efter rang.

För att ändra ordningen på offertlinjer, använd **OrderBy** taggen, med en linje-nivå suffix. Till exempel, `OrderBy:name` sorterar produkter alfabetiskt efter namn, och `OrderBy:vatInfo` sorterar produkter efter momsstatus. Endast en nivå av sortering stöds.

### <a id ="culture"></a>Formatering av numeriska och datumfält

Numeriska och datumfält kan formateras för att matcha de valda språk/kulturinställningarna (påverkar visningsordning och separatorer):

* **Numeriska fält:** För decimalvärden kan du specificera antalet decimaler (0, 2, eller 5). Till exempel, `line/totalPrice:2` säkerställer två decimaler. Decimal separatorn är alltid enligt valt språk/kultur.

* **Datum och tidsfält:** Tillgängliga format inkluderar ShortDate, ShortTime, ShortDateTime, LongDate, LongTime, och LongDateTime. Till exempel, `quote/sent:LongDateTime` för full datum och tid.

Om ingen specifik formatering är satt, används standarden för valt språk.

Den faktiska formateringen (decimalseparator, dag/månad ordning, osv.) speglar användarens valda kultur, som specificeras i dialogerna **Skicka offert** och **Registrera order**. För specifika formateringsbehov, kan du inkludera **Culture:** fältet i mallen, och specificera en [.NET kulturkod][11] (som, `Culture:de-CH` för schweizisk tyska) för att åsidosätta användarens val. Detta innebär att en sådan kulturkod bör byggas in i en speciell mall kallad *Offert till schweiziska kunder* eller liknande.

> [!NOTE]
> Använd inte *Table of Language Culture Names, Codes, and ISO Values Method* av [C++ AppConfig objekt][12] som referens, det finns små skillnader.

Genom att följa dessa riktlinjer, kan du effektivt använda merge fields för att skapa detaljerade, anpassade offert- och orderbekräftelsemallar i SuperOffice CRM.

## Relaterat innehåll

* [Uppdatera offertmall][5]
* [Handledning][6]
* [Merge field-referens][3]
* [Mallvariabelreferens][4]
* [System.Globalization.CultureInfo][11]
* [Aspose][13] (hanterar dokumentgenerering)

<!-- Referenced links -->
[1]: template-variables.md
[2]: ../merge-fields/line.md
[3]: ../merge-fields/index.md
[4]: ../variables/for-quote-line.md
[5]: ../admin/update-template.md
[6]: ../admin/update-template.md
[7]: ../../../sale/learn/quote/create.md
[11]: https://docs.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo?view=net-5.0
[12]: https://docs.microsoft.com/en-us/previous-versions/commerce-server/ee825488(v=cs.20)
[13]: http://www.aspose.com

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/document/quote-list-document-template.png
[img2]: ../../../../media/loc/en/document/quote-list-email-template.png
[img3]: ../../../../media/loc/en/document/quote-layout.png
[img4]: ../../../../media/loc/en/document/quote-order-confirmation-template.png
[img5]: ../../../../media/loc/en/document/quote-send-email.png
[img6]: ../../../../media/loc/en/document/quote-send-confirmation.png
[img7]: ../../../../media/loc/en/document/tablestart-line.png
