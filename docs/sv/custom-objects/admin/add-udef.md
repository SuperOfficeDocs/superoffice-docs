---
uid: help-sv-udef-add
title: Lägga till fält
description: Lägga till fält
author: Bergfrid Dias
so.date: 01.16.2024
keywords: udef, användardefinierade, anpassa fält
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: sv
---

# Lägg till användardefinierat fält

Den här filmen visar hur du skapar egna extrafält i SuperOffice CRM (filmens längd: 2:51):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/SpeZVxpxeMM]

## Steg

1. [!include[Go to fields and select tab](../includes/goto-fields.md)]

1. Klicka på knappen **Lägg till** under listan **Fält**.

1. Skriv in namnet i fältet **Namn**.

1. I listrutan **Typ** väljer du vilken [typ av fält][6] du vill lägga till (till exempel nummer, text eller datum).

1. I fältet **Standardvärde** anger du det värde som ska infogas som standardvärde i fältet.

1. I fältet **Hjälptext** skriver du en kort beskrivning som visas när muspekaren hålls över fältet. Det kan vara en beskrivning med information till de användare som kommer att använda fältet.

1. Fältet **Program-ID** innehåller ett standard-ID för fältet. Program-ID:t kan åsidosättas av dina samarbetspartner så att anslutningen till partnerprogrammen fungerar bättre. I stället för att ändra sin kod kan de skriva in ett mer logiskt namn eller ett specifikt ID för ett användardefinierat fält (UDEF).

1. Markera alternativet **Obligatoriskt** om du vill att det ska vara obligatoriskt att fylla i fältet.

    > [!NOTE]
    > Detta gäller inte fälttypen **Kryssruta**.

1. Markera **Dölj ledtext** om du inte vill att fältets namn ska visas.

1. Markera **Endast läsbart** om du inte vill att fältet ska kunna ändras.

    > [!NOTE]
    > Du kan inte markera **Endast läsbart** om du har markerat alternativet **Obligatoriskt**. Dessa alternativ utesluter varandra.

1. Markera **Indexerat** om du vill att fältet ska vara sökbart.

1. När du har angett alla inställningar klickar du på **Spara**. Dialogrutan stängs och det nya fältet visas i listan **Fält** och i rutnätet.

    > [!TIP]
    > Längst ned till höger i dialogrutan **Fält** finns **Mallvariabelnamnet** följt av en kod (ID), som kan användas för att återanvända informationen du anger i det här fältet, till exempel som [mallvariabler][2] i dokument och e-postmeddelanden.

1. [Justera fältets position][3].

1. Klicka på **Publicera** om du vill att fältet ska vara tillgängligt för SuperOffice CRM-användarna. Opublicerade fält ![ikon][img1] och fält med opublicerade ändringar ![ikon][img2] visas i fetstil i listan **Fält**.

## Varför är det en bra idé att indexera?

Om du väljer **Indexerat** går det snabbare att söka i fälten med **sökfunktionen**. Icke-indexerade fält är också sökbara, men sökningen tar längre tid. Du bör bara indexera fält som genomsöks ofta och innehåller data som används ofta.

## Felsökning

### Jag kan inte skapa ett nytt fält

Om du inte kan skapa ett nytt fält kan det bero på att du redan har nått det [maximala antalet tillåtna fält][1] av den aktuella typen. Du måste då ta bort ett befintligt fält innan du kan lägga till ett nytt.

Fyra fält av varje typ (Kort text, Lång text, Nummer och Decimal) är sökbara. Om du till exempel inte markerar några fält som sökbara kan du bara lägga till sex decimalfält.

## Relaterade ämnen

* [Placera fält][3]
* [Redigera fält][4]
* [Redigera tabbordning för fält][5]
* [Maximalt antal fält][1]
* [Skärmdesigner][7]

<!-- Referenced links -->
[1]: limitations.md
[2]: ../../document/learn/template-variables.md
[3]: move.md
[4]: edit.md
[5]: change-tab-order.md
[6]: index.md#field-types
[7]: ../../ui/screen-designer/learn/index.md

<!-- Referenced links -->
[img1]: ../../../media/icons/admin/fields-unpublish-new.png
[img2]: ../../../media/icons/admin/fields-unpublish-changed.png
