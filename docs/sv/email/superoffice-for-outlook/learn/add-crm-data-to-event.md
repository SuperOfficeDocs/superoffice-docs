---
uid: help-sv-email-outlook-add-crm-data-to-event
title: Lägg till CRM-data i Outlook-händelse
description: Lägg till CRM-data i Outlook-händelse
keywords: SuperOffice for Outlook, Outlook, e-post, händelse, kalender, CRM data, SOFO
author: Erik Lebiko, Bergfrid Dias
date: 10.29.2024
version_sofo: 2024.8.12
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Lägg till CRM-data i Outlook-händelse

## Ny händelse

1. Välj **Ny händelse** i Outlook.

1. [Öppna SuperOffice for Outlook][1] (om panelen inte är fäst).

1. Lägg till personer i fältet **Bjud in deltagare** i Outlook.

    ![SuperOffice for Outlook, lägg till CRM-data till händelse -screenshot][img1]

    Om e-posten eller kontakten är lagrad i SuperOffice, kommer deras kontaktinformation att visas, och fälten **Företag** och **Kontakt** fylls i automatiskt. Du kan hålla muspekaren över kontakten och klicka på **Öppna i CRM** för att visa detaljerad information i SuperOffice CRM.

    Du kan också **bjuda in kontakter från SuperOffice** för extra bekvämlighet.

1. Justera händelsedetaljerna vid behov.

1. Tryck på **Spara** för att slutföra händelsen.

## Befintlig händelse

1. Öppna en befintlig händelse i Outlook.

1. [Öppna SuperOffice for Outlook][1] (om panelen inte är fäst).

    * Om det finns SuperOffice CRM-data för deltagarna, kommer de att visas.
    * Om inga data finns kommer tillägget att försöka hitta arrangören i SuperOffice CRM.

1. Följ samma steg som beskrivs ovan för att ändra eller spara händelsen.

> [!NOTE]
> Du behöver [Synchronizer for SuperOffice][2] för denna funktionalitet. Kalenderhändelser som synkroniseras från SuperOffice CRM är endast läsbara i Outlook, men du kan ändå visa kontaktinformation.

## Ytterligare information

För att visa försäljning, projekt eller aktiviteter relaterade till en kontakt, följ dessa steg:

1. I SuperOffice-sidpanelen, navigera till fliken **Åtgärd** eller **Personer** och välj kontaktens namn.
2. Du kommer att se viktiga detaljer om kontakten, inklusive deras ärenden, försäljningar och händelsar.

<!-- Referenced links -->
[1]: get.md#open
[2]: https://appstore.superoffice.com/infobridge-software-b-v-/synchronizer-for-superoffice

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/email/outlook-calendar-event.png
