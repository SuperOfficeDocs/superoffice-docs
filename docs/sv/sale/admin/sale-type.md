---
uid: help-sv-sale-add-type
title: Lägg till försäljningstyp
description: Så här lägger du till och hanterar försäljningstyper i SuperOffice CRM. Definiera faser, säljguider och offerter för varje försäljningstyp i Inställningar och underhåll.
keywords: lägg till försäljningstyp, Försäljning - Typ Faser Offert lista, Försäljning - Kategori lista, Offertbilagor, Standardvärden för offert, Offertgodkännande, försäljningstyp, försäljning, offert
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
license: salesessentials
audience: settings
audience_tooltip: Settings and maintenance
language: sv
redirect_from:
  - /sv/admin/lists/learn/sale-type
  - /sv/sale/learn/screen/sales-type-for-stages
index: true
---

# Försäljningstyp

[!include[Must be admin](../../learn/includes/req-admin.md)]

Fältet **Försäljningstyp** i fönstret Försäljning kategoriserar försäljningar och definierar deras arbetsflöden. Dessa typer är fördefinierade i listan **Försäljning - Typ, Faser, Offert**, som du kan hantera i **Inställningar och underhåll** under **Listor**.

Varje försäljning måste ha en försäljningstyp. Dessa kan kopplas till specifika [faser][1] och, valfritt, till [säljguider][4]. Säljguider effektiviserar processen genom att vägleda säljare genom fördefinierade faser, händelser och dokument.

## Lägg till en försäljningstyp

1. Välj <i class="ph ph-list-bullets" aria-hidden="true"></i> **Listor** i navigatorn.

1. Välj **Försäljning - Typ, Faser, Offert** från rullgardinsmenyn. Fliken **Poster** visar alla befintliga försäljningstyper.

1. Klicka på **Lägg till** för att öppna dialogrutan **Redigera listpost**.

    ![Dialogrutan Redigera listpost med inställningar för försäljningstyp -screenshot][img1]

1. Ange ett namn för försäljningstypen i fältet **Namn**. *(Obligatoriskt)*

    Detta namn visas i fältet **Försäljningstyp** på försäljningskortet.

1. Välj önskad kategori för försäljningstypen från listan **Kategori för försäljningstyp**.

    > [!TIP]
    > Du kan skapa nya alternativ i listan **Försäljning - Kategori (för försäljningstyp)**.

1. Ange den typiska försäljningslängden i fältet **Beräknad tid för den här försäljningstypen** (antal veckor, dagar eller månader).

    Detta fastställer standardförsäljningsdatumet vid skapande av en försäljning.

1. På fliken **Faser** väljer du de faser som ska användas för denna försäljningstyp i listan **Faser för denna försäljningstyp**.

    > [!NOTE]
    > För att koppla försäljningstypen till en säljguide måste du välja minst två faser.

1. *(Valfritt)* Markera **Denna försäljningstyp har en anknuten guide** om du vill koppla försäljningstypen till en [säljguide][4].

1. *(Valfritt)* Markera **Föreslå automatisk flytt av försäljningen till nästa fas** om du vill att användarna ska uppmanas att gå vidare när alla aktiviteter för den aktuella fasen har slutförts.

1. *(Valfritt)* Markera **Den här försäljningstypen har intressenter** om du vill tillåta koppling av [intressenter][5] till försäljningar av denna typ. *(Kräver SalesPremium-licens)*

1. Lägg till en beskrivning av försäljningstypen i fältet **Beskrivning**, om det behövs.

1. För offertinställningar, konfigurera fälten i flikarna **Bilaga**, **Standardvärden** och **Godkännande** enligt beskrivningen i [Offertfält förklarade](#quote-fields) nedan. *(Kräver SalesPremium-licens)* Dessa inställningar låter dig anpassa offerter för att matcha företagets processer.

1. Klicka på **Spara** för att tillämpa dina ändringar eller **Avbryt** för att ignorera dem.

1. I listan **Aktiva faser för denna försäljningstyp** markerar du de faser du vill ha med i försäljningstypen. Det här steget är valfritt, men om du vill koppla försäljningstypen till en säljguide måste du markera minst två faser.

## <a id="quote-fields"></a>Offertfält förklarade

En offert hör till en försäljning, och alla försäljningar har en försäljningstyp. I varje försäljningstyp kan du definiera många av egenskaperna för en offert, såsom bilagor, inställningar för godkännande, användning av alternativ och mallar.

<!-- markdownlint-disable MD051 -->
### [Fliken Bilaga](#tab/quote-attachment)

På fliken **Bilaga** kan du lägga till dokument som ska skickas till kunden tillsammans med en offert, till exempel produktblad eller broschyrer.

> [!NOTE]
> Dokumenten måste först läggas till som dokumentmallar i SuperOffice.

#### Lägg till offertbilagor

1. Klicka på **Lägg till**.
1. I dialogrutan **Sök**, [sök efter de dokument du vill lägga till][7].
1. Välj ett eller flera dokument och klicka på **OK**. Dokumenten visas i fliken **Bilaga**.
1. Markera de dokument du vill inkludera i kolumnen **Inkludera**.

När du skapar en offert med denna försäljningstyp, bifogas de markerade dokumenten automatiskt till offerten. De kommer dock inte att visas på detaljkortet **Aktiviteter** i försäljningen.

### [Fliken Standardvärden för offert](#tab/quote-defaults)

På fliken **Standardvärden för offert** kan du konfigurera följande:

* **Tillåt användning av alternativ i offerter** – Markera detta alternativ om du vill att användarna ska kunna skapa flera alternativa förslag i en offert.
* **Antal dagar en offert är giltig** – Ange hur många dagar en offert är giltig. Detta värde kan justeras när offerten skickas.
* **Mall för offertformat** – Välj vilken mall som ska användas för offerten.
* **Bekräftelsedokument** – Välj vilken mall som ska användas för orderbekräftelser.

### [Fliken Godkännande](#tab/quote-approval)

På fliken **Godkännande** kan du ange om en offert kräver godkännande baserat på vissa villkor:

* **Inget godkännande krävs** – Ingen begränsning, offerten kan skickas utan godkännande.
* **Totalrabatt överskrider gränsen** – Ange en procentuell gräns för rabatter som kräver godkännande.
* **Totalvinst understiger gränsen** – Ange en procentuell gräns för vinster som kräver godkännande.

***
<!-- markdownlint-enable MD051 -->

## Redigera eller ta bort en försäljningstyp

1. Följ steg 1–2 i **Lägg till en försäljningstyp** för att komma till listan **Försäljning - Typ, Faser, Offert**.

1. För att redigera:
    * Dubbelklicka på önskad försäljningstyp för att öppna dialogrutan **Redigera listpost**.
    * Uppdatera fälten vid behov och klicka på **Spara**.

1. För att ta bort:
    * Markera försäljningstypen i listan och klicka på **Ta bort**.

    > [!CAUTION]
    > Om du tar bort en försäljningstyp tas även kopplingen till faser och säljguider bort. Kontrollera att den inte används aktivt innan du tar bort den.

## <a id="restore"></a>Återställ en borttagen försäljningstyp

Om en försäljningstyp har tagits bort kan du återställa den från listan **Försäljning - Typ, Faser, Offert**. Observera att återställning inte automatiskt återskapar kopplingar mellan den återställda posten och relaterade försäljningsfaser eller säljguider. Dessa måste återskapas manuellt vid behov.

1. Gå till listan **Försäljning - Typ, Faser, Offert**.

1. Markera **Visa borttagna poster och rubriker** i sidfoten. Borttagna poster visas överstrukna i fliken **Poster**.

1. Dubbelklicka på den borttagna posten du vill återställa. Dialogrutan **Redigera listpost** öppnas.

1. Klicka på **Återställ**.

1. Uppdatera eventuella nödvändiga fält och klicka på **Spara**. Posten är nu aktiv och visas i fliken **Poster**.

## Relaterat innehåll

* [Lägg till en försäljningsfas][1]
* [Skapa en säljguide][2]
* [Redigera en säljguide][3]
* [Offertmallar][6]

<!-- Referenced links -->
[1]: sale-stage.md
[2]: create-sales-guide.md
[3]: edit-sales-guide.md
[4]: ../learn/sales-guides.md
[5]: ../learn/stakeholders/index.md
[6]: ../../document/templates/learn/quote-templates.md
[7]: ../../search-options/learn/search-criteria.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/edit-sale-type.png
