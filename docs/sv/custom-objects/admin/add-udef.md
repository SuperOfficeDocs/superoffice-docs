---
uid: help-sv-udef-add
title: Lägg till användardefinierat fält
description: Lägg till användardefinierat fält
author: Bergfrid Dias
date: 01.29.2024
version: 10
keywords: udef, användardefinierade, anpassa fält
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
---

# Lägg till användardefinierat fält

Den här filmen visar hur du skapar egna extrafält i SuperOffice CRM (filmens längd: 2:51):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/SpeZVxpxeMM]

## Steg

1. [!include[Gå til Fält og välj flik](includes/goto-fields.md)]

1. Klicka på knappen **Lägg till** under listan **Fält**.

1. Ange ett **Namn** och välj en [**Typ**][2] (till exempel nummer, text eller datum).

1. Ställ in eventuella andra [fältegenskaper](#properties), som om fältet är obligatoriskt eller ska indexeras.

1. När du är klar, klicka på **Spara**. Dialogen stängs och det nya fältet visas i **Fält**-listan och i rutnätet.

1. [Valfritt, justera positionen för fältet][3]. Detta kräver en licens för Development Tools!

1. Fortsätt att lägga till fält. Klicka på **Publicera** när du är klar för att göra fältet tillgängligt för SuperOffice-användare. Opublicerade fält ![ikon][img1] och fält med opublicerade ändringar ![ikon][img2] visas i fetstil i listan **Fält**.

## <a id="properties" />Fältegenskaper

| Egenskap | Beskrivning |
|---|---|
| Standardvärde | Värdet som ska infogas som standard i detta fält. |
| Text i inforuta | En kort beskrivning som visas när muspekaren hålls över fältet. Till exempel användningsinformation. |
| Program-ID | Ett standard-ID för detta fält. Formatet är **text:nummer**. Behåll textdelen till bokstäverna a-z eller deras versaler. Kan åsidosättas av SuperOffice-partners. |
| Obligatorisk | Gör det obligatoriskt att fylla i detta fält. Gäller inte för fälttypen *Kryssruta*. |
| Dölj ledtext | Om vald visas inte namnet på fältet. |
| Endast läsbart | Om vald är det inte möjligt att ändra fältet. |
| Indexterat | Om vald blir detta fält sökbart och det går snabbare att söka **Hitta**. Icke-indexerade fält kan också sökas, men det går långsammare. Indexera bara fält som ofta söks och innehåller ofta använda data. |

> [!NOTE]
> Du kan inte markera **Endast läsbart** om du har markerat alternativet **Obligatorisk**. Dessa alternativ utesluter varandra.

## Var visas fälten jag skapar?

* [Fliken Mer (företag)][16]
* [Fliken Mer (kontakt)][17]
* [Fliken Mer (projekt)][13]
* [Fliken Mer (händelser)][14]
* [Fliken Mer (dokument)][15]
* [Fliken Mer (sälj)][19]

> [!TIP]
> Längst ned till höger i dialogrutan **Fält** finns **Mallvariabelnamnet** följt av en kod (ID), som kan användas för att återanvända informationen du anger i det här fältet, till exempel som [mallvariabler][12] i dokument och e-postmeddelanden.

## Felsökning

### Jag kan inte skapa ett nytt fält

Om du inte kan skapa ett nytt fält kan det bero på att du redan har nått det [maximala antalet tillåtna fält][1] av den aktuella typen. Du måste då ta bort ett befintligt fält innan du kan lägga till ett nytt.

Fyra fält av varje typ (Kort text, Lång text, Nummer och Decimal) är sökbara. Om du till exempel inte markerar några fält som sökbara kan du bara lägga till sex decimalfält.

## Relaterat innehåll

* [Placera fält][3]
* [Redigera fält][4]
* [Skärmdesigner][11]

<!-- Referenced links -->
[1]: ../learn/udef.md#limit
[2]: ../learn/udef.md#field-types
[3]: edit-udef-layout.md
[4]: edit-udef.md
[11]: ../../ui/screen-designer/learn/index.md
[12]: ../../document/learn/template-variables.md
[13]: ../../project/learn/index.md#more-tab
[14]: ../../diary/learn/follow-ups.md#more-tab
[15]: ../../document/learn/screen/index.md
[16]: ../../company/learn/create.md#more-tab
[17]: ../../contact/learn/create.md#more-tab
[19]: ../../sale/learn/index.md

<!-- Referenced links -->
[img1]: ../../../media/icons/admin/fields-unpublish-new.png
[img2]: ../../../media/icons/admin/fields-unpublish-changed.png
