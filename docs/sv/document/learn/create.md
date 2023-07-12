---
uid: help-sv-document-create
title: Skapa ett nytt dokument
description: Skapa ett nytt dokument direkt i SuperOffice CRM eller ladda upp befintliga dokument så att du och dina kollegor alltid har tillgång till de senaste dokumenten och versionerna. Den här guiden visar hur du gör båda.
author: SuperOffice RnD
so.date: 02.10.2023
keywords: dokument
so.topic: howto
language: sv
---

# Skapa nya dokument

> [!TIP]
> Har du redan dokumentet? Se [Ladda upp dokument][1].

Följ anvisningarna nedan beroende på hur dokument hanteras i din SuperOffice-installation:

> [!NOTE]
> Den här funktionen kräver en licens.

## Hur vet jag om jag använder SharePoint, SuperOffice WebTools eller inte?

[!include[How to check document library](includes/webtools-or-sharepoint.md)]

## Skapa ett nytt dokument med SharePoint-dokument

1. Klicka på **Nytt** &gt; **Dokument** på toppraden.

2. [Ange den information som behövs i fälten][2].

3. Skapa det nya dokumentet med den valda dokumentmallen som grund genom att klicka på **Skapa**. Dokumentet skapas i SharePoint och öppnas i en ny flik med online-textredigeringsprogrammet (Office Online).

    > [!NOTE]
    > Om du vill använda ditt desktop-redigeringsprogram kan du välja **Öppna i Desktop-appen** från Office Online.

4. Skriv in dokumentets innehåll.

5. Stäng fliken eller din desktop-app. Dokumentet sparas automatiskt till SharePoint.

## Skapa ett nytt dokument utan SuperOffice WebTools

Om du inte har installerat SuperOffice WebTools måste du manuellt ladda ner dokument för att redigera dem. När du är klar måste du ladda upp de redigerade dokumenten till den centrala servern.

> [!NOTE]
> Den här proceduren beskriver hur du skapar dokument om du använder ett desktop-program för textredigering. Den faktiska processen kan skilja sig något om du använder ett online-baserat textredigeringsverktyg (som Microsoft Office Online) och ett dokumentbibliotek (som SharePoint).

1. Klicka på **Nytt** &gt; **Dokument** på toppraden.

2. [Ange den information som behövs i fälten][2].

3. Skapa det nya dokumentet med den valda dokumentmallen som grund genom att klicka på **Skapa**. Dokumentet skapas på servern.

4. Klicka på **Öppna** och **Redigera**.

5. I dialogrutan **Ladda ner fil** väljer du en av följande knappar:

    * **Aktivt**: När du klickar på **Öppna** öppnas dokumentet i ordbehandlingsprogrammet. Skriv in önskat innehåll i dokumentet och välj **Arkiv** &gt; **Spara som** och bläddra till den mapp där du vill spara det på datorn.

    * **Spara**: När du klickar på **Spara** öppnas dialogrutan **Spara som**. Ange var på datorn filen ska sparas och klicka sedan på **Spara** så börjar hämtningen. Klicka på **Stäng** när hämtningen är klar. Öppna Windows Utforskaren och bläddra fram till dokumentet som du sparade. Öppna dokumentet, skriv innehåll och spara dokumentet.

6. Stäng ordbehandlingsprogrammet.

7. Gå till fönstret Dokument.

    > [!NOTE]
    > Om alternativet ![ikon][img1] **Slutfört** är markerat i fönstret Dokument är uppladdningsalternativen inaktiverade. Ta i så fall bort markeringen för **Slutfört**.

8. Klicka på länken för att ladda upp dokumentet eller dra och släpp dokumentet från Utforskaren till dialogrutan **Dokument**.

    ![Skapa ett nytt dokument -screenshot][img2]

9. Stäng dialogrutan **Dokument** genom att klicka på **Spara**.

## Skapa ett nytt dokument med SuperOffice WebTools

Med SuperOffice CRM kan du logga in från vilken dator som helst via webbläsaren, men då sparas dina dokument på den centrala servern. Nedladdning och uppladdning av dokument hanteras automatiskt av SuperOffice WebTools.

1. Klicka på **Nytt** &gt; **Dokument** på toppraden.

2. [Ange den information som behövs i fälten][2].

3. Skapa det nya dokumentet med den valda dokumentmallen som grund genom att klicka på **Skapa**. Dialogrutan **Dokument** stängs automatiskt och dokumentet öppnas i ditt vanliga ordbehandlingsprogram.

4. Skriv innehåll i dokumentet.

5. Spara dokumentet och stäng ordbehandlingsprogrammet. Dokumentet sparas.

## Relaterade ämnen

* [WebTools][3]
* [Skicka e-postbilagor från SuperOffice][4]
* [Hantera dokumentmallar under Inställningar och underhåll][5]

<!-- Referenced links -->
[1]: upload.md
[2]: screen/index.md
[3]: ../../webtools/learn/index.md
[4]: send-as-email.md
[5]: ../../admin/lists/learn/add-template.md

<!-- Referenced images -->
[img1]: ../../../media/icons/followup-completed-small.png
[img2]: ../../../media/loc/en/document/upload.png
