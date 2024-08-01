---
uid: help-sv-document-create
title: Skapa ett nytt dokument
description: Skapa ett nytt dokument direkt i SuperOffice CRM eller ladda upp befintliga dokument så att du och dina kollegor alltid har tillgång till de senaste dokumenten och versionerna. Den här guiden visar hur du gör båda.
keywords: dokument
author: Bergfrid Dias
date: 08.02.2024
topic: howto
language: sv
audience: person
audience_tooltip: SuperOffice CRM
---

# Skapa nya dokument

> [!TIP]
> Har du redan dokumentet? Se [Ladda upp dokument](#upload).

Följ anvisningarna nedan beroende på hur dokument hanteras i din SuperOffice-installation.

## Hur vet jag om jag använder SharePoint, SuperOffice WebTools eller inte?

[!include[How to check document library](includes/webtools-or-sharepoint.md)]

<!-- markdownlint-disable-file MD051 -->
## Steg

### [Med SuperOffice WebTools](#tab/webtools)

Med SuperOffice CRM kan du logga in från vilken dator som helst via webbläsaren, men då sparas dina dokument på den centrala servern. Nedladdning och uppladdning av dokument hanteras automatiskt av SuperOffice WebTools.

1. Klicka på **Nytt** > **Dokument** på toppraden.

2. [Ange den information som behövs i fälten](#fields).

3. Skapa det nya dokumentet med den valda [dokumentmallen][5] som grund genom att klicka på **Skapa**. Dialogrutan **Dokument** stängs automatiskt och dokumentet öppnas i ditt vanliga ordbehandlingsprogram.

4. Skriv innehåll i dokumentet.

5. Spara dokumentet och stäng ordbehandlingsprogrammet. Dokumentet sparas.

### [Med SharePoint-dokument](#tab/sharepoint)

**Den här funktionen kräver en licens.**

1. Klicka på **Nytt** > **Dokument** på toppraden.

2. [Ange den information som behövs i fälten](#fields).

3. Skapa det nya dokumentet med den valda [dokumentmallen][5] som grund genom att klicka på **Skapa**. Dokumentet skapas i SharePoint och öppnas i en ny flik med online-textredigeringsprogrammet (Office Online).

    Om du vill använda ditt desktop-redigeringsprogram kan du välja **Öppna i Desktop-appen** från Office Online.

4. Skriv in dokumentets innehåll.

5. Stäng fliken eller din desktop-app. Dokumentet sparas automatiskt till SharePoint.

### [Utan SuperOffice WebTools](#tab/no-webtools)

Om du inte har installerat SuperOffice WebTools måste du manuellt ladda ner dokument för att redigera dem. När du är klar måste du ladda upp de redigerade dokumenten till den centrala servern.

> [!NOTE]
> Den här proceduren beskriver hur du skapar dokument om du använder ett desktop-program för textredigering. Den faktiska processen kan skilja sig något om du använder ett online-baserat textredigeringsverktyg (som Microsoft 365) och ett dokumentbibliotek (som SharePoint).

1. Klicka på **Nytt** > **Dokument** på toppraden.

2. [Ange den information som behövs i fälten](#fields).

3. Skapa det nya dokumentet med den valda [dokumentmallen][5] som grund genom att klicka på **Skapa**. Dokumentet skapas på servern.

4. Klicka på **Öppna** och **Redigera**.

5. I dialogrutan **Ladda ner fil** väljer du en av följande knappar:

    * **Aktivt**: När du klickar på **Öppna** öppnas dokumentet i ordbehandlingsprogrammet. Skriv in önskat innehåll i dokumentet och välj **Arkiv** > **Spara som** och bläddra till den mapp där du vill spara det på datorn.

    * **Spara**: När du klickar på **Spara** öppnas dialogrutan **Spara som**. Ange var på datorn filen ska sparas och klicka sedan på **Spara** så börjar hämtningen. Klicka på **Stäng** när hämtningen är klar. Öppna Windows Utforskaren och bläddra fram till dokumentet som du sparade. Öppna dokumentet, skriv innehåll och spara dokumentet.

    > [!NOTE]
    > Ändringar i dokumentet sparas inte automatiskt i SuperOffice. Om du vill ha sådan funktionalitet rekommenderar vi att installera [SuperOffice WebTools][7].

6. Stäng ordbehandlingsprogrammet.

7. Gå till dialogrutan Dokument.

    > [!NOTE]
    > Om alternativet ![ikon][img1] **Slutfört** är markerat i dialogrutan Dokument är uppladdningsalternativen inaktiverade. Ta i så fall bort markeringen för **Slutfört**.

8. Klicka på länken för att ladda upp dokumentet eller dra och släpp dokumentet från Utforskaren till dialogrutan **Dokument**.

    ![Skapa ett nytt dokument -screenshot][img2]

9. Stäng dialogrutan **Dokument** genom att klicka på **Spara**.

***

## <a id="fields" />How to enter information

> [!NOTE]
> Many fields have a list of predefined values you can choose from. Click the arrow ![icon][img5] to expand the list. Then select a value for that field. Alternatively, start typing in the field to search for a specific value, such as a company name.
![Create document from template -screenshot][img3]

1. Choose a [document template][5]. Select a language for the template. This option is only available if the selected template includes translated versions.

1. Optionally, select a company or contact the document pertains to.

1. Optionally, select a project and/or sale to link it to the document. You can choose any project/sale regardless of which company you chose earlier.

1. Enter a document title in the **Subject** field. This text is shown in section tabs and in other lists of document.

1. Today's **date** is set by default. Optionally, change the creation date (click to open the date picker).

    > [!NOTE]
    > You cannot change this date after clicking the **Create** button (the field becomes read-only).
1. Enter references:

    * **Our ref:** Enter your own reference. The default entry for each template is defined in Settings and maintenance, but you can also edit the content of this field.
    * **Your ref:** Enter the addressee's reference from their communication.

### Other settings (optional)

* In the the **Details** tab, enter a description of the document (or keywords) to aid free-text searching.

* In the **Links** tab, click **Add link** to [link the document to other activities][9].

* In the **More** tab, set any [user-defined fields][10] configured in Settings and maintenance.

## <a id="upload" />Ladda upp dokument

1. Klicka på **Nytt** > **Dokument** på toppraden.

2. Dra och släpp dokument från Utforskaren till dialogrutan **Dokument**.

3. (valfritt) Klicka på ![ikon][img4] längst upp till höger för att ange dokumentet som **Slutfört** ![ikon][img1].

4. [Ange den information som behövs i fälten](#fields).

5. Klicka på **Skapa** för att upprätta det nya dokumentet i SuperOffice CRM. Dokumentet läggs till på detaljkortet **Aktiviteter**.

## Relaterade ämnen

* [Redigera dokument][1]
* [Checka in/ut dokument][3]
* [Arkivera ett e-postmeddelande][8]
* [Skicka e-postbilagor från SuperOffice][4]
* [Hantera dokumentmallar under Inställningar och underhåll][6]

<!-- Referenced links -->
[1]: edit.md
[3]: lock.md
[4]: send-as-email.md
[5]: ../templates/learn/index.md
[6]: ../templates/admin/link-template.md
[7]: ../../webtools/learn/install.md
[8]: ../../email/mail-link/learn/archive.md
[9]: ../../diary/learn/linking-documents-to-follow-ups.md
[10]: ../../custom-objects/learn/udef.md

<!-- Referenced images -->
[img1]: ../../../media/icons/followup-completed-small.png
[img4]: ../../../media/icons/followup-not-completed-small.png
[img2]: ../../../media/loc/en/document/upload.png
[img3]: ../../../media/loc/en/document/create-document.png
[img5]: ../../../../common/icons/dropdown-icon.png
