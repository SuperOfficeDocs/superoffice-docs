---
uid: help-nl-service-mailbox-create
title: Postbussen maken
description: Postbussen maken
keywords: e-mail
author: digitaldiina
date: 05.04.2026
version: 11.13
content_type: howto
category: email
topic: Service mailbox
license: serviceessentials
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: nl
---

# Postbussen maken

U kunt een postbus maken voor het importeren van e-mailberichten in SuperOffice Service. Voordat u dit doet, moet u een postbus maken op de e-mailserver waarnaar de e-mailberichten worden bezorgd.

> [!NOTE]
> Voordat u een postbus instelt, moet u ervoor zorgen dat er geen oude berichten in deze postbus op de e-mailserver staan. SuperOffice Service importeert alle e-mailberichten in de postbus, hierdoor worden er mogelijk automatische antwoorden verzonden naar alle personen die e-mailberichten naar dit adres hebben gestuurd. Om deze oude e-mails te importeren, moet u de functie voor automatisch beantwoorden uitschakelen. Het gaat om de optie **Niet automatisch antwoorden** in het scherm **Postbuseigenschappen** en de optie **Geen e-mail naar nieuwe personen verzenden** op het tabblad **Instellingen** in het scherm **Systeem** in SuperOffice Service.

## Stappen

1. [!include[Go to email](includes/goto-email.md)]

1. Klik op **Nieuwe postbus**. Het scherm **Postbuseigenschappen** wordt weergegeven met het geopende tabblad **Eigenschappen**.

1. in het veld **Adres** voert u de naam zonder @domein.xx in en drukt u op **TAB** om de instellingen van CRM Online aan het e-mailadres toe te voegen.

    > [!NOTE]
    > Een gebruiksvriendelijk e-mailadres kan aan het adres worden toegevoegd door toevoeging van ("gebruiksvriendelijke naam") aan het einde van het e-mailadres. Voorbeeld: `info@company.com` (Klant B.V.).

1. Selecteer categorie, prioriteit, en verzoektype:

    * In de keuzelijst **Categorie** selecteert u tot welke categorie de berichten in deze postbus behoren.

    * Selecteer in de keuzelijst **Prioriteit** de prioriteit om verzoeken uit deze postbus te geven.

    * Selecteer in de keuzelijst **Verzoektype** het type berichten dat bij deze postbus hoort.

1. [!include[Set customer language](includes/step-set-language.md)]

1. Stel antwoord in:

    1. Selecteer **Niet automatisch antwoorden** om de functie voor automatisch antwoorden uit te schakelen. Zie de opmerking boven aan dit onderwerp.

    1. In het veld **E-mailvelden** kunt u een door komma's gescheiden lijst met e-mailvelden (kopteksten) invoeren die u in het verzoekbericht wilt weergeven (bijvoorbeeld Aan en Cc).

    1. In de keuzelijst **Antwoordsjabloon voor antwoord aan contactpersoon** selecteert u de antwoordsjabloon die u wilt gebruiken voor het verzenden van automatische antwoorden naar de klant.

    1. **Items uit Veelgestelde vragen voorstellen vanuit**: Wanneer u deze optie inschakelt, zal het systeem op basis van de tekst in het inkomende e-mailbericht items voor Veelgestelde vragen voorstellen. De voorgestelde items in Veelgestelde vragen zijn beschikbaar als sjabloonvariabelen en kunnen dus worden hergebruikt in de geselecteerde antwoordsjabloon. U kunt ook aangeven in welke tak van de boomstructuur voor Veelgestelde vragen moet worden gezocht door de map op te geven.

1. **Automatische antwoorden en systeemberichten importeren**: Standaard worden e-mails die niet-aanwezigheidsberichten, systeemberichten en andere irrelevante berichten bevatten, niet geïmporteerd. Als u dergelijke e-mails wilt importeren, kunt u deze optie aanvinken.

1. **AI-diensten**: Hier kunt u de volgende opties selecteren voor categorisering en tekstanalyse met behulp van [AI][4]:

    * **AI gebruiken om categorieën voor te stellen**: Selecteer deze optie om [AI een categorie te laten voorstellen][3] voor verzoeken op basis van de inhoud van e-mailberichten.
    * **Tekstanalyse gebruiken**: Selecteer deze optie om [AI de tekst in e-mailberichten te laten analyseren][2] om taal te detecteren (voor vertaling) en sentimentanalyse uit te voeren.

1. Klik op **OK**. De postbus wordt gemaakt.

## Gerelateerde inhoud

* [Postbussen verwijderen][1]
* [E-mail in Service en Marketing][5]
* [Postbus maken (lokaal)][6]

<!-- Referenced links -->
[1]: delete-mailbox.md
[2]: ../../../ai/learn/text-analysis.md
[3]: ../../../ai/learn/categorization.md
[4]: ../../../ai/learn/index.md
[5]: ../../../../en/online/mail-services/curl/index.md
[6]: https://help.superoffice.com/docs/11/nl/email/admin/mailbox/create-mailbox.html
