---
uid: help-nl-company-create
title: Een nieuw bedrijf maken
description: Stappen om een nieuw bedrijf te maken
keywords: nieuw bedrijf, bedrijf maken, bedrijfsinteresses, bedrijf
author: Bergfrid Dias
date: 03.14.2025
version: 10.5.2
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: nl
---

# Een nieuw bedrijf maken

In het **Bedrijf-scherm** kunt u bedrijven aanmaken en beheren, inclusief aangepaste velden en aanvullende gegevens. Bekijk deze [videohandleiding over het maken van een nieuw bedrijf][1].

## Stappen om een bedrijf te maken

1. Klik op **Nieuw** in de bovenste balk en selecteer **Bedrijf**.

2. Voer in het tabblad **Bedrijf** de volgende informatie in:
    * **Bedrijfsnaam** (verplicht, rood gemarkeerd).
    * **Land**. Het adresformaat wordt automatisch bijgewerkt op basis van het geselecteerde land. Uw thuisland wordt standaard geselecteerd en kan worden aangepast in **Instellingen** > **Systeem**.
    * Vul indien nodig aanvullende velden in, zoals **Postcode**, **Telefoon**, **E-mail** en **Website**.

    ![Lege bedrijfskaart met verplichte en optionele velden -screenshot][img1]

3. Kies een categorie en branche in de velden **Categorie** en **Branche**. Beide zijn verplicht om de gegevens op te slaan.

4. (Optioneel) Vul meer details in:
    * Ga naar het **Meer-tabblad** om [aangepaste velden in te voeren][12].
    * Ga naar het **Interesses-tabblad** om [interesses toe te voegen](#interests-tab).
    * Ga naar het **Opmerking-tabblad** om [notities toe te voegen][5].

5. Klik op **Opslaan** om de gegevens op te slaan.

## <a id="fields"></a>Belangrijke velden en hun betekenis

De volgende velden zijn beschikbaar op de bedrijfskaart. Sommige velden worden automatisch ingevuld, terwijl andere handmatige invoer vereisen.

> [!NOTE]
> Velden en lay-out kunnen variëren afhankelijk van [Schermontwerper][9]-instellingen en andere aanpassingen.

* **Afdeling:** Specificeer een afdeling als het bedrijf meerdere filialen of divisies heeft.
* **Adresvelden:** Worden automatisch aangepast op basis van het geselecteerde land.
* **Postcode en plaats:** Als u een postcode invoert die in de SuperOffice-database is gedefinieerd, wordt de plaats automatisch ingevuld als dit veld leeg is. U kunt ook een plaatsnaam invoeren en een postcode wordt voorgesteld.
* **Telefoon/Fax/E-mail/Website:** Voer meerdere vermeldingen in met beschrijvingen, zoals *Centrale*. Klik buiten de tabel of druk op TAB om de invoer te beëindigen.
* **Onze contactpersoon:** Uw naam wordt automatisch toegewezen. Klik op de pijl om iemand anders uit uw organisatie te kiezen.
* **Hoofdcontactpersoon:** Kies de persoon die de hoofdcontactpersoon voor deze klant moet zijn. Personen moeten eerst aan het bedrijf worden toegevoegd.
* **Code:** Wordt automatisch gegenereerd na het opslaan van het bedrijf. De code is gebaseerd op de bedrijfsnaam, maar kan handmatig worden gewijzigd.
* **Nummer:** Het eerstvolgende beschikbare bedrijfsnummer wordt automatisch toegewezen. Standaard begint dit nummer bij 10001 en wordt het met 1 verhoogd voor elk nieuw bedrijf. Deze instelling kan worden aangepast in **Instellingen en onderhoud**.
* **BTW-nr.:** Voer het BTW-nummer of een vergelijkbare identificatie van het bedrijf in.
* **Stoppen** en **Geen mailings**-selectievakjes:
  * **Stoppen:** Geeft aan dat het bedrijf bijzondere aandacht vereist. Als u **Stoppen** selecteert, wordt een stopteken weergegeven op de bedrijfskaart. U kunt ook een opmerking toevoegen om de reden te verklaren. Deze optie is alleen beschikbaar in de bewerkingsmodus.
  * **Geen mailings:** Voorkomt dat er direct mailings naar dit bedrijf worden gestuurd. Deze optie is alleen beschikbaar in de bewerkingsmodus.

[!include[3 udef](../../learn/includes/more-udef.md)]

## Duplicaten detecteren

Als u een bedrijf invoert dat lijkt op een bedrijf dat al in SuperOffice CRM staat, wordt het **Duplicaten**-dialoogvenster weergegeven. Dit helpt om [per ongeluk dubbele vermeldingen te voorkomen][2].

* Controleer de weergegeven duplicaten om gegevensconsistentie te waarborgen.
* Kies of u met de nieuwe record wilt doorgaan of naar een van de vermelde bedrijven wilt gaan.

## <a id="interests-tab"></a>Interesses toevoegen

Interesses kunnen u helpen om gerichte selecties te maken. Bijvoorbeeld, u kunt *Referentieaccount* als interesse definiëren en een selectie maken voor marketingcampagnes gericht op deze klanten.

1. Selecteer het tabblad **Interesses**.

2. Selecteer in de bewerkingsmodus de relevante selectievakjes. Beschikbare interesses worden gedefinieerd in **Instellingen en onderhoud**.

    > [!NOTE]
    > In de weergavemodus worden alleen de geselecteerde interesses weergegeven. In de bewerkingsmodus kunnen aanvullende opties zichtbaar zijn.

3. Als u een of meer interesses selecteert, verschijnt er een stip naast de naam van het tabblad **Interesses**.

    ![Het tabblad Interesses met selectievakjes voor bedrijfsinteresses -screenshot][img2]

4. Klik op **Opslaan** om de geselecteerde interesses op te slaan.

## Gerelateerde inhoud

* [Record toevoegen als een favoriet][4]
* [Dialoogvenster Voorkeuren][3] – standaardwaarden en lijstwaarden

<!-- Referenced links -->
[1]: https://community.superoffice.com/globalassets/user--admin/learning/user-guide/company--contact/add-company.mp4
[2]: ../../learn/basics/duplicates.md
[3]: ../../learn/getting-started/preferences.md
[4]: ../../learn/basics/fav.md
[5]: ../../learn/basics/notes.md
[9]: ../../customization/screen-designer/admin/index.md
[12]: ../../custom-objects/learn/more-tab.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/company/new-company.png
[img2]: ../../../media/loc/en/company/interests.png
