---
uid: help-sv-document-template-link
title: Lägga till en dokumentmall
description: I den här guiden förklarar vi hur du lägger till en ny dokumentmall i SuperOffice CRM.
keywords: dokument, mall, lista
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
redirect_from: /sv/admin/lists/learn/add-template
index: true
---

# Lägga till en dokumentmall

Om du skapar nya mallar eller ändrar en standardmall och sparar den med ett nytt filnamn måste du koppla mallarna till SuperOffice CRM så att programmet kan hitta dem när du skriver dokument med SuperOffice CRM.

Mallarna visas som objekt i listan **Dokument – Mall** och du kopplar en mall till SuperOffice CRM genom att lägga in den som en post i listan.

Titta på den här filmen eller följ anvisningarna nedan om du vill lägga till en dokumentmall:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/FnhcmjP-TgE]

(filmens längd: 2:30)

## Steg

1. I Inställningar och underhåll, klicka på knappen **Listor** i navigatorn (1).

1. Välj fliken **Poster**, klicka på pilen och välj **Dokument – Mall** (2).

1. Klicka på **Lägg till** (3).

    ![Lägg till dokumentmall -screenshot][img3]

1. Skriv in namnet på posten i fältet **Namn** (1).

    ![Redigera post -screenshot ][img2]

1. Välj eventuellt var du vill spara dokumentmallen i listan **Spara mallen i** (2).

1. Nu har du två alternativ:

    * Ladda upp en ny dokumentmall:

        1. Klicka på **Kopiera en befintlig dokumentmallfil**.
        2. Klicka på listan **Kopiera mall**.
        3. Välj önskad mall i listan.

    * Kopiera en befintlig mall i SuperOffice:

        1. Välj **Ladda upp en ny dokumentmall från disk** (3).
        2. Klicka på **Ladda upp**.
        3. Klicka på **Ladda upp fil** i dialogrutan **Ladda upp fil**.
        4. Välj önskad fil och klicka på **Öppna**. Filnamnet visas i dialogrutan **Redigera post**.

1. Klicka på **Spara** i dialogrutan **Redigera post**. Dialogrutan uppdateras.

1. Valfritt: Redigera mallnamnet om det behövs, och klicka på **Redigera** för att redigera själva mallen.

1. Ange önskad information på flikarna **Detaljer** och **Språk**.

1. Klicka på **Spara**. Mallen läggs nu till som en egen post i listan **Poster** och är nu tillgänglig i CRM-klienten:

![New document -screenshot][img4]

![New document dialog -screenshot][img5]

> [!TIP]
> Upprepa proceduren om du vill lägga till fler mallar.

## Fliken Detaljer

Ange följande information på fliken **Detaljer**:

1. I fältet **Riktning** anger du om mallen ska vara utgående eller inkommande genom att klicka på <i class="ph ph-caret-down" aria-label="Chevron"></i> och välja ett alternativ i listrutan.

2. I fältet **Dokumenttyp** väljer du **Dokument** eller **Fax** som malltyp.

3. I fältet **Dokument sparat i** kan du välja att spara dokumentet på en annan plats än standardalternativet.

4. Gå till fältet **Syfte**, klicka på <i class="ph ph-caret-down" aria-label="Chevron"></i> och välj ett av de fördefinierade alternativen i listan. De här posterna används vid statusövervakning (kräver licens för [Sales Intelligence][4]).

    > [!TIP]
    >Du kan skapa nya alternativ förutom de fördefinierade genom att lägga till poster i listan **Händelse – Syfte** i Inställningar och underhåll.

5. Lokalt: Markera alternativet **Publicera** om du vill att dokumentmallen ska kunna göras tillgänglig för externa användare i dialogrutan Dokument.

6. Lokalt: Markera alternativet **Spara i databasen** om du vill att de dokument som du skapar med den här mallen ska sparas i dokumentdatabasen. Om du markerar det här alternativet visas dokumentet på detaljkortet **Aktiviteter**. Om du inte markerar det visas inte dokumentet i SuperOffice CRM när du har skapat det, och du kommer inte åt det via programmet.

7. Markera alternativet **Offertdokumenttyp** om dokumentet ska vara tillgängligt som [offertmall][2] eller orderbekräftelsemall. Du väljer offertdokumenttyp i listan nedan.

    ![Reference list item -screenshot][img8]

8. Ange standardinställningen för fältet **Vår ref (standard)** med hjälp av mallvariablerna, till exempel *auth* för avsändarens för- och efternamn.

9. Skriv eventuellt en beskrivning av mallen i fältet **Beskrivning**.

    > [!TIP]
    > Du kan öppna mallen för redigering direkt från dialogrutan **Redigera post** genom att klicka på **Redigera**-knappen.

## Fliken Språk

Här kan du lägga till översatta versioner av dokumentmallen.

1. Klicka på **Lägg till**.

    ![Lägg till språk -screenshot][img6]

1. Välj önskat språk i listan **Lägg till språk** i dialogrutan **Redigera post**.

1. Lägg till den översatta dokumentmallen enligt beskrivningen ovan.

    ![Översatta dokumentmallen -screenshot][img7]

1. Klicka på **Lägg till**. Språket visas på fliken **Språk**.

1. Upprepa stegen ovan om du vill lägga till fler språk.

## Relaterat

* [Ersätta befintlig mall][1]

<!-- Referenced links -->
[1]: update-template.md
[2]: ../learn/quote-templates.md
[4]: ../../../saint/learn/index.md

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/document/edit-list-item.png
[img3]: ../../../../media/loc/en/document/lists-add.png
[img4]: ../../../../media/loc/en/document/imagedmnmi.png
[img5]: ../../../../media/loc/en/document/image6r9sc.png
[img6]: ../../../../media/loc/en/document/language-add.png
[img7]: ../../../../media/loc/en/document/deutch-document-upload.png
[img8]: ../../../../media/loc/en/document/reference-item.png
