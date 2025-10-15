---
uid: help-sv-ai-copilot
title: SuperOffice Copilot
description: SuperOffice AI-tjänster - Copilot
keywords: AI, ChatGPT, OpenAI, Bing, Copilot
author: digitaldiina, Filip Norman
date: 10.15.2025
version: 11.5
content_type: concept
license: aiplatform
pilot: yes
category: automation
topic: ai
deployment: online
platform: web
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# SuperOffice Copilot

SuperOffice Copilot integrerar smidigt en ChatGPT-liknande användarupplevelse med SuperOffice och tillhandahåller ett kraftfullt AI-verktyg inom CRM-kontexten. Vårt mål är att sömlöst bädda in generativ AI inom SuperOffice CRM, vilket eliminerar behovet av extern appåtkomst samtidigt som ditt arbetsflöde förbättras direkt inom plattformen.

Du kan spara tid och få insikter genom att använda de olika färdiga frågorna (prompts) i skärmbilderna Företag, Kontakt, Kalender, Försäljning, Projekt, Ärende och Urval.

> [!NOTE]
> Denna funktion är tillgänglig genom vårt [AI lab-program][9]. SuperOffice AI är endast tillgängligt i molnet.

## Integritet och GDPR

SuperOffice Copilot vet ingenting om dina kunddata och kommer att ge dig svar med hjälp av en stor språkmodell (LLM) som Bing från Microsoft eller ChatGPT från OpenAI.

## Komma igång

SuperOffice Copilot är tillgängligt i alla skärmbilder med [sidopanelen][1]. Som standard visar sidopanelen en förhandsgranskning av den valda posten.

1. Gå till ett företag, kontakt, kalender, försäljning, projekt, ärende eller urval.

1. Klicka på <i class="ph ph-caret-down" aria-label="Chevron"></i> bredvid sidopanelens namn och välj **SuperOffice Copilot**.

    ![Aktivera SuperOffice Copilot -screenshot][img2]

1. Välj en av de fördefinierade promptarna eller ställ vilken fråga som helst för att få svar från AI-teknologin.

    ![SuperOffice Copilot på en försäljning -screenshot][img3]

1. Efter att AI har genererat ett svar har du följande alternativ:

    * Välj plus- eller minus-ikonen för att få mer eller mindre text.
    * Kopiera resultatet till urklipp.
    * Ställ en annan fråga.
    * Rensa chatten.

    ![SuperOffice Copilot på en försäljning -screenshot][img4]

## Kontext och språk

SuperOffice Copilot använder språket i din SuperOffice-applikation. Om du till exempel har valt *Deutsch* i **Lokala inställningar** kommer AI att svara dig på tyska.

Kontexten är alltid det för närvarande visade objektet. När du till exempel tittar på företaget "SuperOffice AS" berättar AI om SuperOffice. Om du går till "Visma" berättar AI om det företaget istället. Om du byter till **Projekt** återställs chatten och du kan välja projektrelaterade prompts. Och så vidare.

## Tillgängliga prompts

Prompts kan ändras utan föregående meddelande under piloten!

### Företag

* **Företagsdetaljer:** AI berättar om det aktuella företaget.
* **Konkurrenter:** AI presenterar allmän information om konkurrenter och konkurrensanalys.
* **Verksamhet:** AI berättar om den verksamhet som företaget är engagerat i.

### Kontakt

* **Företagsdetaljer:** AI berättar om det aktuella företaget.
* **Kontaktdetaljer:** AI berättar om den aktuella kontakten.
* **Skriv pitch:** AI skriver en pitch riktad mot kontakten.

### Kalender

* **Idag:** AI listar alla dina schemalagda kalenderposter för aktuellt datum.

### Försäljning

* **Företagsdetaljer:** AI berättar om företaget för den aktuella försäljningen.
* **Konkurrenter:** AI presenterar allmän information om konkurrenter och konkurrensanalys.
* **Verksamhet:** AI berättar om den verksamhet som företaget är engagerat i.
* **Förslag:** AI utarbetar ett förslag för försäljningsmöjligheten.

### Projekt

* **Projektplanering:** AI skapar en projektplan för det aktuella projektet.
* **Idéer:** AI ger dig några idéer om saker att överväga för det aktuella projektet baserat på dess titel och beskrivning.

### Ärenden

* **Sammanfatta:** AI analyserar ärendet och ärendemeddelanden, extraherar nyckelinformation och presenterar en kort, sammanhängande sammanfattning.

  * Om ett ärende innehåller 3 eller fler meddelanden kan du välja **Sammanfatta** från **Visa alla** dropdown-menyn i **Meddelanden**-fliken på Ärende-skärmbilden.
  * Om ärendet har mer än 5 meddelanden kommer en separat **Sammanfatta**-knapp också att visas bredvid **Lägg till kommentar**-knappen.

### Urval

* Kommer snart

## Relaterat innehåll

* [Andra AI-tjänster][2]
* [Trust center | GDPR & SuperOffice-produkter][8]

<!-- Referenced links -->
[1]: ../../learn/getting-started/main-screen/side-panel.md
[2]: index.md
[8]: https://www.superoffice.com/trust-center/gdpr-and-crm/
[9]: https://community.superoffice.com/en/product-releases/pilot-programs/current-pilot-programs/ai-lab/

<!-- Referenced image -->
[img2]: ../../../media/loc/en/ai/copilot-in-sidepanel-list.png
[img3]: ../../../media/loc/en/ai/copilot-on-sale.png
[img4]: ../../../media/loc/en/ai/copilot-about-superoffice.png
