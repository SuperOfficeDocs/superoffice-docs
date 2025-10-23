---
uid: help-da-licenses
title: SuperOffice og licenser
description: SuperOffice og licenser
keywords: licens, forbrugstjeneste, databaseejer, fanen status
author: digitaldiina, xt1
date: 10.22.2025
version: 11.5
content_type: concept
category: Settings and maintenance
topic: licenses
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: da
redirect_from: 
  - /da/admin/license/learn/screen/index
  - /da/admin/license/learn/index
  - /da/learn/administration
---

# SuperOffice og licenser

For at du kan logge på SuperOffice CRM fra en webklient kræves logonrettigheder til SuperOffice CRM og Essential- eller Premium-brugerlicens

## Se licensoplysninger

1. I Indstillinger og vedligeholdelse skal du gå til skærmbilledet Licenser.
1. Vælg fanen **SuperOffice**.
1. Listen viser de licenser, du har [købt og aktiveret][1]. Klik på et licensnavn for at få vist flere oplysninger om det.

## Skærmbilledet Licenser

### Fanen SuperOffice

Under fanen **SuperOffice** i skærmbilledet Licenser kan du se og opdatere licensinformationen til din version af SuperOffice CRM og tilhørende moduler.

> [!NOTE]
> Hvis der er installeret en tredjepartstilføjelse, vises der flere faner her.

#### Ejeroplysninger

Øverst er firmanavnet (dit firma/din organisation) og serienummeret. Hvis licensen er tidsbegrænset, vises udløbsdatoen under serienummeret.

#### Licensliste

Listen nederst viser, hvilke licenser der er i brug, og hvor mange der er tilgængelige. Klik på et licensnavn for at få vist oplysninger om licensen.

### Fanen Status

Opdaterede oplysninger om systemet vises under fanen **Status** i skærmbilledet Licenser. Skærmbilledet **Status** er inddelt i følgende hoveddele:

#### Database

Her vises den ejer af databasen, det serienummer og den type, som angives ved installation. Derudover vises, om det er en central database eller en satellitdatabase. Du kan se den næste udløbsdato og navnet på den bruger, der er logget på.

#### Forbrugstjenester

Klik på denne knap for at åbne dashboardet for dine forbrugsafregnede tjenester.

Forbrugsafregnede tjenester er tjenester, der faktureres, når du har overskredet et vist niveau/en vis mængde af

* Brugt lagerplads
* E-mails sendt via Udsendelser
* Logon på kundecenter
* Indledte chatsessioner
* Formularindsendelser

Administratorer kan følge med i, præcis hvor meget hver tjeneste bliver brugt pr. måned. Når dit firma overskrider grænsen, faktureres du automatisk for disse tjenester på din næste månedlige faktura. Grænsen afhænger af antallet af brugere. Jo flere brugere du har, jo højere bliver grænsen.

#### Systemmeddelelser

Denne liste viser statusmeddelelser fra systemet og tilføjede [hændelser][3]. Meddelelser om aktive importer, SAINT- eller fritekstindeksering osv. Vælg en meddelelse på listen for at få vist en beskrivelse. Du kan holde styr på hændelser, der er aktive i systemet.

Fanen **Systemhændelser** består af to dele:

* **Hændelser**.
* **Beskrivelse**, viser detaljerede oplysninger om den hændelse, der aktuelt er valgt under **Hændelser**.

Under **Systemmeddelelser** finder du følgende kolonner:

| Kolonne | Beskrivelse |
|---|---|
| Hændelse | Viser navnet for hændelsen. |
| Status | Viser status for hændelsen. |
| Meddelelse | Viser beskrivelsen af hændelsen. |
| Aktiveret | Viser, hvornår begivenheden blev startet. |
| Aktiveret af | Viser, hvem der startede hændelsen (bruger-id og portræt). |
| Afsluttet | Viser, hvornår hændelsen forventes at slutte. |
| Type | Viser, om hændelsen gælder for hele systemet. |

## <a id="types"></a>Licenstyper

### Systemlicenser

| Licens | Beskrivelse |
|---|---|
| System | Angiver, hvilke systemer du har adgang til. |
| SuperOffice Server | Påkrævet til at bruge SuperOffice CRM. |
| Online Web Services | Påkrævet for at få adgang til SuperOffice CRM fra en webklient. |
| Sales Intelligence | Tillader [SAINT-statusovervågning][2]. |
| Exchange Synchronizer | Tillader brug af SuperOffice Synchronizer. |
| SuperOffice Expander Services | Tillader funktionalitet for anonyme og eksterne brugere via blandt andet SuperOffice Audience eller tredjepartsapplikationer. |
| Customer Centre | Tillader brug af Kundecenteret. |
| Håndtering af salgstilbud | Tillader brug af tilbud. |

### Brugerplaner

Endelig er der brugerplaner til SuperOffice CRM, som købes til et bestemt antal brugere. Dette gælder blandt andet følgende produkter:

* Sales-Essentials
* Sales-Premium
* Service-Essentials
* Service-Premium
* Marketing-Essentials
* Marketing-Premium

### Site-licenser og bruger-licenser (Windows - ældre)

Licenser til SuperOffice CRM til Windows (sidste udgivelse [SuperOffice G8 8.5 R17][6]) købes til et bestemt antal brugere.

## <a id="dev"></a>Bag kulissene - lisenssystemet

Lisenssystemet har egne databaser:

* [ModuleOwner][11] – en utsteder av lisenser

  * Vanligvis bare én rad (SuperOffice).
  * Inneholder globale utløpsdatoer.

* [ModuleLicense][12] – én rad per lisens

  * Det finnes flere lisenser enn det som vises i GUI.
  * Flere typer: System, sted, bruker; av/på eller med angitt antall.
  * Synlige lisenser (som brukerplaner) vises i Admin. Brukerplaner har `ExtraFlags = 1`.
  * Skjulte lisenser (som **user**-pålogging eller **web**-klientlisens) vises ikke i GUI, men sjekkes i kode for å bekrefte at funksjonen er tilgjengelig for brukeren.

| Lisens | ModuleLicense.Type | Beskrivelse |
|---|---|---|
| **Systemlisenser** | 1 | Definerer hvilke funksjoner som er tilgjengelige for hele systemet.  <br />Eksempel: **saint**-lisens er til stede hvis Sales Intelligence er aktivert. Denne lisensen er skjult og aktiveres implisitt. SuperOffice-klienten sjekker etter den og aktiverer SAINT-funksjoner hvis den finnes. |
| **Stedslisenser** | 2 | Brukes sjelden i dag. Tidligere brukt i satelittmiljøer hvor noen lisenser var knyttet til bestemte steder. |
| **Brukerlisenser** | 3 | Tildeles direkte til brukere. Antall tildelinger kan ikke overstige antall tilgjengelige lisenser.  <br />Noen brukerlisenser er skjult for å forenkle GUI. Disse aktiveres gjennom brukerplaner.  <br />Brukerplaner har `ModuleLicense.ExtraFlags = 1` og definerer implisitte lisenser i `ExtraInfo`-feltet, for eksempel: <br>`"set=user,web,chat-cal"` tildeler lisensene **user**, **web** og **chat-cal** automatisk. |

### Tilordne brukerlisenser

[LicenseAssocLink][13] – kobler en spesifikk `moduleLicense` til en bestemt bruker. Dette er hvordan "John" blir en bruker og får Windows-klienttilgang: det blir 2 rader.

Summen av lisenser som er tildelt for en modul, må ikke overstige antallet i `moduleLicense`. En ny lisens fra SuperLicense blir avvist hvis det allerede er for mange tildelinger.

### Signering av lisenser

Lisenser signeres med offentlig/privat nøkkel.

Privat nøkkel er strengt beskyttet, og uten den kan man ikke lage en fungerende lisenskodegenerator.

Hver `moduleLicense`-rad signeres, og alle rader har hash-sjekk for å forhindre manipulering.

**Oppsummert:** Endrer du dem, slutter de å virke. Kun SoAdmin og NetServer kan redigere dem. Ingen andre.
Hackere kan hacke DLL-filer, men ikke lage fungerende lisensgeneratorer for bruk med uhacket kode.

### Telle brukere

Det finnes to tilnærminger:

#### 1: Hent lisens og les antall user/web-lisenser

Brukere må ha både **user** og **web** for å logge inn i SuperOffice Web. Dette tallet er øvre grense, ikke antallet i bruk.

Noen kunder har mange lisenser fordi de betaler etter bruk (SCIM). Da må du telle aktive brukere, ikke hvor mange lisenser som er tilgjengelige.

#### 2: Hent lisens og summer antall brukte lisenser med ExtraFlags=1

Brukerplanene er det kundene betaler for. De inkluderer flere implisitte, skjulte lisenser.

Samme SCIM-forbehold: Tell antall brukte brukerplaner, ikke total tilgjengelig mengde.

## Relateret indhold

* [SuperOffice brugerplaner og abonnementer][4]
* [Køb og aktivering af licenser][1]
* [Tidligere versioner af SuperOffice][7]
* [Systemhændelser][3]

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
