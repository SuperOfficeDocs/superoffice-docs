---
uid: help-sv-email-service
title: Servicemejl
description: Servicemejl
author: SuperOffice Product and Engineering
keywords: brevlåda
date: 07.10.2025
version: 10.5
content_type: concept
category: service
topic: email
functional_right:
license: serviceessentials
audience: person
audience_tooltip: SuperOffice Service
language: sv
redirect_from:
  - /sv/email/service/learn/index
  - /sv/email/service/learn/screen/tab-inbox-for-email
  - /sv/email/service/learn/screen/tab-outbox-for-email
  - /sv/email/service/learn/screen/tab-blocked-email
  - /sv/email/service/learn/screen/sms-inbox
  - /sv/email/service/learn/screen/sms-outbox
---

# Servicemejl

[!include[Restricted access](../../../learn/includes/note-insufficient-rights.md)]

I fönstret **E-post** kontrollerar du de mekanismer som styr inkommande och utgående e-post. E-postmeddelanden importeras genom att SuperOffice Service regelbundet samlar in e-post från en eller flera brevlådor. Dessa e-postmeddelanden kan skannas av e-postfilter som behandlar meddelandena baserat på deras innehåll och generar ärenden. Utgående e-post (svar) från systemet placeras i utkorgen och skickas regelbundet till en e-postserver som vidarebefordrar dem. Importerade e-postmeddelanden som har blockerats (av ett filter) visas på fliken **Blockerad e-post** och måste gås igenom manuellt.

## E-postlådor

På fliken **E-postlådor** visas en översikt över installerade e-postlådor. I översikten finns följande kolumner:

* **Adress**: E-postlådans avsändaradress.
* **Kategori**: Ärenden från e-postlådan placeras i denna kategori.
* **Prioritet**: Prioritet som nya ärenden får när de registreras från den här brevlådan.
* **Adress för vidarebefordran**: Om du inte använder e-postfunktionerna i SuperOffice vidarebefordras e-postmeddelanden till denna adress.
* **Protokoll**: Det protokoll som brevlådan använder.

### <a id="email-in"></a>Inkorg för e-post

På fliken **Inkorg för e-post** finns en lista med alla e-postmeddelanden i inläsningskön. Följande alternativ är också tillgängliga via knappen <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i>:

* **Exportera**: Används för att exportera listan till en fil. Du kan välja mellan följande format: Excel, HTML och oformaterad text.

* **Ta bort**: Används för att ta bort de valda e-postmeddelandena.

    > [!NOTE]
    > Denna åtgärd kan inte ångras.

Om du klickar på ett av meddelandena på den här fliken visas fönstret **Inkommande e-post**. Denna skärm visar information om meddelandet. I fältet **Senaste felmeddelande** kan du se vad som orsakade problemet, till exempel om det finns problem med e-postadressen eller e-postservern. Om ett felmeddelande från SuperOffice Service visas kan du klicka på **Importera med felsökning** för att visa teknisk information som kan hjälpa användarsupporten med felsökning.

### <a id="email-out"></a>Utkorg för e-post

På fliken **Utkorg för e-post** finns en översikt över alla e-postmeddelanden i utskickningskön.

Välj **Visa skickade e-postmeddelanden** längst ner till höger om du även vill visa de senaste e-postmeddelandena om ärenden.

Följande alternativ är också tillgängliga via knappen <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i>:

* **Exportera**: Används för att exportera listan till en fil. Du kan välja mellan följande format: Excel, HTML och oformaterad text.

* **Skicka**: Används för att bara skicka om de markerade e-postmeddelandena om det uppstod fel i det automatiska utskicket.

* **Ta bort**: Används för att ta bort de valda e-postmeddelandena.

    > [!NOTE]
    > Denna åtgärd kan inte ångras.

Om du klickar på ett av meddelandena på den här fliken visas fönstret **Utgående e-post**. Här visas information om det valda meddelandet, t.ex. dess storlek och vem som skapade det. Eventuella felmeddelanden visas också.

### <a id="email-blocked"></a>Blockerad e-post

På fliken **Blockerad e-post** finns en lista över inkommande e-postmeddelanden som har blockerats av ett e-postfilter. Klicka på ett e-postmeddelande om du vill visa innehållet. Om alla e-postmeddelanden inte ryms på en sida kan du klicka på <i class="ph ph-arrow-right" aria-label="Arrow right"></i> för att navigera till nästa sida. I översikten finns följande kolumner:

* **När**: Anger när e-postmeddelandet blockerades.
* **E-postlåda**: Anger vilken brevlåda som importerade e-postmeddelandet.
* **E-postfilter**: Anger vilket e-postfilter som blockerade e-postmeddelandet.
* **E-postmeddelandets rubrik**: Visar meddelandets rubrik.

Följande alternativ är också tillgängliga via <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i>:

* **Exportera**: Används för att exportera listan till en fil. Du kan välja mellan följande format: Excel, HTML och oformaterad text.
* **Import**: Används för att importera de valda e-postmeddelandena. Det e-postfilter som blockerade e-postmeddelandet ignoreras medan övriga e-postfilter kan vara aktiverade.
* **Ta bort**: Används för att ta bort de markerade blockerade e-postmeddelandena.

### <a id="sms-in"></a>Inkorg för SMS

> [!NOTE]
> Om fliken inte syns betyder det att SMS-modulen inte är installerad eller att SMS inte har aktiverats för den licens du använder. Kontakta systemansvarig person om du vill ha mer information.

På fliken **Inkorg för SMS** finns en lista över alla SMS-meddelanden i inläsningskön. Följande alternativ är också tillgängliga via menyknappen:

* **Exportera**: Används för att exportera listan till en fil. Du kan välja mellan följande format: Excel, HTML och oformaterad text.

* **Ta bort**: Används för att ta bort de valda meddelandena.

    > [!NOTE]
    > Denna åtgärd kan inte ångras.

Klicka på något av meddelandena på den här fliken om du vill visa information om det valda meddelandet.

### <a id="sms-out"></a>Utkorg för SMS

Fliken **Utkorg för SMS** innehåller alla utgående SMS som ännu inte har skickats eller som har genererat fel.

> [!NOTE]
> Om fliken inte syns betyder det att SMS-modulen inte är installerad eller att SMS inte har aktiverats för den licens du använder. Kontakta systemansvarig person om du vill ha mer information.

Följande alternativ är också tillgängliga via menyknappen:

* **Exportera**: Används för att exportera listan till en fil. Du kan välja mellan följande format: Excel, HTML och oformaterad text.

* **Skicka**: Används för att bara skicka om de markerade e-postmeddelandena om det uppstod fel i det automatiska utskicket.

* **Ta bort**: Används för att ta bort de valda meddelandena.

    > [!NOTE]
    > Denna åtgärd kan inte ångras.

Om du klickar på ett av meddelandena på fliken visas skärmen **Utgående SMS**. Här visas information om det valda meddelandet, t.ex. dess storlek och vem som skapade det. Eventuella felmeddelanden visas också.

## Relaterat innehåll

* [Skapa e-postlådor][1]
* [Ta bort e-postlådor][2]
* [E-postfilter][3]

<!-- Referenced links -->
[1]: create-mailbox.md
[2]: delete-mailbox.md
[3]: email-filters/index.md

<!-- Referenced images -->
