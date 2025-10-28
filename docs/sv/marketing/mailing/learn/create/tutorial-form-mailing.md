---
uid: help-sv-tutorial-form-mailing
title: Handledning - utskick av formulärsvar
description: I den här instruktionsguiden lär du dig att skapa ett formulärsvarsutskick.
keywords: formulärsvar, formulärutskick
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

# Handledning - utskick av formulärsvar

[!include[Tips](includes/tip-mailing-save-draft.md)]

## Steg 1: Konfigurering

Det första steget för att skapa ett formulärsvar är att **konfigurera** utskicket. Här kan du ställa in uppgifter för e-posthuvudet som t.ex. avsändare, svarsadress och ämne. Du kan även bifoga filer, ställa in arkiveringsalternativ för utskicket och välja spårningsalternativ.

1. Ange ett namn i fältet **Namn för utskick**.

1. Ange ämnesraden för e-postmeddelandet i fältet **Ämnesrad för e-post**.

1. I listan **Från**, välj **Använd alltid** och ange sedan avsändarens e-postadress i fältet nedanför om du vill använda samma avsändare i alla utskick. Du kan även sätta en försäljningskontakt eller supportkontakt som avsändare om en sådan kontakt finns definierad för den aktuella mottagaren. Ange den e-postadress som ska användas om ingen försäljningskontakt eller supportkontakt finns tillgänglig. Om administratören har aktiverat inställningen för [global e-postvalidering][1] väljer du den domän du vill skicka från i listrutan. Om inte, ange adressen och domänen du vill skicka från.

    [!include[Note](includes/spf-look-up.md)]

1. I listan **Svar till** har du samma alternativ att välja mellan som ovan. Dessutom kan du välja alternativet **Använd "Från" som svarsadress**. Eventuella svar kommer då att skickas till avsändaren.

1. Välj en mapp som du vill placera utskicket i från listan **Mapp**.

    [Hur skapar jag en utskicksmapp?][2]

1. I fälten **Urval** och **Projekt** kan du associera utskicket med ett urval och/eller ett projekt. Börja fylla i fälten om du vill söka.

    Om du lägger till ett urval läggs alla kontakter i urvalet till som mottagare i utskicket.

1. **Bilaga**: Om du vill lägga till en eller flera bilagor till utskicket använder du någon av följande metoder:

    * Klicka på **Ladda upp filer (eller dra dem hit)** och bläddra och lägg till en fil från en disk eller server.
    * Dra och släpp en fil från Windows Utforskaren till bilagefältet.
    * Klicka på **Välj ett CRM-dokument** och välj ett dokument i SuperOffice CRM.

1. Under **Spårning** finns följande alternativ:

    [!include[Tracking options for mailing](includes/mailing-tracking-options.md)]

1. Klicka på **Nästa** när du vill gå vidare till nästa steg.

## Steg 2: Mall

[!include[Så här väljer du en mall](includes/mailing-choose-template.md)]

## Steg 3: Innehåll

[!include[Steg 3 e-post](includes/step-3-content-email.md)]

<!-- Referenced links -->
[1]: ../../admin/add-domain.md
[2]: ../../../learn/create-folder.md
