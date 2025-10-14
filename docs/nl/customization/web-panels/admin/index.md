---
uid: help-nl-ui-web-panels
title: Webpanelen
description: Webpanelen
keywords: webpaneel, www tabblad
author: digitaldiina
date: 10.13.2025
version: 11.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: web panel
language: nl
index: true
redirect_from: 
  - /nl/ui/web-panels/learn/index
  - /nl/admin/lists/learn/web-panel
---

# Webpanelen

Een **webpaneel** is een configureerbaar gebied binnen SuperOffice CRM dat inhoud weergeeft van een webpagina of interne bron, gebaseerd op een URL. Hiermee kunt u externe gegevensbronnen of interne tools direct integreren in SuperOffice.

Webpanelen kunnen op verschillende locaties verschijnen en zijn afgestemd op de context waarin de gebruiker werkt, zoals een bedrijfskaart, verzoek of vervolgactiviteit.

## Inhoudstypen ondersteund door webpanelen

Webpanelen ondersteunen een reeks inhoudstypen:

* **URL's:** externe webpagina's of interne systemen
* **Schermen:** SuperOffice CRM-schermsnelkoppelingen
* **Selecties:** snelkoppelingen naar selecties
* **Scripten/macro's:** acties geactiveerd via een knop of menu

## Weergavelocaties voor webpanelen

De **weergavelocatie** wordt gedefinieerd wanneer u het paneel configureert. Dit bepaalt waar in SuperOffice het paneel verschijnt.

* **Zijpaneel** – Verschijnt in het inklapbare paneel aan de zijkant van vele CRM-schermen.
* **Werkbalk** – Voegt een knop toe aan de werkbalk.
* **Navigatorknop** – Voegt een knop toe aan het hoofdmenu.
* **Panelen:**
  * **Bedrijfs-, Persoons-, Project-, Verkoop- en Selectiekaarten** – Voegt een snelkoppeling toe in het **www**-tabblad voor elk scherm.
  * **Webpaneel op SuperOffice-knop** – Opent vanuit het SuperOffice-logo (linkerbovenhoek). Meerdere URL's verschijnen als tabbladen rechts.
  * **Sectietabbladen (in Bedrijfs-, Persoons-, Project- en Verkoopschermen)** – Voegt een apart tabblad toe dat de panelinhoud opent.
* **Dialoogvensters:**
  * **Vervolgactiviteitdialoogvenster** – Voegt een snelkoppeling toe in het **www**-tabblad van het vervolgactiviteitdialoogvenster.
  * **Document-, Product- en Offertedialoogvensters** – Voegt een snelkoppeling toe in het **www**-tabblad van elk dialoogvenster.
* **Menu's:**
  * **Werkzeugmenu** – Verschijnt onder **Andere toepassingen** bij het klikken op de **Tools**-knop in de Navigator.
  * **Weergavemenu** – Verschijnt in de menuoptie **Andere toepassingen**.
* **Dashboard-tegels** – Beschikbaar in de tegelinhoudskiezer voor dashboard-widgets.

### In Service (verouderd)

* Hoofdscherm
* Verzoekscherm
* Bedrijfsscherm
* Persoonscherm
* Extra tabelitemscherm

## <a id="www"></a>Het www-tabblad

Op plaatsen zoals Bedrijf, Persoon, Project en Verkoop worden webpanelen vaak weergegeven onder het **www**-tabblad.

U kunt het tabblad hernoemen in **Instellingen en onderhoud** > **Opties** > **Labels**. Om het tabblad binnen de CRM-interface te herpositioneren, gebruikt u de lijst **GUI - Webpaneel**.

### Openen in apart venster

Alle ingesloten URL's kunnen worden geopend in een apart browservenster met **Openen in apart venster**.

## Hoe webpanelen werken

Webpanelen laden dynamisch inhoud op basis van CRM-context en de URL die is gedefinieerd voor het paneel:

1. Een gebruiker opent een record (bijvoorbeeld een bedrijf).
1. Het systeem berekent de URL met behulp van beschikbare sjabloonvariabelen.
    * Bijvoorbeeld, `http://server/pagina.asp?id=<cuid>` wordt `http://server/pagina.asp?id=123`
1. Als de nieuwe URL anders is dan de vorige, verzendt het systeem een nieuw verzoek.
1. De server reageert met de juiste webpagina: het ontvangt de URL, berekent de pagina met behulp van URL-parameters en retourneert het resultaat.
1. Het paneel rendert de webpagina binnen SuperOffice CRM.

## Gerelateerde inhoud

* [Webpaneel toevoegen][1]
* [Webpanelen bouwen][2]

<!-- Referenced links -->
[1]: add-web-panel.md
[2]: ../../../../en/customization/web-panels/dev/index.md

<!-- Referenced images -->