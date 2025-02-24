---
uid: help-sv-email-inbox-setup
title: Konfigurera inkorgen i SuperOffice
description: Inkorgen i SuperOffice är ett alternativt sätt att koppla din e-post till din SuperOffice CRM för e-postklienter som inte kan anslutas via WebTools. Läs om hur du konfigurerar inkorgen och loggar in första gången.
keywords: e-post, inkorg
author: SuperOffice RnD
date: 02.25.2025
topic: howto
language: sv
---

# Konfigurera inkorgen i SuperOffice

Inkorgen i SuperOffice är ett alternativt sätt att koppla din e-post till din SuperOffice CRM för e-postklienter som inte kan anslutas via WebTools.

## Innan du börjar

* Kontrollera att IMAP är aktiverat i din e-postklient. Inkorgen i SuperOffice stöder de flesta IMAP-servrar.

* För att du ska kunna skicka e-post från SuperOffice CRM måste e-postadressen du ska använda med inkorgen i SuperOffice vara densamma som den första e-postadress som har registrerats på ditt kontaktkort/-fönster.

![Du kan kontrollera vilken e-postadress du har registrerat på ditt kontaktkort -screenshot][img2]

## Konfigurera e-postkonto

För att komma åt e-post måste du ange vissa uppgifter om ditt e-postkonto.

I den här filmen förklarar vi hur du snabbt och enkelt kan konfigurera din SuperOffice-inkorg. Du kan också följa anvisningarna nedan.

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/QoAanZgQs5A]

(filmens längd: 1:34)

### Steg

1. Klicka på ikonen Inkorg i navigatormenyn. Fönstret **Konfigurera e-postkonto** visas första gången du öppnar inkorgen.

1. I fältet **E-postkonto** anger du e-postadressen för det konto du vill använda i SuperOffice.

    ![x -screenshot][img3]

1. Om du vill ange information för inkommande och utgående e-post klickar du på **Avancerade inställningar**. Om inte, klickar du på **Nästa**. SuperOffice försöker då ange den här informationen åt dig.

1. I fältet **Lösenord** anger du ditt lösenord.

1. Klicka på **Logga in**.

    * Om SuperOffice känner igen e-postleverantören (t.ex. Gmail) konfigureras serverinställningarna automatiskt och inkorgen synkroniseras.
    * Om systemet inte hittar rätt uppgifter eller om e-postadressen och lösenordet du angav inte stämmer öppnas dialogrutan **Avancerade inställningar**. Ange eller kontrollera konfigurationsuppgifterna för inkommande och utgående servrar manuellt.

## Så lägger du till serverinformation manuellt

### Inställningar för inkommande e-post

För att dina e-postmeddelanden ska importeras till SuperOffice CRM måste du ange uppgifter om IMAP-servern, som du hittar i inställningarna för din e-postklient.

* Användarnamn: din fullständiga e-postadress
* Lösenord: lösenordet för ditt e-postkonto
* SSL: På/Av – beror på e-postleverantörens inställningar (se inställningar för Outlook och Gmail)

### Inställningar för utgående e-post

Om du vill skicka e-post från SuperOffice CRM anger du uppgifter om din SMTP-server.

* Användarnamn: din fullständiga e-postadress
* Lösenord: lösenordet för ditt e-postkonto
* SSL: beror på e-postleverantörens inställningar (se inställningar för Outlook och Gmail)

![Avancerade inställningar – gå till inkorgen för att manuellt ange korrekta uppgifter om e-postservern -screenshot][img4]

## Ändra e-postkonfigurationen i SuperOffice-inkorgen

1. Om du vill redigera eller ta bort ditt kopplade e-postkonto klickar du på profilikonen längst upp till höger och väljer **Alternativ för e-post**.

    ![Alternativ för e-post -screenshot][img5]

1. Välj fliken **E-postkonto** och klicka på knappen **Redigera/ta bort**.

    ![Alternativ för e-post -screenshot][img6]

## Varför uppdateras inte e-postlistan?

Vissa e-postleverantörer, till exempel Gmail, blockerar inloggningsförsök från okända appar. Kontrollera din inkorg för att se om din e-postleverantör har skickat information till dig om ett obehörigt inloggningsförsök. Följ anvisningarna i e-postmeddelandet för att ge SuperOffice åtkomst till ditt konto.

> [!TIP]
> För att komma åt e-postalternativen går du till <i class="ph ph-user-circle" aria-hidden="true"></i> **Personliga inställningar** > **Alternativ för e-post**.

<!-- Referenced links -->

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/email/getstarted-contact-mycontactcard.png
[img3]: ../../../../media/loc/en/email/getstarted-inbox-login.png
[img4]: ../../../../media/loc/en/email/so-inbox-advanced-settings.png
[img5]: ../../../../media/loc/en/email/email-options-general.png
[img6]: ../../../../media/loc/en/email/email-options-account.png
