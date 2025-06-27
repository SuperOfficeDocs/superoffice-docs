---
uid: help-nl-document-template-defaults
title: Standaardwaarden voor nieuwe documentsjablonen
description: Standaardwaarden voor nieuwe documentsjablonen
author: Bergfrid Dias
date: 03.24.2023
keywords: nummer, teller
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
---

# Standaardwaarden voor nieuwe documentsjablonen

U kunt desgewenst standaardwaarden voor documentsjablonen definiëren. Dit betekent dat de waarde in het veld **Onze ref.** in het scherm Document elke keer met 1 toeneemt als precies deze sjabloon wordt gebruikt. Als u het selectievakje **Automatisch nieuwe tellers maken voor nieuwe documentsjablonen** niet inschakelt, wordt één teller gebruikt voor alle documentsjablonen. Hierdoor neemt, voor elke keer dat een sjabloon wordt gebruikt, de waarde van het veld **Onze ref.** met 1 toe, ongeacht welke sjabloon het is.

> [!NOTE]
> Of het veld **Onze ref.** in het scherm Document functioneert als een tellerveld, hangt af of de {snum}sjabloonvariabele is opgegeven voor de desbetreffende sjabloon. Dit wordt gedefinieerd in het scherm Lijsten: Klik op **Documentsjabloon**, dubbelklik vervolgens op de documentsjabloon, onder **Items** en bewerk het veld **Onze referentie (standaard)** in het dialoogvenster **Item in lijst bewerken** .

## Specificeer dat nieuwe documentsjablonen een eigen teller hebben

1. [!include[Go to Options](../includes/open-options.md)]

2. Selecteer het tabblad **Nummertoewijzing**.

3. Selecteer onder in het tabblad **Automatisch nieuwe tellers maken voor nieuwe documentsjablonen**.

4. Klik op **Standaardwaarden**.

5. Schakel **Uniek** in als u wilt dat de tellerwaarden in het veld **Onze ref.** uniek zijn. Handig wanneer SuperOffice CRM-gebruikers zelf waarden toewijzen.

6. Schakel het selectievakje **Blanco toestaan** in om lege tellervelden toe te staan. Handig wanneer de tellerwaarden uniek moeten zijn. Als **Blanco toestaan**is ingeschakeld, houdt dat in dat de eis dat de waarden uniek moeten zijn niet geldt voor lege velden.

7. Schakel **Alleen lezen** in als u niet wilt dat SuperOffice CRM-gebruikers zelf een waarde kunnen typen in het veld **Onze ref.**.

8. Schakel **Toewijzen** in om de automatische tellerfunctie te gebruiken, zodat het veld **Onze ref.** automatisch wordt gevuld.

    [Bekijk de resultaten van verschillende combinaties van deze waarden][1].

9. Voer in het veld **Volgende nummer** de waarde in waarmee u de teller wilt laten beginnen.

10. Klik op **Opslaan**.

<!-- Referenced links -->
[1]: index.md

<!-- Referenced images -->
