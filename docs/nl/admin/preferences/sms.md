---
uid: help-nl-service-settings-system-sms
title: SMS
description: SMS
keywords: SMS instellingen
author: digitaldiina
date: 10.17.2025
version: 11.5
content_type: reference
category: Settings and maintenance
topic: preferences
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /nl/admin/preferences/learn/global-preferences/sms
language: nl
---

# SMS-configuratie in Algemene voorkeuren

Ga naar <i class="ph ph-gear" aria-hidden="true"></i> **Voorkeuren** in de navigator en selecteer het tabblad **Algemene voorkeuren**. De sectie voor **SMS-configuratie** bevat opties voor het configureren van SMS-oplossingen in SuperOffice.

## Algemene velden

[!include[Settings for mailings - SMS](../../marketing/learn/includes/mailing-settings-sms.md)]

> [!NOTE]
> Deze instellingen zijn ook beschikbaar bij het configureren van SMS-mailings in **Marketing**.

### De SMS-instellingen testen

Als u de instellingen wilt testen, voert u een mobiel telefoonnummer en een willekeurige tekst in en klikt u op **Test**.

## Beschikbare velden voor oorspronkelijke Intelecom (alleen LOKAAL)

* **SMS-eindpunt**: Dit veld moet de code bevatten waaraan SuperOffice Service een inkomend SMS-bericht kan herkennen.
* **Webservice gebruiken**: Indien ingeschakeld, worden SMS'en verzonden via een webservice in plaats van per e-mail. Dit is de aanbevolen methode, aangezien deze meer functionaliteit biedt. Eventuele firewalls moeten wel uitgaand verkeer naar SMS-gateways doorlaten.
* **Bezorgingsrapport**: Wanneer deze optie is ingeschakeld, wordt bezorgingsbevestiging van SMS-berichten in SuperOffice Service ondersteund. Dit betekent kunt dat u kunt controleren of een SMS-bericht is bezorgd bij de relevante mobiele telefoon. Dit vereist tevens configuratie aan de klant van de serviceleverancier.
* **Service-ID**: de ID voor de SMS-service. Deze hebt u ontvangen van SuperOffice AS.
* **Gebruikersnaam**: hier voert u de gebruikersnaam in die u hebt ontvangen van Intelecom.
* **Wachtwoord**: hier voert u het wachtwoord in dat u hebt ontvangen van Intelecom.
* **SMS-prioriteit**: hier voert u 1, 2 of 3 in. Het nummer geeft aan hoe snel de SMS-berichten worden verzonden.

## Beschikbare velden voor oorspronkelijke PsWinCom (alleen LOKAAL)

* **SMS-eindpunt**: Dit veld moet de code bevatten waaraan SuperOffice Service een inkomend SMS-bericht kan herkennen.
* **Gebruikersnaam**: hier voert u de gebruikersnaam in die u hebt ontvangen van PsWinCom.
* **Wachtwoord**: hier voert u het wachtwoord in dat u hebt ontvangen van PsWinCom.
