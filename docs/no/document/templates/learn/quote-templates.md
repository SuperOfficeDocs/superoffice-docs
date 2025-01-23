---
uid: help-no-quote-template
title: Tilbudsmaler og flettefelt
description: Tilbudsmaler og flettefelt
keywords: tilbud, tilbudsmal, mal, tilbudsdokument, tilbudsdetaljer, flettefelt
author: Bergfrid Dias
date: 07.31.2024
version: 10
topic: concept
language: no
---

# Tilbudsmaler og flettefelt

Denne veiledningen beskriver de forskjellige typene tilbudsmaler som er tilgjengelige i SuperOffice CRM, sammen med instruksjoner for bruk av flettefelt for å tilpasse tilbud og ordrebekreftelser. Disse malene inkluderer hovedtilbudsdokumentet, tilbudsdetaljer, ordrebekreftelser og tilhørende e-postmaler.

Et tilbud består ofte av mer enn ett produkt. Det er derfor nødvendig å lage en mal for tilbudsdetaljer (og en ordrebekreftelsesmal) der hvert produkt er oppført i en tabell med forskjellige grupperinger (som alternativer). Brukeren vil bare kunne redigere tilbudsdokumentet i Word. Tilbudsdetaljene og ordrebekreftelsen genereres som en PDF og kan ikke redigeres av brukeren. Alle tilbudsmaler kan redigeres på vanlig måte i Innstillinger og vedlikehold.

## <a id="types"></a>Typer tilbudsdokumentmaler

SuperOffice tilbyr forskjellige maler for å generere tilbud. Disse malene kan nås og tilpasses i Innstillinger og vedlikehold under **Lister**.

| Type | Beskrivelse | Format | Eksempel |
|---|---|---|---|
| Tilbud | Hovedtilbudsdokumentmal | .doc eller .docx | markert i gult |
| Tilbudsdetaljer | Mal for tilbudsdetaljer | .pdf | markert i lilla |
| Ordrebekreftelse | Mal for ordrebekreftelser | .pdf | markert i rosa |
| E-postmal | Maler for tilbuds- og ordrebekreftelser | | markert i oransje |

![Tilbud - Dokumentmal -screenshot][img1]

![Tilbud - E-postmal -screenshot][img2]

### Tilbudsdokument

Malen **Tilbudsdokument** er en kombinasjon av følgebrev skrevet av selgeren og tilbudsdetaljene. Tilbudsdokumentet genereres når du [lager et nytt tilbud][7] eller åpner et eksisterende tilbud og velger **Klikk for å opprette tilbudsdokument**. Dokumentet genereres i .doc eller .docx-format, som tillater redigering etter opprettelse. Det lagres automatisk under **Aktiviteter**-fanen i salgsoppføringen. Det er også tilgjengelig via lenken på **Tilbud**-fanen.

### Mal for tilbudsdetaljer

Malen for **tilbudsdetaljer** [flettes automatisk](#usage) inn i tilbudsdokumentet der flettefeltet `<<QuoteDetails>>` er plassert. For å generere tilbudsdetaljdokumentet, klikk **Send** i Tilbuds-skjermen. Dette åpner en dialog der du kan velge ønsket layout og velge hvilken mal for tilbudsdetaljer som skal brukes. Dokumentet opprettes i .pdf-format og kan ikke redigeres etter at det er generert.

![Tilbudsdetalj layout -screenshot][img3]

### Ordrebekreftelsesmal

For å generere et **ordrebekreftelsesdokument**, klikk på **Registrer ordre** knappen. Dette åpner en dialog der du enten kan velge **Send ordrebekreftelse via e-post** eller generere dokumentet direkte. Ordrebekreftelsesmalen velges basert på salgstypen og settes i Innstillinger og vedlikehold under **Lister** > **Sale – Type, Stages, Quote**. Dokumentet opprettes i .pdf-format og kan ikke redigeres etter at det er generert.

![Malvalg for ordrebekreftelse -screenshot][img4]

### E-postmal for tilbud og ordrebekreftelse

Når du sender tilbud eller ordrebekreftelser via e-post, kan du velge en e-postmal. For tilbud, klikk på **Send** knappen og velg malen fra listen **Tilbudsformat**. For ordrebekreftelser, klikk **Registrer ordre**, velg **Send ordrebekreftelse via e-post**, velg e-postmalen og språket, og klikk deretter **OK** for å sende.

![Tilbud send e-post -screenshot][img5]

![Tilbud send ordrebekreftelse -screenshot][img6]

## Flettefelt i tilbudsmaler

**flettefelt** i SuperOffice CRM tilbudsmaler muliggjør dynamisk innsetting av detaljer som produktlinjer og alternativer. I motsetning til [standard malvariabler][1], følger flettefelt en spesifikk struktur, eller hierarki, for å sikre riktig dataintegrasjon.

Du kan tilpasse tilbuds- og ordrebekreftelsesmaler ved bruk av flettefelt i Microsoft Word. flettefelt lar deg sette inn spesifikk tilbudsinformasjon i maler, mens standard malvariabler henter kundedata og andre detaljer.

### <a id="structure"></a>Struktur av flettefelt

flettefelt må følge en hierarkisk rekkefølge: quote > alternative > group > line. Denne strukturen defineres ved bruk av **TableStart** og **TableEnd** felt, som markerer starten og slutten av hvert tabellområde:

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

* quote: Det ytterste nivået, representerer hele tilbudet.
* alternative: Nestet innenfor tilbud, brukt for forskjellige produktalternativer.
* group: Nestet innenfor alternativ, brukt for å gruppere produkter (valgfritt).
* line: Nestet innenfor gruppe, representerer individuelle produktlinjer.

> [!NOTE]
> Hver mal må overholde rekkefølgen og alltid starte med det ytterste nivået (quote). Den trenger ikke gå helt ned, men kan ikke starte med alternative eller noe annet enn quote.

### <a id="usage"></a>Bruk av flettefelt

Tilbudsdetaljer inkluderer detaljer som linjer, priser og produktnavn, og er vanligvis plassert i en separat mal fra tilbudsdokumentet. Hvis både hoveddokumentet og tilbudsdetaljene brukes:

* Hvis flettefeltet `<<QuoteDetails>>` er til stede i hoveddokumentet, settes tilbudsdetaljene inn på det stedet.
* Hvis flettefeltet `<<QuoteDetails>>` ikke er til stede, legges tilbudsdetaljene til på slutten.

I begge tilfeller genereres en enkelt PDF som vedlegges e-posten.

Tagger for en bestemt tabell er tilgjengelige fra den tabellens TableStart: tag til dens slutt.

**Eksempel:**

[Linjefelt][2] (som line/name) kan bare plasseres innenfor linjetabellen («TableStart:line» «TableEnd:line»), mens alternativfelt kan plasseres innenfor både alternativtabellen og de underliggende tabellene (gruppe og linje).

![Tilbudsdetaljer eksempel, TableStart -screenshot][img7]

### Gruppering og sortering

**Gruppering:** Du kan gruppere produkter i malen ved bruk av **GroupBy** taggen, med en linje-nivå suffiks, som `GroupBy:productFamilyKey` for å gruppere produkter etter deres familie.

* GroupBy taggen skiller mellom store og små bokstaver og kan plasseres hvor som helst i dokumentet. Ved kjøring forsvinner denne taggen uten å etterlate noen tekst.
* Bare én GroupBy tag er tillatt per mal.

Når en GroupBy tag er til stede, bruk **TableStart** og **TableEnd** for å markere begynnelsen og slutten av gruppe-relaterte seksjoner. **group/groupField** taggen vil inneholde verdien av gruppefeltet (for eksempel, productFamily). Seksjonen mellom TableStart og TableEnd vil gjentas for hver unik verdi av gruppefeltet.

* Du kan ha flere sett med TableStart og TableEnd seksjoner. For eksempel, du vil kanskje ha en oppsummeringstabell med totaler og separate tabeller for linjene i hver gruppe. I dette tilfellet bør oppsummeringstabellen ikke inkludere en indre TableStart:line/TableEnd:line seksjon.

Innenfor gruppen (mellom TableStart og TableEnd), kan du legge til felt som er spesifikke for gruppen.

**Sortering:** Som standard er tilbudslinjer oppført i rekkefølge etter rangering, som sett i tilbudslinje arkivene. Hvis gruppering brukes, sorteres grupper alfabetisk, og linjene innenfor hver gruppe sorteres etter rangering.

For å endre rekkefølgen på tilbudslinjer, bruk **OrderBy** taggen, med en linje-nivå suffiks. For eksempel, `OrderBy:name` sorterer produkter alfabetisk etter navn, og `OrderBy:vatInfo` sorterer produkter etter MVA-status. Bare ett nivå av sortering støttes.

### <a id ="culture"></a>Formatering av numeriske og datofelt

Numeriske og datofelt kan formateres for å matche de valgte språk/kultinnstillingene (påvirker visningsrekkefølge og separatorer):

* **Numeriske felt:** For desimalverdier, kan du spesifisere antall desimaler (0, 2, eller 5). For eksempel, `line/totalPrice:2` sikrer to desimaler. Desimal separatoren er alltid i henhold til valgt språk/kultur.

* **Dato- og tidfelt:** Tilgjengelige formater inkluderer ShortDate, ShortTime, ShortDateTime, LongDate, LongTime, og LongDateTime. For eksempel, `quote/sent:LongDateTime` for full dato og tid.

Hvis ingen spesifikk formatering er satt, brukes standarden for valgt språk.

Den faktiske formateringen (desimalseparator, dag/måned rekkefølge, osv.) gjenspeiler brukerens valgte kultur, som spesifiseres i **Send tilbud** og **Registrer ordre** dialogene. For spesifikke formateringsbehov, kan du inkludere **Culture:** flettefeltet i malen, og spesifisere en [.NET kulturkode][11] (som, `Culture:de-CH` for sveitsisk tysk) for å overstyre brukerens valg. Dette innebærer at en slik kulturkode bør innebygges i en spesiell mal kalt *Tilbud til sveitsiske kunder* eller lignende.

> [!NOTE]
> Ikke bruk *Table of Language Culture Names, Codes, and ISO Values Method* fra [C++ AppConfig objekt][12] som referanse, det er små forskjeller.

Ved å følge disse retningslinjene, kan du effektivt bruke flettefelt for å lage detaljerte, tilpassede tilbuds- og ordrebekreftelsesmaler i SuperOffice CRM.

## Relatert innhold

* [Oppdater tilbudsmal][5]
* [Veiledning][6]
* [flettefeltreferanse][3]
* [Malvariabelreferanse][4]
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
