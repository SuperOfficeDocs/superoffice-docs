---
uid: help-nl-contact-dial
title: Contactpersonen bellen
description: Contactpersonen bellen en telefoonvoorkeuren instellen
keywords: agenda, vervolgactiviteit, telefoon, bellen, oproep, IP-telefoon
author: Bergfrid Dias
date: 03.14.2025
version: 10.5.2
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: nl
---

# Contactpersonen bellen

Als uw IP-telefoonoplossing correct is geconfigureerd, kunt u rechtstreeks vanuit SuperOffice CRM een contactpersoon bellen op een van de volgende manieren:

* Klik op een telefoonnummer in het scherm **Bedrijf**.
* Klik op <i class="ph ph-phone" aria-label="Telefoonicoon"></i> in een dialoogvenster.
* Klik met de rechtermuisknop op een persoon in een sectietabblad en selecteer **Bel *Naam***.
* Bel contactpersonen handmatig.

## Een contactpersoon bellen vanuit een vervolgactiviteit of document

U kunt de telefoonknop gebruiken in bijvoorbeeld de dialoogvensters **Vervolgactiviteit** en **Document**:

1. Open een vervolgactiviteit of document.
2. Selecteer de juiste persoon in het veld **Persoon** in het dialoogvenster.
3. Klik op de belknop naast het persoonveld. Er verschijnt een lijst met beschikbare telefoonnummers.
4. Selecteer het nummer dat u wilt bellen. De persoon wordt vervolgens gebeld.

## Bellen vanuit sectietabbladen (contactpersonen, selectieleden, belanghebbenden, deelnemers)

1. Ga naar een sectietabblad waarin personen worden weergegeven.
2. Klik op een telefoonnummer in een kolom met telefoonnummers. De persoon wordt vervolgens gebeld.

## Technische vereisten

Om de telefoonfuncties in SuperOffice te gebruiken, moet mogelijk TAPI-software worden geïnstalleerd.

### Voorgestelde leveranciers

* Standaardbelsoftware van Windows
* Panasonic TSP
* PBX Dial

## Voorkeuren

Als IP-telefoon, Skype of Facetime is geïnstalleerd, kunt u telefoneren vanuit SuperOffice CRM. De voorkeur **Telefoonlinkopmaak** moet correct worden ingesteld, hetzij in **Voorkeuren** > **Standaardwaarden** of in Instellingen en onderhoud. In Instellingen en onderhoud kunnen de telefoonvoorkeuren worden ingesteld voor individuele gebruikers, gebruikersgroepen of het hele systeem.

### Beschikbare parameters

* **IP-telefoon**: `tel:%p` (standaardwaarde)
* **Skype**: `callto:%p`
* **FaceTime**: `facetime:%p`

Er kunnen ook [sjabloonvariabelen][2] worden gebruikt in de telefoonparameters.

<!-- Referenced links -->
[2]: ../../document/templates/learn/template-variables.md
