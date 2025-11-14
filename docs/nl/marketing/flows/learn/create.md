---
uid: help-nl-flow-create
title: Een nieuwe flow maken
description: Hoe een nieuwe flow te maken en de flowinstellingen te definiëren in SuperOffice Marketing
keywords: Marketing, flow, flow-controle, flow maken, flow-instelling
author: Bergfrid Dias, Trude Lien Smedbråten
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

# Een nieuwe flow maken

## Stappen

1. Selecteer **Marketing** in de Navigator.
1. Ga naar het tabblad **Flows**.
1. Klik indien nodig op **Map toevoegen** om [een map voor de flow te maken][8].
1. Klik op de knop **Flow** onder **Nieuwe maken** aan de rechterkant van het scherm.
1. Voer in het dialoogvenster **Flow-editor** een korte, beschrijvende **Naam** in.
1. [Vul de velden in](#fields) zoals hieronder beschreven. Vergeet niet regelmatig op **Opslaan** te klikken om uw werk op te slaan. De flow wordt niet automatisch opgeslagen.
1. [Definieer startpunkt triggers en filters.](#trigger)
1. [Voeg stappen toe.](#add-step)
1. Specificeer wat er gebeurt als de flow eindigt.
1. Klik op **Opslaan** wanneer u klaar bent.

![Eigenschappen instellen voor nieuwe flow -screenshot][img1]

## <a id="fields"></a>Veldinvulling voor de flow

### Instellingen (voor flow)

| Instelling | Beschrijving |
|---|---|
| Naam | Een beschrijvend label. |
| Beschrijving | Leg het doel van de flow uit. Deze tekst is alleen intern zichtbaar. |
| Tijdzone | Vereist om het verzendtijdframe te beperken. |
| Wanneer u bent ingeschreven, verwijdert u de persoon uit deze andere flows | Als aangevinkt, verandert de status van de deelnemer naar *Dropout* en verlaat hij de geselecteerde flows. Voorbeeld: verwijderen uit Lead nurturing wanneer ingeschreven in het Onboarding-flow. |
| Eigenaar | Medewerker die de flow aanmaakt. |
| Zichtbaar voor | Toegang tot de flow (eigenaar, groep van de eigenaar, iedereen). Het toegangs niveau wordt ook bepaald door functionele rechten. |
| Map | De locatie van de flow. |

### E-mail (instellingen)

Gemeenschappelijke e-mailinstellingen voor alle e-mails in de flow. Als u niet van plan bent e-mails vanuit deze flow te verzenden, kunt u deze instellingen overslaan.

| Instelling | Beschrijving |
|---|---|
| Type abonnement | Ingesteld op flow-niveau (in plaats van individueel op elke e-mailstap). Zorgt ervoor dat alle e-mails binnen een flow hetzelfde abonnementstype hebben. |
| Van, naam van, adres van | Dezelfde afzender op alle e-mailstappen binnen de flow. Selecteer in de lijst **Van** **Gebruik altijd** en voer het e-mailadres van de afzender in het onderstaande veld in om dezelfde afzender voor alle mailings te gebruiken. U kunt ook een verkoop- of ondersteuningscontact als afzender kiezen, indien deze voor deze ontvanger is gedefinieerd. Voer een e-mailadres in dat moet worden gebruikt als er geen verkoop- of ondersteuningscontact beschikbaar is. Als uw beheerder de [globale e-mailvalidatievoorkeur][12] heeft geactiveerd, selecteer dan het domein waarvan u wilt verzenden in de keuzelijst. |
| Antwoord aan | Dezelfde opties als hierboven. Daarnaast kunt u **Gebruik "Van" als adres vor Beantwoorden** selecteren. Alle antwoorden worden dan naar de afzender gestuurd. |
| Verstuur alleen e-mails en SMS binnen een bepaalde tijdframe | Beperkt het verzendtijdframe. Deelnemers wachten in deze stap tot het toegestane tijdframe begint. Kies tussen Werkdag (ma-vr) en Weekdag (ma-zo). Specificeer tijd. Vereist dat tijdzone is ingesteld. |
| Google Analytics gebruiken | Schakelt Google Analytics-tracking in voor alle e-mails in een flow. Wanneer ingeschakeld, kunt u bron en campagne instellen. |

> [!TIP]
> Timing beïnvloedt de openings- en interactiesnelheid van e-mails. Gebruik de instelling **tijdperiode** om de interactie van lezers te maximaliseren en om uw abonnees niet 's nachts te storen.

![Stel gemeenschappelijke e-mailinstellingen in voor nieuwe flow -screenshot][img2]

### Succescriteria (optioneel)

Succescriteria definiëren [wat succes betekent voor een flow][7].

1. Selecteer **Succescriteria** in het linkermenu.
1. Klik op **Succescriteria toevoegen** en kies een optie.
1. Selecteer optioneel **De deelnemer wordt direct naar de stap Voltooien verplaatst wanneer aan de succescriteria is voldaan**.

    * Als geselecteerd: De status van de deelnemer verandert in *Voltooid met succes* en ze verlaten andere acties later in de flow.

    * Als niet geselecteerd: De status van de deelnemer blijft *Actief* en ze volgen de flow verder. Wanneer ze de stap **Voltooien** bereiken, verandert hun status in *Voltooid met succes*. Gebruik deze optie als de succesgraad voornamelijk voor statistieken wordt gebruikt, en u wilt dat de deelnemer alle stappen voltooit, zelfs als succes is bereikt.

![Stel succescriteria in voor nieuwe flow -screenshot][img3]

## <a id="trigger"></a>Definieer triggers en filters

De stap **Trigger** wordt automatisch toegevoegd als het startpunt voor elke flow. Het bepaalt voor wie de flow relevant is. Triggers worden alleen geactiveerd voor actieve of gepauzeerde flows.

> [!NOTE]
> Het is mogelijk een flow te maken zonder enige geautomatiseerde trigger - door gebruik te maken van het contacttaakmenu of een selectietaak. We zullen dit speciale geval in een ander onderwerp bespreken.

1. Selecteer **Stappen** in het linkermenu.
1. Klik op de **Trigger**-stap in het diagram.
1. Klik in de triggerveldinstellingen aan de rechterkant op **Trigger toevoegen** en kies een optie.
1. Voer de vereiste instellingen in voor de geselecteerde trigger.
1. Specificeer optioneel aanvullende kwalificatiecriteria.
1. Selecteer optioneel **Een contactpersoon kan deze flow slechts eenmaal starten**. Als een flow een tweede keer wordt geactiveerd op hetzelfde persoon, zorgt deze instelling ervoor dat ze niet opnieuw worden ingeschreven.

![Trigger toevoegen voor nieuwe flow -screenshot][img5]

| Trigger | Beschrijving |
|---|---|
| Persoon gemaakt | Wanneer een nieuw persoon wordt geregistreerd, onafhankelijk van de bron (behalve import). |
| Persoon bijgewerkt | Wanneer een persoon wordt bijgewerkt, ongeacht wat er wordt bijgewerkt (behalve import en bulk update). |
| Verkoop gemaakt | Wanneer een verkoop wordt geregistreerd op het persoon. |
| Verkoop verkocht | Wanneer een verkoop op het persoon is ingesteld op verkocht. |
| Verkoop verloren | Wanneer een verkoop op het persoon is ingesteld op verloren. |
| Toegevoegd aan project | Wanneer persoon is toegevoegd als projectlid. |
| Verzoek gemaakt | Wanneer een verzoek is aangemaakt op het persoon (onafhankelijk van de bron). |
| Formulier ingediend | Wanneer een formulier (ingediend door een persoon) **verwerkt** is (een handmatige stap kan betrokken zijn voordat het persoon in de flow terechtkomt). |
| Link geklikt | Wanneer een persoon op een gevolgde link klikt. |

**Opmerking:**

* Als u *formulier ingediend* of *link geklikt* selecteert, let dan op eventuele waarschuwingsiconen. Formulieren en gevolgde links kunnen ook bijbehorende acties hebben.
* Om contacten die zijn aangemaakt of bijgewerkt door een import op te nemen, moet u geïmporteerde contacten handmatig vanuit de selectie aan een flow toevoegen.
* Bij het triggeren op bijgewerkt persoon, hebben we toegang tot de huidige waarden van contactvelden. We hebben echter geen informatie over welk veld is bijgewerkt of de vorige waarde van een veld vóór de update.

### Persoonfilter toevoegen (optioneel)

**Filters** zijn aanvullende regels die worden toegepast op alle voorgestelde deelnemers (automatisch en handmatig toegevoegd). Gebruik het persoonfilter om specifieke contacten voor uw flow te selecteren. Stel bijvoorbeeld het filter in op *contactcategorie = prospect* om alleen prospects in de flow toe te laten, en geen bestaande klanten, die een formulier op uw website invullen. Dit stelt u in staat om inhoud op maat te maken voor verschillende gebruikersgroepen.

> [!NOTE]
> Filters zijn alleen van toepassing bij **het identificeren van nieuwe flow-deelnemers**. Eventuele wijzigingen die achteraf aan het filter worden aangebracht, hebben geen invloed op deelnemers die al zijn ingeschreven.

1. Selecteer het contactveld waarop u wilt filteren.
1. [Selecteer waarden voor het criterium][13] in de verschillende velden op de regel (vergelijkbaar met in het scherm **Zoeken**).
1. Klik op **Toevoegen** om aanvullende criteria in te stellen (voegt een nieuwe regel toe).

![Persoonfilter toevoegen bij trigger van nieuwe flow -screenshot][img6]

### Uitsluitingslijst (optioneel)

De uitsluitingslijst **voorkomt dat geselecteerde contacten aan de flow worden toegevoegd**. Gebruik een [statische selectie][14] om uitzonderingen te beheren, zoals:

* Voorkom dat specifieke klanten algemene massamails ontvangen.
* Stuur herinneringen, maar niet naar degenen die zich al hebben aangemeld.

## <a id="add-step"></a>Stap toevoegen

1. Selecteer **Stappen** in het linkermenu.
1. Kies een stap en sleep deze naar de gewenste plaats in het diagram.
1. Het stappenmenu verandert in **stapinstellingen**. [Beschikbare instellingen][9] zijn afhankelijk van het type stap.

    * [Bericht verzenden][3]
    * Flow-controle
    * [Deelnemer bijwerken][4]
    * [Activiteit maken][5]
    * [Interne acties][10]

Klik op de X in de koptekst van de stapinstellingen om terug te keren naar het stappenmenu.

### De eerste stap

Wanneer u het tabblad **Stappen** voor de eerste keer opent, ziet u iets als dit:

![Flow-stappen -screenshot][img4]

* Een diagram met een **Trigger**, een **placeholder** voor het toevoegen van een stap en een **Voltooi**-stap (in het midden).
* Een lijst met beschikbare staptypen (aan de rechterkant).

## <a id="wait"></a>Flow-controle

De meeste stappen in een flow vertegenwoordigen acties met betrekking tot de deelnemer, zoals het bijwerken van contactinteresses. Echter, flow-control stappen zijn anders; ze hebben betrekking op **timing** en **segmentatie**.

Zonder flow-controle zouden individuen van de ene actie naar de andere gaan totdat ze ofwel uitvallen of het einde van de flow bereiken. Ze zouden bijvoorbeeld het hele onboarding-programma in één dag kunnen ontvangen of alle nieuwsbrieven tegelijkertijd kunnen ontvangen.

Bovendien zou zonder flow-controle iedereen die is ingeschreven dezelfde reeks stappen volgen. Hoewel dit geschikt kan zijn voor een eenvoudige flow, kunt u door voorwaarden in te stellen voor daaropvolgende acties, bijvoorbeeld, een nieuwsbrief sturen in de voorkeurstaal van het persoon of een feedback-enquête sturen alleen naar degenen die het webinar hebben bijgewoond.

**Opties:**

* Wachttijd
* Wachten op actie
* [Opsplitsen][1]

> [!NOTE]
> Deelnemers worden gemarkeerd met een **wacht tot**-tijdstempel wanneer ze een wachtstap bereiken. Als de volgende stap een e-mail of SMS is, en een beperkt tijdframe is gespecificeerd in de e-mailinstellingen, kan de totale wachttijd langer zijn dan wat is ingesteld in de stap.

### Wachttijd

Gebruik een op tijd gebaseerde wachtstap om een specifiek aantal dagen te wachten voordat u de volgende e-mail/SMS verzendt, of om te wachten tot een specifieke datum voor specifieke gelegenheden of acties. Bijvoorbeeld om herinneringen 1 week, 1 dag en 1 uur voor een webinar te verzenden.

1. Sleep het vak **Wachttijd** uit het stappenmenu en laat het vallen in een beschikbare plaats in het diagram.
1. Stel de voorwaarde in. Doe een van de volgende dingen:

    * Selecteer **Aantal dagen/uren na vorige stap** en selecteer vervolgens aantal en eenheid.
    * Of, selecteer **Tot specifieke datum/tijd** en kies een datum uit de kalender.

Actieve deelnemers blijven bij deze stap voordat ze doorgaan naar de volgende stap volgens de gedefinieerde regel.

![Wachttijd voor flowstap -screenshot][img7]

### Wachten op actie

Gebruik een op actie gebaseerde wachtstap om te wachten tot de deelnemer iets doet (een formulier indienen of een link aanklikken).

1. Sleep het vak **Wachten op actie** uit het stappenmenu en laat het vallen in een beschikbare plaats in het diagram.

2. Klik op **Actie toevoegen** en selecteer welke actie wordt afgewacht.

3. Selecteer uit de lijst de naam van de link of het formulier waarop wordt gewacht.

4. Specificeer hoe lang u bereid bent te wachten op een actie (een timeout). De standaard maximale wachttijd is 7 dagen. Als u deze instelling uitschakelt, worden deelnemers die niet reageren, onbeperkt op deze stap vastgehouden.

5. Selecteer optioneel **Flow verlaaten als er geen acties binnen de maximale wachttijd zijn**. Deelnemers die niet reageren, verlaten de flow met de status *Dropout*. U kunt ervoor kiezen om ze naar een andere flow te verplaatsen en/of toe te voegen aan een statische selectie.

![Flowstap wachten op actie -screenshot][img8]

> [!TIP]
> U kunt wachten op meer dan één actie binnen een enkele stap. De eerst voorkomende actie (formulierindiening, linkklik of timeout) verplaatst de deelnemer verder in de flow. Herhaal gewoon stap 2 en 3 hierboven.

## Wat gebeurt er nu?

Na het ontwerpen van een flow en het opslaan ervan, sluit de **Flow-editor** en wordt het diagram weergegeven in het scherm **Flow weergeven**. De nieuwe flow heeft de status **Wordt niet uitgevoerd** totdat een flowbeheerder deze handmatig start door de schakelaar Actief in te schakelen.

## Gerelateerde inhoud

* [Stap verplaatsen, dupliceren of verwijderen][2]
* [Flowacties definieeren][3]
* [Flow opsplitsen][1]
* [Flow starten][6]

<!-- Referenced links -->
[1]: split.md
[2]: update.md
[3]: define-flow-actions.md
[4]: define-flow-actions.md#update
[5]: define-flow-actions.md#create
[10]: define-flow-actions.md#internal
[6]: run-pause-end.md
[7]: index.md#success
[9]: step-settings.md
[8]: ../../learn/create-folder.md
[12]: ../../mailing/admin/add-domain.md
[13]: ../../../search-options/learn/search-criteria.md
[14]: ../../../search-options/selection/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/flow-settings.png
[img2]: ../../../../media/loc/en/marketing/flow-email-settings.png
[img3]: ../../../../media/loc/en/marketing/flow-success-form-submission.png
[img4]: ../../../../media/loc/en/marketing/flow-steps-initial.png
[img5]: ../../../../media/loc/en/marketing/trigger-form-submitted.png
[img6]: ../../../../media/loc/en/marketing/flow-trigger-filter-contact.png
[img7]: ../../../../media/loc/en/marketing/flow-wait-time.png
[img8]: ../../../../media/loc/en/marketing/flow-wait-action.png
