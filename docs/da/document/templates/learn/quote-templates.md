---
uid: help-da-quote-template
title: Tilbudsskabeloner og fletfelter
description: Tilbudsskabeloner og fletfelter
keywords: tilbud, tilbudsskabelon, skabelon, tilbudsdokument, tilbudsdetaljer, fletfelt
author: Bergfrid Dias
date: 07.31.2024
version: 10
topic: concept
language: da
---

# Tilbudsskabeloner og fletfelter

Denne guide beskriver de forskellige typer af tilbudsskabeloner, der er tilgængelige i SuperOffice CRM, sammen med instruktioner til brug af fletfelter for at tilpasse tilbud og ordrebekræftelser. Disse skabeloner inkluderer hovedtilbudsdokumentet, tilbudsdetaljer, ordrebekræftelser og tilhørende e-mailskabeloner.

Et tilbud består ofte af mere end ét produkt. Det er derfor nødvendigt at oprette en tilbudsdetaljeskabelon (og en ordrebekræftelsesskabelon), hvor hvert produkt er opført i en tabel med forskellige grupperinger (som alternativer). Brugeren vil kun kunne redigere tilbudsdokumentet i Word. Tilbudsdetaljerne og ordrebekræftelsen bliver genereret som en PDF og kan ikke redigeres af brugeren. Alle tilbudsskabeloner kan redigeres på normal vis i Indstillinger og vedligeholdelse.

## <a id="types"></a>Typer af tilbudsskabeloner

SuperOffice tilbyder forskellige skabeloner til generering af tilbud. Disse skabeloner kan tilgås og tilpasses i Indstillinger og vedligeholdelse under **Lister**.

| Type | Beskrivelse | Format | Eksempel |
|---|---|---|---|
| Tilbud | Skabelon til tilbudsdokument | .doc eller .docx | markeret med gult |
| Tilbudsdetaljer | Skabelon til tilbudsdetaljer | .pdf | markeret med lilla |
| Ordrebekræftelse | Skabelon til ordrebekræftelser | .pdf | markeret med pink |
| E-mailskabelon | Skabeloner til tilbuds- og ordrebekræftelsese-mails | | markeret med orange |

![Tilbud - Dokumentskabelon -screenshot][img1]

![Tilbud - E-mailskabelon -screenshot][img2]

### Skabelon til tilbudsdokument

**Tilbudsskabelonen** er en kombination af følgebrev skrevet af sælgeren og tilbudsdetaljerne. Tilbudsdokumentet genereres, når du [opretter et nyt tilbud][7] eller åbner et eksisterende tilbud og vælger **Klik for at oprette tilbudsdokument**. Dokumentet genereres i .doc eller .docx-format, hvilket tillader redigering efter oprettelse. Det gemmes automatisk under **Aktiviteter**-fanen i salgsoptegnelsen. Det er også tilgængeligt via linket på **Tilbud**-fanen.

### Skabelon til tilbudsdetaljer

**Tilbudsdetaljeskabelonen** [fletter automatisk](#usage) ind i tilbudsdokumentet, hvor fletfeltet `<<QuoteDetails>>` er placeret. For at generere tilbudsdetaljedokumentet, klik **Send** på Tilbud-skærmen. Dette åbner en dialog, hvor du kan vælge den ønskede layout og vælge, hvilken tilbudsdetaljeskabelon der skal bruges. Dokumentet oprettes i .pdf-format og kan ikke redigeres, når det først er genereret.

![Tilbudsdetalje layout -screenshot][img3]

### Skabelon til ordrebekræftelser

For at generere et **ordrebekræftelsesdokument**, klik på **Placer ordre** knappen. Dette åbner en dialog, hvor du enten kan vælge **Send ordrebekræftelse via e-mail** eller generere dokumentet direkte. Ordrebekræftelsesskabelonen vælges baseret på salgstypen og indstilles i Indstillinger og vedligeholdelse under **Lister** > **Sale – Type, Stages, Quote**. Dokumentet oprettes i .pdf-format og kan ikke redigeres, når det først er genereret.

![Tilbud ordrebekræftelses skabelon valg -screenshot][img4]

### E-mailskabelon til tilbud og ordrebekræftelse

Når du sender tilbud eller ordrebekræftelser via e-mail, kan du vælge en e-mailskabelon. For tilbud, klik på **Send** knappen og vælg skabelonen fra **E-mail tekst** listen. For ordrebekræftelser, klik **Placer ordre**, vælg **Send ordrebekræftelse via e-mail**, vælg e-mail tekstskabelonen og sproget, og klik derefter **OK** for at sende.

![Tilbud send e-mail -screenshot][img5]

![Tilbud send ordrebekræftelse -screenshot][img6]

## Fletfelter i tilbudsskabeloner

**Fletfelter** i SuperOffice CRM tilbudsskabeloner muliggør dynamisk indsættelse af detaljer som produktlinjer og alternativer. I modsætning til [standard skabelonvariabler][1], følger fletfelter en specifik struktur, eller hierarki, for at sikre korrekt dataintegration.

Du kan tilpasse tilbuds- og ordrebekræftelsesskabeloner ved brug af fletfelter i Microsoft Word. Fletfelter lader dig indsætte specifik tilbudsinformation i skabeloner, mens standard skabelonvariabler henter kundedata og andre detaljer.

### <a id="structure"></a>Struktur af fletfelter

Fletfelter skal følge en hierarkisk rækkefølge: quote > alternative > group > line. Denne struktur defineres ved brug af **TableStart** og **TableEnd** felter, som markerer starten og slutningen af hvert tabelområde:

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

* quote: Det yderste niveau, der repræsenterer hele tilbuddet.
* alternative: Indlejret inden for tilbud, brugt til forskellige produktalternativer.
* group: Indlejret inden for alternativ, brugt til at gruppere produkter (valgfrit).
* line: Indlejret inden for gruppe, der repræsenterer individuelle produktlinjer.

> [!NOTE]
> Hver skabelon skal overholde indlejringsrækkefølgen og altid starte med det yderste niveau (quote). Den behøver ikke at gå hele vejen ned, men kan ikke starte med alternative eller andet end quote.

### <a id="usage"></a>Brug af fletfelter

Tilbudsdetaljer inkluderer detaljerede informationer som linjer, priser og produktnavne, typisk placeret i en separat skabelon fra tilbudsdokumentet. Hvis både hoveddokumentet og tilbudsdetaljerne bruges:

* Hvis `<<QuoteDetails>>` fletfeltet er til stede i hoveddokumentet, indsættes tilbudsdetaljerne på den placering.
* Hvis `<<QuoteDetails>>` fletfeltet ikke er til stede, tilføjes tilbudsdetaljerne til slutningen.

I begge tilfælde genereres en enkelt PDF, som vedhæftes e-mailen.

Tags for en bestemt tabel er tilgængelige fra den tabels TableStart: tag til dens slutning.

**Eksempel:**

[Linjefelter][2] (såsom line/name) kan kun placeres inden for linjetabellen (`«TableStart:line» «TableEnd:line»`), mens alternative felter kan placeres inden for både den alternativetabel og de underliggende tabeller (group og line).

![Tilbudsdetaljer eksempel, TableStart -screenshot][img7]

### Gruppering og sortering

**Gruppering:** Du kan gruppere produkter i skabelonen ved brug af **GroupBy** taggen, med en linje-niveau suffiks, som `GroupBy:productFamilyKey` for at gruppere produkter efter deres familie.

* GroupBy taggen er case-sensitiv og kan placeres hvor som helst i dokumentet. Ved runtime forsvinder denne tag uden at efterlade nogen tekst.
* Kun en GroupBy tag er tilladt per skabelon.

Når en GroupBy tag er til stede, brug **TableStart** og **TableEnd** til at markere starten og slutningen af gruppe-relaterede sektioner. **group/groupField** taggen vil indeholde værdien af gruppefeltet (for eksempel, produktfamilie). Sektionen mellem TableStart og TableEnd gentages for hver unik værdi af gruppefeltet.

* Du kan have flere sæt af TableStart og TableEnd sektioner. For eksempel, du ønsker måske en opsummeringstabel med totaler og separate tabeller for linjerne i hver gruppe. I dette tilfælde, skal opsummeringstabellen ikke inkludere en indre TableStart:line/TableEnd:line sektion.

Inden for gruppen (mellem TableStart og TableEnd), kan du tilføje felter, der er specifikke for gruppen.

**Sortering:** Som standard, er tilbudslinjer listet i rangorden, som set i tilbudslinje arkiverne. Hvis grupperingen bruges, sorteres grupper alfabetisk, og linjerne inden for hver gruppe sorteres efter rang.

For at ændre rækkefølgen på tilbudslinjer, brug **OrderBy** taggen, med en linje-niveau suffiks. For eksempel, `OrderBy:name` sorterer produkter alfabetisk efter navn, og `OrderBy:vatInfo` sorterer produkter efter momsstatus. Kun et niveau af sortering understøttes.

### <a id ="culture"></a>Formatering af numeriske og dato data

Numeriske og datofelter kan formateres for at matche de valgte sprog/kulturindstillinger (påvirker visningsrækkefølge og separatorer):

* **Numeriske felter:** For decimalværdier, kan du specificere antallet af decimaler (0, 2, eller 5). For eksempel, `line/totalPrice:2` sikrer to decimaler. Decimal separatoren er altid i henhold til valgt sprog/kultur.

* **Dato og tidsfelter:** Tilgængelige formater inkluderer ShortDate, ShortTime, ShortDateTime, LongDate, LongTime, og LongDateTime. For eksempel, `quote/sent:LongDateTime` for fuld dato og tid.

Hvis ingen specifik formatering er sat, bruges standarden for valgt sprog.

Den faktiske formatering (decimalseparator, dag/måned rækkefølge, osv.) afspejler brugerens valgte kultur, som specificeres i **Send tilbud** og **Placer ordre** dialogerne. For specifikke formateringsbehov, kan du inkludere **Culture:** fletfeltet i skabelonen, og specificere en [.NET kulturkode][11] (som, `Culture:de-CH` for schweizisk tysk) for at tilsidesætte brugerens valg. Dette indebærer, at en sådan kulturkode bør indbygges i en speciel skabelon kaldet *Tilbud til schweiziske kunder* eller lignende.

> [!NOTE]
> Brug ikke *Table of Language Culture Names, Codes, and ISO Values Method* af [C++ AppConfig objektet][12] som reference, der er små forskelle.

Ved at følge disse retningslinjer, kan du effektivt bruge fletfelter til at skabe detaljerede, tilpassede tilbuds- og ordrebekræftelsesskabeloner i SuperOffice CRM.

## Relateret indhold

* [Opdater tilbudsskabelon][5]
* [Tutorial][6]
* [Fletfeltreference][3]
* [Skabelonvariabelreference][4]
* [System.Globalization.CultureInfo][11]
* [Aspose][13] (håndterer dokumentgenerering)

<!-- Referenced links -->
[1]: template-variables.md
[2]: ../merge-fields/line.md
[3]: ../merge-fields/index.md
[4]: ../variables/for-quote-line.md
[5]: ../admin/update-template.md
[6]: ../admin/update-template.md
[7]: ../../../quote/learn/create.md
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
