---
uid: help-sv-document-create
title: Skapa ett nytt dokument
description: Skapa ett nytt dokument direkt i SuperOffice CRM eller ladda upp befintliga dokument så att du och dina kollegor alltid har tillgång till de senaste dokumenten och versionerna. Den här guiden visar hur du gör båda.
keywords: skapa dokument, ladda upp dokument, online-textredigering, dokument, SharePoint
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: sv
redirect_from:
  - /sv/document/learn/upload
  - /sv/document/learn/screen/index
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
    > Om alternativet **Slutfört** är markerat i dialogrutan Dokument är uppladdningsalternativen inaktiverade. Ta i så fall bort markeringen för **Slutfört**.

8. Klicka på länken för att ladda upp dokumentet eller dra och släpp dokumentet från Utforskaren till dialogrutan **Dokument**.

9. Stäng dialogrutan **Dokument** genom att klicka på **Spara**.

***

## <a id="fields"></a>Hur man anger information

> [!NOTE]
> Många fält har en lista med fördefinierade värden att välja från. Klicka på <i class="ph ph-caret-down" aria-label="Chevron"></i> för att expandera listan. Välj sedan ett värde för det fältet. Alternativt kan du börja skriva i fältet för att söka efter ett specifikt värde, till exempel ett företagsnamn.

![Skapa dokument från mall (ny) -screenshot][img4]

**Steg:**

1. Välj en [dokumentmall][5]. Välj ett språk för mallen. Det här fältet är endast tillgängligt om den valda mallen innehåller översatta versioner.

1. Välj eventuellt ett företag eller en kontakt som dokumentet gäller.

1. Välj eventuellt ett projekt och/eller en försäljning för att koppla det till dokumentet. Du kan välja vilket projekt/försäljning som helst, oavsett vilket företag du valde tidigare.

1. Ange en dokumenttitel i **Ämne**-fältet. Denna text visas i sektionsflikar och i andra dokumentlistor.

1. Dagens **datum** är standardinställt. Ändra eventuellt skapelsedatumet (klicka för att öppna datumväljaren).

    > [!NOTE]
    > Du kan inte ändra detta datum efter att du klickat på **Skapa**-knappen (fältet blir skrivskyddat).

1. Ange referenser:

    * **Vår ref:** Ange din egen referens. Standardposten för varje mall är definierad i Inställningar och underhåll, men du kan också redigera innehållet i detta fält.
    * **Er ref:** Ange mottagarens referens från deras kommunikation.

### Andra inställningar (valfritt)

* I fliken **Detaljer** anger du en beskrivning av dokumentet (eller nyckelord) för att underlätta fritekstsökning.

* I fliken **Länkar** klickar du på **Lägg till länk** för att [koppla dokumentet till andra aktiviteter][9].

* I fliken **Mer** anger du eventuella [användardefinierade fält][10] som är konfigurerade i Inställningar och underhåll.

## <a id="upload"></a>Ladda upp dokument

1. Klicka på **Nytt** > **Dokument** på toppraden.

2. Dra och släpp dokument från Utforskaren till dialogrutan **Dokument**.

3. (valfritt): Markera kryssrutan i sidfoten för att ange att dokumentet är slutfört.

4. [Ange den information som behövs i fälten](#fields).

5. Klicka på **Skapa** för att upprätta det nya dokumentet i SuperOffice CRM. Dokumentet läggs till på detaljkortet **Aktiviteter**.

## Relaterat innehåll

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
[7]: ../../../../integrations/webtools/install.md
[8]: ../../../../integrations/mail-link/archive.md
[9]: ../../learn/basics/links.md
[10]: ../../custom-objects/learn/udef.md

<!-- Referenced images -->
[img4]: ../../../media/loc/en/document/create-document.png
