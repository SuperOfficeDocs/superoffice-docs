---
uid: help-nl-service-mailbox-create
title: Postbussen maken
description: Postbussen maken
author: SuperOffice RnD
so.date: 12.12.2023
so.version: 10.2.11
keywords: e-mail
so.topic: howto
language: nl
---

# Postbussen maken

U kunt een postbus maken voor het importeren van e-mailberichten in SuperOffice Service. Voordat u dit doet, moet u een postbus maken op de e-mailserver waarnaar de e-mailberichten worden bezorgd.

> [!NOTE]
> Voordat u een postbus instelt, moet u ervoor zorgen dat er geen oude berichten in deze postbus op de e-mailserver staan. SuperOffice Service importeert alle e-mailberichten in de postbus, hierdoor worden er mogelijk automatische antwoorden verzonden naar alle personen die e-mailberichten naar dit adres hebben gestuurd. Om deze oude e-mails te importeren, moet u de functie voor automatisch beantwoorden uitschakelen. Het gaat om de optie **Niet automatisch antwoorden** in het scherm **Postbuseigenschappen** en de optie **Geen e-mail naar nieuwe personen verzenden** op het tabblad **Instellingen** in het scherm **Systeem** in SuperOffice Service.

## Een nieuw postvak maken - online

1. [!include[Go to email](includes/goto-email.md)]

1. Klik op **Nieuwe postbus**. Het scherm **Postbuseigenschappen** wordt weergegeven met het geopende tabblad **Eigenschappen**.

1. in het veld **Adres** voert u de naam zonder @domein.xx in en drukt u op **TAB** om de instellingen van CRM Online aan het e-mailadres toe te voegen.

    > [!NOTE]
    > Een gebruiksvriendelijk e-mailadres kan aan het adres worden toegevoegd door toevoeging van ("gebruiksvriendelijke naam") aan het einde van het e-mailadres. Voorbeeld: <info@company.com> (Klant B.V.).

1. Selecteer categorie, prioriteit, en verzoektype:

    [!include[Select category and priority](includes/step-select-category-priority.md)]

1. [!include[Set customer language](includes/step-set-language.md)]

1. Stel antwoord in:

    [!include[Common steps](includes/step-set-reply.md)]

1. [!include[Import stuff](includes/step-import.md)]

1. **AI-diensten**: Hier kunt u de volgende opties selecteren voor categorisering en tekstanalyse met behulp van [AI][4]:

    * **AI gebruiken om categorieën voor te stellen**: Selecteer deze optie om [AI een categorie te laten voorstellen][3] voor verzoeken op basis van de inhoud van e-mailberichten.
    * **Tekstanalyse gebruiken**: Selecteer deze optie om [AI de tekst in e-mailberichten te laten analyseren][2] om taal te detecteren (voor vertaling) en sentimentanalyse uit te voeren.

1. Klik op **OK**. De postbus wordt gemaakt.

## Een nieuw postvak maken - lokaal

1. [!include[Go to email](includes/goto-email.md)]

1. Klik op **Nieuwe postbus**. Het scherm **Postbuseigenschappen** wordt weergegeven met het geopende tabblad **Eigenschappen**.

1. Voer in het veld **Adres** het e-mailadres in dat u wilt gebruiken voor de postbus.

    > [!NOTE]
    > Stel doorsturen in naar dit postbusadres als u het e-mailadres van uw bedrijf gaat gebruiken (bijvoorbeeld <info@company.com>). Gebruik **Doorstuuradres** in het scherm **Postbussen**.

1. Selecteer in de keuzelijst **Protocol** het protocol dat moet worden gebruikt voor communicatie met de e-mailserver. Voor sommige protocollen is mogelijk verdere configuratie vereist.

1. Voer in het veld **E-mailserver** de hostnaam van de server in.

1. Voer in de velden **Gebruikersnaam** en **Wachtwoord** de gebruikersnaam en het wachtwoord voor de postbus in.

1. Typ in het veld **Map** de mapnaam voor de postbus op de server.

1. In het veld **Poort** kunt u de voorgestelde standaardpoort voor het geselecteerde protocol wijzigen.

1. Selecteer categorie, prioriteit, en verzoektype:

    [!include[Select category and priority](includes/step-select-category-priority.md)]

1. In de keuzelijst **Interval** kunt u selecteren hoe vaak SuperOffice Service berichten moet ophalen voor deze postbus.

1. [!include[Set customer language](includes/step-set-language.md)]

1. Stel antwoord in:

    [!include[Common steps](includes/step-set-reply.md)]

1. Ga naar het tabblad **Alias**. Hier kunt u elke e-mailalias voor een postvak invoeren (bijvoorbeeld als <sales@company.com> en <sale@company.com> ga naar hetzelfde postvak). U voegt een alias toe door een e-mailadres in te vullen en vervolgens op ![pictogram][img1] te klikken.

1. [!include[Import stuff](includes/step-import.md)]

1. Klik op **OK**. De postbus wordt gemaakt.

## Wat wilt u nu doen?

* [Postbussen verwijderen][1]

<!-- Referenced links -->
[1]: delete-mailbox.md
[2]: ../../../ai/learn/text-analysis.md
[3]: ../../../ai/learn/categorization.md
[4]: ../../../ai/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/btn-add.png
