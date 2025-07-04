---
uid: help-sv-section-tab-activities
title: Activities tab
description: Lär dig hur du använder Aktivitetsfliken i SuperOffice CRM för att visa, hantera och följa upp aktiviteter, uppgifter och dokument för företag, kontakter, projekt och försäljningar – allt i en organiserad sektion.
keywords: Aktivitetsfliken, fliken Aktiviteter, detaljkortet Aktiviteter, detaljkort, aktivitetsarkiv, aktivitet
author: Bergfrid Skaara Dias
date: 04.08.2025
version: 10.5.4
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: sv
redirect_from:
  - /sv/company/learn/screen/activities-tab
  - /sv/contact/learn/screen/activities-tab
  - /sv/diary/learn/screen/activities-tab
  - /sv/project/learn/screen/activities-project
  - /sv/sale/learn/screen/activities-sale
---

# Aktivitetsfliken

Det finns olika typer av [aktiviteter][1] i SuperOffice CRM, inklusive händelser, e-postutskick, formulärinlämningar och chattposter.

Detaljkortet **Aktiviteter** i SuperOffice CRM ger en omfattande översikt över händelser, dokument och e-postmeddelanden kopplade till en specifik enhet (företag, kontakt, projekt eller försäljning). Detta gör det enkelt att följa upp och hantera interaktioner, vilket säkerställer att all relevant aktivitet är lättillgänglig.

![Aktivitetsfliken (Kalendern) -screenshot][img2]

## Tillgänglighet för Aktivitetsfliken

Detaljkortet **Aktiviteter** är tillgänglig för:

| Enhet   | Beskrivning av detaljkortet |
|---------|-----------------------------|
| [Företag][9] | Visar alla aktiviteter relaterade till företaget. |
| [Kontakt][10] | Visar alla aktiviteter som involverar kontakten, inklusive aktiviteter som involverar kontaktens tillhörande företag. |
| [Kalender][11] | En att-göra-lista som visar oavslutade aktiviteter, inklusive de som ännu inte har schemalagts. |
| [Försäljning][12] | Visar alla aktiviteter kopplade till försäljningen, och ger en överblick över framsteg och interaktioner. |
| [Projekt][13] | Visar alla aktiviteter kopplade till projektet. |

## <a id="columns"></a>Kolumnöversikt i Aktivitetsfliken

Detaljkortet **Aktiviteter** innehåller följande kolumner för att visa viktig information om varje aktivitet:

| Kolumn | Beskrivning |
|--------|-------------|
| Slutförd | Kryssruta som indikerar om aktiviteten är slutförd. En bock i rutan (<i class="ph ph-check" aria-hidden="true"></i>) betyder slutförd, medan en tom ruta betyder att den pågår. |
| Typikon | Visar [typen av aktivitet][1] (som möte, samtal, dokument). Matchar texten i kolumnen **Typ**. |
| Datum | Visar när ett dokument skapades eller när en händelse är planerad att ske. |
| Typ | Typen av aktivitet, som möte, uppgift eller e-post. |
| Beskrivning | En kort beskrivning av aktiviteten. |
| Företag | Tillhörande företag, om tillämpligt. |
| Ägare | Kontakten som är kopplad till aktiviteten, om tillämpligt. |
| Användar-ID | Användaren som skapade aktiviteten. |

[!include[Conf. columns](../includes/tip-configure-columns.md)]

## Visa aktiviteter

1. Gå till relevant skärm, såsom Företag, Kontakt, Projekt eller Försäljning.

1. Klicka på detaljkortet **Aktiviteter** för att se alla aktiviteter kopplade till enheten.

1. Dubbelklicka på en rad för en aktivitet för att öppna och visa eller redigera detaljerna för den aktiviteten.

### Filtrera aktiviteter

Du kan [filtrera listan][8] över aktiviteter genom att använda kryssrutorna eller filtren längst ner på detaljkortet. Detta hjälper dig att fokusera på specifika aktivitetstyper eller tidsramar.

### Inkludera slutförda aktiviteter

För att inkludera slutförda aktiviteter i listan, se till att kryssrutan **Slutförd** är markerad. Detta ger en fullständig vy över både pågående och tidigare aktiviteter.

## Hantera aktiviteter i Aktivitetsfliken

* **Lägg till aktivitet:** Klicka på **Lägg till**, fyll i detaljerna och klicka på **Spara** för att skapa en händelse.

* **Öppna aktiviteter:** Dubbelklicka på en aktivitet i listan. Om du dubbelklickar på ett dokument öppnas själva dokumentet.

* **Bläddra mellan aktiviteter:** Använd pilarna för att navigera genom aktiviteter. Använd **Förhandsgranska** i [sidopanelen][2] för att snabbt se detaljer.

* **Svara på eller vidarebefordra e-post:** Lokalisera den sparade e-posten, högerklicka och välj **Svara** eller **Vidarebefordra**.

## Ytterligare tips

* **Snabbnavigering:** Använd [Navigatorn][7] för att snabbt växla mellan olika enheter och deras motsvarande Aktivitetsflikar.

* **Markera som slutförd:** För att ändra **Slutförd**-statusen för en aktivitet, klicka helt enkelt i rutan.

* **Verktygstips för fullständig text:** Om inte all text i ett fält är synlig, håll muspekaren över det för att visa det i en inforuta.

## Relaterat innehåll

* [Introduktion till aktiviteter][1]
* [Skapa händelser][6]
* [Svara på eller vidarebefordra e-post från Aktivitetsfliken][3]
* [Ändra Slutförd-status för en aktivitet][4]
* [Ta bort aktiviteter i aktivitetslistan][1]
* [Filtrera aktiviteter][8]
* [Gruppera kolumner och sammanfatta][5]

<!-- Referenced links -->
[1]: ../basics/activity.md
[2]: ../getting-started/main-screen/side-panel.md
[3]: send-email.md
[4]: ../../diary/learn/change-completed-status.md
[5]: configure-columns.md#calculate
[6]: ../../diary/learn/create-follow-up.md
[7]: ../getting-started/main-screen/navigator.md
[8]: filter.md
[9]: ../../company/learn/index.md#section-tabs
[10]: ../../contact/learn/index.md#section-tabs
[11]: ../../diary/learn/index.md#section-tabs
[12]: ../../sale/learn/index.md#section-tabs
[13]: ../../project/learn/index.md#section-tabs

<!-- Referenced images -->
[img2]: ../../../media/loc/en/diary/activities-detail.png
