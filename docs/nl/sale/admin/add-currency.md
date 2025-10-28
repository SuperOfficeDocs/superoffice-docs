---
uid: help-nl-currency-add
title: Valuta
description: Items toevoegen aan de lijst Valuta
keywords: lijst Algemeen - Valuta, valuta
author: digitaldiina
date: 10.28.2025
version: 10.5
content_type: howto
category: sale
license: salesessentials
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from:
  - /nl/admin/lists/learn/adding-items-to-currency-list
  - /nl/admin/lists/learn/currency
language: nl
---

# Valuta

Op het scherm Verkoop van SuperOffice CRM geeft u het verkoopbedrag, de kosten en winst op voor de verkoop. De valuta waarin de bedragen worden weergegeven is afhankelijk van wat u opgeeft in de [voorkeuren][2], waar u uw eigen valuta kiest en een basisvaluta in een lijst die is gedefinieerd in het scherm Lijsten.

## Valuta toevoegen

1. Selecteer <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lijsten** in de navigator.

1. Kies **Algemeen – Valuta** in het dropdownmenu. Het tabblad **Items** toont alle bestaande valuta's.

1. Klik op **Toevoegen** om het dialoogvenster **Lijstitem bewerken** te openen.

1. Voer de gewenste naam van het item in het veld **Naam** in. *(Verplicht)*

1. Geef in het veld **Koers** de koers voor de betreffende valuta op door een waarde in te voeren.

    > [!NOTE]
    > dit is de koers ten opzichte van de basisvaluta. De basisvaluta is de valuta waarvoor de koers is ingesteld op 1. Als EUR de basisvaluta is, wordt de koers voor de andere valuta berekend ten opzichte van deze valuta op basis van de opgegeven eenheid (zie het volgende punt). Bijvoorbeeld: GBP 1 komt overeen met EUR 1,562 tegen de dagkoers, terwijl NOK 100 overeenkomt met EUR 12,677. Deze berekening wordt weergegeven nadat u de wisselkoers en eenheid hebt opgegeven.

1. Geef in het veld **Eenheid** op welke eenheid wordt gebruikt in relatie tot de basisvaluta. De standaard is hier bijvoorbeeld 100 voor Noorse kronen en 1 voor Britse ponden.

1. Typ zo nodig een beschrijving voor de valuta in het veld **Beschrijving**.

1. Klik op **Opslaan**. De valuta wordt als een afzonderlijk item toegevoegd aan de lijst **Items**. Herhaal deze procedure voor alle valuta's die u wilt toevoegen.

## Standaardvaluta wijzigen

Om de standaardvaluta te wijzigen, opent u het scherm **Voorkeuren** en gaat u naar tabblad **Algemene voorkeuren** > **Systeem** > **Basisvaluta**.

## Gebruik van valuta inschakelen

Om verkopen in een andere valuta te registreren, opent u het scherm **Voorkeuren** en gaat u naar tabblad **Voorkeuren** > **Systeem** > **Gebruik van valuta inschakelen**.

<!-- Referenced links -->
[2]: ../../admin/preferences/index.md
