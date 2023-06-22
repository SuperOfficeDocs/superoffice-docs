---
uid: help-da-page-1-fields
title: Valg af side 1-felt
description: Valg af side 1-felt
author: SuperOffice RnD
so.date: 06.29.2022
keywords: udef, tilpasset felt
so.topic: howto
so.user: admin
so.user.tooltip: Settings and maintenance
language: da
---

# Valg af side 1-felt

> [!NOTE]
> Denne funktion er ikke tilgængelig, hvis din organisation bruger tilpassede skærmlayout.

Blandt de brugerdefinerede felter, der vises under fanen **Mere** i SuperOffice CRM, kan du vælge *tre* der skal fungere som side 1-felter (såkaldte, fordi de vises på "første side" på deres respektive skærmbilleder).

## Hvor kan jeg få vist felterne Side 1?

[!include[List](includes/list-page-1-field-locations.md)]

## Sådan vises et brugerdefineret felt på den første side

1. [!include[Go to fields and select tab](includes/goto-fields.md)]

1. Markér **Tillad forskellige side 1-felter for forskellige brugergrupper** nederst på fanen for at angive forskellige side 1-felter for forskellige brugergrupper. Hvis afkrydsningsfeltet ikke er markeret, bruges de felter, du angiver, til alle brugergrupper.

1. På brugergruppelisten ovenfor skal du vælge den ønskede brugergruppe (hvis du markerede **Tillad forskellige side 1-felter for forskellige brugergrupper** i forrige trin).

1. På listen **Felt 1** skal du vælge det felt, der skal vises øverst. Vælg de felter, der skal vises på de næste placeringer på listerne **Felt 2** og **Felt 3** .

1. Klik på **Gem** for kun at gemme dine ændringer i Indstillinger og vedligeholdelse, eller klik på **Udgiv** for at gøre ændringerne tilgængelige for SuperOffice CRM-brugere.

## Brugergrupper og side 1-felter

Når du vælger et navn på listen **Brugergruppe**, vises de tilgængelige side 1-felter for den valgte brugergruppe**under**felt 1**,**2**og**3**.

> [!NOTE]
> Brugergrupper defineres på skærmbilledet **Lister** og den gruppe, som en bruger tilhører, defineres på skærmbilledet Brugere.

Hvis du vælger **(alle brugergrupper)** på **brugergruppelisten**, vælger et eller flere felter og gemmer opsætningen, gælder det samme valg af felter for alle brugergrupper i SuperOffice CRM. Hvis du derefter vælger en bestemt brugergruppe, kan du tilsidesætte den eksisterende feltopsætning for netop denne gruppe ved hjælp af en anden specifikation. Hvis du ikke angiver noget i et felt, efterlades det tomt – fordi tilsidesættelsen gælder for alle tre felter uanset deres indhold.

> [!NOTE]
> Du skal publicere en tilsidesættelse for en enkelt brugergruppe *når* du har angivet en opsætning for alle brugergrupper. Ellers træder den ikke i kraft.

<!-- Referenced links -->

<!-- Referenced images -->
