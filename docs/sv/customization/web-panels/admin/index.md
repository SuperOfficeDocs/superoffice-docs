---
uid: help-sv-ui-web-panels
title: Webbpaneler
description: Webbpaneler
keywords: webbpanel
author: digitaldiina
date: 10.13.2025
version: 11.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: web panel
language: sv
index: true
redirect_from: /sv/ui/web-panels/learn/index
---

# Webbpaneler

En **webbpanel** är ett konfigurerbart område i SuperOffice CRM som visar innehåll från en webbsida eller intern resurs, baserat på en URL. Detta låter dig integrera externa datakällor eller interna verktyg direkt i SuperOffice.

Webbpaneler kan visas på olika platser och anpassas till det sammanhang användaren arbetar i, såsom ett företagskort, ett ärende eller en händelse.

## Innehållstyper som stöds av webbpaneler

Webbpaneler stöder en rad innehållstyper:

* **Webbadresser:** externa webbsidor eller interna system
* **Skärmar:** SuperOffice CRM-skärmgenvägar
* **Urval:** genvägar till urval
* **Skripter/makron:** åtgärder utlösta via en knapp eller meny

## Visningsplatser för webbpaneler

**Visningsplatsen** definieras när du konfigurerar panelen. Detta styr var i SuperOffice panelen visas.

* Sidopanel
* Verktygsfält
* Navigatorknapp (huvudmeny)
* Paneler:
  * Företags-, Kontakt-, Projekt-, Försäljnings- och Urvalskort
  * SuperOffice-knapp webbpanel
  * Sektionsflikar för Företags-, Kontakt-, Projekt- och Försäljningsskärmar
* Dialogrutor:
  * Uppföljningsdialog
  * Dokumentdialog
  * Produkt- och offertdialoger
* Menyer:
  * Verktygsmenyn
  * Visa-menyn
* Dashboard-paneler (via innehållsväljare dropdown)

### I Service (föråldrad)

* Huvudskärm
* Ärendeskärm
* Företagsskärm
* Kontaktskärm
* Extra tabellpostskärm

## <a id="www"></a>www-fliken

På platser som Företag, Kontakt, Projekt och Försäljning visas webbpaneler ofta under **www**-fliken.

Du kan byta namn på fliken i **Inställningar och underhåll** > **Systemval** > **Etiketter**. För att flytta fliken inom CRM-gränssnittet använder du listan **GUI – Webbpanel**.

### Öppna i eget fönster

Alla inbäddade URL:er kan öppnas i ett separat webbläsarfönster med **Öppna i eget fönster**.

## Så fungerar webbpaneler

Webbpaneler laddar innehåll dynamiskt baserat på CRM-kontext och URL:en som är definierad för panelen:

1. En användare öppnar en post (till exempel ett företag).
1. Systemet beräknar URL:en med tillgängliga mallvariabler.
    * Till exempel blir `http://server/sida.asp?id=<cuid>` till `http://server/sida.asp?id=123`
1. Om den nya URL:en skiljer sig från den föregående skickar systemet en ny förfrågan.
1. Servern svarar med lämplig webbsida: den tar emot URL:en, beräknar sidan med URL-parametrar och returnerar resultatet.
1. Panelen renderar webbsidan inne i SuperOffice CRM.

<!-- Referenced links -->

<!-- Referenced images -->