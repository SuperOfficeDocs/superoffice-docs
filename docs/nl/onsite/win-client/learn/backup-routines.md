---
uid: help-nl-backup-routines
title: Routines voor het maken van reservekopieën
description: Routines voor het maken van reservekopieën
author: SuperOffice RnD
date: 06.29.2022
keywords: Windows Client-instellingen
content_type: concept
language: nl
client: win
deployment: onsite
---

# Routines voor het maken van reservekopieën

Als er een databasefout optreedt, is het uiterst belangrijk dat u goede back-uproutines hebt. Het maken van een reservekopie kan een weinig boeiend klusje zijn wanneer u dit elke dag moet doen. Maar als er iets fout gaat, kan het probleem snel worden hersteld als u een kopie van de database van de voorgaande dag hebt.

Stelt u zich voor dat u in de loop van een jaar een bedrijfsdatabase hebt samengesteld met meer dan 1500 bedrijven. U werkt dagelijks met SuperOffice CRM en u maakt bedrijven die u elke week belt en voor wie u vervolgactiviteiten onderneemt. U hebt afspraken in de toekomst gepland en alle documenten en vervolgactiviteiten vastgelegd in SuperOffice CRM. U bent echter 'vergeten' een resevekopie te maken van de bestanden van de afgelopen zes maanden.

Op een dag doet zich een fout voor op de vaste schijf die niet direct kan worden hersteld. U belt SuperOffice en krijgt de vraag of u gisteren een reservekopie hebt gemaakt...

Stelt u zich voor dat u alleen die ene reservekopie hebt van zes maanden oud. Hoeveel belangrijke bedrijven hebt u daarna geregistreerd? Hoeveel belangrijke telefoonnummers stonden in de database? Hoeveel adressen?

> [!NOTE]
> onthoud dat databases en vaste schijven niet faalveilig zijn. Er kan altijd een fout optreden en uw belangrijkste wapen is een goede routine voor het maken van reservekopieën. Maak elke dag een reservekopie van de database.

## Alleen een reservekopie maken van het gegevensbestand

* Als u een SQL-database gebruikt, volgt u de instructies voor het maken van reservekopieën in de documentatie voor de betreffende SQL-database. Dit genereert een database die alleen kan worden gebruikt in combinatie met de database waaruit deze is gegenereerd. Dit is de snelste manier om een back-up te maken.

* Open het bestand **dbsetup.exe** in de SuperOffice Server installatiemap en selecteer de optie **Een database naar een bestand exporteren**. Hiermee genereert u een database die op alle typen server die door SuperOffice CRM worden ondersteund, kan worden geïnstalleerd.

Als u bovendien een reservekopie wilt maken van alle documenten en sjablonen, moet u een reservekopie maken van de hele map **SO_ARC** met alle submappen.

<!-- online --> Online customers must contact SuperOffice Support to create a backup.
