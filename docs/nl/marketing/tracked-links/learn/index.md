---
uid: help-nl-mailing-tracked-links
title: Gevolgde links
description: Een koppeling die u in een mailing opneemt, kan worden gebruikt om reacties van uw klanten en prospects bij te houden. Wanneer de ontvangers van uw mailing op de koppeling klikken, wordt een actie geactiveerd.
keywords: Marketing, koppelingen, mailing, nieuwsbrief, gevolgde links
author: Bergfrid Dias
date: 09.26.2025
version: 10.5
content_type: concept
category: marketing
topic: mailing
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
redirect_from: /nl/marketing/tracked-links/learn/examples
language: nl
---

# Gevolgde links

De links die je gebruikt in je nieuwsbrief of e-mailcampagne worden bepaald door je doelen. Elk doel heeft een unieke oproep tot actie die een reactie van de ontvanger uitlokt, die je kunt volgen. Dit stelt je in staat om op te volgen met je ontvangers zodra je alle resultaten hebt verzameld.

Bijvoorbeeld, een linkklik kan een nieuwe website openen of de persoonskaart van een ontvanger bijwerken. Het kan ook een [service-verzoek][8] toevoegen.

Je kunt vaak gebruikte links instellen, zelfs voordat je inhoud maakt. Dit stelt je in staat om deze links opnieuw te gebruiken en tijd te besparen. Vaak gebruikte links zijn onder andere:

* Afmeldpagina's
* Contactformulieren
* Sociale mediakanalen

![In het scherm Koppelingseigenschappen kunt u koppelingen toevoegen die u wilt bijhouden -screenshot][img4]

De URL's moeten uniek zijn voor elke ontvanger, zodat u er zeker van kunt zijn dat verschillende ontvangers op de koppelingen hebben geklikt (en niet dezelfde ontvanger er meerdere keren op heeft geklikt). Bovendien moeten de URL's verwijzen naar de SuperOffice-server, zodat deze kunnen worden geteld voordat ze worden omgeleid naar de doel-URL. Dit alles wordt automatisch geregeld wanneer u aangeeft welke URL's in het bericht u wilt traceren.

## Welke koppelingen volg ik?

Als u [alle koppelingen een mailing wilt weergeven][4], opent u de mailing in de weergavemodus en selecteert u het tabblad **Gevolgde koppelingen**.

## Tabblad Gevolgde links

Het tabblad **Gevolgde links** bevat de volgende opties:

| Pictogram | Optie | Lees meer |
|:-:|---|---|
| <i class="ph ph-plus" aria-label="Plus"></i> | Bericht | [Een nieuwe koppeling maken][1], [Linkacties definiëren][7] |
| <i class="ph ph-folder" aria-label="Folder"></i> | Map toevoegen | [Een map maken][5] voor uw koppelingen |
| Koppeling | Klik op een link om het scherm **Link weergeven** te openen. | [Werken met gevolgde koppelingen na de mailing][2] |
| <i class="ph ph-list" aria-label="Task menu"></i> | Menu | Klik op de knop naast een koppeling om meer opties te gebruiken. |

Menuopties:

* [**Weergeven**][2]
* [**Bewerken**][1]
* [**Opnieuw instellen**][10] (Tellers voor koppelingen)
* **Verplaatsen naar map** (verplaats de koppeling naar een andere map)
* **Verwijderen**

## <a id="ex"></a>Use cases

Sporbare links kunnen op verschillende manieren worden gebruikt:

* **Respons**: Registreer elk klik van een ontvanger op een link, zoals een nieuwe productpagina, om interesse te meten over meerdere mailings.

* **Prospectlijst**: Voor de lancering van een nieuw product kunnen ontvangers interesse tonen door op de link "Stuur me meer informatie" te klikken. Klikkers kunnen worden toegevoegd aan een [statische selectie][9] voor verdere contactbeheer.

* **CRM-vervolgactiviteit**: In plaats van een prospectlijst, genereer een taak of vergadering voor elk länkklik en wijs deze toe aan een verkoper of klantcontact. Bijvoorbeeld, een klik op de link "Neem contact met mij op" kan een vervolgactiviteit met "Telefoon - uitgaand" genereren.

* **Uitschrijven**: Voeg een [uitschrijflink][4] in de inhoudseditor in om een specifiek type mailing te stoppen. Klanten kunnen zich ook uitschrijven voor individuele ontvangerlijsten.

    Voeg een link toe (bijvoorbeeld "Klik hier als u onze nieuwsbrieven niet langer wilt ontvangen") om klanten uit de ontvangerlijst te verwijderen. Als een nieuwsbrief alleen wordt verzonden naar contacten met het interesse "Nieuwsbrief", kan dit interesse worden verwijderd voor klikkers.

    > [!TIP]
    > Volg abonnement opzeggingen op door link klikkers toe te voegen aan een aparte selectie, bijvoorbeeld "Nieuwsbrief 2024 - uitschrijvingen". Meerdere acties kunnen worden toegevoegd aan dezelfde link.

* **Boek consultant**: Voor een grote productupdate, voeg een link toe voor klanten om een consultant te boeken. Elk länkklik registreert een nieuwe serviceverzoek, toegewezen aan de categorie "Consultant". De klant ontvangt feedback dat ze zullen worden gecontacteerd door een consultant.

> [!NOTE]
> Deze voorbeelden werken even goed voor gewone links, maar in dat geval worden alleen de klikken voor de afzonderlijke mailing geregistreerd.

## <a id="google"></a>Google Analytics

Wanneer u een mailing instelt, kunt u Google Analytics als volgsysteem gebruiken. Via de instellingen in mailings kunt u een nauwkeurigere tracering van e-mails definiëren met behulp van de opgegeven velden, wat resulteert in meer gedetailleerde Google Channel-rapporten.

Google Analytics is de populairste digitale analysesoftware die beschikbaar is. Door bij te houden hoe websitebezoekers uw website vinden en gebruiken, biedt de service uw bedrijf nuttige inzichten die u helpen het succes van uw online marketingstrategieën te verbeteren.

Standaard identificeert Google Analytics geen bezoekers die afkomstig zijn van specifieke mailings. U moet een tag toevoegen aan de koppelingen in uw e-mail om het volgende te kunnen doen:

* Identificeren op welke koppelingen uw ontvangers hebben geklikt,
* Bekijken welke webpagina's ze hebben bezocht nadat ze op uw website zijn beland.

Wanneer u zonder tag een koppeling naar uw website toevoegt aan uw mailing, kunt u zien dat je uw bezoekers van een mailing komen, maar weet u niet welke specifieke mailing. Hierdoor blijft u in het ongewisse over hoe de ontvangers van specifieke mailings zich gedragen op uw website.

De Google Analytics-functie in SuperOffice Marketing identificeert uw mailings in de rapporten. Door een unieke tag toe te voegen aan alle koppelingen die u in uw mailing gebruikt, herkent Google Analytics uw mailing als de bron waar de websitebezoekers vandaan komen. Google Analytics geeft u ook inzicht in het pad van de bezoekers door uw website.

**Medium**: "E-mail" is het vooraf gedefinieerde medium in geautomatiseerde UTM-tags. Dit betekent dat gevolgde links in mailings die vanuit SuperOffice worden verzonden in Google Channel-rapporten kunnen worden gevonden onder "E-mails" (in tegenstelling tot "andere").

**Bron** en **Campagne**: Deze velden identificeren deze specifieke mailing als de bron en zorgen voor een nauwkeurigere tracering en rapportage in Google.

## Gerelateerde inhoud

* [Links opnemen die u wilt traceren][3]
* [Links voor abonnement toevoegen][4]
* [Eenvoudige e-mailtracering van Google Analytics][6]

<!-- Referenced links -->
[1]: create-links.md
[2]: explore-clicks.md
[7]: define-link-actions.md
[6]: ga-tutorial.md
[10]: reset-counter.md
[3]: ../../editor/learn/add-tracked-link-to-msg.md
[4]: ../../editor/learn/add-unsubscribe-link.md
[5]: ../../learn/create-folder.md
[8]: ../../../request/learn/index.md
[9]: ../../../search-options/selection/learn/index.md

<!-- Referenced images -->
[img4]: ../../../../media/loc/en/marketing/link-properties.png
