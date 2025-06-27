<!-- markdownlint-disable-file MD041 MD034-->
Wanneer u een mailing maakt, moet u de ontvangers van de mailing selecteren. U kunt ontvangers uit meerdere bronnen toevoegen. Daarnaast kunt u hier verschillende mailingopties instellen en een voorbeeld van de mailing bekijken.

Uw doellijst is de groep mensen waarvan u denkt dat ze het beste op uw bericht zullen reageren. Als u uw marketingboodschap specifiek op die groep afstemt, krijgt u een betere kans op succes en voorkomt u dat u tijd en moeite verspilt aan mensen die niet geïnteresseerd zijn.

U kunt selecties, projecten gebruiken of afzonderlijke personen toevoegen in SuperOffice CRM.

Vanwege de AVG-wetgeving kunnen alleen de personen die toestemming hebben gegeven om legaal te worden opgeslagen in de SuperOffice CRM-database en informatie ontvangen, als ontvangers worden toegevoegd.

![U kunt uw ontvangers toevoegen uit selectie, project, een enkele persoon of een externe lijst die u moet importeren -screenshot][img3]

### Ontvangers toevoegen uit selecties en projecten

U kunt ontvangers toevoegen uit selecties (zowel uit SuperOffice CRM als uit SuperOffice Service) en uit projecten (uit SuperOffice CRM).

1. Bij **Ontvangers toevoegen** klikt u op **Selectie** of **Project**.

2. Klik in het veld eronder en begin in het veld eronder de naam te typen van de selectie die of het project dat u wilt toevoegen. Terwijl u typt, worden de overeenkomsten in een dynamische lijst weergegeven.

3. Klik op een selectie of project in de lijst.

4. Klik op **+**. De selectie of het project wordt toegevoegd aan de lijst **Ontvangerbronnen** en de lijst **Ontvangers** wordt bijgewerkt.

5. Herhaal stap 1-4 om meer selecties of projecten toe te voegen.

> [!NOTE]
> Als u een selectie hebt geselecteerd onder **Mailing archiveren** in **Instellingen** (stap 1), wordt deze selectie weergegeven onder **Ontvangerbronnen**. U kunt deze selectie verwijderen indien nodig.

### Personen toevoegen uit SuperOffice

U kunt individuele personen toevoegen uit SuperOffice.

1. Bij **Ontvangers toevoegen** klikt u op **Persoon**.

2. Klik op het veld eronder en begin in het veld eronder de naam te typen van de persoon die u wilt toevoegen. U kunt ook een bedrijfsnaam invoeren om alle personen voor een bedrijf weer te geven.

3. Selecteer de persoon in de lijst die wordt weergegeven.

4. Klik op **+**. De persoon wordt toegevoegd aan de lijst **Ontvangerbronnen** en de lijst **Ontvangers** wordt bijgewerkt.

5. Herhaal stap 2-5 om meer personen toe te voegen. Aanvullende personen zullen worden toegevoegd aan dezelfde rij in de lijst **Ontvangerbronnen** en het aantal personen zal worden weergegeven in de kolom **Naam**.

### Een lijst met ontvangers (personen) importeren uit een extern bestand

U kunt ontvangers toevoegen aan een mailing door deze te importeren uit een extern, door komma's gescheiden bestand (een .txt-bestand dat is gemaakt in Notepad of een .csv-bestand dat is gemaakt in Excel bijvoorbeeld).

Wanneer u een lijst met namen en e-mailadressen importeert, probeert SuperOffice Marketing de geïmporteerde ontvangers in de SuperOffice-database te vinden. Als er overeenkomsten worden gevonden, zullen de bedrijven van de ontvangers worden weergegeven in de kolom **Bedrijf** in de lijst **Ontvangers**. Alle namen/e-mailadressen die **niet** in SuperOffice worden gevonden, worden uitgefilterd en niet opgenomen in de mailing. Dit is het gevolg van de AVG-regelgeving.

#### Stappen

1. Klik op **Bestand selecteren**.

2. Zoek het desbetreffende bestand (.txt, .csv of vergelijkbare tekstindeling).

3. Klik op **+**. De lijst wordt toegevoegd aan de lijst **Ontvangerbronnen** en de lijst **Ontvangers** wordt bijgewerkt.

4. Herhaal stap 2-4 om meer ontvangers toe te voegen. Aanvullende ontvangers zullen worden toegevoegd aan dezelfde rij in de lijst **Ontvangerbronnen**. Het totaalaantal ontvangers zal worden weergegeven in de kolom **Naam**.

> [!NOTE]
> Importeren is niet beschikbaar voor documentmailings.

#### Opmaak importbestand

* elke ontvanger moet op een afzonderlijke regel staan (rij).

* Elke ontvanger (rij) bestaat uit de volledige naam en het e-mailadres.

    Bijvoorbeeld: "Henk Jansen. john@company.com"

    > [!NOTE]
    > U kunt ook alleen het e-mailadres opgeven. De naam is dan echter niet beschikbaar als een sjabloonvariabele.

* Lokaal: Elke ontvanger (rij) kan ook een mobiel telefoonnummer bevatten (na het e-mailadres) in het geval u mailings via SMS wilt maken. Bijvoorbeeld: "Henk Jansen, john@company.com, 99999999". Vereist de Marketing SMS-licentie.

> [!NOTE]
> Wanneer u alleen het mobiele telefoonnummer hebt en een SMS wilt sturen, kunt u het volgende invoeren: " , , 99887766".

### Opties voor ontvangers

U kunt bij **Opties** in het onderste deel van het scherm **Ontvangers** opties voor de mailing selecteren op basis van het type.

**Beschikbaarheid per mailingtype:**

| Optie | Document | E-mail | SMS |
|---|:-:|:-:|:-:|
| Toestemming en abonnement overschrijven | x | x | x |
| Slechts één bericht per e-mailadres | | x | x |
| Ontvangerslijst bijwerken bij verzending | | x | x |
| Neem bedrijven op | x | x | |
| Voorkeursbedrijf | x | x | |

* **Toestemming en abonnement overschrijven**: Selecteer deze optie om de mailing ook naar contactpersonen te verzenden die geen toestemming hebben gegeven om e-marketing te ontvangen of niet zijn geabonneerd op dit type mailing. Deze contactpersonen worden in de lijst **Ontvangers** weergegeven met de status **Geen toestemming**.

* **Slechts één bericht per e-mailadres**: Selecteer deze optie om dubbele e-mailadressen in de ontvangerslijst te verwijderen (aangegeven door **Duplicaat** in de kolom **Status**). De lijst **Ontvangers** wordt bijgewerkt.

* **Ontvangerslijst bijwerken bij verzending**: selecteer deze optie om automatisch de ontvangerslijst bij te werken voordat de mailing wordt verzonden. Zie **Ontvangerslijst bijwerken** hieronder.

* **Neem bedrijven op**: selecteer deze optie om bedrijven op te nemen als ontvangers.

    > [!NOTE]
    > Als een bedrijf geen e-mailadres heeft, wordt de mailing in plaats daarvan verzonden naar alle gerelateerde personen in de lijst met geadresseerden.

* **Voorkeursbedrijf**: Selecteer deze optie om de mailing alleen naar de bedrijven in de lijst met ontvangers te verzenden (en niet naar de gerelateerde personen). Elk bedrijf ontvangt slechts één mailing. Personen die niet tot een bedrijf behoren, ontvangen nog steeds de mailing.

    > [!NOTE]
    > De optie **Voorkeursbedrijf** is alleen beschikbaar als u hierboven **Bedrijven opnemen** hebt geselecteerd.

### Voorbeeldweergave van de mailing bekijken

Nadat u ontvangers hebt toegevoegd aan de lijst **Ontvangers**, kunt u een voorbeeldweergave van de mailing bekijken om te zien hoe de mailing er voor een ontvanger uitziet. Voorbeeldweergave is niet beschikbaar voor document- en SMS-mailings.

> [!NOTE]
> De mailing wordt **niet** verzonden naar de ontvanger tijdens de voorbeeldweergave.

1. Klik op een ontvanger in de lijst **Ontvangers**.

2. Klik op de knop **Afdrukvoorbeeld**. Het venster **Afdrukvoorbeeld** geeft de mailing weer zoals deze eruit zal zien voor de geselecteerde ontvanger. Alle sjabloonvariabelen (bijvoorbeeld naam en bedrijf) worden vervangen door werkelijke contactgegevens.

3. Klik op de koppelingen om te controleren of deze werken, maar vergeet niet om de koppelingen opnieuw in te stellen als deze worden getraceerd.

4. Klik op X om het het venster **Voorbeeldweergave** te sluiten.

### Lijst met ontvangers controleren en bijwerken

Wanneer u selecties, projecten, contactpersonen en importlijsten toevoegt, wordt de lijst **Ontvangers** automatisch bijgewerkt. Als u **Lijst met ontvangers bijwerken** hebt geselecteerd tijdens het verzenden, worden de projecten en selecties gecontroleerd voordat de mailing wordt verzonden, als contactpersonen zijn toegevoegd, verwijderd of bewerkt.

Daarnaast kunt u klikken op de knop **Lijst bijwerken** onder de lijst **Ontvangers** om de lijst handmatig bij te werken. Sommige personen op de lijst hebben inmiddels mogelijk hun toestemming gewijzigd nadat u ze hebt toegevoegd.

> [!NOTE]
> De lijst geeft alleen de eerste 50 ontvangers weer. Klik op **Alles laden** onder aan de lijst om alle ontvangers weer te geven.

Klik op **Volgende** om naar stap 5 te gaan: Bevestigen. U kunt nog altijd teruggaan naar de stap **Ontvangers** om de lijst met ontvangers te bewerken.

<!-- Referenced images -->
[img3]: ../../../../../../media/loc/en/marketing/add-target-list.png
