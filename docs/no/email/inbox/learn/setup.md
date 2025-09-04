---
uid: help-no-email-inbox-setup
title: Konfigurer SuperOffice-innboksen
description: Lær hvordan du konfigurerer og logger på SuperOffice-innboksen. Denne funksjonen er et alternativ til WebTools for å koble e-postkontoen din til SuperOffice CRM.
keywords: SuperOffice-innboks, konfigurer innboks, e-postoppsett, IMAP, e-posttilkobling
author: Bergfrid Dias
date: 05.28.2025
version: 10.5
content_type: concept
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Konfigurer SuperOffice-innboksen

SuperOffice-innboksen er en alternativ måte å koble e-postkontoen din til SuperOffice CRM. Den er laget for brukere som ikke kan bruke [WebTools][9]. Innboksen støtter kun IMAP-kontoer.

> [!NOTE]
> SuperOffice-innboksen støtter kun **én** e-postkonto per bruker. Hvis WebTools er installert og tilkoblet e-posten din, er ikke innboksfunksjonen tilgjengelig.

## Før du begynner

* Kontroller at **SuperOffice CRM** er valgt som din [foretrukne e-postklient][8] i **Lokale innstillinger**.

* Sørg for at **IMAP er aktivert** i e-postklienten din.

* Kontroller at **e-postadressen** du ønsker å bruke samsvarer med primæradressen som er registrert på [personkortet][1] ditt i SuperOffice.

## Koble til e-postkontoen din

1. Klikk på <i class="ph ph-at" aria-hidden="true"></i> **Innboks** i navigatoren.

    Første gang du åpner innboksen, vises dialogboksen **Konfigurer e-postkonto**.

    ![Dialogboksen for konfigurasjon av e-postkonto med e-postfelt og Neste-knapp -screenshot][img1]

1. I feltet **E-postkonto** skriver du inn e-postadressen du vil bruke.

1. Klikk på **Neste**.

    * SuperOffice prøver å oppdage e-postleverandøren din og omdirigerer deg til pålogging.
    * Hvis passordet ditt er lagret, kan godkjenningen fullføres automatisk.
    * Hvis ikke, blir du bedt om å skrive inn passordet direkte hos leverandøren (for eksempel Microsoft eller Google).
    * Når autentiseringen er vellykket, returneres du til SuperOffice og innboksen åpnes.

1. Hvis autentisering mislykkes eller leverandøren ikke blir gjenkjent, vises dialogboksen **Avanserte innstillinger**. Du kan da skrive inn serverinnstillingene manuelt.

## Konfigurer avanserte innstillinger

Hvis automatisk oppsett mislykkes, må du legge inn serverinnstillingene manuelt. Alle obligatoriske felt må fylles ut for at e-post skal kunne sendes og mottas via SuperOffice-innboksen.

1. Skriv inn innstillinger for innkommende e-post:

    * **Innkommende e-postserver:** Adressen til IMAP-serveren din
    * **Brukernavn:** Vanligvis hele e-postadressen
    * **Passord:** Passordet til e-postkontoen
    * **SSL:** På eller av, avhengig av leverandørens krav

1. Skriv inn innstillinger for utgående e-post:

    * **Utgående e-postserver:** Adressen til SMTP-serveren din
    * **Brukernavn**, **Passord** og **SSL**: tilsvarende innkommende.

1. Klikk på **Lagre** for å koble til kontoen.

![Avanserte innstillinger for e-postkonto -screenshot][img4]

## Koble fra eller endre e-postkontoen

Du kan koble fra den nåværende e-postkontoen og eventuelt oppdatere den ved å koble til på nytt.

1. Klikk på <i class="ph ph-user-circle" aria-label="Personal settings"></i> øverst og velg **E-postalternativer**.

1. Gå til fanen **E-postkonto**.

    ![E-postkonto-fane med Rediger/fjern-knapp -screenshot][img6]

1. Klikk på **Rediger/fjern** for å koble fra gjeldende e-postkonto.

    * Dette åpner samme dialog som ved førstegangsoppsett.
    * For å fjerne tilkoblingen, lukk dialogboksen.
    * For å koble til på nytt, skriv inn en ny e-postadresse og følg oppsettet.

> [!NOTE]
> Fjerning av e-postkontoen sletter **ikke** den faktiske kontoen din (for eksempel Gmail eller Outlook). Den kobles bare fra SuperOffice.

## Feilsøkingstips

* SuperOffice-innboksen støtter ikke **POP3**-kontoer. Kun IMAP er støttet.

* Hvis innboksen ikke oppdateres, kan det være at e-postleverandøren blokkerer tilkoblingen.
  * Sjekk e-posten for melding om blokkert eller uautorisert påloggingsforsøk.
  * Følg instruksjonene for å gi SuperOffice tilgang.

* **Gmail-brukere:** Fra januar 2025 er IMAP aktivert som standard. Hvis du blir bedt om passord, bruk et **app-passord** i stedet for ditt vanlige Gmail-passord.

> [!TIP]
> For å tilpasse utseende, skrift eller oppførsel for meldinger, gå til <i class="ph ph-user-circle" aria-hidden="true"></i> **Personlige innstillinger** > **E-postalternativer** > fanen **Generelt**.

## Relatert innhold

* [Hvordan aktivere IMAP for Office 365-konto][11] – FAQ
* [Hvordan generere et Google-app-passord for å bruke totrinnsbekreftelse med SuperOffice-innboksen][12] – FAQ
* [Endre standard e-postklient i SuperOffice][8]

<!-- Refererte lenker -->
[1]: ../../../contact/learn/index.md
[8]: ../../learn/change-default-mail-client.md
[9]: ../../../../../integrations/webtools/index.md
[11]: https://learn.microsoft.com/en-au/exchange/troubleshoot/user-and-shared-mailboxes/pop3-imap-owa-activesync-office-365
[12]: https://community.superoffice.com/en/support-faqs/faq/how-do-i-generate-a-googleapp-password-to-use-2-step-verification-with-superoffice-inbox/

<!-- Refererte bilder -->
[img1]: ../../../../media/loc/en/email/inbox-setup-dialog.png
[img4]: ../../../../media/loc/en/email/so-inbox-advanced-settings.png
[img6]: ../../../../media/loc/en/email/email-options-account.png
<!-- Prev YT video tag QoAanZgQs5A -->
