---
uid: help-sv-status-screen
title: Fönstret Status
description: Fönstret Status
author: SuperOffice RnD
date: 06.29.2022
keywords: Inställningar för Windows-klient
content_type: concept
language: sv
platform: win
deployment: onsite
---

# Fönstret Status

Uppdaterad information om systemet visas i fönstret **Status**. Fönstret **Status** är indelad i följande tre huvuddelar:

## Databas

Här visas databasens ägare, serienummer och typ som anges vid installation. Här anges också om det är en central databas eller en satellitdatabas. Du kan även se nästa utgångsdatum (när licenser måste förnyas) och namnet på den inloggade användaren.

**Tabelladministration: Lokal databasanvändare**: Ange användarnamn och lösenord för databasanvändaren (det behöver inte vara en SuperOffice CRM-användare) som automatiskt ska användas av systemet för att skapa och ta bort databastabeller. Den här användaren behöver inte ha några andra rättigheter.

> [!NOTE]
> För Oracle-databaser måste detta vara samma användare som äger tabellerna och som används som prefix i **SuperOffice.ini**.

## Statistik

Visar hur många användare som för närvarande är inloggade, när den senaste prototypen genererades och antalet aktiva Travel-användare.
