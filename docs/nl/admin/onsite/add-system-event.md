---
uid: help-nl-system-event-add
title: Systeemgebeurtenissen toevoegen
description: Systeemgebeurtenissen toevoegen
keywords: gebeurtenis, melding, systeemgebeurtenis
author: SuperOffice Product and Engineering
date: 07.10.2025
version: 10.5
content_type: howto
deployment: onsite
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: 
  - /nl/admin/learn/system-events
  - /nl/admin/learn/add-system-events
language: nl
---

# Systeemgebeurtenissen toevoegen (lokaal)

U kunt bepaalde systeemgebeurtenissen opstarten vanuit de lijst **Systeemmeldingen** in het tabblad **Status**.

1. Open het scherm Licenties.

2. Selecteer het tabblad **Status**.

3. Klik op de knop **Toevoegen** onder **Systeemmeldingen**.

4. Kies in het dialoogvenster **Gebeurtenis toevoeg** en een [Systeemgebeurtenistype](#types) in de keuzelijst **Gebeurtenistype**.

5. Geef in het veld **Voltooid** de datum en tijd op wanneer de gebeurtenis naar verwachting voltooid zal zijn.

    > [!NOTE]
    > Gebeurtenissen worden niet automatisch voltooid. U moet ze verwijderen van het tabblad **Systeemgebeurtenissen** om ze te beëindigen.

6. Geef in het veld **Beschrijving** uitgebreidere informatie over de gebeurtenis op.

    > [!NOTE]
    > Als u een gebeurtenis van het type **Bericht van de dag** (bericht voor alle gebruikers) toevoegt, wordt de tekst in het veld **Beschrijving** samen met de verwachte tijd van voltooiing naar de gebruikers verzonden.

7. Klik op **Opslaan** om de gebeurtenis aan te maken. De gebeurtenis wordt weergegeven in de lijst **Systeemmeldingen** in het tabblad **Status.**

> [!TIP]
> Om een gebeurtenis te bewerken, dubbelklikt u het in de lijst.
>
> Om een gebeurtenis te verwijderen, selecteer het in de lijst en klik op de knop **Verwijderen**.

## <a id="types"></a>Typen

De volgende typen gebeurtenissen worden gestart vanuit de verschillende schermen in Instellingen en onderhoud:

* **UDefRebuild**, waarvan er verschillende typen zijn: de opmaak voor door gebruikers gedefinieerde velden wordt bijgewerkt en de door gebruikers gedefinieerde velden zijn niet toegankelijk terwijl deze gebeurtenis plaatsvindt.

    > [!NOTE]
    > U moet deze gebeurtenis niet annuleren vanuit de lijst **Systeemmeldingen**.

* **FreetextRebuild**: de vrije tekst-index wordt gegenereerd en gebruikers kunnen de freevrije tekst niet gebruiken terwijl de generatie aan de gang is.

* **PrototypeRebuild**: er wordt een Travel-prototype gegenereerd. De Travel-functies zijn niet toegankelijk terwijl deze gebeurtenis plaatsvindt.

    > [!NOTE]
    > In noodgevallen kunt u zowel **FreetextRebuild** als **PrototypeRebuild** annuleren via de lijst **Systeemmeldingen**.

* **ROURebuild**: tellers of statuscontroles worden opnieuw gegenereerd. Statusafbeeldingen, het tabblad **Statistieken** en tellers zijn niet beschikbaar terwijl de gebeurtenis plaatsvindt. (Voor statuscontroles is een [aparte licentie nodig][2].)

U kunt de volgende typen gebeurtenissen starten vanaf het licentiescherm in het tabblad **Status**:

* **Geen aanmelding**: Selecteer deze gebeurtenis om te voorkomen dat wordt aangemeld tijdens het bijwerken van server of database, periodiek onderhoud, etc.
* **Geen vrije tekst**: Selecteer deze gebeurtenis om de omvang van de uitgaande Travel-database te beperken.
* **Geen Travel**: Selecteer deze gebeurtenis om Travel uit te schakelen. Dit kan van pas komen tijdens grote systeem-upgrades, ter voorkoming van problemen met synchronisatie van terugkerende Travel-gebruikers.
* **Bericht van de dag**: Selecteer deze gebeurtenis om ervoor te zorgen dat belangrijke berichten worden weergegeven aan iedere gebruiker die zich aanmeldt bij SuperOffice CRM (en na een vertraging van een paar minuten aan alle gebruikers die zich al hadden aangemeld).

<!-- Referenced links -->
[2]: ../../../en/admin/license/index.md

<!-- Referenced images -->
