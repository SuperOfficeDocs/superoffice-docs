---
uid: help-nl-phone-preferences
title: Telefoonvoorkeuren
description: Telefoonvoorkeuren
author: SuperOffice RnD
so.date: 06.29.2022
keywords: agenda, vervolgactiviteit, telefoon, bellen, bellen
so.topic: howto
language: nl
---

# Telefoonvoorkeuren

U kunt op een van de volgende manieren bellen vanuit SuperOffice CRM:

* Klik op een telefoonnummer in het scherm Bedrijf
* Klik op ![pictogram][img1] in een dialoogvenster.
* Klik met de rechtermuisknop op een persoon in een sectietabblad en selecteer **Bel *Naam*.**
* [Contactpersonen bellen][1].

Telefoonvoorkeuren worden verschillend verwerkt in Windows- en Webclients. Meer informatie over de telefoonvoorkeuren voor Windows en Web vindt u hieronder.

## Technische vereisten

Als u de telefoonfuncties in SuperOffice wilt gebruiken, moet u mogelijk TAPI-software installeren.

### Voorgestelde leveranciers

* Standaardbelsoftware van Windows
* Panasonic TSP
* PBX Dial

## Voorkeuren

Als IP-telefoon, Skype of Facetime is geïnstalleerd, kunt u telefoneren vanuit SuperOffice CRM. De voorkeur **Telefoonlinkopmaak** moet correct worden ingesteld, hetzij in **Voorkeuren** &gt; **Standaardwaarden** of in Instellingen en onderhoud. In Instellingen en onderhoud kunnen de telefoonvoorkeuren worden ingesteld voor individuele gebruikers, gebruikersgroepen of het hele systeem.

### Beschikbare parameters

**IP-telefoon**: tel:%p (standaardwaarde)
**Skype**: callto:%p
**Facetime**: facetime:%p

Er kunnen ook [sjabloonvariabelen][2] worden gebruikt in de telefoonparameters.

<!-- Referenced links -->
[1]: dial.md
[2]: ../../../document/learn/template-variables.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/phone.png
