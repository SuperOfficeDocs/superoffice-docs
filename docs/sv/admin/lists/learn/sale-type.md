---
uid: help-sv-sale-add-type
title: Lägg till försäljningstyp
description: Lägg till försäljningstyp
author: SuperOffice RnD
date: 06.29.2022
keywords: försäljningstyp
topic: howto
language: sv
---

# Lägg till försäljningstyp

[!include[Must be admin](../../../learn/includes/req-admin.md)]

[!include[Note difference](includes/different-edit-list-item-dialog.md)]

> [!NOTE]
> En offert hör till en försäljning och alla försäljningar har en försäljningstyp. I varje försäljningstyp kan du definiera många av egenskaperna för offerter, bland annat bilagor, inställningar för godkännande, användning av alternativ samt mallar.

[!include[Edit list item](includes/edit-list-item.md)] när posterna är försäljningstyper:

1. Skriv in namnet på posten i fältet **Namn**.

    [!include[Mandatory](includes/note-mandatory-field.md)]

2. Välj eventuellt önskad kategori för försäljningstypen i listrutan **Kategori för försäljningstyp**.

    > [!TIP]
    > Du kan skapa nya alternativ vid sidan om de fördefinierade genom att [lägga till poster][2] i listan **Försäljning – Kategori (för försäljningstyp)** under Inställningar och underhåll.

3. I fältet **Beräknad tid för den här försäljningstypen** anger du varaktighet för försäljningstypen (antal veckor, dagar eller månader). När du skapar en ny försäljning med den här försäljningstypen fastställs försäljningsdatumet utifrån den tid du har angett här (dagens datum + beräknad tid).

4. Skriv in en beskrivning av försäljningstypen längst ned i dialogrutan.

5. Ange information på flikarna **Faser**, **Bilaga**, **Standardvärden** och **Godkännande**. Detta beskrivs nedan.

    > [!NOTE]
    > Flikarna **Bilaga**, **Standardvärden** och **Godkännande** är bara relevanta om du har Sales Quote Management-licensen.

6. [!include[Save or cancel](includes/save-or-cancel.md)]

## Fliken Faser

På fliken **Faser** gör du följande:

1. I listan **Aktiva faser för denna försäljningstyp** markerar du de faser du vill ha med i försäljningstypen. Det här steget är valfritt, men om du vill koppla försäljningstypen till en säljguide måste du markera minst två faser.

    [Så skapar du en fas][3].

2. Markera **Denna försäljningstyp har en anknuten guide** om du vill att alla försäljningar med den här försäljningstypen ska följa en [säljguide][5].

3. Välj eventuellt **Föreslå automatisk flytt av försäljningen till nästa fas**.

    När alla händelser och dokument i en fas har slutförts tillfrågas du om du vill gå till nästa fas.

4. Markera **Den här försäljningstypen har intressenter** om du vill att det ska vara möjligt att koppla [intressenter][4] till försäljningar av den här typen.

## Fliken Bilaga

På fliken **Bilaga** kan du lägga till dokument som ska skickas till kunden tillsammans med en offert. Det kan vara exempelvis produktblad, broschyrer och liknande.

> [!NOTE]
> Dokumenten måste först läggas till som dokumentmallar i SuperOffice.

### Lägg till offertbilaga

1. Klicka på **Lägg till**.
2. [Sök efter det eller de dokument du vill lägga till][1] i fönstret Sök.
3. Välj ett eller flera dokument och klicka på **OK**. Dokumenten visas på fliken **Bilaga**.
4. Markera de dokument du vill ta med i kolumnen **Inkludera**.

När du skapar en offert med den här försäljningstypen läggs de markerade dokumenten till som bilagor i offerten. De läggs dock inte till på detaljkortet **Aktiviteter** i försäljningen.

## Standardvärden

Inställningar för offerter med den här försäljningstypen:

* **Tillåt användning av alternativ i offerter**: Markera det här alternativet om användarna ska kunna lägga till flera alternativ i en offert.
* **Antal dagar en offert är giltig**: Ange hur många dagar en offert ska vara giltig. Det här värdet kan ändras när offerten skickas.
* **Mall för offertformat**: Markera mallen som du vill använda för offerten.
* **Bekräftelsedokument**: Markera mallen som du vill använda för bekräftelsen.

## Godkännande

Här kan du välja om offerten måste godkännas ifall den totala rabatten överstiger ett visst tröskelvärde eller de totala vinsterna understiger ett visst tröskelvärde:

* Inget godkännande krävs. Inga gränser. Offerten behöver inte godkännas.
* **Totalrabatten överskrider gränsen**. Ange ett procentvärde.
* **Totalvinsten underskrider gränsen**. Ange ett procentvärde.

## Relateret indhold

* [Offertmallar][6]

<!-- Referenced links -->
[2]: adding-items.md
[3]: ../../../sale/learn/screen/sale-stage.md
[4]: ../../../sale/learn/stakeholders/index.md
[5]: ../../../sale/learn/screen/sales-guide-admin.md
[1]: ../../../search-options/learn/search-criteria.md
[6]: ../../../document/templates/learn/quote-templates.md

<!-- Referenced images -->
