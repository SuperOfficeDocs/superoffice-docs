---
uid: help-sv-ui-web-panels
title: Webbpaneler
description: Webbpaneler
keywords: webbpanel, www flik
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
redirect_from: 
  - /sv/ui/web-panels/learn/index
  - /sv/admin/lists/learn/web-panel
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

* **Sidopanel** – Visas i den hopfällbara panelen på sidan av många CRM-skärmar.
* **Verktygsfält** – Lägger till en knapp till verktygsfältet.
* **Navigatorknapp** – Lägger till en knapp till huvudmenyn.
* **Paneler:**
  * **Företags-, Kontakt-, Projekt-, Försäljnings- och Urvalskort** – Lägger till en genväg i **www**-fliken för varje skärm.
  * **Webbpanel på SuperOffice-knapp** – Öppnas från SuperOffice-logotypen (övre vänstra hörnet). Flera URL:er visas som flikar till höger.
  * **Sektionsflikar (i Företags-, Kontakt-, Projekt- och Försäljningsskärmar)** – Lägger till en separat flik som öppnar panelinnehållet.
* **Dialogrutor:**
  * **Uppföljningsdialog** – Lägger till en genväg i **www**-fliken för uppföljningsdialogen.
  * **Dokument-, Produkt- och Offertdialoger** – Lägger till en genväg i **www**-fliken för varje dialog.
* **Menyer:**
  * **Verktygsmenyn** – Visas under **Andra applikationer** när du klickar på **Verktyg**-knappen i Navigatorn.
  * **Visa-menyn** – Visas i menyalternativet **Andra applikationer**.
* **Dashboard-paneler** – Tillgängliga i panelinnehållsväljaren för dashboard-widgets.

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

## Relaterat innehåll

* [Lägg till webbpanel][1]
* [Bygga webbpaneler][2]

<!-- Referenced links -->
[1]: add-web-panel.md
[2]: ../../../../en/customization/web-panels/dev/index.md

<!-- Referenced images -->