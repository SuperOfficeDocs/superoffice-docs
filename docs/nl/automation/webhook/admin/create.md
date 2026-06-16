---
uid: help-nl-webhook-create
title: Webhook aanmaken
description: Maak een webhook aan in Instellingen en onderhoud zonder code te schrijven of de API aan te roepen.
keywords: webhook aanmaken, webhook bewerken, melding, gebeurtenis
author: digitaldiina
date: 06.16.2026
version: 12.1
content_type: howto
tier: core
category: automation
topic: webhook
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: nl
---

# Webhook aanmaken

U kunt webhook-abonnementen direct aanmaken en beheren in **Instellingen en onderhoud**, zonder code te schrijven of de API aan te roepen.

> [!NOTE]
> Als u een bestaande webhook wilt bewerken, klikt u met de rechtermuisknop op de webhook-rij in de lijst **Webhooks** en selecteert u **Bewerken**. Het formulier wordt geopend met alle huidige waarden ingevuld.

## Stappen

1. Ga naar **Instellingen en onderhoud** > **System design** en selecteer het tabblad **Webhooks**.

1. Klik op **Toevoegen**.

    ![Nieuw webhook-formulier in Instellingen en onderhoud -screenshot][img1]

1. Voer een **Naam van de webhook** in om de webhook te identificeren (verplicht). Maximaal 100 tekens.

1. U kunt eventueel een **Beschrijving** toevoegen. Dit wordt weergegeven in het Webhooks-paneel.

1. **Gebeurtenissen die deze webhook activeren** (verplicht).

    Selecteer een of meer gebeurtenissen uit de lijst **Gebeurtenis toevoegen**. Elke geselecteerde gebeurtenis verschijnt als een tag. Als u een gebeurtenis wilt verwijderen, selecteert u **x** op de tag.

    > [!TIP]
    > U kunt ook een aangepaste gebeurtenisnaam rechtstreeks in het veld typen en op **Enter** drukken.

1. **Stel de bestemming in** (verplicht).

    Kies waar de webhook moet worden afgeleverd:

    * **Externe URL:** Voer de **Eindpunt-URL** in. De URL moet HTTPS gebruiken en een geldig TLS-certificaat hebben. Het endpoint wordt gevalideerd wanneer u opslaat — een onbereikbare of foutieve URL voorkomt het opslaan. Selecteer **Test verzenden** om de verbinding te verifiëren voor het opslaan.
    * **CRMScript:** Selecteer een script uit de lijst.

1. **Foutmelding** (verplicht).

    Geef aan wie u wilt waarschuwen, hoe u hen kunt bereiken en wanneer de melding moet worden verzonden.

    * **Ontvangers:** Voeg CRM-gebruikers toe of typ externe e-mailadressen. Ontvangers verschijnen als tags.
    * **Melden via:** Selecteer het meldingskanaal.
    * **Melding activeren:** Selecteer een of beide opties:
      * **Bij de eerste fout:** Stuurt een melding de eerste keer dat de webhook er niet in slaagt te leveren.
      * **Wanneer uitgeschakeld:** Stuurt een melding als de webhook automatisch wordt gedeactiveerd na herhaalde fouten.

    ![Webhook-formulier met geconfigureerde gebeurtenissen, bestemming en foutmelding -screenshot][img2]

1. (Optioneel) Vouw **Beveiliging en geavanceerde instellingen** uit.

    * **Gedeeld geheim:** Selecteer **Genereren** om een cryptografisch willekeurige waarde te maken voor het ondertekenen van elke payload. Het secret wordt alleen bij aanmaak weergegeven — kopieer het onmiddellijk. Als u het later wilt vervangen, selecteert u **Regenereren**.
    * **Aangepaste kopteksten:** Sleutel-waardeparen die aan elke HTTP POST worden toegevoegd. Alleen beschikbaar voor Externe URL-webhooks.
    * **Aangepaste eigenschappen:** Aanvullende gegevens die in elke payload worden ingevoegd.

    ![Sectie Beveiliging en geavanceerde instellingen uitgevouwen -screenshot][img3]

1. (Optioneel) Zet de **Actief**-schakelaar uit (rechtsboven) om de webhook op te slaan in de toestand *Gestopt*.

1. Klik op **Opslaan**.

    ![Verzendstatus weergegeven onder de Actief-schakelaar na opslaan -screenshot][img4]

Na het opslaan verschijnt verzendstatusinformatie onder de **Actief**-schakelaar. Klik op **Terug naar Webhooks** bovenaan om terug te keren naar de lijst.

## Gerelateerde inhoud

* [Webhooks-paneel][1]
* [Een webhook registreren via de API][2]
* [Een CRMScript aanmaken][3]

<!-- Referenced links -->
[1]: index.md
[2]: ../dev/register.md
[3]: ../../../customization/macros-and-scripts/admin/create-script.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/automation/new-webhook-required-fields.png
[img2]: ../../../../media/loc/en/automation/create-webhook-in-ui.png
[img3]: ../../../../media/loc/en/automation/webhook-advanced-settings.png
[img4]: ../../../../media/loc/en/automation/webhook-delivery-status.png
