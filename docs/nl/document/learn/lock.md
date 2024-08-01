---
uid: help-nl-document-lock
title: Documenten aan/afmelden
description: Documenten aan/afmelden
keywords: document
author: Bergfrid Dias
date: 87.02.2024
topic: howto
language: nl
audience: person
audience_tooltip: SuperOffice CRM
---

# Documenten aan/afmelden

In SuperOffice CRM worden door veel verschillende mensen en op verschillende momenten documenten gemaakt, bewerkt en gelezen. Als meerdere gebruikers tegelijkertijd hetzelfde document bewerken, lopen ze het risico dat ze elkaars gegevens overschrijven. Ter voorkoming hiervan vergrendelt SuperOffice CRM een document wanneer het wordt bewerkt door een andere gebruiker. Andere gebruikers kunnen het document dan alleen in leesmodus openen. (Als uw organisatie een documentbibliotheek zoals SharePoint gebruikt, kunnen meerdere mensen tegelijkertijd een document bewerken.)

## Bewerkingsmodus en leesmodus

* Bewerkingsmodus: Het document is geopend voor bewerking. Het document kan niet worden bewerkt door andere gebruikers tot u het document hebt opgeslagen en gesloten, waardoor het document automatisch wordt aangemeld.

    Als u niet wilt dat een document automatisch wordt aangemeld wanneer u het opslaat en sluit, kunt u de optie **Aanmelding voorstellen na voltooiing bewerking** activeren in **Voorkeuren** in SuperOffice Web Tools.

* Leesmodus: Het document is geopend voor lezen. Als u wijzigingen aanbrengt, worden deze niet opgeslagen. Als u [de wijzigingen in uw document wilt opslaan][1], moet u een nieuw document maken in SuperOffice CRM en het bestand met uw wijzigingen uploaden.

Een document wordt standaard in de bewerkingsmodus geopend. Als u liever de leesmodus of bewerkingsmodus selecteert wanneer u een document opent, gaat u naar ![pictogram][img2] **Persoonlijke instellingen** > **Voorkeuren** > **Functies** en stelt u **Vragen om te bewerken of te lezen** in op **Ja**.

## Hoe weet ik wanneer een document is afgemeld?

In het dialoogvenster **Document** heeft een afgemeld document een van de volgende pictogrammen:

![pictogram][img3] Het document is momenteel afgemeld voor bewerking door uzelf.

![pictogram][img4] Het document is momenteel afgemeld voor bewerking door een andere gebruiker.

Houd de muisaanwijzer op een pictogram om informatie over de gebruiker weer te geven die het document heeft afgemeld.

Als u probeert een afgemeld document te openen, wordt er een dialoogvenster weergegeven met informatie over de persoon die het document heeft afgemeld. U kunt het document alleen in leesmodus openen.

## Een document afmelden voor bewerking

Open een document en selecteer de optie om [het document te bewerken][1]. Het document is afgemeld voor bewerking door uzelf. Andere gebruikers kunnen het document alleen in leesmodus openen.

## Een document aanmelden na bewerking

In de meeste gevallen kunt u [het document opslaan en sluiten][1] binnen de toepassing en wordt het document automatisch aangemeld.

## Een afmelding annuleren (opgeslagen versie gebruiken)

U hebt speciale bevoegdheden nodig om toegang te krijgen tot deze optie. U hebt ook schrijftoegang nodig voor het document.

> [!CAUTION]
> Als een andere gebruiker een document heeft afgemeld, moet u altijd contact opnemen met die gebruiker voordat u deze procedure uitvoert. Anders loopt u het risico dat u de wijzigingen van een ander overschrijft of dat de andere gebruiker uw wijzigingen overschrijft wanneer het document weer wordt aangemeld
>
> De beste optie zou kunnen zijn dat u een kopie maakt van het document en de kopie bewerkt.

Als u of iemand anders een document heeft uitgecheckt en u het document wilt bewerken, kunt u het afmelden annuleren:

1. Klik met de rechtermuisknop op het document en selecteer **Document**.
2. Klik in het dialoogvenster Document op ![pictogram][img1] en selecteer **Opgeslagen versie gebruiken**.

<!-- Referenced links -->
[1]: edit.md

<!-- Referenced images -->
[img1]: ../../../media/icons/btn-menu.png
[img2]: ../../../media/icons/personal-settings-small.png
[img3]: ../../../media/icons/document-lock-editing.png
[img4]: ../../../media/icons/document-lock-locked.png
