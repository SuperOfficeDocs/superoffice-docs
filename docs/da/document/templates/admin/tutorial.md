---
uid: help-da-quote-template-tutorial
title: Tilpas ordrebekræftelsesskabelon
description: Tilpas ordrebekræftelsesskabelon (vejledning)
keywords: dokumentskabelon, dokument, skabelonen, tilbud, ordrebekræftelse
author: Bergfrid Dias
date: 07.31.2024
version: 10
topic: tutorial
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Tilpas ordrebekræftelsesskabelon

I denne vejledning vil vi bruge en ordrebekræftelsesskabelon som grundlag for at lave en ny skabelon.

Vi vil:

* Tilføje navnet på alternativet (taget fra tilbuddet).
* Tilføje antallet af linjer i alternativet.
* Tilføje et miniaturebillede af produktet.
* Sortere produkterne efter produktnavn.
* Gruppere produkterne i skabelondokumentet efter produktfamilie. En produktfamilie kan for eksempel være "hardware", "software" eller "tilbehør".
* Angive en samlet sum for produkterne i hver gruppe, men beholde den samlede sum for alternativet, der allerede findes i skabelondokumentet.

## Forberedelser

### Opret et salg for at teste skabelonen

1. I SuperOffice CRM, [opret et tilbud][5] med forskellige produkter fra forskellige produktfamilier for at teste grupperingsfunktionen.

2. Sørg for, at salget har samme type som den, du vil knytte skabelonen til (senere i denne vejledning).

3. Klik på **Placer ordre** i tilbuddet for at aktivere knappen **Vis bekræftelse**.

### Vælg de felter, der skal vises

1. Sørg for, at de nødvendige produktfelter er synlige i dialogboksen **Konfigurer produkt**.

* Kun felter markeret som synlige i Indstillinger og vedligeholdelse vil vises i skabelonen.

* Se [Konfigurer produkter][4] for mere information om at sætte felt synlighed.

### Kopier skabelonen, der skal ændres

1. I Indstillinger og vedligeholdelse, vælg **Lister** fra Navigatoren.
2. Klik på pilen og vælg **Document - Template**.
3. Dobbeltklik på skabelonen *Ordrebekræftelse* og klik **Rediger** for at åbne den i Microsoft Word.
4. Gem dokumentet med et nyt navn på et let tilgængeligt sted.
5. [Tilføj skabelondokumentet][1].
6. Navngiv dokumentet logisk, for eksempel *Ordrebekræftelse – Grupperet*.
7. Markér **Tilbudsdokumenttype** for at gøre det tilgængeligt for tilbud i SuperOffice CRM.
8. Vælg **Skabelon til ordrebekræftelser**.

### Knyt skabelondokumentet til en salgstype

1. I skærmbilledet **Lister**, dobbeltklik **Sale - Type, Stages, Quote**.
2. I oversigten **Forekomster**, dobbeltklik en salgstype for at åbne dialogboksen **Rediger forekomst**.
3. Gå til fanen **Standardværdier**, åbn listen **Skabelon til tilbudsformat** og vælg din nye skabelon.
4. Klik **OK** for at gemme dine ændringer.

## Rediger skabelonen

I dette afsnit vil du lære, hvordan du ændrer skabelondokumentet ved at indsætte felter, tilføje produktbilleder, gruppere produkter og vælge sorteringsrækkefølge.

### Indsæt felter i Word

1. Åbn skabelondokumentet fra listen **Document - Template**.

1. **Kopier** et eksisterende felt fra skabelonen. Sørg for at kopiere hele feltet, inklusive «».

1. **Indsæt** feltet i skabelonen efter titlen ("Detaljer").

1. Højreklik på det indsatte felt og vælg **Rediger felter**. I boksen **Feltnavn** under **Feltegenskaber**, skriv *alternative/name* (uden «»). Klik **OK**.

    > [!NOTE]
    > Det er vigtigt, at du skelner mellem store og små bogstaver, når du skriver feltnavnene.

1. Kopier et eksisterende felt (igen) og indsæt det under produkttabellen (venstrejusteret på samme række som den samlede sum for alternativet).

1. Indtast *alternative/numLines* som feltnavn og klik **OK**.

1. Indtast etiketten *Linjer:* til venstre for numLines-feltet.

1. Indsæt en ny kolonne med titlen "Billede" (`Image:line/quoteLineThumbnail`.)

1. Din skabelon skal nu se sådan ud:

    ![Ordrebekræftelse med nye felter -screenshot][img1]

1. Gem skabelondokumentet, men luk det ikke.

### Vis ordrebekræftelsen i SuperOffice CRM (valgfrit)

For at sikre, at dine ændringer reflekteres korrekt, følg disse trin for at se ordrebekræftelsen:

1. **Åbn et salg** af samme type, som din skabelon er knyttet til.
2. Gå til fanen **Tilbud** inden for salget og klik **Åbn**.
3. Klik på **Placer ordre**, hvis du ikke allerede har gjort det.
4. I dialogboksen **Rediger tilbud**, klik **Vis bekræftelse**. Ordrebekræftelsen åbnes som en PDF-fil.
5. Bekræft ordrebekræftelsen:
    * Sørg for, at alt indhold i tabellerne vises korrekt, uden at tal deles over to linjer.
    * Kontroller, at der ikke vises feltnavne i dokumentet; hvis de gør, kan du have brugt forkerte feltnavne.
    * Bekræft, at alle indsatte felter er til stede. Manglende felter kan indikere, at de nødvendige data ikke er tilgængelige i tilbuddet eller produktet.
6. Foretag eventuelle nødvendige justeringer i skabelonen og gem den.
7. Gennemgå ordrebekræftelsen igen for at sikre, at alle ændringer vises korrekt.

### Angiv sorteringsrækkefølge

1. Indsæt **OrderBy**-feltet i skabelondokumentet.

    `«TableStart:alternative»«OrderBy:name»`

Produkterne vil nu blive sorteret efter produktnavn inden for hvert alternativ. Efter at have defineret grupperingsområdet, vil produkterne også blive sorteret inden for hver gruppe.

### Angiv grupperingsområde og nøgle

1. Indsæt `«TableStart:group»` før TableStart:line.
1. Indsæt `«TableEnd:group»` efter TableEnd:line.
1. Indsæt `«GroupBy:productFamilyKey»` hvor som helst i dokumentet for at definere grupperingsnøglen.

### Tilføj gruppespecifikke felter

1. Flyt tabellen med den samlede sum for alternativet (inklusive det samlede antal linjer) ned et par linjer, så du har plads til at indsætte gruppefelterne mellem TableStart:group og TableEnd:group.

1. Mellem titlen og tabellen, der indeholder produkterne, indsæt `«group/groupField»`. Giv feltet en overskriftsstil.

    Dette er titlen på gruppen (navnet på feltet, som produkterne er grupperet efter).

1. Nederst i kolonnen med priser, indsæt `«group/sumtotalPrice»`.

    Dette er den samlede sum for hele gruppen.

1. I cellen til venstre for den samlede sum for hele gruppen, indsæt `«group/groupField»`. Indtast etiketten *Sum* til venstre for feltet.

### Gem og bekræft

1. Din skabelon skal nu se sådan ud:

    ![Ordrebekræftelse resultat -screenshot][img2]

1. Gem skabelondokumentet og bekræft som beskrevet ovenfor.

## Relateret indhold

* [Opret et skabelondokument][2]
* [Skabelonvariabelreference][3]

<!-- Referenced links -->
[1]: link-template.md
[2]: ../learn/create.md
[3]: ../variables/index.md
[4]: ../../../quote/learn/admin/product/configure.md
[5]: ../../../sale/learn/create.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/document/tutorial-insert-fields.png
[img2]: ../../../../media/loc/en/document/tutorial-grouped.png
