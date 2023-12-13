---
uid: help-sv-service-mailbox-create
title: Skapa brevlåda
description: Skapa brevlåda
author: SuperOffice RnD
so.date: 12.12.2023
so.version: 10.2.11
keywords: e-post
so.topic: howto
language: sv
---

# Skapa brevlåda

Du kan skapa en brevlåda som ska användas för att importera e-post till SuperOffice Service. Innan du kan göra detta måste du skapa en brevlåda på den e-postserver som e-posten levereras till.

> [!NOTE]
> Innan du konfigurerar en brevlåda måste du kontrollera att det inte finns gamla meddelanden i denna brevlåda på e-postservern. SuperOffice Service importerar all e-post i brevlådan och du riskerar att skicka autosvar till alla kontakter som har skickat e-post till adressen. Om du vill importera dessa gamla e-postmeddelanden bör du inaktivera autosvarfunktionen. Först och främst gäller detta alternativet **Skicka inte automatiskt svar** i fönstret **Egenskaper för brevlåda** och alternativet **Skicka inte e-post till nya kontakter** på fliken **Inställningar** i fönstret **System** i SuperOffice Service.

## Så skapar du en ny brevlåda – online

1. [!include[Go to email](includes/goto-email.md)]

1. Klicka på **Ny brevlåda**. Skärmen **Egenskaper för brevlåda** visas med fliken **Egenskaper** öppen.

1. I fältet **Adress** anger du namnet utan @domän.xx och trycker på **tabbtangenten** för att lägga till CRM Online-inställningarna till e-postadressen.

    > [!NOTE]
    > En vänlig e-postadress kan läggas till på adressen genom att ("vänligt namn") läggs till i slutet av e-postadressen. Exempel: <info@company.com> (Kund AB).

1. Välj kategori, prioritet, och ärendetyp:

    [!include[Select category and priority](includes/step-select-category-priority.md)]

1. [!include[Set customer language](includes/step-set-language.md)]

1. Ange svar:

    [!include[Common steps](includes/step-set-reply.md)]

1. [!include[Import stuff](includes/step-import.md)]

1. **AI-tjänster**: Här kan du välja följande alternativ för kategorisering och textanalys med [AI][4]:

    * **Använd AI för att föreslå kategorier**: Välj det här alternativet om du vill [låta AI:n föreslå en kategori][3] för ärenden baserat på innehållet i e-postmeddelanden.
    * **Använd textanalys**: Välj det här alternativet om du vill [låta AI:n analysera texten][2] i e-postmeddelanden för att identifiera språk (för översättning) och utföra sentimentanalys.

1. Klicka på **OK**. Brevlådan skapas.

## Så skapar du en ny brevlåda – lokalt

1. [!include[Go to email](includes/goto-email.md)]

1. Klicka på **Ny brevlåda**. Skärmen **Egenskaper för brevlåda** visas med fliken **Egenskaper** öppen.

1. I fältet **Adress** anger du den e-postadress du vill använda för brevlådan.

    > [!NOTE]
    > Konfigurera vidarebefordran till denna e-postadress om du tänker använda ditt företags e-postadress (till exempel <info@company.com>). Använd **Adress för vidarebefordran** på skärmen **Brevlådor**.

1. I listrutan **Protokoll** väljer du vilket protokoll som ska användas för att kommunicera med e-postservern. Några av protokollen kan behöva ytterligare konfigurering.

1. I fältet **E-postserver** anger du e-postserverns värdnamn.

1. I fälten **Användarnamn** och **Lösenord** skriver du in användarnamnet och lösenordet till brevlådan.

1. I fältet **Mapp** skriver du namnet på brevlådans mapp på servern.

1. I fältet **Port** kan du ändra den föreslagna standardporten för det valda protokollet.

1. Välj kategori, prioritet, och ärendetyp:

    [!include[Select category and priority](includes/step-select-category-priority.md)]

1. I listrutan **Intervall** väljer du hur ofta SuperOffice Service ska kontrollera om det finns meddelanden i brevlådan.

1. [!include[Set customer language](includes/step-set-language.md)]

1. Ange svar:

    [!include[Common steps](includes/step-set-reply.md)]

1. Gå till fliken **Alias**. Här kan du ange ett e-postalias för en brevlåda (till exempel om <sales@company.com> och <sale@company.com> går till samma brevlåda). Du lägger till ett alias genom att ange en e-postadress och sedan klicka på ![ikon][img1].

1. [!include[Import stuff](includes/step-import.md)]

1. Klicka på **OK**. Brevlådan skapas.

## Vad vill du göra nu?

* [Ta bort brevlådor][1]

<!-- Referenced links -->
[1]: delete-mailbox.md
[2]: ../../../ai/learn/text-analysis.md
[3]: ../../../ai/learn/categorization.md
[4]: ../../../ai/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/btn-add.png
