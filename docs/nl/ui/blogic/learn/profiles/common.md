---
uid: help-nl-service-profile-common
title: Algemene profielen
description: Algemene profielen
author: SuperOffice RnD
date: 06.29.2022
keywords: profiel, service
content_type: howto
language: nl
---

# Algemene profielen

[!include[Legacy](../includes/legacy-profiles.md)]

Algemene profielen zijn gekoppeld aan een [rol][2] en gelden van toepassing voor alle gebruikers die deze rol hebben. U configureert algemene profielen in het scherm **Profielen weergeven**.

## Profieltypen

* **Systeem**: deze profielen kunt u configureren door de onderstaande procedure te volgen.
* **Systeemschermen**: Een lijst met schermen die zijn gemaakt via de module [Systeemontwerp][1] in SuperOffice Service. U kunt deze veranderen als u toegang hebt tot **Systeemontwerp** > **Schermen**.

## <a id="create"></a>Algemene profielen maken

In de volgende stappen ziet u bijvoorbeeld hoe u een veld toevoegt in het scherm **Verzoeken zoeken**.

1. Selecteer **Systeeminstellingen** > **Profiel**. Het scherm **Profielen weergeven** wordt geopend.
2. Klik op **Systeem**. Er wordt een hiërarchische lijst met alle profielen in het systeem weergegeven.
3. Klik op **Zoek**.
4. Plaats de cursor op **Verzoeken zoeken** en klik op <i class="ph ph-list" aria-label="Main menu"></i> (**Nieuw algemeen profiel**) rechts van de naam. Het scherm **Elementprofiel bewerken** wordt geopend.
5. Voer in het veld **Naam** de naam van het profiel in.
6. Klik op de knop **Criteria toevoegen**.
7. Ga in het dialoogvenster als volgt te werk:
    * **Typ hier het label voor het veld**: Voer de veldnaam in.
    * **Veld kiezen**: Selecteer uit welk veld in de database u gegevens wilt ophalen.
8. Klik op **OK**. Het nieuwe criterium wordt onder de andere criteria toegevoegd.
9. Klik op **OK**. Het nieuwe profiel wordt gemaakt. U kunt dit nu bijvoorbeeld [koppelen aan een specifieke rol][3].

## Informatie in een gemeenschappelijk profiel bewerken

1. Selecteer **Systeeminstellingen** > **Profiel**. Het scherm **Profielen weergeven** wordt geopend.
2. Klik op **Systeem**. Er wordt een hiërarchische lijst met alle profielen in het systeem weergegeven.
3. Ga naar een gedetailleerder niveau in de hiërarchie totdat u het gewenste profiel hebt gevonden.
4. Klik op de profielnaam. Het scherm **Elementprofiel bewerken** wordt geopend.
5. Breng de gewenste wijzigingen aan.
6. Klik op **OK**. De wijzigingen worden opgeslagen.

## Eem gemeenschappelijk profiel verwijderen

1. Selecteer **Systeeminstellingen** > **Profiel**. Het scherm **Profielen weergeven** wordt geopend.
2. Klik op **Systeem**. Er wordt een hiërarchische lijst met alle profielen in het systeem weergegeven.
3. Ga naar een gedetailleerder niveau in de hiërarchie totdat u het gewenste profiel hebt gevonden.
4. Klik op de profielnaam. Het scherm **Elementprofiel bewerken** wordt geopend.
5. Klik op de knop **Standaardwaarden herstellen (dit profiel wordt verwijderd)** onder in het scherm. Het profiel wordt verwijderd.

## Gerelateerde inhoud

* [Persoonlijke profielen][4]
* [Globale profielen][5]

<!-- Referenced links -->
[1]: ../screen-properties.md
[2]: ../../../../admin/user-management/role/index.md
[3]: ../../../../admin/user-management/role/create-role.md
[4]: personal.md
[5]: global.md
