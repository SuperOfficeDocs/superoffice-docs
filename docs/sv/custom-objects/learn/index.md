---
uid: help-sv-custom-objects
title: Egendefinierade objekt och fält
description: Egendefinierade objekt och fält
author: Bergfrid Dias
date: 01.29.2024
version: 10
keywords: egendefinierade objekt, användardefinierade fält, extratabell, extrafält, tilläggsfält, anpassat fält
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: sv
---

# Egendefinierade objekt och fält

Alla företag och organisationer har sina egna krav på den information de behöver registrera angående sina kontakter, försäljning, projekt, avtal och så vidare. Administratörer kan lägga till fält och tabeller i SuperOffice för att anpassa vilken typ av information som kan registreras.

SuperOffice CRM och Service var en gång två separata applikationer med olika möjligheter till utökning. [**Användardefinierade fält**][1] (kallat udefs för kort) hör hemma i SuperOffice CRM, medan [**extra tabeller**][3] (även kallade tredjepartstabeller) och [**extrafält**][2] hör hemma i Service. Begreppet **anpassat fält** inkluderar både användardefinierade fält och extra fält.

## Användning

* Ett bra exempel på ett anpassat fält du kan använda på **Kontakt**-skärmen är ett fält kallat "Nöjd kund", där värdet av fältet är Ja eller Nej. Till exempel kan du skicka dina kontakter ett mail (med länkåtgärder) där de kan ange om de är nöjda med din service. Detta ger dig värdefull insikt i den generella kundnöjdhetsgraden.

* Genom att använda **Sök**-funktionen kan du söka efter informationen du lägger in i anpassade fält och skapa urval. Om du till exempel registrerar förfallodatumet för underhållsavtalet du har med kontakter kan du skapa ett dynamiskt urval som visar alla kontakter vars avtal löper ut om mindre än en månad.

* Du kan återanvända informationen från dessa fält i dokument och e-post som **mallvariabler**. Varje fält du lägger till får sitt eget unika ID (Program-ID), som kan användas i dokument för att slå ihop kontaktspecifik information. Så om du vill skicka ett mail till dina kontakter som säger att deras underhållsavtal snart löper ut, kan du använda mallvariabeln för förfallodatum för att visa rätt förfallodatum för deras avtal i meddelandet.

## Krav

| Anpassning | Licens | Kommentar |
|---|---|---|
| Lägg till/ta bort användardefinierat fält | Ingen | Visas automatiskt på [fliken Mer][12]. Behöver Development Tools för att anpassa placeringen. |
| Anpassa layouten för fliken Mer | Development Tools | |
| Hantera sid 1-fält | Development Tools | |
| Extra fält | Development Tools | |
| Extra tabell | Development Tools | |
| [Skärmdesigner][5] | Development Tools | SuperOffice version 10 och nyare. |
| [Anpassade skärmar][6] | Development Tools, Service | Skapa nya skärmar i Service. |

## Layout (positionering av fält)

UI-anpassning av vilken typ som helst kräver en Development Tools-licens. Eventuella anpassade skärmlayouter (skapade i Skärmdesignern) kan åsidosätta inställningarna för enskilda anpassade fält.

Om du inte har en Development Tools-licens, använd rangordningen av de olika fälten för att sortera dem på fliken **Mer**.

## Relaterat innehåll

* [Brukerdefinerte felt][1]
* [Ekstrafelt][2]
* [Ekstra tabeller][3]

<!-- Referenced links -->
[1]: udef.md
[2]: extra-field.md
[3]: extra-table.md
[5]: ../../customization/screen-designer/admin/index.md
[6]: ../../../en/ui/blogic/custom-screens/index.md
[12]: more-tab.md

<!-- Referenced images -->
