---
uid: help-nl-service-settings-system-settings
title: SuperOffice Service-systeeminstellingen
description: Algemene voorkeuren voor SuperOffice Service-systeeminstellingen
keywords: Service instellingen, systeeminstellingen, Algemene voorkeuren
author: digitaldiina
date: 10.17.2025
version: 11.5
content_type: reference
category: Settings and maintenance
topic: preferences
license: serviceessentials
functional_right: Service administration, General Administrator
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: nl
redirect_from: /nl/admin/preferences/learn/global-preferences/settings
---

# Algemene voorkeuren voor SuperOffice Service-systeeminstellingen

Ga naar <i class="ph ph-gear" aria-hidden="true"></i> **Voorkeuren** in de navigator en selecteer het tabblad **Algemene voorkeuren**. De sectie voor **SuperOffice Service-systeeminstellingen** bevat de volgende opties:

* **Standaardlettertype in editor**: Selecteer welk lettertype, welke lettergrootte en welke opmaak standaard worden gebruikt voor berichtregistratie.

* **Standaardlettertypegrootte**: Grootte van het standaardlettertype in de Verzoekeditor.

* **Standaardlettertypegewicht**: Gewicht (dikte) van het standaardlettertype in de Verzoekeditor.

* **E-mailmelding sturen voor openstaande verzoeken**: Geeft aan of een e-mailbericht over openstaande verzoeken wordt verzonden naar de gebruikers. Als u **Gebruiker mag kiezen** selecteert, kunnen gebruikers de e-mailmelding inschakelen en uitschakelen in <i class="ph ph-user-circle" aria-hidden="true"></i> **Persoonlijke instellingen** > **Voorkeuren** > **Melding via e-mail & SMS**.

* **Nieuwe status bij acceptatie verzoek**: Selecteer welke status wordt gebruikt wanneer een verzoek wordt geaccepteerd door een gebruiker.

* **Aantal dagen voor melding**: Geeft het aantal dagen aan dat moet verstrijken voordat via e-mail een melding naar de gebruikers wordt verzonden over oude verzoeken. U kunt ook het tijdstip van de dag instellen waarop de melding moet worden verzonden.

* **Tijdstip van dag**: Tijdstip van dag voor verzenden van meldingen.

* **Systeembeheerder**: Het e-mailadres van de persoon die verantwoordelijk is voor het functioneren van SuperOffice Service. Dit moet een e-mailadres zijn dat niet door SuperOffice Service is geïmporteerd/verwerkt.

* **Standaard Van-adres**: Het standaard afzenderadres van de e-mail van het systeem. Dit adres wordt meestal vervangen door de adressen die in de postbussen zijn ingevoerd. Dit moet een e-mailadres zijn dat in SuperOffice Service is geïmporteerd. Bijvoorbeeld, `<support@company.com>`.

* **E-mailcode**: De e-mailcode die, samen met de verzoek-ID, wordt gebruikt om een unieke sleutel te maken voor de onderwerpregel van e-mailberichten die vanuit SuperOffice Service worden verstuurd. Deze waarde mag alleen worden gewijzigd wanneer u exact weet wat voor gevolgen dit kan hebben! Wanneer deze waarde wordt gewijzigd, worden ontvangen e-mailberichten niet meer goed gelinkt aan bestaande verzoeken.

* **Systeemklok**: Kies de tijdnotatie 24 of 12 uur (am/pm) voor het systeem. Gebruikersspecifieke klokken (bijvoorbeeld weergave van verzoeken) worden bepaald door de instellingen van de betreffende gebruiker, niet door deze waarde.

* **Standaardstijl voor uitgaande e-mail**: Hier kunt u een standaardstijl definiëren die moet worden gebruikt voor e-mails in HTML-indeling. Bijvoorbeeld: &lt;p style='font-family:Verdana'&gt; &lt;/p&gt;

* **Minimumscore voor zoekresultaten Veelgestelde vragen (percentage)**: Iin antwoordsjablonen die aan de klanten worden verzonden, kunt u [automatische suggesties toevoegen voor items in Veelgestelde vragen][1] die de klant helpen om het verzoek zelf op te lossen. In dit veld kunt u bepalen hoe hoog de mate van correlatie moet zijn tussen het verzoek van de klant en een item in Veelgestelde vragen om een veelgestelde vraag toe te voegen aan het antwoord op de klant. Als u hier een te lage waarde definieert, is het waarschijnlijk dat de klant veel Veelgestelde vragen zal ontvangen die niet relevant zijn voor het verzoek. Indien het klantverzoek overeenkomt met een sleutelwoord in een Veelgestelde vraag, zal de Veelgestelde vraag altijd worden opgenomen.

* **Tijdsperiode voor cross-posts in minuten**: Hier voert u een aantal minuten in. Wanneer twee of meer e-mailberichten van dezelfde persoon binnen de ingestelde periode worden ontvangen, worden, indien mogelijk, de verzoeken naar dezelfde verzoekbehandelaar verzonden.

* **Anonimiseer gebruikers bij antwoord**: Indien aangevinkt, wordt de naam van de agent gemaskeerd in uitgaande communicatie.

* **Limiet (uren) voor inactiviteit van de gebruiker**: Na het opgegeven aantal uren zonder gebruikersactiviteit wordt de gebruiker als inactief beschouwd (standaard 2 uur). Dit wordt bijvoorbeeld gebruikt bij het delegeren van verzoeken.

* **Extern is standaardtoegangsniveau**: Wanneer deze optie is ingeschakeld, wordt standaard het toegangsniveau Extern gebruikt voor nieuwe verzoeken en berichten. Het is ook mogelijk Intern in te stellen als standaardtoegangsniveau.

* **Geen e-mail naar nieuwe personen verzenden**: Wanneer deze optie is ingeschakeld, worden e-mailberichten niet naar nieuw geregistreerde personen verzonden.

* **Automatisch persoon maken voor nieuw inkomend verzoek**: Als deze optie is ingeschakeld, maakt SuperOffice automatisch een nieuwe persoon als een e-mailadres niet wordt herkend in een binnenkomend verzoek. Deze optie kan worden uitgeschakeld voor GDPR-naleving.

* **Bewerken van berichten inschakelen**: Wanneer deze optie is ingeschakeld, kan de gebruiker berichten wijzigen.

* **Alle links traceren**: schakel in om alle links in mailings te traceren.

* **Interne URL**: Het basisadres voor toegang tot het SuperOffice Service-systeem. (ALLEEN ter plaatse)

* **Externe URL**: Het basisadres voor externe toegang tot het SuperOffice Service-systeem. (ALLEEN ter plaatse)

* **Cgi-bin-pad**: Het pad naar de map waar de Cgi-bin-toepassingsbestanden van SuperOffice Service zich bevinden. Dit pad moet beginnen met een slash maar mag niet eindigen met een slash. Bijvoorbeeld */bin* of */Scripts*. (ALLEEN ter plaatse)

* **Gebruikers verifiëren vanaf webserver**: Wanneer deze optie is ingeschakeld, accepteert SuperOffice Service de verificatiegegevens voor gebruikers van de webserver (Microsoft IIS). (ALLEEN ter plaatse)

* **Klanten verifiëren vanaf webserver**: Wanneer deze optie is ingeschakeld, accepteert SuperOffice Service de verificatiegegevens voor gebruikers van de webserver van het klantencentrum (Microsoft IIS). (ALLEEN ter plaatse)

* **Online op internet**: Schakel deze optie in als SuperOffice Service op internet beschikbaar is. Hiermee worden onderdelen van de beschikbare functionaliteit van SuperOffice Service aangestuurd, aangezien voor sommige functies de oplossing online moet zijn. (ALLEEN ter plaatse)

<!-- Referenced links -->
[1]: ../../knowledge-base/learn/reply-templates/create.md#faq
