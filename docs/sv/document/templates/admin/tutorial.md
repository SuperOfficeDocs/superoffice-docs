---
uid: help-sv-quote-template-tutorial
title: Anpassa orderbekräftelsemall
description: Anpassa orderbekräftelsemall
keywords: dokumentmall, dokument, mall, offert, orderbekräftelse
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: tutorial
audience: settings
audience_tooltip: Settings and maintenance
language: sv
index: true
---

# Anpassa orderbekräftelsemall

I denna handledning kommer vi att använda en orderbekräftelsemall som grund för att skapa en ny mall.

Vi kommer att:

* Lägga till namnet på alternativet (taget från offerten).
* Lägga till antalet rader i alternativet.
* Lägga till en miniatyrbild av produkten.
* Sortera produkterna efter produktnamn.
* Gruppera produkterna i malldokumentet efter produktfamilj. En produktfamilj kan till exempel vara "hårdvara", "mjukvara" eller "tillbehör".
* Ange en totalsumma för produkterna i varje grupp, men behålla totalsumman för alternativet som redan finns i malldokumentet.

## Förberedelser

### Skapa en försäljning för att testa mallen

1. I SuperOffice CRM, [skapa en offert][5] med olika produkter från olika produktfamiljer för att testa grupperingsfunktionen.

2. Se till att försäljningen har samma typ som den du kommer att länka mallen till (senare i denna handledning).

3. Klicka på **Registrera order** i offerten för att aktivera knappen **Visa bekräftelse**.

### Välj fälten som ska visas

1. Kontrollera att de nödvändiga produktfälten är synliga i dialogrutan **Konfigurera produkt**.

* Endast [fält markerade som synliga][4] i Inställningar och underhåll kommer att visas i mallen.

### Kopiera mallen som ska ändras

1. I Inställningar och underhåll, välj **Listor** från Navigatören.
2. Klicka på pilen och välj **Document - Template**.
3. Dubbelklicka på mallen *Orderbekräftelse* och klicka **Redigera** för att öppna den i Microsoft Word.
4. Spara dokumentet med ett nytt namn på en lättillgänglig plats.
5. [Lägg till malldokumentet][1].
6. Namnge dokumentet logiskt, till exempel *Orderbekräftelse – Grupperad*.
7. Markera alternativet **Offertdokumenttyp** för att göra det tillgängligt för offerter i SuperOffice CRM.
8. Välj **Mall för orderbekräftelser**.

### Länka malldokumentet till en försäljningstyp

1. På skärmen **Listor**, dubbelklicka **Sale – Type, Stages, Quote**.
2. I översikten **Poster**, dubbelklicka på en försäljningstyp för att öppna dialogrutan **Redigera post**.
3. Gå till fliken **Standardvärden**, öppna listan **Mall för offertformat** och välj din nya mall.
4. Klicka **OK** för att spara dina ändringar.

## Ändra mallen

I detta avsnitt kommer du att lära dig hur du ändrar malldokumentet genom att infoga fält, lägga till produktbilder, gruppera produkter och välja sorteringsordning.

### Infoga fält i Word

1. Öppna malldokumentet från listan **Document - Template**.

1. **Kopiera** ett befintligt fält från mallen. Se till att kopiera hela fältet, inklusive «».

1. **Klistra in** fältet i mallen efter titeln ("Detaljer").

1. Högerklicka på det inklistrade fältet och välj **Redigera fält**. I rutan **Fältnamn** under **Fältegenskaper**, ange *alternative/name* (utan «»). Klicka **OK**.

    > [!NOTE]
    > Det är viktigt att du skiljer mellan stora och små bokstäver när du skriver fältnamnen.

1. Kopiera ett befintligt fält (igen) och klistra in det under produkttabellen (vänsterjusterat på samma rad som totalsumman för alternativet).

1. Ange *alternative/numLines* som fältnamn och klicka **OK**.

1. Ange etiketten *Rader:* till vänster om fältet numLines.

1. Infoga en ny kolumn med titeln "Bild" (`Image:line/quoteLineThumbnail`.)

1. Din mall ska nu se ut så här:

    ![Orderbekräftelse med nya fält -screenshot][img1]

1. Spara malldokumentet, men stäng det inte.

### Visa orderbekräftelsen i SuperOffice CRM (valfritt)

För att säkerställa att dina ändringar reflekteras korrekt, följ dessa steg för att visa orderbekräftelsen:

1. **Öppna en försäljning** av samma typ som din mall är länkad till.
2. Gå till fliken **Offert** inom försäljningen och klicka **Öppna**.
3. Klicka på **Registrera order** om du inte redan har gjort det.
4. I dialogrutan **Redigera offert**, klicka **Visa bekräftelse**. Orderbekräftelsen öppnas som en PDF-fil.
5. Kontrollera orderbekräftelsen:
    * Se till att allt tabellinnehåll visas korrekt, utan att siffror delas över två rader.
    * Kontrollera att inga fältnamn visas i dokumentet; om de gör det kan du ha använt felaktiga fältnamn.
    * Bekräfta att alla infogade fält är närvarande. Saknade fält kan indikera att de nödvändiga uppgifterna inte är tillgängliga i offerten eller produkten.
6. Gör eventuella nödvändiga justeringar av mallen och spara den.
7. Granska orderbekräftelsen igen för att säkerställa att alla ändringar visas korrekt.

### Ange sorteringsordning

1. Infoga **OrderBy**-fältet i malldokumentet.

    `«TableStart:alternative»«OrderBy:name»`

Produkter kommer nu att sorteras efter produktnamn inom varje alternativ.
Efter att grupperingsområdet har definierats kommer produkterna också att sorteras inom varje grupp.

### Ange grupperingsområde och nyckel

1. Infoga `«TableStart:group»` före TableStart:rad.
1. Infoga `«TableEnd:group»` efter TableEnd:rad.
1. Infoga `«GroupBy:productFamilyKey»` var som helst i dokumentet för att definiera grupperingsnyckeln.

### Lägg till gruppspecifika fält

1. Flytta tabellen med totalsumman för alternativet (inklusive det totala antalet rader) ner några rader, så att du har plats att infoga gruppfälten mellan TableStart:group och TableEnd:group.

1. Mellan titeln och tabellen som innehåller produkterna, infoga `«group/groupField»`. Ge fältet en rubrikstil.

    Detta är titeln på gruppen (namnet på fältet som produkterna är grupperade efter).

1. Nederst i kolumnen med priser, infoga `«group/sumtotalPrice»`.

    Detta är totalsumman för hela gruppen.

1. I cellen till vänster om totalsumman för hela gruppen, infoga `«group/groupField»`. Skriv etiketten *Summa* till vänster om fältet.

### Spara och verifiera

1. Din mall ska nu se ut så här:

    ![Orderbekräftelse resultat -screenshot][img2]

1. Spara malldokumentet och verifiera enligt beskrivningen ovan.

## Relaterat innehåll

* [Skapa ett malldokument][2]
* [Mallvariabelreferens][3]

<!-- Referenced links -->
[1]: link-template.md
[2]: ../learn/create.md
[3]: ../variables/index.md
[4]: ../../../sale/admin/quote/configure-product-fields.md
[5]: ../../../sale/learn/create.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/document/tutorial-insert-fields.png
[img2]: ../../../../media/loc/en/document/tutorial-grouped.png
