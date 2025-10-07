---
uid: help-sv-screen-designer
title: Skärmdesigner
description: Lär dig hur du konfigurerar skärmar i den här guiden.
keywords: Skärmdesigner, layout, gränssnitt, flik, fält
author: Bergfrid
date: 10.09.2025
version: 10.3.11
content_type: concept
license: development-tools
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: screen designer
language: sv
index: true
redirect_from: /sv/customization/screen-designer/index
---

# Skärmdesigner <i class="ph ph-squares-four" aria-hidden="true"></i>

**Skärmdesignern** i SuperOffice CRM låter dig anpassa layouten på huvudskärmar i applikationen, så att gränssnittet möter de specifika behoven hos olika användargrupper i din organisation. Denna funktion ersätter det gamla [PageBuilder][9]-verktyget och erbjuder ett mer strömlinjeformat och flexibelt sätt att konfigurera skärmar utan kodning.

![Skärmdesigner, företagskort, standard fältlayout -screenshot][img5]

> [!NOTE]
> Denna funktion kräver licensen Development Tools och funktionsrätten "Fältadministratör".

## Varför använda Skärmdesignern?

SuperOffice CRM levereras med standardlayouter för Kontakt-, Företags-, Försäljnings-, Projekt- och Ärendeskärmarna samt Händelsesdialogen. Men olika team har ofta olika informationsbehov. Genom att använda Skärmdesignern kan du:

* Skapa anpassade layouter som är skräddarsydda för arbetsflödena och prioriteringarna hos specifika användargrupper (som försäljning, support, ledning).

* Förbättra effektiviteten genom att låta dina team snabbt komma åt den information som är viktigast för dem.

* Ta bort onödiga fält, lägga till nya och organisera information i logiska grupper med hjälp av flikar, kolumner och etiketter.

Om till exempel ditt försäljningsteam fokuserar på kundinteraktioner, kan du se till att kontaktuppgifter visas tydligt, medan mindre relevanta fält flyttas till sekundära flikar.

## Vad kan jag anpassa?

Med Skärmdesignern kan du:

* Ändra standardlayouten för skärmar för alla användare eller skapa anpassade layouter för specifika användargrupper.
* Designa layouter som är optimerade för specifika projekttyper, försäljningstyper, ärendetyper, hëndelsestyper, eller dokumentmallar.
* Dölja fält som aldrig används.
* Framhäva viktiga data genom att formatera fält (t.ex. fetstil eller stor text).
* Lägga till knappar och länkar för att trigga automatiserade processer (CRMScript) eller externa uppslag.
* Organisera anpassade fält inom fliken **Mer** eller andra anpassade flikar.
* Lägga till, omorganisera eller ta bort flikar efter behov.

## Vilka skärmar kan jag konfigurera?

Du kan anpassa följande skärmar och dialoger:

* Företag
* Kontakt
* Försäljning
* Projekt
* Ärende
* Händelsesdialog
* Dokumentdialog

## Hur fungerar layouter?

Layouter i SuperOffice CRM styr hur information presenteras för användarna. Standardlayouterna (system) tillämpas på alla användare, såvida inte en anpassad layout har skapats och tilldelats en specifik användargrupp.

* **Anpassade layouter**: Skapa layouter som är specifikt anpassade till användargruppers unika behov.

* **Layouttilldelning**: Layouter för försäljnings-, projekt- och ärendeskärmarna kan ytterligare anpassas genom att tilldela dem specifika försäljningstyper, projekttyper och ärendetyper. På samma sätt kan Händelsesdialogen tilldelas händelsestyper, och Dokumentdialogen kan tilldelas dokumentmallar.

* **Layoutstatus**: Layouter kan vara i *utkast* eller *publicerat* tillstånd. Publicerade layouter är markerade med de tilldelade användargrupperna/typer.

![Skärmdesigner utkastlayout -screenshot][img3]

![Skärmdesigner publicerad layout -screenshot][img4]

Listan **Layouter** visar alla befintliga layouter, inklusive en förhandsgranskning av skärmen.

## Arbeta med Skärmdesignern

För att börja anpassa skärmar:

1. Öppna skärmdesignern genom att klicka på <i class="ph ph-list" aria-label="Main menu"></i>, välja **Inställningar och underhåll** och sedan välja **Skärmdesigner** från navigatören.

2. Dra och släpp fält i redigeraren för att lägga till dem i layouten.

3. Klicka på ett fält för att flytta det eller uppdatera dess inställningar. Tillgängliga inställningar beror på vilken typ av fält som har valts.

### Layoutkomponenter

* **Fält:** Visar alla datafält som är tillgängliga för den valda skärmlayouten. Använd filter för att snabbt hitta specifika fält.

* **Element:** Innehåller icke-databaserade element som etiketter, avdelare, länkar och knappar.

* **Inställningar:** Låter dig anpassa utseendet och beteendet för det valda fältet.

* **Fliklayout:** Ger alternativ för att arrangera fält och element i kolumner.

* **Flikar:** Kan läggas till, omorganiseras eller tas bort för att logiskt organisera information.

> [!NOTE]
> Efter publicering av en layout måste användare i de tilldelade grupperna logga ut och logga in igen för att se ändringarna.

## Vad händer om jag inte använder Skärmdesignern?

Om du inte har en licens för utvecklingsverktyg organiserar fliken **Mer** automatiskt alla anpassade fält i två kolumner. Detta standardupplägg ger fortfarande ett funktionellt gränssnitt, men utan de avancerade anpassningsalternativ som finns tillgängliga genom Skärmdesignern.

## Sammanfattning

Genom att anpassa skärmlayouterna med skärmdesignern kan du eliminera onödig information, vilket gör gränssnittet renare och mer effektivt för dina team. Om till exempel ditt supportteam inte behöver visa företagets adress tydligt kan du flytta den till en sekundär flik, vilket frigör utrymme för mer relevanta fält.

## Relaterat innehåll

* [Lägg till layout][2]
* [Redigera huvudkortlayout][1]
* [Arbeta med fält][4]
* [Arbeta med detaljkort (arkiv)][3]

<!-- Referenced links -->
[1]: edit-layout.md
[2]: add-layout.md
[3]: working-with-archives.md
[4]: working-with-fields.md
[9]: ../../../../en/ui/web-app/pagebuilder/index.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/customization/status-draft.png
[img4]: ../../../../media/loc/en/customization/status-published.png
[img5]: ../../../../media/loc/en/customization/edit-card-layout-fields.png
