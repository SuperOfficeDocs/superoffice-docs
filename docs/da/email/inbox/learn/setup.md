---
uid: help-da-email-inbox-setup
title: Opsætning af SuperOffice Indbakke
description: SuperOffice-indbakken er en alternativ måde at forbinde din e-mail til din SuperOffice CRM til e-mailklienter, der ikke kan forbindes via WebTools. Lær, hvordan du konfigurerer det og logger ind første gang.
keywords: e-mail, indbakke
author: SuperOffice RnD
date: 02.14.2023
topic: howto
language: da
---

# Opsætning af SuperOffice Indbakke

SuperOffice-indbakken er en alternativ måde at forbinde din e-mail til din SuperOffice CRM til e-mailklienter, der ikke kan forbindes via WebTools.

## Før du starter

* Sørg for, at IMAP er aktiveret i din e-mail-klient. SuperOffice Inbox understøtter de fleste IMAP-mailservere.

* For at kunne sende e-mails fra SuperOffice CRM skal du sørge for, at den e-mailadresse, du skal bruge med SuperOffice-indbakken, er den samme som den første e-mail, der er registreret på dit visitkort/skærm.

![Du kan kontrollere, hvilken e-mail du har registreret på dit kontaktkort -screenshot][img2]

## Konfigurer e-mailkonto

For at få adgang til e-mail skal du først angive detaljer om din e-mail-konto.

Se denne video for at se, hvor hurtigt og nemt du kan konfigurere din SuperOffice-indbakke, eller følg nedenstående trin:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/QoAanZgQs5A]

(videoens længde: 1:34)

### Trin

1. Klik på ikonet Indbakke i navigatormenuen. Skærmbilledet **Konfigurer e-mail-konto** vises, første gang du åbner indbakken.

1. Indtast e-mailadresseni for den konto, du vil bruge i SuperOffice, i feltet **E-mailkonto**.

    ![x -screenshot][img3]

1. Hvis du vil angive oplysninger om indgående og udgående e-mail, skal du klikke på **Avancerede indstillinger**. Hvis ikke, skal du klikke på **Næste**. SuperOffice vil derefter forsøge at konfigurere disse oplysninger for dig.

1. Indtast din adgangskode i feltet **Adgangskode**.

1. Klik på **Log ind**.

    * Hvis SuperOffice genkender e-mail-udbyderen (f.eks. Gmail), konfigureres serverindstilingerne automatisk og indbakken indlæses.
    * Hvis oplysningerne ikke er korrekte, eller hvis den indtastede e-mail-adresse og adgangskode ikke er korrekte, åbnes dialogboksen **Avancerede indstillinger** . Angiv eller kontroller konfigurationsoplysninger for indgående og udgående servere manuelt.

## Sådan tilføjes serveroplysninger manuelt

### Indstillinger for indgående mail

For at få dine e-mails importeret til SuperOffice CRM skal du indtaste dine IMAP-serveroplysninger, der findes i din e-mailklients indstillinger.

* Brugernavn: din fulde e-mailadresse
* Adgangskode: adgangskoden til din e-mailkonto
* SSL: Til/Fra - afhænger af din e-mailudbyders indstillinger (se indstillinger for Outlook og Gmail)

### Indstillinger for udgående e-mail

Hvis du vil sende e-mails fra SuperOffice CRM, skal du indtaste dine SMTP-serveroplysninger.

* Brugernavn: din fulde e-mailadresse
* Adgangskode: adgangskoden til din e-mailkonto
* SSL: afhænger af din e-mailudbyders indstillinger (se indstillinger for Outlook og Gmail)

![Avancerede indstillinger - gå til Indbakke for manuelt at tilføje korrekte e-mail-serveroplysninger -screenshot][img4]

## Skift mailkonfiguration i SuperOffice Inbox

1. Hvis du vil redigere eller fjerne din tilknyttede e-mail-konto, skal du klikke på dit profilikon i øverste højre hjørne og vælge **E-mail-indstillinger**.

    ![Indstillinger for e-mail -screenshot][img5]

1. Vælg fanen **E-mailkonto**, og tryk på knappen **Rediger/fjern**.

    ![Indstillinger for e-mail -screenshot][img6]

## Hvorfor opdateres e-maillisten ikke?

Nogle e-mailudbydere, f.eks. Gmail, blokerer fosøg på login fra ukendte apps. Tjek din indbakke for at se, om din e-mailudbyder har sendt dig oplysninger om et uautoriseret forsøg på at logge ind. Følg instruktionerne i e-mailen for at give SuperOffice adgang til din konto.

> [!TIP]
> Hvis du vil have adgang til e-mailindstillingerne, skal du gå til <i class="ph ph-user-circle" aria-hidden="true"></i> **Personlige indstillinger** > **E-mailindstillinger**.

<!-- Referenced links -->

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/email/getstarted-contact-mycontactcard.png
[img3]: ../../../../media/loc/en/email/getstarted-inbox-login.png
[img4]: ../../../../media/loc/en/email/so-inbox-advanced-settings.png
[img5]: ../../../../media/loc/en/email/email-options-general.png
[img6]: ../../../../media/loc/en/email/email-options-account.png
