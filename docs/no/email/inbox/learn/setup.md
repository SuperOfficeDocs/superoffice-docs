---
uid: help-no-email-inbox-setup
title: Konfigurer SuperOffice-innboksen
description: SuperOffice-innboksen er en alternativ måte å koble e-posten din til SuperOffice CRM for e-postklienter som ikke kan kobles til via WebTools. Finn ut hvordan du konfigurerer og logger på for første gang.
author: SuperOffice RnD
date: 02.14.2023
keywords: E-post, innboks
topic: howto
language: no
---

# Konfigurer SuperOffice-innboksen

SuperOffice-innboksen er en alternativ måte å koble e-posten din til SuperOffice CRM for e-postklienter som ikke kan kobles til via WebTools.

## Før du begynner

* Kontroller at IMAP er aktivert i e-postklienten. SuperOffice-innboksen støtter de fleste IMAP-e-postservere.

* For å kunne sende ut e-post fra SuperOffice CRM må du sørge for at e-postadressen du skal bruke med SuperOffice-innboksen, er den samme som den første e-posten som ble registrert på personkortet/skjermen.

![Du kan sjekke hvilken e-post du har registrert i personkortet ditt -screenshot][img2]

## Konfigurere e-postkonto

For å få tilgang til e-post må du først spesifisere detaljer om e-postkontoen din.

Se denne videoen for å se hvor raskt og enkelt du kan konfigurere SuperOffice-innboksen, eller følg trinnene nedenfor (videolengde -1:34):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/QoAanZgQs5A]

### Trinn

1. Klikk på Innboks-ikonet i navigatormenyen. Skjermbildet **Konfigurer e-postkonto** vises første gang du åpner innboksen.

1. I feltet **E-postkonto** skriver du inn e-postadressen til kontoen du vil bruke i SuperOffice.

    ![E-postkonto -screenshot][img3]

1. Hvis du vil angi informasjon for innkommende og utgående e-post, klikker du på **Avanserte innstillinger**. Hvis ikke, klikker du på **Neste**. SuperOffice vil deretter prøve å sette opp denne informasjonen for deg.

1. I feltet **Passord** skriver du inn passordet ditt.

1. Klikk på **Logg på**.

    * Hvis SuperOffice gjenkjenner e-postleverandøren (for eksempel Gmail), konfigureres serverinnstillingene automatisk, og innboksen lastes inn.
    * Hvis den ikke får opplysningene riktige eller e-postadressen og passordet du skrev inn ikke er riktig, åpnes dialogboksen **Avanserte innstillinger**. Angi eller kontroller konfigurasjonsinformasjon manuelt for innkommende og utgående servere.

## Slik legger du til serverinformasjon manuelt

### Innstillinger for innkommende e-post

Hvis du vil importere e-postene dine til SuperOffice CRM, skriver du inn IMAP-serverdetaljene i innstillingene for e-postklienten.

* Brukernavn: din fullstendige e-postadresse
* Passord: passordet for e-postkontoen din
* SSL: På/Av – avhenger av e-postleverandørens innstillinger (se innstillinger for Outlook og Gmail)

### Innstillinger for utgående e-post

Hvis du vil sende e-post fra SuperOffice CRM, skriver du inn SMTP-serveropplysningene.

* Brukernavn: din fullstendige e-postadresse
* Passord: passordet for e-postkontoen din
* SSL: avhenger av leverandørens innstillinger for e-post (se innstillinger for Outlook og Gmail)

![Avanserte innstillinger – gå til Innboks for å legge til riktig e-postserverinformasjon manuelt -screenshot][img4]

## Endre e-postkonfigurasjonen i SuperOffice-innboksen

1. Hvis du vil redigere eller fjerne den tilknyttede e-postkontoen, klikker du på profilikonet ditt øverst i høyre hjørne og velger **E-postalternativer**.

    ![Alternativer for e-post -screenshot][img5]

1. Velg fanen **E-postkonto** og trykk på **Rediger/fjern**-knappen.

    ![Alternativer for e-post -screenshot][img6]

## Hvorfor er ikke e-postlisten oppdatert?

Noen e-postleverandører, for eksempel Gmail, blokkerer påloggingsforsøk fra ukjente apper. Sjekk innboksen din for å se om e-postleverandøren din har sendt deg informasjon om et uautorisert påloggingsforsøk. Følg instruksjonene i e-posten for å gi SuperOffice tilgang til kontoen din.

> [!TIP]
> For å få tilgang til e-postalternativene, gå til <i class="ph ph-user-circle" aria-hidden="true"></i> **Personlige innstillinger** > **E-postalternativer**.

<!-- Referenced links -->

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/email/getstarted-contact-mycontactcard.png
[img3]: ../../../../media/loc/en/email/getstarted-inbox-login.png
[img4]: ../../../../media/loc/en/email/so-inbox-advanced-settings.png
[img5]: ../../../../media/loc/en/email/email-options-general.png
[img6]: ../../../../media/loc/en/email/email-options-account.png
