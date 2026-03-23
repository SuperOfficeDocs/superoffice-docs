---
uid: help-no-connect-your-accounts
title: Koble til kontoene dine
description: Slik bruker du veiviseren Brukeroppsett til å koble e-postkontoen og dokumenthåndteringen din til SuperOffice CRM.
keywords: brukeroppsett, e-posttilkobling, dokumenthåndtering, WebTools, koble til e-post, e-postkonto, veiviser, personlige innstillinger
author: digitaldiina
date: 03.17.2026
version: 11.11
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Koble til kontoene dine

*Tilgjengelig for nye kunder fra 11.11, tilgjengelig for alle kunder fra 11.13.*

Som ny bruker, eller når du setter opp en ny datamaskin, bør du koble e-postkontoen og dokumenthåndteringen din til SuperOffice. Dette lar deg:

* Sende e-poster og automatisk arkivere utgående meldinger i SuperOffice, slik at all kundekommunikasjon er tilgjengelig for kollegaene dine.
* Sende møteinvitasjoner til eksterne mottakere og motta invitasjoner fra andre.
* Opprette, åpne og redigere dokumenter direkte fra SuperOffice.

> [!TIP]
> Hvis organisasjonen din bruker Microsoft Entra ID, oppdager og kobler SuperOffice til kontoene dine automatisk. Du trenger ikke å fullføre veiviseren manuelt.

## Åpne veiviseren

1. Klikk på <i class="ph ph-user-circle" aria-label="Personlige innstillinger"></i> **Personlige innstillinger** øverst til høyre.
1. Velg **Brukeroppsett**.

Veiviseren guider deg gjennom tre trinn.

## Trinn 1: Oversikt

Det første skjermbildet oppsummerer hva veiviseren hjelper deg med å sette opp. Klikk på **Neste** for å fortsette.

![SuperOffice Brukeroppsett - oversikt over det første skjermbildet i veiviseren -screenshot][img1]

## Trinn 2: Koble til e-postkontoen din

Klikk på **Koble til**, og følg instruksjonene for å bekrefte påloggingsinformasjonen din.

![SuperOffice Brukeroppsett - koble til e-postkontoen din -screenshot][img2]

Tilkobling av e-postkontoen din gir deg muligheten til å sende e-poster fra SuperOffice og arkivere utgående meldinger automatisk. Du kan også sende og godta møteinvitasjoner.

> [!NOTE]
> For å arbeide med **innkommende** e-poster og få tilgang til SuperOffice-funksjoner direkte i e-postklienten din, installer [SuperOffice for Outlook][3] (Microsoft 365) eller [SuperOffice Gmail Link][4] (Google Workspace) etter at du har fullført veiviseren.

## Trinn 3: Koble til dokumenthåndteringen din

Dokumenthåndteringen din styrer hvordan du oppretter, åpner og redigerer dokumenter i SuperOffice.

Klikk på **Last ned WebTools**, kjør installasjonsprogrammet, og følg instruksjonene på skjermen. WebTools kobler SuperOffice-tenanten din til de lokale Office-programmene dine.

![SuperOffice Brukeroppsett - last ned WebTools for dokumenthåndtering -screenshot][img3]

> [!NOTE]
> Installasjonsprogrammet velges automatisk basert på operativsystemet ditt. Hvis du laster ned WebTools direkte fra SuperOffice-nedlastingstjenesten, velger du riktig installasjonsprogram for operativsystemet ditt (Windows eller macOS) og versjonen din.

### Andre alternativer for dokumenthåndtering

WebTools med SuperOffice-dokumentbiblioteket er standard. Administratoren din kan ha konfigurert et annet alternativ:

| Alternativ | Krever |
|---|---|
| SuperOffice-dokumentbibliotek (WebTools) | — |
| Microsoft 365 / SharePoint | Microsoft 365-abonnement + [administratoroppsett][5] |
| Google Workspace | Google Workspace-abonnement + [administratoroppsett][6] |

* **Microsoft 365 / SharePoint:** Lagrer dokumenter i SharePoint Online. Du kan åpne dem i SuperOffice CRM eller i SharePoint og dele dem med personer som ikke bruker SuperOffice CRM via en SharePoint-lenke.

* **Google Workspace:** Lagrer dokumenter i Google Workspace. Du kan åpne, redigere og lagre dokumenter fra hvilken som helst datamaskin.

## Synkroniser kalenderen din

Kalendersynkronisering er ikke en del av veiviseren. Hvis du ønsker å holde avtaler og oppfølginger synkronisert mellom SuperOffice og Outlook- eller Google-kalenderen din, setter du opp [Synchronizer for SuperOffice][8] (tilgjengelig fra App Store).

## Relatert innhold

* [Koble til e-post, dokumenter og kalender (versjon 11.10 og tidligere)][1]
* [Konfigurere SuperOffice Inbox][2]
* [Installer SuperOffice for Outlook][3]
* [Installer SuperOffice Gmail Link][4]
* [Installer WebTools][7]

<!-- Referenced links -->
[1]: connect-email-doc/index.md
[2]: ../../email/inbox/learn/setup.md
[3]: ../../../../integrations/superoffice-for-outlook/index.md
[4]: ../../../../integrations/gmail-link/index.md
[5]: ../../../../integrations/sharepoint-documents/set-up.md
[6]: ../../../../integrations/g-suite/index.md
[7]: ../../../../integrations/webtools/install.md
[8]: https://appstore.superoffice.com/infobridge-software-b-v-/synchronizer-for-superoffice

<!-- Referenced images -->
[img1]: ../../../media/loc/en/learn/superoffice-user-setup-1.png
[img2]: ../../../media/loc/en/learn/superoffice-user-setup-2-connect-email.png
[img3]: ../../../media/loc/en/learn/superoffice-user-setup-3-webtools.png
