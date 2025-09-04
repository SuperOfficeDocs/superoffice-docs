---
uid: help-da-email-inbox-setup
title: Opsætning af SuperOffice Indbakke
description: Lær, hvordan du opsætter og logger ind i SuperOffice Indbakke. Denne funktion er et alternativ til WebTools for at forbinde din e-mailkonto til SuperOffice CRM.
keywords: SuperOffice Indbakke, opsæt indbakke, e-mailopsætning, IMAP, e-mailforbindelse
author: Bergfrid Dias
date: 05.28.2025
version: 10.5
content_type: concept
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Opsætning af SuperOffice Indbakke

SuperOffice Indbakke er en alternativ metode til at forbinde din e-mailkonto med SuperOffice CRM. Den er designet til brugere, der ikke kan bruge [WebTools][9]. Indbakken understøtter kun IMAP-konti.

> [!NOTE]
> SuperOffice Indbakke understøtter kun **én** e-mailkonto pr. bruger. Hvis WebTools er installeret og forbundet til din e-mail, er Indbakke-funktionen ikke tilgængelig.

## Før du starter

* Kontrollér, at **SuperOffice CRM** er valgt som din [foretrukne e-mailklient][8] under **Lokale indstillinger**.

* Sørg for, at **IMAP er aktiveret** i din e-mailklient.

* Bekræft, at den **e-mailadresse**, du vil bruge, matcher den primære e-mailadresse, der er registreret på dit [personkort][1] i SuperOffice.

## Tilslut din e-mailkonto

1. Klik på <i class="ph ph-at" aria-hidden="true"></i> **Indbakke** i navigatoren.

    Første gang du åbner indbakken, vises dialogboksen **Konfigurer e-mailkonto**.

    ![Dialogboksen Konfigurer e-mailkonto med e-mailfelt og Næste-knap -screenshot][img1]

1. Indtast den e-mailadresse, du vil bruge, i feltet **E-mailkonto**.

1. Klik på **Næste**.

    * SuperOffice forsøger at identificere din e-mailudbyder og viderestille dig til login.
    * Hvis din adgangskode er gemt hos udbyderen, kan godkendelsen gennemføres automatisk.
    * Hvis ikke, bliver du bedt om at indtaste adgangskoden direkte hos udbyderen (f.eks. Microsoft eller Google).
    * Efter vellykket godkendelse returneres du til SuperOffice, og indbakken åbnes.

1. Hvis godkendelsen mislykkes, eller udbyderen ikke kan identificeres, vises dialogboksen **Avancerede indstillinger**. Du kan så indtaste serveroplysninger manuelt.

## Konfigurer avancerede indstillinger

Hvis automatisk opsætning mislykkes, skal du indtaste dine e-mailserveroplysninger manuelt. Alle påkrævede felter skal udfyldes for at sikre, at e-mail kan sendes og modtages via SuperOffice Indbakke.

1. Indtast oplysninger for indgående e-mail:

    * **Server for indgående e-mail:** Din IMAP-serveradresse
    * **Brugernavn:** Normalt din fulde e-mailadresse
    * **Adgangskode:** Adgangskoden til din e-mailkonto
    * **SSL:** Slå til eller fra afhængigt af udbyderens krav

1. Indtast oplysninger for udgående e-mail:

    * **Server for udgående e-mail:** Din SMTP-serveradresse
    * **Brugernavn**, **Adgangskode** og **SSL**: som ovenfor

1. Klik på **Gem** for at tilslutte din konto.

![Avancerede indstillinger for e-mailkonto -screenshot][img4]

## Fjern eller skift din e-mailkonto

Du kan fjerne din nuværende e-mailkonto og eventuelt opdatere den ved at oprette forbindelse igen.

1. Klik på <i class="ph ph-user-circle" aria-label="Personlige indstillinger"></i> i toplinjen og vælg **E-mailindstillinger**.

1. Gå til fanen **E-mailkonto**.

    ![Fanen E-mailkonto med knappen Rediger/fjern -screenshot][img6]

1. Klik på **Rediger/fjern** for at afbryde forbindelsen til den aktuelle e-mailkonto.

    * Dette åbner den samme opsætningsdialog som ved første tilslutning.
    * Hvis du blot vil fjerne forbindelsen, skal du lukke dialogen.
    * For at oprette forbindelse igen skal du indtaste en ny e-mailadresse og følge opsætningsvejledningen.

> [!NOTE]
> Fjernelse af e-mailkontoen sletter **ikke** din faktiske e-mailkonto (f.eks. din Gmail- eller Outlook-konto). Den afbryder kun forbindelsen til SuperOffice.

## Fejlfinding

* SuperOffice Indbakke understøtter **ikke POP3**-konti. Kun IMAP er understøttet.

* Hvis indbakken ikke opdateres, kan det skyldes, at e-mailudbyderen blokerer forbindelsen.
  * Kontrollér din e-mailkonto for en besked om blokeret eller uautoriseret loginforsøg.
  * Følg instruktionerne for at give SuperOffice adgang til din konto.

* **Gmail-brugere:** Fra januar 2025 er IMAP permanent aktiveret som standard. Hvis du bliver bedt om en adgangskode, skal du bruge en **app-adgangskode** i stedet for din almindelige Gmail-adgangskode.

> [!TIP]
> Hvis du vil justere layout, skrifttype eller opførsel for meddelelser, skal du gå til <i class="ph ph-user-circle" aria-hidden="true"></i> **Personlige indstillinger** > **E-mailindstillinger** > fanen **Generelt**.

## Relateret indhold

* [Sådan aktiveres IMAP på Office 365-konto][11] – FAQ
* [Sådan genereres en Google-appadgangskode til brug af 2-trinsbekræftelse med SuperOffice Indbakke][12] – FAQ
* [Skift standard e-mailklient i SuperOffice][8]

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
