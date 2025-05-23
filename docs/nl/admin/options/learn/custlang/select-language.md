---
uid: help-nl-languages-selection
title: Klanttaal voor nieuwe contactpersonen
description: Hoe SuperOffice de klanttaal voor nieuwe personen selecteert
author: SuperOffice RnD
date: 06.29.2022
keywords: taal
topic: howto
language: nl
---

# Hoe SuperOffice de klanttaal voor nieuwe personen selecteert

Wanneer een nieuwe contactpersoon verzoek stuurt, probeert SuperOffice te bepalen welke klanttaal moeten worden weergegeven voor de contactpersoon.

## Scenario 1

1. John, een nieuwe contactpersoon, registreert een nieuw verzoek in het Customer Centre cs.liberty.com met het e-mailadres `john@coca-cola.se`.

2. Het nieuwe verzoek wordt verzonden naar het systeem, waar het e-maildomein van John (coca-cola.se) wordt gecontroleerd. Coca-cola.se is geregistreerd als domein voor het bedrijf Coca-Cola.

3. John wordt toegevoegd als een nieuwe persoon voor Coca-Cola en niet als nieuwe persoon zonder bedrijf.

4. SuperOffice Service controleert vervolgens of het e-maildomein .se gekoppeld is aan een van de geregistreerde klanttalen. .se is geregistreerd als domein voor de klanttaal Zweeds.

5. De klanttaal voor persoon John wordt daarom ingesteld als Zweeds.

6. SuperOffice Service stuurt een Zweeds antwoordsjabloon (als dit is gemaakt) naar John, waarmee hij wordt geïnformeerd dat het verzoek ontvangen en geregistreerd is.

7. John ontvangt een gebruikersnaam en wachtwoord van SuperOffice Service en kan zich aanmelden bij cs.liberty.com en toegang krijgen tot de Zweedse versie van SuperOffice Customer Centre. John krijgt ook toegang tot de Zweedse Veelgestelde vragen als dit is ingesteld in SuperOffice.

## Scenario 2

1. Maria een nieuwe contactpersoon, registreert een nieuw verzoek in het Customer Centre cs.liberty.com met het e-mailadres `maria@coca-cola.nl`.
2. SuperOffice verifieert vervolgens het e-maildomein en dit wordt geregistreerd onder het bedrijf Coca-Cola.
3. Maria wordt geregistreerd als nieuwe persoon voor Coca-Cola.
4. SuperOffice verifieert vervolgens of het e-maildomein .nl gekoppeld is aan een van de geregistreerde klanttalen. Het e-maildomein .nl is *niet* gekoppeld aan een klanttaal en daarom kan er geen enkele klanttaal worden bepaald voor Maria.
5. Maria krijgt een antwoordsjabloon in de standaardtaal voor haar bedrijf. Het SuperOffice Customer Centre en Veelgestelde vragen worden ook weergegeven in de standaardtaal.

## Scenario 3

1. Nederlands wordt toegevoegd als nieuwe klanttaal voor SuperOffice en gekoppeld aan het domein .nl.
2. Maria krijgt niet automatisch Nederlands toegewezen als klanttaal. Dit moet handmatig worden gedaan voor de persoon. Alleen nieuwe personen worden gecontroleerd op nieuwe klanttalen.
