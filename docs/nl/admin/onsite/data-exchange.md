---
uid: help-nl-data-exchange
title: Gegevensuitwisseling
description: Gegevensuitwisseling
keywords: Gegevensuitwisseling
author: SuperOffice Product and Engineering
date: 07.10.2025
content_type: reference
category: service
deployment: onsite
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: nl
redirect_from: /nl/automation/crmscript/learn/screen/data-exchange
---

# Gegevensuitwisseling (alleen op LOCATIE)

[!include[Requirement](../../includes/req-dev-tools.md)]

Dit gebied wordt gebruikt om database-integraties tussen het systeem en andere gegevensbronnen te configureren.

## Agenten

Dit scherm bevat een lijst met bestaande Data Exchange (database-integrator)-agents. SuperOffice Service kan worden verbonden met een of meer agents om te synchroniseren met andere databases.

| Element | Beschrijving |
|---|---|
| Nieuwe agent | Wordt gebruikt om een nieuwe agent te maken. |
| Naam | geeft de naam van de agent weer. |
| Protocol | geeft het communicatieprotocol voor verbinding met de agent weer. |

## Eigenschappen agent

Dit scherm toont de eigenschappen van een Gegevensuitwisselingsagent.

| Element | Beschrijving |
|---|---|
| Agent bewerken | Wordt gebruikt om de agenteigenschappen te bewerken. |
| Nieuwe taak voor agent | Wordt gebruikt om een nieuwe agenttaak te maken. |
| Velden bewerken | Wordt gebruikt om aan te geven welke velden niet mogen worden gewijzigd in SuperOffice Service. |
| Agent | dit venster bevat verschillende eigenschappen voor de agent. |
| Naam | Naam van de Gegevensuitwisselingsagent. |
| Protocol | Selecteer het protocol voor communicatie met de Gegevensuitwisselingsagent. |
| Pad/URL | pad of netwerkagent voor communicatie met de Gegevensuitwisselingsagent. |
| Parameters | parameters die worden gebruikt door CRMScript of de Gegevensuitwisselingsagent. |
| Taken | dit venster bevat alle geregistreerde taken voor deze agent. De status van elke taak wordt ook weergegeven. Klik op een taak om deze te bewerken. |
| Velden | Hier ziet u alle velden in SuperOffice Service die niet bewerkbaar zijn. Klik op **Velden bewerken** om een nieuw veld toe te voegen. |

## Agent bewerken

Via dit scherm kunt u de eigenschappen van een nieuwe of bestaande Gegevensuitwisselingsagent. U kunt ook schema's maken om de agent met bepaalde intervallen te activeren.

| Element | Beschrijving |
|---|---|
| Naam | Naam van de Gegevensuitwisselingsagent. |
| Protocol | Selecteer het protocol voor communicatie met de Gegevensuitwisselingsagent. |
| Pad/URL | Pad of URL voor communicatie met de Gegevensuitwisselingsagent. |
| Parameters | parameters die worden gebruikt door CRMScript of de Gegevensuitwisselingsagent. |
| OK (Alt-O) | Klik op deze knop om op te slaan. |
| Annuleren | Klik op deze knop om te annuleren. |
| Verwijderen | Klik op deze knop om te verwijderen. |
| Toepassen | Selecteren om deze instellingen te gebruiken. |

## Eigenschappen agentschema

Via dit scherm kunt u de eigenschappen van een nieuw of bestaand schema voor een Gegevensuitwisselingsagent wijzigen. Hier kunt u instellen hoe vaak de agent wordt gesynchroniseerd met SuperOffice.

| Element | Beschrijving |
|---|---|
| Naam | hier kunt u de naam van het schema invoeren. |
| ejScript/CRMScript | Hier kunt u de CRMScript selecteren die door het schema wordt geactiveerd. |
| Parameters | parameters die worden gebruikt door CRMScript of de Gegevensuitwisselingsagent. |
| OK (Alt-O) | Klik op deze knop om op te slaan. |
| Annuleren | Klik op deze knop om te annuleren. |
| Verwijderen | Klik op deze knop om te verwijderen. |
| Herstellen | wanneer de uitvoering van de agenttaak niet wordt gestopt, klikt u op deze knop om de taak opnieuw in te stellen. |
| Stoppen | klik op deze knop om de agenttaak te stoppen. |
| Toepassen | klik op deze knop om de instellingen te gebruiken. |

## Eigenschappen agentveld

Via dit scherm kunt u de eigenschappen bewerken van een veld dat is gekoppeld aan een agent. De velden die worden weergegeven zijn alleen-lezen in SuperOffice Service.

| Element | Beschrijving |
|---|---|
| Veldnamen | Een lijst met databaseveldnamen die alleen-lezen zijn in de interface, bijvoorbeeld 'cust-company.name'. |

<!-- Referenced links -->

<!-- Referenced images -->
