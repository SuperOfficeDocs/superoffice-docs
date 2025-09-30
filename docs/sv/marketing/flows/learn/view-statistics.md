---
uid: help-sv-flow-view-statistics
title: Analysera dina flödesresultat
description: Analysera dina flödesresultat
keywords: flöde, flödesresultat, flödesstatistik, statistik, analysera flöde, rapport, meddelandeprestanda, framgångsgrad
author: Bergfrid Dias, Trude Lien Smedbråten
date: 09.26.2025
version: 10.5
content_type: howto
category: marketing
topic: flows
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: sv
---

# Analysera dina flödesresultat

SuperOffice samlar statistik och resultat för varje flöde du kör.

## Steg

För att se statistik om ditt flöde, gå till fliken **Flöden** och klicka på flödet i listan. **Visa flöde**-skärmen öppnas.

> [!TIP]
> Klicka på **Uppdatera**-knappen för att uppdatera flödesstatistiken.

## Flikar med flödesstatistik

* **Sammanfattning:** Grundläggande information om flödet och några nyckelmetriker

  * **Trigger:** Flödets startpunkt som definierar NÄR en person föreslås som deltagare.
  * **Framgångskriterier:** Vad användaren vill uppnå med denna automation.
  * **Registrerad:** Totalt antal tillagda deltagare, alla statusar.
  * **Pågående:** Totalt antal deltagare med status = pågåande.
  * **Slutförd:** Totalt antal deltagare med status = Slutförd / Slutförd med framgång.
  * **Framgångsgrad:** Procentandel av alla deltagare med status Slutförd med framgång.

  **Viktig info:** status (Inte körs/Körs/Paus), ägare, synlig för (kollega/grupp/alla), senast uppdaterad, beskrivning

* **Rapporter:** Visar diagram med statistik för flödet, används för att övervaka dess prestanda. Ett endast läsbart instrumentpanel med fördefinierade brickor. Datasetet är begränsat till det aktuella flödet - ingen filtrering.

* **Deltagare:** Presenterar en [lista över alla deltagare][1] inom flödet.

## Relaterat innehåll

### Jämför kampanjer/flöden

Gå till **Marknadsföring** > **Flöden** och välj arkivläge.

![Jämför kampanjer/flöden -screenshot][img3]

### Kontrollera status för aktuellt flöde

På **Visa flöde**-skärmen syns status i sidhuvudet och på fliken **Sammanfattning**.

![Visa status för aktuellt flöde -screenshot][img2]

### Kontrollera status för alla flöden

Gå till **Marknadsföring** > **Flöden** och välj arkivläge (<i class="ph ph-list" aria-label="Lista"></i>).

![Visa status för alla flöden i arkivläge -screenshot][img1]

### Kontrollera meddelandeprestanda och engagemang

Gå till **Marknadsföring** > **Flöden** > **Rapporter**.

![Visa flödesinstrumentpanel -screenshot][img4]

### Rapportbrickor

* Mottagare per e-post
* Öppningsfrekvens per e-post
* Klickfrekvens per e-post
* Deltagare efter status
* Deltagare som hoppat av sorterat efter orsak
* Registrering av deltagare över tid
* E-postmeddelanden med best resultat (CTR)

### Vilka länkar klickas och av vem

Gå till **Marknadsföring** > **Spårade länkar**. Se [Utforska länkklick][11].

<!-- Referenced links -->
[1]: participants.md
[11]: ../../tracked-links/learn/explore-clicks.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/view-status-all-flows.png
[img2]: ../../../../media/loc/en/marketing/check-flow-status.png
[img3]: ../../../../media/loc/en/marketing/compare-flow-success.png
[img4]: ../../../../media/loc/en/marketing/flow-dashboard.png
