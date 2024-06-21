---
uid: help-da-erp-connection-add
title: ERP-forbindelse tilføj
description: ERP-forbindelse tilføj
author: SuperOffice RnD
date: 06.29.2022
keywords: tilbud, ERP, henvisning
topic: howto
language: da
---

# Tilføjelse af ERP-link (Quote Connector)

Hver Quote Connector skal have et ERP-link med konfigurationsinformation for at knytte Quote Connector til SuperOffice.

Hvordan indstiller jeg en ERP-forbindelse til SuperOffice CRM til web (online)?

[!include[How to set up ERP](includes/set-up-erp.md)]

## Sådan tilføjer du et ERP-link

1. Gå til fanen **ERP-links** i skærmbilledet Tilbud/Sync.

1. Klik på **Tilføj** nederst på listen **ERP-links**. Dialogboksen **Angiv nyt ERP-link** vises.

1. Indtast navnet på ERP-linket i feltet **Navn**.

1. Vælg ønsket **Quote Connector** på listen. Denne liste er identisk med **Tilgængelige Quote Connectors**.

1. Vælg et **Omfang**:

    * **Alle**: Vælg dette alternativ, hvis alle brugere skal have adgang til og kunne bruge dette ERP-link. Det vil sige, at de kan bruge de prislister, der er tilgængelige via dette link.
    * **Angivne brugere + grupper**: Klik på **Vælg grupper og brugere** for at vælge, hvilke brugergrupper og/eller brugere, som skal have adgang til dette ERP-link.

1. Vælg det ERP-link, der skal håndtere synkroniseringen ([Sync Connector][1]) i feltet **ERP-link**.

1. Nederst i dialogboksen angiver du de ønskede indstillinger. Indholdet på denne liste varierer afhængigt af, hvilken type Quote Connector, du har valgt.

1. Indtast en beskrivelse af ERP-linket i feltet nederst.

1. Klik på **Test ERP-linket** for at kontrollere, at linket fungerer.

1. Klik på **OK**.

## Slet og gendan

Nederst på listen **ERP-links** kan du slette ERP-links, der ikke længere bruges.

Sådan gendanner du en slettet ERP-forbindelse:

1. Markér **Slettet**.
1. Vælg den slettede forbindelse på listen.
1. Klik på **Gendan**.

<!-- Referenced links -->
[1]:sync/index.md

<!-- Referenced images -->
