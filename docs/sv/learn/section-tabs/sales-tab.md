---
uid: help-sv-section-tab-sales
title: Försäljningsfliken
description: Lär dig hur du hanterar och ser försäljningsinformation i detaljkortet Försäljning i SuperOffice CRM, inklusive att lägga till försäljningar, filtrera och spåra försäljningsaktiviteter för företag, kontakter och projekt.
keywords: Försäljning-fliken, Försäljningsfliken, fliken Försäljning, detaljkortet Försäljning, detaljkort
author: Bergfrid Skaara Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: sv
redirect_from:
  - /sv/company/learn/screen/sales-tab
  - /sv/contact/learn/screen/sales-tab
  - /sv/diary/learn/screen/sales-tab
  - /sv/project/learn/screen/sale
---

# Försäljningsfliken

Detaljkortet **Försäljning** i SuperOffice CRM tillåter användare att visa och hantera [försäljningsinformation][1] kopplad till specifika enheter som företag, kontakter, projekt och kalendrar. Det visar en lista över alla försäljningar som är kopplade till en enhet, vilket gör det enkelt att spåra aktiviteter i sitt sammanhang och få djupare insikter i försäljningsprestanda och kommande åtgärder.

![Detaljkortet Försäljning -screenshot][img1]

## Tillgänglighet för Försäljning-detaljkortet

Detaljkortet **Försäljning** är tillgängligt för:

| Enhet | Beskrivning av Försäljning-detaljkortet |
|---|---|
| [Företag][9] | Visar alla försäljningar kopplade till företaget. |
| [Kontakt][10] | Visar försäljningar som är kopplade till kontakten, inklusive information som status, belopp och nästa steg. |
| [Kalender][11] | Ger en översikt över försäljningar med betoning på planerade aktiviteter och försäljningsframgång. |
| [Projekt][13] | Visar försäljningar som är kopplade till projektet, med fokus på relaterade aktiviteter och kommande händelser. |

## <a id="columns"></a>Kolumner i Försäljning-detaljkortet

Detaljkortet **Försäljning** innehåller följande kolumner för att visa viktig information om varje försäljning:

| Kolumn | Beskrivning |
|---|---|
| Slutförd | Kryssruta som visar om försäljningen är slutförd. En bock i rutan (<i class="ph ph-check" aria-hidden="true"></i>) betyder slutförd, medan en tom ruta betyder att den fortfarande pågår. |
| Statusikon | Visar den aktuella [statusen för försäljningen][4], t.ex. såld, förlorad eller uppskjuten. |
| Försäljningsdatum | Datum som är kopplat till försäljningen, kan vara beräknat, sålt eller förlorat datum. |
| Belopp | Det ekonomiska värdet av försäljningen. |
| Fas | Den nuvarande fasen i försäljningsprocessen. |
| Nästa aktivitet | Datum för nästa planerade händelse eller försäljningsaktivitet. Datumet som visas här representerar den äldsta händelse som ännu inte är avslutad. För att se mer detaljer eller identifiera vad nästa händelse är, dubbelklicka på försäljningen för att öppna Försäljnings-skärmen. Händelsen kan ses i detaljkortet **Aktiviteter** för försäljningen. |
| Namn | Namnet på försäljningen. |
| Kontakt | Kontakten som är kopplad till försäljningen. |
| Företag | Företaget som försäljningen är kopplad till. |
| Användar-ID | Användaren som registrerade försäljningen. |
| ERP-rabatt | Visar rabattinformation om SuperOffice CRM är kopplat till ett ERP-system. |

[!include[Conf. columns](../includes/tip-configure-columns.md)]

## Se försäljningar i Försäljningsfliken

1. Gå till den relevanta skärmen, såsom Företag, Kontakt, Projekt eller Kalender.

1. Klicka på detaljkortet **Försäljning** för att se alla försäljningar som är kopplade till enheten.

1. Dubbelklicka på en försäljning i listan för att öppna Försäljningsskärmen och se detaljerad information.

### Filtrera försäljningar

Du kan [filtrera listan][8] över försäljningar efter datum, användare eller grupp genom att klicka på **Filter**-knappen (<i class="ph ph-funnel" aria-hidden="true"></i>). Detta hjälper dig att fokusera på specifika försäljningsaktiviteter som behöver uppmärksamhet.

### Inkludera intressenter

För att inkludera försäljningar där det aktuella företaget eller kontakten är involverad som [intressent][3], markera rutan **Ta med intressenter** längst ned i detaljkortet. Detta ger en bredare översikt över alla försäljningsaktiviteter kopplade till enheten.

## Försäljningsuppgiftsassistent

Detaljkortet **Försäljning** fungerar som en **försäljningsuppgiftsassistent** som hjälper dig att hålla koll på pågående försäljningsaktiviteter. Det fungerar som en försäljningsorienterad att göra-lista och ger en sammanfattning av:

* **Ej slutförda försäljningar:** Alla pågående försäljningar där försäljningsdatumet faller inom det definierade visningsintervallet.

* **Planerade försäljningsaktiviteter:** Alla försäljningar med planerade aktiviteter för ett specifikt antal dagar framåt.

    > [!NOTE]
    > Antalet dagar framåt är användardefinierat. För att ändra denna inställning, gå till **Personliga inställningar** > **Preferenser** > **Funktioner** > **Visa dagar framåt**.

* **Förfallna aktiviteter:** Alla försäljningar med aktiviteter som har passerat sitt slutdatum (slutdatum tidigare än idag). Dessa försäljningar markeras i rött för att vara lättare att identifiera.

* **Uppskjutna försäljningar:** Om en försäljning är markerad som [stoppad][4] och har ett återöppningsdatum, kommer detta datum att skriva över datumet i fältet **Nästa aktivitet** och visas i kolumnen **Nästa aktivitet**.

Denna vy hjälper användare att hålla koll på pågående handlingar och säkerställer att inget förbises, vilket förbättrar försäljningshanteringen.

## Lägg till försäljning

För att lägga till en ny försäljning direkt från Detaljkortet **Försäljning**:

1. Välj **Lägg till** för att öppna dialogrutan för försäljningsskapande.

1. Ange försäljningsdetaljer: Fyll i de obligatoriska fälten och klicka **Spara**.

## Ytterligare tips

* **Snabb navigering:** Använd [Navigeraren][7] för att snabbt växla mellan olika enheter och deras motsvarande **Försäljning**-flikar.

## Relaterat innehåll

* [Hur man lägger till en försäljning][2]
* [Hantera intressenter i försäljning][3]
* [Filtrera aktiviteter och försäljningar][8]
* [Gruppera kolumner och sammanfatta belopp][5]

<!-- Referenced links -->
[1]: ../../sale/learn/index.md
[2]: ../../sale/learn/create.md
[3]: ../../sale/learn/stakeholders/index.md
[4]: ../../sale/learn/update.md#stalled
[5]: configure-columns.md#calculate
[7]: ../getting-started/main-screen/navigator.md
[8]: filter.md
[9]: ../../company/learn/index.md#section-tabs
[10]: ../../contact/learn/index.md#section-tabs
[11]: ../../diary/learn/index.md#section-tabs
[13]: ../../project/learn/index.md#section-tabs

<!-- Referenced images -->
[img1]: ../../../media/loc/en/company/sale-detail.png
