---
uid: help-sv-editor
title: Dra och släpp-redigerare
description: Dra och släpp-redigerare
author: SuperOffice RnD
so.date: 02.20.2023
keywords: marknadsföring, redigerare, mallvariabel, kopplingsfält
so.topic: concept
language: sv
---

# Dra och släpp-redigerare

![Dra och släpp-redigerare -screenshot][img1]

I steget **Innehåll** kan du redigera meddelandets utseende och innehåll.

* Du kan [infoga text och bilder][1] (och annat innehåll) i kolumnerna och raderna i meddelandet.

* Du kan definiera format/layout (t.ex. teckensnittstyp och storlek, färger och marginaler) på global nivå (hela meddelandet) eller för enskilda avsnitt.

* Du kan enkelt dra och släppa innehåll från sidopanelen (menyer, knappar, SoMe-länkar, html-innehåll, och sidhuvud- och sidfotsblock).

SuperOffice Marknadsföring levereras med många [färdiga meddelandemallar][9] och du kan enkelt kan flytta runt kolumner och avsnitt för att skapa det utseende som du vill ha. Spara innehåll som ofta används som block för att spara tid.

> [!TIP]
> Vanligtvis rekommenderar vi en maximal bredd på 600 pixlar för utskick. Du kan också kontrollera hur utskicket kommer att se ut, t.ex. på smarttelefoner, genom att klicka på **Mobil** (![ikon][img4]) i menyn i det nedre vänstra hörnet. Se även [Anpassa meddelandet för visning på mobila enheter][3].

## Redigera kolumner och block/avsnitt

När du klickar på ett avsnitt (som kolumn, innehållsruta, rad) visas knappar med redigeringsalternativ. I sidopanelen visas redigeringsalternativ för det markerade avsnittet.

En blå ram visas runt det markerade elementet så att du alltid vet vilken del av meddelandet som du redigerar.

Om du klickar på textinnehåll, visas ett redigeringsverktygsfält.

Den globala menyn visas alltid längst ned till vänster i innehållsområdet.

## Redigera text och bilder

[Redigera text][5], [infoga bilder][6] och lägg till annat innehåll genom att klicka på ett avsnitt i meddelandet. Använd verktygsfältet för textredigering och sidopanelen för att redigera det markerade avsnittet.

## Infoga nytt innehåll

I sidopanelen kan du dra och släppa element från avsnittet **Innehåll** till meddelandet. Du kan också klicka på **+** över eller under en rad för att infoga en ny rad.

## Flytta, kopiera och ta bort innehåll

Du kan markera ett avsnitt och använda knapparna för att flytta ( ![ikon][img6] ), duplicera ( ![ikon][img8] ) eller ta bort det ( ![ikon][img7] ).

## Redigera format och layout

Utseendet och egenskaperna för meddelandet (t.ex. teckensnitt och -storlek, färger och marginaler) kan definieras på global nivå (hela meddelandet) eller per avsnitt (se beskrivning ovan).

Om du vill redigera meddelandet på global nivå, väljer du **Brödtext** (![ikon][img12]) i sidopanelen.

> [!TIP]
> Använd standardteckensnitt för bästa läsbarhet oberoende av e-postklient och webbläsare.

## Menyöversikt

Nedan visas en översikt över de olika funktionerna i steget **Innehåll**.

### Sidopanel

Sidopanelen innehåller följande huvudavsnitt:

[!include[Mailing - sections in the side panel](includes/mailing-side-panel.md)]

Se även [Lägg till innehåll][1].

### Global meny

Från den globala menyn kan du förhandsgranska, ångra eller göra om åtgärder, och se hur meddelandet kommer att se ut på en bordsdator eller mobil. Den här menyn visas alltid längst ned till vänster i innehållsområdet.

| Ikon | Namn | Funktion |
|:-:|---|---|
| ![ikon][img11] | Ångra/gör om | Ångrar den senaste åtgärden eller gör om en åtgärd som du har ångrat. |
| ![ikon][img2] | Förhandsgranskning | Öppnar en förhandsgranskning av meddelandet på en bordsdator- eller mobil skärm. |
| ![ikon][img3], ![ikon][img4] | Byt visning för bordsdator eller mobila enheter | Används för att se hur utskicket ser ut på en bordsdator eller smarttelefon. |

### Kontextmeny

När du klickar på ett avsnitt i ett meddelande får du tillgång till olika funktioner för urvalet.

| Ikon | Namn | Funktion |
|:-:|---|---|
| ![ikon][img5] | Lägg till rad | Lägger till en rad under eller över det markerade avsnittet. |
| ![ikon][img6] | Flytta | Klicka och dra för att flytta avsnittet. |
| ![ikon][img7] | Radera | Tar bort avsnittet. |
| ![ikon][img8] | Dubblett | Skapar en kopia av avsnittet. |
| ![ikon][img9] | Spara block | Sparar det markerade avsnittet som ett block. Låter dig återanvända innehåll (som sidhuvuden och sidfötter) i meddelanden. |

## <a id="variables" />Mallvariabler

Om du vill göra meddelandet mer personligt kan du använda platshållare för att infoga kundspecifik information, som kundens förnamn. På så sätt kan du anpassa innehållet efter varje enskild kund.

Dessa platshållare kallas **mallvariabler** i den gamla redigeraren och **kopplingsfält** i dra-och-släpp-redigeraren.

[!include[Note](includes/note-imported-recipients.md)]

Det finns flera olika typer av kopplingsfält:

* Kopplingsfält som är kopplade till kontakter. Exempelvis infogar **\[\[customer.name\]\]**hela namnet på kontaktpersonen.
* Kopplingsfält som är kopplade till företag. Exempelvis infogar **\[\[company.name\]\]**namn på företaget som kontaktpersonen tillhör.

### Exempel

I stället för följande text:

"Bästa kund! Vill du veta mer om hur vår produkt kan hjälpa ditt företag att skaffa nya kunder? Vänliga hälsningar från oss på SuperShop."

Du kan skicka denna text:

"Hej Jonas! Vill du veta mer om hur vår produkt kan hjälpa Bilbutiken AB att skaffa nya kunder? Vänliga hälsningar, Karin Nordman på SuperShop."

Den text du anger ser ut så här:

"Hej **\[\[customer.firstname\]\]**! Vill du veta mer om hur vår produkt kan hjälpa **\[\[company.name\]\]** att skaffa nya kunder? Vänliga hälsningar **\[\[company.ourSalesContact.name\]\]**från oss på SuperShop."

## Två olika redigerare

Använder du den nya Dra och släpp-redigeraren eller den tidigare versionen av redigeraren?

I början av 2021 lade SuperOffice till en ny meddelanderedigerare ("Dra och släpp-redigeraren") för att ersätta den gamla ("Redigerare"). Meddelanderedigeraren används när du skapar e-postutskick och formulärsvar. Du kommer fortfarande att kunna använda den gamla meddelanderedigeraren för att redigera meddelanden och mallar som har skapats i den äldre versionen. Alla nya utskick och mallar använder sig av den nya meddelanderedigeraren.

### Redigerare (gammal)

![Redigerare (gammal) -screenshot][img13]

## Vad vill du göra nu?

* [Lägg till innehåll][1]
* [Redigera innehåll][5]
* [Inkludera länkar som du vill kunna spåra][8]
* [Använd kopplingsfält i meddelanden][7]
* [Lägga in bilder i meddelandet][6]
* [Läs om den gamla redigeraren][2]

<!-- Referenced links -->
[1]: add-content.md
[3]: customize-for-mobile.md
[5]: edit-paragraph.md
[6]: insert-images-in-message.md
[7]: add-merge-tag.md
[8]: ../tracked-links/learn/add-tracked-link-to-msg.md
[9]: work-with-messages-and-templates.md
[2]: https://help.superoffice.com/Documentation/Help/EN/CRM/UserHelp/index.htm#t=Mailing%2FHelptopics%2Foldeditor%2FStep_3__Content_-_Formatted_e-mail.htm

<!-- Referenced images -->
[img1]: ../../../media/loc/en/marketing/edit-template.png
[img2]: ../../../media/icons/marketing-and-forms/preview.png
[img3]: ../../../media/icons/marketing-and-forms/desktop.png
[img4]: ../../../media/icons/marketing-and-forms/mobile-2.png
[img5]: ../../../media/icons/marketing-and-forms/add-row.png
[img6]: ../../../media/icons/marketing-and-forms/move-2.png
[img7]: ../../../media/icons/marketing-and-forms/cancel.png
[img8]: ../../../media/icons/marketing-and-forms/copy.jpg
[img9]: ../../../media/icons/marketing-and-forms/save-block.png
[img11]: ../../../media/icons/marketing-and-forms/undo-redo.png
[img12]: ../../../media/icons/marketing-and-forms/side-panel-body-small.png
[img13]: ../../../media/loc/en/marketing/template-edit-overview-old.png
