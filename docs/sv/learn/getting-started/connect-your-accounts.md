---
uid: help-sv-connect-your-accounts
title: Anslut dina konton
description: Hur du använder guiden Användarinställningar för att ansluta ditt e-postkonto och dokumenthantering till SuperOffice CRM.
keywords: användarinställningar, e-postanslutning, dokumenthantering, WebTools, anslut e-post, e-postkonto, guide, personliga inställningar
author: digitaldiina
date: 03.17.2026
version: 11.11
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Anslut dina konton

*Tillgänglig för nya kunder från 11.11, tillgänglig för alla kunder från 11.13.*

Som ny användare, eller när du konfigurerar en ny dator, bör du ansluta ditt e-postkonto och din dokumenthantering till SuperOffice. Det gör att du kan:

* Skicka e-post och automatiskt arkivera utgående meddelanden i SuperOffice, så att all kundkommunikation är tillgänglig för dina kollegor.
* Skicka mötesinbjudningar till externa mottagare och ta emot inbjudningar från andra.
* Skapa, öppna och redigera dokument direkt från SuperOffice.

## Öppna guiden

1. Klicka på <i class="ph ph-user-circle" aria-label="Personliga inställningar"></i> **Personliga inställningar** längst upp till höger.
1. Välj **Användarinställningar**.

Guiden leder dig genom tre steg.

## Steg 1: Översikt

Den första skärmbilden sammanfattar vad guiden hjälper dig att konfigurera. Klicka på **Nästa** för att fortsätta.

![SuperOffice Användarinställningar - översikt över guidens första skärm -screenshot][img1]

## Steg 2: Anslut ditt e-postkonto

Klicka på **Anslut** och följ anvisningarna för att verifiera dina inloggningsuppgifter.

![SuperOffice Användarinställningar - anslut ditt e-postkonto -screenshot][img2]

Genom att ansluta ditt e-postkonto kan du skicka e-post från SuperOffice och arkivera utgående meddelanden automatiskt. Du kan också skicka och acceptera mötesinbjudningar.

> [!NOTE]
> Om du vill arbeta med **inkommande** e-post och komma åt SuperOffice-funktioner direkt i din e-postklient installerar du [SuperOffice för Outlook][3] (Microsoft 365) eller [SuperOffice Gmail Link][4] (Google Workspace) efter att ha slutfört guiden.

## Steg 3: Anslut din dokumenthantering

Din dokumenthantering styr hur du skapar, öppnar och redigerar dokument i SuperOffice.

Klicka på **Ladda ned WebTools**, kör installationsprogrammet och följ anvisningarna på skärmen. WebTools ansluter din SuperOffice-klientorganisation till dina lokala Office-program.

![SuperOffice Användarinställningar - ladda ned WebTools för dokumenthantering -screenshot][img3]

> [!NOTE]
> Installationsprogrammet väljs automatiskt utifrån ditt operativsystem. Om du laddar ned WebTools direkt från SuperOffice-nedladdningstjänsten väljer du rätt installationsprogram för ditt operativsystem (Windows eller macOS) och din version.

### Andra alternativ för dokumenthantering

WebTools med SuperOffice-dokumentbiblioteket är standard. Din administratör kan ha konfigurerat ett annat alternativ:

| Alternativ | Kräver |
|---|---|
| SuperOffice-dokumentbibliotek (WebTools) | — |
| Microsoft 365 / SharePoint | Microsoft 365-prenumeration + [administratörsinställning][5] |
| Google Workspace | Google Workspace-prenumeration + [administratörsinställning][6] |

* **Microsoft 365 / SharePoint:** Lagrar dokument i SharePoint Online. Du kan öppna dem i SuperOffice CRM eller i SharePoint och dela dem med personer som inte använder SuperOffice CRM via en SharePoint-länk.

* **Google Workspace:** Lagrar dokument i Google Workspace. Du kan öppna, redigera och spara dokument från vilken dator som helst.

## Synkronisera din kalender

Kalendersynkronisering är inte en del av guiden. Om du vill hålla möten och uppföljningar synkroniserade mellan SuperOffice och din Outlook- eller Google-kalender konfigurerar du [Synchronizer för SuperOffice][8] (tillgänglig i App Store).

## Relaterat innehåll

* [Anslut e-post, dokument och kalender (version 11.10 och tidigare)][1]
* [Konfigurera SuperOffice Inbox][2]
* [Installera SuperOffice för Outlook][3]
* [Installera SuperOffice Gmail Link][4]
* [Installera WebTools][7]

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
