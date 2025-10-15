---
uid: help-nl-erp-admin
title: ERP-synchronisatie beheren
description: Inleiding tot het configureren van synchronisatie tussen SuperOffice CRM en externe ERP-systemen.
keywords: ERP-tabblad, ERP-systeem, ERP-actor, Sync Connector, ERP-verbinding, synchronisatie, connector, verbinding, Offerte/Synchroniseren-scherm, ERP
author: Bergfrid Dias
date: 03.31.2025
version: 10.5
content_type: concept
license: development-tools
audience: settings
audience_tooltip: Instellingen en onderhoud
language: nl
redirect_from: /nl/quote/learn/admin/sync/index
index: true
---

# ERP-synchronisatie beheren

Het tabblad **Synchroniseren** in het scherm Offerte/Synchroniseren binnen **Instellingen en onderhoud** toont de Sync Connectors en ERP-verbindingen die integratie tussen SuperOffice CRM en externe ERP-systemen mogelijk maken.

[!include[Requirement](../../includes/req-dev-tools.md)]

## Terminologie

| Term | Beschrijving |
|---|---|
| **Sync Connector** | De integratiecomponent die SuperOffice CRM verbindt met een extern ERP-systeem. Elke connector verwijst naar een specifiek ERP-systeem. |
| **ERP-verbinding** | Een configuratie die een Sync Connector gebruikt om te definiëren wat er wordt gesynchroniseerd, hoe authenticatie verloopt en welke ERP-client wordt aangesproken. U kunt meerdere verbindingen per connector hebben. |
| **ERP-actor** | Een record in het ERP-systeem die gekoppeld kan worden aan een element in SuperOffice CRM. |
| **CRM-element** | Een record in SuperOffice CRM – meestal een bedrijf, contactpersoon of project – die kan worden gekoppeld aan een ERP-actor. |

U kunt het tabblad **Synchroniseren** gebruiken om verbindingen toe te voegen, te configureren en te prioriteren.

## Wat ERP-synchronisatie mogelijk maakt

Als de ERP-integratie correct is geconfigureerd, krijgen gebruikers toegang tot het tabblad **ERP** in de schermen **Bedrijf**, **Persoon** en **Project** in SuperOffice CRM.

Vanuit dit tabblad kunnen gebruikers:

* SuperOffice-records koppelen aan bijbehorende actoren in het ERP-systeem.
* Gesynchroniseerde velden en waarden uit het ERP-systeem bekijken.

Dit helpt dubbele invoer te verminderen en de gegevensconsistentie tussen systemen te verbeteren.

> [!NOTE]
> Het tabblad **ERP** is alleen zichtbaar voor gebruikers met de juiste licentie en toegang tot een actieve ERP-verbinding.

## Gerelateerde inhoud

* [Een Sync Connector toevoegen en een ERP-verbinding definiëren][1]
* [Een ERP-verbinding bewerken][7]
* [Veldtoewijzing en standaardwaarden configureren][4]
* [Synchronisatieprioriteit instellen][3]
* [Importeren uit ERP][9]

<!-- Referenced links -->
[1]: add-connection.md
[3]: configure.md#priority
[4]: configure.md
[7]: update-connection.md
[9]: ../../admin/import/from-erp.md
