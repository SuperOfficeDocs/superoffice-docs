---
uid: help-nl-webhook-panel
title: Webhooks-paneel
description: Webhooks weergeven, beheren en monitoren vanuit Instellingen en onderhoud.
keywords: webhook-paneel, webhook-status, gedeactiveerde webhook, webhook herstarten, webhooks monitoren
author: digitaldiina
date: 06.16.2026
version: 12.1
content_type: concept
tier: core
category: automation
topic: webhook
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: nl
---

# Webhooks-paneel

Het Webhooks-paneel is de centrale plek voor beheerders en consultants om webhook-abonnementen in SuperOffice te beheren. U vindt het via **Instellingen en onderhoud** > **System design** > **Webhooks**.

Vanuit dit paneel kunt u de status van alle webhooks in één oogopslag bekijken, nieuwe abonnementen aanmaken, bestaande bewerken en webhooks herstellen die automatisch zijn gedeactiveerd wegens leveringsfouten.

![Overzicht van het Webhooks-paneel in Instellingen en onderhoud -screenshot][img1]

## De webhooks-lijst

De lijst toont alle geregistreerde webhooks. U kunt op elke kolom sorteren en filteren.

| Kolom | Beschrijving |
| --- | --- |
| Naam | De weergavenaam van de webhook. |
| Status | Statusbadge die de huidige toestand weergeeft. |
| Aantal gebeurtenissen | Het aantal gebeurtenistypen waarop de webhook is geabonneerd. |
| Doel-URL | De doel-URL of de naam van het CRMScript. |
| Meest recente gebeurtenis | Tijdstempel van de meest recente leveringspoging. |
| Opeenvolgende fouten | Aantal opeenvolgende leveringsfouten in de afgelopen 24 uur. |
| Bijgewerkt door | Wie de webhook het laatst heeft gewijzigd. |

## Statusbadges

Elke webhook heeft een statusbadge die de huidige staat toont.

| Status | Kleur | Betekenis |
| --- | --- | --- |
| Actief | Groen | Actief zonder fouten in de afgelopen 24 uur. |
| Actief met fouten | Oranje | Actief maar met leveringsfouten in de afgelopen 24 uur. |
| Gestopt | Grijs | Handmatig gestopt door een beheerder. |
| Uitgeschakeld | Rood | Automatisch gedeactiveerd door het systeem na 9 opeenvolgende leveringsfouten. |

## Contextmenu-acties

Klik met de rechtermuisknop op een webhook-rij om de volgende acties te openen.

| Actie | Beschrijving |
| --- | --- |
| Bewerken | Opent het webhook-formulier met alle huidige waarden ingevuld. |
| Kopiëren | Maakt een kopie met "(copy)" toegevoegd aan de naam. De kopie wordt aangemaakt in de toestand Gestopt. |
| Activeren/stoppen | Start of stopt de levering voor de webhook. |
| Opnieuw starten | Activeert een gedeactiveerde webhook opnieuw. Alleen zichtbaar als de webhook-status Uitgeschakeld is. |
| Verwijderen | Verwijdert de webhook permanent. Er wordt een bevestiging gevraagd voor verwijdering. |

## Leveringsgeschiedenis

Selecteer een webhook-rij om het detailpaneel te openen. Het tabblad **Gebeurtenissen** toont een leveringslogboek per webhook.

| Kolom | Beschrijving |
| --- | --- |
| Tijdstempel | Wanneer de levering werd geprobeerd. |
| Status | Resultaat van de poging. |
| Pogingen | Aantal leveringspogingen voor deze gebeurtenis. |
| Foutcode | De fout die werd geretourneerd als de levering mislukte. |

U kunt individuele mislukte gebeurtenissen direct vanuit deze lijst opnieuw proberen en de volledige lijst exporteren naar CSV.

## Automatische deactivering en herstel

Als een webhook 9 opeenvolgende leveringsfouten ontvangt, deactiveert het systeem deze automatisch. De rij toont een foutteller (bijvoorbeeld 7/9) en de laatste fout.

Zo herstelt u een gedeactiveerde webhook:

1. Los het probleem op dat de leveringsfouten veroorzaakte.
1. Klik met de rechtermuisknop op de webhook-rij en selecteer **Opnieuw starten**.

De webhook keert terug naar de Actief-status en hervat de normale levering.

## In-app-meldingen

Meldingsontvangers zien een melding in SuperOffice wanneer een webhook automatisch wordt gedeactiveerd. Selecteer de melding om het Webhooks-paneel te openen.

## Gerelateerde inhoud

* [Webhook aanmaken][1]
* [Ontwikkelaarsgids voor webhooks][2]

<!-- Referenced links -->
[1]: create.md
[2]: ../dev/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/admin/admin-system-design-webhook-overview.png
