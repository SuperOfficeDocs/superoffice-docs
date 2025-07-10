---
uid: help-nl-email-service
title: Service-e-mails
description: Service-e-mails
author: SuperOffice Product and Engineering
keywords: postbus
date: 07.10.2025
version: 10.5
content_type: concept
category: service
topic: email
functional_right:
license: serviceessentials
audience: person
audience_tooltip: SuperOffice Service
language: nl
redirect_from:
  - /nl/email/service/learn/index
  - /nl/email/service/learn/screen/tab-inbox-for-email
  - /nl/email/service/learn/screen/tab-outbox-for-email
  - /nl/email/service/learn/screen/tab-blocked-email
  - /nl/email/service/learn/screen/sms-inbox
  - /nl/email/service/learn/screen/sms-outbox
---

# Service-e-mails

[!include[Restricted access](../../../learn/includes/note-insufficient-rights.md)]

In het scherm **E-mail** beheert u de mechanismen die worden gebruikt voor het beheren van inkomende en uitgaande e-mailberichten. E-mailberichten worden geïmporteerd doordat SuperOffice Service regelmatig e-mailberichten van een of meer postbussen verzamelt. Deze e-mailberichten kunnen worden gescand door e-mailfilters die e-mails verwerken op basis van inhoud en die verzoeken genereren. Uitgaande e-mail (antwoorden) wordt in het Postvak UIT geplaatst en op regelmatige tijden verzonden naar een e-mailserver die de berichten doorstuurt. Geïmporteerde e-mailberichten die zijn geblokkeerd (door een filter) worden weergegeven op het tabblad **Geblokkeerde e-mail** en moeten handmatig worden gecontroleerd.

## Postbussen

Het tabblad **Postbussen** bevat een lijst met geïnstalleerde postbussen. Deze lijst bevat de volgende kolommen:

* **Adres**: het afzenderadres van de postbus.
* **Categorie**: Verzoeken van de postbus worden aan deze categorie toegewezen.
* **Prioriteit**: De prioriteit die wordt toegewezen aan nieuwe verzoeken die vanuit deze postbus worden geregistreerd.
* **Doorstuuradres**: Wanneer u de e-mailfuncties in SuperOffice niet gebruikt, wordt het e-mailbericht naar dit adres doorgestuurd.
* **Protocol**: Het protocol dat door de postbus wordt gebruikt.

### <a id="email-in"></a>Postvak IN voor e-mail

Het tabblad **Postvak IN voor e-mail** bevat een lijst met e-mailberichten die in de wachtrij staan om te worden gelezen. De volgende opties zijn eveneens beschikbaar vanaf de menuknop <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i>:

* **Exporteren**: Wordt gebruikt om de lijst naar een bestand te exporteren. U kunt kiezen uit de volgende indelingen: Excel, HTML en tekst.

* **Verwijderen**: Wordt gebruikt om de geselecteerde e-mails te verwijderen.

    > [!NOTE]
    > u kunt deze actie niet ongedaan maken.

Wanneer u op een van de berichten op dit tabblad klikt, wordt het scherm **Binnenkomende e-mail** geopend. Dit scherm bevat informatie over dat bericht. In het veld **Laatste foutbericht** ziet u de oorzaak van het probleem, bijvoorbeeld of er een probleem is met het e-mailadres of de e-mailserver. Wanneer u een foutmelding ontvangt van SuperOffice Service, kunt u klikken op **Importeren met foutopsporing** om technische gegevens weer te geven die gebruikersondersteuning helpen bij de probleemoplossing.

### <a id="email-out"></a>Postvak UIT voor e-mail

Op het tabblad **Postvak UIT voor e-mail** ziet u een lijst met e-mailberichten die in de wachtrij staan om te worden verzonden.

Selecteer **Verzonden e-mails weergeven** in de rechterbenedenhoek om ook de laatste e-mails weer te geven.

De volgende opties zijn eveneens beschikbaar vanaf de menuknop <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i>:

* **Exporteren**: Wordt gebruikt om de lijst naar een bestand te exporteren. U kunt kiezen uit de volgende indelingen: Excel, HTML en tekst.

* **Verzenden**: Wordt gebruikt om de geselecteerde e-mails alleen opnieuw te verzenden als er een fout is opgetreden met de automatische mailing.

* **Verwijderen**: Wordt gebruikt om de geselecteerde e-mails te verwijderen.

    > [!NOTE]
    > U kunt deze actie niet ongedaan maken.

Wanneer u op een van de berichten op dit tabblad klikt, wordt het scherm **Uitgaande e-mail** geopend. Dit scherm bevat informatie over het geselecteerde bericht, zoals de grootte en wie het bericht heeft gemaakt. Eventuele foutberichten worden ook weergegeven.

### <a id="email-blocked"></a>Geblokkeerde e-mail

Op het tabblad **Geblokkeerde e-mail** ziet u een lijst met inkomende e-mailberichten die zijn geblokkeerd door een e-mailfilter. Klik op een e-mailbericht om de inhoud ervan weer te geven. Als er op een pagina onvoldoende ruimte is voor alle e-mails, kunt u klikken op <i class="ph ph-arrow-right" aria-label="Arrow right"></i> om naar de volgende pagina te navigeren. Deze lijst bevat de volgende kolommen:

* **Wanneer**: Geeft aan wanneer het e-mailbericht is geblokkeerd.
* **Postbus**: Geeft de postbus aan waarin het e-mailbericht is geïmporteerd.
* **E-mailfilter**: Geeft het e-mailfilter aan dat het e-mailbericht heeft geblokkeerd.
* **E-mailonderwerp**: Hier ziet u het onderwerp van het bericht.

De volgende opties zijn eveneens beschikbaar vanaf <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i>:

* **Exporteren**: Wordt gebruikt om de lijst naar een bestand te exporteren. U kunt kiezen uit de volgende indelingen: Excel, HTML en tekst.
* **Import**: Wordt gebruikt om de geselecteerde e-mails te importeren. Het e-mailfilter dat de e-mailberichten heeft geblokkeerd, wordt genegeerd, maar mogelijk zijn andere filters ingeschakeld.
* **Verwijderen**: Wordt gebruikt om de geselecteerde geblokkeerde e-mails te verwijderen.

### <a id="sms-in"></a>SMS-postvak IN

> [!NOTE]
> Wanneer dit tabblad niet zichtbaar is, is de module SMS niet geïnstalleerd of is SMS niet ingeschakeld voor de licentie die u gebruikt. Neem contact op met uw systeembeheerder voor meer informatie.

Het tabblad **SMS-Postvak IN** bevat een lijst met SMS-berichten die in de wachtrij staan om te worden gelezen. De volgende opties zijn eveneens beschikbaar vanaf de menuknop:

* **Exporteren**: Wordt gebruikt om de lijst naar een bestand te exporteren. U kunt kiezen uit de volgende indelingen: Excel, HTML en tekst.

* **Verwijderen**: Wordt gebruikt om de geselecteerde berichten te verwijderen.

    > [!NOTE]
    > u kunt deze actie niet ongedaan maken.

Klik op een van de berichten in deze tab om informatie weer te geven over het geselecteerde bericht.

### <a id="sms-out"></a>SMS-postvak UIT

Het tabblad **Postvak UIT SMS** bevat alle uitgaande SMS-berichten die nog niet zijn verzonden of waarbij een fout is opgetreden.

> [!NOTE]
> Wanneer dit tabblad niet zichtbaar is, is de module SMS niet geïnstalleerd of is SMS niet ingeschakeld voor de licentie die u gebruikt. Neem contact op met uw systeembeheerder voor meer informatie.

De volgende opties zijn eveneens beschikbaar vanaf de menuknop:

* **Exporteren**: Wordt gebruikt om de lijst naar een bestand te exporteren. U kunt kiezen uit de volgende indelingen: Excel, HTML en tekst.

* **Verzenden**: Wordt gebruikt om de geselecteerde berichten alleen opnieuw te verzenden als er een fout is opgetreden met de automatische mailing.

* **Verwijderen**: Wordt gebruikt om de geselecteerde berichten te verwijderen.

    > [!NOTE]
    > U kunt deze actie niet ongedaan maken.

Wanneer u op een van de berichten op dit tabblad klikt, wordt het scherm **Uitgaande SMS** geopend. Dit scherm bevat informatie over het geselecteerde bericht, zoals de grootte en wie het bericht heeft gemaakt. Eventuele foutberichten worden ook weergegeven.

## Gerelateerde inhoud

* [Postbussen maken][1]
* [Postbussen verwijderen][2]
* [E-mailfilters][3]

<!-- Referenced links -->
[1]: create-mailbox.md
[2]: delete-mailbox.md
[3]: email-filters/index.md

<!-- Referenced images -->
