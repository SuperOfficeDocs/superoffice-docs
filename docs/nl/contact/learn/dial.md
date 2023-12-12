---
uid: help-nl-contact-dial
title: Contactpersonen bellen
description: Contactpersonen bellen; Telefoonvoorkeuren
author: SuperOffice RnD
so.date: 09.22.2023
keywords: agenda, vervolgactiviteit,  telefoon, bellen, bellen
so.topic: howto
language: nl
---

# Contactpersonen bellen

Als uw IP-telefoonoplossing juist is geconfigureerd, kunt u een persoon rechtstreeks bellen vanuit SuperOffice CRM van de volgende manieren:

* Klik op een telefoonnummer in het scherm Bedrijf
* Klik op ![pictogram][img1] in een dialoogvenster.
* Klik met de rechtermuisknop op een persoon in een sectietabblad en selecteer **Bel *Naam*.**
* Contactpersonen bellen.

## Kies een persoon in het dialoogvenster Afspraak, Taak, Telefoongesprek en Document

U gebruikt hiervoor de telefoonknop in bijvoorbeeld de dialoogvensters **Afspraak**, **Taak**, **Gesprek** en **Document**:

1. Open een afspraak, taak, telefoongesprek of document.
2. Selecteer de juiste persoon in het veld **Persoon** in het dialoogvenster.
3. Klik op de knop naast het veld persoon ![pictogram][img1]. Er wordt een lijst met nummers weergegeven voor de geselecteerde persoon.
4. Selecteer het nummer dat u wilt bellen. De persoon wordt vervolgens gebeld.

## Bellen vanuit sectietabbladen (met contactpersonen, selectieleden, belanghebbenden, deelnemers)

1. Ga naar een sectietabblad met personen.
2. Klik op een telefoonnummer in een kolom met telefoonnummers. De persoon wordt vervolgens gebeld.

## Technische vereisten

Als u de telefoonfuncties in SuperOffice wilt gebruiken, moet u mogelijk TAPI-software installeren.

### Voorgestelde leveranciers

* Standaardbelsoftware van Windows
* Panasonic TSP
* PBX Dial

## Voorkeuren

Als IP-telefoon, Skype of Facetime is geïnstalleerd, kunt u telefoneren vanuit SuperOffice CRM. De voorkeur **Telefoonlinkopmaak** moet correct worden ingesteld, hetzij in **Voorkeuren** > **Standaardwaarden** of in Instellingen en onderhoud. In Instellingen en onderhoud kunnen de telefoonvoorkeuren worden ingesteld voor individuele gebruikers, gebruikersgroepen of het hele systeem.

### Beschikbare parameters

**IP-telefoon**: tel:%p (standaardwaarde)
**Skype**: callto:%p
**Facetime**: facetime:%p

Er kunnen ook [sjabloonvariabelen][2] worden gebruikt in de telefoonparameters.

<!-- Referenced links -->
[2]: ../../document/learn/template-variables.md

<!-- Referenced images -->
[img1]: ../../../../common/icons/phone.png
