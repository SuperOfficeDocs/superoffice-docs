---
uid: help-no-quote-template-tutorial
title: Tilpass ordrebekreftelsesmal
description: Tilpass ordrebekreftelsesmal
keywords: dokumentmal, dokument, mal, tilbud, ordrebekreftelse
author: Bergfrid Dias
date: 07.31.2024
version: 10
topic: tutorial
language: no
audience: settings
audience_tooltip: Settings and maintenance
---

# Tilpass ordrebekreftelsesmal

I denne veiledningen vil vi bruke et ordrebekreftelsesmal som grunnlag for å lage en ny mal.

Vi skal:

* Legge til navnet på alternativet (hentet fra tilbudet).
* Legge til antall linjer i alternativet.
* Legge til et miniatyrbilde av produktet.
* Sortere produktene etter produktnavn.
* Gruppere produktene i maldokumentet etter produktfamilie. En produktfamilie kan for eksempel være "maskinvare", "programvare" eller "tilbehør".
* Angi en totalsum for produktene i hver gruppe, men beholde totalsummen for alternativet som allerede finnes i maldokumentet.

## Forberedelser

### Opprett et salg for å teste malen

1. I SuperOffice CRM, [opprett et tilbud][5] med forskjellige produkter fra ulike produktfamilier for å teste grupperingsfunksjonen.

2. Sørg for at salget har samme type som den du vil knytte malen til (senere i denne veiledningen).

3. Klikk **Registrer ordre** i tilbudet for å aktivere knappen **Vis bekreftelse**.

### Velg feltene som skal vises

1. Sørg for at de nødvendige produktfeltene er synlige i dialogboksen **Konfigurer produkt**.

* Bare felter merket som synlige i Innstillinger og vedlikehold vil vises i malen.

* Se [Konfigurer produkter][4] for mer informasjon om å sette felt synlighet.

### Kopier malen som skal endres

1. I Innstillinger og vedlikehold, velg **Lister** fra Navigatoren.
2. Klikk på pilen og velg **Document - Template**.
3. Dobbeltklikk på malen *Ordrebekreftelse* og klikk **Rediger** for å åpne den i Microsoft Word.
4. Lagre dokumentet med et nytt navn på et lett tilgjengelig sted.
5. [Legg til maldokumentet][1].
6. Gi dokumentet et logisk navn, for eksempel *Ordrebekreftelse – Gruppert*.
7. Merk av for **Tilbudsdokumenttype** for å gjøre det tilgjengelig for tilbud i SuperOffice CRM.
8. Velg **Mal for ordrebekreftelser**.

### Koble maldokumentet til en salgstype

1. I skjermbildet **Lister**, dobbeltklikk **Sale - Type, Stages, Quote**.
2. I oversikten **Forekomster**, dobbeltklikk en salgstype for å åpne dialogboksen **Rediger forekomst**.
3. Gå til fanen **Standardverdier**, åpne listen **Tilbudsformat** og velg din nye mal.
4. Klikk **OK** for å lagre endringene dine.

## Endre malen

I denne delen vil du lære hvordan du endrer maldokumentet ved å sette inn felt, legge til produktbilder, gruppere produkter og velge sorteringsrekkefølge.

### Sett inn felt i Word

1. Åpne maldokumentet fra listen *Document - Template**.

1. **Kopier** et eksisterende felt fra malen. Sørg for å kopiere hele feltet, inkludert «».

1. **Lim inn** feltet i malen etter tittelen ("Detaljer").

1. Høyreklikk det innlimte feltet og velg **Rediger felt**. I boksen **Feltnavn** under **Feltegenskaper**, skriv inn *alternativ/navn* (uten «»). Klikk **OK**.

    > [!NOTE]
    > Det er viktig at du skiller mellom store og små bokstaver når du skriver inn feltnavnene.

1. Kopier et eksisterende felt (igjen) og lim det inn under produkttabellen (venstrejustert på samme rad som totalsummen for alternativet).

1. Skriv inn *alternative/numLines* som feltnavn og klikk **OK**.

1. Skriv inn etiketten *Linjer:* til venstre for numLines-feltet.

1. Sett inn en ny kolonne med tittelen "Bilde" (`Image:line/quoteLineThumbnail`.)

1. Malen din skal nå se slik ut:

    ![Ordrebekreftelse med nye felt -screenshot][img1]

1. Lagre maldokumentet, men lukk det ikke.

### Vis ordrebekreftelsen i SuperOffice CRM (valgfritt)

For å sikre at endringene dine reflekteres korrekt, følg disse trinnene for å se ordrebekreftelsen:

1. **Åpne et salg** av samme type som din mal er koblet til.
2. Gå til fanen **Tilbud** innenfor salget og klikk **Åpne**.
3. Klikk **Registrer ordre** hvis du ikke har gjort det allerede.
4. I dialogboksen **Rediger tilbud**, klikk **Vis bekreftelse**. Ordrebekreftelsen åpnes som en PDF-fil.
5. Verifiser ordrebekreftelsen:
    * Sørg for at alt innhold i tabellene vises korrekt, uten at tall deles over to linjer.
    * Sjekk at ingen feltnavn vises i dokumentet; hvis de gjør det, kan du ha brukt feil feltnavn.
    * Bekreft at alle innsatte felter er tilstede. Manglende felter kan indikere at de nødvendige dataene ikke er tilgjengelige i tilbudet eller produktet.
6. Gjør nødvendige justeringer i malen og lagre den.
7. Gå gjennom ordrebekreftelsen igjen for å sikre at alle endringer vises korrekt.

### Angi sorteringsrekkefølge

1. Sett inn **OrderBy**-feltet i maldokumentet.

    `«TableStart:alternative»«OrderBy:name»`

Produktene vil nå bli sortert etter produktnavn innen hvert alternativ.
Etter å ha definert grupperingsområdet, vil produktene også bli sortert innen hver gruppe.

### Angi grupperingsområde og nøkkel

1. Sett inn `«TableStart:group»` før TableStart:linje.
1. Sett inn `«TableEnd:group»` etter TableEnd:linje.
1. Sett inn `«GroupBy:productFamilyKey»` hvor som helst i dokumentet for å definere grupperingsnøkkelen.

### Legg til gruppespesifikke felt

1. Flytt tabellen med totalsummen for alternativet (inkludert total antall linjer) ned noen linjer, slik at du har plass til å sette inn gruppefeltene mellom TableStart:group og TableEnd:group.

1. Mellom tittelen og tabellen som inneholder produktene, sett inn `«group/groupField»`. Gi feltet en overskriftsstil.

    Dette er tittelen på gruppen (navnet på feltet som produktene er gruppert etter).

1. Nederst i kolonnen med priser, sett inn `«group/sumtotalPrice»`.

    Dette er totalsummen for hele gruppen.

1. I cellen til venstre for totalsummen for hele gruppen, sett inn `«group/groupField»`. Skriv inn etiketten *Sum* til venstre for feltet.

### Lagre og verifiser

1. Malen din skal nå se slik ut:

    ![Ordrebekreftelse resultat -screenshot][img2]

1. Lagre maldokumentet og verifiser som beskrevet ovenfor.

## Relaterte emner

* [Lag et maldokument][2]
* [Malvariabelreferanse][3]

<!-- Referenced links -->
[1]: link-template.md
[2]: ../learn/create.md
[3]: ../variables/index.md
[4]: ../../../quote/learn/admin/product/configure.md
[5]: ../../../sale/learn/create.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/document/tutorial-insert-fields.png
[img2]: ../../../../media/loc/en/document/tutorial-grouped.png
