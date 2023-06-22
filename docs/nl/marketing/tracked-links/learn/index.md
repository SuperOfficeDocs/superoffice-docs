---
uid: help-nl-mailing-tracked-links
title: Gevolgde links
description: "Een koppeling die u in een mailing opneemt, kan worden gebruikt om reacties van uw klanten en prospects bij te houden. Wanneer de ontvangers van uw mailing op de koppeling klikken, wordt een actie geactiveerd." 
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Marketing
so.topic: concept
language: nl
---

# Gevolgde links

[!include[Requirement](includes/req-marketing.md)]

Het doel van uw nieuwsbrief of e-mailcampagne bepaalt welke koppelingen u moet gebruiken. Elk doel heeft zijn eigen oproep tot actie om een reactie van de ontvanger te activeren die u wilt volgen. Op deze manier kunt u uw ontvangers opvolgen nadat u alle resultaten hebt ontvangen.

Als u bijvoorbeeld op een koppeling klikt, kan een nieuwe website worden geopend of de persoonskaart van uw ontvanger worden bijgewerkt. De actie kan ook een service-verzoek toevoegen in Service en op het sectietabblad Verzoek op de persoonskaart. Het gebruik van koppelingen is alleen beschikbaar voor gebruikers die zich abonneren op het Marketingplan.

Voordat u begint met de eigenlijke mailing, kunt u de koppelingen instellen die u vaak in uw mailings zult gebruiken. Nadat u ze hebt ingesteld, kunt u ze steeds opnieuw gebruiken, waardoor u tijd kunt besparen. De meest voorkomende koppelingen om te gebruiken zijn bijvoorbeeld:

* Afmeldpagina's
* Contactformulieren
* Sociale mediakanalen

![In het scherm Koppelingseigenschappen kunt u koppelingen toevoegen die u wilt bijhouden -screenshot][img4]

U kunt links (URL's) in een bericht opnemen en deze traceren. Met andere woorden: u kunt nagaan hoeveel ontvangers op de links hebben geklikt.

De URL's moeten uniek zijn voor elke ontvanger, zodat u er zeker van kunt zijn dat verschillende ontvangers op de koppelingen hebben geklikt (en niet dezelfde ontvanger er meerdere keren op heeft geklikt). Bovendien moeten de URL's verwijzen naar de SuperOffice-server, zodat deze kunnen worden geteld voordat ze worden omgeleid naar de doel-URL. Dit alles wordt automatisch geregeld wanneer u aangeeft welke URL's in het bericht u wilt traceren.

Het tabblad **Gevolgde links** bevat de volgende opties:

| Pictogram | Optie | Lees meer |
|---|---|---|
| ![pictogram][img2] | Bericht | [Een nieuwe koppeling maken][1] |
| ![pictogram][img3] | Map toevoegen | [Een map maken][5] voor uw koppelingen |
| Koppeling | Klik op een link om het scherm **Link weergeven** te openen. | [Werken met gevolgde koppelingen na de mailing][2] |
| ![pictogram][img1] | Menu | Klik op de knop naast een koppeling om meer opties te gebruiken. |

Menuopties:

* **Weergeven**. [Werken met gevolgde koppelingen na de mailing][2].
* **Bewerken**. [Gevolgde koppelingen maken][1].
* **Opnieuw instellen**. [Tellers voor koppelingen opnieuw instellen][2].
* **Verplaatsen naar map**. Wordt gebruikt om de koppeling naar een andere map te verplaatsen.
* **Verwijderen**. Verwijdert de koppeling.

## Welke koppelingen volg ik?

Als u [alle koppelingen een mailing wilt weergeven][4], opent u de mailing in de weergavemodus en selecteert u het tabblad **Gevolgde koppelingen**.

## <a id="google" />Google Analytics

Wanneer u een mailing instelt, kunt u Google Analytics als volgsysteem gebruiken. Via de instellingen in mailings kunt u een nauwkeurigere tracering van e-mails definiëren met behulp van de opgegeven velden, wat resulteert in meer gedetailleerde Google Channel-rapporten.

Google Analytics is de populairste digitale analysesoftware die beschikbaar is. Door bij te houden hoe websitebezoekers uw website vinden en gebruiken, biedt de service uw bedrijf nuttige inzichten die u helpen het succes van uw online marketingstrategieën te verbeteren.

Standaard identificeert Google Analytics geen bezoekers die afkomstig zijn van specifieke mailings. U moet een tag toevoegen aan de koppelingen in uw e-mail om het volgende te kunnen doen:

* Identificeren op welke koppelingen uw ontvangers hebben geklikt,
* Bekijken welke webpagina's ze hebben bezocht nadat ze op uw website zijn beland.

Wanneer u zonder tag een koppeling naar uw website toevoegt aan uw mailing, kunt u zien dat je uw bezoekers van een mailing komen, maar weet u niet welke specifieke mailing. Hierdoor blijft u in het ongewisse over hoe de ontvangers van specifieke mailings zich gedragen op uw website.

De Google Analytics-functie in SuperOffice Marketing identificeert uw mailings in de rapporten. Door een unieke tag toe te voegen aan alle koppelingen die u in uw mailing gebruikt, herkent Google Analytics uw mailing als de bron waar de websitebezoekers vandaan komen. Google Analytics geeft u ook inzicht in het pad van de bezoekers door uw website.

**Medium**: “E-mail” is het vooraf gedefinieerde medium in geautomatiseerde UTM-tags. Dit betekent dat getraceerde links in mailings die vanuit SuperOffice worden verzonden in Google Channel-rapporten kunnen worden gevonden onder “E-mails” (in tegenstelling tot “andere”).

**Bron** en **Campagne**: Deze velden identificeren deze specifieke mailing als de bron en zorgen voor een nauwkeurigere tracering en rapportage in Google.

## Gerelateerde inhoud

* [Links opnemen die u wilt traceren][3]
* [Links voor abonnement toevoegen][4]
* [Eenvoudige e-mailtracering van Google Analytics][6] \- blog
* [Linkacties definiëren][7]

<!-- Referenced links -->
[1]: create-links.md
[2]: explore-clicks.md
[3]: add-tracked-link-to-msg.md
[4]: ../../mailing/learn/create/add-unsubscribe-link.md
[5]: ../../learn/create-folder.md
[6]: https://community.superoffice.com/en/technical/blogs/archive/simple-google-analytics-email-tracking/
[7]: define-link-actions.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/btn-menu.png
[img2]: ../../../../media/icons/btn-add.png
[img3]: ../../../../../common/icons/folder.png
[img4]: media/link-properties.png
