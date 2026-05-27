---
uid: help-nl-screen-chooser
title: Schermkiezers
description: Schermkiezers
keywords: UI, screen chooser
author: digitaldiina
date: 05.11.2026
version: 11.11
content_type: concept
tier: core
language: nl
---

# Schermkiezers

[!include[Requirement](../../../includes/req-dev-tools-transition.md)]

Een schermkiezer is een script waarmee de gebruiker vanuit het standaardscherm kan worden omgeleid naar een ander scherm. Het script kan de CRMScript-functie "setVariable("url", myUrl)" uitvoeren om een andere dan de standaard-URL weer te geven. Op deze manier is het bijvoorbeeld mogelijk een aangepast scherm te openen in plaats van het scherm Verzoeken en/of berekeningen in het script uit te voeren voordat het scherm wordt weergegeven. Schermkiezers worden opgeslagen in een mapstructuur, op basis van de locatie in het systeem waar ze worden uitgevoerd.

## Eigenschappen schermkiezer

Hier kunt u een script toevoegen waardoor de gebruiker via de CRMScript-functie "setVariable("url", myUrl)" wordt omgeleid naar een ander scherm.
