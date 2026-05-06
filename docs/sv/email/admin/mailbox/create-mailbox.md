---
uid: help-sv-service-mailbox-create
title: Skapa brevlåda
description: Skapa brevlåda
keywords: e-post
author: digitaldiina
date: 11.27.2025
version: 11.6
content_type: howto
category: email
topic: Service mailbox
license: serviceessentials
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: sv
---

# Skapa brevlåda

Du kan skapa en brevlåda som ska användas för att importera e-post till SuperOffice Service. Innan du kan göra detta måste du skapa en brevlåda på den e-postserver som e-posten levereras till.

> [!NOTE]
> Innan du konfigurerar en brevlåda måste du kontrollera att det inte finns gamla meddelanden i denna brevlåda på e-postservern. SuperOffice Service importerar all e-post i brevlådan och du riskerar att skicka autosvar till alla kontakter som har skickat e-post till adressen. Om du vill importera dessa gamla e-postmeddelanden bör du inaktivera autosvarfunktionen. Först och främst gäller detta alternativet **Skicka inte automatiskt svar** i fönstret **Egenskaper för brevlåda** och alternativet **Skicka inte e-post till nya kontakter** på fliken **Inställningar** i fönstret **System** i SuperOffice Service.

## Steg

1. [!include[Go to email](includes/goto-email.md)]

1. Klicka på **Ny brevlåda**. Skärmen **Egenskaper för brevlåda** visas med fliken **Egenskaper** öppen.

1. I fältet **Adress** anger du namnet utan @domän.xx och trycker på **tabbtangenten** för att lägga till CRM Online-inställningarna till e-postadressen.

    > [!NOTE]
    > En vänlig e-postadress kan läggas till på adressen genom att ("vänligt namn") läggs till i slutet av e-postadressen. Exempel: `info@company.com` (Kund AB).

1. Välj kategori, prioritet, och ärendetyp:

    * I listrutan **Kategori** väljer du vilken kategori meddelandena i den här brevlådan ska höra till.

    * I listrutan **Prioritet** väljer du vilken prioritet ärenden från den här brevlådan ska få.

    * I listrutan **Ärendetyp** väljer du typen av meddelanden som hör hemma i den här brevlådan.

1. [!include[Set customer language](includes/step-set-language.md)]

1. Ange svar:

    1. Markera **Skicka inte automatiskt svar** om du vill inaktivera den automatiska svarsfunktionen. Se anmärkningen högst upp i det här avsnittet.

    1. I fältet **E-postfält** kan du lägga in en kommaseparerad lista med e-postfält (sidhuvud) som ska visas i ärendemeddelandet, till exempel Till och Kopia.

    1. I listrutan **Svarsmall för svar till kund** väljer du vilken svarsmall som ska användas för autosvar till kunden.

    1. **Föreslå FAQ-poster från**: Om du markerar det här alternativet föreslår systemet FAQ-poster baserat på texten i inkommande e-postmeddelanden. De föreslagna FAQ-posterna blir tillgängliga som mallvariabler och kan därför upprepas i den valda svarsmallen. Du kan även specificera vilken gren av FAQ-trädet sökningen ska göras i, genom att specificera önskad mapp.

1. **Importera automatiska svar och systemmeddelanden**: Som standard importeras inte e-postmeddelanden som innehåller meddelanden, systemmeddelanden och andra irrelevanta meddelanden. Om du vill importera sådana e-postmeddelanden kan du markera det här alternativet.

1. **AI-tjänster**: Här kan du välja följande alternativ för kategorisering och textanalys med [AI][4]:

    * **Använd AI för att föreslå kategorier**: Välj det här alternativet om du vill [låta AI:n föreslå en kategori][3] för ärenden baserat på innehållet i e-postmeddelanden.
    * **Använd textanalys**: Välj det här alternativet om du vill [låta AI:n analysera texten][2] i e-postmeddelanden för att identifiera språk (för översättning) och utföra sentimentanalys.

1. Klicka på **OK**. Brevlådan skapas.

## Relaterat innehåll

* [Ta bort brevlådor][1]
* [E-post i Service och Marketing][5]
* [Skapa brevlåda (lokalt)][6]

<!-- Referenced links -->
[1]: delete-mailbox.md
[2]: ../../../ai/learn/text-analysis.md
[3]: ../../../ai/learn/categorization.md
[4]: ../../../ai/learn/index.md
[5]: ../../../../en/online/mail-services/curl/index.md
[6]: https://help.superoffice.com/docs/11/sv/email/admin/mailbox/create-mailbox.html
