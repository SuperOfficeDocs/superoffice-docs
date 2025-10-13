---
uid: help-sv-reply-template-create
title: Skapa svarsmallar
description: Lär dig hur du skapar en svarsmall i denna steg-för-steg-guide.
keywords: skapa svarsmall, ny svarsmall, kopiera svarsmall, svarsmallsegenskaper, ny mall
author: SuperOffice Product and Engineering
date: 02.25.2025
version: 10.5.2
content_type: howto
category: service
topic: knowledge base
license: serviceessentials
functional_right: knowledge-base
audience: person
audience_tooltip: SuperOffice Service
language: sv
redirect_from:
  - /sv/request/reply-templates/learn/copy
  - /sv/request/reply-templates/learn/create
---

# Skapa svarsmall

En svarsmall är en färdig text som kan infogas i ett meddelande du skriver till en kontakt. Genom att använda svarsmallar sparar du tid och kan skicka personliga meddelanden effektivt.

Svarsmallar kan också innehålla en bilaga som automatiskt bifogas till meddelandet. Innan du skickar svaret kan du redigera texten och lägga till eller ta bort bilagor.

> [!NOTE]
> Du behöver *Kunskapsbas* som funktionell rättighet för att skapa svarsmallar.

## Skapa en svarsmall från grunden

1. Gå till <i class="ph ph-list" aria-label="Huvudmeny"></i> i toppraden och välj **Kunskapsbas** > **Svarsmallar**.

1. Gå till mappen där du vill spara svarsmallen. Om mappen inte finns kan du [skapa en ny mapp][2].

1. Klicka på knappen **Ny svarsmall**.

1. På fliken **Egenskaper** i fönstret **Egenskaper för svarsmall**, fyll i följande:

    * **Namn**: Ett beskrivande namn för svarsmallen.
    * **Beskrivning**: En kort beskrivning av svarsmallens innehåll.
    * **Mapp**: Som standard anges den valda mappen, men du kan välja en annan.
    * **Åtkomst**: Bestäm vilka användare som ska kunna läsa och redigera svarsmallen.

1. Välj fliken **(Ospecificerat språk)**.

1. På fliken **Egenskaper**, ange:
    * **Språk**: Välj [kundspråk][7] för svarsmallen.
    * **Standard**: Markera om detta ska vara standardspråket för svarsmallen.
    * **Ämne**: Ange en titel. Den används normalt som ämne när svarsmallen används i e-post.
    * **Meddelandehuvudfält**: Lägg till fördefinierat innehåll som visas i meddelandehuvudet, exempelvis fälten **Till** och **Ämne** i e-post.

1. På fliken **Oformaterad text**, ange:

    * **Inkludera oformaterad text**: När du skapar en HTML-version kan det vara bra att skapa en version med oformaterad text också, för e-postprogram som inte stöder HTML. E-postprogrammet väljer då automatiskt rätt format. Om du inte markerar det här alternativet ignoreras texten nedan. Den sparas dock så du kan välja att inkludera den senare.

    > [!NOTE]
    > Om du inkluderar både oformaterad text och HTML-text väljer e-postprogrammet den "bästa" versionen, som vanligtvis är HTML. Kom ihåg att meddelanden som skickas utan oformaterad text bara kan läsas av e-postprogram som har stöd för HTML.

    * I det stora fältet mitt på skärmen skriver du själva innehållet i svarsmallen. Det är alltid denna text som används när du [lägger till svarsmallar i meddelanden][4].
    * **Stavningskontroll**: Starter en stavningskontroll av meddelandet på det språk som anges i listan **Språk**.

1. På fliken **HTML-text**, ange:

    * **Inkludera HTML-text**: Markera detta alternativ för att inkludera texten nedan i en HTML-version av e-postmeddelandet. Detta kan användas för kunder med e-postprogram som kan läsa HTML (t.ex. Outlook). Budskapet blir ofta tydligare om du skickar meddelandet som HTML, eftersom du då kan lägga in bilder och använda färger i texten.
    * I det stora fältet mitt på skärmen skriver du in HTML-formaterad text som du vill inkludera i meddelandet till kontakten. Kom ihåg att bilder som meddelandet hänvisar till här måste finnas på en server som är tillgänglig för e-postmeddelandets mottagare. Du kan t.ex. lägga in bilder som redan har lagts upp under **Externa dokument**.

1. På fliken **SMS-text**, ange:

    * **SMS-text**: I detta fält skriver du in själva brödtexten i svarsmallen.
    * **Antal tecken**: Här kan du se hur många tecken du har skrivit in.

1. På fliken **Bilaga**, lägg till bilagor som du vill ha med i svarsmallen:

    1. Klicka på **Bläddra**.
    2. Bläddra dig fram till önskat dokument i dialogrutan.
    3. Klicka på **Lägg till** för att lägga till bilagan.
    4. Upprepa denna procedur om du vill lägga till fler bilagor.

    > [!TIP]
    > Ta bort en bilaga genom att klicka på **Ta bort** bredvid filen.

1. Klicka på **OK** för att spara svarsmallen. Fliken **(Ospecificerat språk)** ändras till det valda språket. Klicka på **Tillbaka** för att återgå till mappstrukturen för svarsmallar. Svarsmallen är nu tillgänglig för användning när du [svarar på kundförfrågningar][4].

## <a id="copy"></a> Kopiera en svarsmall

Du kan skapa en ny svarsmall genom att kopiera en befintlig.

1. Gå till <i class="ph ph-list" aria-label="Huvudmeny"></i> i toppraden och välj **Kunskapsbas** > **Svarsmallar**.
1. Gå till mappen där svarsmallen finns.
1. Klicka på svarsmallen för att öppna den.
1. Klicka på knappen **Kopiera**. Svarsmallen öppnas i redigeringsläge.
1. Ändra namn och gör eventuella andra ändringar.
1. Klicka på **OK**. Ändringarna sparas.

## Skapa anpassad layout för svarsmallar med kategorier

Du kan skapa svarsmallar med olika layouter för att anpassa svaren per avdelning. Varje svarsmall kan kopplas till en [kategori][1] som representerar en avdelning. Alla utgående svar från kategorin får då en specifik design.

Utöver layouten måste svarsmallen innehålla följande mallvariabler för att sammanfogas med svaret:

```text
[[IF:message.bodyHtml!=""]]
[[message.bodyHtml]]
[[ELSE]]
[[message.body]]
[[ENDIF]]
```

## <a id="faq"></a> Automatiskt FAQ-svar

SuperOffice Service levereras med en uppsättning svarsmallar. Bland dessa svarsmallar hittar du "Example of an automated FAQ response". I denna svarsmall finns ett exempel på hur svar till kunden kan automatiseras på fliken **HTML-text**.

Baserat på kundens förfrågan söker systemet efter motsvarande ord (inkl. nyckelord) i FAQ-posterna i SuperOffice Service. Baserat på graden av överensstämmelse mellan dessa föreslås FAQ-poster som kan hjälpa kunden och dessa inkluderas i den svarsmall som automatiskt skickas till kunden för att bekräfta att förfrågan har mottagits.

Du kan välja graden av överensstämmelse mellan kundens förfrågan och FAQ-posterna i fältet **Minimivärde för FAQ-sökresultat (i procent)** i <i class="ph ph-list" aria-label="Huvudmeny"></i> **Systeminställningar** > **System** > **Inställningar**.

## Relaterat innhåll

* [Skapa ny språkversion av svarsmall][5]
* [Redigera svarsmallar][6]

<!-- Referenced links -->
[1]: ../../../request/admin/category/index.md
[4]: ../../../request/learn/reply.md
[2]: ../manage-folders.md
[5]: new-language.md
[6]: edit.md
[7]: ../../../localization/learn/customer-languages.md
