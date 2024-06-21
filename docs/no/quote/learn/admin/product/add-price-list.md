---
uid: help-no-price-list-add
title: Legge til en prisliste
description: I denne veiledningen lærer du hvordan du legger til og redigerer en prisliste i SuperOffice CRM.
author: SuperOffice RnD
date: 02.23.2023
keywords: produkt, prisliste
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Legge til en prisliste

Det er ikke uvanlig å bruke ulike prislister for ulike tider på året eller for bestemte kampanjer du kanskje vil kjøre.

Tilpassing av prislister hjelper selgerne dine med å bruke de riktige prisdetaljene uten å måtte kaste bort tid på å dobbeltsjekke dem. Du som administrator kan bestemme når en bestemt prisliste skal brukes, ved å bruke begrenset gyldighet.

![Du kan legge til og redigere alle prislistene dine i fanen SuperOffice-produkter -screenshot][img1]

## Trinn

1. [!include[Go to products](../includes/goto-products.md)]

1. Klikk på knappen **Legg til** øverst i fanen. Dialogboksen **Legg til/rediger prisliste** vises.

1. Fyll ut følgende felt:

    * **Prislistenavn**: Gi prislisten et beskrivende navn, slik at det er lett å skille den fra eventuelle andre prislister.

    > [!NOTE]
    > Du kan ikke endre valutaen etter at du har opprettet prislisten. For å aktivere valuta, går du til **Preferanser** > **System** > **Aktiver bruk av valuta**.

    * **Beskrivelse**: Skriv inn en beskrivelse av prislisten.

    * **Aktiv**: Merk av her for å aktivere prislisten, slik at den kan brukes ved oppretting av tilbud. Du bør ikke aktivere prislisten før den er helt ferdig.

    * **Begrenset gyldighet**: Merk av her hvis prislisten bare skal være gyldig i en bestemt periode. For eksempel under tidsbegrensede salgskampanjer. Du kan velge en start- og sluttdato *ELLER* bare en sluttdato.

1. Gjør ett av følgende:

    * Velg **Legg til tom prisliste** for å starte med en tom prisliste og legge inn alle produktene manuelt.
    * Velg **Kopier eksisterende prisliste** for å kopiere en prisliste med alle produkter.

    1. Velg ønsket prisliste i listen nedenfor.

    2. Velg ett av følgende alternativer:

        * **Konverter priser fra opprinnelig prisliste til &lt;valuta&gt;**: Velg dette alternativet for å bruke de eksisterende prisene i prislisten. Hvis du kopierer en prisliste med en annen valuta enn prislisten du oppretter, konverteres prisene til riktig valuta.

        * **Sette priser til null &lt;valuta&gt;**: Velg dette alternativet hvis du ikke vil kopiere prisene fra prislisten. Du må angi prisene på alle produktene i prislisten manuelt.

1. Klikk på **OK**.

    > [!NOTE]
    >Når prislisten er opprettet, har du ikke mulighet til å endre valuta og gyldighet.

## Hva vil du gjøre nå?

* [Legge til produkt i prisliste][1]
* [Sync][2]
* [Legge til Sync Connector][3]
* [Legge til ERP-kobling][4]

<!-- Referenced links -->
[1]: add-product-to-price-list.md
[2]: ../sync/index.md
[3]: ../sync/sync-connector-add.md
[4]: ../sync/sync-add-erp-connection.md

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/quote/add-price-list.png
