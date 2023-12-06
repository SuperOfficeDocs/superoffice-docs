---
uid: help-sv-document-update
title: Redigera dokument
description: Redigera dokument
author: SuperOffice RnD
so.date: 12.06.2023
keywords: dokument
so.topic: howto
language: sv
---

# Redigera dokument

Redigering av dokument innefattar:

* Redigera dokumentegenskaperna i fönstret Dokument.
* Redigera själva dokumentfilen i det program där dokumentet skapades.

Du kan öppna ett dokument i [redigeringsläge eller läsläge][1]. När du öppnar dokumentet i redigeringsläge, är det bara du som kan redigera det. Andra användare kan öppna dokumentet i läsläge.

Om ditt företag använder ett dokumentbibliotek som SharePoint kan flera personer redigera ett dokument samtidigt.

> [!NOTE]
> Den här funktionen kräver en licens.

Följ anvisningarna nedan beroende på hur dokument hanteras i din SuperOffice-installation:

## Hur vet jag om jag använder SharePoint, SuperOffice WebTools eller inte?

[!include[How to check document library](includes/webtools-or-sharepoint.md)]

## Redigera dokumentegenskaper i fönstret Dokument

Om du vill ändra dokumentegenskaper, till exempel vilket projekt dokumentet är kopplat till, använder du fönstret Dokument:

1. [Markera dokumentet][2].
2. Högerklicka och välj **Dokument**. Om du dubbelklickar på dokumentet öppnas det direkt i det program som dokumentet skapades i.
3. [Gör de ändringar som behövs][3].
4. Klicka på **Spara**-knappen.

## Redigera innehåll i dokument med hjälp av SharePoint-dokument

1. [Dubbelklicka på dokumentet][2]. Dokumentet öppnas i en ny flik med online-textredigeringsprogrammet (Office Online).

    > [!NOTE]
    > Om du vill använda ditt desktop-redigeringsprogram kan du välja **Öppna i Desktop-appen** från Office Online.

2. Redigera dokumentet.

3. Stäng fliken eller din desktop-app. Dokumentet sparas automatiskt till SharePoint

## Redigera innehåll i dokument – utan SuperOffice WebTools

> [!NOTE]
> Den här proceduren beskriver hur du skapar dokument om du använder ett desktop-program för textredigering. Den faktiska processen kan skilja sig något om du använder ett online-baserat textredigeringsverktyg (som Microsoft Office Online) och ett dokumentbibliotek (som SharePoint).

1. [Dubbelklicka på dokumentet][2].
2. Klicka på **Öppna** i dialogrutan **Dokument**.
3. Om en dialogruta öppnas klickar du på **Redigera**.
4. I dialogrutan Ladda ner fil väljer du något av följande alternativ:
    * **Aktivt**: När du väljer alternativet för att öppna öppnas dokumentet i ordbehandlingsprogrammet. Skriv in önskat innehåll i dokumentet och välj **Arkiv** > **Spara som** och bläddra till den mapp där du vill spara det på datorn.
    * **Spara**: När du klickar på alternativet för att spara visas dialogrutan **Spara som**. Ange var i datorn du vill spara filen och spara den. Öppna sedan dokumentet, skriv innehåll och spara det.
5. Stäng ordbehandlingsprogrammet.
6. Gå till dialogrutan **Dokument**.

    > [!NOTE]
    > Om alternativet **Slutfört** är markerat i dialogrutan **Dokument** är uppladdningsalternativen inaktiverade. Ta i så fall bort markeringen för **Slutfört**.

7. Klicka på länken för att ladda upp dokumentet eller dra och släpp dokumentet från Utforskaren till dialogrutan **Dokument**.

    ![Skapa ett nytt dokument -screenshot][img1]

8. Stäng dialogrutan **Dokument** genom att klicka på **Spara**. Dokumentet checkas in och statusen ändras till **Slutfört**.

## Redigera innehåll i dokument – med SuperOffice WebTools

1. [Dubbelklicka på dokumentet][2].
2. Om en dialogruta öppnas klickar du på **Redigera**.
3. Spara dokumentet och stäng ordbehandlingsprogrammet.
4. I dialogrutan som öppnas klickar du på **Ja** om du är klar med redigeringen av dokumentet. Klicka på **Nej** för att behålla dokumentet utcheckat.

    Den här dialogrutan visas bara om det här alternativet har aktiverats i SuperOffice WebTools.

5. Dokumentet checkas in och statusen ändras till **Slutfört**.

### <a id="allow" />Webbläsarsäkerhetsfråga vid öppning av filer

När du får tillgång till och redigerar ett dokument, fil eller e-post i SuperOffice, uppmanar din webbläsare dig med en *säkerhetsfråga* angående filnedladdningen.

* För att öppna filen måste du välja knappen **Öppna**/**Tillåt**.
* Välj **Alltid tillåt** för att hoppa över frågan nästa gång.

Dialogen ser något annorlunda ut i Chrome, Edge, Firefox och Safari.

**Chrome:** Välj **Öppna URL:SuperOffice-Extensions**.

![Chrome: Öppna URL:SuperOffice-Extensions -screenshot][img5]

**Edge:** Välj **Öppna**.

![Edge: Öppna -screenshot][img2]

**Firefox:** Välj **Öppna länk**.

![Firefox: Öppna länk -screenshot][img3]

**Safari:** Välj **Alltid tillåt** eller **Tillåt**.

![Safari: Alltid tillåt eller Tillåt -screenshot][img4]

## Felsökning

Om du dubbelklickar på ett dokument och ingenting händer, kan du testa att högerklicka på det och välja **Dokument**. Detta öppnar dialogrutan **Dokument**. Klicka på **Öppna** och se om dokumentet öppnas nu.

<!-- Referenced links -->
[1]: lock.md
[2]: open.md
[3]: screen/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/document/upload.png
[img2]: ../../../media/loc/en/webtools/webtools-edge-security-question.png
[img3]: ../../../media/loc/en/webtools/webtools-firefox-security-question.png
[img4]: ../../../media/loc/en/webtools/webtools-safari-security-question.png
[img5]: ../../../media/loc/en/webtools/webtools-chrome-security-question.png
