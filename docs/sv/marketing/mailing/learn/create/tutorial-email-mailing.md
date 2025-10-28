---
uid: help-sv-tutorial-email-mailing
title: Handledning - e-postutskick
description: När du har slutfört de nödvändiga förberedelserna, vilket inkluderar att skapa din mållista och förbereda din utskicksmall, är du redo att skapa ett nytt utskick i SuperOffice CRM. I den här instruktionsguiden lär du dig att skapa ett e-postutskick.
keywords: e-postutskick
date: 09.26.2025
version: 10.5
content_type: tutorial
category: marketing
topic: mailing
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: sv
---

# Handledning - e-postutskick

[!include[Tips](includes/tip-mailing-save-draft.md)]

## Steg 1: Konfigurering

Du kan skapa ditt nya utskick i fönstret Marknadsföring under fliken Utskick. Klicka på knappen Skapa utskick så kommer du till det första steget där du kan ställa in ditt utskick.

Det första steget för att skapa ett e-postutskick är att **konfigurera** utskicket. Här kan du ställa in uppgifter för e-posthuvudet som t.ex. avsändare, svarsadress och ämne. Du kan även bifoga filer, ställa in arkiveringsalternativ för utskicket och välja spårningsalternativ.

1. Ange ett namn i fältet **Namn för utskick**.

1. Ange ämnesraden för e-postmeddelandet i fältet **Ämnesrad för e-post**.

1. I listan **Från**, välj **Använd alltid** och ange sedan avsändarens e-postadress i fältet nedanför om du vill använda samma avsändare i alla utskick. Du kan även sätta en försäljningskontakt eller supportkontakt som avsändare om en sådan kontakt finns definierad för den aktuella mottagaren. Ange den e-postadress som ska användas om ingen försäljningskontakt eller supportkontakt finns tillgänglig. Om administratören har aktiverat inställningen för [global e-postvalidering][2] väljer du den domän du vill skicka från i listrutan.

    [!include[Note](includes/spf-look-up.md)]

1. I listan **Svar till** har du samma alternativ att välja mellan som ovan. Dessutom kan du välja alternativet **Använd "Från" som svarsadress**. Eventuella svar kommer då att skickas till avsändaren.

1. Välj en mapp som du vill placera utskicket i från listan **Mapp**.

    [Hur skapar jag en utskicksmapp?][4]

1. I fälten **Urval** och **Projekt** kan du associera utskicket med ett urval och/eller ett projekt. Börja fylla i fälten om du vill söka.

    Om du lägger till ett urval läggs alla kontakter i urvalet till som mottagare i utskicket.

1. I listan **Typ** väljer du vilken typ av utskick du vill skapa. Välj **(någon)** om utskicket matchar två eller fler av de tillgängliga typerna. Använd **(någon)** när du har lagt till flera mottagare med flera prenumerationer och vill skicka utskicket till alla.

1. **Bilaga**: Om du vill lägga till en eller flera bilagor till utskicket använder du någon av följande metoder:

    * Klicka på **Ladda upp filer (eller dra dem hit)** och bläddra och lägg till en fil från en disk eller server.
    * Dra och släpp en fil från Windows Utforskaren till bilagefältet.
    * Klicka på **Välj ett CRM-dokument** och välj ett dokument i SuperOffice CRM.

1. Under **Spårning** finns följande alternativ:

    [!include[Tracking options for mailing](includes/mailing-tracking-options.md)]

1. Klicka på **Nästa** när du vill gå vidare till nästa steg.

### Validering av e-postdomän (ENDAST ONLINE)

Om administratören har aktiverat den [globala inställningen][2] **Använd endast godkända e-postdomäner** delas fältet **Från adress** upp och du måste välja den domän du vill skicka från i listrutan över godkända domäner.
Om du försöker skicka från en domän som inte har en giltig SPF-post visas en varning och du kan inte skicka från den domänen. Detta gäller för alla e-postdomäner även om valideringsinställningen inte är aktiverad.

> [!NOTE]
> Om **Vår kontaktadress** har en e-postdomän som inte har validerats skickas utskicket automatiskt från den adress som anges i listrutan **Använd annars**.

## Steg 2: Mall

[!include[Så här väljer du en mall](includes/mailing-choose-template.md)]

## Steg 3: Innehåll

[!include[Steg 3 e-post](includes/step-3-content-email.md)]

## Steg 4: Mottagare

[!include[Steg 4 mottagare](includes/step-4-recipients.md)]

## Steg 5: Bekräfta

[!include[Så här bekräftar och skickar du ett utskick](includes/step-5-confirm-and-send-mailing.md)]

<!-- Referenced links -->
[2]: ../../admin/add-domain.md
[4]: ../../../learn/create-folder.md
