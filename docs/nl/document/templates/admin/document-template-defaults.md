---
uid: help-nl-document-template-defaults
title: Standaardwaarden voor nieuwe documentsjablonen
description: Standaardwaarden voor nieuwe documentsjablonen
keywords: nummertoewijzing, nieuwe teller, documentsjabloon teller, standaardwaarden
author: digitaldiina
date: 10.21.2025
version: 11.5
content_type: howto
category: document
topic: template
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /nl/admin/options/learn/number-allocation/document-template-defaults
language: nl
---

# Standaardwaarden voor nieuwe documentsjablonen

U kunt desgewenst [standaardwaarden][1] voor documentsjablonen definiëren. Dit betekent dat de waarde in het veld **Onze ref.** in het scherm Document elke keer met 1 toeneemt als precies deze sjabloon wordt gebruikt. Als u het selectievakje **Automatisch nieuwe tellers maken voor nieuwe documentsjablonen** niet inschakelt, wordt één teller gebruikt voor alle documentsjablonen. Hierdoor neemt, voor elke keer dat een sjabloon wordt gebruikt, de waarde van het veld **Onze ref.** met 1 toe, ongeacht welke sjabloon het is.

> [!NOTE]
> Of het veld **Onze ref.** in het scherm Document functioneert als een tellerveld, hangt af of de {snum}sjabloonvariabele is opgegeven voor de desbetreffende sjabloon. Dit wordt gedefinieerd in het scherm Lijsten: Klik op **Documentsjabloon**, dubbelklik vervolgens op de documentsjabloon, onder **Items** en bewerk het veld **Onze referentie (standaard)** in het dialoogvenster **Item in lijst bewerken** .

## Specificeer dat nieuwe documentsjablonen een eigen teller hebben

1. Ga naar Instellingen en onderhoud en selecteer <i class="ph ph-sliders-horizontal" aria-hidden="true"></i> **Opties**.

1. Selecteer het tabblad **Nummertoewijzing**.

1. Selecteer onder in het tabblad **Automatisch nieuwe tellers maken voor nieuwe documentsjablonen**.

1. Klik op **Standaardwaarden**.

1. Schakel **Uniek** in als u wilt dat de tellerwaarden in het veld **Onze ref.** uniek zijn. Handig wanneer SuperOffice CRM-gebruikers zelf waarden toewijzen.

1. Schakel het selectievakje **Blanco toestaan** in om lege tellervelden toe te staan. Handig wanneer de tellerwaarden uniek moeten zijn. Als **Blanco toestaan**is ingeschakeld, houdt dat in dat de eis dat de waarden uniek moeten zijn niet geldt voor lege velden.

1. Schakel **Alleen lezen** in als u niet wilt dat SuperOffice CRM-gebruikers zelf een waarde kunnen typen in het veld **Onze ref.**.

1. Schakel **Toewijzen** in om de automatische tellerfunctie te gebruiken, zodat het veld **Onze ref.** automatisch wordt gevuld.

    [Bekijk de resultaten van verschillende combinaties van deze waarden][1].

1. Voer in het veld **Volgende nummer** de waarde in waarmee u de teller wilt laten beginnen.

1. Klik op **Opslaan**.

<!-- Referenced links -->
[1]: ../../../admin/options/configure-number-allocation.md

<!-- Referenced images -->
