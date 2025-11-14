---
uid: help-no-licenses
title: CRM og lisenser
description: CRM og lisenser
keywords: lisens, brukerplan, Windows, målt tjeneste, databaseeier, status-fane
author: digitaldiina, xt1
date: 10.22.2025
version: 11.5
content_type: concept
category: Settings and maintenance
topic: licenses
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: no
redirect_from: 
  - /no/admin/license/learn/screen/index
  - /no/admin/license/learn/index
  - /no/learn/administration
---

# SuperOffice og lisenser

For å logge på SuperOffice CRM fra en webklient trenger du påloggingsrettigheter til SuperOffice CRM og en Essential eller en Premium brukerplan

## Vise lisensinformasjon

1. Gå til skjermbildet Lisenser under Innstillinger og vedlikehold.
1. Velg **SuperOffice**-fanen.
1. Listen viser lisensene du har [kjøpt og aktivert.][1] Klikk et lisensnavn for å vise mer informasjon om den.

## Lisenser-bildet

### SuperOffice-fanen

I fanen **SuperOffice** i Lisenser-bildet kan du vise og oppdatere lisensinformasjonen for din versjon av SuperOffice CRM og tilhørende moduler.

> [!NOTE]
> Hvis et tillegg fra tredjepart er installert, vises det flere faner her.

#### Informasjon om eier

Øverst er firmanavnet (firmaet/organisasjonen din) og serienummeret. Hvis lisensen er tidsbegrenset, vises utløpsdatoen under serienummeret.

#### Lisensliste

Listen nederst viser hvilke lisenser som er i bruk, og hvor mange som er tilgjengelige. Klikk på et lisensnavn for å vise informasjon om den.

### Fanen Status

I **Status**-fanen i Lisenser-bildet finner du oppdatert informasjon om systemet. **Status**-bildet er inndelt i følgende hoveddeler:

#### Database

Her vises databasens eier, serienummer og type, som angis ved installering. Det viser også om det er en sentral database eller en satellittdatabase. Du kan se neste utløpsdato og navnet til pålogget bruker.

#### Forbruk

Klikk på denne knappen for å åpne dashbord for ditt forbruk.

Forbruk er tjenester som faktureres når du overskrider et bestemt nivå/antall

* Brukt lagringsplass
* E-post sendt via utsendelser
* Kundesenterpålogginger
* Startede chatsesjoner
* Skjemainnsendinger

Administratorer kan holde oversikt over nøyaktig hvor mye hver tjeneste brukes per måned. Når firmaet overskrider terskelen, blir du automatisk fakturert for disse tjenestene på den neste månedlige fakturaen. Terskelen avhenger av antall brukere. Jo flere brukere du har, desto høyere blir terskelen.

#### Systemmeldinger

Denne listen viser statusmeldinger fra systemet og [hendelser][3] som er lagt til. Varsler om aktiv import, SAINT eller fritekstindeksering og så videre. Velg et varsel i listen for å vise en beskrivelse. Du kan holde oversikt over hendelser som er aktive i systemet.

Fanen **Systemoperasjoner** består av to deler:

* **Operasjoner**.
* **Beskrivelse**, viser detaljinformasjon om hendelsen som er merket under **Hendelser**.

Du finner følgende kolonner under **Systemmeldinger**:

| Kolonner | Beskrivelse |
|---|---|
| Operasjon | Viser navn på operasjonen. |
| Status | Viser status for operasjonen. |
| Melding | Viser beskrivelse for operasjonen. |
| Aktivert | Viser når operasjonen ble satt i gang. |
| Aktivert av | Viser hvem som satt i gang operasjonen (bruker-ID og miniatyrbilde). |
| Avsluttes | Viser når operasjonen antas å være ferdig. |
| Type | Viser om hendelsen gjelder for hele systemet. |

## <a id="types"></a>Lisenstyper

### Systemlisenser

| Lisens | Beskrivelse |
|---|---|
| System | Angir hvilke systemer du har tilgang til. |
| SuperOffice Server | Kreves for å bruke SuperOffice CRM. |
| Online Web Services | Kreves for å få tilgang til SuperOffice CRM fra en webklient. |
| Sales Intelligence | Tillater [SAINT-statusovervåking][2]. |
| Exchange Synchronizer | Tillater bruk av SuperOffice Synchronizer. |
| SuperOffice Expander Services | Tillater funksjonalitet for anonyme og eksterne brukere via blant annet SuperOffice Audience eller tredjepartsapplikasjoner. |
| Kundesenter | Tillater bruk av Kundesenter. |
| Sales Quote Management | Tillater bruk av tilbud. |

### Sitelisenser

Det finnes også såkalte sitelisenser. En *site* i SuperOffice-termer tilsvarer en database eller en satellittdatabase. En sitelisens angir følgende:

| Lisens | Beskrivelse |
|---|---|
| Satellitt | Antall satellittdatabaser organisasjonen kan definere. |
| Reporter Studio | Maksimalt antall siter som kan bruke SuperOffice Reporter Studio. |
| Audience | Maksimalt antall siter som kan bruke SuperOffice Audience. |

### Brukerplaner

Sist er det brukerlisenser for SuperOffice CRM, som kjøpes for et bestemt antall brukere. Dette gjelder blant annet følgende produkter:

* Sales-Essentials
* Sales-Premium
* Service-Essentials
* Service-Premium
* Marketing-Essentials
* Marketing-Premium

## Sitelisenser og brukerlisenser (Windows – EOL)

Lisenser for SuperOffice CRM for Windows (siste release [SuperOffice G8 8.5 R17][6]) kjøpes for et bestemt antall brukere.

## <a id="dev"></a>Bak kulissene – lisenssystemet

Lisenssystemet har egne sett med databasetabeller:

* [ModuleOwner][11] – en utsteder av lisenser
  * Vanligvis bare én rad (SuperOffice).
  * Inneholder globale utløpsdatoer.

* [ModuleLicense][12] – én rad per lisens
  * Flere lisenser enn du ser – noen er skjult i GUI.
  * Flere typer: System, sted, bruker; på/av eller med angitt antall.
  * Synlige lisenser (som brukerplaner) vises i administrasjonsbildet. Brukerplaner har `ExtraFlags = 1`.
  * Skjulte lisenser (som **user**-pålogging eller **web**-klientlisens) vises ikke i GUI, men sjekkes i koden for å verifisere at en funksjon er tilgjengelig for brukeren.

| Lisens | ModuleLicense.Type | Beskrivelse |
|---|---|---|
| **Systemlisenser** | 1 | Definerer hvilke funksjoner som er tilgjengelige for hele systemet. <br />Eksempel: **saint**-lisensen finnes hvis Sales Intelligence er aktivert. Lisensen er skjult (ikke på prisliste) og aktiveres implisitt. SuperOffice-klienten sjekker for den og aktiverer SAINT-funksjonene. |
| **Stedslisenser** | 2 | Brukes sjelden i dag. Tidligere brukt i satellittoppsett, der enkelte lisenser var knyttet til spesifikke steder. |
| **Brukerlisenser** | 3 | Lisenser som tildeles direkte til brukere. Antall tildelinger kan ikke overstige antallet tilgjengelige lisenser. <br />Noen brukerlisenser kan være skjult for å forenkle brukergrensesnittet. Disse aktiveres gjennom brukerplaner. <br />Brukerplaner har `ModuleLicense.ExtraFlags = 1` og definerer implisitte lisenser i feltet `ExtraInfo`, for eksempel:<br>`"set=user,web,chat-cal"` tildeler lisensene **user**, **web** og **chat-cal** automatisk. |

### Tilordning av brukerlisenser

[LicenseAssocLink][13] – tildeler en bestemt `moduleLicense` til en spesifikk bruker. Det er slik «John» blir en bruker og Windows-klientbruker – det blir to oppføringer.

Summen av tildelte lisenser for en gitt modul kan ikke overstige verdien i `moduleLicense`. Et nytt lisenssett fra SuperLicense vil bli avvist dersom for mange allerede er tildelt.

### Signering av lisenser

Lisenser signeres med offentlig/privat nøkkel.

Den private nøkkelen er strengt beskyttet – uten den er det ikke mulig å lage en fungerende lisenskodegenerator.

Hver `moduleLicense`-rad signeres, og alle rader er hash-sjekket for å gjøre det vanskeligere å manipulere dem.

**Oppsummert:** Hvis du tukler med dem, slutter de å virke. Bare SoAdmin og NetServer kan endre dem – ingen andre.
Hackere kan manipulere DLL-filer, men ikke lage en fungerende lisensgenerator som virker med originalkode.

### Telling av brukere

Det finnes to tilnærminger:

#### 1: Hent lisens og les antallet user/web-lisenser

Brukere må ha både **user** og **web** for å logge inn i SuperOffice Web. Dette tallet er en øvre grense og viser ikke hvor mange som faktisk er i bruk.

Noen kunder har svært mange lisenser fordi de betaler etter bruk via SCIM. Da må man telle aktive brukere, ikke totalt antall tilgjengelige lisenser.

#### 2: Hent lisens og summer antallet lisenser i bruk med ExtraFlags = 1

Brukerplaner er det brukeren faktisk betaler for. De inkluderer flere implisitte, skjulte lisenser.

Samme SCIM-unntak gjelder: tell antall brukte brukerplaner, ikke totalen som er tilgjengelig.

## Relatert innhold

* [SuperOffice-brukerplaner og abonnement][4]
* [Kjøpe og aktivere lisenser][1]
* [Lisenser i tidligere versjoner av SuperOffice][7]
* [Systemoperasjoner][3]

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
