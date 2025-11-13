---
uid: help-nl-flow-actions
title: Definieer flowacties
description: Definieer flowacties
keywords: flow, automatisering, flowactie, script uitvoeren, verdeel naar eigenaar
author: Bergfrid Dias
date: 09.26.2025
version: 11.3
content_type: howto
category: marketing
topic: flows
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: nl
---

# Definieer flowacties

## Beschikbare acties

* [Bericht verzenden](#send)
* [Deelnemer bijwerken](#update)
* [Activiteit maken](#create)
* [Interne acties](#internal)

> [!NOTE]
> Bij het toevoegen of bijwerken van flowacties moet u er rekening mee houden dat formulieren en bijgehouden links ook acties hebben. Zorg ervoor dat er geen dubbele of conflicterende acties zijn. We raden aan om alle acties op één plek op te nemen, ofwel in het formulier of in de flow.

## <a id="send"></a>Bericht verzenden

Overwegingen:

* Hoe vaak moeten we nieuwe informatie verzenden?
* Moet de volgende e-mail gebaseerd zijn op contactbetrokkenheid, wanneer een persoon een formulier invult of op een gevolgde link klikt?
* Moeten alle contacten dezelfde inhoud ontvangen?

### E-mail verzenden (mailing)

Een e-mailstap wordt gebruikt om een e-mail te verzenden naar een actieve flow-deelnemer. U kunt een al voorbereide e-mail selecteren of een nieuwe toevoegen.

1. Sleep de **E-mail verzenden**-box uit het stappenmenu en laat deze vallen in een beschikbare sleuf in het diagram.

    > [!NOTE]
    > Wanneer u een e-mailstap toevoegt, moet u e-mailinstellingen opgeven voordat u de flow start. Als deze instellingen ontbreken, ziet u een waarschuwingssymbool (zoals in de onderstaande screenshot). U kunt de flow nog steeds opslaan! Ga eenvoudig door met het ontwerpen van de flow en keer later terug naar de e-mailinstellingen.

1. Kies een van de opties:

    * Maak een nieuwe e-mail voor deze stap. Voer een naam in en klik op **maken**. Dit opent de Mailing wizard bij de stap **Sjabloon**.
    * Selecteer een bestaande e-mail voor deze stap. Klik om inhoud te selecteren.

1. Voer het **onderwerp** van de e-mail in. Contactvariabelen zijn beschikbaar.

1. Voeg optioneel één of meer bijlagen toe (maximaal 25 MB totaal).

![E-mailstap toevoegen aan flow -screenshot][img1]

> [!NOTE]
> Het maken van een nieuwe e-mail als flowinhoud is alleen mogelijk vanuit de flow-UI.

### SMS verzenden

Een SMS-stap wordt gebruikt om een SMS te verzenden naar een actieve flow-deelnemer.

Deelnemers zonder geregistreerd telefoonnummer kunnen de stap overslaan (doorgaan naar de volgende stap) of de flow verlaten, afhankelijk van de stapinstellingen.

1. Sleep de **SMS verzenden**-box uit het stappenmenu en laat deze vallen in een beschikbare sleuf in het diagram.

1. Voer de afzender en de SMS-tekst in. Contactvariabelen zijn beschikbaar.

1. Selecteer optioneel **Flow verlaten als er geen mobiel telefoonnummer is geregistreerd** en kies hoe u omgaat met contacten die de SMS niet kunnen ontvangen.

> [!TIP]
> Als u slechts één SMS wilt verzenden, houd dan het aantal tekens in de gaten in de rechterbenedenhoek. Als het aantal tekens meer dan 160 bedraagt, wordt het bericht verzonden als meerdere SMS-segmenten en kunnen extra kosten van toepassing zijn. We raden aan het bericht kort en informatief te houden.

## <a id="update"></a>Deelnemer bijwerken

* Persoon bijwerken
* Toevoegen aan selectie/project
* Verwijderen uit selectie/project

### Persoon bijwerken

Gebruik deze stap om relevante gegevens over een persoon of hun bedrijf bij te werken, voordat de deelnemer naar de volgende stap in de flow gaat.

1. Sleep de **Persoon bijwerken**-box uit het stappenmenu en laat deze vallen in een beschikbare sleuf in het diagram.

1. Selecteer een veld om bij te werken in de **Veld**-kolom. U kunt ook de naam typen in het veld. Naarmate u elke letter typt, worden relevante overeenkomsten weergegeven.

1. Selecteer een actie in de **Actie**-kolom. De [beschikbare acties][11] zijn afhankelijk van het type veld dat u in de vorige stap hebt geselecteerd.

1. Specificeer nieuwe waarden indien van toepassing.

1. Om extra velden bij te werken, klik op **Toevoegen** en herhaal stap 2-4.

1. Zorg ervoor dat alle velden die u wilt bijwerken - en alleen die - zijn aangevinkt. U kunt op het rode X klikken om overtollige regels te verwijderen.

![Contactgegevens bijwerken in flow -screenshot][img2]

Dit werkt vergelijkbaar met [bulksgewijs bijwerken][11].

### Toevoegen aan selectie/project

Houd overzicht over degenen die zich hebben aangemeld, of betrokken waren, of volg ze later op.

1. Sleep de **Toevoegen aan selectie/project**-box uit het stappenmenu en laat deze vallen in een beschikbare sleuf in het diagram.

1. Voeg persoon toe aan statische selectie: kies een statische contactselectie uit de lijst of klik op **Nieuw** om een nieuwe te maken.

1. Voeg persoon toe als projectlid: kies een project uit de lijst.

> [!TIP]
> Begin met typen om een lijst te doorzoeken.

### Verwijderen uit selectie/project

Persoon wordt verwijderd als lid uit de gespecificeerde selectie en/of project.

Deze stap is vergelijkbaar met **Toevoegen aan selectie/project**.

### <a id="distribute"></a>Distribueer naar eigenaar

Verdeel contactpersonen gelijkmatig over geselecteerde medewerkers of groepsleden. Handig voor het automatisch toewijzen van nieuwe leads aan een team.

1. Sleep het blok **Distribueer naar eigenaar** vanuit het stappenmenu en laat deze vallen in een beschikbare sleuf in het diagram.
1. Selecteer één of meer medewerkers of een primaire groep om de contactpersonen aan toe te wijzen.
1. Optioneel: Deselecteer **Alleen nieuwe eigenaar toepassen als de contactpersoon momenteel niet is toegewezen** om bestaande contacteigenaren te overschrijven.
1. Optioneel: Stel een standaard eigenaar in bij **Als er niemand beschikbaar is, wijs dan contactpersonen toe aan**.

De nieuwe eigenaar [ontvangt een melding][10] voor elke toegewezen contactpersoon.

## <a id="create"></a>Activiteit maken

De flow kan automatisch een vervolgactiviteit, verzoek en/of verkoop maken bij het persoon volgens de instellingen. Door CRM-activiteiten en meldingen te koppelen, kan uw organisatie de kloof tussen marketing en verkoop overbruggen. Het maken van activiteiten stelt u ook in staat zich te richten op contacten die betrokken zijn.

### Vervolgactiviteit maken

Voorbeeld: Stel een gratis consult in op de eerste beschikbare tijd in de agenda van Onze contactpersoon. Ze worden op de hoogte gebracht in het **Meldingen**-paneel.

1. Sleep de **Vervolgactiviteit maken**-box uit het stappenmenu en laat deze vallen in een beschikbare sleuf in het diagram.

1. Voer een titel in.

1. Selecteer een type.

1. Specificeer een vervaldatum voor een to-do of reserveer de eerste beschikbare tijd voor een vergadering.

1. Wijs toe aan: kies wie de deelnemer moet opvolgen: "onze contactpersoon" of "onze servicecontactpersoon", of een specifiek benoemde collega.

1. Voer optioneel andere informatie in. Zie voor details de [lijst met stapinstellingen][1] en [hoe u een vervolgactiviteit kunt maken][12].

### Verzoek maken

1. Sleep de **Verzoek maken**-box uit het stappenmenu en laat deze vallen in een beschikbare sleuf in het diagram.

1. Voer een beschrijvende **titel** in.

1. Selecteer een [verzoektype][14], wat van invloed is op standaardwaarden en beschikbare statussen en prioriteiten.

1. Selecteer [status][15], [categorie][16] en [prioriteit][17].

1. **Eigenaar:**
    * Om het verzoek aan een specifiek persoon toe te wijzen, selecteert u de gewenste naam.
    * **Automatisch toegewezen:** Als u deze optie selecteert, wijst het systeem het verzoek toe volgens de van toepassing zijnde toewijzingsregels.
    * **Niet toegewezen:** U kunt er ook voor kiezen om het verzoek niet toe te wijzen. De leden van de relevante categorie worden dan verantwoordelijk voor de afhandeling van het verzoek.

1. Voer de feitelijke boodschap in die u aan het verzoek wilt toevoegen.

Voor details, zie de [lijst met stapinstellingen][1] en [hoe u een verzoek kunt maken][13].

### Verkoop maken

Wanneer een persoon deze stap bereikt, is het persoon volwassen geworden en heeft het aanwijzingen gegeven dat het een verkoopkans is.​

1. Sleep de **Verkoop maken**-box uit het stappenmenu en laat deze vallen in een beschikbare sleuf in het diagram.
1. Voer een beschrijvende **titel** in.
1. Selecteer een verkoopstype, wat van invloed is op standaardwaarden en beschikbare fasen.
1. Voer de vereiste informatie in de andere velden in.
1. Eigenaar: Kies wie deze lead moet opvolgen: "onze contactpersoon" of "onze servicecontactpersoon", of een specifiek benoemde collega.

    > [!NOTE]
    > Voeg ook een vervolgactiviteit toe om de eigenaar van de verkoop op de hoogte te stellen van deze nieuwe kans​.

Voor details, zie de [lijst met stapinstellingen][1] en [hoe u een verkoop kunt maken][18].

## <a id="internal"></a>Interne acties

### Script uitvoeren

Voer aangepaste bedrijfslogica uit door een CRMScript te activeren als onderdeel van de flow.

1. Sleep de **Script uitvoeren**-box uit het stappenmenu en laat deze vallen in een beschikbare sleuf in het diagram.
1. Kies een [CRMScript][20] uit de lijst.

> [!NOTE]
> De deelnemer gaat onmiddellijk naar de volgende stap nadat het script is geactiveerd, zonder te wachten op het resultaat.

### Melden via e-mail

Stuur een melding per e-mail naar een specifieke persoon als onderdeel van de flow.

1. Sleep het vak **Melden via e-mail** uit het stappenmenu en laat deze vallen in een beschikbare sleuf in het diagram.
1. Geef de ontvanger op (**Aan:**).
1. Voer het **onderwerp** van de e-mail in.
1. Voer het bericht in dat u wilt verzenden.

Contactvariabelen zijn beschikbaar.

### Melden via SMS

Stuur een SMS naar een specifieke persoon als onderdeel van de flow.

1. Sleep het vak **Melden via SMS** uit het stappenmenu en laat deze vallen in een beschikbare sleuf in het diagram.
2. Geef de ontvanger op (**Aan:**).
3. Voer het bericht in dat je wilt verzenden. Contactvariabelen (merge tags) zijn beschikbaar.

Als er geen mobiel nummer is opgegeven bij de geselecteerde contacten, wordt er geen SMS ontvangen aan de andere kant.

## Flowactie vs. formulieractie

Verschillende actietypen zijn mogelijk zowel als formulieractie als als flow-stap​.

Een [formulieractie][6] kan:

* Persoon toevoegen aan selectie en/of project
* Interesse toevoegen aan persoon
* Standaard categorie en bedrijf instellen voor nieuwe contacten en bedrijven
* Een verzoek maken
* Een formulierrespons verzenden naar persoon

## Flowactie vs. linkactie

Een [linkactie][7] kan:

* Persoon toevoegen aan selectie en/of project
* Interesses bijwerken
* Een waarde toevoegen aan een [extra veld][19] van persoon
* Een verzoek maken
* Een vervolgactiviteit maken

<!-- Referenced links -->
[1]: step-settings.md
[6]: ../../forms/learn/define-form-actions.md
[7]: ../../tracked-links/learn/define-link-actions.md
[10]: ../../../learn/basics/notifications.md
[11]: ../../../learn/basics/bulk-update.md
[12]: ../../../diary/learn/create-follow-up.md
[13]: ../../../request/learn/create.md
[14]: ../../../request/admin/type/index.md
[15]: ../../../request/admin/status/index.md
[16]: ../../../request/admin/category/index.md
[17]: ../../../request/admin/priority/index.md
[18]: ../../../sale/learn/create.md
[19]: ../../../custom-objects/learn/extra-field.md
[20]: ../../../automation/crmscript/learn/create-script.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/flow-send-email-new.png
[img2]: ../../../../media/loc/en/marketing/flow-update-contact.png
