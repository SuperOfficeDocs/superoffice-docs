---
uid: help-sv-lists
title: Listor
description: Så redigerar du listor
keywords: lista, listor
author: digitaldiina
date: 10.29.2025
version: 10.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
redirect_from: 
  - /sv/admin/lists/learn/index
  - /sv/admin/lists/learn/items
  - /sv/admin/lists/learn/duplicates
language: sv
---

# Listor

SuperOffice CRM innehåller många standardlistor, bland annat kundkategorier, aktivitetstyper, försäljningstyper och många mer. Om du vill ändra standardlistorna så att de överensstämmer med ditt företags jargong och processer beskriver den här guiden hur du redigerar listor.

Beroende på vilken bransch ditt företag verkar i kan du skräddarsy alla listor i systemet så att de avspeglar era affärsprocesser och behov. Du kan skapa nya poster, inaktivera onödiga poster och redigera befintliga poster. Vissa poster ingår som standard i alla listor i SuperOffice CRM.

## Fönstret Listor

Fönstret **Listor** innehåller beskrivningar och definitioner av listorna i SuperOffice CRM. Här kan du anpassa de fördefinierade listorna som medföljer SuperOffice CRM.

> [!TIP]
> Om du snabbt vill gå till en lista klickar du på **Listor** i navigatorn och börjar skriva i sökfältet. Sökresultaten uppdateras samtidigt som du skriver.

Du kan också lägga till egna användardefinierade listor som visas på **Mer**-flikarna i SuperOffice CRM. Du kan ange vad som ska visas på **Mer**-flikarna i fönstret [Fält][10].

Fönstret **Listor** är indelat i följande sektioner:

* Högst upp i fönstret kan du klicka på listrutan och välja bland alla tillgängliga listor i SuperOffice, både fördefinierade och [användardefinierade listor][5].
* Fliken **Poster** innehåller de [poster](#items) som är tillgängliga för den valda listan.
* På fliken **Användargrupper** visas poster [filtrerat på användargrupp][7].
* På fliken **Rubriker** visas [poster per rubrik][1].
* I listan **Synlig för användargrupper** ser du vilken eller vilka grupper den valda posten i listan **Poster** visas för. Du kan till exempel välja att ge användargrupperna Försäljning, Support och Redovisning tillgång till olika händelsetyper.
* Listan **Rubriker** visar de [rubriker][1] som de enskilda posterna visas under. Om en lista är väldigt lång (innehåller ett stort antal poster) kan du använda rubriker för att dela in posterna i logiska grupper. Posterna i listan **Dokument – Mall** har till exempel grupperats under rubrikerna **Brev**, **Fax**, **E-post** och så vidare.

Längst upp till höger finns kryssrutan **Använd gruppering och användargruppfiltrering för den här listan** där du kan ange om listan ska kunna grupperas och filtreras. Det här alternativet är inaktiverat för listor där detta är irrelevant.

Längst ner i fönstret **Listor** finns kryssrutan **Visa borttagna poster och rubriker** som du kan använda för att [ångra borttagningen][9] av poster och rubriker.

## <a id="items"></a>Poster

Till skillnad från själva listorna kan du göra tillägg till, ändra eller ta bort poster i både fördefinierade och användardefinierade listor.

### Dubbletter

Du kan inte skapa två poster med samma namn i samma lista. Detsamma gäller rubriker. Om du försöker skapa ett objekt med samma namn som en befintlig post eller rubrik visas ett meddelande om att det inte är tillåtet. Denna begränsning gäller oavsett om namnet är skrivet med versaler eller gemener.

> [!NOTE]
> Du kan inte lägga till en ny post eller rubrik som har samma namn som en [borttagen post eller rubrik][9].

## Organisera listor

SuperOffice CRM innehåller många standardlistor med ännu fler poster. Om du lägger till egna (användardefinierade) listor och poster är det en bra idé att organisera dina listor. I SuperOffice CRM finns det i huvudsak två sätt att organisera listor:

* **Gruppering:** Använda [rubriker][1] i listor för att kategorisera poster på 2 nivåer. Exempel: Listan **Allmänt – Resurs** kan delas in i två grupper med hjälp av två rubriker: *Utrustning* och *Rum*.

* **Användargruppfiltrering:** Göra poster synliga enbart för de användargrupper som faktiskt använder dem. Exempel: Listan **Dokument – Mall** kan [filtreras][7] så att offertmallar inte är synliga för användargrupper som aldrig skickar offerter.

> [!NOTE]
> Användargrupper och rubriker visas inte för listor i de fall de är irrelevanta.

Under Inställningar och underhåll kan du för de flesta fördefinierade och alla användardefinierade listor ange att de ska grupperas.

## Relaterat innehåll

* [Speciallistor][4]
* [Lägga till användardefinierade listor][5]
* [Lägga till en post][6]
* [Redigera eller bort en post][8]

<!-- Referenced links -->
[1]: headings.md
[4]: specialized-lists.md
[5]: user-defined-lists.md
[6]: add-items.md
[7]: user-group-filtering.md
[8]: update-items.md
[9]: restore.md
[10]: ../../custom-objects/admin/edit-udef-layout.md

<!-- Referenced images -->
