---
uid: help-sv-add-template
title: Lägg till en mall
description: I den här guiden förklarar vi hur du lägger till en ny dokumentmall i SuperOffice CRM.
author: SuperOffice RnD
so.date: 03.24.2023
keywords: dokument, mall
so.topic: howto
so.user: admin
language: sv
---

# Lägga till en dokumentmall

För att alla i företaget ska använda samma dokument kan du skapa och lägga till egna dokumentmallar för olika filtyper. Använd de tillgängliga mallvariablerna för att anpassa och automatisera inmatningen av kunduppgifter i dina dokument.

Om du skapar nya mallar eller ändrar en standardmall och sparar den med ett nytt filnamn måste du koppla mallarna till SuperOffice CRM så att programmet kan hitta dem när du skriver dokument med SuperOffice CRM. När du har kopplat mallarna kan du enkelt skriva brev, fax och andra dokument du har skapat mallar för med hjälp av [Dokument-funktionen i SuperOffice CRM][5].

Titta på den här filmen eller följ anvisningarna nedan om du vill lägga till en dokumentmall (filmens längd: 2:30):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/FnhcmjP-TgE]

## Steg

> [!TIP]
> Om du vill lägga till nya mallar kan du enkelt kopiera en befintlig dokumentmallfil och redigera den så att den passar dina behov.

Mallarna visas som objekt i listan **Dokument – Mall** och du kopplar en mall till SuperOffice CRM genom att lägga in den som en post i listan.

[!include[Edit list item](includes/edit-list-item.md)] när posterna är dokumentmallar:

1. Skriv in namnet på posten i fältet **Namn**.
2. Välj eventuellt var du vill spara dokumentmallen i listan **Spara mallen i**.
3. Nu har du två alternativ:

    * Ladda upp en ny dokumentmall:

        1. Klicka på **Kopiera en befintlig dokumentmallfil**.
        2. Klicka på listan **Kopiera mall**.
        3. Välj önskad mall i listan.

    * Kopiera en befintlig mall i SuperOffice:

        1. Välj **Ladda upp en ny dokumentmall från disk**.
        2. Klicka på **Ladda upp**.
        3. Klicka på **Ladda upp fil** i dialogrutan **Ladda upp fil**.
        4. Välj önskad fil och klicka på **Öppna**. Filnamnet visas i dialogrutan **Redigera post**.

4. Klicka på **Spara** i dialogrutan **Redigera post**. Dialogrutan uppdateras.
5. Valfritt: Redigera mallnamnet om det behövs, och klicka på **Redigera** för att redigera själva mallen.
6. Ange önskad information på flikarna **Detaljer** och **Språk**.
7. Klicka på **Spara**. Mallen läggs nu till som en egen post i listan **Poster**. Upprepa proceduren om du vill lägga till fler mallar.

## Fliken Detaljer

Ange följande information på fliken **Detaljer**:

1. I fältet **Riktning** anger du om mallen ska vara utgående eller inkommande genom att klicka på ![ikon][img1] pilen och välja ett alternativ i listrutan.

2. I fältet **Dokumenttyp** väljer du **Dokument** eller **Fax** som malltyp.

3. I fältet **Dokument sparat i** kan du välja att spara dokumentet på en annan plats än standardalternativet.

4. Gå till fältet **Syfte**, klicka på ![ikon][img1] och välj ett av de fördefinierade alternativen i listan. De här posterna används vid statusövervakning (kräver licens för [Sales Intelligence][4]).

    > [!TIP]
    >Du kan skapa nya alternativ förutom de fördefinierade genom att lägga till poster i listan **Händelse – Syfte** i Inställningar och underhåll.

5. Lokalt: Markera alternativet **Publicera** om du vill att dokumentmallen ska kunna göras tillgänglig för externa användare i fönstret Dokument.

6. Lokalt: Markera alternativet **Spara i databasen** om du vill att de dokument som du skapar med den här mallen ska sparas i dokumentdatabasen. Om du markerar det här alternativet visas dokumentet på detaljkortet **Aktiviteter**. Om du inte markerar det visas inte dokumentet i SuperOffice CRM när du har skapat det, och du kommer inte åt det via programmet.

7. Markera alternativet **Offertdokumenttyp** om dokumentet ska vara tillgängligt som offertmall eller orderbekräftelsemall. Du väljer offertdokumenttyp i listan nedan.

    [!include[Link to quote template docs](includes/learn-quote-templates.md)]

8. Ange standardinställningen för fältet **Vår ref (standard)** med hjälp av [mallvariablerna][2], till exempel *auth* för avsändarens för- och efternamn.

9. Skriv eventuellt en beskrivning av mallen i fältet **Beskrivning**.

    > [!TIP]
    > Du kan öppna mallen för redigering direkt från dialogrutan **Redigera post** genom att klicka på **Redigera**-knappen.

## Fliken Språk

Här kan du lägga till översatta versioner av dokumentmallen.

1. Klicka på **Lägg till**.
2. Välj önskat språk i listan **Lägg till språk** i dialogrutan **Redigera post**.
3. Lägg till den översatta dokumentmallen enligt beskrivningen ovan.
4. Klicka på **Lägg till**. Språket visas på fliken **Språk**.
5. Upprepa stegen ovan om du vill lägga till fler språk.

## Relaterat

* [Hur laddar jag upp och använder dokumentmallar?][3] – FAQ
* [Ersätta befintlig mall][1]

<!-- Referenced links -->
[2]: ../../../document/learn/template-variables.md
[5]: ../../../document/learn/index.md
[1]: replace-existing-template.md
[4]: ../../../sale/saint/learn/index.md
[3]: https://community.superoffice.com/en/support-faqs/faq/how-do-i-upload-and-use-document-templates-in-superoffice-crm/

<!-- Referenced images -->
[img1]: ../../../../media/icons/arrow-down.png
