---
uid: help-nl-mailing
title: Werken met mailings
description: Werken met mailings
keywords: Marketing
author: SuperOffice RnD
so.date: 02.12.2024
so.version: 10
so.topic: concept
language: nl
so.audience: user
so.audience.tooltip: SuperOffice Marketing
---

# Werken met mailings

Een mailing wordt doorgaans in twee stappen uitgevoerd:

* [Het voorbereiden en verzenden van de mailing][1]
* [Het opvolgen van de voltooide mailing](#after)

## Mailingtypes

* E-mail
* SMS
* Document
* Formulierantwoord

> [!NOTE]
> E-mail-mailings en formulierantwoorden zijn de meest veelzijdige van de mailingtypen. Functies zoals [gevolgde koppelingen][7] en [abonnementskoppelingen][6] zijn niet beschikbaar in SMS-mailings en documentmailings.

## Uw doel definiëren

Om ervoor te zorgen dat uw mailing een succes wordt, moet u eerst en vooral de juiste mensen bereiken. Hoe meer u uw doelgroep kunt beperken, hoe groter de kans dat de juiste boodschap de juiste persoon bereikt.

Wat wilt u bereiken met uw mailing? Wilt u:

* Meer leads krijgen?
* Meer nieuwe producten of diensten verkopen aan uw bestaande klanten?
* Klantenverbinding verbeteren en klanten behouden?
* Op de hoogte blijven van nieuwe ontwikkelingen, mijlpalen of voorstellen?

SuperOffice CRM biedt vele manieren om een solide [doellijst][8] te maken. U kunt selecties, projecten of een enkele persoon gebruiken die in het systeem is opgeslagen. Alle personen die nog niet beschikbaar zijn in de SuperOffice CRM-database, kunnen worden toegevoegd door een Excel-lijst te importeren, op voorwaarde dat u hun toestemming hebt om marketingberichten door uw bedrijf te ontvangen.

U kunt ook een mailinglijst opbouwen met behulp van [online webformulieren][5]. U kunt niet alleen nieuwe leads vastleggen onder de bezoekers van uw website die een webformulier invullen, maar u kunt ook webformulieren gebruiken om mensen uit te nodigen om zich te abonneren of aan te melden voor verschillende mailings.

Meer informatie over het [maken en gebruiken van webformulieren in Marketing][4].

## Ontvangers

U kunt ontvangers uit meerdere bronnen toevoegen.

> [!NOTE]
> Wanneer u ontvangers toevoegt, worden alleen personen met een geldig e-mailadres (of mobiel telefoonnummer, in het geval van SMS-mailings) toegevoegd aan de lijst **Ontvangers**.

Geïmporteerde ontvangers die NIET voorkomen in de SuperOffice-database, bestaan alleen uit een naam en een e-mailadres (of alleen een e-mailadres). Dit betekent dat uitsluitend de sjabloonvariabelen **\[\[customer.name\]\]** en/of **\[\[customer.email\]\]** functioneren bij deze ontvangers. Ter voorkoming van lege variabelen in uw mailing moet u eerst een [voorbeeldweergave van de mailing][3] bekijken.

## Een mailing koppelen aan selectie of project

U kunt de mailing koppelen aan een selectie en/of een project om alle mailings met betrekking tot uw selecties en projecten bij te houden. De mailings worden weergegeven op het sectietabblad **Mailings** in **Selecties** en op het sectietabblad **Activiteiten** in **Projecten** in SuperOffice CRM.

> [!NOTE]
> Als u een selectie of een project toevoegt, worden in de mailing alle personen in de selectie of het project toegevoegd als ontvangers. Als u zowel een selectie als een project toevoegt, worden alleen de personen uit de selectie toegevoegd als ontvangers.

Bijvoorbeeld: als u meerdere mailings verzendt voor de promotie van een evenement, kunt u deze mailings toevoegen aan een selectie met de naam "Evenement 2015" voor een volledige lijst met alle mailings voor dit evenement. Op dezelfde manier kunt u, als u een project maakt voor uw evenement, een lijst met alle projectgerelateerde mailings bijhouden op het sectietabblad **Activiteiten**.

## <a id="after" />Hoe kan ik dit opvolgen?

* [Bekijk de statistieken][2] van de mailing en krijg informatie over eventuele problemen die zich hebben voorgedaan.
* [Voeg ontvangers toe aan selecties en projecten][12] voor verdere verwerking.
* [Controleer en corrigeer de adressen van niet-bezorgde e-mails][11].
* Bekijk [wie op de traceerbare koppelingen][14] heeft geklikt die u in het bericht hebt ingevoegd.
* Beheer e-mailadressen die zijn geretourneerd vanwege permanente fouten of die meerdere keren zijn [geretourneerd][13].

<!-- Referenced links -->
[1]: create/index.md
[3]: create/send-test-email.md
[2]: view-statistics.md
[4]: ../../forms/learn/create.md
[6]: ../../recipients/learn/add-unsubscribe-link.md
[8]: ../../recipients/learn/index.md
[11]: ../../recipients/learn/look-at-recipient-list.md
[12]: ../../recipients/learn/look-at-recipient-list.md#add-recipients
[13]: ../../recipients/learn/manage-bounces.md
[14]: ../../tracked-links/learn/explore-clicks.md
[7]: ../../tracked-links/learn/index.md
[5]: https://www.superoffice.co.uk/resources/articles/integrated-web-forms/

<!-- Referenced images -->