---
uid: help-sv-dashboard
title: Dashboards
description: SuperOffice Dashboards är perfekta för både användare och chefer. Få en översikt över ditt arbete eller teamets resultat med fördefinierade paneler eller skapa egna.
keywords: dashboard administrator, diagram, rapport, dataset, stora siffror, mätare, dashboard, panel
author: Bergfrid Dias
date: 03.26.2025
version: 10.5.3
topic: concept
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Dashboards

Dashboards i SuperOffice CRM ger dig omedelbar visuell insikt i ditt arbete, teamets framsteg och viktiga nyckeltal. De visar viktiga siffror och trender med hjälp av paneler som är kopplade till urval eller andra datakällor.

Använd dashboards för att följa upp aktiviteter, försäljning, ärenden med mera. Du kan visa fördefinierade dashboards eller skapa egna.

![Ärendedashboard -screenshot][img4]

> [!NOTE]
> Åtkomst till dashboards och paneldata beror på din användarplan och tilldelade rättigheter.

## Vad är ett dashboard?

Ett dashboard är en anpassningsbar vy av dina CRM-data. Det visar en eller flera paneler – små visuella rapporter som visar sammanfattningar, antal eller diagram baserat på dina data. Dashboards hjälper dig att hålla dig uppdaterad och fatta snabbare beslut.

Varje panel innehåller en grafisk eller numerisk representation av SuperOffice-data. Det är data bakom panelerna som gör ett dashboard användbart.

### Terminologi

* **Dashboard:** En skärmbild som visar CRM-data visuellt med en eller flera paneler.
* **Panel:** Ett konfigurerbart fält i ett dashboard. Paneler kan visa diagram, listor eller siffror.
* **Diagram:** En grafisk visualisering av paneldata, till exempel cirkeldiagram eller stapeldiagram.
* **Dataset:** Den underliggande datakällan för en panel. Vanligtvis baserat på sökkriterier.

## Öppna dina dashboards

Välj **Dashboard** i navigatorn för att öppna dashboard-skärmen. Du har åtkomst till:

* **Fastnålade dashboards:** Distribuerade av en administratör
* **Favoritdashboards:** Markerade med stjärnikon
* **Egna dashboards:** Dashboards du själv har skapat

Som standard finns ett dashboard som heter **Status** tillgängligt och fastnålat. Det innehåller paneler med fördefinierade diagram och nyckeltal. Om du har användarplanen SuperOffice Service är ett andra dashboard som heter **Ärenden** också tillgängligt.

Du kan skapa fler dashboards eller duplicera befintliga för att anpassa dem.

Fastnålade och favoritdashboards visas högst upp på skärmen tillsammans med det senast använda. Använd sökfältet i navigatorn för att hitta andra dashboards som du har åtkomst till.

| Ikon | Beskrivning |
|:-:|---|
| <i class="ph ph-push-pin" aria-label="Pin icon"></i> | Fastnålade dashboards. |
| <i class="ph ph-star" aria-label="Star icon"></i> | Favoritdashboard. Klicka för att växla. |
| <i class="ph ph-arrow-clockwise" aria-label="Refresh icon"></i> | Uppdatera all paneldata. |
| <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> | Åtgärdsmeny för dashboardfunktioner. |

## Paneler

Paneler är byggstenarna i ett dashboard. Paneldata är vanligtvis relaterad till dig, dina grupper och en viss tidsperiod (till exempel denna månad eller de senaste 6 månaderna).

En panel kan visa:

* Ett **diagram**, som stapel- eller cirkeldiagram. Diagram är grafiska visualiseringar av data (kallas ibland graf).
* En **lista** med upp till 100 poster från ett urval.
* En **stor siffra**, till exempel total försäljning. Visar en KPI.
* Ett **webbpanel** som laddar en URL.
* **HTML-innehåll**, formaterat direkt i panelen.

Du kan lägga till fördefinierade paneler eller skapa egna.

## <a id="charts"></a>Diagramtyper

Diagramtypen bestämmer hur data visas i panelen.

| Ikon | Typ | Beskrivning |
|:-:|---|---|
| <i class="ph ph-chart-pie" aria-label="Pie chart"></i> | Cirkeldiagram | Ett cirkelformat diagram. |
| <i class="ph ph-number-square-three" aria-label="Big numbers"></i> | Stora siffror | Ett stort värde med möjlighet att jämföra. |
| <i class="ph ph-list-bullets" aria-label="List icon"></i> | Lista | Visar upp till 100 poster. |
| <i class="ph ph-chart-bar" aria-label="Column chart"></i> | Kolumndiagram | Visar värden vertikalt. |
| <i class="ph ph-chart-bar-horizontal" aria-label="Bar chart"></i> | Stapeldiagram | Visar värden horisontellt. |
| <i class="ph ph-chart-line-up" aria-label="Line chart"></i> | Linjediagram | Datapunkter förenade med en linje. |
| <i class="ph ph-chart-line-up ph-fill" aria-label="Line chart"></i> | Områdesdiagram | Kombinerar linje- och stapeldiagram. |
| <i class="ph ph-gauge" aria-label="Gauge chart icon"></i> | Mätare | Visar data med visare på en skiva. |
| <i class="ph ph-chart-bar" aria-label="Column chart"></i> | Kolumn + linje (2 axlar) | Diagram med dubbla axlar. |
| <i class="ph ph-chart-bar-horizontal" aria-label="Bar chart"></i> | Stapel + linje (2 axlar) | Diagram med dubbla axlar. |

## Visa och interagera med paneler

Varje panel visar en ögonblicksbild av realtidsdata. Du kan interagera med panelerna för att utforska underliggande data.

* **Hovra** över diagramytor för att se detaljerade verktygstips.
* **Klicka på en värdeetikett i förklaringen** för att visa/dölja dataserier.
* Klicka på <i class="ph ph-dots-three-vertical" aria-label="Task menu"></i> och välj **Visa i helskärmsläge** för att förstora en panel.

    ![Panelens åtgärdsmeny -screenshot][img1]

* **Klicka på datapunkter** (till exempel stapel eller sektor) för att se relaterade poster i ett nytt fönster.

I vyn med bakomliggande data:

* Markera en post för att förhandsgranska.
* Dubbelklicka för att öppna posten, eller klicka på **Öppna**.
* Klicka på <i class="ph ph-dots-three-vertical" aria-label="Task menu"></i> och välj **Kopiera till urval** för att kopiera poster. Om inget är markerat kopieras alla.

![Granska bakomliggande data -screenshot][img2]

## Krav

Dashboardfunktioner beror på funktionella rättigheter och licensnivå. Alla användare kan:

* Visa dashboards som är fastnålade eller delade med dem
* Skapa, anpassa och ta bort egna dashboards

> [!NOTE]
> Paneler visar endast data du har behörighet till.

Om du inte kan redigera eller nåla fast ett dashboard, kontakta administratören för att kontrollera dina rättigheter.

### Funktionella rättigheter

Funktionella rättigheter tilldelas roller i **Inställningar och underhåll**. Dessa styr vem som kan dela och hantera dashboards.

* **Dashboardadministratör:**
  * Nåla fast dashboards till användare eller grupper
* **Allmän administratör:**
  * Uppdatera dashboards skapade av andra
  * Kan inte ta bort dashboards de inte äger

Endast **ägaren** av ett dashboard kan ta bort det.

### Licensspecifika dashboardfunktioner

| Licens | Inkluderade dashboards | Paneltyper |
|---|---|---|
| Alla CRM-planer | Status-dashboard med standardpaneler | Diagram, listor, stora siffror |
| **Service** | Ärenden-dashboard | Paneler relaterade till ärenden |
| **Marketing** (Essentials eller högre) | – | Utskick, formulärsvar, chattar |
| **Sales Premium** | – | Prognoser, nyckeltal, säljmål, offerter |
| **Sales eller Service Premium** | – | Aktivitetsövervakning (SAINT) |

## Tips

* Använd **favoriter** <i class="ph ph-star" aria-label="Star icon"></i> för att snabbt nå dina mest använda dashboards.

## Relaterat innehåll

* [Skapa ett nytt dashboard eller duplicera ett befintlig][1]
* [Redigera ett dashboard][3]
* [Redigera paneler][6]

<!-- Referenced links -->
[1]: create.md
[3]: update.md
[6]: working-with-tiles.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/dashboard/tile-task-menu.png
[img2]: ../../../media/loc/en/dashboard/10-drill-down.gif
[img4]: ../../../media/loc/en/dashboard/dashboard-overview.png
