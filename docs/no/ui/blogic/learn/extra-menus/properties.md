---
uid: help-no-ui-extra-menu-properties
title: Egenskaper for meny
description: Egenskaper for meny
author: SuperOffice RnD
date: 06.29.2022
keywords: Service
topic: reference
language: no
---

# Egenskaper for meny

[!include[Legacy](../includes/legacy-extra-menus.md)]

Her kan du redigere egenskapene til alternativer på ekstramenyer og webpaneler.

* **Baseprogram**: Velg et baseprogram her hvis du ønsker at innholdet i URL-feltet skal legges til i valgt baseprogram. For at dette skal fungere, må teksten i URL-feltet starte med &action=...

* **URL**: URLen som skal kjøres når det klikkes på menyen.

* **Legg til ID**: Legger automatisk til IDen for den gjeldende oppføringen til slutten av URLen.

* **Returner til samme bilde**: Hvis denne boksen merkes av, returneres brukerne automatisk til skjermbildet der knappen (eller lignende) ble klikket på. Ellers måtte brukerne ha gjort dette manuelt.

  * Eksempel på når du bør bruke dette alternativet: Hvis du oppretter en knapp (makro) i skjermbildet Sak for å endre sakskategorien, vil du også få det samme resultatet når knappen klikkes på.

  * Eksempel på når du IKKE bør bruke dette alternativet: Hvis du oppretter en knapp (skript) som viser mye informasjon på skjermen, vil du ikke ha dette merket av, fordi du vil vise informasjonen på skjermen. Det samme gjelder eksterne URLer, fordi du vil gå til nettstedet når du klikker på knappen.

* **Legg til &lt;usec&gt;**: &lt;usec&gt;er øktnøkkelen for NetServer-økten. For å få et webpanel til å fungere med NetServer ved hjelp av autentisering, må denne nøkkelen inkluderes.

* **Mål**: Mål for URLen. Du kan velge hvilket vindu URLen skal åpnes i, ved å skrive inn navnet på vinduet i **Mål**-feltet. Du kan skrive inn "_blank" hvis du alltid vil åpne et nytt vindu/fane eller for eksempel "kunde" for å åpne et eget vindu for dette menyalternativet eller en gruppe menyalternativer.

* **URL til ikon**: Hvis du vil ha ditt eget egendefinerte ikon for ekstramenyen, skriver du inn URLen for bildet her.

* **Plassering**: Indikerer plasseringen til ekstramenyene (0 = øverst).
