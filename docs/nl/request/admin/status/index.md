---
uid: help-nl-request-status
title: Verzoekstatus
description: Verzoekstatus
keywords: verzoek, status, verzoekstatus, tabblad Verzoekstatus
author: Bergfrid Dias
date: 03.14.2025
version: 10.5.2
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: nl
redirect_from: /nl/request/learn/status/index
index: true
---

# Verzoekstatus

Alle verzoeken die zijn geregistreerd in SuperOffice, hebben een status, zoals **Open**, **Gesloten** of **Uitgesteld**. Selecteer **Verzoek** in de Navigator en in het tabblad **Verzoekstatus**, u kunt u de verzoekstatussen zien die al in het systeem zijn gedefinieerd en extra verzoekstatussen maken. Een verzoekstatus moet zijn gekoppeld aan een van de interne statuswaarden van het systeem, zoals **Open** of **Gesloten**. Elke interne status moet zijn gekoppeld aan minimaal één verzoekstatus.

U kunt bijvoorbeeld een nieuwe status maken met de naam 'Wacht op antwoord', als een meer gedetailleerde variant van **Gesloten** of **Open**, afhankelijk van de manier waarop het systeem deze status intern moet verwerken en rapporteren. U kunt ook aangepaste logica aan dergelijke statussen koppelen om bedrijfsprocessen te stroomlijnen.

## Instellingen

| Instelling | Beschrijving |
|---|---|
| Naam | De naam van de verzoekstatus. Standaard heeft elke interne status een verzoekstatus met dezelfde naam. |
| Interne status | De interne statuswaarden van het systeem. Elke interne status moet zijn gekoppeld aan minimaal één verzoekstatus. De systeemstatussen **Gekoppeld** en **Verwijderd** worden alleen gebruikt voor respectievelijk samengevoegde verzoeken en verwijderde verzoeken en zijn niet zichtbaar voor de gebruiker. |
| Standaard | Geeft aan of dit een standaardstatus is voor de interne status. |
| Wachtrijstatus | Geeft aan of verzoeken met deze status in de wachtrij geplaatst moeten worden. Dit is relevant als u de functie **Volgende in wachtrij ophalen** gebruikt. |
| Tijd traceren als | Wordt gebruikt om tijdsgebruik in verschillende fasen van het verzoekbeheer te rapporteren. Het systeem berekent de tijd zowel in relatie tot bepaalde 'openingstijden' en de gehele periode van 24 uur. Kies uit: in de wachtrij en wachtend op verwerking, in de interne beslissingsfase, in de externe beslissingsfase |

## Gerelateerde inhoud

* [Verzoekstatus maken][1]
* [Verzoekstatus verwijderen][2]
* [Instellen van Volgende verzoek in wachtrij ophalen][3].

<!-- Referenced links -->
[1]: create.md
[2]: delete.md
[3]: ../next-in-queue.md
