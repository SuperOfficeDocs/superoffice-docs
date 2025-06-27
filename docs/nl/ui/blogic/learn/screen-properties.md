---
uid: help-nl-service-screen-properties
title: Schermeigenschappen
description: Schermeigenschappen
author: SuperOffice RnD
date: 06.29.2022
keywords: scherm
content_type: reference
language: nl
---

# Schermeigenschappen

Hier kunt u de eigenschappen van een scherm bewerken. U kunt een script maken om variabelen vooraf te berekenen, eventueel gebaseerd op CGI-variabelen die worden verkregen via een URL of op basis van formulierinvoer in het huidige of een ander scherm.

## Eigenschappen

* **Map:** als u de schermen in een mapstructuur hebt georganiseerd, klikt u op <i class="ph ph-caret-down" aria-label="Chevron"></i> en selecteert u een map.
* **Naam**: een beschrijvende naam voor het scherm.
* **ID-tekenreeks**: een tekenreeks waarmee dit scherm uniek wordt aangeduid, zodat ernaar kan worden verwezen in URL's.
* **Verificatiesleutel**: het is mogelijk een aangepast scherm uit te voeren zonder als gebruiker te zijn aangemeld. Om dit te doen, moet u een verificatiesleutel opgeven.
* **Waarschuwing bij navigeren**: de gebruiker ziet een waarschuwing als een pagina wordt verlaten die niet-opgeslagen gegevens bevat.
* **Automatisch opslaan gebruiken**: activeer de functie [automatisch opslaan][1].

## Scripts

* **Script laden (vóór setFromCgi)**: dit script wordt uitgevoerd voordat waarden worden toegewezen aan de schermelementen
* **Script laden (na setFromCgi)**: dit script wordt uitgevoerd nadat waarden worden toegewezen aan de schermelementen
* **Script laden (als laatste uitvoeren)**: dit script wordt aan het eind uitgevoerd, nadat code en scripts van eventuele knoppen zijn uitgevoerd.
* **Verborgen variabelen**: de variabelen die hier worden gedefinieerd, worden opgeslagen wanneer het scherm wordt verzonden, zodat het volgende scherm er toegang toe heeft.

<!-- Referenced links -->
[1]: ../../../request/learn/create.md
