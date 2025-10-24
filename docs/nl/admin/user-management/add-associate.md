---
uid: help-nl-user-add
title: Gebruiker toevoegen
description: In deze handleiding leert u hoe u een nieuwe gebruiker toevoegt in SuperOffice CRM.
author: SuperOffice RnD
date: 02.21.2023
keywords: gebruiker, medewerker
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
---

# Gebruikers toevoegen

Nadat uw SuperOffice CRM-oplossing is geconfigureerd en aangepast, is het tijd om uw gebruikers toegang te geven tot hun CRM-oplossing.

Beheerders zijn verantwoordelijk voor het verstrekken van nieuwe gebruikers met een gebruikersplan, een gebruikersnaam, een wachtwoord en de gebruikersgroep waartoe de gebruiker behoort. U kunt gebruikers toevoegen aan SuperOffice CRM in Instellingen en onderhoud.

> [!NOTE]
> Als u informatie over gebruikers hebt opgegeven toen u SuperOffice CRM bestelde, hoeft u geen gebruikers toe te voegen. Gebruikers hebben aanmeldingsgegevens van SuperOffice per e-mail ontvangen. Controleer of gebruikers zich in het systeem bevinden in het menu Gebruikers in Instellingen en onderhoud.
>
> Deze procedure beschrijft hoe u één gebruiker tegelijk kunt toevoegen. Zie [Gebruikers importeren][1] om meerdere gebruikers toe te voegen.

## Stappen

1. Open het scherm Gebruikers.
2. Selecteer het tabblad **Medewerkers**.
3. Klik op de knop **Toevoegen** onder de lijst.
4. Voer de naam en het e-mailadres van de nieuwe gebruiker in het bovenste deel van de kaart in.
5. Als er meer dan één bedrijf beschikbaar is als eigenaar in uw SuperOffice-installatie, kunt u dit selecteren onder het veld **E-mail**.
6. Voer de relevante informatie in de tabbladen **Details** en **Licenties** in.

    ![Create user details -screenshot][img7]

7. Klik op **Opslaan**. De naam van de nieuwe gebruiker wordt nu weergegeven in de lijst.

    * Als actieve gebruikers een ander gebruikersplan nodig hebben, kunt u [gebruikersplannen toewijzen][4] in Instellingen en onderhoud.

    * In het onderste deel van de gebruikerskaart kunt u aanmeldrechten van de geselecteerde gebruiker activeren of deactiveren door op de knop **Kan aanmelden** te klikken. Deze optie wordt standaard geactiveerd wanneer u een gebruikersplan voor de gebruiker selecteert.

## <a id="fields"></a>Belangrijke velden uitgelegd

<!-- markdownlint-disable-file MD051 -->
### [Het tabblad Details](#tab/details)

Het tabblad **Details** bevat de volgende opties:

* **Gebruikers-ID**: Bewerk in het veld **Gebruikers-ID** de voorgestelde ID voor de gebruiker (als u de automatisch gegenereerde ID niet wilt gebruiken). U kunt geen gebruikers-ID opgeven die al bestaat in de database. Er gelden geen beperkingen op de tekens die in de gebruikers-ID kunnen worden gebruikt.

    > [!NOTE]
    > De gebruikers-ID mag niet teveel tekens bevatten, aangezien deze wordt weergegeven in de ID-kolommen in SuperOffice CRM en de ruimte in deze kolommen mogelijk beperkt is.

* **Bijnaam**: De bijnaam is de naam die zichtbaar is voor andere gebruikers van SuperOffice en wordt alleen gebruikt voor gebruikers van SuperOffice Service. U kunt de voorgestelde bijnaam voor de gebruiker bewerken (als u de automatisch gegenereerde naam niet wilt gebruiken).

* **Verificatie**: als er meerdere verificatiemethoden beschikbaar zijn, kunt u hier een verificatiemethode selecteren.

* **Gebruikersnaam**: voer de gebruikersnaam van SuperOffice in. Dit moet dezelfde naam zijn als in het systeem van uw identiteitsprovider (als u Office 365 of Gmail gebruikt voor verificatie). Wanneer u SuperOffice gebruikt voor authenticatie, vult u gewoon uw e-mailadres in. Zorg ervoor dat het e-mailadres geldig is, omdat dit wordt gebruikt voor accountbevestiging.

* **Rol**: Selecteer de [rol][3] voor de gebruiker in de keuzelijst **Rol**. De rol bepaalt de gegevenstoegang en functionele rechten van de gebruiker. U kunt uw eigen rol niet wijzigen.

* **Gebruikersplan**: Selecteer het relevante gebruikersplan voor de gebruiker. Dit bepaalt welke SuperOffice-functies de gebruiker kan openen.

* **Voormalige werknemer**: Als een gebruiker geen toegang meer heeft tot SuperOffice, selecteert u deze optie om het gebruikersplan en de aanmeldingsrechten van de gebruiker te verwijderen.

* **Primaire groep**: Selecteer een van de vooraf gedefinieerde opties voor groepslidmaatschap in de keuzelijst **Primaire groep**. Deze personen kunnen worden gedefinieerd in het scherm **Lijsten**. De gebruiker krijgt toegang tot gegevens die het eigendom zijn van andere gebruikers in dezelfde primaire groep. Toegangsrechten (bijvoorbeeld schrijf- en verwijdertoegang) tot deze gegevens worden gedefinieerd in de [rol][3] waartoe de gebruiker behoort. Zie [Zichtbaarheid][2] voor meer informatie over het delen van gegevens met uw primaire groep.

* **Andere groepen**: Klik in het veld **Andere groepen** en selecteer tot welke andere groepen de gebruiker behoort. Als de lijst veel groepen bevat, begint u met het typen van een groepsnaam in het zoekveld om de lijst te filteren.

* **Service-categorieën**: Deze categorieën worden gebruikt om gebruikers toegang te geven tot specifieke verzoekcategorieën.

* **Service-categorieën van gebruikersgroepen**: Geeft de categorieën weer die de gebruiker ontvangt binnen een gebruikersgroep.

### Voorbeeld

[!include[Example](includes/example-grouping.md)]

### [Het tabblad Licenties](#tab/license)

In het tabblad **Licenties** kunt u extra licenties selecteren, naast de licenties die zijn gedefinieerd via het geselecteerde gebruikersplan.

**Vertrouwelijke activiteiten**: schakelt de lijst **Zichtbaar voor** in voor vervolgactiviteiten, documenten en verkoop, om [records zichtbaar te maken voor alleen][2] de gebruiker, de primaire groep van de gebruiker, of iedereen.

***

## Video: Een nieuwe SuperOffice CRM-gebruiker toevoegen

Bekijk deze demo om te zien hoe u een nieuwe gebruiker kunt toevoegen in SuperOffice CRM.
(Deze video toont een eerdere versie van SuperOffice, dus het ontwerp kan er anders uitzien. De stappen zijn hetzelfde.)

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/oLlfTrCAqCU]

(videolengte - 1:46)

## Gerelateerde inhoud

* [Anonieme gebruikers of systeemgebruikers toevoegen (lokaal)][5]
* [Gebruiker / medewerker bewerken][6]'

<!-- Referenced links -->
[1]: onsite/import-users.md
[2]: index.md#visible
[3]: role/index.md
[4]: ../../license/change-user-plan.md
[5]: other-users.md
[6]:  update-user.md

<!-- Referenced images -->
[img7]: ../../../../media/loc/en/admin/selected-user-plan.png
