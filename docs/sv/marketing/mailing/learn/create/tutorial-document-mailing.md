---
uid: help-sv-tutorial-document-mailing
title: Handledning - dokumentutskick
description: I den här instruktionsguiden lär du dig att skapa ett dokumentutskick.
keywords: dokumentutskick
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

# Handledning - dokumentutskick

[!include[Tips](includes/tip-mailing-save-draft.md)]

## Steg 1: Konfigurering

> [!TIP]
> Om du vill visa och skriva ut ett befintligt dokumentutskick stänger du steget **Konfiguration** (klicka på **Avbryt** eller **Spara + stäng**). Välj fliken **Utskick**, leta rätt på dokumentet, klicka på <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> och välj **Visning**. Klicka på knappen under **Hämta genererat dokument**. Dokumentet hämtas då till webbläsaren. Öppna och skriv ut dokumentet.

Med arbetsflödet för dokumentutskick kan du generera ett PDF-dokument som ska skrivas ut och skicka det till dina kunder. Det första steget för att skapa ett dokumentutskick är att **konfigurera** utskicket. Här kan du ställa in utskickets namn, ange rubriken och Obs!-texten i dokumentet och ställa in olika arkiveringsalternativ för utskicket.

Du kan koppla dokumentutskicket till ett specifikt projekt. Det kan vara relevant om du skapar utskick till mottagare som deltar i ett projekt i SuperOffice CRM. Genom att använda mallvariabler i mallen kan du infoga projektuppgifter i utskicket.

Du kan koppla dokumentutskicket till en specifik försäljning. Det kan vara relevant om du skapar utskick till mottagare som är intressenter i en försäljning i SuperOffice CRM. Genom att använda mallvariabler i mallen kan du infoga försäljningsdata i utskicket.

**Steg:**

1. Ange ett namn i fältet **Namn för utskick**.

1. I fältet **Rubrik** anger du dokumentets titel.

1. I fältet **Riktat till** ska du välja vem utskicket ska rikta sig till. Välj ett av följgende alternativ:

    * **Om ingen definierats**: Välj det här alternativet om du vill använda mottagarnas namn som standard, eller, om inget mottagarnamn hittas, använd mottagaren som du anger i textfältet. Om du vill göra ett utskick till IT-teknikerna vid ett företag kan du t.ex. skriva "IT-avdelningen" eller liknande.

    * **Använd alltid**: Välj det här alternativet om du vill åsidosätta mottagarnamnen och bara använda mottagaren som du anger i textfältet.

1. I fältet **Vår ref** ska du ange det namn som ska anges som "vår referens" i dokumentet. Du kan använda [mallvariablerna][1] från SuperOffice CRM i det här fältet.

    > [!NOTE]
    > För att variabler som försäljnings-ID och projekt-ID ska fungera måste du koppla dokumentutskicket till en försäljning eller ett projekt.

1. Välj en mapp som du vill placera utskicket i från listan **Mapp**.

    [Hur skapar jag en utskicksmapp?][3]

1. I fälten **Urval** och **Projekt** kan du associera utskicket med ett urval och/eller ett projekt. Börja fylla i fälten om du vill söka.

1. Klicka på **Nästa** när du vill gå vidare till nästa steg.

## Steg 2: Mall

[!include[Så här väljer du en mall](includes/mailing-choose-template.md)]

## Steg 3: Innehåll

I steget **Innehåll** kan du redigera dokumentets utseende och innehåll.

1. Klicka på knappen **Redigera**.

1. I dialogrutan klickar du på **Ladda ned dokument**. Filen hämtas då till webbläsaren.

1. Öppna dokumentet för redigering. I de flesta webbläsare kan du klicka på den hämtade filen om du vill öppna den i standardprogrammet.

1. Redigera dokumentets innehåll.

1. Spara dokumentet.

1. (i tillämpliga fall) I SuperOffice Marknadsföring, klicka på **Redigera** för att öppna dialogrutan igen.

1. Klicka på **Välj fil**, välj det sparade dokumentet och klicka sedan på **Ladda upp vald fil**. Förhandsgranskningen på höger sida uppdateras med innehållet i den uppladdade filen.

1. Klicka på **Nästa** när du vill gå vidare till nästa steg.

### Använda mallvariabler

Du kan använda [mallvariabler][3] från SuperOffice CRM i ditt dokument för att infoga kundspecifika uppgifter. Det ger meddelandet en mer personlig prägel.

## Steg 4: Mottagare

[!include[Steg 4 mottagare](includes/step-4-recipients.md)]

## Steg 5: Bekräfta

> [!NOTE]
> Dokumentutskick skickas inte i praktiken när du klickar på **Skicka nu**. Ett PDF-dokument genereras, med alla sidor till alla personer/företag som du valt som mottagare till utskicket. Du kan [öppna och skriva ut](#pdf) PDF-dokumentet från skärmen **Visa utskick**.

I det sista steget, **Bekräfta**, kan du se en sammanfattning för utskicket och kontrollera att allt stämmer. Eventuella felmeddelanden som visas på denna skärm måste lösas innan utskicket kan skickas.

> [!NOTE]
> Utskicksalternativen är inaktiverade om några steg är ofullständiga eller information saknas i utskicket. Dessa anges i rött.

### Skicka utskicket nu

Klicka på **Skicka nu** och generera ett PDF-dokument. Ett PDF-dokument genereras. Arbetsflödet stängs och du kommer tillbaka till fliken **Utskick**.

Klicka på utskicket i listan om du vill [visa sändningsstatus och statistik för utskicket][2].

### <a id="pdf"></a>Öppna och skriv ut dokumentet

1. Välj fliken **Utskick**.
1. Leta rätt på dokumentet, klicka på <i class="ph ph-list" aria-label="Task menu"></i> och välj **Visning**.
1. Klicka på knappen under **Hämta genererat dokument**. Dokumentet hämtas då till webbläsaren.
1. Öppna och skriv ut dokumentet.

<!-- Referenced links -->
[2]: ../view-statistics.md
[1]: ../../../editor/learn/index.md#variables
[3]: ../../../learn/create-folder.md
