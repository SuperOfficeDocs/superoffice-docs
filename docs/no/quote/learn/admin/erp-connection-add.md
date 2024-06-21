---
uid: help-no-erp-connection-add
title: ERP-kobling legg til
description: ERP-kobling legg til
author: SuperOffice RnD
date: 06.29.2022
keywords: tilbud, ERP, connector
topic: howto
language: no
---

# Legg til ERP-kobling (Quote Connector)

Hver Quote Connector må ha en ERP-kobling med konfigurasjonsinformasjon for å knytte Quote Connector til SuperOffice.

Hvordan konfigurerer jeg en ERP-tilkobling for SuperOffice CRM for Web (online)?

[!include[How to set up ERP](includes/set-up-erp.md)]

## Slik legger du til en ERP-tilkobling

1. Gå til fanen **ERP-koblinger** i bildet Tilbud/Sync.

1. Klikk på **Legg til** nederst i listen **ERP-koblinger**. Dialogboksen **Angi ny ERP-kobling** vises.

1. Skriv inn navnet på ERP-koblingen i feltet **Navn**.

1. Velg ønsket **Quote Connector** i listen. Denne listen er identisk med **Tilgjengelige Quote Connectors**.

1. Velg et **Område**:

    * **Alle**: Velg dette alternativet hvis alle brukere skal ha tilgang til og kunne bruke denne ERP-koblingen. Det vil si at de kan bruke prislistene som er tilgjengelig via denne koblingen.
    * **Angitte brukere + grupper**: Klikk på **Velg grupper og brukere** for å velge hvilke brukergrupper og/eller brukere som skal tilgang til denne ERP-koblingen.

1. Velg ERP-koblingen som skal håndtere synkroniseringen ([Sync Connector][1]) i feltet **ERP-kobling**.

1. Nederst i dialogboksen angir du ønskede innstillinger. Innholdet i denne listen varierer avhengig av hvilken type Quote Connector du har valgt.

1. Skriv inn en beskrivelse av ERP-koblingen i feltet nederst.

1. Klikk på **Test ERP-koblingen** for å kontrollere at koblingen fungerer.

1. Klikk på **OK**.

## Slett og gjenopprett

Nederst i listen **ERP-koblinger** kan du slette ERP-koblinger som ikke lenger er i bruk.

Slik gjenoppretter du en slettet ERP-tilkobling:

1. Velg **Slettet**.
1. Velg den slettede tilkoblingen i listen.
1. Klikk på **Gjenopprett**.

<!-- Referenced links -->
[1]:sync/index.md

<!-- Referenced images -->
