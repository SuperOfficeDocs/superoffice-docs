---
uid: help-nl-automation-script-tracing
title: Traceren
description: Traceren
author: SuperOffice RnD
so.date: 06.29.2022
keywords: CRMScript, traceren, fout opsporen
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: nl
---

# Traceren

De traceringsfunctie legt alle details van de uitvoering van een script of macro vast en slaat deze op in een logboek. Bij elk gebruik van het script of de macro wordt de uitvoering vastgelegd.

U kunt vervolgens de uitvoering van het script onderzoeken door de vastgelegde scriptuitvoering terug en vooruit te spoelen. U ontvangt een complete lijst met alle vastgelegde uitvoeringen van het script en met vermelding van degenen die het script hebben uitgevoerd. Op deze manier kunt u zien hoe uw scripts zich hebben gedragen en kunt u alle variabelen op elk willekeurig moment bekijken.

## Traceringen weergeven

Het tabblad **Traceren** bevat een lijst met alle traceringen. Klik op een tracering in de lijst om de details weer te geven.

## Traceringen starten

* Ga naar **CRMScript** > **Foutopsporingssessies** en klik op ![pictogram][img1] **Traceringsscripts starten** om de tracering van de scripts in de lijst te starten.
* Open een script of macro in **Foutopsporing** en klik op ![pictogram][img2] **Script traceren**.
* Open een script of macro in het tabblad **Macro’s en scripts** en klik op ![Pictogram][img2] **Script traceren**.

## Traceringen bewerken

1. Klik op een tracering in de lijst **Traceren** om deze te openen.

2. Klik op ![pictogram][img3] **Tracering bewerken**. Het scherm **Tracering bewerken** wordt geopend.

3. Vul de volgende velden in:

    * **Beschrijving**: voer een beschrijving van de tracering in om deze makkelijker te kunnen identificeren.
    * **Gebruikersfilter**: Als u het script wilt traceren voor een bepaalde gebruiker, selecteert u de gebruiker uit de lijst.
    * **Traceeroplossing**: voer de metingsfrequentie in voor het traceringslogboek.
        Bijvoorbeeld: voer 1 in om elke opdracht vast te leggen die het script uitvoert. voer 5 in om elke vijfde opdracht vast te leggen die het script uitvoert.
    * **Traceringen bewaren**: selecteer hoe lang de traceringslogboeken moeten worden bewaard.
    * **Ingeschakeld**: selecteer deze optie om de tracering te activeren.

4. Klik op **OK** wanneer u klaar bent.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../../media/icons/run-script.png
[img2]: ../../../../media/icons/btn-script-trace-small.png
[img3]: ../../../../media/icons/edit.png
