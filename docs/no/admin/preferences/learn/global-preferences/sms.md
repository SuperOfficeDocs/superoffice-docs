---
uid: help-no-service-settings-system-sms
title: SMS
description: SMS
author: SuperOffice RnD
date: 03.27.2023
keywords: Tjeneste, innstillinger
topic: help
audience: settings
audience_tooltip: Settings and maintenance

language: no
---

# SMS-konfigurasjon i Globale preferanser

Gå til <i class="ph ph-gear" aria-hidden="true"></i> **Preferanser** i navigatoren, og velg deretter fanen **Globale preferanser**. Seksjonen for **SMS-konfigurasjon** inneholder valg for å konfigurere SMS-løsninger i SuperOffice.

## Generelle felt

[!include[Settings for mailings - SMS](../../../../marketing/learn/includes/mailing-settings-sms.md)]

### Teste SMS-innstillingene

Du kan teste innstillingene ved å skrive inn et mobiltelefonnummer og noe tekst, og deretter klikke på **Test**.

## Tilgjengelige felt for opprinnelig Intelecom (bare ONSITE)

* **SMS-endepunkt**: Dette feltet skal inneholde kode som gjør det mulig for SuperOffice Service å gjenkjenne en innkommende SMS.
* **Bruk nettjeneste**: Hvis du merker av dette, sendes SMS-er via en webtjeneste i stedet for via e-post. Dette er den foretrukne metoden, siden den gjør mer funksjonalitet tilgjengelig. Dette krever at en eventuell brannmur godtar utgående trafikk mot SMS-gateway.
* **Leveringsbekreftelse**: Hvis du merker av for dette, støttes leveringsbekreftelse for SMS-er i SuperOffice Service. Det betyr at du kan se om en SMS ble levert til den aktuelle mobiltelefonen. Dette krever også konfigurering hos leverandøren.
* **Tjeneste-ID**: Tjeneste-ID for SMS-tjenesten. Denne oppgis av SuperOffice AS.
* **Brukernavn**: Her skriver du inn brukernavnet du har fått tildelt fra Intelecom.
* **Passord**: Her skriver du inn passordet du har fått fra Intelecom.
* **SMS-prioritet**: Her angir du enten 1, 2 eller 3. Tallene angir hvor raskt SMS-meldingene sendes ut.

## Tilgjengelige felt for opprinnelig PsWinCom (bare ONSITE)

* **SMS-endepunkt**: Dette feltet skal inneholde kode som gjør det mulig for SuperOffice Service å gjenkjenne en innkommende SMS.
* **Brukernavn**: Her skriver du inn brukernavnet du har fått tildelt fra PsWinCom.
* **Passord**: Her skriver du inn passordet du har fått tildelt fra PsWinCom.
