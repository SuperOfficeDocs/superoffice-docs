---
uid: help-sv-licenses
title: SuperOffice och licenser
description: SuperOffice och licenser
keywords: licens, mätt tjänst, databasägare, fliken Status
author: digitaldiina, xt1
date: 10.22.2025
version: 11.5
content_type: concept
category: Settings and maintenance
topic: licenses
audience: settings
audience_tooltip: Settings and maintenance
index: true
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

Här visas databasens ägare, serienummer och typ som anges vid installation. Här anges också om det är en central databas eller en satellitdatabas. Du kan även se nästa utgångsdatum och namnet på den inloggade användaren.

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

### Platslicenser och Användarlicenser (Windows – äldre)

Licenser för SuperOffice CRM för Windows (senaste versionen [SuperOffice G8 8.5 R17][6]) köps för ett specifikt antal användare.

## <a id="dev"></a>Bakom kulisserna – licenssystemet

Licenssystemet har egna databas-tabeller:

* [ModuleOwner][11] – en utfärdare av licenser
  * Innehåller normalt endast en rad (SuperOffice).
  * Innehåller globala utgångsdatum.

* [ModuleLicense][12] – en rad per licens
  * Det finns fler licenser än vad som visas i användargränssnittet.
  * Flera typer: System, plats, användare; på/av eller med ett definierat antal.
  * Synliga licenser (som användarplaner) visas i administratörsgränssnittet. Användarplaner har `ExtraFlags = 1`.
  * Dolda licenser (som **user**-inloggningsrättigheter eller **web**-klientlicens) visas inte i användargränssnittet men kontrolleras i koden för att bekräfta att funktionen är tillgänglig för användaren.

| Licenstyp | ModuleLicense.Type | Beskrivning |
|---|---|---|
| **Systemlicenser** | 1 | Definierar vilka funktioner som är tillgängliga i hela systemet. <br />Exempel: **saint**-licensen finns om Sales Intelligence är aktiverat. Licensen är dold (finns inte på prislistan) och aktiveras automatiskt. SuperOffice-klienten kontrollerar att licensen finns och aktiverar SAINT-funktionerna. |
| **Platslicenser** | 2 | Används sällan idag. Tidigare användes de i satellitmiljöer där vissa licenser tilldelades specifika platser istället för att vara globala. |
| **Användarlicenser** | 3 | Licenser som tilldelas direkt till användare. Antalet tilldelningar får inte överskrida antalet tillgängliga licenser. <br />Vissa användarlicenser kan vara dolda för att förenkla användargränssnittet. Dessa aktiveras via användarplaner. <br />Användarplaner har `ModuleLicense.ExtraFlags = 1` och definierar underliggande licenser i fältet `ExtraInfo`, till exempel:<br>`"set=user,web,chat-cal"` tilldelar licenserna **user**, **web** och **chat-cal** automatiskt. |

### Tilldelning av användarlicenser

[LicenseAssocLink][13] – kopplar en specifik `moduleLicense` till en viss användare. Det är så "Anna" blir användare och får åtkomst till Windows-klienten – två rader i tabellen.

Summan av tilldelade licenser för en modul får inte överskrida antalet i `moduleLicense`. Ett nytt licenspaket från SuperLicense kommer att nekas om det redan finns för många tilldelningar.

### Licenssignering

Licenser signeras med publik/privat nyckel.

Den privata nyckeln är strikt skyddad – utan den går det inte att skapa en fungerande licensnyckelgenerator.

Varje rad i `moduleLicense` signeras, och alla rader kontrolleras med hash för att förhindra manipulation.

**Sammanfattning:** Om du ändrar dem slutar de fungera. Endast SoAdmin och NetServer kan redigera dem.
Hackare kan manipulera DLL-filer, men inte skapa en fungerande licensgenerator som fungerar med originalkod.

### Räkna användare

Det finns två tillvägagångssätt:

#### 1: Hämta licens och läs antalet user/web-licenser

Användare måste ha både **user** och **web** för att kunna logga in i SuperOffice Web. Detta antal anger det övre taket, men säger inget om hur många som faktiskt används.

Vissa kunder har många licenser eftersom de betalar per användning via SCIM. Då ska du räkna aktiva användare, inte tillgängliga licenser.

#### 2: Hämta licens och summera antalet ExtraFlags = 1 i användning

Användarplanerna är det kunden betalar för. De omfattar flera dolda, underliggande licenser.

Samma undantag gäller för SCIM: räkna antalet aktiva användarplaner – inte det totala antalet tillgängliga.

## Relaterat innehåll

* [SuperOffice användarplaner och abonnemang][4]
* [Köp och aktivera licenser][1]
* [Licenser i tidigare versioner av SuperOffice][7]
* [Systemhändelser][3]

<!-- Referenced links -->
[1]: activate.md
[2]: ../../saint/learn/index.md
[3]: ../onsite/add-system-event.md
[4]: user-plans.md
[6]: https://community.superoffice.com/en/product-releases/release-notes/release-details/?release=SuperOffice_8.5_-_R17
[7]: https://help.superoffice.com/Documentation/Help/EN/CRM/WebHelpAdmin/index.htm#t=chap03%2FCRM_and_licences.htm
[11]: ../../database/tables/ModuleOwner.md
[12]: ../../database/tables/ModuleLicense.md
[13]: ../../database/tables/LicenseAssocLink.md
