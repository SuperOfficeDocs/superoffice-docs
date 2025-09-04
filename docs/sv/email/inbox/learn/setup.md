---
uid: help-sv-email-inbox-setup
title: Konfigurera inkorgen i SuperOffice
description: Läs om hur du konfigurerar och loggar in på inkorgen i SuperOffice. Den här funktionen är ett alternativ till WebTools för att koppla din e-post till SuperOffice CRM.
keywords: SuperOffice Inkorg, inkorgen i SuperOffice, konfigurera inkorg, e-postinställningar, IMAP, e-postanslutning
author: Bergfrid Dias
date: 05.28.2025
version: 10.5
content_type: concept
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Konfigurera inkorgen i SuperOffice

Inkorgen i SuperOffice är ett alternativt sätt att koppla din e-post till SuperOffice CRM. Den är avsedd för användare som inte kan använda [WebTools][9]. Inkorgen stöder endast IMAP-konton.

> [!NOTE]
> Inkorgen i SuperOffice stöder endast **ett** e-postkonto per användare. Om WebTools är installerat och anslutet till din e-post är funktionen Inkorg inte tillgänglig.

## Innan du börjar

* Kontrollera att **SuperOffice CRM** är vald som [standard e-postklient][8] i **Lokala inställningar**.

* Kontrollera att **IMAP är aktiverat** i din e-postklient.

* Bekräfta att **e-postadressen** du vill använda matchar den primära e-postadressen som är registrerad på ditt [kontaktkort][1] i SuperOffice.

## Anslut ditt e-postkonto

1. Klicka på <i class="ph ph-at" aria-hidden="true"></i> **Inkorg** i navigatorn.

    Första gången du öppnar inkorgen visas dialogrutan **Konfigurera e-postkonto**.

    ![Dialogrutan Konfigurera e-postkonto med fältet för e-postadress och knappen Nästa -screenshot][img1]

1. Ange den e-postadress du vill använda i fältet **E-postkonto**.

1. Klicka på **Nästa**.

    * SuperOffice försöker identifiera din e-postleverantör och omdirigerar dig till inloggning.
    * Om lösenordet är sparat hos leverantören kan autentiseringen slutföras automatiskt.
    * Om inte, ombeds du att ange lösenordet direkt hos leverantören (till exempel Microsoft eller Google).
    * När autentiseringen har slutförts visas inkorgen i SuperOffice.

1. Om autentiseringen misslyckas eller leverantören inte kan identifieras visas dialogrutan **Avancerade inställningar**. Du kan då ange serverinställningar manuellt.

## Konfigurera avancerade inställningar

Om automatisk konfiguration misslyckas måste du ange inställningarna för e-postservern manuellt. Alla obligatoriska fält måste fyllas i för att inkorgen i SuperOffice ska fungera korrekt.

1. Ange inställningar för inkommande e-post:

    * **Server för inkommande e-post:** Adressen till din IMAP-server
    * **Användarnamn:** Vanligtvis din fullständiga e-postadress
    * **Lösenord:** Lösenordet till din e-post
    * **SSL:** Aktivera eller inaktivera beroende på leverantörens krav

1. Ange inställningar för utgående e-post:

    * **Server för utgående e-post:** Adressen till din SMTP-server
    * **Användarnamn**, **Lösenord** och **SSL**: samma som för inkommande

1. Klicka på **Spara** för att koppla kontot.

![Avancerade inställningar för e-postkonto -screenshot][img4]

## Koppla från eller ändra ditt e-postkonto

Du kan koppla bort det aktuella e-postkontot och valfritt ansluta ett nytt konto.

1. Klicka på <i class="ph ph-user-circle" aria-label="Personliga inställningar"></i> i toppraden och välj **Alternativ för e-post**.

1. Gå till fliken **E-postkonto**.

    ![Fliken E-postkonto med knappen Redigera/ta bort -screenshot][img6]

1. Klicka på **Redigera/ta bort** för att koppla från kontot.

    * Detta öppnar samma dialogruta som används vid första anslutningen.
    * Stäng dialogen för att endast koppla bort kontot.
    * Ange en ny e-postadress och följ stegen för att återansluta.

> [!NOTE]
> Att ta bort ett konto raderar **inte** själva e-postkontot (till exempel ditt Gmail- eller Outlook-konto). Det kopplas endast bort från SuperOffice.

## Felsökningstips

* Inkorgen i SuperOffice stöder **inte POP3**. Endast IMAP är tillåtet.

* Om inkorgen inte uppdateras kan det bero på att din e-postleverantör blockerar anslutningen.
  * Kontrollera om du har fått ett meddelande om ett blockerat eller obehörigt inloggningsförsök.
  * Följ instruktionerna för att ge SuperOffice åtkomst till kontot.

* **Gmail-användare:** Från och med januari 2025 är IMAP aktiverat som standard. Om du ombeds ange lösenord, använd ett **applösenord** i stället för ditt vanliga Gmail-lösenord.

> [!TIP]
> För att justera layout, teckensnitt eller beteende för meddelanden, gå till <i class="ph ph-user-circle" aria-hidden="true"></i> **Personliga inställningar** > **Alternativ för e-post** > fliken **Allmänt**.

## Relaterat innehåll

* [Så här aktiverar du IMAP i Office 365][11] – FAQ
* [Så här skapar du ett applösenord i Google för tvåstegsverifiering med SuperOffice Inkorg][12] – FAQ
* [Ändra standard e-postklient i SuperOffice][8]

<!-- Referenced links -->
[1]: ../../../contact/learn/index.md
[8]: ../../learn/change-default-mail-client.md
[9]: ../../../../../integrations/webtools/index.md
[11]: https://learn.microsoft.com/en-au/exchange/troubleshoot/user-and-shared-mailboxes/pop3-imap-owa-activesync-office-365
[12]: https://community.superoffice.com/en/support-faqs/faq/how-do-i-generate-a-googleapp-password-to-use-2-step-verification-with-superoffice-inbox/

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/email/inbox-setup-dialog.png
[img4]: ../../../../media/loc/en/email/so-inbox-advanced-settings.png
[img6]: ../../../../media/loc/en/email/email-options-account.png
