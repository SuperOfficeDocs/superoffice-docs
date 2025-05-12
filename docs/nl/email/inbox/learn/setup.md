---
uid: help-nl-email-inbox-setup
title: SuperOffice Postvak IN instellen
description: SuperOffice Postvak IN is een alternatieve manier om uw e-mail te verbinden met uw SuperOffice CRM voor e-mailclients die niet via WebTools kunnen worden verbonden. Leer hoe u het instelt en voor de eerste keer inlogt.
keywords: e-mail, postvak IN
author: SuperOffice Product and Engineering
date: 05.12.2025
version: 10.4
topic: howto
language: nl
---

# SuperOffice Postvak IN instellen

SuperOffice Postvak IN is een alternatieve manier om uw e-mail te verbinden met uw SuperOffice CRM voor e-mailclients die niet via WebTools kunnen worden verbonden.

## Voordat u begint

* Zorg ervoor dat IMAP is ingeschakeld in uw e-mailclient. SuperOffice Postvak IN ondersteunt de meeste IMAP-e-mailservers.

* Om e-mails te kunnen verzenden vanuit SuperOffice CRM, moet u ervoor zorgen dat het e-mailadres dat u gaat gebruiken met SuperOffice Postvak IN hetzelfde is als het eerste e-mailadres dat is geregistreerd in uw persoonskaart/scherm.

![U kunt controleren welk e-mailadres u hebt geregistreerd op uw persoonskaart -screenshot][img2]

## E-mailaccount instellen

Als u toegang wilt tot e-mail, moet u eerst details over uw e-mailaccount opgeven.

<!-- Prev YT video tag QoAanZgQs5A -->

1. Klik op het pictogram Postvak IN in het navigatiemenu. Het scherm **E-mailaccount instellen** wordt weergegeven als u Postvak IN voor de eerste keer opent.

1. Voer in het veld **E-mailaccount** het e-mailadres in van het account dat u wilt gebruiken in SuperOffice.

    ![x -screenshot][img3]

1. Als u informatie wilt invoeren voor inkomende en uitgaande e-mail, klikt u op **Geavanceerde instellingen**. Als u dat niet wilt, klikt u op **Volgende**. SuperOffice zal dan proberen deze informatie voor u in te stellen.

1. Voer in het veld **Wachtwoord** uw wachtwoord in.

1. Klik op **Aanmelden**.

    * Als SuperOffice de e-mailprovider herkent (zoals Gmail), worden de serverinstellingen automatisch ingesteld en wordt Postvak IN geladen.
    * Als de gegevens niet correct zijn of als het e-mailadres en wachtwoord dat u hebt ingevoerd niet correct zijn, wordt het dialoogvenster **Geavanceerde instellingen** geopend. Voer handmatig configuratiegegevens in of controleer deze voor binnenkomende en uitgaande servers.

## Handmatig servergegevens toevoegen

### Instellingen voor binnenkomende e-mail

Als u uw e-mails wilt importeren in SuperOffice CRM, voert u de gegevens van uw IMAP-server in de instellingen van uw e-mailclient in.

* Gebruikersnaam: uw volledige e-mailadres
* Wachtwoord: het wachtwoord van uw e-mailaccount
* SSL: Aan/Uit - afhankelijk van de instellingen van uw e-mailprovider (zie instellingen voor Outlook en Gmail)

### Instellingen voor uitgaande e-mail

Als u e-mails wilt verzenden vanuit SuperOffice CRM, voert u de gegevens van uw SMTP-server in.

* Gebruikersnaam: uw volledige e-mailadres
* Wachtwoord: het wachtwoord van uw e-mailaccount
* SSL: afhankelijk van de instellingen van uw e-mailprovider (zie instellingen voor Outlook en Gmail)

![Geavanceerde instellingen - ga naar Postvak IN om handmatig de juiste e-mailservergegevens toe te voegen -screenshot][img4]

## E-mailconfiguratie wijzigen in SuperOffice Postvak IN

1. Als u uw gekoppelde e-mailaccount wilt bewerken of verwijderen, klikt u op uw profielpictogram in de rechterbovenhoek en kiest u **E-mailopties**.

    ![E-mailopties -screenshot][img5]

1. Selecteer het tabblad **E-mailaccount** en druk op de knop **Bewerken/verwijderen**.

    ![E-mailopties -screenshot][img6]

## Waarom wordt de e-maillijst niet bijgewerkt?

Sommige e-mailproviders, zoals Gmail, zullen pogingen tot aanmelding vanuit onbekende apps blokkeren. Controleer uw Postvak IN om te zien of uw e-mailprovider informatie naar u heeft verzonden over een onbevoegde aanmeldingspoging. Volg de instructies in de e-mail om SuperOffice toegang te geven tot uw account.

> [!TIP]
> Als u toegang wilt tot de e-mailopties, gaat u naar <i class="ph ph-user-circle" aria-hidden="true"></i> **Persoonlijke instellingen** > **E-mailopties**.

<!-- Referenced links -->

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/email/getstarted-contact-mycontactcard.png
[img3]: ../../../../media/loc/en/email/getstarted-inbox-login.png
[img4]: ../../../../media/loc/en/email/so-inbox-advanced-settings.png
[img5]: ../../../../media/loc/en/email/email-options-general.png
[img6]: ../../../../media/loc/en/email/email-options-account.png
