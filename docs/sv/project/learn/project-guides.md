---
uid: help-sv-project-guide
title: Projektguider
description: Introduktion till projektguider i SuperOffice.
keywords: projektguide, guide, arbetsflöde, detaljkortet Projektguide, projekt, processhantering, projektledare, arbetsmetod
author: Bergfrid
date: 02.25.2025
version: 10.5.2
content_type: concept
license: salespremium, servicepremium, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: sv
redirect_from:
  - /sv/project/learn/project-guide/index
  - /sv/project/learn/project-guide/project-guide-tab
  - /sv/project/learn/project-guide/view-followups-and-documents
---

# Projektguider

En projektguide i SuperOffice CRM är ett verktyg för processhantering som förenklar och standardiserar genomförandet av projekt. Den kopplar projekttyper till fördefinierade statusar, där varje status innehåller specifika händelser, dokument och milstolpar. Detta strukturerade tillvägagångssätt säkerställer en enhetlig arbetsmetod i alla projekt och hjälper projektledare att hålla koll på uppgifter och viktiga leveranser.

Som standard finns flera projektguider tillgängliga i SuperOffice CRM. Du kan använda dessa som de är eller anpassa dem i **Inställningar och underhåll** för att matcha ditt företags arbetsflöden.

## Vad är en projektguide?

En projektguide består av:

* **Statusar:** Olika faser av ett projekt, såsom **Planerat**, **Under arbete** och **Avslutning**.
* **Händelser:** Uppgifter som att-göra-punkter och möten kopplade till varje status.
* **Dokument:** Relevanta filer, såsom rapporter eller anteckningar, som är länkade till projektet.
* **Milstolpar:** Viktiga händelser som markerar betydande framsteg i projektet.

När du skapar ett projekt eller ändrar dess typ till en som är kopplad till en projektguide, aktiveras guiden automatiskt i detaljkortet **Projektguide**. Detta detaljkort visar statusarna, tillhörande aktiviteter och nästa steg för projektet.

**Exempel:**

För en projekttyp som **Konferens** kan guiden innehålla:

* **Planerat**: En händelse för "Planeringsmöte" och ett dokument för "Konferensprogram".
* **Under arbete**: Uppgifter för att skapa en deltagarlista och skicka inbjudningar.
* **Avslutning**: Ett utvärderingsmöte och en slutrapport.

Projektguider konfigureras i Inställningar och underhåll och kan anpassas efter din organisations specifika arbetsflöden.

## Så fungerar en projektguide

1. **Starta med en status:** När du skapar eller uppdaterar ett projekt med en kopplad projektguide, ställs den första statusen in automatiskt. Detaljkortet **Projektguide** visar de händelser och dokument som är kopplade till denna status.

1. **Skapa aktiviteter:** Varje händelse eller dokument i guiden kan skapas direkt från detaljkortet:
    * Klicka på **Skapa** bredvid händelsen eller dokumentets namn.
    * Många av fälten är redan ifyllda, men du kan ändra informationen eller lägga till mer information. Fyll i de återstående fälten i dialogrutan och spara.

    > [!TIP]
    > Tilldela händelser till teammedlemmar för bättre samarbete. Dialogrutan **Överför uppgiften till en projektdeltagare** visas för vissa händelser.

1. **Markera uppgifter som slutförda:** När en aktivitet är klar markerar du kryssrutan bredvid dess namn i detaljkortet **Projektguide**. Dokument markeras automatiskt som slutförda när de skapas.

    Slutförda aktiviteter visas även i detaljkortet **Aktiviteter**.

1. **Gå vidare till nästa status:** När alla aktiviteter för en status är slutförda, eller vid behov:
    * Flytta projektet till nästa status manuellt eller automatiskt (om det är konfigurerat i **Inställningar och underhåll**).
    * Guiden uppdateras och visar händelser och dokument för den nya statusen.

1. **Fortsätt för alla statusar:** Arbeta igenom varje status, slutför de föreslagna aktiviteterna, tills projektet är avslutat.

> [!NOTE]
> Du kan gå vidare till nästa status utan att slutföra alla händelser för den aktuella statusen.

## <a id="project-guide-tab"></a>Detaljkortet Projektguide

![Detaljkortet Projektguide som visar statusen Planerat -screenshot][img1]

Detaljkortet **Projektguide** ger en strukturerad översikt över projektets fördefinierade statusar, händelser och dokument. Här kan användare enkelt spåra och genomföra uppgifter för att säkerställa att projektet fortskrider enligt plan.

### Viktiga komponenter

* **Statusknappar:** Finns högst upp och representerar de fördefinierade statusarna, såsom **Planerat**, **Under arbete**, **Avslutning** och **Slutfört**.

    ![Projektguidens statusknappar -screenshot][img2]

  * **Aktuell status:** Markeras med en fylld cirkel (<i class="ph ph-circle-fill" aria-hidden="true"></i>).
  * **Framtida statusar:** Markeras med en öppen cirkel (<i class="ph ph-circle" aria-hidden="true"></i>).
  * **Slutförda statusar:** Markeras med en bock (<i class="ph ph-check" aria-hidden="true"></i>).

* **Aktiviteter:** Detaljkortet är uppdelat i två kolumner: **Händelser** och **Dokument**. Varje rad har en **Skapa**-knapp, så att användare kan skapa händelser och dokument direkt från detaljkortet.

    **Milstolpar** identifieras med en diamantsymbol (<i class="ph ph-diamond" aria-hidden="true"></i>). Fältet **Nästa milstolpe** på projektkortet visar automatiskt datumet för nästa milstolpe, vilket hjälper användare att hålla koll på viktiga deadlines.

* **Filter:** Finns längst ner och ger möjlighet att justera visningen:

  * **Endast skapade:** Visar endast slutförda eller pågående händelser och dokument.
  * **Endast milstolpar:** Visar endast milstolpe-händelser.
  * **Visa alla statusar:** Visar alla statusar och deras tillhörande (föreslagna och skapade) händelser och dokument.

### Tips för användning

* **Snabb navigering:** Använd statusknapparna för att fokusera på aktiviteter i en viss fas av projektet.
* **Effektiv spårning:** Markera händelser som slutförda eller skapa uppgifter direkt från detaljkortet.
* **Anpassning:** Justera filtren för att fokusera på milstolpar eller endast skapade aktiviteter.

## Skapa en händelse eller ett dokument

För att skapa en händelse eller ett dokument som är kopplat till en projektguide:

1. Gå till detaljkortet **Projektguide**.
1. Leta upp händelsen eller dokumentet under den aktuella statusen.
1. Klicka på **Skapa** bredvid objektet.

    * För händelser öppnas [Händelse-dialogrutan][7] med förifyllda fält baserat på inställningarna i projektguiden. Anpassa vid behov och klicka på **Spara**.

    * För dokument öppnas [Dokument-dialogrutan][8] med en förvald mall. Fyll i de obligatoriska fälten och klicka på **Spara**.

> [!TIP]
> Du kan skapa flera händelser eller dokument av samma typ genom att högerklicka på ett objekt och välja **Skapa en till**.

## Markera en händelse som slutförd

1. I detaljkortet **Projektguide**, leta upp händelsen.
1. Markera kryssrutan bredvid händelsens namn. Uppgiften markeras som slutförd och visas som färdig i detaljkortet **Aktiviteter**.

Dokument markeras automatiskt som slutförda när de skapas.

## <a id="change-status"></a>Flytta till nästa status

Att flytta projektet genom de olika statusarna är en central funktion i projektguiden. Statusförändringar kan ske automatiskt eller manuellt beroende på dina arbetsflödesbehov.

### Automatisk statusförändring

Om projektguiden är konfigurerad för att föreslå nästa status, öppnas dialogrutan **Projektguide – flytta projektet till nästa status** när alla obligatoriska händelser och dokument för den aktuella statusen har markerats som slutförda.

1. Slutför alla obligatoriska händelser och dokument för den aktuella statusen.
1. När dialogrutan visas, klicka på **Ja** för att flytta till nästa status eller **Nej** för att stanna kvar i den nuvarande statusen.

> [!NOTE]
> Automatisk statusförändring måste vara aktiverad i **Inställningar och underhåll** för att denna funktion ska fungera.

### Manuell statusförändring

Du kan manuellt flytta projektet till nästa status om det behövs, även om inte alla händelser och dokument i den aktuella fasen är slutförda. När du ändrar en status, till exempel från Planerat till Under arbete, markeras den föregående statusen automatiskt som slutförd med en bock i detaljkortet **Projektguide**.

#### Från detaljkortet Projektguide

1. Högerklicka på knappen för den önskade statusen.
1. Välj **Flytta till den här status** från menyn.

#### Från projektkortet

1. Klicka på **Redigera** (<i class="ph ph-pencil-simple" aria-hidden="true"></i>) på projektkortet.
1. Klicka på pilen bredvid fältet **Status** för att öppna listan.
1. Välj den önskade statusen.
1. Klicka på **Spara** för att bekräfta ändringarna.

> [!TIP]
> Du kan också gå tillbaka till en tidigare status genom att följa samma steg.

## Fördelar med att använda projektguider

* Konsekvens: Säkerställer ett enhetligt sätt att hantera projekt över hela teamet.
* Synlighet: Håller hela teamet uppdaterat om aktuell status, nästa steg och viktiga milstolpar.
* Anpassning: Möjlighet att skräddarsy guider för att matcha företagets unika arbetsprocesser.

## Relaterat innehåll

* [Introduktion till projekt][2]
* [Skapa ett projekt][4]
* [Redigera eller inaktivera en projektguide][5]

<!-- Referenced links -->
[2]: index.md
[4]: create.md
[5]: edit.md
[7]: ../../diary/learn/create-follow-up.md
[8]: ../../document/learn/edit.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/project/project-guide-tab.png
[img2]: ../../../media/loc/en/project/guide-statuses.png
