---
uid: help-sv-quote-create-document
title: Skapa offertdokument
description: Skapa ett offertdokument för ditt förslag i SuperOffice Quote som du kan skicka till kunden.
keywords: skapa offertdokument, ändra offertdokument, offertdokument, offert
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: sv
redirect_from: /sv/quote/learn/create-quote-document
---

# Skapa offertdokument

När du har skapat offerten och lagt till produkterna, kan du generera ett offertdokument. Det fungerar som ett "brev" som skickas till kunden. Produktlistan läggs till automatiskt när offerten skickas.

Du kan skapa dokumentet antingen från fliken **Offert** i försäljningen eller från dialogrutan **Redigera offert**.

> [!TIP]
> Använd [en mall med offertspecifika merge fields][3] för att inkludera offertinformation i dokumentet.

## Skapa offertdokumentet

1. Om du redan redigerar offerten, klicka på **Klicka för att skapa ett offertdokument** högst upp i dialogrutan **Redigera offert**.

    *Annars*, gå till fliken **Offert** i försäljningen och klicka på **Klicka för att skapa ett offertdokument**.

    > [!NOTE]
    > Offerten måste ha statusen **Utkast**. Om den redan har skickats, [skapa först en ny version][1].

2. I dialogrutan **Dokument**, [fyll i de obligatoriska fälten][2].

3. Klicka på **Skapa** för att skapa ett nytt dokument baserat på vald mall.

4. Redigera innehållet i Word (eller annan standardredigerare), och spara och stäng filen.

    Dokumentet visas på fliken **Offert** och är kopplat till offerten. Det visas också under fliken **Aktiviteter** i försäljningen (samt i Företag- och Kalender-vyerna).

## <a id="replace"></a>Byt ut offertdokumentet

Om du vill ändra innehållet eller mallen för ett offertdokument kan du använda någon av följande metoder:

### Alternativ 1: Endast ersätta filen

Använd detta om du vill behålla metadata för dokumentet men ladda upp en uppdaterad fil från datorn.

1. Klicka på dokumentet i fliken **Offert**.

2. Avmarkera **Slutförd**.

3. Klicka på **Ersätt**, välj den nya filen och ladda upp.

4. Klicka på **Spara**.

### Alternativ 2: Ta bort och återskapa dokumentet

Använd detta om du vill börja om från början med ett nytt dokument.

1. Klicka på det befintliga dokumentet i fliken **Offert**.

2. Klicka på <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> och välj **Ta bort** i menyn **Uppgift**.

3. Klicka på **Klicka för att skapa ett offertdokument** för att skapa en ny fil.

### Alternativ 3: Skapa och koppla ett nytt dokument

Använd detta för att manuellt skapa ett nytt dokument med din valda mall och koppla det till offerten. Det befintliga dokumentet bevaras.

1. Klicka på **Nytt** i toppmenyn och välj **Dokument**.

2. I dialogrutan **Dokument**, välj en offertmall och koppla dokumentet till rätt försäljning. Klicka på **Skapa**.

3. Gå till fliken **Offert** i försäljningen och klicka på **Öppna**.

4. Klicka på <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> och välj **Byt offertdokument** i menyn **Uppgift**.

5. Välj det nya dokumentet i listan.

    Listan visar alla offertdokument som är kopplade till den aktuella försäljningen.

> [!TIP]
> För mindre ändringar kan du öppna det befintliga dokumentet, göra ändringar och spara. Du behöver inte ersätta eller ta bort det.

## Hur offertmallar fungerar

Mallarna för offertdokument, offertdetaljer och orderbekräftelser skiljer sig från vanliga dokumentmallar. De använder **merge fields** utöver standardvariabler.

* Om sammanslagningsfältet `<<QuoteDetails>>` finns i huvuddokumentet infogas offertdetaljerna där.
* Om det inte finns, infogas offertdetaljerna sist i dokumentet.

## Relaterat innehåll

* [Skicka en offert][4]
* [Registrera en order][5]
* [Redigera ett dokument][2]
* [Offertmallar][6]
* [Mallvariabler och merge fields][3]

<!-- Referenced links -->
[1]: send.md#versions
[2]: ../../../document/learn/edit.md
[3]: ../../../document/templates/merge-fields/quote.md
[4]: send.md
[5]: place-order.md
[6]: ../../../document/templates/learn/quote-templates.md
