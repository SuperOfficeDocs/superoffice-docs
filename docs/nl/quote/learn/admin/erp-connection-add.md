---
uid: help-nl-erp-connection-add
title: ERP-verbinding toevoegen
description: ERP-verbinding toevoegen
author: SuperOffice RnD
date: 06.29.2022
keywords: offerte, ERP, connector
topic: howto
language: nl
---

# ERP-verbinding toevoegen (Quote Connector)

Elke Quote Connector moet beschikken over een ERP-verbinding met configuratiegegevens om de Quote Connector te koppelen met SuperOffice.

Hoe stel ik een ERP-verbinding in voor SuperOffice CRM for Web (online)?

[!include[How to set up ERP](includes/set-up-erp.md)]

## U voegt een ERP-verbinding als volgt toe

1. Ga naar het tabblad **ERP-verbindingen** op het scherm Offerte/Synchroniseren.

1. Klik op **Toevoegen** onder aan de lijst **ERP-verbindingen**. Het dialoogvenster **Een nieuwe ERP-verbinding definiëren** wordt weergegeven.

1. Geef de naam van de ERP-verbinding op in het veld **Naam**.

1. Selecteer de vereiste **Quote Connector** in de lijst. Deze lijst is identiek aan **Beschikbare Quote Connectors**.

1. Selecteer een **Reikwijdte**:

    * **Alles**: Selecteer deze optie als alle gebruikers toegang moeten hebben tot deze ERP-verbinding en deze mogen gebruiken. Dit betekent dat ze de prijslijsten kunnen gebruiken die toegankelijk zijn via deze verbinding.
    * **Specifieke gebruikers + groepen**: Klik op **Gebruikers en groepen selecteren** om te kiezen welke gebruikersgroepen en/of gebruikers toegang moeten hebben tot deze ERP-verbinding.

1. Selecteer de ERP-verbinding waarmee u de synchronisatie ([Synchronisatieverbinding][1]) wilt uitvoeren in het veld **ERP-verbinding**.

1. Configureer de vereiste instellingen onder aan het dialoogvenster. De inhoud van deze lijst varieert, afhankelijk van het type Quote Connector dat u hebt gekozen.

1. Type een beschrijving van de ERP-verbinding in het veld onderaan.

1. Klik op **ERP-verbinding testen** om te controleren of de verbinding werkt.

1. Klik op **OK**.

## Verwijderen en herstellen

Onder aan de lijst **ERP-verbindingen** kunt u ERP-verbindingen verwijderen die niet langer in gebruik zijn.

Om een verwijderde ERP-verbinding te herstellen:

1. Vink **Verwijderd aan**.
1. Selecteer de verwijderde verbinding in de lijst.
1. Klik op **Herstellen**.

<!-- Referenced links -->
[1]:sync/index.md

<!-- Referenced images -->
