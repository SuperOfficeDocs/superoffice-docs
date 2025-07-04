---
uid: help-sv-document-update
title: Redigera dokument
description: Redigera dokument
keywords: redigera dokument, dokumentegenskaper, dokument
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: sv
redirect_from: /sv/document/learn/delete
---

# Redigera dokument

Redigering av dokument innefattar:

* Redigera dokumentegenskaperna i dialogrutan Dokument.
* Redigera själva dokumentfilen i det program där dokumentet skapades.

Du kan öppna ett dokument i [redigeringsläge eller läsläge][1]. När du öppnar dokumentet i redigeringsläge, är det bara du som kan redigera det. Andra användare kan öppna dokumentet i läsläge. Om ditt företag använder ett dokumentbibliotek som SharePoint kan flera personer redigera ett dokument samtidigt.

## Redigera dokumentegenskaper i dialogrutan Dokument

Om du vill ändra dokumentegenskaper, till exempel vilket projekt dokumentet är kopplat till, använder du dialogrutan Dokument:

1. Markera dokumentet.

2. Högerklicka och välj **Dokument**. Om du dubbelklickar på dokumentet öppnas det direkt i det program som dokumentet skapades i.

3. [Gör de ändringar som behövs][3].

4. Klicka på **Spara**-knappen.

> [!NOTE]
> Du kan inte göra ändringar i slutförda dokument förrän du har inaktiverat deras **Slutfört**-status

## Redigera innehåll

Följ anvisningarna nedan beroende på hur dokument hanteras i din SuperOffice-installation.

<!-- markdownlint-disable-file MD051 -->
### [Med SuperOffice WebTools](#tab/webtools)

1. Dubbelklicka på dokumentet.

1. Om en dialogruta öppnas klickar du på **Redigera**.

1. Gör de ändringar som behövs.

1. Spara dokumentet och stäng ordbehandlingsprogrammet.

1. I dialogrutan som öppnas klickar du på **Ja** om du är klar med redigeringen av dokumentet. Klicka på **Nej** för att behålla dokumentet utcheckat.

    Den här dialogrutan visas bara om det här alternativet har aktiverats i SuperOffice WebTools.

1. Dokumentet checkas in och statusen ändras till **Slutfört**.

### [Med SharePoint-dokument](#tab/sharepoint)

**Den här funktionen kräver en licens.**

1. Dubbelklicka på dokumentet. Dokumentet öppnas i en ny flik med online-textredigeringsprogrammet (Office Online).

    Om du vill använda ditt desktop-redigeringsprogram kan du välja **Öppna i Desktop-appen** från Office Online.

2. Redigera dokumentet.

3. Stäng fliken eller din desktop-app. Dokumentet sparas automatiskt till SharePoint.

### [Utan SuperOffice WebTools](#tab/no-webtools)

> [!NOTE]
> Den här proceduren beskriver hur du skapar dokument om du använder ett desktop-program för textredigering. Den faktiska processen kan skilja sig något om du använder ett online-baserat textredigeringsverktyg (som Microsoft Office Online) och ett dokumentbibliotek (som SharePoint).

1. Dubbelklicka på dokumentet.

2. Klicka på **Öppna** i dialogrutan **Dokument**.

3. Om en dialogruta öppnas klickar du på **Redigera**.

4. I dialogrutan **Ladda ner fil** väljer du **Öppna** eller **Spara**. Följ sedan steg 5-9 i proceduren [skapa dokument utan WebTools][2].

***

### <a id="allow"></a>Webbläsarsäkerhetsfråga vid öppning av filer

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

## <a id="delete"></a>Ta bort dokument

### Från detaljkortet Aktiviteter

1. Välj dokumentet på detaljkortet **Aktiviteter** i fönstret Företag, Kontakt, Kalender, Försäljning eller Projekt.

2. Högerklicka och välj **Ta bort**.

3. Bekräfta eller avbryt borttagningen i bekräftelsedialogen.

### Från dokumentdialogen

När du visar ett specifikt dokument:

1. Klicka på **Uppgift**-knappen (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) i **Dokument**-dialogen.
2. Välj **Ta bort**.
3. Bekräfta eller avbryt borttagningen i bekräftelsedialogen.

## Felsökning

Om du dubbelklickar på ett dokument och ingenting händer, kan du testa att högerklicka på det och välja **Dokument**. Detta öppnar dialogrutan **Dokument**. Klicka på **Öppna** och se om dokumentet öppnas nu.

### Hur vet jag om jag använder SharePoint, SuperOffice WebTools eller inte?

[!include[How to check document library](includes/webtools-or-sharepoint.md)]

## Relaterat innehåll

* [Så ändrar du Slutförd-status för en aktivitet][4]

<!-- Referenced links -->
[1]: lock.md
[2]: create.md
[3]: create.md#fields
[4]: ../../diary/learn/change-completed-status.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/webtools/webtools-edge-security-question.png
[img3]: ../../../media/loc/en/webtools/webtools-firefox-security-question.png
[img4]: ../../../media/loc/en/webtools/webtools-safari-security-question.png
[img5]: ../../../media/loc/en/webtools/webtools-chrome-security-question.png
