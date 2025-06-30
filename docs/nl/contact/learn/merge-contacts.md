---
uid: help-nl-contact-merge
title: Personen samenvoegen
description: Leer hoe u dubbele personen in SuperOffice CRM samenvoegt om activiteiten, verkopen en projectlidmaatschappen te consolideren. Bevat stapsgewijze instructies voor het gebruik van het dialoogvenster Personen samenvoegen.
keywords: Personen samenvoegen, contact, persoon
author: Bergfrid Dias
date: 03.14.2025
version: 10.5.2
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: nl
---

# Personen samenvoegen

[!include[Requirement](../../learn/includes/note-req-manage-entities.md)]

Als dezelfde persoon onder verschillende namen of bedrijven in SuperOffice CRM is geregistreerd (zoals "Jonathan Clark" en "Jonathon Clarke"), kunt u hun contactrecords samenvoegen om activiteiten, verkopen en projectlidmaatschappen te consolideren.

> [!NOTE]
> U kunt geen personen (SuperOffice-gebruikers) in uw eigen bedrijf samenvoegen. Wel kunt u een persoon van een ander bedrijf samenvoegen met een persoon in uw eigen bedrijf.

## Stappen

1. Open het dialoogvenster **Personen samenvoegen**:

    * In het **scherm Persoon**: Ga naar de gewenste persoon, klik op <i class="ph ph-dots-three-circle-vertical" aria-label="Taakknop"></i> en selecteer **Personen beheren** > **Personen samenvoegen** in het menu.

    * In het **scherm Bedrijf**: Ga naar het sectietabblad **Personen**, selecteer één of twee Personen, klik met de rechtermuisknop en kies **Personen beheren** > **Personen samenvoegen**.

1. Als u slechts één persoon hebt geselecteerd, kies dan een tweede persoon onder **Aan**. Begin te typen om te zoeken naar de persoon. Om de Personen bij **Van** en **Naar** te wisselen, klikt u op de pijlknop <i class="ph ph-arrows-left-right" aria-hidden="true"></i>.

1. Onder **Actie bij \[bedrijf/persoon\] na samenvoegen**, kies een van de volgende opties:

    * **Verwijderen van \[bronpersoon\]:** Verwijdert de bronpersoon na het samenvoegen (handig voor duplicaten).
    * **Markeren als voormalige werknemer:** Markeert de bronpersoon als een voormalige werknemer (handig als de persoon van baan is veranderd).

1. Onder **Actie op alle bestaande activiteiten en verkopen**, kies een van de volgende opties:

    [!include[Select action](../../learn/includes/select-action-on-activity.md)]

1. Klik op **Samenvoegen**. Vervolgens gebeurt het volgende:

    * Alle details worden samengevoegd.
    * Activiteiten en verkopen blijven gekoppeld aan de doelpersoon of worden verplaatst, afhankelijk van de geselecteerde optie.
    * Project- en statische selectielidmaatschappen volgen het doelbedrijf.
    * De opgegeven actie (verwijderen of markeren als voormalige werknemer) wordt toegepast op de bronpersoon.

![Dialoogvenster Personen samenvoegen met opties om dubbele Personen (inclusief hun activiteiten) te verwerken en post-samenvoegacties te kiezen. -screenshot][img4]

## Gerelateerde inhoud

* [Bedrijven samenvoegen][1]
* [Verwijderde bedrijven en personen herstellen][2]

<!-- Referenced links -->
[1]: ../../company/learn/merge-companies.md
[2]: ../../learn/basics/deleting-elements.md#restore

<!-- Referenced images -->
[img4]: ../../../media/loc/en/contact/merge-contacts.png
