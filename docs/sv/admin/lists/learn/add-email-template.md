---
uid: help-sv-add-email-template
title: Lägg till e-postmall
description: Lägg till e-postmall
keywords: e-postmall
author: SuperOffice RnD
date: 02.25.2025
content_type: howto
audience: settings
audience_tooltip: Inställningar och underhåll
language: sv
---

# Lägg till en e-postmall

E-postmallar kan användas när du skapar nya e-postmeddelanden i SuperOffice-inkorgen och när du skickar offerter, orderbekräftelser och integritetsbekräftelser.

Mallarna visas som objekt i listan **E-post – Mall** och du kan lägga till nya mallar i SuperOffice CRM genom att lägga in dem som poster i listan.

[!include[Edit list item](includes/edit-list-item.md)] när posterna är e-postmallar:

1. Skriv in ett namn på posten i fältet **Mallnamn**.

2. I fältet **Malltyp** väljer du typen av mall som du skapar. Välj **Normal** om du vill att mallen ska vara tillgänglig i **Inkorg**. Du kan också göra mallen tillgänglig som offertmall, [orderbekräftelsemall][3] eller [integritetsbekräftelsemall][4].

3. Välj eventuellt var du vill spara dokumentmallen i listan **Spara mallen i**.

4. Du har nu tre alternativ:

    * **Skapa en ny e-postmall**
    * **Kopiera en befintlig e-postmall**.
        1. Klicka på listan **Kopiera mall**.
        2. Välj önskad mall i listan.
    * **Ladda upp en ny e-postmall från disk (.md/.md)**
        1. Klicka på **Ladda upp**.
        2. Klicka på **Ladda upp fil** i dialogrutan **Ladda upp fil**.
        3. Välj önskad fil och klicka på **Öppna**. Filnamnet visas i dialogrutan **Redigera post**.

5. Klicka på **Spara** i dialogrutan **Redigera post**. Dialogrutan uppdateras.

6. Valfritt: Redigera mallnamnet om det behövs.

7. Klicka på **Redigera** om du vill redigera själva mallfilen. Om du har skapat en ny e-postmall lägger du till innehåll i mallen.

8. Ange önskad information på flikarna **Detaljer** och **Språk**.

9. Klicka på **Spara**. Mallen läggs nu till som en egen post i listan **Poster**. Upprepa proceduren om du vill lägga till fler mallar.

## Fliken Detaljer

Ange följande information på fliken **Detaljer**:

1. (valfritt) Redigera namnet på mallen i fältet **Namn**. Du kan också [lägga till mallnamnet på andra språk][1] genom att klicka på <i class="ph ph-translate" aria-label="Translate"></i>.

2. Ange e-postmeddelandets rubrik i fältet **Rubrik**. Du kan också [lägga till rubriken på andra språk][1] genom att klicka på <i class="ph ph-translate" aria-label="Translate"></i>.

3. Välj **Använd signatur i ny e-post** om du vill lägga till din signatur i nya e-postmeddelanden. Om du inte har en personlig signatur används systemsignaturen.

4. Välj **Visa e-postdialogrutan** om du vill visa dialogrutan **Ny e-post** när du skapar ett nytt e-postmeddelande baserat på den här mallen. I den här dialogrutan kan du ange uppgifter som företag, kontakt och projekt vilket behövs om e-postmallen innehåller mallvariabler.

5. Skriv eventuellt en beskrivning av mallen i fältet **Beskrivning**.

6. I fältet **Riktning** anger du om mallen ska vara utgående eller inkommande genom att klicka på <i class="ph ph-caret-down" aria-label="Chevron"></i> och välja i listrutan. Välj **Utgående** om du vill att mallen ska vara tillgänglig i **Inkorg**.

7. Gå till fältet **Syfte**, klicka på <i class="ph ph-caret-down" aria-label="Chevron"></i> och välj ett av de fördefinierade alternativen i listrutan. De här posterna används vid statusövervakning (kräver licens för [Sales Intelligence][5]).

    > [!TIP]
    > Du kan skapa nya alternativ utöver de fördefinierade genom att lägga till poster i listan **Händelse – Syfte** under Inställningar och underhåll.

8. I fältet **Dokument sparat i** kan du välja att spara dokumentet på en annan plats än standardalternativet.

9. Ange standardinställningen för fältet **Vår referens** med hjälp av [mallvariablerna][2], till exempel *auth* för avsändarens för- och efternamn.

> [!NOTE]
> Du kan öppna mallen för redigering direkt från dialogrutan **Redigera post** genom att klicka på **Redigera**-knappen. Endast htm/html-filer kan redigeras direkt i den här redigeraren. Filtypen visas i fältet **Filnamn** på fliken **Detaljer**. Klicka på **Hämta** om du vill hämta andra filtyper och redigera dem i det aktuella programmet.

## Fliken Språk

Här kan du lägga till översatta versioner av dokumentmallen.

1. Klicka på **Lägg till**.
2. Välj önskat språk i listan **Lägg till språk** i dialogrutan **Redigera post**.
3. Lägg till den översatta dokumentmallen enligt beskrivningen ovan.
4. Klicka på **Lägg till**. Språket visas på fliken **Språk**.
5. Upprepa stegen ovan om du vill lägga till fler språk.

> [!TIP]
> Klicka på <i class="ph ph-translate" aria-label="Translate"></i> bredvid det relevanta fältet om du vill [lägga till översättningar][1] av mallnamnet och e-postrubriken.

<!-- Referenced links -->
[1]: ../../../globalization-and-localization/learn/translate-fields.md
[2]: ../../../document/templates/learn/template-variables.md
[3]: ../../../sale/admin/sale-type.md
[4]: privacy-source-add.md
[5]: ../../../saint/learn/index.md

<!-- Referenced images -->
