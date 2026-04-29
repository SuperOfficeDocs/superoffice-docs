---
uid: help-nl-connect-your-accounts
title: Accounts koppelen
description: Hoe je de wizard Gebruikersinstellingen gebruikt om je e-mailaccount en documentbeheer te koppelen aan SuperOffice CRM.
keywords: gebruikersinstellingen, e-mailverbinding, documentbeheer, WebTools, e-mail koppelen, e-mailaccount, wizard, persoonlijke instellingen
author: digitaldiina
date: 05.04.2026
version: 11.13
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: nl
---

# Accounts koppelen

*Beschikbaar voor nieuwe SuperOffice Online-klanten vanaf 11.11. Wordt geleidelijk uitgerold naar alle SuperOffice Online-klanten vanaf 11.13. Niet beschikbaar voor onsite-installaties.*

Als nieuwe gebruiker, of bij het instellen van een nieuwe computer, moet je je e-mailaccount en documentbeheer koppelen aan SuperOffice. Hiermee kun je:

* E-mails verzenden en uitgaande berichten automatisch archiveren in SuperOffice, zodat alle klantcommunicatie beschikbaar is voor je collega's.
* Vergaderuitnodigingen sturen naar externe ontvangers en uitnodigingen van anderen ontvangen.
* Documenten rechtstreeks vanuit SuperOffice aanmaken, openen en bewerken.

## De wizard openen

1. Klik op <i class="ph ph-user-circle" aria-label="Persoonlijke instellingen"></i> **Persoonlijke instellingen** rechtsboven.
1. Selecteer **Gebruikersinstellingen**.

De wizard leidt je door drie stappen.

## Stap 1: Overzicht

Het eerste scherm geeft een samenvatting van wat de wizard je zal helpen instellen. Klik op **Volgende** om door te gaan.

![SuperOffice Gebruikersinstellingen - overzicht van het eerste scherm van de wizard -screenshot][img1]

## Stap 2: E-mailaccount koppelen

Klik op **Koppelen** en volg de aanwijzingen om je inloggegevens te valideren.

![SuperOffice Gebruikersinstellingen - e-mailaccount koppelen -screenshot][img2]

Door je e-mailaccount te koppelen, kun je e-mails versturen vanuit SuperOffice en uitgaande berichten automatisch archiveren. Je kunt ook vergaderuitnodigingen versturen en accepteren.

> [!NOTE]
> Om met **inkomende** e-mails te werken en SuperOffice-functies rechtstreeks in je e-mailclient te gebruiken, installeer je na het voltooien van de wizard [SuperOffice voor Outlook][3] (Microsoft 365) of [SuperOffice Gmail Link][4] (Google Workspace).

## Stap 3: Documentbeheer koppelen

Je documentbeheer bepaalt hoe je documenten in SuperOffice aanmaakt, opent en bewerkt.

Klik op **WebTools downloaden**, voer het installatieprogramma uit en volg de instructies op het scherm. WebTools verbindt je SuperOffice-tenant met je lokale Office-toepassingen.

![SuperOffice Gebruikersinstellingen - WebTools downloaden voor documentbeheer -screenshot][img3]

> [!NOTE]
> Het installatieprogramma wordt automatisch geselecteerd voor je besturingssysteem. Als je WebTools rechtstreeks downloadt van de SuperOffice-downloadservice, kies dan het juiste installatieprogramma voor je besturingssysteem (Windows of macOS) en versie.

### Andere opties voor documentbeheer

WebTools met de SuperOffice-documentbibliotheek is de standaard. Je beheerder heeft mogelijk een andere optie geconfigureerd:

| Optie | Vereist |
|---|---|
| SuperOffice-documentbibliotheek (WebTools) | — |
| Microsoft 365 / SharePoint | Microsoft 365-abonnement + [beheerdersinstelling][5] |
| Google Workspace | Google Workspace-abonnement + [beheerdersinstelling][6] |

* **Microsoft 365 / SharePoint:** Slaat documenten op in SharePoint Online. Je kunt ze openen in SuperOffice CRM of in SharePoint en via een SharePoint-link delen met mensen die SuperOffice CRM niet gebruiken.

* **Google Workspace:** Slaat documenten op in Google Workspace. Je kunt documenten vanaf elke computer openen, bewerken en opslaan.

## Agenda synchroniseren

Het synchroniseren van je agenda maakt geen deel uit van de wizard. Als je afspraken en follow-ups gesynchroniseerd wilt houden tussen SuperOffice en je Outlook- of Google-agenda, stel je [Synchronizer voor SuperOffice][8] in (beschikbaar in de App Store).

## Gerelateerde inhoud

* [E-mail, document en agenda koppelen (versie 11.10 en eerder)][1]
* [SuperOffice Inbox instellen][2]
* [SuperOffice voor Outlook installeren][3]
* [SuperOffice Gmail Link installeren][4]
* [WebTools installeren][7]

<!-- Referenced links -->
[1]: connect-email-doc/index.md
[2]: ../../email/inbox/learn/setup.md
[3]: https://docs.superoffice.com/integrations/superoffice-for-outlook/index.html
[4]: https://docs.superoffice.com/integrations/gmail-link/index.html
[5]: https://docs.superoffice.com/integrations/sharepoint-documents/set-up.html
[6]: https://docs.superoffice.com/integrations/g-suite/index.html
[7]: https://docs.superoffice.com/integrations/webtools/install.html
[8]: https://appstore.superoffice.com/infobridge-software-b-v-/synchronizer-for-superoffice

<!-- Referenced images -->
[img1]: ../../../media/loc/en/learn/superoffice-user-setup-1.png
[img2]: ../../../media/loc/en/learn/superoffice-user-setup-2-connect-email.png
[img3]: ../../../media/loc/en/learn/superoffice-user-setup-3-webtools.png
