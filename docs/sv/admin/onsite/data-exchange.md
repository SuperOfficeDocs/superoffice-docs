---
uid: help-sv-data-exchange
title: Data Exchange
description: Data Exchange
keywords: Data Exchange
author: SuperOffice Product and Engineering
date: 07.10.2025
content_type: reference
category: service
deployment: onsite
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: sv
redirect_from: /sv/automation/crmscript/learn/screen/data-exchange
---

# Data Exchange (endast LOKALT)

[!include[Requirement](../../includes/req-dev-tools.md)]

Det här området används för att konfigurera eventuella databasintegrationer mellan systemet och andra datakällor.

## Agenter

På den här skärmen finns en lista med alla befintliga Data Exchange-agenter (databasintegrering). SuperOffice Service kan anslutas till en eller flera agenter för att synkronisera data med andra databaser.

| Objekt | Beskrivning |
|---|---|
| Ny agent | Används för att skapa en ny agent. |
| Namn | Visar agentens namn. |
| Protokoll | Visar det kommunikationsprotokoll som används för att ansluta till agenten. |

## Egenskaper för agent

På denna skärm kan du visa egenskaperna för en Data Exchange-agent.

| Objekt | Beskrivning |
|---|---|
| Redigera agent | Används för att redigera agentens egenskaper. |
| Ny agentuppgift | Används för att skapa en ny agentuppgift. |
| Redigera fält | Används för att ange vilka fält som ska vara skrivskyddade i SuperOffice Service. |
| Agent | Här visas olika egenskaper för agenten. |
| Namn | Namn på Data Exchange-agenten. |
| Protokoll | Ange vilket protokoll som ska användas för att kommunicera med Data Exchange-agenten. |
| Sökväg/URL | Sökväg eller nätverksadress som används för kommunikation med Data Exchange-agenten. |
| Parametrar | Parametrar som används av CRMScript eller Data Exchange-agenten. |
| Uppgifter | Här visas alla registrerade uppgifter för agenten. Även status visas för varje uppgift. Klicka på en uppgift om du vill redigera den. |
| Fält | Visar alla fält i SuperOffice Service som inte är redigerbara. Klicka på **Redigera fält** om du vill lägga till ett nytt fält. |

## Redigera agent

På denna skärm kan du redigera egenskaperna för en ny eller befintlig Data Exchange-agent. Du kan också skapa tidsplaner för att aktivera agenten i specifika intervall.

| Objekt | Beskrivning |
|---|---|
| Namn | Namn på Data Exchange-agenten. |
| Protokoll | Ange vilket protokoll som ska användas för att kommunicera med Data Exchange-agenten. |
| Sökväg/URL | Sökväg eller URL som används för kommunikation med Data Exchange-agenten. |
| Parametrar | Parametrar som används av CRMScript eller Data Exchange-agenten. |
| OK (Alt-O) | Klicka på denna knapp för att spara. |
| Avbryt | Klicka på denna knapp för att avbryta. |
| Radera | Klicka på denna knapp för att ta bort. |
| Använd | Klicka här för att använda inställningarna. |

## Egenskaper för agenttidsplan

På denna skärm kan du redigera egenskaperna för en ny eller befintlig tidsplan som används av en Data Exchange-agent. Här kan du välja hur ofta agenten ska synkroniseras med SuperOffice.

| Objekt | Beskrivning |
|---|---|
| Namn | Här kan du ange namnet på tidsplanen. |
| ejScript/CRMScript | Här kan du välja vilket CRMScript tidsplanen ska aktivera. |
| Parametrar | Parametrar som används av CRMScript eller Data Exchange-agenten. |
| OK (Alt-O) | Klicka på denna knapp för att spara. |
| Avbryt | Klicka på denna knapp för att avbryta. |
| Radera | Klicka på denna knapp för att ta bort. |
| Återställ | Om agentuppgiften inte stoppar kan du klicka på denna knapp för att återställa den. |
| Stopp | Klicka på denna knapp om du vill stoppa agentuppgiften. |
| Använd | Klicka på denna knapp för att använda inställningarna. |

## Egenskaper för agentfält

På denna skärm kan du ändra egenskaperna för ett fält kopplat till en agent. Fälten som visas är skrivskyddade i SuperOffice Service.

| Objekt | Beskrivning |
|---|---|
| Fältnamn | En lista med namn på databasfält som är skrivskyddade i gränssnittet, till exempel "cust_company.name". |

<!-- Referenced links -->

<!-- Referenced images -->
