---
uid: help-sv-crmscript
title: CRMScript
description: Med funktionen CRMScript kan du automatisera uppgifter i SuperOffice eller ändra programmets beteende.
author: SuperOffice RnD
date: 02.22.2023
keywords: CRMScript
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: sv
redirect_from:
  - /sv/automation/crmscript/learn/macro-script
  - /sv/automation/crmscript/learn/screen/
---

# CRMScript

Med funktionen CRMScript kan du automatisera uppgifter i SuperOffice eller ändra programmets beteende. Genom att automatisera uppgifter och processer sparar du tid och du och dina kollegor blir mer produktiva.

Olika verktyg, makron, skript, utlösare och planerade uppgifter har olika funktioner och används för olika ändamål. Nedan följer en introduktion till det flexibla och kraftfulla inbäddade skriptverktyget CRMScript.

## Öppna CRMScript

Om du vill komma åt funktionerna i CRMScript öppnar du Inställningar och underhåll i SuperOffice och klickar på <i class="ph ph-code-block" aria-hidden="true"></i> **CRMScript** i navigatorn.

Utlösare är skript som körs för specifika händelser i systemet, till exempel när en ny försäljning skapas eller ett ärende stängs. Utlösare kan reagera tyst på vad som händer, eller blockera åtgärden och visa en förklaring för användaren.

## Makron och skript

Under **CRMScript** på fliken **Makron och skript** finns en lista över alla skript och makron i systemet indelade i mappar. Klicka på ett skript eller makro i listan om du vill visa, redigera eller köra det.

### Om makron

Makron är den användarvänliga versionen av skript: Du behöver inte ha betydande kunskaper om skript eller CRMScript för att skapa makron.

Med makron kan du anpassa och automatisera åtgärder i SuperOffice. En användarvänlig guide med en beskrivning om hur du ställer inte makron medföljer.

Makron fyller flera funktioner i SuperOffice. De kan kopplas till specifika [utlösare][2] i systemet (t.ex. eskaleringar eller nya meddelanden i ärenden i SuperOffice) eller tilldelas till knappar i definierade skärmbilder så att användarna kan klicka på en knapp för att utföra ett antal åtgärder som upprepas ofta. Det gör ärendehandläggningen snabbare och användare undviker onödigt klickande.

Du kan till exempel använda makron

* som en uppgift/funktion i en menypunkt (t.ex. i **Åtgärd** i fönstret Ärende)
* när ett ärende eskaleras via varningsnivåerna för prioritet
* som en planerad uppgift
* när de aktiveras av ett e-postfilter
* när en mottagare klickar på en spårad länk i ett utskick.

### Vad är skillnaden mellan ett skript och ett makro?

Ett makro är en uppsättning fördefinierade åtgärder som utförs i en specifik ordning och kan skapas utan programmeringskunskaper.

Ett skript är ett litet program som har skrivits för att utföra specifika uppgifter och kräver programmeringskunskaper för att skapas.

### Fliken Makron och skript

Så här går du till fliken **Makron och skript**:

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Klicka på **CRMScript** och gå till fliken **Makron och skript**.

På skärmen finns följande alternativ:

| Alternativ | Beskrivning |
|---|---|
| Nytt skript | Används för att [skapa ett nytt skript][8]. |
| Nytt makro | Används för att [skapa ett nytt makro][9]. |
| Ny mapp | Används för att [skapa en ny mapp][10]. |
| Sök | Används för att söka efter makron och skript i de valda mapparna och undermapparna. |

#### Fönstret Skript

När du klickar på ett skript eller makro på fliken **Makron och skript** öppnas skärmen **Skript**. Utöver den information som visas längst upp på skärmen finns det mer skriptinformation på flikarna **Beskrivning** och **Skript**.

**Alternativ:**

| Ikon | Alternativ | Beskrivning |
|---|---|---|
| | Makron och skript | Används för att återgå till listan över skript och makron. |
| <i class="ph ph-pencil-simple" aria-label="Edit"></i> | Redigera skript | Används för att redigera skriptet eller makrot. |
| <i class="ph ph-play" aria-label="Play"></i> | Kör skript | Används för att köra skriptet eller makrot i standardläge. |
| <i class="ph ph-bug" aria-label="Bug"></i> | Felsök skript | Används för att öppna **felsökningsfönstret** och köra det valda skriptet eller makrot i felsökningsläge. Skriptet avbryts vid första raden. Du kan öppna en [felsökningssession][4] på fliken **Felsökningssessioner**. |
| | Spåra skript | Används för att starta en [spårning av skriptet eller makrot][5]. |

## Flikar

* [Makron och skript][8] – Skapa makron och skript för att automatisera planerade uppgifter i SuperOffice.
* [Utlösare][2] – Definiera att en viss händelse i systemet ska utlösa en eller flera fördefinierade åtgärder.
* [Planerade uppgifter][3] – Ange att ett skript eller makro ska köras en viss tidpunkt.
* [Felsökningssessioner][4] – Hitta och korrigera buggar i skript och makron.
* [Spårning][5] – Registrera varje detalj i körningen av ett skript eller makro och spara i en logg.

## Relaterat innehåll

* [Skapa skript][8]
* [Skapa makro][9]
* [Skapa mapp][10]
* [Lär dig CRMScript-språket][6]
* [API-referens i CRMScript][7]

<!-- Referenced links -->
[2]: trigger.md
[3]: schedule-task.md
[4]: debug.md
[5]: tracing.md
[6]: ../../../../en/automation/crmscript/overview/index.md
[7]: ../../../../en/automation/crmscript/reference/index.md
[8]: create-script.md
[9]: create-macro.md
[10]: create-script.md#folder
