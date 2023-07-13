---
uid: help-sv-reply-template-create
title: Skapa svarsmallar
description: I den här guiden förklarar vi hur man skapar en svarsmall.
author: Bergfrid Dias
so.date: 03.16.2023
keywords: ärende, svar, mall
so.topic: howto
so.audience: person
so.audience.tooltip: SuperOffice Service
language: sv
---

# Skapa svarsmall

En svarsmall är en färdig text som kan klistras in i ett meddelande som du skriver till en kontakt. Användning av svarsmallar sparar tid och låter dig skicka personliga meddelanden till dina kontakter.

Svarsmallar kan även inkludera en bilaga som bifogas till meddelandet. Innan du skickar svaret till kontakten kan du redigera texten och lägga till eller ta bort bilagor.

> [!NOTE]
> Du behöver *Kunskapsbas* som funktionell rättighet för att skapa svarsmallar.

## Steg

1. Gå till ![ikon][img1] **Huvudmeny** i det övre fältet och välj **Kunskapsbas** > **Svarsmallar**.

1. Gå till mappen som du vill lägga in svarsmallen i. Om den inte finns än kan du [skapa en ny mapp][2].

    ![Så här hittar du svarsmallar i SuperOffice -screenshot][img3]

1. Klicka på knappen **Ny svarsmall**.

1. Högst upp på fliken **Egenskaper** i fönstret **Egenskaper för svarsmall**, anger du följande:

    * **Namn**: Ett beskrivande namn för svarsmallen.
    * **Beskrivning**: En kort beskrivning av vad svarsmallen innehåller.
    * **Mapp**: Som standard är det namnet på den valda mappen. Du kan välja en annan mapp här.
    * **Åtkomst**: Här väljer du vem som ska kunna läsa och ändra den aktuella svarsmallen.

1. Välj fliken **(Ospecificerat språk)**.

1. På fliken **Egenskaper** anger du följande information:
    * **Språk**: I denna lista väljer du svarsmallens språk. Listrutan innehåller de språk som finns registrerade under ![ikon][img2] &gt; **Kundspråk**.
    * **Standard**: Markera här om du vill att det aktuella språket ska vara standardspråk för svarsmallen.
    * **Ämne**: Här skriver du in svarsmallens titel. Vanligtvis sätts denna in i fältet **Ämne** när svarsmallen används som e-postmeddelande.
    * **Meddelandehuvudfält**: Här kan du lägga till fördefinierat innehåll som ska visas i meddelandehuvudet, t.ex. i fälten **Till** och **Ämne** i ett e-postmeddelande. Denna funktion används bara i speciella fall.

1. På fliken **Oformaterad text** anger du följande information:

    * **Inkludera oformaterad text**: När du skapar en HTML-version kan det vara bra att skapa en version med oformaterad text också, för e-postprogram som inte stöder HTML. E-postprogrammet väljer då automatiskt rätt format. Om du inte markerar det här alternativet ignoreras texten nedan. Den sparas dock så du kan välja att inkludera den senare.

    > [!NOTE]
    > Om du inkluderar både oformaterad text och HTML-text väljer e-postprogrammet den "bästa" versionen, som vanligtvis är HTML. Kom ihåg att meddelanden som skickas utan oformaterad text bara kan läsas av e-postprogram som har stöd för HTML.

    * I det stora fältet mitt på skärmen skriver du själva innehållet i svarsmallen. Det är alltid denna text som används när du [lägger till svarsmallar i meddelanden][4].
    * **Stavningskontroll**: Starter en stavningskontroll av meddelandet på det språk som anges i listan **Språk**.

1. På fliken **HTML-text** anger du följande information:

    * **Inkludera HTML-text**: Markera detta alternativ för att inkludera texten nedan i en HTML-version av e-postmeddelandet. Detta kan användas för kunder med e-postprogram som kan läsa HTML (t.ex. Outlook). Budskapet blir ofta tydligare om du skickar meddelandet som HTML, eftersom du då kan lägga in bilder och använda färger i texten.
    * I det stora fältet mitt på skärmen skriver du in HTML-formaterad text som du vill inkludera i meddelandet till kontakten. Kom ihåg att bilder som meddelandet hänvisar till här måste finnas på en server som är tillgänglig för e-postmeddelandets mottagare. Du kan t.ex. lägga in bilder som redan har lagts upp under **Externa dokument**.

1. På fliken **SMS-text** kan du lägga in svarsmallstext som ska skickas via SMS. Här anger du följande information:

    * **SMS-text**: I detta fält skriver du in själva brödtexten i svarsmallen.
    * **Antal tecken**: Här kan du se hur många tecken du har skrivit in.

1. På fliken **Bilaga** kan du lägga till bilagor som du vill ha med i svarsmallen:

    1. Klicka på **Bläddra**.
    2. Bläddra dig fram till önskat dokument i dialogrutan.
    3. Klicka på **Lägg till** för att lägga till bilagan.
    4. Upprepa denna procedur om du vill lägga till fler bilagor.

    > [!TIP]
    > Du kan ta bort en bilaga genom att klicka på **Ta bort** till höger på raden.

1. Klicka på **OK** för att spara svarsmallen. Fliken **(Ospecificerat språk)** ändras till det valda språket. Klicka på **Tillbaka** för att återgå till mappstrukturen för svarsmallar. Den finns nu tillgänglig för användning när du ska [svara på förfrågningar från kunder][4].

## Skapa egen layout för svar med hjälp av kategorier

Om du vill att varje avdelning i företaget ska få en egen layout för sin korrespondens kan du skapa svarsmallar med olika layouter. Varje svarsmall kan kopplas till en [kategori][1] som representerar en avdelning. Den avdelningsspecifika designen används vid alla utgående svar från kategorierna (avdelningarna).

Förutom sin layout och formatering måste svarsmallen även innehålla följande mallvariabler för att slås ihop för svaret:

```text
[[IF:message.bodyHtml!=""]]
[[message.bodyHtml]]
[[ELSE]]
[[message.body]]
[[ENDIF]]
```

## <a id="faq" />Automatiskt svar på FAQ

SuperOffice Service levereras med en uppsättning svarsmallar. Bland dessa svarsmallar hittar du "Example of an automated FAQ response". I denna svarsmall finns ett exempel på hur svar till kunden kan automatiseras på fliken **HTML-text**.

Baserat på kundens förfrågan söker systemet efter motsvarande ord (inkl. nyckelord) i FAQ-posterna i SuperOffice Service. Baserat på graden av överensstämmelse mellan dessa föreslås FAQ-poster som kan hjälpa kunden och dessa inkluderas i den svarsmall som automatiskt skickas till kunden för att bekräfta att förfrågan har mottagits.

Du kan välja graden av överensstämmelse mellan kundens förfrågan och FAQ-posterna i fältet **Minimivärde för FAQ-sökresultat (i procent)** i ![ikon][img2] **Systeminställningar** > **System** > **Inställningar**.

## Vad vill du göra nu?

* [Skapa ny språkversion av svarsmall][5]
* [Redigera svarsmallar][6]
* [Kopiera svarsmallar][7]

<!-- Referenced links -->
[1]: ../../learn/category/index.md
[2]: manage-folders.md
[4]: ../../learn/howto/reply.md
[5]: new-language.md
[6]: edit.md
[7]: copy.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/main-menu.png
[img2]: ../../../../media/icons/main-menu-small.png
[img3]: ../../../../media/loc/en/request/create-a-new-reply-template.png
