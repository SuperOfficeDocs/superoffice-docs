---
uid: help-sv-licenses
title: SuperOffice och licenser
description: SuperOffice och licenser
keywords: licens, mätt tjänst, databasägare, fliken Status
author: digitaldiina, xt1
date: 05.04.2026
version: 11.13
content_type: concept
category: Settings and maintenance
topic: licenses
audience: settings
audience_tooltip: Settings and maintenance
index: true
tier: starter
language: sv
redirect_from:
  - /sv/admin/license/learn/screen/index
  - /sv/admin/license/learn/index
  - /sv/learn/administration
---

# SuperOffice och licenser

För att logga in i SuperOffice CRM från en webbklient behöver du inloggningsbehörighet till SuperOffice CRM och en Essential eller Premium användarlicens.

## Visa licensinformation

1. Gå till fönstret Licenser under Inställningar och underhåll.
1. Välj fliken **SuperOffice**.
1. Listan visar alla licenser du har [köpt och aktiverat][1]. Klicka på ett licensnamn om du vill se mer information om licensen.

## Fönstret Licenser

### Fliken SuperOffice

På fliken **SuperOffice** i fönstret Licenser kan du visa och uppdatera licensinformationen för din version av SuperOffice CRM och tillhörande moduler.

> [!NOTE]
> Om ett tilläggsprogram från tredje part har installerats visas flera flikar här.

#### Information om ägare

Högst upp anges företagsnamnet (ditt företag/din organisation) och serienumret. Om licensen är tidsbegränsad visas förfallodatumet under serienumret.

#### Licensförteckning

Listan längst ner visar vilka licenser som används och hur många som är tillgängliga. Klicka på ett licensnamn om du vill se information om licensen.

### Fliken Status

På fliken **Status** i fönstret Licenser finns uppdaterad information om systemet. Fönstret **Status** är indelad i följande tre huvuddelar:

#### Databas

Här visas databasens ägare, serienummer, abonnemang och typ som anges vid installation. Du kan även se nästa utgångsdatum och namnet på den inloggade användaren.

Om din organisation har ett **SuperOffice CRM Suite**-abonnemang visas även följande i **Databas**-avsnittet:

* **Plan:** den plan som ingår i ditt abonnemang, till exempel *SuperOffice Core Suite*
* **Begränsningar:** din aktuella användning i förhållande till plangränserna, till exempel *1 av 100 aktiva projekt*

Plangränser förhindrar din organisation från att överskrida kapaciteten i den aktuella planen. Indikatorn **Begränsningar** visar hur nära du är en gräns:

| Användning | Indikator | Betydelse |
|---|---|---|
| Under 85 % | Antal visas i svart, till exempel *1 av 100 aktiva projekt* | Normalt – ingen åtgärd krävs |
| 85 % eller mer | <i class="ph ph-warning" aria-label="Warning"></i> Antal visas i rött | Närmar sig gränsen |
| 100 % | <i class="ph ph-prohibit" aria-label="Limit reached"></i> Antal visas i rött | Gränsen nådd – funktionen är blockerad |

Välj indikatorn för att öppna sidan [Plangränser][16] för mer information.

Om du är systemadministratör visas en **Uppgradera**-knapp bredvid varnings- eller stoppindikatorn. Välj den för att öppna ett kontaktformulär för att begära mer kapacitet eller en planuppgradering.

#### Tjänster med datapriser

Klicka på den här knappen för att öppna instrumentpanelen för dina tjänster med datapriser.

Tjänster med datapriser är tjänster som faktureras när du överskrider en viss nivå/ett visst antal

* använt förvaringsutrymme
* e-postmeddelanden som har skickats via Utskick
* inloggningar i kundcentret
* startade chattsessioner
* Formulärinlämningar

Administratörer kan hålla koll på exakt hur mycket av varje tjänst som används varje månad. När ditt företag överskrider gränsen debiteras du automatiskt för dessa tjänster på nästa månadsfaktura. Tröskeln beror på antalet användare. Ju fler användare du har, desto högre kommer tröskeln att vara.

#### Systemmeddelanden

I den här listan visas statusmeddelanden från systemet och skapade [händelser][3]. Aviseringar om aktiva importer, SAINT eller fritext-indexering etc. Välj en avisering i listan för att visa en beskrivning. Du kan hålla koll på händelser som är aktiva i systemet.

Fliken **Systemhändelser** består av två delar:

* **Händelser**.
* **Beskrivning**, innehåller detaljerad information om den händelse som har valts under **Händelser**.

Under **Systemmeddelanden** hittar du följande kolumner:

| Kolumn | Beskrivning |
|---|---|
| Händelse | Visar händelsens namn. |
| Status | Visar händelsens status. |
| Meddelande | Visar en beskrivning av händelsen. |
| Aktiverat | Visar när händelsen initierades. |
| Aktiverad av | Visar vem som initierade händelsen (användar-ID och porträtt). |
| Avslutat | Visar när händelsen beräknas vara avslutad. |
| Typ | Visar om händelsen avser hela systemet. |

## <a id="types"></a>Licenstyper

### Systemlicenser

| Licens | Beskrivning |
|---|---|
| System | Anger vilka system du har åtkomst till. |
| SuperOffice Server | Krävs för att använda SuperOffice CRM. |
| Online Web Services | Krävs för åtkomst till SuperOffice CRM från en webbklient. |
| Sales Intelligence | Möjliggör [SAINT statusövervakning][2]. |
| Exchange Synchronizer | Gör det möjligt att använda SuperOffice Synchronizer. |
| SuperOffice Expander Services | Ger tillgång till funktioner för anonyma och externa användare via SuperOffice Audience eller tredjepartsprogram, bland annat. |
| Customer Centre | Ger tillgång till Kundcenter. |
| Sales Quote Management | Ger tillgång till offerter. |

### Användarlicenser (planer)

Slutligen finns det användarlicenser för SuperOffice CRM, som köps för ett specifikt antal användare. Detta gäller bland annat följande produkter:

* Sales-Essentials
* Sales-Premium
* Service-Essentials
* Service-Premium
* Marketing-Essentials
* Marketing-Premium

## Relaterat innehåll

* [SuperOffice användarplaner och abonnemang][4]
* [Köp och aktivera licenser][1]
* [Licenser i tidigare versioner av SuperOffice][7]
* [Systemhändelser][3]

<!-- Referenced links -->
[16]: crm-suite.md
[1]: activate.md
[2]: ../../saint/learn/index.md
[3]: https://help.superoffice.com/docs/11/sv/admin/onsite/add-system-event.html
[4]: user-plans.md
[7]: https://help.superoffice.com/Documentation/Help/EN/CRM/WebHelpAdmin/index.htm#t=chap03%2FCRM_and_licences.htm
