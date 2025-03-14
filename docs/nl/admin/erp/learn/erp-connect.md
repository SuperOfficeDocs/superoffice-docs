---
uid: help-nl-erp-connect
title: Verbinding maken met ERP
description: Verbinding maken met ERP
author: SuperOffice RnD
date: 07.04.2022
keywords: ERP
topic: howto
language: nl
---

# Verbinding maken met ERP

[!include[Requirement](includes/req-integration-server.md)]

U kunt een SuperOffice-bedrijf verbinden met een klant/leverancier in het ERP-systeem. Personen die zijn geregistreerd onder het SuperOffice-bedrijf kunnen vervolgens worden gekoppeld aan individuen in het ERP-systeem. Op gelijke wijze kunnen SuperOffice-projecten worden gekoppeld aan projecten in het ERP-systeem. De gegevens tussen SuperOffice en het ERP-systeem worden dan gesynchroniseerd.

1. Ga naar het scherm Bedrijf, het scherm Persoon of het scherm Project en selecteer het tabblad **ERP**.

    > [!NOTE]
    > Als het tabblad **ERP** bedrijfs- , persoon- of projectinformatie bevat, bestaat er al een verbinding tussen SuperOffice en het ERP-systeem.

1. Klik op **Bewerken**. De opties zijn afhankelijk van of u een bedrijf, een persoon of een project bewerkt.
1. Bedrijf: Klik op **Klant** of **Leverancier**, afhankelijk van de ERP-actor waarmee u het bedrijf wilt koppelen. U kunt slechts één actor per bedrijf kiezen.
    *Of* Project: Klik op **Project**.
    *Of* Persoon: Klik op **Persoon**.
1. Voer in het dialoogvenster **Verbinden met ERP** de tekst waarop moet worden gezocht op in het zoekveld en klik op **Zoeken**. U kunt ook op <i class="ph ph-magnifying-glass" aria-label="Zoek"></i> klikken om een geavanceerde zoekopdracht te starten (zie [Het scherm Zoeken gebruiken][1]).

    > [!TIP]
    > Als u een zoekopdracht geeft met een leeg zoekveld, worden alle records in het ERP-systeem weergegeven.

1. Selecteer een item uit de lijst met treffers. Als u geen treffers hebt, kunt u [een nieuwe "actor" maken in het ERP-systeem][2], gebaseerd op gegevens uit SuperOffice CRM.
1. Klik op **Verbinden**. Er wordt een dialoogvenster weergegeven met de gegevens die worden gesynchroniseerd tussen SuperOffice CRM en het ERP-systeem. Welke gegevens hier worden weergegeven, wordt gedefinieerd in Instellingen en onderhoud.
1. Als de gegevens van de twee systemen verschillen, selecteer dan de correcte gegevens.
    Bijvoorbeeld: als de adressen verschillen, selecteer dan het correcte adres. De andere gegevens worden overschreven.
1. Klik op **Verbinden**. Hiermee gaat u terug naar het tabblad **ERP** waarop de gesynchroniseerde gegevens nu worden weergegeven.
1. Klik op **Opslaan**.
1. Als u wilt, kunt u klikken op **Nu synchroniseren**.

## Gerelateerde inhoud

* [Een actor maken in het ERP-systeem][2]
* [Synchronisatie uitschakelen][3]

<!-- Referenced links -->
[1]: ../../../search-options/learn/find-screen.md
[2]: erp-create-new-actor.md
[3]: erp-sync-disconnect.md
