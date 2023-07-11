---
uid: help-sv-webtools-install
title: Installera WebTools
description: Om du använder Windows OS behöver du WebTools för att integrera dina Outlook- och Microsoft Office-dokumentprogram med SuperOffice CRM.
author: SuperOffice RnD
so.date: 02.10.2023
keywords: WebTools
so.topic: howto
language: sv
---

# Installera WebTools

> [!NOTE]
> I Windows består WebTools av två komponenter: Mail Link och Web Extensions. På Mac består WebTools av endast en komponent: WebTools.

## Krav

* Beroende på ditt företags säkerhetsinställningar kan du behöva administratörsbehörighet i SuperOffice CRM för att koppla samman systemen.

* För Office 365-kopplingar måste du också kontrollera dina rättigheter i Office 365-miljön.

* Om du använder en Citrix-anslutning, måste IT-teamet göra kopplingarna åt dig.

## Installera WebTools for Windows OS

Titta på den här videon eller följ guiden nedan för att lära dig hur du installerar WebTools for Outlook med Windows OS (videolängd - 3:00):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/PGh6An9o8mA]

### Steg

1. Gå till ![ikon][img1] huvudmenyn i det övre fältet.
2. Välj **Hämta** &gt; **SuperOffice WebTools**. Hjälpen för SuperOffice WebTools wizard visas.
3. I hjälpen väljer du **Persondator** &gt; **SuperOffice**, och klickar på **Hämta** för att ladda ner installationsfilen
4. Klicka på **Nästa** och **Stäng** för att stänga guiden för WebTools.
5. Klicka på den hämtade **SuperOffice.Web.Tools.exe**-filen i avsnittet Hämtningar i din webbläsare.
6. Dubbelklicka på filen **SuperOffice WebTools Installer.pkg** för att starta installationen.
7. Klicka på **Fortsätt**.
8. Klicka på **Installera**.
9. Om du blir ombedd att ange ditt användarnamn och lösenord för att installera, anger du detta och klickar sedan på **Installera programvara**.
10. När meddelandet ”Installationen lyckades” visas, stäng dialogrutan.
11. Slutligen loggar du ut från SuperOffice CRM, stänger webbläsarfönstret och öppnar webbläsarfönstret igen för att logga in på nytt.

Med WebTools installerat kan du börja skapa dokument i SuperOffice

## Installera WebTools för Mac

1. Gå till huvudmenyn i SuperOffice och välj **Ladda ner + SuperOffice WebTools**.

1. Öppna filen i **DiskImage** och dra och släpp applikationsfilen i mappen *appar* på din Mac

    ![Dra och släpp SuperOffice-ikonen i mappen appar -screenshot][img2]

1. Du är färdig.

## Valfri inställning för standardstart

Lägg till ”SuperOffice WebTools” till din användares "Startobjekt”, så att det startas tillsammans med din Mac.

![Lägg till SuperOffice WebTools i dina startobjekt så att programmet startas automatiskt -screenshot][img3]

## Preferenser

Ställ in inställningarna så att de passar dina behov:

* Öppna och redigera dokument direkt från SuperOffice
  * Be att få checka in när redigeringen är klar
  * Ladda endast upp vid dokumentstängning
* Visa larm för bokningar i SuperOffice
* Kopiera aktiviteter till iCal
  * Kopiera aktiviteter var [x minutes]
  * Kopiera deltagare till adressbok
* Kopiera kontakter till adressbok
  * Kopiera kontakter var [x hours]
  * Kopiera kontakter från ett specifikt urval i SuperOffice

![Ställ in inställningarna så att de passar dina behov -screenshot][img4]

## Relaterat innehåll

* [Hur laddar jag ner och installerar WebTools för SuperOffice?][1] \- FAQ

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/support-faqs/faq/how-do-i-download-and-install-web-tools-for-superoffice-crm/

<!-- Referenced images -->
[img1]: ../../../media/icons/main-menu-small.png
[img2]: ../../../media/loc/en/webtools/webtools-mac-install.jpg
[img3]: ../../../media/loc/en/webtools/webtools-mac-login-items.jpg
[img4]: ../../../media/loc/en/webtools/webtools-mac-preferences.jpg
