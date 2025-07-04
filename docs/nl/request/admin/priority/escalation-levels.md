---
uid: help-nl-request-escalation
title: Escalatieniveaus
description: Escalatieniveaus
keywords: verzoek, prioriteit, escaleren
author: Bergfrid Dias
date: 03.14.2025
version: 10.5.2
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
redirect_from: /nl/request/learn/priority/escalation-levels
index: true
---

# Escalatieniveaus

Voor elke verzoek**prioriteit** kunt u een of meer escalatieniveaus definiëren, zodat het systeem het verzoek automatisch door de organisatie routeert wanneer dat niet binnen een bepaalde tijd wordt gelezen of behandeld.

[!include[Restricted access](../../../learn/includes/note-insufficient-rights.md)]

## Definiëren van nieuwe niveaus

1. Klik op de knop **Verzoeken** in de navigator en selecteer het tabblad **Prioriteiten**.

1. Selecteer een prioriteit waarvoor u escalatieniveaus wilt creëren.

1. Selecteer het tabblad **Escalatieniveaus**.

1. Klik op de knop **Toevoegen**. U creëert nu het eerste escalatieniveau.

1. Voer de volgende informatie in:

    * **Vindt plaats na**
    * **Toewijzen aan**
    * **Script uitvoeren**

    Details over elk veld worden hieronder gespecificeerd.

1. Onder **Antwoordsjabloon verzenden** kunt u bepalen wie een e-mail en SMS moet ontvangen wanneer dit escalatieniveau wordt geactiveerd.

    Schakel de selectievakjes voor **E-mail** of **SMS** naast elke ontvanger in en selecteer de relevante antwoordsjabloon. Als u **Anderen** selecteert, moet u de relevante e-mailadressen (gebruik komma's) en telefoonnummers invoeren in de onderstaande velden.

    > [!NOTE]
    > Wanneer het tabblad **Antwoordsjabloon per SMS verzenden naar** niet zichtbaar is, is de SMS-module niet ingeschakeld voor de licentie die u gebruikt. Neem contact op met uw systeembeheerder voor meer informatie.

1. Klik op **Opslaan**.

1. Herhaal deze stappen om extra escalatieniveaus te creëren.

1. Als u meerdere escalatieniveaus hebt gemaakt, kunt u de volgorde bepalen waarin ze moeten worden geactiveerd met behulp van de pijlknoppen onder de lijst met escalatieniveaus.

## Escalatie-instellingen

| Instelling | Beschrijving |
|---|---|
| Prioriteit | De prioriteit op die u aan het escalatieniveau wilt koppelen. |
| Vindt plaats na | Hoeveel tijd er moet verstrijken voordat dit escalatieniveau wordt ingeschakeld. Als de prioriteit zo is gedefinieerd dat escalatie moet overeenkomen met de tijdsperiode, heeft dat invloed op de hier ingevoerde tijd. Een prioriteit met de tijdsperiode maandag - vrijdag, 09.00 tot 17.00 en eerste escalatieniveau na 2 uur, wordt op maandag om 10.00 geëscaleerd wanneer het verzoek op de voorafgaande vrijdag om 16.00 is geregistreerd. |
| Toewijzen aan | Schakel deze optie in als u wilt dat het verzoek naar een andere gebruiker wordt doorgestuurd wanneer dit escalatieniveau wordt bereikt. Selecteer dan de gewenste gebruiker in de lijst. |
| Script uitvoeren | Schakel deze optie in als u wilt dat een script wordt uitgevoerd wanneer dit escalatieniveau wordt bereikt. Selecteer vervolgens het gewenste script in de lijst. |

## Instellingen antwoordsjabloon

| Instelling | Beschrijving |
|---|---|
| Persoon | Indien ingeschakeld, wordt de in het rechterveld opgegeven antwoordsjabloon naar de persoon voor het verzoek verzonden wanneer dit escalatieniveau wordt bereikt. Selecteer de gewenste antwoordsjabloon in de lijst. |
| Eigenaar van verzoek | Indien ingeschakeld, wordt de in het rechterveld opgegeven antwoordsjabloon naar de eigenaar van het verzoek verzonden wanneer dit escalatieniveau wordt bereikt. Selecteer de gewenste antwoordsjabloon in de lijst. |
| Categoriebeheerder | Indien ingeschakeld, wordt de in het rechterveld opgegeven antwoordsjabloon naar de categoriebeheerder verzonden wanneer dit escalatieniveau wordt bereikt. Selecteer de gewenste antwoordsjabloon in de lijst. |
| Anderen | Indien ingeschakeld, wordt de in het rechterveld opgegeven antwoordsjabloon naar het e-mailadres in het veld eronder verzonden. Selecteer de gewenste antwoordsjabloon in de lijst. |
| E-mailadres | Voer hier het e-mailadres in waarnaar de antwoordsjabloon in het veld **Anderen** moet worden verzonden. U kunt desgewenst meerdere adressen opgeven, gescheiden door komma's. |

## Escalatieniveau verwijderen

1. Selecteer het escalatieniveau dat u wilt verwijderen.
2. Klik op de knop **Verwijderen** onder in het scherm.
