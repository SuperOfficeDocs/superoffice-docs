---
uid: help-nl-email-inbox-setup
title: SuperOffice Postvak IN instellen
description: Leer hoe u SuperOffice Postvak IN instelt en inlogt. Deze functie is een alternatief voor WebTools om uw e-mailaccount te koppelen aan SuperOffice CRM.
keywords: SuperOffice Postvak IN, postvak instellen, e-mailinstellingen, IMAP, e-mailverbinding
author: Bergfrid Dias
date: 05.28.2025
version: 10.5
content_type: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: nl
---

# SuperOffice Postvak IN instellen

SuperOffice Postvak IN is een alternatief voor het koppelen van uw e-mailaccount aan SuperOffice CRM. Deze functie is bedoeld voor gebruikers die geen gebruik kunnen maken van [WebTools][9]. Alleen IMAP-accounts worden ondersteund.

> [!NOTE]
> SuperOffice Postvak IN ondersteunt slechts **één** e-mailaccount per gebruiker. Als WebTools is geïnstalleerd en verbonden met uw e-mail, is Postvak IN niet beschikbaar.

## Voordat u begint

* Controleer of **SuperOffice CRM** is geselecteerd als uw [standaard e-mailclient][8] onder **Lokale instellingen**.

* Zorg ervoor dat **IMAP is ingeschakeld** in uw e-mailclient.

* Bevestig dat het **e-mailadres** dat u wilt gebruiken overeenkomt met het primaire e-mailadres dat op uw [persoonskaart][1] in SuperOffice is geregistreerd.

## Uw e-mailaccount koppelen

1. Klik op <i class="ph ph-at" aria-hidden="true"></i> **Postvak IN** in de navigator.

    De eerste keer dat u het postvak opent, verschijnt het scherm **E-mailaccount instellen**.

    ![Scherm E-mailaccount instellen met e-mailadresveld en knop Volgende -screenshot][img1]

1. Voer in het veld **E-mailaccount** het e-mailadres in dat u wilt gebruiken.

1. Klik op **Volgende**.

    * SuperOffice probeert uw e-mailprovider te detecteren en stuurt u door om in te loggen.
    * Als uw wachtwoord al bij de provider is opgeslagen, wordt u mogelijk automatisch geverifieerd.
    * Anders wordt u gevraagd uw wachtwoord rechtstreeks in te voeren bij uw provider (bijvoorbeeld Microsoft of Google).
    * Na succesvolle verificatie keert u terug naar SuperOffice en wordt het postvak geopend.

1. Als verificatie mislukt of de provider niet wordt herkend, verschijnt het scherm **Geavanceerde instellingen**. Voer dan handmatig de serverinstellingen in.

## Geavanceerde instellingen configureren

Als automatische configuratie mislukt, moet u handmatig de e-mailservergegevens invoeren. Alle verplichte velden moeten worden ingevuld zodat e-mail verzonden en ontvangen kan worden via SuperOffice Postvak IN.

1. Voer instellingen voor inkomende e-mail in:

    * **Server voor inkomende e-mail:** Uw IMAP-serveradres
    * **Gebruikersnaam:** Meestal uw volledige e-mailadres
    * **Wachtwoord:** Het wachtwoord van uw e-mailaccount
    * **SSL:** In- of uitschakelen volgens de vereisten van uw provider

1. Voer instellingen voor uitgaande e-mail in:

    * **Server voor uitgaande e-mail:** Uw SMTP-serveradres
    * **Gebruikersnaam**, **Wachtwoord** en **SSL**: gelijk aan inkomend

1. Klik op **Opslaan** om uw account te koppelen.

![Geavanceerde instellingen voor e-mailaccount -screenshot][img4]

## Uw e-mailaccount wijzigen of verwijderen

U kunt uw huidige e-mailaccount ontkoppelen en eventueel vervangen door opnieuw te koppelen.

1. Klik op <i class="ph ph-user-circle" aria-label="Persoonlijke instellingen"></i> in de bovenste balk en kies **E-mailopties**.

1. Ga naar het tabblad **E-mailaccount**.

    ![Tabblad E-mailaccount met knop Bewerken/verwijderen -screenshot][img6]

1. Klik op **Bewerken/verwijderen** om het huidige e-mailaccount te ontkoppelen.

    * Dit opent hetzelfde dialoogvenster als bij het eerste instellen van uw account.
    * Sluit het venster om de koppeling te verwijderen.
    * Voer een nieuw e-mailadres in en volg de stappen om opnieuw te koppelen.

> [!NOTE]
> Het verwijderen van het e-mailaccount verwijdert **niet** uw eigenlijke e-mailaccount (zoals Gmail of Outlook). Het verbreekt alleen de koppeling met SuperOffice.

## Tips voor probleemoplossing

* SuperOffice Postvak IN ondersteunt **geen POP3**-accounts. Alleen IMAP wordt ondersteund.

* Als het postvak niet wordt bijgewerkt, blokkeert uw e-mailprovider mogelijk de verbinding.
  * Controleer uw e-mailaccount op berichten over een geblokkeerde of ongeautoriseerde aanmeldpoging.
  * Volg de instructies om SuperOffice toegang te geven tot uw account.

* **Gmail-gebruikers:** Sinds januari 2025 is IMAP standaard permanent ingeschakeld. Als u wordt gevraagd om een wachtwoord, gebruik dan een **app-wachtwoord** in plaats van uw gewone Gmail-wachtwoord.

> [!TIP]
> Ga naar <i class="ph ph-user-circle" aria-hidden="true"></i> **Persoonlijke instellingen** > **E-mailopties** > tabblad **Algemeen** om de lay-out, het lettertype of gedrag van berichten aan te passen.

## Gerelateerde inhoud

* [IMAP inschakelen op een Office 365-account][11] - FAQ
* [Een Google app-wachtwoord genereren voor gebruik met SuperOffice Postvak IN][12] - FAQ
* [Standaard e-mailclient wijzigen in SuperOffice][8]

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
