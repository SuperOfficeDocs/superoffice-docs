---
uid: help-nl-define-link-actions
title: Geautomatiseerde linkacties definiëren
description: In deze handleiding leert u hoe u links in mailings kunt gebruiken om acties te automatiseren.
keywords: Marketing, koppelingen, mailing, gevolgde links
author: Bergfrid Dias
so.date: 02.27.2024
so.version: 10
so.topic: howto
language: nl
so.audience: person
so.audience.tooltip: SuperOffice Marketing
---

# Geautomatiseerde linkacties definiëren

Het handmatig bijwerken van 500 contactkaarten is tijdrovend en onnodig. Geautomatiseerde linkacties kunnen dit proces stroomlijnen.

Zo werken geautomatiseerde linkacties:

* Een klik van een ontvanger op een CTA-link kan hen automatisch toevoegen aan een selectie of een project in SuperOffice CRM.
* SuperOffice CRM kan automatisch relevante informatie, zoals interesses, bijwerken op het contactkaart.

Automatisering bespaart tijd die anders zou worden besteed aan het afhandelen van reacties. Wanneer een lezer op een link in uw mailing klikt, voert het systeem de linkacties voor u uit!

U kunt de verzamelde informatie op verschillende manieren benutten:

* Genereer een selectie op basis van wie er op een specifieke link heeft geklikt en stuur een gericht antwoord naar deze groep met een aangepast bericht.
* Plan vervolgactiviteiten voor uw teamleden om persoonlijk in contact te komen met respondenten.
* Maak verzoeken aan uw klantenserviceteam om de zaak op te pakken en te onderzoeken.

![Definieer uw linkacties -screenshot][img3]

## Beschikbare acties

Afhankelijk van het doel en de CTA van uw mailing kunt u uw database bijwerken. Deze informatie kan de segmentatie verbeteren of helpen bij het opvolgen van geïnteresseerde personen.

| Tabblad | Actie |
|---|---|
| [Respons](#response) | voeg een openingspagina of aangepaste tekst toe. |
| [Veld instellen](#set-field) | voeg een waarde toe aan een [extra veld][5] voor personen |
| [Interesses](#interests) | werk de interesses bij. |
| [Selectie/project](#selection) | Persoon toevoegen aan/verwijderen uit een selectie of project. |
| [Vervolg­activiteit](#follow-up) | Maak een vervolgactiviteit (taak of vergadering) in SuperOffice CRM. |
| [Verzoek](#request) | maak een nieuw verzoek. |
| [Script](#script) | voer een script uit. |

> [!TIP]
> Je kunt meer dan één actie selecteren voor een gevolgde link.

## <a id="response" />Reactie

Selecteer wat er moet gebeuren wanneer de ontvanger op de link klikt.

* **Omleiden naar nieuwe webpagina**: Voer de URL in het daarvoor bestemde veld in.
* Of, **Aangepaste tekst weergeven**: Voer de tekst in die moet worden weergegeven. Klik op bewerkingssymbool ![pictogram][img4] om de rich-text toolbar te tonen.

## <a id="set-field" />Veld instellen

In het tabblad **Veld instellen** kun je een waarde instellen die moet worden toegevoegd aan een extra veld wanneer de ontvanger op de link klikt. Dit registreert aanvullende klantinformatie.

Selecteer een veld en voer een waarde in.

## <a id="interests" />Interesses

Specificeer dat een klik op de link de interesses van de contactpersoon moet wijzigen. Voeg bijvoorbeeld het interesse "Productnieuws" toe als er op de link "Ja, houd me op de hoogte van nieuwe producten" wordt geklikt, of verwijder het als er op de link "Uitschrijven" wordt geklikt.

* **Interesse instellen**: kies een interesse die moet worden toegevoegd voor de personen wanneer ze op de link klikken.
* **Interesse verwijderen** kies een interesse die moet worden verwijderd voor de personen wanneer ze op de link klikken.

[Hoe je een aanmeldformulier voor de nieuwsbrief kunt maken][1]

## <a id="selection" />Selectie/Project

Specificeer dat ontvangers die op de link klikken, worden toegevoegd of verwijderd uit selecties of projecten. Begin met typen om om snel zoeken te starten.

## <a id="follow-up" />Vervolgactiviteit (taak/vergadering)

In het tabblad **Vervolgactiviteit** stel je een link klik in om vergaderingen of taak te genereren in SuperOffice CRM. Kies het type vervolgactiviteit, geef een beschrijving op, koppel het aan een project, selecteer het taaktype, wijs verantwoordelijkheid toe en stel de duur in.

Activeer deze functie door **Vervolgactiviteit** te selecteren.

[Hoe je een vervolgactiviteit kunt maken][4]

> [!TIP]
> Geef als beschrijving aan bij welke mailing het hoort, welke link de ontvanger heeft geklikt, en mogelijk hoe het taak of de vergadering moet worden opgevolgd.
>
> Bij het instellen van **Gemaakt door** of **Standaardontvanger** kun je op de knop **Actieve gebruiker selecteren** ![pictogram][img1] klikken om jezelf te kiezen.

## <a id="request" />Verzoek

In het tabblad **Verzoek** stel je een link klik in om een Service-verzoek te creëren. Vink het vakje aan om een nieuw verzoek te registreren, geef een titel op, selecteer de prioriteit en categorie, en kies de eigenaar. Je kunt ook **Automatisch toegewezen** of **Niet-toegewezen** selecteren.

[Hoe je een verzoek kunt maken][3]

## <a id="script" />Script

In het tabblad **Script** kies je een CRMScript of macro die moet worden uitgevoerd wanneer er op de link wordt geklikt. Activeer deze functie door **Script uitvoeren** te selecteren, en kies vervolgens het vereiste script uit de lijst.

Variabelen die beschikbaar zijn in het script zijn custId, linkId, shipmentId, linkUrl, linkHits, en returnUrl.

[Hoe je een CRMScript kunt maken of bewerken][6]

<!-- Referenced links -->
[1]: ../../forms/learn/examples.md#newsletter-sign-up
[3]: ../../../request/learn/howto/create.md
[4]: ../../../diary/learn/create-follow-up.md
[5]: ../../../custom-objects/learn/extra-field.md
[6]: ../../../automation/crmscript/learn/create-script.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/nav-contact.png
[img3]: ../../../../media/loc/en/marketing/link-properties-follow-up.png
[img4]: ../../../../media/icons/marketing-and-forms/side-panel-content-text.png
