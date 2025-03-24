---
uid: help-sv-dashboard
title: Dashboards
description: Konfigurera SuperOffice Dashboard och använd fördefinierade figurer. Dashboards är perfekta för alla användare och chefer. Du får en översikt över ditt arbete eller teamets resultat.
keywords: dashboard
author: SuperOffice RnD
date: 02.25.2025
topic: concept
language: sv
---

# Panel

> [!NOTE]
> Vissa av de funktioner som beskrivs här kräver specifika funktionella behörigheter eller licenser.

Med **Dashboard**-funktionen i SuperOffice CRM får du snabb tillgång till diagrammen, rapporterna och statistiken som är viktigast för dig. Du kan välja bland ett stort anal fördefinierade figurer och även lägga till figurer med dynamiska urval eller skapa egna.

Dashboards visas som flikar högst upp på skärmen. Fastnålade dashboards och dashboards som har valts som favoriter visas här, liksom den senast använda dashboarden. Om du vill se andra dashboards som du har åtkomst till söker du i navigatorn.

![Anpassa din dashboard så att du har större användning av den -screenshot][img4]

## Terminologi

* **Dashboard:** En dashboard är ett sätt att visa olika typer av visuella data på ett och samma ställe. Vanligtvis används en dashboard för att förmedla olika typer av, men relaterad, information i en överskådlig form.

* **Rapporter:** en lista eller ett urval som visas i en figur

* **Figurer:** Justerbar fyrkant som kan visualisera olika data på din dashboard.

  * **Diagramtyp:** Ett diagram är en grafisk framställning som visualiserar data (kallas ibland graf).
  * **Lista:** En lista som visar ett definierat urval.
  * **Stora siffror:** Gör det möjligt att framhäva viktiga totalmått eller nyckeltal.
  * **Webbpanel:**  Visa en URL/webbsida inuti en figur.
  * **HTML-kod:** Visa HTML-kod inuti en figur.

* **Dataset:** Ett dataurval som visas i figuren, till exempel ett dynamiskt urval med sökkriterier.

* **Layout:** Ändra inställningarna för att justera hur data visas i en figur.

* **Dashboard-flikar:** Varje flik innehåller en dashboard som visar olika figurer med olika data som kan ge insikter och fungera som beslutsstöd.

## Figurer

I SuperOffice Dashboard finns många [fördefinierade standardfigurer][6] att välja mellan och diagram som är kopplade till dynamiska urval. Figurerna kan delas in i åtta olika kategorier: Företag, Kontakt, Händelse, Försäljning, Projekt, Dokument, Produkt och Ärende.

Varje figur på en dashboard innehåller antingen ett diagram, en lista eller en siffra. Ett dashboard kan innehålla flera figurer.

Figurerna kan också anpassas för att endast visa data från urval. Eftersom figurdata kräver åtkomstbehörigheter visar figurerna bara information som du har åtkomst till. Figurdata gäller vanligtvis dig eller dina grupper och en specifik tidsperiod (till exempel den här månaden eller de senaste 6 månaderna)

Det finns flera typer av diagram:

| Typ | Beskrivning |
|---|---|
| Cirkeldiagram | Ett cirkelformat diagram. |
| Kolumn | Ett kolumndiagram ställer upp variabelvärdena vertikalt. |
| Stapel | Ett stapeldiagram ställer upp variabelvärdena horisontellt. |
| Linje | En serie datapunkter med en heldragen linje. |
| Område | Ett diagram som kombinerar ett linjediagram och ett stapeldiagram. |
| Mätare | Använder visare för att förmedla information som en avläsning på en nummerskiva. |
| Kolumn + linje | (2 axlar) Ett diagram med två axlar som kombinerar ett kolumn- och ett linjediagram. |
| Stapel + linje | (2 axlar) Ett diagram med två axlar som kombinerar ett stapel- och ett linjediagram. |

### Skapa fler flikar

Som standard har dashboarden bar en flik: Status. Den innehåller olika figurer med fördefinierade diagram. Du kan redigera den här fliken och/eller lägga till fler flikar där du infogar alla figurer och diagram du behöver.

> [!NOTE]
> Eftersom figurdata kräver åtkomstbehörigheter visar figurerna bara information som du har åtkomst till.

## Alternativ i skärmen Dashboard

| Ikon/knapp | Beskrivning |
|---|---|
| <i class="ph ph-push-pin" aria-label="Pin"></i> | Dashboarden har nålats fast av en administratör och distribueras förmodligen till flera användare. |
| <i class="ph ph-star" aria-label="Star icon"></i> | Klicka på ikonen längst upp till höger för att välja en dashboard som favorit. |
| <i class="ph ph-arrow-clockwise" aria-label="Refresh"></i> | Klicka på knappen **Uppdatera** om du vill uppdatera data i alla figurer. |
| <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> | Klicka för att komma åt olika funktioner. |

**Funktioner under knappen Uppgift:**

* [Skapa en ny dashboard eller duplicera][1]
* [Redigera ett dashboard][3]
* [Lägg till figurer/Redigera layout][4]
* Ta bort ett dashboard

En dashboard kan bestå av valfritt antal figurer. Varje figur innehåller en grafisk eller numerisk framställning av SuperOffice-data.

Det är de data som ligger bakom figurerna som gör dashboarden användbar. Lär dig hur du kommer åt informationen på din dashboard så att du får en tydlig översikt och kan prioritera nästa steg bättre.

## Visa figurer och data

* Klicka på data i en figur (till exempel en sektor i ett cirkeldiagram) för att visa underliggande data.

* Placera muspekaren över en del av en figur för att visa källdata i en popup-ruta.

* Klicka på dataetiketterna (text) under figuren för att dölja/visa specifika data i figurerna. Detta kan vara användbart om du vill skriva ut eller exportera figurer.

* Klicka på <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> i sidhuvudet för en figur och välj **Visa i helskärmsläge** för att öppna figuren i helskärmsläge. Praktiskt för figurer med mycket innehåll.

### Granska bakomliggande data

Följ anvisningarna i den här GIF-filen eller anvisningarna nedan för att se hur du kommer åt datauppgifterna bakom figurerna:

![Visa data bakom diagrammet med en detaljgranskning av din dashboard -screenshot][img2]

1. Öppna skärmen **Dashboard**.

2. Välj relevant dashboard.

3. Klicka på data i en figur (till exempel en kolumn i ett kolumndiagram). Ett nytt fönster visar posterna i den sektion som du klickade på.

4. Här har du följande alternativ:

    * Välj en post för att förhandsgranska den.

    * Dubbelklicka på en post för att öppna den (eller välj en post och klicka på **Öppna**).

    * Om du vill [kopiera posterna till ett urval][8] klickar du på <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> och väljer **Kopiera till urval**. Om du inte väljer några poster kopieras alla poster.

5. Klicka på **Stäng** när du är klar.

<!-- Referenced links -->
[1]: create.md
[3]: update.md
[4]: add-tile.md
[6]: working-with-tiles.md
[8]: ../../search-options/selection/learn/add-remove-members-static.md

<!-- Referenced images -->
[img4]: ../../../media/loc/en/dashboard/dashboard-overview.png
[img2]: ../../../media/loc/en/dashboard/10-drill-down.gif
