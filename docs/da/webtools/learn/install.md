---
uid: help-da-webtools-install
title: Installer WebTools
description: "Hvis du bruger Windows OS, skal du bruge WebTools til at integrere dine Outlook- og Microsoft Office-dokumentapplikationer med SuperOffice CRM."
author: SuperOffice RnD
so.date: 02.10.2023
keywords: WebTools
so.topic: howto
language: da
---

# Installer WebTools

> [!NOTE]
> På Windows består WebTools af to komponenter: Mail Link og Web Extensions. På Mac består WebTools kun af én komponent: WebTools.

## Forudsætninger

* Du skal muligvis have administratorrettigheder til SuperOffice CRM, afhængigt af din organisations sikkerhedsindstillinger, for at oprette systemforbindelser.

* For Office 365-forbindelser skal du også kontrollere dine rettigheder i Office 365-miljøet.

* Hvis du bruger en Citrix-forbindelse, skal dit IT-team oprette forbindelserne for dig.

## Installering af WebTools til Windows OS

Se denne video, eller følg vejledningen nedenunder for at lære, hvordan du installerer WebTools til Outlook ved hjælp af Windows OS (videolængde - 3:00):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/PGh6An9o8mA]

### Trin

1. Gå til ![ikonet][img1] Hovedmenu på toplinjen.
2. Vælg **Download** &gt; **SuperOffice WebTools**. Vejviseren for SuperOffice WebTools vises.
3. Vælg **Personal computer** &gt; **SuperOffice** i guiden, og klik på **Download** for at downloade installationsfilen
4. Klik på **Næste** og **Luk** for at lukke vejviseren WebTools.
5. Klik på den downloadede **SuperOffice.Web.Tools.exe-fil** i downloadsektionen i din browser.
6. Dobbeltklik på filen **SuperOffice WebTools Installer.pkg** for at starte installationen.
7. Klik på **Fortsæt**.
8. Klik på **Installer**.
9. Hvis du bliver bedt om at angive dit brugernavn og din adgangskode for at installere, skal du indtaste dem og klikke på **Installer software**.
10. Når meddelelsen "Installationen blev gennemført" vises, skal du klikke på Luk i dialogboksen.
11. Til sidst skal du logge af SuperOffice CRM, lukke webbrowservinduet og genåbne browservinduet for at logge ind igen.

Med WebTools installeret kan du begynde at oprette dokumenter inde fra SuperOffice

## Installer WebTools til Mac

1. Gå til hovedmenuen i SuperOffice, og vælg **Download + SuperOffice WebTools**.

1. Åbn filen i **DiskImage**, og træk og slip app-filen til mappen *Applikation* på din Mac

    ![Træk og slip SuperOffice-ikonet til mappen Applikationer -screenshot][img2]

1. Så er du klar.

## Valgfri indstilling for standardopstart

Tilføj "SuperOffice WebTools" til dine brugeres "login-elementer", så programmet starter sammen med din Mac.

![Tilføj SuperOffice WebTools til dine login-elementer for at få applikationen vist automatisk -screenshot][img3]

## Præferencer

Indstil præferencerne, så de passer til dine behov:

* Åbn og rediger dokument direkte fra SuperOffice
  * Bed om at tjekke ind, når du er færdig med at redigere
  * Upload kun ved dokumentlukning
* Vis alarmer for aftaler i SuperOffice
* Kopiér aktiviteter til iCal
  * Kopiér aktiviteter hver [x minutes]
  * Kopiér deltagere til Adressebog
* Kopiér personer til Adressebog
  * Kopiér personer hver [x hours]
  * Kopiér personer fra ét bestemt udvalg i SuperOffice

![Indstil præferencerne, så de passer til dine behov -screenshot][img4]

## Relateret indhold

* [Hvordan downloader og installerer jeg WebTools til SuperOffice?][1] - FAQ

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/support-faqs/faq/how-do-i-download-and-install-web-tools-for-superoffice-crm/

<!-- Referenced images -->
[img1]: ../../../media/icons/main-menu-small.png
[img2]: ../../../media/loc/en/webtools/webtools-mac-install.jpg
[img3]: ../../../media/loc/en/webtools/webtools-mac-login-items.jpg
[img4]: ../../../media/loc/en/webtools/webtools-mac-preferences.jpg
