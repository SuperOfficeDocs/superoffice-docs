---
uid: help-nl-request-category-create
title: Verzoekcategorie aanmaken
description: Verzoekcategorie aanmaken
keywords: verzoekcategorie, categorie, verzoek
author: Bergfrid Dias
date: 03.14.2025
version: 10.5.2
content_type: howto
license: serviceessentials
audience: settings
audience_tooltip: Settings and maintenance
language: nl
redirect_from: /nl/request/learn/category/create
index: true
---

# Verzoekcategorie aanmaken

1. Klik in Instellingen en onderhoud op de knop **Verzoeken** in de navigator en selecteer het tabblad **Categorieën**.

1. Klik op de knop **Toevoegen**.

1. Voer een beschrijvende naam in voor de categorie in het veld **Categorienaam** boven de tabbladen.

1. Voer op het tabblad **Eigenschappen** de volgende informatie in:

    * **Intern of extern**: Als u **Intern** inschakelt, zal de categorie niet zichtbaar zijn in SuperOffice Customer Centre.

    * **Externe naam**: hier voert u de categorienaam in die aan de klant wordt getoond. Dit veld is verplicht, tenzij de categorie intern is.

    * **Subcategorie van**: als dit een subcategorie van een andere categorie moet zijn, selecteert u de bovenliggende categorie die u nodig hebt.

    * **Categoriebeheerder**: selecteer de verantwoordelijke voor de verzoeken in deze categorie. Op het tabblad **Toewijzingsmethode** kunt u opgeven dat verzoeken aan de categoriebeheerder moeten worden toegewezen wanneer andere leden van de categorie niet beschikbaar zijn. De rol van categoriebeheerder wordt normaal gesproken vervuld door een afdelingsmanager.

        * **Categorie opnemen in statusweergave**: indien ingeschakeld, wordt deze categorie weergegeven onder **Status** op het **Dashboard**.
        * **Alleen leden hebben toegang**: Als deze optie is aangevinkt, is de categorie alleen toegankelijk voor leden van de categorie.
        * **Melding over nieuw verzoek verzenden naar leden**: indien geselecteerd, zullen alle leden van de categorie een melding van de nieuwe verzoeken in deze categorie ontvangen.

    * **Melding over nieuw verzoek verzenden naar e-mailadres**: voer een e-mailadres in.

    * **Word eigenaar bij beantwoording**: indien geactiveerd, wordt de gebruiker die antwoordt op een verzoek in deze categorie, ingesteld als de eigenaar van het verzoek.

    * **Standaardstatus van nieuw verzoek**: hier kiest u de standaardstatus die wordt weergegeven in het scherm **Verzoek**. Deze instelling zal de [gebruikersvoorkeuren][1] overschrijven, tenzij u **Door gebruiker gedefinieerd** selecteert.

    * **Standaardstatus voor nieuw bericht**: hier kiest u welke standaardstatus wordt weergegeven in een nieuw bericht. Deze instelling zal de [gebruikersvoorkeuren][1] overschrijven, tenzij u **Door gebruiker gedefinieerd** selecteert.

    * **Voeg uitgaande e-mails voor deze categorie samen met een antwoordsjabloon**: Selecteer de antwoordsjabloon die u wilt gebruiken in berichten die aan klanten en anderen worden verzonden voor verzoeken die tot deze categorie behoren. Dit kan een antwoordsjabloon zijn die speciaal voor deze categorie is gemaakt om alle antwoorden van een categorie (zoals ondersteuning of boekhouding) een uniforme uitstraling te geven.

        * Selecteer de optie **Toepassen op subcategorieën** als u de geselecteerde antwoordsjabloon ook wilt gebruiken voor eventuele subcategorieën. Hierbij wordt er echter van uitgegaan dat de sjabloon niet wordt overschreven door instellingen die in de subcategorieën zijn gemaakt.

1. Op het tabblad **Leden** kunt u aangeven welke gebruikers leden van de categorie moeten worden. Selecteer een gebruiker in de lijst **Gebruiker** onderaan en klik op **Toevoegen**.

    > [!TIP]
    > wanneer u de optie **Gewogen toewijzing** hebt geselecteerd als toewijzingsmethode voor de verzoeken in deze categorie, kunt u de weging voor elke individuele gebruiker gebruiken om de toewijzing van nieuwe verzoeken te bepalen. De gebruikers met de grootste weging krijgen de meeste verzoeken toegewezen. U kunt geen gewogen toewijzing gebruiken voor categorieleden uit gebruikersgroepen.

1. Voer op het tabblad **Toewijzingsmethode** de volgende informatie in:

    * Selecteer een toewijzingstype:

        * **Evenredig**: verzoeken worden evenredig verdeeld over alle leden van de categorie.
        * **Gewogen**: verzoeken worden toegewezen op basis van het gewicht dat is toegekend aan leden van de categorie.

           Bijvoorbeeld: wanneer persoon A een weging van 1 heeft, persoon B een weging van 2 en persoon C een weging van 5, krijgt elk van deze personen bij een bereik van 8 verzoeken hetzelfde aantal verzoeken toegewezen als door hun weging wordt aangegeven.

        * **Aan gebruiker met minste aantal openstaande verzoeken**: nieuwe verzoeken worden toegewezen aan het lid van de categorie met het minste aantal openstaande verzoeken.
        * **Niet toewijzen**: de verzoeken worden niet toegewezen aan specifieke gebruikers, maar worden standaard in een wachtrij geplaatst. Onder **Verzoeken** > **Niet-toegewezen verzoeken** (standaard) of in het wachtrijsysteem **Volgend verzoek in wachtrij ophalen** (zie [Hoe 'Volgend verzoek in wachtrij ophalen' instellen][3]).

    * **Alleen toewijzen aan aangemelde gebruikers**: Verzoeken worden alleen toegewezen aan gebruikers die bij SuperOffice Service zijn aangemeld.

    * **Toewijzen aan categoriebeheerder als niemand beschikbaar is**: verzoeken worden aan de categoriebeheerder toegewezen wanneer er geen andere gebruikers beschikbaar zijn.

    * **Verzoeken opnieuw toewijzen bij nieuw bericht als gebruiker afwezig is**: verzoeken worden opnieuw toegewezen wanneer een nieuw bericht binnenkomt over een verzoek en de gebruiker niet beschikbaar is.

    * **Toewijzen aan onze servicepersoon indien beschikbaar**: wanneer het bedrijf of de persoon in kwestie een verzoekbehandelaar heeft die als **Onze contactpersoon** is aangegeven en deze gebruiker beschikbaar is, wordt het verzoek aan deze gebruiker toegewezen. Wanneer **Onze contactpersoon** niet is opgegeven of de gebruiker niet beschikbaar is, wordt het verzoek toegewezen in overeenstemming met de gebruikelijke toewijzingsregels.

    * **Exclusieve toewijzing**: Geef hier het aantal minuten op waarbinnen alle verzoeken van dezelfde klant aan een bepaalde gebruiker moeten worden toegewezen. Op die manier kunt u ervoor zorgen dat wanneer klanten twee achtereenvolgende verzoeken naar hetzelfde e-mailadres verzenden, deze verzoeken ook bij dezelfde verzoekbehandelaar terechtkomen. Wanneer u hier -1 invoert, wordt deze functie uitgeschakeld en worden alle verzoeken volgens de gebruikelijke toewijzingsregels toegewezen.

1. Klik op **Opslaan**. De categorie wordt gemaakt.

## Gerelateerde inhoud

* [Hoe 'Volgend verzoek in wachtrij ophalen' instellen][3]

<!-- Referenced links -->
[1]: ../../../admin/preferences/index.md
[3]: ../next-in-queue.md
