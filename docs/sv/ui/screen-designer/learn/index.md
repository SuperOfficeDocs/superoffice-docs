---
uid: help-sv-screen-designer
title: Skärmdesigner
description: "Lär dig hur du konfigurerar skärmar i den här guiden."
author: SuperOffice RnD
date: 01.02.2024
version: 10.2.11
keywords: skärmdesigner
topic: concept
language: sv
audience: settings
audience_tooltip: Settings and maintenance
---

# Skärmdesigner ![icon][img1]

**Skärmdesignern** i SuperOffice CRM låter dig anpassa layouten på nyckelskärmar i applikationen, så att gränssnittet möter de specifika behoven hos olika användargrupper i din organisation. Denna funktion ersätter det gamla [PageBuilder][9]-verktyget och erbjuder ett mer strömlinjeformat och flexibelt sätt att konfigurera skärmar utan kodning.

![Skärmdesigner, företagskort, standard fältlayout -screenshot][img5]

> [!NOTE]
> Denna funktion kräver utvecklingsverktygslicens och rättigheten "Fältadministratör".

## Varför använda Skärmdesignern?

SuperOffice CRM levereras med standardlayouter för Kontakt-, Företags-, Försäljnings-, Projekt- och Ärendeskärmarna samt Uppföljningsdialogen. Men olika team har ofta olika informationsbehov. Genom att använda Skärmdesignern kan du:

* Skapa anpassade layouter som är skräddarsydda för arbetsflödena och prioriteringarna hos specifika användargrupper (som försäljning, support, ledning).
* Förbättra effektiviteten genom att låta dina team snabbt komma åt den information som är viktigast för dem.
* Ta bort onödiga fält, lägga till nya och organisera information i logiska grupper med hjälp av flikar, kolumner och etiketter.

Om till exempel ditt försäljningsteam fokuserar på kundinteraktioner, kan du se till att kontaktuppgifter visas tydligt, medan mindre relevanta fält flyttas till sekundära flikar.

## Vad kan jag anpassa?

Med Skärmdesignern kan du:

* Ändra standardlayouten för skärmar för alla användare eller skapa anpassade layouter för specifika användargrupper.
* Designa layouter som är optimerade för specifika projekttyper, försäljningstyper och ärendetyper.
* Dölja fält som aldrig används.
* Framhäva viktiga data genom att formatera fält (t.ex. fetstil eller stor text).
* Lägga till anpassade knappar och länkar för att trigga automatiserade processer (CRMScript) eller externa uppslag.
* Organisera anpassade fält inom fliken **Mer** eller andra anpassade flikar.
* Lägga till, omorganisera eller ta bort flikar efter behov.

## Vilka skärmar kan jag konfigurera?

Du kan anpassa följande skärmar och dialoger:

* Företag
* Kontakt
* Försäljning
* Projekt
* Ärende
* Uppföljningsdialog

## Hur fungerar layouter?

Layouter i SuperOffice CRM styr hur information presenteras för användarna. Standardlayouterna (system) tillämpas på alla användare, såvida inte en anpassad layout har skapats och tilldelats en specifik användargrupp.

* **Anpassade layouter**: Skapa layouter som är specifikt anpassade till användargruppers unika behov.
* **Layouttilldelning**: Layouter för försäljnings-, projekt- och ärendeskärmarna kan ytterligare anpassas genom att tilldela dem specifika försäljningstyper, projekttyper och ärendetyper.
* **Layoutstatus**: Layouter kan vara i *utkast* eller *publicerat* tillstånd. Publicerade layouter är markerade med de tilldelade användargrupperna.

![Skärmdesigner utkastlayout -screenshot][img3]

![Skärmdesigner publicerad layout -screenshot][img4]

Listan **Layouter** visar alla befintliga layouter, inklusive en förhandsvisning av skärmen.

## Arbeta med Skärmdesignern

För att börja anpassa skärmar:

1. Öppna skärmdesignern genom att klicka på ![icon][img2], välja **Inställningar och underhåll** och sedan välja **Skärmdesigner** från navigatören.
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
* [Redigera layout - Huvudkort][1]
* [Arbeta med fält][4]
* [Arbeta med arkiv (sektionsflikar)][3]

## Original Skärmdesigner

Med skärmdesignerfunktionen kan du konfigurera dina huvudskärmar i SuperOffice CRM. Du kan skapa olika skärmlayouter för olika användargrupper, beroende på deras informationsbehov och arbetsflöden. Detta hjälper din organisation att bli mer effektiv och fokusera på det som är viktigast.

> [!NOTE]
> Skärmdesigner (konfigurerbara skärmar) kräver en licens för utvecklingsverktyg. Användning av denna funktion kräver funktionsrätten "Fältadministratör".

Kontakt- och företagskorten/-skärmarna i SuperOffice CRM har en standardlayout, men du kan redigera dem eller skapa egna layouter. Eftersom olika användargrupper ofta använder kontakt- och företagskorten på olika sätt, kan det vara en bra idé att skapa olika layouter för varje användargrupp.

Med skärmdesignern kan du ta bort onödiga fält och/eller skapa nya, mer relevanta fält. Du kan också gruppera fälten i flikar eller kolumner och lägga till egna rubriker (kallas "etiketter"). Om du tycker att några av flikarna är onödiga, kan du enkelt ta bort dem eller ersätta dem med de flikar som är mer lämpliga för din organisation.

Ditt säljteam, supportteam och ledningsteam har inte nödvändigtvis samma fokus och krav på de data som behöver komma åt oftast i SuperOffice. Lösningen är att skapa anpassade skärmar för varje team. Din organisation kommer att spara tid genom att teamen hittar relevant information snabbare. Konfigurera layouten på dina huvudskärmar och arkiv (avsnittsflikar), och definiera vilken typ av information som respektive team (användargrupp) kan komma åt och se på skärmarna Företag, Kontakt, Försäljning, Projekt, och Ärenden och på **Händelse**-dialogen.

* Flytta de viktigaste fälten till den första fliken.
* Använd kolumner, etiketter/figurer och avdelare för att organisera informationen i logiska grupper.
* Formatera fält för att betona nyckeldata (till exempel fetstil och stort teckensnitt) för bättre synlighet.
* Flytta mindre viktiga fält till sekundära flikar.
* Ta bort fält som aldrig används.
* Lägg till länkar/knappar för att söka efter information på andra webbplatser eller för att manuellt trigga en automatiserad process baserad på CRMScript.

> [!NOTE]
> När den här funktionen är aktiverad ändras fälten i din nuvarande **Mer**-flik för skärmarna Företag, Kontakt, Försäljning, Projekt, och Ärenden till två kolumner. Du kan [redigera dessa flikar][1] i skärmdesignern.

Du kan skapa anpassade skärmlayouter för korten företag, kontakt, försäljning, projekt, och ärenden och **Händelse**-dialogen. Listan **Layouter** visar alla befintliga skärmlayouter (vanligtvis standardlayouten), med en förhandsgranskningsskärm till höger.

Layouterna är markerade med status (publicerad eller utkast) samt tilldelade användargrupper.

En anpassad layout för fönstret Kontakt och Företag gör att dina team och din organisation kan arbeta mer effektivt, eftersom det eliminerar det distraherande "informationsbruset".

Om ditt supportteam till exempel sällan använder företagsadressen när de kommunicerar med företag och kontakter, vill du kanske göra plats för andra fält som är viktigare på första sidan (fliken Företag). Flytta den genom att klicka på staplarna till vänster i fältet och dra den över till fliken **Mer**.

## Vad vill du göra nu?

* [Lägg till ny layout][2]
* [Redigera layout - Huvudkort][1]
* [Redigera layout - Arkiv (avsnittsflikar)][3]

<!-- Referenced links -->
[1]: edit-layout.md
[2]: add-layout.md
[3]: working-with-archives.md
[4]: learn/working-with-fields.md
[9]: ../web-app/pagebuilder/index.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/nav-admin-confscreen-active-h32.png
[img2]: ../../../../media/icons/btn-menu.png
[img3]: ../../../../media/loc/en/ui/status-draft.png
[img4]: ../../../../media/loc/en/ui/status-published.png
[img5]: ../../../../media/loc/en/ui/edit-card-layout-fields.png
