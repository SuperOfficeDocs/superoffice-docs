---
uid: help-nl-project-create
title: Een nieuw project maken
description: Zo maakt u een project en organiseert u uw werk efficiënter.
keywords: project maken, nieuw project, project toevoegen, project
author: Bergfrid Dias
date: 03.14.2025
version: 10.5.2
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: nl
---

# Een nieuw project maken

U kunt een project toevoegen in SuperOffice CRM via de knop **Nieuw** op de bovenste balk. Bekijk deze video of volg de onderstaande stappen om te leren hoe u een project maakt:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/zLJwNll223w]

(videolengte - 2:49)

## Stappen

1. Klik op **Nieuw** op de bovenste balk en selecteer **Project**.

1. Voer een **projectnaam** in (verplicht, wordt rood gemarkeerd).

    Als de projectnaam al bestaat of lijkt op een bestaand project, verschijnt het dialoogvenster **Duplicaten**, zodat u dubbele records kunt vermijden.

    ![Het scherm Project in bewerkingsmodus, met projectdetails -screenshot][img1]

1. Gebruik het grote tekstvak om een gedetailleerd overzicht of een samenvatting van het project te geven. Dit is het veld **Beschrijving**.

1. Selecteer het **Type** project (verplicht). Deze waarden zijn vooraf gedefinieerd en ingesteld in **Instellingen en onderhoud**.

1. **Optioneel: Voer aanvullende informatie in** op het tabblad **Project**:
    * Voeg een **Website**-adres en titel toe.
    * Selecteer een **Verantwoordelijke** gebruiker voor het project.
    * Kies de **Status** van het project. Waarden zijn vooraf gedefinieerd in **Instellingen en onderhoud**.
    * Stel een **Einddatum** in via de kalenderkiezer.

1. **Meer details toevoegen:**
    * Ga naar het tabblad **Meer** om [aangepaste velden in te vullen][12].
    * Ga naar het tabblad **Afbeelding** om [een projectafbeelding te uploaden en in te stellen][2].
    * Ga naar het tabblad **Opmerking** om [notities toe te voegen][11].
    * Ga naar het tabblad **Koppelingen** om [activiteiten, verkopen, documenten of websites][10] aan het project te koppelen.

1. Klik op **Opslaan** om de projectgegevens op te slaan. U kunt nu [projectleden toevoegen][5].

## <a id="fields"></a>Belangrijke velden uitgelegd

De volgende velden zijn beschikbaar op de projectkaart. Sommige worden automatisch ingevuld, terwijl andere handmatig moeten worden ingevoerd.

> [!NOTE]
> Velden en de lay-out kunnen variëren op basis van aanpassingen via [Schermontwerper][13] of andere UI-wijzigingen.

* **Projectnaam:** De belangrijkste identificatie van het project. Dit veld is verplicht.
* **Nummer:** Automatisch gegenereerd als het volgende beschikbare projectnummer, indien geconfigureerd in **Instellingen en onderhoud**. Kan handmatig worden gewijzigd.
* **Website:** Voeg webadressen toe met een korte beschrijving. Klik buiten de tabel of druk op **TAB** om de invoer af te sluiten.
* **Beschrijving:** Samenvatting van de projectdoelen, scope of doelstelling. Optioneel maar handig voor het bijhouden van doelen.
* **Verantwoordelijke:** Wijs een gebruiker toe die verantwoordelijk is voor het project.
* **Type:** Vooraf gedefinieerde projecttypen. Sommige typen kunnen gekoppeld zijn aan een [projectgids][1].
* **Status:** Houd de huidige fase van het project bij (bijv. Gepland, In uitvoering, Voltooid). Indien gekoppeld aan een projectgids, verschijnen statusopties specifiek voor de gids.
* **Einddatum:** Stel in wanneer het project moet eindigen. Kan later worden aangepast.
* **Volgende mijlpaal:** Als het project is gekoppeld aan een gids, toont dit veld de datum van de volgende geplande vervolgactiviteit. De datum wordt automatisch berekend op basis van gekoppelde activiteiten of de projectgids. Indien er geen projectgids is, wordt de einddatum van het project weergegeven. Datums vóór vandaag worden in rood gemarkeerd.

[!include[3 aangepaste velden](../../learn/includes/more-udef.md)]

## Dubbele projecten voorkomen

Als de projectnaam overeenkomt met of vergelijkbaar is met een bestaande record, helpt het dialoogvenster **Duplicaten** u om [dubbele projecten te voorkomen][6]. Controleer de suggesties en ga verder zoals nodig.

## Gerelateerde inhoud

* [Een projectafbeelding toevoegen of wijzigen][2]
* [Projectleden toevoegen][5]
* [Projecten bewerken][7]
* [Projecten samenvoegen][8]
* [Projecten verwijderen][9]
* [Projectgidsen][1]
* [Activiteiten][3]

<!-- Referenced links -->
[5]: project-members/add.md
[2]: add-image.md
[7]: edit.md
[8]: merge-projects.md
[9]: delete.md
[1]: project-guides.md
[3]: ../../learn/basics/activity.md
[6]: ../../learn/basics/duplicates.md
[10]: ../../learn/basics/links.md
[11]: ../../learn/basics/notes.md
[12]: ../../custom-objects/learn/more-tab.md
[13]: ../../customization/screen-designer/admin/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/project/create-project.png
